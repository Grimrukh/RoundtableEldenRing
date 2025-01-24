using PropertyHook;
using RoundtableBase.Memory;

namespace RoundtableEldenRing.Memory;


public enum HandedStyle
{
    EmptyHanded = 0,
    OneHanded = 1,
    LeftTwoHanded = 2,
    RightTwoHanded = 3,
}


public enum WeaponSlot
{
    Primary = 0,
    Secondary = 1,
    Tertiary = 2,
}


public class ChrAsm(PHPointer pointer) : RTPointer(pointer)
{
    static class Offsets
    {
        public const int HandedStyle = 0x328;  // HandedStyle
        public const int CurrentLeftWeaponSlot = 0x32C;  // WeaponSlot
        public const int CurrentRightWeaponSlot = 0x330;  // WeaponSlot
        public const int CurrentLeftArrowSlot = 0x334;  // WeaponSlot
        public const int CurrentRightArrowSlot = 0x338;  // WeaponSlot
        public const int CurrentLeftBoltSlot = 0x33C;  // WeaponSlot
        public const int CurrentRightBoltSlot = 0x340;  // WeaponSlot

        public const int PrimaryLeftWeapon = 0x39C;  // int
        public const int PrimaryRightWeapon = 0x3A0;  // int
        public const int SecondaryLeftWeapon = 0x3A4;  // int
        public const int SecondaryRightWeapon = 0x3A8;  // int
        public const int TertiaryLeftWeapon = 0x3AC;  // int
        public const int TertiaryRightWeapon = 0x3B0;  // int
        public const int PrimaryArrow = 0x3B4;  // int
        public const int PrimaryBolt = 0x3B8;  // int
        public const int SecondaryArrow = 0x3BC;  // int
        public const int SecondaryBolt = 0x3C0;  // int
        // public const int TertiaryArrow = 0x3C4;
        // public const int TertiaryBolt = 0x3C8;
        public const int Helm = 0x3CC;  // int
        public const int Chest = 0x3D0;  // int
        public const int Gauntlets = 0x3D4;  // int
        public const int Leggings = 0x3D8;  // int
        public const int Hair = 0x3DC;  // int
        public const int Talisman1 = 0x3E0;  // int
        public const int Talisman2 = 0x3E4;  // int
        public const int Talisman3 = 0x3E8;  // int
        public const int Talisman4 = 0x3EC;  // int
        // public const int Talisman5 = 0x3F0;
    }
    
    public HandedStyle HandedStyle
    {
        get => (HandedStyle)Pointer.ReadInt32(Offsets.HandedStyle);
        set => WriteInt32(Offsets.HandedStyle, (int)value);
    }
    
    public WeaponSlot CurrentLeftWeaponSlot
    {
        get => (WeaponSlot)Pointer.ReadInt32(Offsets.CurrentLeftWeaponSlot);
        set => WriteInt32(Offsets.CurrentLeftWeaponSlot, (int)value);
    }
    
    public WeaponSlot CurrentRightWeaponSlot
    {
        get => (WeaponSlot)Pointer.ReadInt32(Offsets.CurrentRightWeaponSlot);
        set => WriteInt32(Offsets.CurrentRightWeaponSlot, (int)value);
    }
    
    public WeaponSlot CurrentLeftArrowSlot
    {
        get => (WeaponSlot)Pointer.ReadInt32(Offsets.CurrentLeftArrowSlot);
        set => WriteInt32(Offsets.CurrentLeftArrowSlot, (int)value);
    }
    
    public WeaponSlot CurrentRightArrowSlot
    {
        get => (WeaponSlot)Pointer.ReadInt32(Offsets.CurrentRightArrowSlot);
        set => WriteInt32(Offsets.CurrentRightArrowSlot, (int)value);
    }
    
    public WeaponSlot CurrentLeftBoltSlot
    {
        get => (WeaponSlot)Pointer.ReadInt32(Offsets.CurrentLeftBoltSlot);
        set => WriteInt32(Offsets.CurrentLeftBoltSlot, (int)value);
    }
    
    public WeaponSlot CurrentRightBoltSlot
    {
        get => (WeaponSlot)Pointer.ReadInt32(Offsets.CurrentRightBoltSlot);
        set => WriteInt32(Offsets.CurrentRightBoltSlot, (int)value);
    }
    
    public int PrimaryLeftWeapon
    {
        get => ReadInt32(Offsets.PrimaryLeftWeapon);
        set => WriteInt32(Offsets.PrimaryLeftWeapon, value);
    }
    
    public int PrimaryRightWeapon
    {
        get => ReadInt32(Offsets.PrimaryRightWeapon);
        set => WriteInt32(Offsets.PrimaryRightWeapon, value);
    }
    
    public int SecondaryLeftWeapon
    {
        get => ReadInt32(Offsets.SecondaryLeftWeapon);
        set => WriteInt32(Offsets.SecondaryLeftWeapon, value);
    }
    
    public int SecondaryRightWeapon
    {
        get => ReadInt32(Offsets.SecondaryRightWeapon);
        set => WriteInt32(Offsets.SecondaryRightWeapon, value);
    }
    
    public int TertiaryLeftWeapon
    {
        get => ReadInt32(Offsets.TertiaryLeftWeapon);
        set => WriteInt32(Offsets.TertiaryLeftWeapon, value);
    }
    
    public int TertiaryRightWeapon
    {
        get => ReadInt32(Offsets.TertiaryRightWeapon);
        set => WriteInt32(Offsets.TertiaryRightWeapon, value);
    }
    
    public int PrimaryArrow
    {
        get => ReadInt32(Offsets.PrimaryArrow);
        set => WriteInt32(Offsets.PrimaryArrow, value);
    }
    
    public int PrimaryBolt
    {
        get => ReadInt32(Offsets.PrimaryBolt);
        set => WriteInt32(Offsets.PrimaryBolt, value);
    }
    
    public int SecondaryArrow
    {
        get => ReadInt32(Offsets.SecondaryArrow);
        set => WriteInt32(Offsets.SecondaryArrow, value);
    }
    
    public int SecondaryBolt
    {
        get => ReadInt32(Offsets.SecondaryBolt);
        set => WriteInt32(Offsets.SecondaryBolt, value);
    }
    
    public int Helm
    {
        get => ReadInt32(Offsets.Helm);
        set => WriteInt32(Offsets.Helm, value);
    }
    
    public int Chest
    {
        get => ReadInt32(Offsets.Chest);
        set => WriteInt32(Offsets.Chest, value);
    }
    
    public int Gauntlets
    {
        get => ReadInt32(Offsets.Gauntlets);
        set => WriteInt32(Offsets.Gauntlets, value);
    }
    
    public int Leggings
    {
        get => ReadInt32(Offsets.Leggings);
        set => WriteInt32(Offsets.Leggings, value);
    }
    
    public int Hair
    {
        get => ReadInt32(Offsets.Hair);
        set => WriteInt32(Offsets.Hair, value);
    }
    
    public int Talisman1
    {
        get => ReadInt32(Offsets.Talisman1);
        set => WriteInt32(Offsets.Talisman1, value);
    }
    
    public int Talisman2
    {
        get => ReadInt32(Offsets.Talisman2);
        set => WriteInt32(Offsets.Talisman2, value);
    }
    
    public int Talisman3
    {
        get => ReadInt32(Offsets.Talisman3);
        set => WriteInt32(Offsets.Talisman3, value);
    }
    
    public int Talisman4
    {
        get => ReadInt32(Offsets.Talisman4);
        set => WriteInt32(Offsets.Talisman4, value);
    }
    
    #region Shortcuts

    public int EquippedRightHandWeapon
    {
        get
        {
            return CurrentRightWeaponSlot switch
            {
                WeaponSlot.Primary => PrimaryRightWeapon,
                WeaponSlot.Secondary => SecondaryRightWeapon,
                WeaponSlot.Tertiary => TertiaryRightWeapon,
                _ => -1,
            };
        }
        set
        {
            switch (CurrentRightWeaponSlot)
            {
                case WeaponSlot.Primary:
                    PrimaryRightWeapon = value;
                    break;
                case WeaponSlot.Secondary:
                    SecondaryRightWeapon = value;
                    break;
                case WeaponSlot.Tertiary:
                    TertiaryRightWeapon = value;
                    break;
            }
        }
    }
    
    public int EquippedLeftHandWeapon
    {
        get
        {
            return CurrentLeftWeaponSlot switch
            {
                WeaponSlot.Primary => PrimaryLeftWeapon,
                WeaponSlot.Secondary => SecondaryLeftWeapon,
                WeaponSlot.Tertiary => TertiaryLeftWeapon,
                _ => -1,
            };
        }
        set
        {
            switch (CurrentLeftWeaponSlot)
            {
                case WeaponSlot.Primary:
                    PrimaryLeftWeapon = value;
                    break;
                case WeaponSlot.Secondary:
                    SecondaryLeftWeapon = value;
                    break;
                case WeaponSlot.Tertiary:
                    TertiaryLeftWeapon = value;
                    break;
            }
        }
    }
    
    #endregion
}
