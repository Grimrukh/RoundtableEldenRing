namespace EldenRingBase.Events;


public enum OnRestBehavior
{
    ContinueOnRest = 0,
    RestartOnRest = 1,
    EndOnRest = 2,
}

public enum AIStatusType
{
    Normal = 0,
    Caution = 1,
    Search = 2,
    Battle = 3,
    Unknown4 = 4,
    Unknown5 = 5,
    Unknown6 = 6,
}

public enum ArenaMatchType
{
    Duel = 0,
    TwoPlayerBrawl = 1,
    FourPlayerBrawl = 2,
    SixPlayerBrawl = 3,
    OneVersusOne = 4,
    TwoVersusTwo = 5,
    ThreeVersusThree = 6,
}

public enum ArenaResult
{
    Win = 0,
    Draw = 1,
}

public enum BitOperation
{
    Add = 0,
    Delete = 1,
    Invert = 2,
}

public enum BossMusicState
{
    NormalFadeOut = -2,
    LongFadeOut = -1,
    Start = 0,
    HeatUp = 1,
}

public enum ButtonType
{
    Yes_or_No = 0,
    OK_or_Cancel = 1,
}

public enum CharacterType
{
    Alive = 0,
    WhitePhantom = 1,
    BlackPhantom = 2,
    Unknown3 = 3,
    Unknown4 = 4,
    Unknown5 = 5,
    Unknown6 = 6,
    Unknown7 = 7,
    GrayPhantom = 8,
    Invader = 15,
    Invader2 = 16,
    BluePhantom = 17,
    Invader3 = 18,
}

public enum CharacterUpdateRate
{
    Never = -1,
    Always = 0,
    EveryTwoFrames = 2,
    EveryFiveFrames = 5,
    AtLeastEveryTwoFrames = 102,
    AtLeastEveryFiveFrames = 105,
}

public enum ClassType
{
    Vagabond = 0,
    Warrior = 1,
    Hero = 2,
    Bandit = 3,
    Astrologer = 4,
    Prophet = 5,
    Confessor = 6,
    Samurai = 7,
    Prisoner = 8,
    Wretch = 9,
}

public enum ComparisonType
{
    Equal = 0,
    NotEqual = 1,
    GreaterThan = 2,
    LessThan = 3,
    GreaterThanOrEqual = 4,
    LessThanOrEqual = 5,
}

public enum CutsceneFlags
{
    Unskippable = 2,
    FadeOut = 8,
    Unknown16 = 16,
    Unknown32 = 32,
    IsEndingCutscene = 64,
}

public enum DamageTargetType
{
    Character = 1,
    Map = 2,
    Character_and_Map = 3,
}

public enum EventReturnType
{
    End = 0,
    Restart = 1,
}

public enum FlagSetting
{
    Off = 0,
    On = 1,
    Change = 2,
}

public enum FlagType
{
    Absolute = 0,
    RelativeToThisEvent = 1,
    RelativeToThisEventSlot = 2,
}

public enum InterpolationState
{
    Interpolated = 0,
    NotInterpolated = 1,
}

public enum ItemType
{
    Weapon = 0,
    Armor = 1,
    Talisman = 2,
    Good = 3,
    AshOfWar = 4,
}

public enum RangeState
{
    AllOn = 0,
    AllOff = 1,
    AnyOn = 2,
    AnyOff = 3,
}

public enum CoordEntityType
{
    Asset = 0,
    Region = 1,
    Character = 2,
}

public enum NavmeshType
{
    Default = 0,
    Disable = 1,
    Gate = 2,
    Obstacle = 4,
    Drop = 8,
    Degenerate = 16,
    DropAdjacent = 32,
    LandingPoint = 64,
    Event = 128,
    Edge = 256,
    LargeSpace = 512,
    Ladder = 1024,
    Hole = 2048,
    Door = 4096,
    ClosedDoor = 8192,
    MapExit = 16384,
    InsideWall = 32768,
}

public enum NumberButtons
{
    OneButton = 1,
    TwoButton = 2,
    NoButton = 6,
}

public enum OnOffChange
{
    On = 0,
    Off = 1,
    Change = 2,
}

public enum SummonSignType
{
    WhiteSign = 0,
    BlackSign = 1,
    RedSign = 2,
    NPCWhiteSign = 20,
}

public enum SoundType
{
    a_Ambient = 0,
    c_CharacterMotion = 1,
    f_MenuEffect = 2,
    o_Object = 3,
    p_Cutscene = 4,
    s_SFX = 5,
    m_Music = 6,
    v_Voice = 7,
    x_FloorMaterialDependent = 8,
    b_ArmorMaterialDependent = 9,
    g_Ghost = 10,
    unk_GeometrySet = 14,
}

public enum StatueType
{
    Stone = 0,
    Crystal = 1,
}

public enum TriggerAttribute
{
    Session = 1,
    NoSession = 2,
    Host = 4,
    Client = 8,
    Human = 16,
    Hollow = 32,
    WhitePhantom = 64,
    BlackPhantom = 128,
    All = 255,
}

public enum UpdateAuthority
{
    Normal = 0,
    Forced = 8192,
}

public enum ArmorType
{
    Head = 0,
    Body = 1,
    Arms = 2,
    Legs = 3,
}

public enum BannerType
{
    YouDied = 2,
    HostVanquished = 5,
    BloodyFingerVanquished = 7,
    LostGraceDiscovered = 13,
    Unknown14 = 14,
    LegendFelled = 15,
    DemigodFelled = 16,
    GreatEnemyFelled = 17,
    EnemyFelled = 18,
    DutyFulfilled = 20,
    MapFound = 22,
    GreatRuneRestored = 26,
    GodSlain = 27,
    DuelistVanquished = 28,
    RecusantVanquished = 29,
    InvaderVanquished = 30,
    Commence = 31,
    Stalemate = 32,
    Victory = 33,
    Defeat = 34,
}

public enum CalculationType
{
    Add = 0,
    Subtract = 1,
    Multiply = 2,
    Divide = 3,
    Modulus = 4,
    Assign = 5,
}

public enum ClientType
{
    Coop = 0,
    Invader = 1,
    BetrayalInvader = 2,
}

public enum ConditionGroup
{
    OR_15 = -15,
    OR_14 = -14,
    OR_13 = -13,
    OR_12 = -12,
    OR_11 = -11,
    OR_10 = -10,
    OR_9 = -9,
    OR_8 = -8,
    OR_7 = -7,
    OR_6 = -6,
    OR_5 = -5,
    OR_4 = -4,
    OR_3 = -3,
    OR_2 = -2,
    OR_1 = -1,
    MAIN = 0,
    AND_1 = 1,
    AND_2 = 2,
    AND_3 = 3,
    AND_4 = 4,
    AND_5 = 5,
    AND_6 = 6,
    AND_7 = 7,
    AND_8 = 8,
    AND_9 = 9,
    AND_10 = 10,
    AND_11 = 11,
    AND_12 = 12,
    AND_13 = 13,
    AND_14 = 14,
    AND_15 = 15,
}

public enum DamageType
{
    Unspecified = 0,
    Fire = 1,
    Magic = 2,
    Lightning = 3,
    Blunt = 4,
    Slash = 5,
    Thrust = 6,
    NoType = 7,
    AllPhysical = 8,
}

public enum DeleteOrAdd
{
    Delete = 0,
    Add = 1,
}

public enum DialogResult
{
    Cancel = 0,
    Left = 1,
    Right = 2,
    Leave = 3,
}

public enum DisplayState
{
    Hide = 0,
    Display = 1,
}

public enum DoorState
{
    DoorClosed = 0,
    DoorOpen = 1,
    DoorClosing = 2,
    DoorOpening = 3,
}

public enum Gender
{
    Male = 0,
    Female = 1,
}

public enum Label
{
    L0 = 0,
    L1 = 1,
    L2 = 2,
    L3 = 3,
    L4 = 4,
    L5 = 5,
    L6 = 6,
    L7 = 7,
    L8 = 8,
    L9 = 9,
    L10 = 10,
    L11 = 11,
    L12 = 12,
    L13 = 13,
    L14 = 14,
    L15 = 15,
    L16 = 16,
    L17 = 17,
    L18 = 18,
    L19 = 19,
    L20 = 20,
}

public enum MultiplayerState
{
    Host = 0,
    Client = 1,
    Multiplayer = 2,
    MultiplayerPending = 3,
    Singleplayer = 4,
    Invasion = 5,
    InvasionPending = 6,
}

public enum NPCPartType
{
    Part1 = 1,
    Part2 = 2,
    Part3 = 3,
    Part4 = 4,
    Part5 = 5,
    Part6 = 6,
    Part7 = 7,
    Part8 = 8,
    Part9 = 9,
    Part10 = 10,
    Part11 = 11,
    Part12 = 12,
    Part13 = 13,
    Part14 = 14,
    Part15 = 15,
    Part16 = 16,
    Part17 = 17,
    Part18 = 18,
    Part19 = 19,
    Part20 = 20,
    Part21 = 21,
    Part22 = 22,
    Part23 = 23,
    Part24 = 24,
    Part25 = 25,
    Part26 = 26,
    Part27 = 27,
    Part28 = 28,
    Part29 = 29,
    Part30 = 30,
    WeakPoint = 31,
}

public enum SingleplayerSummonSignType
{
    NormalCoop = 0,
    ScriptedInvasion = 1,
    ScriptedInvasionWideArea = 2,
}

// NOTE: `TeamType` is in its own file.

public enum Weather
{
    Null = -1,
    Default = 0,
    Rain = 1,
    Snow = 2,
    WindyRain = 3,
    Fog = 4,
    Cloudless = 5,
    FlatClouds = 6,
    PuffyClouds = 7,
    RainyClouds = 8,
    WindyFog = 9,
    HeavySnow = 10,
    HeavyFog = 11,
    WindyPuffyClouds = 12,
    Default2 = 13,
    Default3 = 14,
    RainyHeavyFog = 15,
    SnowyHeavyFog = 16,
    ScatteredRain = 17,
    Unknown18 = 18,
    Unknown19 = 19,
    Unknown20 = 20,
    Unknown21 = 21,
    Unknown22 = 22,
    Unknown23 = 23,
}
