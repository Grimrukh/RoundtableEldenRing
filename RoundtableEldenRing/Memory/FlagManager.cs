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

    /// <summary>
    /// Set many event flags at once, in as few memory calls as possible: the flag block pointer is resolved once, the
    /// flag bytes are read in a few spans (flags at most `MaxSpanGap` bytes apart share one read), and only the bytes
    /// that actually change are written back. `SetEventFlag` costs ~7 memory calls per flag, which took most of a
    /// minute for ~1,000 flags while other threads were also reading game memory. Returns the number of flags whose
    /// state changed.
    /// </summary>
    public int SetEventFlags(IEnumerable<uint> flags, bool state)
    {
        if (!FlagsAvailable)
        {
            Logging.Error("Event Flag pointer is not valid; cannot set event flags.");
            return 0;
        }
        IntPtr flagBlocksOffset = EventFlagMan.ReadIntPtr(0x28);
        IntPtr handle = Hook.Process.Handle;

        SortedDictionary<int, byte> masksByAddress = new();
        foreach (uint flag in flags)
        {
            (int address, byte mask)? addressMask = GetFlagAddressMask((int)flag, "set");
            if (addressMask == null)
                continue;
            (int address, byte mask) = addressMask.Value;
            masksByAddress[address] = (byte)(masksByAddress.GetValueOrDefault(address) | mask);
        }

        return SetFlagBits(handle, flagBlocksOffset, masksByAddress, state);
    }

    /// <summary>
    /// Set (or clear) the `mask` bits of each byte at `flagBlocksOffset + address` in `handle`'s process, reading and
    /// writing in spans as described in `SetEventFlags`. Public for testing. Returns the number of bits changed.
    /// </summary>
    public static int SetFlagBits(
        IntPtr handle, IntPtr flagBlocksOffset, IReadOnlyDictionary<int, byte> masksByAddress, bool state)
    {
        int changed = 0;
        List<(int address, byte mask)> span = [];
        foreach ((int address, byte mask) in masksByAddress.OrderBy(kv => kv.Key))
        {
            if (span.Count > 0 && address - span[^1].address > MaxSpanGap)
            {
                changed += SetFlagSpan(handle, flagBlocksOffset, span, state);
                span.Clear();
            }
            span.Add((address, mask));
        }
        if (span.Count > 0)
            changed += SetFlagSpan(handle, flagBlocksOffset, span, state);
        return changed;
    }

    /// <summary>Flags whose bytes are at most this far apart are read in one call (one memory page).</summary>
    const int MaxSpanGap = 0x1000;

    /// <summary>
    /// Read the bytes from the first to the last address of `span` in one call, then write only the changed bytes
    /// (consecutive ones together). Falls back to one byte at a time if the span can't be read.
    /// </summary>
    static int SetFlagSpan(IntPtr handle, IntPtr flagBlocksOffset, List<(int address, byte mask)> span, bool state)
    {
        int start = span[0].address;
        int length = span[^1].address - start + 1;
        byte[] bytes = new byte[length];
        if (!Kernel32.ReadProcessMemory(handle, flagBlocksOffset + start, bytes, (IntPtr)length, out IntPtr read)
            || read != (IntPtr)length)
        {
            Logging.Warning($"Could not read event flag bytes {start:X}+{length:X}; setting them one at a time.");
            int count = 0;
            foreach ((int address, byte mask) in span)
            {
                byte flagByte = Kernel32.ReadByte(handle, flagBlocksOffset + address);
                byte newByte = state ? (byte)(flagByte | mask) : (byte)(flagByte & ~mask);
                if (newByte == flagByte)
                    continue;
                Kernel32.WriteByte(handle, flagBlocksOffset + address, newByte);
                count += BitCount((byte)(newByte ^ flagByte));
            }
            return count;
        }

        // New values of the bytes that change, in address order.
        List<(int address, byte value)> changes = [];
        int changedFlags = 0;
        foreach ((int address, byte mask) in span)
        {
            byte flagByte = bytes[address - start];
            byte newByte = state ? (byte)(flagByte | mask) : (byte)(flagByte & ~mask);
            if (newByte == flagByte)
                continue;
            changes.Add((address, newByte));
            changedFlags += BitCount((byte)(newByte ^ flagByte));
        }

        int i = 0;
        while (i < changes.Count)
        {
            int j = i;
            while (j + 1 < changes.Count && changes[j + 1].address == changes[j].address + 1)
                j++;
            byte[] run = changes.GetRange(i, j - i + 1).Select(c => c.value).ToArray();
            Kernel32.WriteBytes(handle, flagBlocksOffset + changes[i].address, run);
            i = j + 1;
        }
        return changedFlags;
    }

    static int BitCount(byte b) => System.Numerics.BitOperations.PopCount(b);

    public void Enable(uint flag) => SetEventFlag(flag, true);
    public void Disable(uint flag) => SetEventFlag(flag, false);
}