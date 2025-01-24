using PropertyHook;
using RoundtableBase;

namespace RoundtableEldenRing.Memory;

public class FlagManager
{
    EldenRingHook Hook { get; }
    
    PHPointer EventFlagMan { get; }

    public bool FlagsAvailable => EventFlagMan.IsNonZero && EventFlagMan.ReadIntPtr(0x28) != IntPtr.Zero;

    public FlagManager(EldenRingHook hook)
    {
        Hook = hook;
        EventFlagMan = Hook.RegisterRelativeAOB_3_7(CoreOffsets.EventFlagManAoB, 0x0);
    }

    public bool IsEventFlag(uint flag)
    {
        if (!FlagsAvailable)
        {
            Logging.Error("Event Flag pointer is not valid; cannot check event flag.");
            return false;
        }

        IntPtr flagBlocksOffset = EventFlagMan.ReadIntPtr(0x28);
        (int address, byte mask)? addressMask = GetFlagAddressMask((int)flag, "check");
        if (addressMask == null)
            return false;
        
        (int address, byte mask) = addressMask.Value;
        IntPtr flagAddress = flagBlocksOffset + address;
        
        try
        {
            byte flagByte = Kernel32.ReadByte(Hook.Process.Handle, flagAddress);
            return (flagByte & mask) != 0;
        }
        catch (Exception ex)
        {
            Logging.Error($"Failed to read event flag {flag} at {flagAddress:X}. Error: {ex.Message}");
            return false;
        }
    }
    
    public void SetEventFlag(uint flag, bool state)
    {
        if (!FlagsAvailable)
        {
            Logging.Error("Event Flag pointer is not valid; cannot set event flag.");
            return;
        }

        IntPtr flagBlocksOffset = EventFlagMan.ReadIntPtr(0x28);
        (int address, byte mask)? addressMask = GetFlagAddressMask((int)flag, "set");
        if (addressMask == null)
            return;
        
        (int address, byte mask) = addressMask.Value;
        IntPtr flagAddress = flagBlocksOffset + address;
        
        try
        {
            byte flagByte = Kernel32.ReadByte(Hook.Process.Handle, flagAddress);
            if (state)
                flagByte |= mask;
            else
                flagByte &= (byte)~mask;
            Kernel32.WriteByte(Hook.Process.Handle, flagAddress, flagByte);
        }
        catch (Exception ex)
        {
            Logging.Error($"Failed to read and/or set event flag {flag} at {flagAddress:X}. Error: {ex.Message}");
        }
    }
    
    /// <summary>
    /// Read a 32-bit unsigned integer starting at the flag address.
    ///
    /// Bits are read directly; no endianess conversion is performed. The first flag is the most significant bit.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public uint? ReadUInt32AtFlag(uint flag)
    {
        if (!FlagsAvailable)
        {
            Logging.Error("Event Flag pointer is not valid; cannot read uint32 from event flags.");
            return null;
        }
        
        uint mapOffset = flag % 10000;
        if (mapOffset > 3000 - 32)
        {
            Logging.Error(
                $"Cannot read uint32 from event flag: {flag}. uint32 bounds must be within map flags [0000, 2999].");
            return null;
        }

        IntPtr flagBlocksOffset = EventFlagMan.ReadIntPtr(0x28);
        (int address, byte _)? addressMask = GetFlagAddressMask((int)flag, "check");
        if (addressMask == null)
            return null;
        
        // We don't need the bit mask.
        (int address, byte _) = addressMask.Value;
        IntPtr flagAddress = flagBlocksOffset + address;
        
        try
        {
            return Kernel32.ReadUInt32(Hook.Process.Handle, flagAddress);
        }
        catch (Exception ex)
        {
            Logging.Error($"Failed to read uint32 starting at event flag {flag} at {flagAddress:X}. Error: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Write a 32-bit unsigned integer starting at the flag address.
    /// </summary>
    /// <param name="flag"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public void WriteUInt32AtFlag(uint flag, uint value)
    {
        if (!FlagsAvailable)
        {
            Logging.Error("Event Flag pointer is not valid; cannot write uint32 to event flags.");
            return;
        }
        
        uint mapOffset = flag % 10000;
        if (mapOffset > 3000 - 32)
        {
            Logging.Error(
                $"Cannot write uint32 to event flag: {flag}. uint32 bounds must be within map flags [0000, 2999].");
            return;
        }

        IntPtr flagBlocksOffset = EventFlagMan.ReadIntPtr(0x28);
        (int address, byte _)? addressMask = GetFlagAddressMask((int)flag, "check");
        if (addressMask == null)
            return;
        
        // We don't need the bit mask.
        (int address, byte _) = addressMask.Value;
        IntPtr flagAddress = flagBlocksOffset + address;
        
        try
        {
            Kernel32.WriteUInt32(Hook.Process.Handle, flagAddress, value);
        }
        catch (Exception ex)
        {
            Logging.Error($"Failed to write uint32 starting at event flag {flag} at {flagAddress:X}. Error: {ex.Message}");
        }
    }

    static (int address, byte mask)? GetFlagAddressMask(int flag, string operation)
    {
        // Special cases. TODO: More general, e.g. 61XXX
        if (flag <= 10000)
        {
            int lowAddress = flag / 8;
            byte lowMask = (byte)(0b10000000 >> (flag % 8));  // earliest flag is closest to memory start ("big endian")
            return (lowAddress, lowMask);
        }
        
        int mapOffset = flag % 10000;
        if (mapOffset > 3000 || flag < 10000000 || flag >= 1100000000)
        {
            Logging.Error($"Cannot {operation} event flag: {flag}. Only map/overworld flags ending in 0000-2999.");
            return null;
        }
        
        // Parse flag into map stem to get base address.
        string flagStr = flag.ToString();
        MapStem mapStem;
        if (flagStr.Length == 10 && flagStr[..2] == "10")
        {
            // Overworld.
            int tileX = int.Parse(flagStr[2..4]);
            int tileZ = int.Parse(flagStr[4..6]);
            mapStem = new MapStem($"m60_{tileX:D2}_{tileZ:D2}_02");
        }
        else if (flagStr.Length == 8)
        {
            // Dungeon.
            int area = int.Parse(flagStr[..2]);
            int block = int.Parse(flagStr[2..4]);
            mapStem = new MapStem($"m{area:D2}_{block:D2}_00_00");
        }
        else
        {
            Logging.Error($"Cannot {operation} event flag: {flag}. Must be eight digits (dungeon) or ten digits " +
                               $"starting with 10 (Overworld).");
            return null;
        }

        int baseOffset = mapStem.BaseEventFlagOffset;
        if (baseOffset == -1)
        {
            Logging.Error($"Cannot {operation} event flag: {flag}. Must be 8 (dungeon) or 10 (overworld) digits in " +
                               $"a recognized Elden Ring map. {mapStem} is not recognized.");
            return null;
        }
        
        int address = baseOffset + mapOffset / 8;
        byte mask = (byte)(0b10000000 >> (mapOffset % 8));  // earliest flag is closest to memory start ("big endian")
        return (address, mask);
    }

    public void Enable(uint flag) => SetEventFlag(flag, true);
    public void Disable(uint flag) => SetEventFlag(flag, false);
}