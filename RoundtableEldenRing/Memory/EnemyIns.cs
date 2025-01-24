using System.Numerics;
using System.Text;
using PropertyHook;
using RoundtableBase.Memory;

namespace RoundtableEldenRing.Memory;

/// <summary>
/// Wrapper for an `EnemyIns` struct pointer in memory.
/// </summary>
public class EnemyIns : RTPointer
{
    static class Offsets
    {
        public const int LocalHandle = 0x8;
        public const int OwnerMap = 0xC;  // byte[4]
        public const int EnemyCtrl = 0x58;  // IntPtr
        public const int NpcParamID = 0x60;  // int
        public const int ModelNumber = 0x64;  // int
        public const int ChrType = 0x68;  // int
        public const int TeamType = 0x6C;  // byte
        public const int GlobalHandle = 0x74;  // short
        public const int EntityID = 0x1E8;  // int
        public const int ActiveSpEffectList = 0x178;  // IntPtr
        public const int ModuleBase = 0x190;  // IntPtr

        // TODO: Only ChrAsm for model zero; some other struct for other models.
        //  For now, validated by asserting `ModelNumber == 0`.
        public const int ChrAsm = 0x580;  // IntPtr

        // Only valid for Player.
        public const int PlayerLocalPositionX = 0x6C0;  // float
        public const int PlayerLocalPositionY = 0x6C4;  // float
        public const int PlayerLocalPositionZ = 0x6C8;  // float
        public const int RotationY = 0x6CC;  // float; local and global are the same
    }

    public EnemyInsModuleBaseStruct ModuleBase { get; }

    public EnemyIns(PHPointer pointer) : base(pointer)
    {
        ModuleBase = new EnemyInsModuleBaseStruct(CreateChildPointer(Offsets.ModuleBase));
    }
    
    public int LocalHandle => ReadInt32(Offsets.LocalHandle);
    /// <summary>
    /// Four bytes (AA, BB, CC, DD), packed in reverse order, representing the map stem containing the enemy.
    /// </summary>
    public byte[] OwnerMap => ReadBytes(Offsets.OwnerMap, 4).Reverse().ToArray();
    public IntPtr EnemyCtrl => ReadIntPtr(Offsets.EnemyCtrl);
    public int NpcParamID => ReadInt32(Offsets.NpcParamID);
    public int ModelNumber => ReadInt32(Offsets.ModelNumber);
    public int ChrType => ReadInt32(Offsets.ChrType);
    public byte TeamType => ReadByte(Offsets.TeamType);
    public short GlobalHandle => ReadInt16(Offsets.GlobalHandle);
    public uint EntityID => ReadUInt32(Offsets.EntityID);
    
    // ChrAsm, only accessible for model c0000 (0). Null otherwise.
    // TODO: Non-model 0 have some other struct at this address. (Not just junk, as they have the same first pointer.)
    public ChrAsm? ChrAsm => ModelNumber == 0 ? new ChrAsm(CreateChildPointer(Offsets.ChrAsm)) : null;
    
    // NOTE: Setting these has no effect, as they are computed. Only valid for Player.
    public float PlayerLocalPositionX => ReadSingle(Offsets.PlayerLocalPositionX);
    public float PlayerLocalPositionY => ReadSingle(Offsets.PlayerLocalPositionY);
    public float PlayerLocalPositionZ => ReadSingle(Offsets.PlayerLocalPositionZ);
        
    /// <summary>
    /// Readonly position in current map coordinates (i.e. correct for this map's MSB).
    ///
    /// Only valid for player.
    /// </summary>
    public Vector3 PlayerLocalPosition => new(PlayerLocalPositionX, PlayerLocalPositionY, PlayerLocalPositionZ);

    /// <summary>
    /// True local position of enemy in current map coordinates (i.e. correct for this map's MSB).
    ///
    /// NOT valid for player.
    /// </summary>
    public Vector3 EnemyLocalPosition => ModuleBase.PhysicsData.RelativePosition;
    public float RotationRadY => ReadSingle(Offsets.RotationY);
    public float RotationDegY => 180f / MathF.PI * ReadSingle(Offsets.RotationY);

    // Nested but common attributes.
    public string Name => ModuleBase.EnemyData.Name;
    public string ModelName => ModuleBase.EnemyData.ModelName;

    public int CurrentHP
    {
        get => ModuleBase.EnemyData.CurrentHP;
        set => ModuleBase.EnemyData.CurrentHP = value;
    }

    public int MaxHP => ModuleBase.EnemyData.MaxHP;
    
    public MapStem? MapStem
    {
        get
        {
            try
            {
                return new MapStem(OwnerMap);
            }
            catch (FormatException)
            {
                return null;
            }
        }
    }

    public bool IsInMap(MapStem mapStem)
    {
        MapStem? stem = MapStem;
        return mapStem == stem;
    }
    
    /// <summary>
    /// Traverse the linked list of active SpEffects and return a list of their IDs.
    ///
    /// Note that changing the IDs of these active SpEffects does not seem to do anything in cases I've tried! It should
    /// be used for monitoring only.
    /// </summary>
    /// <returns></returns>
    public List<int> GetActiveSpEffects()
    {
        PHPointer spEffectList = CreateChildPointer(Offsets.ActiveSpEffectList);
        PHPointer currentEffect = spEffectList.CreateChildPointer(0x8);
        List<int> effects = [];

        while (currentEffect.Resolve() != IntPtr.Zero)
        {
            // Linked list of active SpEffects. Offset 0x8 is the ID, and offset 0x30 is the pointer to the next effect
            // (which will be zero if this is the final effect).
            int effectID = currentEffect.ReadInt32(0x8);
            effects.Add(effectID);
            currentEffect = currentEffect.CreateChildPointer(0x30);
        }
        return effects;
    }
}

public class EnemyInsModuleBaseStruct : RTPointer
{
    static class Offsets
    {
        public const int EnemyData = 0x0;  // IntPtr
        public static readonly int[] CurrentAnimation = [0x18, 0x40];  // int
        public static readonly int[] AnimationSpeed = [0x28, 0x17C8];  // float
        public const int ResistanceData = 0x20;  // IntPtr
        public const int PoiseData = 0x40;  // IntPtr
        public const int PhysicsData = 0x68;  // IntPtr
        public const int ActionRequest = 0x88;  // IntPtr
    }
    
    public EnemyDataStruct EnemyData { get; }

    public ResistanceDataStruct ResistanceData { get; }
    
    public PoiseDataStruct PoiseData { get; }

    public PhysicsDataStruct PhysicsData { get; }
    
    public PHPointer CurrentAnimationPointer { get; }
    public PHPointer AnimationSpeedPointer { get; }

    public EnemyInsModuleBaseStruct(PHPointer pointer) : base(pointer)
    {
        EnemyData = new EnemyDataStruct(CreateChildPointer(Offsets.EnemyData));
        ResistanceData = new ResistanceDataStruct(CreateChildPointer(Offsets.ResistanceData));
        PoiseData = new PoiseDataStruct(CreateChildPointer(Offsets.PoiseData));
        PhysicsData = new PhysicsDataStruct(CreateChildPointer(Offsets.PhysicsData));
        CurrentAnimationPointer = CreateChildPointer(Offsets.CurrentAnimation[..^1]);
        AnimationSpeedPointer = CreateChildPointer(Offsets.AnimationSpeed[..^1]);
    }

    public int CurrentAnimation => CurrentAnimationPointer.ReadInt32(Offsets.CurrentAnimation[^1]);

    public float AnimationSpeed
    {
        get => AnimationSpeedPointer.ReadSingle(Offsets.AnimationSpeed[^1]);
        set => AnimationSpeedPointer.WriteSingle(Offsets.AnimationSpeed[^1], value);
    }
}


public class EnemyDataStruct(PHPointer pointer) : RTPointer(pointer)
{
    static class Offsets
    {
        public const int ModelName = 0xC8;  // UnicodeString[16]
        public const int CurrentHP = 0x138;  // int
        public const int MaxHP = 0x140;  // int
        public const int BaseHP = 0x144;  // int
        public const int CurrentFP = 0x148;  // int
        public const int MaxFP = 0x14C;  // int
        public const int BaseFP = 0x150;  // int
        public const int CurrentStamina = 0x154;  // int
        public const int MaxStamina = 0x158;  // int
        public const int BaseStamina = 0x15C;  // int
        public const int Name = 0x1A0;  // UnicodeString[20]
    }
        
    public string ModelName => ReadString(Offsets.ModelName, Encoding.Unicode, 16);
    public int CurrentHP
    {
        get => ReadInt32(Offsets.CurrentHP);
        set => WriteInt32(Offsets.CurrentHP, value);
    }
    public int MaxHP => ReadInt32(Offsets.MaxHP);
    public int BaseHP => ReadInt32(Offsets.BaseHP);
    public int CurrentFP => ReadInt32(Offsets.CurrentFP);
    public int MaxFP => ReadInt32(Offsets.MaxFP);
    public int BaseFP => ReadInt32(Offsets.BaseFP);
    public int CurrentStamina => ReadInt32(Offsets.CurrentStamina);
    public int MaxStamina => ReadInt32(Offsets.MaxStamina);
    public int BaseStamina => ReadInt32(Offsets.BaseStamina);
    public string Name => ReadString(Offsets.Name, Encoding.Unicode, 80);
}


public class ResistanceDataStruct(PHPointer pointer) : RTPointer(pointer)
{
    static class Offsets
    {
        public const int Poison = 0x10; // int
        public const int Rot = 0x14; // int
        public const int Bleed = 0x18; // int
        public const int Blight = 0x1C; // int
        public const int Frost = 0x20; // int
        public const int Sleep = 0x24; // int
        public const int Madness = 0x28; // int
        public const int PoisonMax = 0x2C; // int
        public const int RotMax = 0x30; // int
        public const int BleedMax = 0x34; // int
        public const int BlightMax = 0x38; // int
        public const int FrostMax = 0x3C; // int
        public const int SleepMax = 0x40; // int
        public const int MadnessMax = 0x44; // int
        public const int PoisonMod = 0x80; // float
        public const int RotMod = 0x84; // float
        public const int BleedMod = 0x88; // float
        public const int BlightMod = 0x8C; // float
        public const int FrostMod = 0x90; // float
        public const int SleepMod = 0x94; // float
        public const int MadnessMod = 0x98; // float
        public const int PoisonMul = 0x9C; // float
        public const int RotMul = 0xA0; // float
        public const int BleedMul = 0xA4; // float
        public const int BlightMul = 0xA8; // float
        public const int FrostMul = 0xAC; // float
        public const int SleepMul = 0xB0; // float
        public const int MadnessMul = 0xB4; // float
    }
    
    public int Poison => ReadInt32(Offsets.Poison);
    public int Rot => ReadInt32(Offsets.Rot);
    public int Bleed => ReadInt32(Offsets.Bleed);
    public int Blight => ReadInt32(Offsets.Blight);
    public int Frost => ReadInt32(Offsets.Frost);
    public int Sleep => ReadInt32(Offsets.Sleep);
    public int Madness => ReadInt32(Offsets.Madness);

    public int PoisonMax => ReadInt32(Offsets.PoisonMax);
    public int RotMax => ReadInt32(Offsets.RotMax);
    public int BleedMax => ReadInt32(Offsets.BleedMax);
    public int BlightMax => ReadInt32(Offsets.BlightMax);
    public int FrostMax => ReadInt32(Offsets.FrostMax);
    public int SleepMax => ReadInt32(Offsets.SleepMax);
    public int MadnessMax => ReadInt32(Offsets.MadnessMax);

    public float PoisonMod => ReadSingle(Offsets.PoisonMod);
    public float RotMod => ReadSingle(Offsets.RotMod);
    public float BleedMod => ReadSingle(Offsets.BleedMod);
    public float BlightMod => ReadSingle(Offsets.BlightMod);
    public float FrostMod => ReadSingle(Offsets.FrostMod);
    public float SleepMod => ReadSingle(Offsets.SleepMod);
    public float MadnessMod => ReadSingle(Offsets.MadnessMod);
    
    public float PoisonMul => ReadSingle(Offsets.PoisonMul);
    public float RotMul => ReadSingle(Offsets.RotMul);
    public float BleedMul => ReadSingle(Offsets.BleedMul);
    public float BlightMul => ReadSingle(Offsets.BlightMul);
    public float FrostMul => ReadSingle(Offsets.FrostMul);
    public float SleepMul => ReadSingle(Offsets.SleepMul);
    public float MadnessMul => ReadSingle(Offsets.MadnessMul);
}


public class PoiseDataStruct(PHPointer pointer) : RTPointer(pointer)
{
    static class Offsets
    {
        public const int Poise = 0x10;  // float
        public const int PoiseMax = 0x14;  // float
        public const int PoiseResetTimer = 0x1C;  // float
    }
    
    public float Poise => ReadSingle(Offsets.Poise);
    public float PoiseMax => ReadSingle(Offsets.PoiseMax);
    public float PoiseResetTimer => ReadSingle(Offsets.PoiseResetTimer);
}


public class PhysicsDataStruct(PHPointer pointer) : RTPointer(pointer)
{
    static class Offsets
    {
        public const int RotationY = 0x54;  // float
        public const int RelativePositionX = 0x70;  // float
        public const int RelativePositionY = 0x74;  // float
        public const int RelativePositionZ = 0x78;  // float
    }

    /// <summary>
    /// NOTE: 'Local' and 'global' rotation are always the same.
    /// </summary>
    public float RotationY
    {
        get => ReadSingle(Offsets.RotationY);
        set => WriteSingle(Offsets.RotationY, value);
    }

    public float RelativePositionX
    {
        get => ReadSingle(Offsets.RelativePositionX);
        set => WriteSingle(Offsets.RelativePositionX, value);
    }

    public float RelativePositionY
    {
        get => ReadSingle(Offsets.RelativePositionY);
        set => WriteSingle(Offsets.RelativePositionY, value);
    }

    public float RelativePositionZ
    {
        get => ReadSingle(Offsets.RelativePositionZ);
        set => WriteSingle(Offsets.RelativePositionZ, value);
    }

    /// <summary>
    /// Relative to some other position, not sure what. Not super useful.
    /// </summary>
    public Vector3 RelativePosition
    {
        get => new(RelativePositionX, RelativePositionY, RelativePositionZ);
        set => (RelativePositionX, RelativePositionY, RelativePositionZ) = (value.X, value.Y, value.Z);
    }
}