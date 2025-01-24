using PropertyHook;
using RoundtableBase.Memory;

namespace RoundtableEldenRing.GameHook;

public class EldenRingHook : BaseGameHook
{
    // Hard-coded offset. TODO: Could be game version dependent. Apparently used to be 0x18468.
    // This offset stores the pointer to the `PlayerInsPointer` struct, not the start of the struct itself.
    // This is definitely still valid as of 1.16.
    public const int PlayerInsPointerOffset = 0x10EF8;
    
    // Various high-level pointers.
    public PHPointer WorldChrMan { get; }
    public PHPointer GameDataMan { get; }
    public PHPointer MapItemMan { get; }
    public PHPointer SoloParamRepository { get; }
    public PHPointer FieldArea { get; }
    
    /// <summary>
    /// Used to check if game is loaded.
    /// </summary>
    public PHPointer PlayerInsPointer { get; }

    public EldenRingHook(int refreshInterval, int minLifetime) : base(refreshInterval, minLifetime, "ELDEN RING™")
    {
        WorldChrMan = RegisterRelativeAOB_3_7(CoreOffsets.WorldChrManAoB, 0x0);
        GameDataMan = RegisterRelativeAOB_3_7(CoreOffsets.GameDataManAoB, 0x0);
        MapItemMan = RegisterRelativeAOB_3_7(CoreOffsets.MapItemManAoB, 0x0);
        SoloParamRepository = RegisterRelativeAOB_3_7(CoreOffsets.SoloParamRepositoryAoB, 0x0);
        FieldArea = RegisterRelativeAOB_3_7(CoreOffsets.FieldAreaAoB, 0x0);

        // Note that this is missing the extra offset 0 that would have it point to the start of the actual PlayerInsPointer.
        // This allows
        PlayerInsPointer = WorldChrMan.CreateChildPointer(PlayerInsPointerOffset);
    }

    protected override bool CheckIsGameLoaded()
    {
        // Check if the game is loaded by checking if the PlayerInsPointer pointer is valid.
        return PlayerInsPointer.IsNonZero;
    }

    /// <summary>
    /// Current NG+ level of Elden Ring.
    ///
    /// NOTE: Setting this beyond 7 has no additional effect. The game's difficulty stops increasing after NG+7.
    /// </summary>
    public uint NewGamePlusLevel
    {
        get => GameDataMan.ReadUInt32(0x120);
        set => GameDataMan.WriteUInt32(0x120, value);
    }
}