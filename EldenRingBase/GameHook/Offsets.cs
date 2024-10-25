﻿
using System.Diagnostics.CodeAnalysis;

namespace EldenRingBase.GameHook;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public static class Offsets
{
    public const int IsLoadedOffset1 = 0x320;
    public const int IsLoadedOffset2 = 0xC8;
    public const int IsLoadedOffset3 = 0xC0;
    public const int IsLoadedOffset4 = 0x100;
    public const int IsLoaded = 0x48;

    public const string GameDataManAoB = "48 8B 05 ? ? ? ? 48 85 C0 74 05 48 8B 40 58 C3 C3";
    public const string GameManAoB = "48 8B 05 ? ? ? ? 80 B8 ? ? ? ? 0D 0F 94 C0 C3";

    public enum GameMan
    {
        LastGrace = 0xB30,
    }

    public enum GameDataMan
    {
        ClassWhereTheNameIsStored = 0x8,
    }

    public enum ClassWhereTheNameIsStored
    {
        Name = 0x9C,
    }

    public const int PlayerGameData = 0x8;
    public enum PlayerGameDataStruct
    {
        MaximumNormalItems = 0x414,
        InventoryCount = 0x420,
        MaximumSpecialItems = 0x424,
        InventoryLength = 0x488,
        HeldNormalItems = 0x450,
        HeldSpecialItems = 0x460,
    }
    public enum ChrIns
    {
        ArmStyle = 0x328,
        CurrWepSlotOffsetLeft = 0x32C,
        CurrWepSlotOffsetRight = 0x330,
        LHandWeapon1 = 0x39C,
        LHandWeapon2 = 0x3A4,
        LHandWeapon3 = 0x3AC,
        RHandWeapon1 = 0x3A0,
        RHandWeapon2 = 0x3A8,
        RHandWeapon3 = 0x3B0,
        Arrow1 = 0x3B4,
        Bolt1 = 0x3B8,
        Arrow2 = 0x3BC,
        Bolt2 = 0x3C0,
    }

    public enum Player
    {
        Level = 0x68,
    }

    public const string SoloParamRepositoryAoB = "48 8B 0D ? ? ? ? 48 85 C9 0F 84 ? ? ? ? 45 33 C0 BA 8E 00 00 00";
    public const string CapParamCallAoB = "48 8B C4 55 41 56 41 57 48 8D 68 A1 48 81 EC A0 00 00 00 48 C7 45 E7 FE FF FF FF 48 89 58 08 48 89 70 10";
        
    public const string FieldAreaAoB = "48 8B 0D ? ? ? ? 48 ? ? ? 44 0F B6 61 ? E8 ? ? ? ? 48 63 87 ? ? ? ? 48 ? ? ? 48 85 C0";

    public enum Param
    {
        TotalParamLength = 0x0,
        NameOffset = 0x10,
        TableLength = 0x30,
    }

    public enum EquipParamGem
    {
        SwordArtsParamId = 0x18,
        ConfigurableWepAttr = 0x30,
        CanMountWep_Dagger = 0x38,
        CanMountWep_SwordPierce = 0x39,
        CanMountWep_SpearLarge = 0x3A,
        CanMountWep_BowSmall = 0x3B,
        CanMountWep_ShieldSmall = 0x3C,
        IsDiscard = 0x34,
        Default_WepAttr = 0x35,
    }
    public enum EquipParamAccessory
    {
        IsDeposit = 0x40,
    }
    public enum EquipParamGoods
    {
        MaxNum = 0x3A,
        IsFullSuppleItem = 0x4A,
        IsDrop = 0x6F,
    }
    public enum EquipParamProtector
    {
        IsDiscard = 0xE3,
    }
    public enum EquipParamWeapon
    {
        SortID = 0x8,
        MaterialSetID = 0x5C,
        OriginEquipWep = 0x60,
        IconID = 0xBE,
        ReinforceTypeID = 0xDA,
        BaseChangeCategory = 0x108,
        DisableMultiDropShare = 0x109,
        SwordArtsParamId = 0x198,
        WepType = 0x1A6,
        MaxArrowQuantity = 0x235,
        OriginEquipWep16 = 0x250,
    }

    public const string ItemGiveAoB = "8B 02 83 F8 0A";
    //public const string ItemGiveAoB = "40 55 56 57 41 54 41 55 41 56 41 57 48 8D 6C 24 B0 48 81 EC 50 01 00 00 48 C7 45 C0 FE FF FF FF";
    public const string MapItemManAoB = "48 8B 0D ? ? ? ? C7 44 24 50 FF FF FF FF C7 45 A0 FF FF FF FF 48 85 C9 75 2E";
    public const int ItemGiveOffset = -0x52;

    public const int ItemInfoArraySize = 0xA0;

    public enum ItemGiveStruct
    {
        ItemStructHeaderSize = 0x24,
        ItemStructEntrySize = 0x10,
        Count = 0x20,
        ID = 0x24,
        Quantity = 0x28,
        Gem = 0x30,
    }

    public const int EquipInventoryDataOffset = 0x5B8;
    public const int PlayerInventoryOffset = 0x10;
    public const int PlayInventoryEntrySize = 0x14;

    public enum InventoryEntry
    {
        GaItemHandle = 0x0,
        ItemID = 0x4,
        ItemCategory = 0x7,
        Quantity = 0x8,
        DispalyID = 0xC,
        Unk = 0x10,
    }

    public const string EventFlagManAoB = "48 8B 3D ? ? ? ? 48 85 FF ? ? 32 C0 E9";
    
    public const string EventFlagsBase = "44 89 7C 24 28 4C 8B 25";

    public const string WorldChrManAoB = "48 8B 05 ? ? ? ? 48 85 C0 74 0F 48 39 88";

    public enum ActionRequest
    {
        CurrentAnimation = 0x90,
    }

    public enum PlayerIns
    {
        TargetHandle = 0x6A0,
        TargetArea = 0x6A4,
    }


    public const string DisableOpenMapAoB = "74 ? C7 45 38 58 02 00 00 C7 45 3C 02 00 00 00 C7 45 40 01 00 00 00 48 ? ? ? ? ? ? 48 89 45 48 48 8D 4D 38 E8 ? ? ? ? E9";
    public const string CombatCloseMapAoB = "E8 ? ? ? ? 84 C0 75 ? 38 83 ? ? ? ? 75 ? 83 E7 FE";
    public const string WorldAreaWeatherAoB = "48 8B 15 ? ? ? ? 32 C0 48 85 D2 ? ? 8B 82";

    public enum WorldAreaWeather
    {
        ForceWeatherParamID = 0x2,
        WeatherParamID = 0x2A,
        ResetWeather = 0x88,
    }

    public const string CSFD4VirtualMemoryFlagAoB = "48 8B 3D ? ? ? ? 48 85 FF 74 ? 48 8B 49";
    public const string CSLuaEventManagerAoB = "48 83 3D ? ? ? ? 00 48 8B F9 0F 84 ? ? ? ? 48";
    public const string LuaWarp_01AoB = "C3 ? ? ? ? ? ? 57 48 83 EC ? 48 8B FA 44";

}