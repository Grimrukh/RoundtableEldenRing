﻿using PropertyHook;
using EldenRingBase.GameHook;

namespace EldenRingBase.Events;

public class FlagManager(EldenRingHook hook)
{
    EldenRingHook Hook { get; } = hook;

    public bool IsEventFlag(uint flag)
    {
        if (!Hook.FlagsAvailable)
        {
            Logging.ErrorPrint("Event Flag pointer is not valid; cannot check event flag.");
            return false;
        }

        IntPtr flagBlocksOffset = Hook.EventFlagMan.ReadIntPtr(0x28);
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
            Logging.ErrorPrint($"Failed to read event flag {flag} at {flagAddress:X}. Error: {ex.Message}");
            return false;
        }
    }
    
    public void SetEventFlag(uint flag, bool state)
    {
        if (!Hook.FlagsAvailable)
        {
            Logging.ErrorPrint("Event Flag pointer is not valid; cannot set event flag.");
            return;
        }

        IntPtr flagBlocksOffset = Hook.EventFlagMan.ReadIntPtr(0x28);
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
            Logging.ErrorPrint($"Failed to read and/or set event flag {flag} at {flagAddress:X}. Error: {ex.Message}");
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
            Logging.ErrorPrint($"Cannot {operation} event flag: {flag}. Only map/overworld flags ending in 0000-2999.");
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
            Logging.ErrorPrint($"Cannot {operation} event flag: {flag}. Must be eight digits (dungeon) or ten digits " +
                               $"starting with 10 (Overworld).");
            return null;
        }

        int baseOffset = mapStem.BaseEventFlagOffset;
        if (baseOffset == -1)
        {
            Logging.ErrorPrint($"Cannot {operation} event flag: {flag}. Must be 8 (dungeon) or 10 (overworld) digits in " +
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