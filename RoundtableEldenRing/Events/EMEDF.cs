using static SoulsFormats.EMEVD;

namespace RoundtableEldenRing.Events;


/// <summary>
/// Soulstruct-generated class for Elden Ring EMEVD instructions.
/// </summary>
public static class EMEDF
{
    
    /// <summary>
    /// Run a local event ID with given slot and arguments.
    /// </summary>
    public static Instruction RunEvent(int slot, uint eventID, params object[] args)
    {
        if (args.Length == 0)
            return new Instruction(2000, 0, slot, eventID, 0);
        object[] allArgs = new object[2 + args.Length];
        allArgs[0] = slot;
        allArgs[1] = eventID;
        for (int i = 0; i < args.Length; i++)
            allArgs[i + 2] = args[i];
        return new Instruction(2000, 0, allArgs);
    }
    
    /// <summary>
    /// Run a CommonFunc event ID with given slot and arguments.
    /// </summary>
    public static Instruction RunCommonEvent(int slot, uint eventID, params object[] args)
    {
        if (args.Length == 0)
            return new Instruction(2000, 6, slot, eventID, 0);
        object[] allArgs = new object[2 + args.Length];
        allArgs[0] = slot;
        allArgs[1] = eventID;
        for (int i = 0; i < args.Length; i++)
            allArgs[i + 2] = args[i];
        return new Instruction(2000, 6, allArgs);
    }
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfConditionState(ConditionGroup condition, byte state, ConditionGroup inputCondition)
        => new(0, 0, (sbyte)condition, state, (sbyte)inputCondition);
    
    /// <summary>
    /// Calls `IfConditionState` with `state=True`.
    /// </summary>
    public static Instruction IfConditionTrue(ConditionGroup condition, ConditionGroup inputCondition)
        => IfConditionState(condition, 1, inputCondition);
    
    /// <summary>
    /// Calls `IfConditionState` with `state=False`.
    /// </summary>
    public static Instruction IfConditionFalse(ConditionGroup condition, ConditionGroup inputCondition)
        => IfConditionState(condition, 0, inputCondition);
    
    /// <summary>
    /// Load given condition group into MAIN (0) and wait for it to be true.
    /// </summary>
    public static Instruction AWAIT(ConditionGroup inputCondition)
        => IfConditionState(ConditionGroup.MAIN, 1, inputCondition);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfValueComparison(ConditionGroup condition, ComparisonType comparisonType, int left, int right)
        => new(0, 1, (sbyte)condition, (sbyte)comparisonType, left, right);
    
    /// <summary>
    /// Calls `IfValueComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfValueEqual(ConditionGroup condition, int left, int right)
        => IfValueComparison(condition, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `IfValueComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfValueNotEqual(ConditionGroup condition, int left, int right)
        => IfValueComparison(condition, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `IfValueComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfValueGreaterThan(ConditionGroup condition, int left, int right)
        => IfValueComparison(condition, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `IfValueComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfValueLessThan(ConditionGroup condition, int left, int right)
        => IfValueComparison(condition, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `IfValueComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfValueGreaterThanOrEqual(ConditionGroup condition, int left, int right)
        => IfValueComparison(condition, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `IfValueComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfValueLessThanOrEqual(ConditionGroup condition, int left, int right)
        => IfValueComparison(condition, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// Time since event started.
    /// </summary>
    public static Instruction IfTimeElapsed(ConditionGroup condition, float seconds)
        => new(1, 0, (sbyte)condition, seconds);
    
    /// <summary>
    /// Frames since event started.
    /// </summary>
    public static Instruction IfFramesElapsed(ConditionGroup condition, int frames)
        => new(1, 1, (sbyte)condition, frames);
    
    /// <summary>
    /// Not used in vanilla DS1. Requires a random amount of time since event began.
    /// </summary>
    public static Instruction IfRandomTimeElapsed(ConditionGroup condition, float minSeconds, float maxSeconds)
        => new(1, 2, (sbyte)condition, minSeconds, maxSeconds);
    
    /// <summary>
    /// Not used in vanilla DS1. Requires a random amount of frames since event began.
    /// </summary>
    public static Instruction IfRandomFramesElapsed(ConditionGroup condition, int minFrames, int maxFrames)
        => new(1, 3, (sbyte)condition, minFrames, maxFrames);
    
    /// <summary>
    /// Checks if current in-game time is EXACTLY the given time, down to the second.
    /// </summary>
    public static Instruction IfTimeOfDay(ConditionGroup condition, byte hour, byte minute, byte second)
        => new(1, 4, (sbyte)condition, hour, minute, second);
    
    /// <summary>
    /// Checks if current in-game time is between an earliest and latest time, each specified down to the second.
    /// 
    /// Note that ranges will loop over midnight as expected, so checking, e.g., if the time is within the three-
    /// hour range between hour 23 (PM) and hour 2 (AM) is straightforward: `earliest=(23, 0, 0), latest=(2, 0, 0)`.
    /// </summary>
    public static Instruction IfTimeOfDayInRange(
        ConditionGroup condition,
        byte earliestHour,
        byte earliestMinute,
        byte earliestSecond,
        byte latestHour,
        byte latestMinute,
        byte latestSecond)
        => new(1, 5, (sbyte)condition, earliestHour, earliestMinute, earliestSecond, latestHour, latestMinute, latestSecond);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfFlagState(ConditionGroup condition, FlagSetting state, FlagType flagType, uint flag)
        => new(3, 0, (sbyte)condition, (byte)state, (byte)flagType, flag);
    
    /// <summary>
    /// Calls `IfFlagState` with `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction IfFlagEnabled(ConditionGroup condition, uint flag)
        => IfFlagState(condition, FlagSetting.On, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `IfFlagState` with `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction IfFlagDisabled(ConditionGroup condition, uint flag)
        => IfFlagState(condition, FlagSetting.Off, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `IfFlagState` with `state=1`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction IfThisEventFlagEnabled(ConditionGroup condition)
        => IfFlagState(condition, FlagSetting.On, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `IfFlagState` with `state=0`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction IfThisEventFlagDisabled(ConditionGroup condition)
        => IfFlagState(condition, FlagSetting.Off, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `IfFlagState` with `state=1`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction IfThisEventSlotFlagEnabled(ConditionGroup condition)
        => IfFlagState(condition, FlagSetting.On, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Calls `IfFlagState` with `state=0`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction IfThisEventSlotFlagDisabled(ConditionGroup condition)
        => IfFlagState(condition, FlagSetting.Off, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfFlagRangeState(ConditionGroup condition, RangeState state, FlagType flagType, uint firstFlag, uint lastFlag)
        => new(3, 1, (sbyte)condition, (byte)state, (byte)flagType, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `IfFlagRangeState` with `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction IfFlagRangeAllEnabled(ConditionGroup condition, uint firstFlag, uint lastFlag)
        => IfFlagRangeState(condition, RangeState.AllOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `IfFlagRangeState` with `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction IfFlagRangeAllDisabled(ConditionGroup condition, uint firstFlag, uint lastFlag)
        => IfFlagRangeState(condition, RangeState.AllOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `IfFlagRangeState` with `state=2`, `flag_type=0`.
    /// </summary>
    public static Instruction IfFlagRangeAnyEnabled(ConditionGroup condition, uint firstFlag, uint lastFlag)
        => IfFlagRangeState(condition, RangeState.AnyOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `IfFlagRangeState` with `state=3`, `flag_type=0`.
    /// </summary>
    public static Instruction IfFlagRangeAnyDisabled(ConditionGroup condition, uint firstFlag, uint lastFlag)
        => IfFlagRangeState(condition, RangeState.AnyOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// New argument with unknown purpose. Always 1 in vanilla resources. Probably for debug.
    /// </summary>
    public static Instruction IfCharacterRegionState(ConditionGroup condition, byte state, uint character, uint region, int minTargetCount = 1)
        => new(3, 2, (sbyte)condition, state, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `IfCharacterRegionState` with `state=True`, `character=10000`.
    /// </summary>
    public static Instruction IfPlayerInsideRegion(ConditionGroup condition, uint region, int minTargetCount = 1)
        => IfCharacterRegionState(condition, 1, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `IfCharacterRegionState` with `state=False`, `character=10000`.
    /// </summary>
    public static Instruction IfPlayerOutsideRegion(ConditionGroup condition, uint region, int minTargetCount = 1)
        => IfCharacterRegionState(condition, 0, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `IfCharacterRegionState` with `state=True`.
    /// </summary>
    public static Instruction IfCharacterInsideRegion(ConditionGroup condition, uint character, uint region, int minTargetCount = 1)
        => IfCharacterRegionState(condition, 1, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `IfCharacterRegionState` with `state=False`.
    /// </summary>
    public static Instruction IfCharacterOutsideRegion(ConditionGroup condition, uint character, uint region, int minTargetCount = 1)
        => IfCharacterRegionState(condition, 0, character, region, minTargetCount);
    
    /// <summary>
    /// Same new argument as region test, with unknown purpose, and again always 1 in EMEVD resources.
    /// </summary>
    public static Instruction IfEntityDistanceState(
        ConditionGroup condition,
        byte state,
        uint entity,
        uint otherEntity,
        float radius,
        int minTargetCount = 1)
        => new(3, 3, (sbyte)condition, state, entity, otherEntity, radius, minTargetCount);
    
    /// <summary>
    /// Calls `IfEntityDistanceState` with `state=True`, `entity=10000`.
    /// </summary>
    public static Instruction IfPlayerWithinDistance(ConditionGroup condition, uint otherEntity, float radius, int minTargetCount = 1)
        => IfEntityDistanceState(condition, 1, 10000, otherEntity, radius, minTargetCount);
    
    /// <summary>
    /// Calls `IfEntityDistanceState` with `state=False`, `entity=10000`.
    /// </summary>
    public static Instruction IfPlayerBeyondDistance(ConditionGroup condition, uint otherEntity, float radius, int minTargetCount = 1)
        => IfEntityDistanceState(condition, 0, 10000, otherEntity, radius, minTargetCount);
    
    /// <summary>
    /// Calls `IfEntityDistanceState` with `state=True`.
    /// </summary>
    public static Instruction IfEntityWithinDistance(
        ConditionGroup condition,
        uint entity,
        uint otherEntity,
        float radius,
        int minTargetCount = 1)
        => IfEntityDistanceState(condition, 1, entity, otherEntity, radius, minTargetCount);
    
    /// <summary>
    /// Calls `IfEntityDistanceState` with `state=False`.
    /// </summary>
    public static Instruction IfEntityBeyondDistance(
        ConditionGroup condition,
        uint entity,
        uint otherEntity,
        float radius,
        int minTargetCount = 1)
        => IfEntityDistanceState(condition, 0, entity, otherEntity, radius, minTargetCount);
    
    /// <summary>
    /// TODO
    /// item_type: Auto-detected from `item` type by default.
    /// </summary>
    public static Instruction IfPlayerItemStateExcludingStorage(ConditionGroup condition, int item, byte state, ItemType itemType)
        => new(3, 4, (sbyte)condition, (byte)itemType, item, state);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfMultiplayerState(ConditionGroup condition, MultiplayerState state)
        => new(3, 6, (sbyte)condition, (sbyte)state);
    
    /// <summary>
    /// Calls `IfMultiplayerState` with `state=0`.
    /// </summary>
    public static Instruction IfHost(ConditionGroup condition)
        => IfMultiplayerState(condition, MultiplayerState.Host);
    
    /// <summary>
    /// Calls `IfMultiplayerState` with `state=1`.
    /// </summary>
    public static Instruction IfClient(ConditionGroup condition)
        => IfMultiplayerState(condition, MultiplayerState.Client);
    
    /// <summary>
    /// Calls `IfMultiplayerState` with `state=2`.
    /// </summary>
    public static Instruction IfMultiplayer(ConditionGroup condition)
        => IfMultiplayerState(condition, MultiplayerState.Multiplayer);
    
    /// <summary>
    /// Calls `IfMultiplayerState` with `state=3`.
    /// </summary>
    public static Instruction IfMultiplayerPending(ConditionGroup condition)
        => IfMultiplayerState(condition, MultiplayerState.MultiplayerPending);
    
    /// <summary>
    /// Calls `IfMultiplayerState` with `state=4`.
    /// </summary>
    public static Instruction IfSingleplayer(ConditionGroup condition)
        => IfMultiplayerState(condition, MultiplayerState.Singleplayer);
    
    /// <summary>
    /// Calls `IfMultiplayerState` with `state=5`.
    /// </summary>
    public static Instruction IfInvasion(ConditionGroup condition)
        => IfMultiplayerState(condition, MultiplayerState.Invasion);
    
    /// <summary>
    /// Calls `IfMultiplayerState` with `state=6`.
    /// </summary>
    public static Instruction IfInvasionPending(ConditionGroup condition)
        => IfMultiplayerState(condition, MultiplayerState.InvasionPending);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfAllPlayersRegionState(ConditionGroup condition, byte state, uint region)
        => new(3, 7, (sbyte)condition, state, region);
    
    /// <summary>
    /// Calls `IfAllPlayersRegionState` with `state=True`.
    /// </summary>
    public static Instruction IfAllPlayersInsideRegion(ConditionGroup condition, uint region)
        => IfAllPlayersRegionState(condition, 1, region);
    
    /// <summary>
    /// Calls `IfAllPlayersRegionState` with `state=False`.
    /// </summary>
    public static Instruction IfAllPlayersOutsideRegion(ConditionGroup condition, uint region)
        => IfAllPlayersRegionState(condition, 0, region);
    
    /// <summary>
    /// Conditions upon player's presence in a particular game map.
    /// </summary>
    public static Instruction IfMapPresenceState(ConditionGroup condition, byte state, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => new(3, 8, (sbyte)condition, state, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `IfMapPresenceState` with `state=True`.
    /// </summary>
    public static Instruction IfInsideMap(ConditionGroup condition, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => IfMapPresenceState(condition, 1, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `IfMapPresenceState` with `state=False`.
    /// </summary>
    public static Instruction IfOutsideMap(ConditionGroup condition, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => IfMapPresenceState(condition, 0, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfMultiplayerEvent(ConditionGroup condition, uint eventID)
        => new(3, 9, (sbyte)condition, eventID);
    
    /// <summary>
    /// Conditions upon a comparison with the number of enabled flags in the given range (inclusive).
    /// </summary>
    public static Instruction IfEnabledFlagCountComparison(
        ConditionGroup condition,
        FlagType flagType,
        uint firstFlag,
        uint lastFlag,
        ComparisonType comparisonType,
        int value)
        => new(3, 10, (sbyte)condition, (byte)flagType, firstFlag, lastFlag, (sbyte)comparisonType, value);
    
    /// <summary>
    /// Calls `IfEnabledFlagCountComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfEnabledFlagCountEqual(ConditionGroup condition, FlagType flagType, uint firstFlag, uint lastFlag, int value)
        => IfEnabledFlagCountComparison(condition, flagType, firstFlag, lastFlag, ComparisonType.Equal, value);
    
    /// <summary>
    /// Calls `IfEnabledFlagCountComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfEnabledFlagCountNotEqual(ConditionGroup condition, FlagType flagType, uint firstFlag, uint lastFlag, int value)
        => IfEnabledFlagCountComparison(condition, flagType, firstFlag, lastFlag, ComparisonType.NotEqual, value);
    
    /// <summary>
    /// Calls `IfEnabledFlagCountComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfEnabledFlagCountGreaterThan(
        ConditionGroup condition,
        FlagType flagType,
        uint firstFlag,
        uint lastFlag,
        int value)
        => IfEnabledFlagCountComparison(condition, flagType, firstFlag, lastFlag, ComparisonType.GreaterThan, value);
    
    /// <summary>
    /// Calls `IfEnabledFlagCountComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfEnabledFlagCountLessThan(ConditionGroup condition, FlagType flagType, uint firstFlag, uint lastFlag, int value)
        => IfEnabledFlagCountComparison(condition, flagType, firstFlag, lastFlag, ComparisonType.LessThan, value);
    
    /// <summary>
    /// Calls `IfEnabledFlagCountComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfEnabledFlagCountGreaterThanOrEqual(
        ConditionGroup condition,
        FlagType flagType,
        uint firstFlag,
        uint lastFlag,
        int value)
        => IfEnabledFlagCountComparison(condition, flagType, firstFlag, lastFlag, ComparisonType.GreaterThanOrEqual, value);
    
    /// <summary>
    /// Calls `IfEnabledFlagCountComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfEnabledFlagCountLessThanOrEqual(
        ConditionGroup condition,
        FlagType flagType,
        uint firstFlag,
        uint lastFlag,
        int value)
        => IfEnabledFlagCountComparison(condition, flagType, firstFlag, lastFlag, ComparisonType.LessThanOrEqual, value);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfEventValueComparison(
        ConditionGroup condition,
        uint flag,
        byte bitCount,
        ComparisonType comparisonType,
        uint value)
        => new(3, 12, (sbyte)condition, flag, bitCount, (byte)comparisonType, value);
    
    /// <summary>
    /// Calls `IfEventValueComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfEventValueEqual(ConditionGroup condition, uint flag, byte bitCount, uint value)
        => IfEventValueComparison(condition, flag, bitCount, ComparisonType.Equal, value);
    
    /// <summary>
    /// Calls `IfEventValueComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfEventValueNotEqual(ConditionGroup condition, uint flag, byte bitCount, uint value)
        => IfEventValueComparison(condition, flag, bitCount, ComparisonType.NotEqual, value);
    
    /// <summary>
    /// Calls `IfEventValueComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfEventValueGreaterThan(ConditionGroup condition, uint flag, byte bitCount, uint value)
        => IfEventValueComparison(condition, flag, bitCount, ComparisonType.GreaterThan, value);
    
    /// <summary>
    /// Calls `IfEventValueComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfEventValueLessThan(ConditionGroup condition, uint flag, byte bitCount, uint value)
        => IfEventValueComparison(condition, flag, bitCount, ComparisonType.LessThan, value);
    
    /// <summary>
    /// Calls `IfEventValueComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfEventValueGreaterThanOrEqual(ConditionGroup condition, uint flag, byte bitCount, uint value)
        => IfEventValueComparison(condition, flag, bitCount, ComparisonType.GreaterThanOrEqual, value);
    
    /// <summary>
    /// Calls `IfEventValueComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfEventValueLessThanOrEqual(ConditionGroup condition, uint flag, byte bitCount, uint value)
        => IfEventValueComparison(condition, flag, bitCount, ComparisonType.LessThanOrEqual, value);
    
    /// <summary>
    /// Check if any item has been dropped in the specified region. Not sensitive to what the item is.
    /// </summary>
    public static Instruction IfAnyItemDroppedInRegion(ConditionGroup condition, uint region)
        => new(3, 14, (sbyte)condition, region);
    
    /// <summary>
    /// TODO
    /// item_type: Auto-detected from `item` type by default.
    /// </summary>
    public static Instruction IfItemDropped(ConditionGroup condition, int item, ItemType itemType)
        => new(3, 15, (sbyte)condition, (byte)itemType, item);
    
    /// <summary>
    /// TODO
    /// item_type: Auto-detected from `item` type by default.
    /// </summary>
    public static Instruction IfPlayerItemStateIncludingStorage(ConditionGroup condition, int item, byte state, ItemType itemType)
        => new(3, 16, (sbyte)condition, (byte)itemType, item, state);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfNewGameCycleComparison(ConditionGroup condition, ComparisonType comparisonType, byte completionCount)
        => new(3, 17, (sbyte)condition, (byte)comparisonType, completionCount);
    
    /// <summary>
    /// Calls `IfNewGameCycleComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfNewGameCycleEqual(ConditionGroup condition, byte completionCount)
        => IfNewGameCycleComparison(condition, ComparisonType.Equal, completionCount);
    
    /// <summary>
    /// Calls `IfNewGameCycleComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfNewGameCycleNotEqual(ConditionGroup condition, byte completionCount)
        => IfNewGameCycleComparison(condition, ComparisonType.NotEqual, completionCount);
    
    /// <summary>
    /// Calls `IfNewGameCycleComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfNewGameCycleGreaterThan(ConditionGroup condition, byte completionCount)
        => IfNewGameCycleComparison(condition, ComparisonType.GreaterThan, completionCount);
    
    /// <summary>
    /// Calls `IfNewGameCycleComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfNewGameCycleLessThan(ConditionGroup condition, byte completionCount)
        => IfNewGameCycleComparison(condition, ComparisonType.LessThan, completionCount);
    
    /// <summary>
    /// Calls `IfNewGameCycleComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfNewGameCycleGreaterThanOrEqual(ConditionGroup condition, byte completionCount)
        => IfNewGameCycleComparison(condition, ComparisonType.GreaterThanOrEqual, completionCount);
    
    /// <summary>
    /// Calls `IfNewGameCycleComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfNewGameCycleLessThanOrEqual(ConditionGroup condition, byte completionCount)
        => IfNewGameCycleComparison(condition, ComparisonType.LessThanOrEqual, completionCount);
    
    /// <summary>
    /// Check comparison of two event flag values. Haven't bothered adding shortcut functions for this.
    /// </summary>
    public static Instruction IfEventsComparison(
        ConditionGroup condition,
        uint leftFlag,
        byte leftBitCount,
        ComparisonType comparisonType,
        uint rightFlag,
        byte rightBitCount)
        => new(3, 20, (sbyte)condition, leftFlag, leftBitCount, (byte)comparisonType, rightFlag, rightBitCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfOnlineState(ConditionGroup condition, byte state)
        => new(3, 22, (sbyte)condition, state);
    
    /// <summary>
    /// Calls `IfOnlineState` with `state=True`.
    /// </summary>
    public static Instruction IfOnline(ConditionGroup condition)
        => IfOnlineState(condition, 1);
    
    /// <summary>
    /// Calls `IfOnlineState` with `state=False`.
    /// </summary>
    public static Instruction IfOffline(ConditionGroup condition)
        => IfOnlineState(condition, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterDeathState(
        ConditionGroup condition,
        uint character,
        byte isDead,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 0, (sbyte)condition, character, isDead, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterDeathState` with `is_dead=True`.
    /// </summary>
    public static Instruction IfCharacterDead(
        ConditionGroup condition,
        uint character,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterDeathState(condition, character, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterDeathState` with `is_dead=False`.
    /// </summary>
    public static Instruction IfCharacterAlive(
        ConditionGroup condition,
        uint character,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterDeathState(condition, character, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Conditions upon a comparison to character health ratio (0-1).
    /// </summary>
    public static Instruction IfHealthRatioComparison(
        ConditionGroup condition,
        uint character,
        ComparisonType comparisonType,
        float value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 2, (sbyte)condition, character, (sbyte)comparisonType, value, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthRatioComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfHealthRatioEqual(
        ConditionGroup condition,
        uint character,
        float value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthRatioComparison(condition, character, ComparisonType.Equal, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthRatioComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfHealthRatioNotEqual(
        ConditionGroup condition,
        uint character,
        float value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthRatioComparison(condition, character, ComparisonType.NotEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthRatioComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfHealthRatioGreaterThan(
        ConditionGroup condition,
        uint character,
        float value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthRatioComparison(condition, character, ComparisonType.GreaterThan, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthRatioComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfHealthRatioLessThan(
        ConditionGroup condition,
        uint character,
        float value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthRatioComparison(condition, character, ComparisonType.LessThan, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthRatioComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfHealthRatioGreaterThanOrEqual(
        ConditionGroup condition,
        uint character,
        float value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthRatioComparison(condition, character, ComparisonType.GreaterThanOrEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthRatioComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfHealthRatioLessThanOrEqual(
        ConditionGroup condition,
        uint character,
        float value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthRatioComparison(condition, character, ComparisonType.LessThanOrEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterIsType(
        ConditionGroup condition,
        uint character,
        CharacterType characterType,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 3, (sbyte)condition, character, (sbyte)characterType, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterTargetingState(
        ConditionGroup condition,
        uint targetingCharacter,
        uint targetedCharacter,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 4, (sbyte)condition, targetingCharacter, targetedCharacter, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterTargetingState` with `state=True`.
    /// </summary>
    public static Instruction IfCharacterTargeting(
        ConditionGroup condition,
        uint targetingCharacter,
        uint targetedCharacter,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterTargetingState(condition, targetingCharacter, targetedCharacter, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterTargetingState` with `state=False`.
    /// </summary>
    public static Instruction IfCharacterNotTargeting(
        ConditionGroup condition,
        uint targetingCharacter,
        uint targetedCharacter,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterTargetingState(condition, targetingCharacter, targetedCharacter, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterSpecialEffectState(
        ConditionGroup condition,
        uint character,
        int specialEffect,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 5, (sbyte)condition, character, specialEffect, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterSpecialEffectState` with `character=10000`, `state=True`.
    /// </summary>
    public static Instruction IfPlayerHasSpecialEffect(
        ConditionGroup condition,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterSpecialEffectState(condition, 10000, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterSpecialEffectState` with `character=10000`, `state=False`.
    /// </summary>
    public static Instruction IfPlayerDoesNotHaveSpecialEffect(
        ConditionGroup condition,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterSpecialEffectState(condition, 10000, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterSpecialEffectState` with `state=True`.
    /// </summary>
    public static Instruction IfCharacterHasSpecialEffect(
        ConditionGroup condition,
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterSpecialEffectState(condition, character, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterSpecialEffectState` with `state=False`.
    /// </summary>
    public static Instruction IfCharacterDoesNotHaveSpecialEffect(
        ConditionGroup condition,
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterSpecialEffectState(condition, character, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterPartHealthComparison(
        ConditionGroup condition,
        uint character,
        int npcPartID,
        int value,
        ComparisonType comparisonType)
        => new(4, 6, (sbyte)condition, character, npcPartID, value, (sbyte)comparisonType);
    
    /// <summary>
    /// Calls `IfCharacterPartHealthComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfCharacterPartHealthLessThanOrEqual(ConditionGroup condition, uint character, int npcPartID, int value)
        => IfCharacterPartHealthComparison(condition, character, npcPartID, value, ComparisonType.LessThanOrEqual);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterBackreadState(
        ConditionGroup condition,
        uint character,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 7, (sbyte)condition, character, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterBackreadState` with `state=True`.
    /// </summary>
    public static Instruction IfCharacterBackreadEnabled(
        ConditionGroup condition,
        uint character,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterBackreadState(condition, character, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterBackreadState` with `state=False`.
    /// </summary>
    public static Instruction IfCharacterBackreadDisabled(
        ConditionGroup condition,
        uint character,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterBackreadState(condition, character, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterTAEEventState(
        ConditionGroup condition,
        uint character,
        int taeEventID,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 8, (sbyte)condition, character, taeEventID, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterTAEEventState` with `state=True`.
    /// </summary>
    public static Instruction IfCharacterHasTAEEvent(
        ConditionGroup condition,
        uint character,
        int taeEventID,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterTAEEventState(condition, character, taeEventID, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterTAEEventState` with `state=False`.
    /// </summary>
    public static Instruction IfCharacterDoesNotHaveTAEEvent(
        ConditionGroup condition,
        uint character,
        int taeEventID,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterTAEEventState(condition, character, taeEventID, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfHasAIStatus(
        ConditionGroup condition,
        uint character,
        AIStatusType aiStatus,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 9, (sbyte)condition, character, (byte)aiStatus, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerClass(ConditionGroup condition, ClassType classType)
        => new(4, 11, (sbyte)condition, (byte)classType);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerCovenant(ConditionGroup condition, byte covenant)
        => new(4, 12, (sbyte)condition, covenant);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerLevelComparison(ConditionGroup condition, ComparisonType comparisonType, uint value)
        => new(4, 13, (sbyte)condition, (byte)comparisonType, value);
    
    /// <summary>
    /// Calls `IfPlayerLevelComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfPlayerLevelEqual(ConditionGroup condition, uint value)
        => IfPlayerLevelComparison(condition, ComparisonType.Equal, value);
    
    /// <summary>
    /// Calls `IfPlayerLevelComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfPlayerLevelNotEqual(ConditionGroup condition, uint value)
        => IfPlayerLevelComparison(condition, ComparisonType.NotEqual, value);
    
    /// <summary>
    /// Calls `IfPlayerLevelComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfPlayerLevelGreaterThan(ConditionGroup condition, uint value)
        => IfPlayerLevelComparison(condition, ComparisonType.GreaterThan, value);
    
    /// <summary>
    /// Calls `IfPlayerLevelComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfPlayerLevelLessThan(ConditionGroup condition, uint value)
        => IfPlayerLevelComparison(condition, ComparisonType.LessThan, value);
    
    /// <summary>
    /// Calls `IfPlayerLevelComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfPlayerLevelGreaterThanOrEqual(ConditionGroup condition, uint value)
        => IfPlayerLevelComparison(condition, ComparisonType.GreaterThanOrEqual, value);
    
    /// <summary>
    /// Calls `IfPlayerLevelComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfPlayerLevelLessThanOrEqual(ConditionGroup condition, uint value)
        => IfPlayerLevelComparison(condition, ComparisonType.LessThanOrEqual, value);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfHealthValueComparison(
        ConditionGroup condition,
        uint character,
        ComparisonType comparisonType,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 14, (sbyte)condition, character, (sbyte)comparisonType, value, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthValueComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfHealthValueEqual(
        ConditionGroup condition,
        uint character,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthValueComparison(condition, character, ComparisonType.Equal, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthValueComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfHealthValueNotEqual(
        ConditionGroup condition,
        uint character,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthValueComparison(condition, character, ComparisonType.NotEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthValueComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfHealthValueGreaterThan(
        ConditionGroup condition,
        uint character,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthValueComparison(condition, character, ComparisonType.GreaterThan, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthValueComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfHealthValueLessThan(
        ConditionGroup condition,
        uint character,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthValueComparison(condition, character, ComparisonType.LessThan, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthValueComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfHealthValueGreaterThanOrEqual(
        ConditionGroup condition,
        uint character,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthValueComparison(condition, character, ComparisonType.GreaterThanOrEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfHealthValueComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfHealthValueLessThanOrEqual(
        ConditionGroup condition,
        uint character,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfHealthValueComparison(condition, character, ComparisonType.LessThanOrEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfAssetDestructionState(
        ConditionGroup condition,
        byte state,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(5, 0, (sbyte)condition, state, asset, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetDestructionState` with `state=True`.
    /// </summary>
    public static Instruction IfAssetDestroyed(
        ConditionGroup condition,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetDestructionState(condition, 1, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetDestructionState` with `state=False`.
    /// </summary>
    public static Instruction IfAssetNotDestroyed(
        ConditionGroup condition,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetDestructionState(condition, 0, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfAssetDamaged(ConditionGroup condition, uint asset, uint attacker)
        => new(5, 1, (sbyte)condition, asset, attacker);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfAssetActivated(ConditionGroup condition, uint objActID)
        => new(5, 2, (sbyte)condition, objActID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfAssetHealthValueComparison(
        ConditionGroup condition,
        uint asset,
        ComparisonType comparisonType,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(5, 3, (sbyte)condition, asset, (sbyte)comparisonType, value, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetHealthValueComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfAssetHealthValueEqual(
        ConditionGroup condition,
        uint asset,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetHealthValueComparison(condition, asset, ComparisonType.Equal, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetHealthValueComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfAssetHealthValueNotEqual(
        ConditionGroup condition,
        uint asset,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetHealthValueComparison(condition, asset, ComparisonType.NotEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetHealthValueComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfAssetHealthValueGreaterThan(
        ConditionGroup condition,
        uint asset,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetHealthValueComparison(condition, asset, ComparisonType.GreaterThan, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetHealthValueComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfAssetHealthValueLessThan(
        ConditionGroup condition,
        uint asset,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetHealthValueComparison(condition, asset, ComparisonType.LessThan, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetHealthValueComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfAssetHealthValueGreaterThanOrEqual(
        ConditionGroup condition,
        uint asset,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetHealthValueComparison(condition, asset, ComparisonType.GreaterThanOrEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetHealthValueComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfAssetHealthValueLessThanOrEqual(
        ConditionGroup condition,
        uint asset,
        int value,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetHealthValueComparison(condition, asset, ComparisonType.LessThanOrEqual, value, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerMovingOnCollision(ConditionGroup condition, uint collision)
        => new(11, 0, (sbyte)condition, collision);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerRunningOnCollision(ConditionGroup condition, uint collision)
        => new(11, 1, (sbyte)condition, collision);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerStandingOnCollision(ConditionGroup condition, uint collision)
        => new(11, 2, (sbyte)condition, collision);
    
    /// <summary>
    /// Not sure if this is ever really used over `IfConditionState`.
    /// </summary>
    public static Instruction AwaitConditionState(byte state, ConditionGroup inputCondition)
        => new(1000, 0, state, (sbyte)inputCondition);
    
    /// <summary>
    /// Calls `AwaitConditionState` with `state=True`.
    /// </summary>
    public static Instruction AwaitConditionTrue(ConditionGroup inputCondition)
        => AwaitConditionState(1, inputCondition);
    
    /// <summary>
    /// Calls `AwaitConditionState` with `state=False`.
    /// </summary>
    public static Instruction AwaitConditionFalse(ConditionGroup inputCondition)
        => AwaitConditionState(0, inputCondition);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfConditionState(byte lineCount, byte state, ConditionGroup inputCondition)
        => new(1000, 1, lineCount, state, (sbyte)inputCondition);
    
    /// <summary>
    /// Calls `SkipLinesIfConditionState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfConditionTrue(byte lineCount, ConditionGroup inputCondition)
        => SkipLinesIfConditionState(lineCount, 1, inputCondition);
    
    /// <summary>
    /// Calls `SkipLinesIfConditionState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfConditionFalse(byte lineCount, ConditionGroup inputCondition)
        => SkipLinesIfConditionState(lineCount, 0, inputCondition);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfConditionState(EventReturnType eventReturnType, byte state, ConditionGroup inputCondition)
        => new(1000, 2, (byte)eventReturnType, state, (sbyte)inputCondition);
    
    /// <summary>
    /// Calls `ReturnIfConditionState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIfConditionTrue(ConditionGroup inputCondition)
        => ReturnIfConditionState(EventReturnType.End, 1, inputCondition);
    
    /// <summary>
    /// Calls `ReturnIfConditionState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIfConditionFalse(ConditionGroup inputCondition)
        => ReturnIfConditionState(EventReturnType.End, 0, inputCondition);
    
    /// <summary>
    /// Calls `ReturnIfConditionState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIfConditionTrue(ConditionGroup inputCondition)
        => ReturnIfConditionState(EventReturnType.Restart, 1, inputCondition);
    
    /// <summary>
    /// Calls `ReturnIfConditionState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIfConditionFalse(ConditionGroup inputCondition)
        => ReturnIfConditionState(EventReturnType.Restart, 0, inputCondition);
    
    /// <summary>
    /// Unconditional line skip.
    /// </summary>
    public static Instruction SkipLines(byte lineCount)
        => new(1000, 3, lineCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction Return(EventReturnType eventReturnType)
        => new(1000, 4, (byte)eventReturnType);
    
    /// <summary>
    /// Calls `Return` with `event_return_type=0`.
    /// </summary>
    public static Instruction End()
        => Return(EventReturnType.End);
    
    /// <summary>
    /// Calls `Return` with `event_return_type=1`.
    /// </summary>
    public static Instruction Restart()
        => Return(EventReturnType.Restart);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfValueComparison(byte lineCount, ComparisonType comparisonType, int left, int right)
        => new(1000, 5, lineCount, (sbyte)comparisonType, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfValueComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction SkipLinesIfValueEqual(byte lineCount, int left, int right)
        => SkipLinesIfValueComparison(lineCount, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfValueComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction SkipLinesIfValueNotEqual(byte lineCount, int left, int right)
        => SkipLinesIfValueComparison(lineCount, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfValueComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction SkipLinesIfValueGreaterThan(byte lineCount, int left, int right)
        => SkipLinesIfValueComparison(lineCount, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfValueComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction SkipLinesIfValueLessThan(byte lineCount, int left, int right)
        => SkipLinesIfValueComparison(lineCount, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfValueComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction SkipLinesIfValueGreaterThanOrEqual(byte lineCount, int left, int right)
        => SkipLinesIfValueComparison(lineCount, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfValueComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction SkipLinesIfValueLessThanOrEqual(byte lineCount, int left, int right)
        => SkipLinesIfValueComparison(lineCount, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfValueComparison(EventReturnType eventReturnType, ComparisonType comparisonType, int left, int right)
        => new(1000, 6, (byte)eventReturnType, (sbyte)comparisonType, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=0`, `comparison_type=0`.
    /// </summary>
    public static Instruction EndIfValueEqual(int left, int right)
        => ReturnIfValueComparison(EventReturnType.End, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=0`, `comparison_type=1`.
    /// </summary>
    public static Instruction EndIfValueNotEqual(int left, int right)
        => ReturnIfValueComparison(EventReturnType.End, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=0`, `comparison_type=2`.
    /// </summary>
    public static Instruction EndIfValueGreaterThan(int left, int right)
        => ReturnIfValueComparison(EventReturnType.End, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=0`, `comparison_type=3`.
    /// </summary>
    public static Instruction EndIfValueLessThan(int left, int right)
        => ReturnIfValueComparison(EventReturnType.End, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=0`, `comparison_type=4`.
    /// </summary>
    public static Instruction EndIfValueGreaterThanOrEqual(int left, int right)
        => ReturnIfValueComparison(EventReturnType.End, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=0`, `comparison_type=5`.
    /// </summary>
    public static Instruction EndIfValueLessThanOrEqual(int left, int right)
        => ReturnIfValueComparison(EventReturnType.End, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=1`, `comparison_type=0`.
    /// </summary>
    public static Instruction RestartIfValueEqual(int left, int right)
        => ReturnIfValueComparison(EventReturnType.Restart, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=1`, `comparison_type=1`.
    /// </summary>
    public static Instruction RestartIfValueNotEqual(int left, int right)
        => ReturnIfValueComparison(EventReturnType.Restart, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=1`, `comparison_type=2`.
    /// </summary>
    public static Instruction RestartIfValueGreaterThan(int left, int right)
        => ReturnIfValueComparison(EventReturnType.Restart, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=1`, `comparison_type=3`.
    /// </summary>
    public static Instruction RestartIfValueLessThan(int left, int right)
        => ReturnIfValueComparison(EventReturnType.Restart, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=1`, `comparison_type=4`.
    /// </summary>
    public static Instruction RestartIfValueGreaterThanOrEqual(int left, int right)
        => ReturnIfValueComparison(EventReturnType.Restart, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfValueComparison` with `event_return_type=1`, `comparison_type=5`.
    /// </summary>
    public static Instruction RestartIfValueLessThanOrEqual(int left, int right)
        => ReturnIfValueComparison(EventReturnType.Restart, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// Skip some number of lines if the last result of the given condition (without re-evaluating) is `state`.
    /// </summary>
    public static Instruction SkipLinesIfLastConditionResultState(byte lineCount, byte state, ConditionGroup inputCondition)
        => new(1000, 7, lineCount, state, (sbyte)inputCondition);
    
    /// <summary>
    /// Calls `SkipLinesIfLastConditionResultState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfLastConditionResultTrue(byte lineCount, ConditionGroup inputCondition)
        => SkipLinesIfLastConditionResultState(lineCount, 1, inputCondition);
    
    /// <summary>
    /// Calls `SkipLinesIfLastConditionResultState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfLastConditionResultFalse(byte lineCount, ConditionGroup inputCondition)
        => SkipLinesIfLastConditionResultState(lineCount, 0, inputCondition);
    
    /// <summary>
    /// End or restart event if last condition result (without re-evaluating) is the given `state`.
    /// </summary>
    public static Instruction ReturnIfLastConditionResultState(EventReturnType eventReturnType, byte state, ConditionGroup inputCondition)
        => new(1000, 8, (byte)eventReturnType, state, (sbyte)inputCondition);
    
    /// <summary>
    /// Calls `ReturnIfLastConditionResultState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIfLastConditionResultTrue(ConditionGroup inputCondition)
        => ReturnIfLastConditionResultState(EventReturnType.End, 1, inputCondition);
    
    /// <summary>
    /// Calls `ReturnIfLastConditionResultState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIfLastConditionResultFalse(ConditionGroup inputCondition)
        => ReturnIfLastConditionResultState(EventReturnType.End, 0, inputCondition);
    
    /// <summary>
    /// Calls `ReturnIfLastConditionResultState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIfLastConditionResultTrue(ConditionGroup inputCondition)
        => ReturnIfLastConditionResultState(EventReturnType.Restart, 1, inputCondition);
    
    /// <summary>
    /// Calls `ReturnIfLastConditionResultState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIfLastConditionResultFalse(ConditionGroup inputCondition)
        => ReturnIfLastConditionResultState(EventReturnType.Restart, 0, inputCondition);
    
    /// <summary>
    /// Wait for some number of seconds.
    /// </summary>
    public static Instruction Wait(float seconds)
        => new(1001, 0, seconds);
    
    /// <summary>
    /// Wait for some number of frames.
    /// </summary>
    public static Instruction WaitFrames(int frames)
        => new(1001, 1, frames);
    
    /// <summary>
    /// Wait for a random number of seconds between min and max. I assume the distribution is inclusive and uniform.
    /// </summary>
    public static Instruction WaitRandomSeconds(float minSeconds, float maxSeconds)
        => new(1001, 2, minSeconds, maxSeconds);
    
    /// <summary>
    /// Wait for a random number of seconds between min and max. I assume the distribution is inclusive and uniform.
    /// </summary>
    public static Instruction WaitRandomFrames(int minFrames, int maxFrames)
        => new(1001, 3, minFrames, maxFrames);
    
    /// <summary>
    /// Not sure if this is really used rather than `IfFlagState` with MAIN condition (0).
    /// </summary>
    public static Instruction AwaitFlagState(FlagSetting state, FlagType flagType, uint flag)
        => new(1003, 0, (byte)state, (byte)flagType, flag);
    
    /// <summary>
    /// Calls `AwaitFlagState` with `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction AwaitFlagEnabled(uint flag)
        => AwaitFlagState(FlagSetting.On, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `AwaitFlagState` with `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction AwaitFlagDisabled(uint flag)
        => AwaitFlagState(FlagSetting.Off, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `AwaitFlagState` with `state=1`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction AwaitThisEventOn()
        => AwaitFlagState(FlagSetting.On, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `AwaitFlagState` with `state=0`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction AwaitThisEventOff()
        => AwaitFlagState(FlagSetting.Off, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `AwaitFlagState` with `state=1`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction AwaitThisEventSlotOn()
        => AwaitFlagState(FlagSetting.On, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Calls `AwaitFlagState` with `state=0`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction AwaitThisEventSlotOff()
        => AwaitFlagState(FlagSetting.Off, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Skip some number of lines if the specified flag (absolute, event-relative, or slot-relative) has the
    /// specified state.
    /// </summary>
    public static Instruction SkipLinesIfFlagState(byte lineCount, FlagSetting state, FlagType flagType, uint flag)
        => new(1003, 1, lineCount, (byte)state, (byte)flagType, flag);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagState` with `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction SkipLinesIfFlagEnabled(byte lineCount, uint flag)
        => SkipLinesIfFlagState(lineCount, FlagSetting.On, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagState` with `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction SkipLinesIfFlagDisabled(byte lineCount, uint flag)
        => SkipLinesIfFlagState(lineCount, FlagSetting.Off, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagState` with `state=1`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction SkipLinesIfThisEventFlagEnabled(byte lineCount)
        => SkipLinesIfFlagState(lineCount, FlagSetting.On, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagState` with `state=0`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction SkipLinesIfThisEventFlagDisabled(byte lineCount)
        => SkipLinesIfFlagState(lineCount, FlagSetting.Off, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagState` with `state=1`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction SkipLinesIfThisEventSlotFlagEnabled(byte lineCount)
        => SkipLinesIfFlagState(lineCount, FlagSetting.On, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagState` with `state=0`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction SkipLinesIfThisEventSlotFlagDisabled(byte lineCount)
        => SkipLinesIfFlagState(lineCount, FlagSetting.Off, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfFlagState(EventReturnType eventReturnType, FlagSetting state, FlagType flagType, uint flag)
        => new(1003, 2, (byte)eventReturnType, (byte)state, (byte)flagType, flag);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=0`, `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction EndIfFlagEnabled(uint flag)
        => ReturnIfFlagState(EventReturnType.End, FlagSetting.On, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=0`, `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction EndIfFlagDisabled(uint flag)
        => ReturnIfFlagState(EventReturnType.End, FlagSetting.Off, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=0`, `state=1`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction EndIfThisEventFlagEnabled()
        => ReturnIfFlagState(EventReturnType.End, FlagSetting.On, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=0`, `state=0`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction EndIfThisEventFlagDisabled()
        => ReturnIfFlagState(EventReturnType.End, FlagSetting.Off, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=0`, `state=1`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction EndIfThisEventSlotFlagEnabled()
        => ReturnIfFlagState(EventReturnType.End, FlagSetting.On, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=0`, `state=0`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction EndIfThisEventSlotFlagDisabled()
        => ReturnIfFlagState(EventReturnType.End, FlagSetting.Off, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=1`, `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction RestartIfFlagEnabled(uint flag)
        => ReturnIfFlagState(EventReturnType.Restart, FlagSetting.On, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=1`, `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction RestartIfFlagDisabled(uint flag)
        => ReturnIfFlagState(EventReturnType.Restart, FlagSetting.Off, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=1`, `state=1`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction RestartIfThisEventFlagEnabled()
        => ReturnIfFlagState(EventReturnType.Restart, FlagSetting.On, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=1`, `state=0`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction RestartIfThisEventFlagDisabled()
        => ReturnIfFlagState(EventReturnType.Restart, FlagSetting.Off, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=1`, `state=1`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction RestartIfThisEventSlotFlagEnabled()
        => ReturnIfFlagState(EventReturnType.Restart, FlagSetting.On, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Calls `ReturnIfFlagState` with `event_return_type=1`, `state=0`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction RestartIfThisEventSlotFlagDisabled()
        => ReturnIfFlagState(EventReturnType.Restart, FlagSetting.Off, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfFlagRangeState(byte lineCount, RangeState state, FlagType flagType, uint firstFlag, uint lastFlag)
        => new(1003, 3, lineCount, (byte)state, (byte)flagType, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagRangeState` with `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction SkipLinesIfFlagRangeAllEnabled(byte lineCount, uint firstFlag, uint lastFlag)
        => SkipLinesIfFlagRangeState(lineCount, RangeState.AllOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagRangeState` with `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction SkipLinesIfFlagRangeAllDisabled(byte lineCount, uint firstFlag, uint lastFlag)
        => SkipLinesIfFlagRangeState(lineCount, RangeState.AllOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagRangeState` with `state=2`, `flag_type=0`.
    /// </summary>
    public static Instruction SkipLinesIfFlagRangeAnyEnabled(byte lineCount, uint firstFlag, uint lastFlag)
        => SkipLinesIfFlagRangeState(lineCount, RangeState.AnyOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `SkipLinesIfFlagRangeState` with `state=3`, `flag_type=0`.
    /// </summary>
    public static Instruction SkipLinesIfFlagRangeAnyDisabled(byte lineCount, uint firstFlag, uint lastFlag)
        => SkipLinesIfFlagRangeState(lineCount, RangeState.AnyOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfFlagRangeState(
        EventReturnType eventReturnType,
        RangeState state,
        FlagType flagType,
        uint firstFlag,
        uint lastFlag)
        => new(1003, 4, (byte)eventReturnType, (byte)state, (byte)flagType, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `ReturnIfFlagRangeState` with `event_return_type=0`, `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction EndIfFlagRangeAllEnabled(uint firstFlag, uint lastFlag)
        => ReturnIfFlagRangeState(EventReturnType.End, RangeState.AllOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `ReturnIfFlagRangeState` with `event_return_type=0`, `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction EndIfFlagRangeAllDisabled(uint firstFlag, uint lastFlag)
        => ReturnIfFlagRangeState(EventReturnType.End, RangeState.AllOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `ReturnIfFlagRangeState` with `event_return_type=0`, `state=2`, `flag_type=0`.
    /// </summary>
    public static Instruction EndIfFlagRangeAnyEnabled(uint firstFlag, uint lastFlag)
        => ReturnIfFlagRangeState(EventReturnType.End, RangeState.AnyOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `ReturnIfFlagRangeState` with `event_return_type=0`, `state=3`, `flag_type=0`.
    /// </summary>
    public static Instruction EndIfFlagRangeAnyDisabled(uint firstFlag, uint lastFlag)
        => ReturnIfFlagRangeState(EventReturnType.End, RangeState.AnyOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `ReturnIfFlagRangeState` with `event_return_type=1`, `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction RestartIfFlagRangeAllEnabled(uint firstFlag, uint lastFlag)
        => ReturnIfFlagRangeState(EventReturnType.Restart, RangeState.AllOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `ReturnIfFlagRangeState` with `event_return_type=1`, `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction RestartIfFlagRangeAllDisabled(uint firstFlag, uint lastFlag)
        => ReturnIfFlagRangeState(EventReturnType.Restart, RangeState.AllOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `ReturnIfFlagRangeState` with `event_return_type=1`, `state=2`, `flag_type=0`.
    /// </summary>
    public static Instruction RestartIfFlagRangeAnyEnabled(uint firstFlag, uint lastFlag)
        => ReturnIfFlagRangeState(EventReturnType.Restart, RangeState.AnyOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `ReturnIfFlagRangeState` with `event_return_type=1`, `state=3`, `flag_type=0`.
    /// </summary>
    public static Instruction RestartIfFlagRangeAnyDisabled(uint firstFlag, uint lastFlag)
        => ReturnIfFlagRangeState(EventReturnType.Restart, RangeState.AnyOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfMapPresenceState(byte lineCount, byte state, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => new(1003, 7, lineCount, state, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `SkipLinesIfMapPresenceState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfInsideMap(byte lineCount, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => SkipLinesIfMapPresenceState(lineCount, 1, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `SkipLinesIfMapPresenceState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfOutsideMap(byte lineCount, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => SkipLinesIfMapPresenceState(lineCount, 0, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfMapPresenceState(
        EventReturnType eventReturnType,
        byte state,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => new(1003, 8, (byte)eventReturnType, state, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `ReturnIfMapPresenceState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIfInsideMap(sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => ReturnIfMapPresenceState(EventReturnType.End, 1, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `ReturnIfMapPresenceState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIfOutsideMap(sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => ReturnIfMapPresenceState(EventReturnType.End, 0, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `ReturnIfMapPresenceState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIfInsideMap(sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => ReturnIfMapPresenceState(EventReturnType.Restart, 1, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `ReturnIfMapPresenceState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIfOutsideMap(sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => ReturnIfMapPresenceState(EventReturnType.Restart, 0, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfAssetDestructionState(
        byte lineCount,
        byte state,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(1005, 1, lineCount, state, asset, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfAssetDestructionState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfAssetDestroyed(
        byte lineCount,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => SkipLinesIfAssetDestructionState(lineCount, 1, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfAssetDestructionState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfAssetNotDestroyed(
        byte lineCount,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => SkipLinesIfAssetDestructionState(lineCount, 0, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfAssetDestructionState(
        EventReturnType eventReturnType,
        byte state,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(1005, 2, (byte)eventReturnType, state, asset, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfAssetDestructionState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIfAssetDestroyed(
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => ReturnIfAssetDestructionState(EventReturnType.End, 1, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfAssetDestructionState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIfAssetNotDestroyed(
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => ReturnIfAssetDestructionState(EventReturnType.End, 0, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfAssetDestructionState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIfAssetDestroyed(
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => ReturnIfAssetDestructionState(EventReturnType.Restart, 1, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfAssetDestructionState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIfAssetNotDestroyed(
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => ReturnIfAssetDestructionState(EventReturnType.Restart, 0, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetNetworkSyncState(byte state)
        => new(2000, 2, state);
    
    /// <summary>
    /// Calls `SetNetworkSyncState` with `state=True`.
    /// </summary>
    public static Instruction EnableNetworkSync()
        => SetNetworkSyncState(1);
    
    /// <summary>
    /// Calls `SetNetworkSyncState` with `state=False`.
    /// </summary>
    public static Instruction DisableNetworkSync()
        => SetNetworkSyncState(0);
    
    /// <summary>
    /// Likely clears all conditions currently loaded into the main condition (0).
    /// </summary>
    public static Instruction ClearMainCondition(byte dummy = 0)
        => new(2000, 3, dummy);
    
    /// <summary>
    /// Request the game to save player progress.
    /// </summary>
    public static Instruction SaveRequest(byte dummy = 0)
        => new(2000, 5, dummy);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction StartPS5Activity(int activityID)
        => new(2000, 7, activityID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction EndPS5Activity(int activityID)
        => new(2000, 8, activityID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction PlayCutsceneToAll(int cutsceneID, CutsceneFlags cutsceneFlags)
        => new(2002, 1, cutsceneID, (uint)cutsceneFlags);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction PlayCutsceneToPlayer(int cutsceneID, CutsceneFlags cutsceneFlags, uint playerID)
        => new(2002, 3, cutsceneID, (uint)cutsceneFlags, playerID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction PlayCutsceneToPlayer_Unknown_2002_04(
        int cutsceneID,
        CutsceneFlags cutsceneFlags,
        uint region,
        int unk1216,
        uint playerID,
        int unk2024)
        => new(2002, 4, cutsceneID, (uint)cutsceneFlags, region, unk1216, playerID, unk2024);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction PlayCutsceneToPlayer_Unknown_2002_09(
        int cutsceneID,
        CutsceneFlags cutsceneFlags,
        int unk812,
        int unk1216,
        uint playerID,
        int unk2024,
        byte unk2425,
        byte unk2526,
        float unk2832,
        byte unk3334,
        byte unk3435,
        byte unk3536,
        byte unk3637)
        => new(2002, 9, cutsceneID, (uint)cutsceneFlags, unk812, unk1216, playerID, unk2024, unk2425, unk2526, unk2832, unk3334, unk3435, unk3536, unk3637);
    
    /// <summary>
    /// e.g. the baby skeletons in Tomb of the Giants.
    /// </summary>
    public static Instruction SetSpawnerState(uint entity, byte state)
        => new(2003, 3, entity, state);
    
    /// <summary>
    /// Calls `SetSpawnerState` with `state=True`.
    /// </summary>
    public static Instruction EnableSpawner(uint entity)
        => SetSpawnerState(entity, 1);
    
    /// <summary>
    /// Calls `SetSpawnerState` with `state=False`.
    /// </summary>
    public static Instruction DisableSpawner(uint entity)
        => SetSpawnerState(entity, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction AwardItemLotToAllPlayers(int itemLot)
        => new(2003, 4, itemLot);
    
    /// <summary>
    /// The owner entity sets the 'team' of the projectile (i.e. who it can hurt).
    /// 
    /// You can use this to directly spawn bullets by setting `source_entity` to `owner_entity`.
    /// 
    /// Note that the angle arguments are all integers.
    /// </summary>
    public static Instruction ShootProjectile(
        uint ownerEntity,
        uint sourceEntity,
        int dummyID,
        int behaviorID,
        int launchAngleX,
        int launchAngleY,
        int launchAngleZ)
        => new(2003, 5, ownerEntity, sourceEntity, dummyID, behaviorID, launchAngleX, launchAngleY, launchAngleZ);
    
    /// <summary>
    /// TODO: Unsure how this differs from `SetMapCollisionState`.
    /// </summary>
    public static Instruction SetMapCollisionState_2003_06(uint collision, byte state)
        => new(2003, 6, collision, state);
    
    /// <summary>
    /// Calls `SetMapCollisionState_2003_06` with `state=True`.
    /// </summary>
    public static Instruction EnableMapCollision_2003_06(uint collision)
        => SetMapCollisionState_2003_06(collision, 1);
    
    /// <summary>
    /// Calls `SetMapCollisionState_2003_06` with `state=False`.
    /// </summary>
    public static Instruction DisableMapCollision_2003_06(uint collision)
        => SetMapCollisionState_2003_06(collision, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetMapVisibilityState(uint mapPiece, byte state)
        => new(2003, 7, mapPiece, state);
    
    /// <summary>
    /// Calls `SetMapVisibilityState` with `state=True`.
    /// </summary>
    public static Instruction EnableMapVisibility(uint mapPiece)
        => SetMapVisibilityState(mapPiece, 1);
    
    /// <summary>
    /// Calls `SetMapVisibilityState` with `state=False`.
    /// </summary>
    public static Instruction DisableMapVisibility(uint mapPiece)
        => SetMapVisibilityState(mapPiece, 0);
    
    /// <summary>
    /// Use to manually END or RESTART a given event ID and slot.
    /// </summary>
    public static Instruction SetEventSlotState(uint eventID, int slot, EventReturnType eventReturnType)
        => new(2003, 8, eventID, slot, (byte)eventReturnType);
    
    /// <summary>
    /// Calls `SetEventSlotState` with `event_return_type=0`.
    /// </summary>
    public static Instruction EndEventSlot(uint eventID, int slot)
        => SetEventSlotState(eventID, slot, EventReturnType.End);
    
    /// <summary>
    /// Calls `SetEventSlotState` with `slot=0`, `event_return_type=0`.
    /// </summary>
    public static Instruction EndEvent(uint eventID)
        => SetEventSlotState(eventID, 0, EventReturnType.End);
    
    /// <summary>
    /// Calls `SetEventSlotState` with `event_return_type=1`.
    /// </summary>
    public static Instruction RestartEventSlot(uint eventID, int slot)
        => SetEventSlotState(eventID, slot, EventReturnType.Restart);
    
    /// <summary>
    /// Calls `SetEventSlotState` with `slot=0`, `event_return_type=1`.
    /// </summary>
    public static Instruction RestartEvent(uint eventID)
        => SetEventSlotState(eventID, 0, EventReturnType.Restart);
    
    /// <summary>
    /// Unclear how this differs from calling `ToggleFlag` (which calls `SetEventFlag` with `FlagSetting.Change`).
    /// </summary>
    public static Instruction InvertFlag(uint flag)
        => new(2003, 9, flag);
    
    /// <summary>
    /// Note: slot number can be 0-2 in DS3.
    /// </summary>
    public static Instruction SetBossHealthBarState(uint character, sbyte state, int name = 0, short barSlot = 0)
        => new(2003, 11, state, character, barSlot, name);
    
    /// <summary>
    /// Calls `SetBossHealthBarState` with `state=True`.
    /// The character's health bar will appear at the bottom of the screen, with a name.
    /// </summary>
    public static Instruction EnableBossHealthBar(uint character, int name = 0, short barSlot = 0)
        => SetBossHealthBarState(character, 1, name, barSlot);
    
    /// <summary>
    /// Calls `SetBossHealthBarState` with `state=False`.
    /// 
    /// The character's health bar will disappear from the bottom of the screen.
    /// 
    /// WARNING: Disabling either boss health will disable both of them, and the name_id doesn't matter,
    /// so only the first argument actually does anything. You're welcome to specify the name for
    /// clarity anyway (and vanilla events will show it when decompiled).
    /// </summary>
    public static Instruction DisableBossHealthBar(uint character, int name = 0, short barSlot = 0)
        => SetBossHealthBarState(character, 0, name, barSlot);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction KillBossAndDisplayBanner(uint character, BannerType bannerType)
        => new(2003, 12, character, (byte)bannerType);
    
    /// <summary>
    /// Set given navmesh type.
    /// </summary>
    public static Instruction SetNavmeshType(uint navmeshID, NavmeshType navmeshType, BitOperation operation)
        => new(2003, 13, navmeshID, (uint)navmeshType, (byte)operation);
    
    /// <summary>
    /// Calls `SetNavmeshType` with `operation=0`.
    /// </summary>
    public static Instruction EnableNavmeshType(uint navmeshID, NavmeshType navmeshType)
        => SetNavmeshType(navmeshID, navmeshType, BitOperation.Add);
    
    /// <summary>
    /// Calls `SetNavmeshType` with `operation=1`.
    /// </summary>
    public static Instruction DisableNavmeshType(uint navmeshID, NavmeshType navmeshType)
        => SetNavmeshType(navmeshID, navmeshType, BitOperation.Delete);
    
    /// <summary>
    /// Calls `SetNavmeshType` with `operation=2`.
    /// </summary>
    public static Instruction ToggleNavmeshType(uint navmeshID, NavmeshType navmeshType)
        => SetNavmeshType(navmeshID, navmeshType, BitOperation.Invert);
    
    /// <summary>
    /// Warp the main player to the given player entity ID, which is in the Players tab of the MSB, in some map. By
    /// default, this warps to the 'default position' in the map (-1), which is the same point you would spawn at if
    /// the game lost track of your stable footing (e.g. in 'wrong warp' glitches).
    /// </summary>
    public static Instruction WarpToMap(byte areaID, byte blockID, byte ccID, byte ddID, uint playerStart = 0, int unk812 = 0)
        => new(2003, 14, areaID, blockID, ccID, ddID, playerStart, unk812);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction HandleMinibossDefeat(uint character)
        => new(2003, 15, character);
    
    /// <summary>
    /// Used to make the Bell of Awakening sounds, for example.
    /// </summary>
    public static Instruction TriggerMultiplayerEvent(uint eventID)
        => new(2003, 16, eventID);
    
    /// <summary>
    /// Set the state of a random flag from a given range (inclusive).
    /// </summary>
    public static Instruction SetRandomFlagInRange(uint firstFlag, uint lastFlag, FlagSetting state)
        => new(2003, 17, firstFlag, lastFlag, (byte)state);
    
    /// <summary>
    /// Calls `SetRandomFlagInRange` with `state=1`.
    /// </summary>
    public static Instruction EnableRandomFlagInRange(uint firstFlag, uint lastFlag)
        => SetRandomFlagInRange(firstFlag, lastFlag, FlagSetting.On);
    
    /// <summary>
    /// Calls `SetRandomFlagInRange` with `state=0`.
    /// </summary>
    public static Instruction DisableRandomFlagInRange(uint firstFlag, uint lastFlag)
        => SetRandomFlagInRange(firstFlag, lastFlag, FlagSetting.Off);
    
    /// <summary>
    /// Calls `SetRandomFlagInRange` with `state=2`.
    /// </summary>
    public static Instruction ToggleRandomFlagInRange(uint firstFlag, uint lastFlag)
        => SetRandomFlagInRange(firstFlag, lastFlag, FlagSetting.Change);
    
    /// <summary>
    /// Used a lot. Standard way to make a Character or Asset perform an animation.
    /// </summary>
    public static Instruction ForceAnimation(
        uint entity,
        int animationID,
        byte loop = 0,
        byte waitForCompletion = 0,
        byte skipTransition = 0,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(2003, 18, entity, animationID, loop, waitForCompletion, skipTransition, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Increase NG+ level by one.
    /// </summary>
    public static Instruction IncrementNewGameCycle(byte dummy = 0)
        => new(2003, 21, dummy);
    
    /// <summary>
    /// Set the state of an entire flag range (inclusive).
    /// </summary>
    public static Instruction SetFlagRangeState(uint firstFlag, uint lastFlag, FlagSetting state)
        => new(2003, 22, firstFlag, lastFlag, (byte)state);
    
    /// <summary>
    /// Calls `SetFlagRangeState` with `state=1`.
    /// </summary>
    public static Instruction EnableFlagRange(uint firstFlag, uint lastFlag)
        => SetFlagRangeState(firstFlag, lastFlag, FlagSetting.On);
    
    /// <summary>
    /// Calls `SetFlagRangeState` with `state=0`.
    /// </summary>
    public static Instruction DisableFlagRange(uint firstFlag, uint lastFlag)
        => SetFlagRangeState(firstFlag, lastFlag, FlagSetting.Off);
    
    /// <summary>
    /// Calls `SetFlagRangeState` with `state=2`.
    /// </summary>
    public static Instruction ToggleFlagRange(uint firstFlag, uint lastFlag)
        => SetFlagRangeState(firstFlag, lastFlag, FlagSetting.Change);
    
    /// <summary>
    /// Respawn point is an event set in the MSB.
    /// </summary>
    public static Instruction SetRespawnPoint(uint respawnPoint)
        => new(2003, 23, respawnPoint);
    
    /// <summary>
    /// Item type is automatically detected. This instruction has a 'quantity' argument, but it seems broken, so you
    /// always have to remove *all* instances of the item. (Strangely, the similar command used in EzState doesn't
    /// seem to have this bug.)
    /// 
    /// WARNING: don't confuse 'Item' with the specific item type 'Good'.
    /// 
    /// item_type: Auto-detected from `item` type by default.
    /// </summary>
    public static Instruction RemoveItemFromPlayer(ItemType itemType, int item, int quantity)
        => new(2003, 24, (byte)itemType, item, quantity);
    
    /// <summary>
    /// Calls `RemoveItemFromPlayer` with `item_type=0`.
    /// </summary>
    public static Instruction RemoveWeaponFromPlayer(int item, int quantity)
        => RemoveItemFromPlayer(ItemType.Weapon, item, quantity);
    
    /// <summary>
    /// Calls `RemoveItemFromPlayer` with `item_type=1`.
    /// </summary>
    public static Instruction RemoveArmorFromPlayer(int item, int quantity)
        => RemoveItemFromPlayer(ItemType.Armor, item, quantity);
    
    /// <summary>
    /// Calls `RemoveItemFromPlayer` with `item_type=2`.
    /// </summary>
    public static Instruction RemoveTalismanFromPlayer(int item, int quantity)
        => RemoveItemFromPlayer(ItemType.Talisman, item, quantity);
    
    /// <summary>
    /// Calls `RemoveItemFromPlayer` with `item_type=3`.
    /// </summary>
    public static Instruction RemoveGoodFromPlayer(int item, int quantity)
        => RemoveItemFromPlayer(ItemType.Good, item, quantity);
    
    /// <summary>
    /// If you set a black summon sign, the specified NPC will try to invade automatically.
    /// 
    /// New unknown argument in Elden Ring.
    /// </summary>
    public static Instruction PlaceSummonSign(
        SummonSignType signType,
        uint character,
        uint region,
        uint summonFlag,
        uint dismissalFlag,
        byte unknown)
        => new(2003, 25, (int)signType, character, region, summonFlag, dismissalFlag, unknown);
    
    /// <summary>
    /// Enable or disable developer message. Technically not a 'Soapstone' message anymore, but keeping the name.
    /// </summary>
    public static Instruction SetSoapstoneMessageState(uint messageID, byte state)
        => new(2003, 26, messageID, state);
    
    /// <summary>
    /// Calls `SetSoapstoneMessageState` with `state=True`.
    /// </summary>
    public static Instruction EnableSoapstoneMessage(uint messageID)
        => SetSoapstoneMessageState(messageID, 1);
    
    /// <summary>
    /// Calls `SetSoapstoneMessageState` with `state=False`.
    /// </summary>
    public static Instruction DisableSoapstoneMessage(uint messageID)
        => SetSoapstoneMessageState(messageID, 0);
    
    /// <summary>
    /// For obvious reasons, I *highly* discourage you from abusing this, except in the interest of maintaining the
    /// accessibility of existing achievements. This interacts with Steam, which is always dangerous.
    /// </summary>
    public static Instruction AwardAchievement(int achievementID)
        => new(2003, 28, achievementID);
    
    /// <summary>
    /// You can use a contiguous array of flags as a single value. Use this to increment that value by 1.
    /// 
    /// The array begins at `flag` and extends for `bit_count`. For example, a 'bit_count' of 8 gives you a
    /// theoretical maximum of 256. You can set a 'max_value' less than that to limit the value. (I'm not sure if it
    /// ticks over back to zero if `max_value` is greater than the possible value given the bit count.)
    /// 
    /// The most significant bit is represented at `flag`, and the least significant bit at `flag + bit_count - 1`.
    /// 
    /// This is used for counters in the vanilla game, such as the number of bosses killed while Rhea is at Undead
    /// Parish.
    /// </summary>
    public static Instruction IncrementEventValue(uint flag, uint bitCount, uint maxValue)
        => new(2003, 31, flag, bitCount, maxValue);
    
    /// <summary>
    /// Clears the given multi-flag. This is basically like disabling `bit_count` flags in a row, starting at
    /// `flag`.
    /// </summary>
    public static Instruction ClearEventValue(uint flag, uint bitCount)
        => new(2003, 32, flag, bitCount);
    
    /// <summary>
    /// Move all bloodstains and dropped items from one region to another (I assume). Used to move your
    /// remains out of Gwyndolin's endless corridor.
    /// </summary>
    public static Instruction MoveRemains(uint sourceRegion, uint destinationRegion)
        => new(2003, 35, sourceRegion, destinationRegion);
    
    /// <summary>
    /// You can simply call AwardItemLot() with the same argument, which will redirect here, as you'll almost never
    /// *not* want to award an item lot to the host only.
    /// </summary>
    public static Instruction AwardItemLotToHostOnly(int itemLot)
        => new(2003, 36, itemLot);
    
    /// <summary>
    /// Performs a binary operation on the source flag and operand value, and stores the result in the target flag.
    /// </summary>
    public static Instruction EventValueOperation(
        uint sourceFlag,
        uint sourceFlagBitCount,
        int operand,
        uint targetFlag,
        uint targetFlagBitCount,
        CalculationType calculationType)
        => new(2003, 41, sourceFlag, sourceFlagBitCount, operand, targetFlag, targetFlagBitCount, (sbyte)calculationType);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetAIState(uint character, byte state)
        => new(2004, 1, character, state);
    
    /// <summary>
    /// Calls `SetAIState` with `state=True`.
    /// </summary>
    public static Instruction EnableAI(uint character)
        => SetAIState(character, 1);
    
    /// <summary>
    /// Calls `SetAIState` with `state=False`.
    /// </summary>
    public static Instruction DisableAI(uint character)
        => SetAIState(character, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetTeamType(uint character, TeamType newTeam)
        => new(2004, 2, character, (byte)newTeam);
    
    /// <summary>
    /// Technically a kill 'request.'
    /// </summary>
    public static Instruction Kill(uint character, byte awardRunes = 0)
        => new(2004, 4, character, awardRunes);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetCharacterState(uint character, byte state)
        => new(2004, 5, character, state);
    
    /// <summary>
    /// Calls `SetCharacterState` with `state=True`.
    /// </summary>
    public static Instruction EnableCharacter(uint character)
        => SetCharacterState(character, 1);
    
    /// <summary>
    /// Calls `SetCharacterState` with `state=False`.
    /// </summary>
    public static Instruction DisableCharacter(uint character)
        => SetCharacterState(character, 0);
    
    /// <summary>
    /// Slot number ranges from 0 to 3.
    /// </summary>
    public static Instruction EzstateAIRequest(uint character, int commandID, byte commandSlot)
        => new(2004, 6, character, commandID, commandSlot);
    
    /// <summary>
    /// A 'bullet owner' that will spawn things according to the Spawner section of the MSB.
    /// </summary>
    public static Instruction CreateProjectileOwner(uint entity)
        => new(2004, 7, entity);
    
    /// <summary>
    /// 'Special effect' as in a buff/debuff, not graphical effects (though they may come with one).
    /// </summary>
    public static Instruction AddSpecialEffect(uint character, int specialEffect)
        => new(2004, 8, character, specialEffect);
    
    /// <summary>
    /// Simply determines if the character loses height as it moves around. They will still gain height by running
    /// up slopes.
    /// </summary>
    public static Instruction SetGravityState(uint character, byte state)
        => new(2004, 10, character, state);
    
    /// <summary>
    /// Calls `SetGravityState` with `state=True`.
    /// </summary>
    public static Instruction EnableGravity(uint character)
        => SetGravityState(character, 1);
    
    /// <summary>
    /// Calls `SetGravityState` with `state=False`.
    /// </summary>
    public static Instruction DisableGravity(uint character)
        => SetGravityState(character, 0);
    
    /// <summary>
    /// Likely refers to patrolling behavior.
    /// </summary>
    public static Instruction SetCharacterEventTarget(uint character, uint entity)
        => new(2004, 11, character, entity);
    
    /// <summary>
    /// Character will take damage, but not die (i.e. cannot go below 1 HP).
    /// </summary>
    public static Instruction SetImmortalityState(uint character, byte state)
        => new(2004, 12, character, state);
    
    /// <summary>
    /// Calls `SetImmortalityState` with `state=True`.
    /// </summary>
    public static Instruction EnableImmortality(uint character)
        => SetImmortalityState(character, 1);
    
    /// <summary>
    /// Calls `SetImmortalityState` with `state=False`.
    /// </summary>
    public static Instruction DisableImmortality(uint character)
        => SetImmortalityState(character, 0);
    
    /// <summary>
    /// Home point for entity AI.
    /// </summary>
    public static Instruction SetNest(uint character, uint region)
        => new(2004, 13, character, region);
    
    /// <summary>
    /// Rotate a character to face a target map entity of any type, then optionally force an animation.
    /// 
    /// WARNING: This may crash an event script if `character` is currently disabled!
    /// </summary>
    public static Instruction FaceEntityAndForceAnimation(uint character, uint targetEntity, int animation = -1, byte waitForCompletion = 0)
        => new(2004, 14, character, targetEntity, animation, waitForCompletion);
    
    /// <summary>
    /// Character cannot take damage or die.
    /// </summary>
    public static Instruction SetInvincibilityState(uint character, byte state)
        => new(2004, 15, character, state);
    
    /// <summary>
    /// Calls `SetInvincibilityState` with `state=True`.
    /// </summary>
    public static Instruction EnableInvincibility(uint character)
        => SetInvincibilityState(character, 1);
    
    /// <summary>
    /// Calls `SetInvincibilityState` with `state=False`.
    /// </summary>
    public static Instruction DisableInvincibility(uint character)
        => SetInvincibilityState(character, 0);
    
    /// <summary>
    /// Clear list of targets from character AI.
    /// </summary>
    public static Instruction ClearTargetList(uint character)
        => new(2004, 16, character);
    
    /// <summary>
    /// The given `command_id` can be accessed in AI Lua scripts with `ai:GetEventRequest(slot)`.
    /// </summary>
    public static Instruction AICommand(uint character, int commandID, byte commandSlot)
        => new(2004, 17, character, commandID, commandSlot);
    
    /// <summary>
    /// Not sure what the usage of this is, but it is likely used to change patrol behavior.
    /// </summary>
    public static Instruction SetEventPoint(uint character, uint region, float reactionRange)
        => new(2004, 18, character, region, reactionRange);
    
    /// <summary>
    /// Change character's AI parameter index.
    /// </summary>
    public static Instruction SetAIParamID(uint character, int aiParamID)
        => new(2004, 19, character, aiParamID);
    
    /// <summary>
    /// Clear current AI goal list and force character to replan it.
    /// </summary>
    public static Instruction ReplanAI(uint character)
        => new(2004, 20, character);
    
    /// <summary>
    /// 'Special effect' as in a buff/debuff, not graphical effects (though they may come with one).
    /// </summary>
    public static Instruction RemoveSpecialEffect(uint character, int specialEffect)
        => new(2004, 21, character, specialEffect);
    
    /// <summary>
    /// Complex. Sets specific damage parameters for part of an NPC model. Further changes to the specific part can
    /// be made using the events below. The part is specified using the NPCPartType slot. Look at usage in tail cut
    /// events to understand these more.
    /// </summary>
    public static Instruction CreateNPCPart(
        uint character,
        short npcPartID,
        NPCPartType partIndex,
        int partHealth,
        float damageCorrection = 1.0f,
        float bodyDamageCorrection = 1.0f,
        byte isInvincible = 0,
        byte startInStopState = 0)
        => new(2004, 22, character, npcPartID, (short)partIndex, partHealth, damageCorrection, bodyDamageCorrection, isInvincible, startInStopState);
    
    /// <summary>
    /// You must create the part first.
    /// </summary>
    public static Instruction SetNPCPartHealth(uint character, int npcPartID, int desiredHealth, byte overwriteMax)
        => new(2004, 23, character, npcPartID, desiredHealth, overwriteMax);
    
    /// <summary>
    /// Attach material effects to an NPC part.
    /// </summary>
    public static Instruction SetNPCPartEffects(
        uint character,
        int npcPartID,
        int materialSfxID,
        int materialVfxID,
        int unk1620,
        int unk2024,
        int unk2428)
        => new(2004, 24, character, npcPartID, materialSfxID, materialVfxID, unk1620, unk2024, unk2428);
    
    /// <summary>
    /// Scale the damage dealt to the part. Usually used to set damage to zero, e.g. Smough's hammer.
    /// </summary>
    public static Instruction SetNPCPartBulletDamageScaling(uint character, int npcPartID, float desiredScaling)
        => new(2004, 25, character, npcPartID, desiredScaling);
    
    /// <summary>
    /// Different bits correspond to different parts of the character model. You can see the initial values for
    /// these in the NPC params. This is generally used to disable tails when they are cut off.
    /// 
    /// `switch_type` can be 0 (off), 1 (on), or 2 (change).
    /// </summary>
    public static Instruction SetDisplayMask(uint character, byte bitIndex, OnOffChange switchType)
        => new(2004, 26, character, bitIndex, (byte)switchType);
    
    /// <summary>
    /// See above. This affects the NPC's Collision, not appearance.
    /// </summary>
    public static Instruction SetCollisionMask(uint character, byte bitIndex, OnOffChange switchType)
        => new(2004, 27, character, bitIndex, (byte)switchType);
    
    /// <summary>
    /// Complex; look at existing usage. Authority level must be 'Normal' or 'Forced'.
    /// </summary>
    public static Instruction SetNetworkUpdateAuthority(uint character, UpdateAuthority authorityLevel)
        => new(2004, 28, character, (int)authorityLevel);
    
    /// <summary>
    /// I'm not 100% certain how this differs from the standard Enable(), but I imagine controlling the 'backread'
    /// of a character has a larger effect on game resources. It is used, for example, to disable the Fair Lady and
    /// Eingyi during the Demon Firesage boss fight.
    /// 
    /// Also note reversed bool.
    /// </summary>
    public static Instruction SetBackreadState(uint character, byte remove)
        => new(2004, 29, character, remove);
    
    /// <summary>
    /// Calls `SetBackreadState` with `remove=False`.
    /// </summary>
    public static Instruction EnableBackread(uint character)
        => SetBackreadState(character, 0);
    
    /// <summary>
    /// Calls `SetBackreadState` with `remove=True`.
    /// </summary>
    public static Instruction DisableBackread(uint character)
        => SetBackreadState(character, 1);
    
    /// <summary>
    /// Normal health bar that appears above character.
    /// </summary>
    public static Instruction SetHealthBarState(uint character, byte state)
        => new(2004, 30, character, state);
    
    /// <summary>
    /// Calls `SetHealthBarState` with `state=True`.
    /// </summary>
    public static Instruction EnableHealthBar(uint character)
        => SetHealthBarState(character, 1);
    
    /// <summary>
    /// Calls `SetHealthBarState` with `state=False`.
    /// </summary>
    public static Instruction DisableHealthBar(uint character)
        => SetHealthBarState(character, 0);
    
    /// <summary>
    /// Note that the bool is no longer inverted, as in older games.
    /// </summary>
    public static Instruction SetCharacterCollisionState(uint character, byte state)
        => new(2004, 31, character, state);
    
    /// <summary>
    /// Calls `SetCharacterCollisionState` with `state=True`.
    /// </summary>
    public static Instruction EnableCharacterCollision(uint character)
        => SetCharacterCollisionState(character, 1);
    
    /// <summary>
    /// Calls `SetCharacterCollisionState` with `state=False`.
    /// </summary>
    public static Instruction DisableCharacterCollision(uint character)
        => SetCharacterCollisionState(character, 0);
    
    /// <summary>
    /// All damage dealt to the first character will *also* (not *only*) be dealt to the target entity. I'm not 100%
    /// sure if the target entity can be an Asset.
    /// 
    /// Only used by the Four Kings in the vanilla game.
    /// </summary>
    public static Instruction ReferDamageToEntity(uint character, uint targetEntity)
        => new(2004, 33, character, targetEntity);
    
    /// <summary>
    /// Not sure what 'is_fixed' does. I believe only 'Always' and 'Never' are used in the vanilla game.
    /// </summary>
    public static Instruction SetNetworkUpdateRate(uint character, byte isFixed, CharacterUpdateRate updateRate)
        => new(2004, 34, character, isFixed, (sbyte)updateRate);
    
    /// <summary>
    /// I have no idea how this differs from the standard backread function above.
    /// </summary>
    public static Instruction SetBackreadStateAlternate(uint character, byte state)
        => new(2004, 35, character, state);
    
    /// <summary>
    /// This will disable the character and spawn any treasure they would drop. It's possible that it only spawns
    /// treasure that has a 100% drop rate, hence the name, but I haven't confirmed this.
    /// </summary>
    public static Instruction DropMandatoryTreasure(uint character)
        => new(2004, 37, character);
    
    /// <summary>
    /// Dummy argument does nothing.
    /// </summary>
    public static Instruction BetrayCurrentCovenant(byte dummy = 0)
        => new(2004, 38, dummy);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetAnimationsState(uint entity, byte state)
        => new(2004, 39, entity, state);
    
    /// <summary>
    /// Calls `SetAnimationsState` with `state=True`.
    /// </summary>
    public static Instruction EnableAnimations(uint entity)
        => SetAnimationsState(entity, 1);
    
    /// <summary>
    /// Calls `SetAnimationsState` with `state=False`.
    /// </summary>
    public static Instruction DisableAnimations(uint entity)
        => SetAnimationsState(entity, 0);
    
    /// <summary>
    /// TODO
    /// destination_type: Auto-detected from `destination` type by default.
    /// </summary>
    public static Instruction MoveAndSetDrawParent(
        uint character,
        CoordEntityType destinationType,
        uint destination,
        int dummyID,
        uint setDrawParent)
        => new(2004, 40, character, (byte)destinationType, destination, dummyID, setDrawParent);
    
    /// <summary>
    /// TODO
    /// destination_type: Auto-detected from `destination` type by default.
    /// </summary>
    public static Instruction ShortMove(uint character, CoordEntityType destinationType, uint destination, int dummyID)
        => new(2004, 41, character, (byte)destinationType, destination, dummyID);
    
    /// <summary>
    /// TODO
    /// destination_type: Auto-detected from `destination` type by default.
    /// </summary>
    public static Instruction MoveAndCopyDrawParent(
        uint character,
        CoordEntityType destinationType,
        uint destination,
        int dummyID,
        uint copyDrawParent)
        => new(2004, 42, character, (byte)destinationType, destination, dummyID, copyDrawParent);
    
    /// <summary>
    /// Cancels an animation. Note the inverted bool for controlling interpolation.
    /// </summary>
    public static Instruction ResetAnimation(uint character, byte disableInterpolation = 0)
        => new(2004, 43, character, disableInterpolation);
    
    /// <summary>
    /// Unknown effect. Only used in Battle of Stoicism, so likely useless to you.
    /// </summary>
    public static Instruction EqualRecovery()
        => new(2004, 47);
    
    /// <summary>
    /// Technically 'requests' the asset's destruction. No idea what the slot number does.
    /// </summary>
    public static Instruction DestroyAsset(uint asset, sbyte requestSlot = 1)
        => new(2005, 1, asset, requestSlot);
    
    /// <summary>
    /// The opposite of destruction. Restores it to its original MSB coordinates.
    /// </summary>
    public static Instruction RestoreAsset(uint asset)
        => new(2005, 2, asset);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetAssetState(uint asset, byte state)
        => new(2005, 3, asset, state);
    
    /// <summary>
    /// Calls `SetAssetState` with `state=True`.
    /// </summary>
    public static Instruction EnableAsset(uint asset)
        => SetAssetState(asset, 1);
    
    /// <summary>
    /// Calls `SetAssetState` with `state=False`.
    /// </summary>
    public static Instruction DisableAsset(uint asset)
        => SetAssetState(asset, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetTreasureState(uint asset, byte state)
        => new(2005, 4, asset, state);
    
    /// <summary>
    /// Calls `SetTreasureState` with `state=True`.
    /// Enables any treasure attached to this asset by MSB events.
    /// </summary>
    public static Instruction EnableTreasure(uint asset)
        => SetTreasureState(asset, 1);
    
    /// <summary>
    /// Calls `SetTreasureState` with `state=False`.
    /// 
    /// Disables any treasure attached to this asset by MSB events.
    /// 
    /// If you want to disable treasure by default, you can do it in the MSB by changing a certain event
    /// value to 255.
    /// </summary>
    public static Instruction DisableTreasure(uint asset)
        => SetTreasureState(asset, 0);
    
    /// <summary>
    /// Manually call a specific ObjAct event attached to this asset. I believe 'relative_index' refers to the
    /// points on the asset at which it can be activated (e.g. which side of a gate you are on).
    /// 
    /// Note that this will 'grab' a nearby NPC and force the appropriate animation from ObjAct params, which is how
    /// the game gets Patches to pull the lever in the Catacombs.
    /// </summary>
    public static Instruction ActivateAsset(uint asset, int objActID, int relativeIndex)
        => new(2005, 5, asset, objActID, relativeIndex);
    
    /// <summary>
    /// Sets whether the asset can be activated (1) or not activated (0).
    /// </summary>
    public static Instruction SetAssetActivation(uint asset, int objActID, byte state)
        => new(2005, 6, asset, objActID, state);
    
    /// <summary>
    /// Sets entity to whatever state it would have after the given animation. Used often to open doors that have
    /// already been opened when you reload the map, etc. I doubt it can be used with characters, but haven't
    /// confirmed.
    /// </summary>
    public static Instruction EndOfAnimation(uint asset, int animationID)
        => new(2005, 7, asset, animationID);
    
    /// <summary>
    /// Sets the asset to whatever appearance it would have after being destroyed. Again, not sure what 'slot'
    /// does, but it's literally *always* 1 in vanilla scripts (and from my testing, the instruction doesn't work
    /// with `slot=0`).
    /// </summary>
    public static Instruction PostDestruction(uint asset, sbyte requestSlot = 1)
        => new(2005, 8, asset, requestSlot);
    
    /// <summary>
    /// Turn an asset into an environmental hazard. It deals damage when touched according to the NPC Behavior
    /// params you give it. The dummy_id determines which part of the asset is hazardous (with the given radius
    /// and life, relative to the time this instruction occurs).
    /// 
    /// An example is the large fire in the Lower Undead Burg, or near the first Armored Tusk.
    /// 
    /// 'target_type' determines what the hazard can damage (Character and/or Map).
    /// </summary>
    public static Instruction CreateHazard(
        uint assetFlag,
        uint asset,
        int dummyID,
        int behaviorParamID,
        DamageTargetType targetType,
        float radius,
        float life,
        float repetitionTime)
        => new(2005, 9, assetFlag, asset, dummyID, behaviorParamID, (int)targetType, radius, life, repetitionTime);
    
    /// <summary>
    /// Move an asset to a character.
    /// </summary>
    public static Instruction MoveAssetToCharacter(uint asset, uint character, short dummyID = -1)
        => new(2005, 11, asset, character, dummyID);
    
    /// <summary>
    /// No idea what this does. I believe it might undo the CreateHazard instruction, at least.
    /// </summary>
    public static Instruction RemoveAssetFlag(uint assetFlag)
        => new(2005, 12, assetFlag);
    
    /// <summary>
    /// 1 = invulnerable.
    /// </summary>
    public static Instruction SetAssetInvulnerabilityState(uint asset, byte state)
        => new(2005, 13, asset, state);
    
    /// <summary>
    /// Calls `SetAssetInvulnerabilityState` with `state=True`.
    /// </summary>
    public static Instruction EnableAssetInvulnerability(uint asset)
        => SetAssetInvulnerabilityState(asset, 1);
    
    /// <summary>
    /// Calls `SetAssetInvulnerabilityState` with `state=False`.
    /// </summary>
    public static Instruction DisableAssetInvulnerability(uint asset)
        => SetAssetInvulnerabilityState(asset, 0);
    
    /// <summary>
    /// Similar to SetAssetActivation, but you can provide the relative index to disable (e.g. one side of a door).
    /// </summary>
    public static Instruction SetAssetActivationWithIdx(uint asset, int objActID, int relativeIndex, byte state)
        => new(2005, 14, asset, objActID, relativeIndex, state);
    
    /// <summary>
    /// Forces an asset to spawn its treasure, even if the treasure's ItemLot flag is already enabled.
    /// 
    /// Useful if you want some treasure to reappear (after, say, taking it from the player and disabling the
    /// ItemLot flag) without the player needing to reload the map.
    /// </summary>
    public static Instruction EnableTreasureCollection(uint asset)
        => new(2005, 15, asset);
    
    /// <summary>
    /// Delete visual VFX. If 'erase_root_only' is True (default), effect particles already emitted will live out
    /// the rest of their lifetimes (e.g. making a fog gate disappear organically). The ID is given in the MSB.
    /// </summary>
    public static Instruction DeleteVFX(uint vfxID, byte eraseRootOnly = 1)
        => new(2006, 1, vfxID, eraseRootOnly);
    
    /// <summary>
    /// Create visual VFX. The ID is given in the MSB (e.g. fog effect for boss gates and checkpoints).
    /// </summary>
    public static Instruction CreateVFX(uint vfxID)
        => new(2006, 2, vfxID);
    
    /// <summary>
    /// Create one-off visual VFX (an FFX ID) attached to the given 'anchor_entity'. The VFX, of course, must be
    /// currently loaded (or in common effects).
    /// 
    /// anchor_type: Auto-detected from `anchor_entity` type by default. Sets `Character` type for `PLAYER`.
    /// </summary>
    public static Instruction CreateTemporaryVFX(CoordEntityType anchorType, uint anchorEntity, int dummyID, int vfxID)
        => new(2006, 3, (int)anchorType, anchorEntity, dummyID, vfxID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction CreateAssetVFX(uint asset, int dummyID, int vfxID)
        => new(2006, 4, asset, dummyID, vfxID);
    
    /// <summary>
    /// Note `erase_root` vs. `erase_root_only` for map SFX.
    /// </summary>
    public static Instruction DeleteAssetVFX(uint asset, int eraseRoot = 1)
        => new(2006, 5, asset, eraseRoot);
    
    /// <summary>
    /// Display a dialog box at the bottom of the screen. You can't use this to get player input, but you can
    /// display short simple messages. It defaults to a box with no buttons (which is still dismissed when you press
    /// A).
    /// 
    /// The 'display_distance' argument specifies how far you can move away from the 'anchor_entity' before the
    /// message automatically disappears. If `anchor_entity=-1` (default), some kind of default anchor is used
    /// (probably just the position where the player was standing).
    /// </summary>
    public static Instruction DisplayDialog(
        int text,
        uint anchorEntity = 0,
        float displayDistance = 3.0f,
        ButtonType buttonType = ButtonType.OK_or_Cancel,
        NumberButtons numberButtons = NumberButtons.NoButton)
        => new(2007, 1, text, (short)buttonType, (short)numberButtons, anchorEntity, displayDistance);
    
    /// <summary>
    /// Display a pre-rendered banner. You'll have to change the textures (in menu_local.tpf) to change them.
    /// </summary>
    public static Instruction DisplayBanner(BannerType bannerType)
        => new(2007, 2, (byte)bannerType);
    
    /// <summary>
    /// Displays a large message that appears at the top of the screen, such as the message that tells you how to
    /// remove your curse, or that the golden fog gates block your path. If 'pad_enabled' is False, you can't get
    /// rid of the message until it times out on its own.
    /// </summary>
    public static Instruction DisplayStatus(int text, byte padEnabled = 1)
        => new(2007, 3, text, padEnabled);
    
    /// <summary>
    /// Displays a flashing messages at the bottom of the screen that does not block player input.
    /// </summary>
    public static Instruction DisplayFlashingMessage(int text)
        => new(2007, 4, text);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction DisplayFullScreenMessage(int text)
        => new(2007, 9, text);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ChangeCamera(int normalCameraID, int lockedCameraID)
        => new(2008, 1, normalCameraID, lockedCameraID);
    
    /// <summary>
    /// TODO
    /// anchor_type: Auto-detected from `anchor_entity` type by default.
    /// </summary>
    public static Instruction SetCameraVibration(
        int vibrationID,
        CoordEntityType anchorType,
        uint anchorEntity,
        int dummyID,
        float decayStartDistance,
        float decayEndDistance)
        => new(2008, 2, vibrationID, (int)anchorType, anchorEntity, dummyID, decayStartDistance, decayEndDistance);
    
    /// <summary>
    /// Switch between one of two camera slots associated with the player's current collision in the MSB.
    /// 
    /// Applies to area and block, not specific map CC/DD values.
    /// </summary>
    public static Instruction SetLockedCameraSlot(byte areaID, byte blockID, ushort cameraSlot)
        => new(2008, 3, areaID, blockID, cameraSlot);
    
    /// <summary>
    /// Don't mess with these flags, generally; you can just delay when this is called after map load to disable
    /// certain ladders (which is kind of weird anyway).
    /// </summary>
    public static Instruction RegisterLadder(uint startClimbingFlag, uint stopClimbingFlag, uint asset)
        => new(2009, 0, startClimbingFlag, stopClimbingFlag, asset);
    
    /// <summary>
    /// Register a Site of Grace, which creates the VFX and allows you to interact with it via the MSB character
    /// with ID `(asset + 1000)`.
    /// 
    /// I believe the grace flag tells the game where to keep track of its kindle level, or something like that. I
    /// don't recommend messing around with this much. The reaction distance, angle, and initial kindle level are
    /// all set to their standard defaults.
    /// 
    /// You can also use `enemy_block_distance` to set the minimum distance that enemies must be at to allow the
    /// Grace to be interacted with.
    /// </summary>
    public static Instruction RegisterGrace(
        uint graceFlag,
        uint asset,
        float reactionDistance = 0.0f,
        float reactionAngle = 0.0f,
        int initialKindleLevel = 0,
        float enemyBlockDistance = 5.0f)
        => new(2009, 3, graceFlag, asset, reactionDistance, reactionAngle, initialKindleLevel, enemyBlockDistance);
    
    /// <summary>
    /// Used to strengthen bosses based on the number of summons you have. Not sure if it works for every NPC. It
    /// could also be tied to certain special effects; haven't checked that yet.
    /// </summary>
    public static Instruction ActivateMultiplayerBuffs(uint character)
        => new(2009, 4, character);
    
    /// <summary>
    /// Sends the message to all summons that the host has challenged the boss.
    /// </summary>
    public static Instruction NotifyBossBattleStart(byte dummy = 0)
        => new(2009, 6, dummy);
    
    /// <summary>
    /// Anchor entity determines sound position and the sound type is used to look up the source.
    /// </summary>
    public static Instruction PlaySoundEffect(uint anchorEntity, int soundID, SoundType soundType)
        => new(2010, 2, anchorEntity, (int)soundType, soundID);
    
    /// <summary>
    /// Enable or disable a map collision (HKX). The ID is specified in the MSB. Note that a Collision doesn't have
    /// to be solid ground, but could be anything triggered by collision, such as a kill plane (which this is often
    /// used to disable).
    /// </summary>
    public static Instruction SetMapCollisionState(uint collision, byte state)
        => new(2011, 1, collision, state);
    
    /// <summary>
    /// Calls `SetMapCollisionState` with `state=True`.
    /// </summary>
    public static Instruction EnableMapCollision(uint collision)
        => SetMapCollisionState(collision, 1);
    
    /// <summary>
    /// Calls `SetMapCollisionState` with `state=False`.
    /// </summary>
    public static Instruction DisableMapCollision(uint collision)
        => SetMapCollisionState(collision, 0);
    
    /// <summary>
    /// Unused.
    /// </summary>
    public static Instruction SetMapCollisionBackreadMaskState(uint collision, byte state)
        => new(2011, 2, collision, state);
    
    /// <summary>
    /// Calls `SetMapCollisionBackreadMaskState` with `state=True`.
    /// </summary>
    public static Instruction EnableMapCollisionBackreadMask(uint collision)
        => SetMapCollisionBackreadMaskState(collision, 1);
    
    /// <summary>
    /// Calls `SetMapCollisionBackreadMaskState` with `state=False`.
    /// </summary>
    public static Instruction DisableMapCollisionBackreadMask(uint collision)
        => SetMapCollisionBackreadMaskState(collision, 0);
    
    /// <summary>
    /// Set the visibility of individual map pieces (e.g. all the crystals in Seath's tower).
    /// </summary>
    public static Instruction SetMapPieceState(uint mapPieceID, byte state)
        => new(2012, 1, mapPieceID, state);
    
    /// <summary>
    /// Calls `SetMapPieceState` with `state=True`.
    /// </summary>
    public static Instruction EnableMapPiece(uint mapPieceID)
        => SetMapPieceState(mapPieceID, 1);
    
    /// <summary>
    /// Calls `SetMapPieceState` with `state=False`.
    /// </summary>
    public static Instruction DisableMapPiece(uint mapPieceID)
        => SetMapPieceState(mapPieceID, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfUnsignedComparison(ConditionGroup condition, ComparisonType comparisonType, uint left, uint right)
        => new(0, 2, (sbyte)condition, (sbyte)comparisonType, left, right);
    
    /// <summary>
    /// Calls `IfUnsignedComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction IfUnsignedEqual(ConditionGroup condition, uint left, uint right)
        => IfUnsignedComparison(condition, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `IfUnsignedComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction IfUnsignedNotEqual(ConditionGroup condition, uint left, uint right)
        => IfUnsignedComparison(condition, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `IfUnsignedComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction IfUnsignedGreaterThan(ConditionGroup condition, uint left, uint right)
        => IfUnsignedComparison(condition, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `IfUnsignedComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction IfUnsignedLessThan(ConditionGroup condition, uint left, uint right)
        => IfUnsignedComparison(condition, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `IfUnsignedComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction IfUnsignedGreaterThanOrEqual(ConditionGroup condition, uint left, uint right)
        => IfUnsignedComparison(condition, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `IfUnsignedComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction IfUnsignedLessThanOrEqual(ConditionGroup condition, uint left, uint right)
        => IfUnsignedComparison(condition, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfAttackedWithDamageType(
        ConditionGroup condition,
        uint attackedEntity,
        uint attacker = 0,
        DamageType damageType = DamageType.Unspecified)
        => new(3, 23, (sbyte)condition, attackedEntity, attacker, (byte)damageType);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfActionButtonParamActivated(ConditionGroup condition, int actionButtonID, uint entity)
        => new(3, 24, (sbyte)condition, actionButtonID, entity);
    
    /// <summary>
    /// Excluding Arena.
    /// </summary>
    public static Instruction IfPlayerOwnWorldState(ConditionGroup condition, byte notInOwnWorld)
        => new(3, 26, (sbyte)condition, notInOwnWorld);
    
    /// <summary>
    /// Calls `IfPlayerOwnWorldState` with `not_in_own_world=False`.
    /// </summary>
    public static Instruction IfPlayerInOwnWorld(ConditionGroup condition)
        => IfPlayerOwnWorldState(condition, 0);
    
    /// <summary>
    /// Calls `IfPlayerOwnWorldState` with `not_in_own_world=True`.
    /// </summary>
    public static Instruction IfPlayerNotInOwnWorld(ConditionGroup condition)
        => IfPlayerOwnWorldState(condition, 1);
    
    /// <summary>
    /// Only used in Radahn fight, I believe, with map tiles.
    /// </summary>
    public static Instruction IfMapLoaded(ConditionGroup condition, byte areaID, byte blockID, byte ccID, byte ddID)
        => new(3, 30, (sbyte)condition, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfWeatherState(ConditionGroup condition, Weather weather, float unk48, float unk812)
        => new(3, 31, (sbyte)condition, (sbyte)weather, unk48, unk812);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfMapUpdatePermissionState(
        ConditionGroup condition,
        byte state,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => new(3, 32, (sbyte)condition, state, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `IfMapUpdatePermissionState` with `state=True`.
    /// </summary>
    public static Instruction IfMapHasUpdatePermission(
        ConditionGroup condition,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => IfMapUpdatePermissionState(condition, 1, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `IfMapUpdatePermissionState` with `state=False`.
    /// </summary>
    public static Instruction IfMapDoesNotHaveUpdatePermission(
        ConditionGroup condition,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => IfMapUpdatePermissionState(condition, 0, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfFieldBattleMusicState(ConditionGroup condition, uint npcThreatLevel, byte state)
        => new(3, 33, (sbyte)condition, npcThreatLevel, state);
    
    /// <summary>
    /// Calls `IfFieldBattleMusicState` with `state=True`.
    /// </summary>
    public static Instruction IfFieldBattleMusicEnabled(ConditionGroup condition, uint npcThreatLevel)
        => IfFieldBattleMusicState(condition, npcThreatLevel, 1);
    
    /// <summary>
    /// Calls `IfFieldBattleMusicState` with `state=False`.
    /// </summary>
    public static Instruction IfFieldBattleMusicDisabled(ConditionGroup condition, uint npcThreatLevel)
        => IfFieldBattleMusicState(condition, npcThreatLevel, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerHasArmorEquipped(ConditionGroup condition, ArmorType armorType, int armor, int unk812 = -1)
        => new(3, 34, (sbyte)condition, (byte)armorType, armor, unk812);
    
    /// <summary>
    /// Calls `IfPlayerHasArmorEquipped` with `armor_type=0`.
    /// </summary>
    public static Instruction IfPlayerHasHeadArmorEquipped(ConditionGroup condition, int armor, int unk812 = -1)
        => IfPlayerHasArmorEquipped(condition, ArmorType.Head, armor, unk812);
    
    /// <summary>
    /// Calls `IfPlayerHasArmorEquipped` with `armor_type=1`.
    /// </summary>
    public static Instruction IfPlayerHasBodyArmorEquipped(ConditionGroup condition, int armor, int unk812 = -1)
        => IfPlayerHasArmorEquipped(condition, ArmorType.Body, armor, unk812);
    
    /// <summary>
    /// Calls `IfPlayerHasArmorEquipped` with `armor_type=2`.
    /// </summary>
    public static Instruction IfPlayerHasArmsArmorEquipped(ConditionGroup condition, int armor, int unk812 = -1)
        => IfPlayerHasArmorEquipped(condition, ArmorType.Arms, armor, unk812);
    
    /// <summary>
    /// Calls `IfPlayerHasArmorEquipped` with `armor_type=3`.
    /// </summary>
    public static Instruction IfPlayerHasLegsArmorEquipped(ConditionGroup condition, int armor, int unk812 = -1)
        => IfPlayerHasArmorEquipped(condition, ArmorType.Legs, armor, unk812);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCeremonyState(ConditionGroup condition, byte state, int ceremony)
        => new(3, 35, (sbyte)condition, state, ceremony);
    
    /// <summary>
    /// Calls `IfCeremonyState` with `state=True`.
    /// </summary>
    public static Instruction IfCeremonyActive(ConditionGroup condition, int ceremony)
        => IfCeremonyState(condition, 1, ceremony);
    
    /// <summary>
    /// Calls `IfCeremonyState` with `state=False`.
    /// </summary>
    public static Instruction IfCeremonyInactive(ConditionGroup condition, int ceremony)
        => IfCeremonyState(condition, 0, ceremony);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfWeatherLotState(ConditionGroup condition, int weatherLotParamID, byte state)
        => new(3, 37, (sbyte)condition, weatherLotParamID, state);
    
    /// <summary>
    /// Calls `IfWeatherLotState` with `state=True`.
    /// </summary>
    public static Instruction IfWeatherLotActive(ConditionGroup condition, int weatherLotParamID)
        => IfWeatherLotState(condition, weatherLotParamID, 1);
    
    /// <summary>
    /// Calls `IfWeatherLotState` with `state=False`.
    /// </summary>
    public static Instruction IfWeatherLotInactive(ConditionGroup condition, int weatherLotParamID)
        => IfWeatherLotState(condition, weatherLotParamID, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerGender(ConditionGroup condition, Gender gender)
        => new(3, 38, (sbyte)condition, (byte)gender);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfArenaMatchReadyState(ConditionGroup condition, byte ready)
        => new(3, 39, (sbyte)condition, ready);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfArenaSoloResult(ConditionGroup condition, ArenaResult result)
        => new(3, 40, (sbyte)condition, (byte)result);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfArenaSoloScoreComparison(ConditionGroup condition, ComparisonType comparisonType, int score)
        => new(3, 41, (sbyte)condition, (sbyte)comparisonType, score);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfArenaTeamResults(ConditionGroup condition, ArenaResult result)
        => new(3, 42, (sbyte)condition, (byte)result);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfArenaTeamScoreComparison(ConditionGroup condition, ComparisonType comparisonType, int score)
        => new(3, 43, (sbyte)condition, (sbyte)comparisonType, score);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfArenaMatchType(ConditionGroup condition, ArenaMatchType matchType, byte hasSpiritSummon)
        => new(3, 44, (sbyte)condition, (byte)matchType, hasSpiritSummon);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerRespawnedInArena(ConditionGroup condition)
        => new(3, 45, (sbyte)condition);
    
    /// <summary>
    /// Checks if a proportion (0-1) of given characters (group entity ID) are dead or alive.
    /// </summary>
    public static Instruction IfCharacterProportionDeathState(
        ConditionGroup condition,
        uint character,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetProportion = 1.0f)
        => new(4, 15, (sbyte)condition, character, state, (sbyte)targetComparisonType, targetProportion);
    
    /// <summary>
    /// Calls `IfCharacterProportionDeathState` with `state=True`.
    /// </summary>
    public static Instruction IfCharacterProportionDead(
        ConditionGroup condition,
        uint character,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetProportion = 1.0f)
        => IfCharacterProportionDeathState(condition, character, 1, targetComparisonType, targetProportion);
    
    /// <summary>
    /// Calls `IfCharacterProportionDeathState` with `state=False`.
    /// </summary>
    public static Instruction IfCharacterProportionAlive(
        ConditionGroup condition,
        uint character,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetProportion = 1.0f)
        => IfCharacterProportionDeathState(condition, character, 0, targetComparisonType, targetProportion);
    
    /// <summary>
    /// Checks if a certain proportion of the given characters (group entity ID) have or do not have a given
    /// special effect, rather than a certain absolute count.
    /// </summary>
    public static Instruction IfCharacterProportionSpecialEffectState(
        ConditionGroup condition,
        uint characterGroup,
        int specialEffect,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetProportion = 1.0f)
        => new(4, 19, (sbyte)condition, characterGroup, specialEffect, state, (sbyte)targetComparisonType, targetProportion);
    
    /// <summary>
    /// Calls `IfCharacterProportionSpecialEffectState` with `state=True`.
    /// </summary>
    public static Instruction IfCharacterProportionHasSpecialEffect(
        ConditionGroup condition,
        uint characterGroup,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetProportion = 1.0f)
        => IfCharacterProportionSpecialEffectState(condition, characterGroup, specialEffect, 1, targetComparisonType, targetProportion);
    
    /// <summary>
    /// Calls `IfCharacterProportionSpecialEffectState` with `state=False`.
    /// </summary>
    public static Instruction IfCharacterProportionDoesNotHaveSpecialEffect(
        ConditionGroup condition,
        uint characterGroup,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetProportion = 1.0f)
        => IfCharacterProportionSpecialEffectState(condition, characterGroup, specialEffect, 0, targetComparisonType, targetProportion);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfPlayerTargeted(ConditionGroup condition, uint minNpcThreatLevel, uint maxNpcThreatLevel, AIStatusType aiStatus)
        => new(4, 28, (sbyte)condition, minNpcThreatLevel, maxNpcThreatLevel, (byte)aiStatus);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfNPCPartAttackedWithDamageType(
        ConditionGroup condition,
        uint character,
        int npcPartID,
        uint attacker = 0,
        DamageType damageType = DamageType.Unspecified)
        => new(4, 30, (sbyte)condition, character, npcPartID, attacker, (byte)damageType);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterInvadeType(
        ConditionGroup condition,
        uint character,
        CharacterType invadeType,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 31, (sbyte)condition, character, (byte)invadeType, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfCharacterMountState(ConditionGroup condition, uint character, byte isMounted)
        => new(4, 32, (sbyte)condition, character, isMounted);
    
    /// <summary>
    /// Calls `IfCharacterMountState` with `is_mounted=True`.
    /// </summary>
    public static Instruction IfCharacterMounted(ConditionGroup condition, uint character)
        => IfCharacterMountState(condition, character, 1);
    
    /// <summary>
    /// Calls `IfCharacterMountState` with `is_mounted=False`.
    /// </summary>
    public static Instruction IfCharacterNotMounted(ConditionGroup condition, uint character)
        => IfCharacterMountState(condition, character, 0);
    
    /// <summary>
    /// Checks if character has or does not have the given `state_info` (from a SpEffect).
    /// </summary>
    public static Instruction IfCharacterStateInfoState(
        ConditionGroup condition,
        uint character,
        short stateInfo,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(4, 34, (sbyte)condition, character, stateInfo, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterStateInfoState` with `state=True`.
    /// </summary>
    public static Instruction IfCharacterHasStateInfo(
        ConditionGroup condition,
        uint character,
        short stateInfo,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterStateInfoState(condition, character, stateInfo, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfCharacterStateInfoState` with `state=False`.
    /// </summary>
    public static Instruction IfCharacterDoesNotHaveStateInfo(
        ConditionGroup condition,
        uint character,
        short stateInfo,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfCharacterStateInfoState(condition, character, stateInfo, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfSpecialStandbyEndedFlagState(ConditionGroup condition, uint character, byte state)
        => new(4, 35, (sbyte)condition, character, state);
    
    /// <summary>
    /// Calls `IfSpecialStandbyEndedFlagState` with `state=True`.
    /// </summary>
    public static Instruction IfSpecialStandbyEndedFlagEnabled(ConditionGroup condition, uint character)
        => IfSpecialStandbyEndedFlagState(condition, character, 1);
    
    /// <summary>
    /// Calls `IfSpecialStandbyEndedFlagState` with `state=False`.
    /// </summary>
    public static Instruction IfSpecialStandbyEndedFlagDisabled(ConditionGroup condition, uint character)
        => IfSpecialStandbyEndedFlagState(condition, character, 0);
    
    /// <summary>
    /// Check if a certain proportion of given assets (group entity ID) have or have not been destroyed.
    /// </summary>
    public static Instruction IfAssetProportionDestructionState(
        ConditionGroup condition,
        byte state,
        uint assetGroup,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetProportion = 1.0f)
        => new(5, 6, (sbyte)condition, state, assetGroup, (sbyte)targetComparisonType, targetProportion);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IfAssetBackreadState(
        ConditionGroup condition,
        uint asset,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(5, 10, (sbyte)condition, asset, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetBackreadState` with `state=True`.
    /// </summary>
    public static Instruction IfAssetBackreadEnabled(
        ConditionGroup condition,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetBackreadState(condition, asset, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `IfAssetBackreadState` with `state=False`.
    /// </summary>
    public static Instruction IfAssetBackreadDisabled(
        ConditionGroup condition,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => IfAssetBackreadState(condition, asset, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfUnsignedComparison(byte lineCount, ComparisonType comparisonType, uint left, uint right)
        => new(1000, 10, lineCount, (sbyte)comparisonType, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfUnsignedComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction SkipLinesIfUnsignedEqual(byte lineCount, uint left, uint right)
        => SkipLinesIfUnsignedComparison(lineCount, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfUnsignedComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction SkipLinesIfUnsignedNotEqual(byte lineCount, uint left, uint right)
        => SkipLinesIfUnsignedComparison(lineCount, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfUnsignedComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction SkipLinesIfUnsignedGreaterThan(byte lineCount, uint left, uint right)
        => SkipLinesIfUnsignedComparison(lineCount, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfUnsignedComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction SkipLinesIfUnsignedLessThan(byte lineCount, uint left, uint right)
        => SkipLinesIfUnsignedComparison(lineCount, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfUnsignedComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction SkipLinesIfUnsignedGreaterThanOrEqual(byte lineCount, uint left, uint right)
        => SkipLinesIfUnsignedComparison(lineCount, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `SkipLinesIfUnsignedComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction SkipLinesIfUnsignedLessThanOrEqual(byte lineCount, uint left, uint right)
        => SkipLinesIfUnsignedComparison(lineCount, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfUnsignedComparison(EventReturnType eventReturnType, ComparisonType comparisonType, uint left, uint right)
        => new(1000, 11, (byte)eventReturnType, (sbyte)comparisonType, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=0`, `comparison_type=0`.
    /// </summary>
    public static Instruction EndIfUnsignedEqual(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.End, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=0`, `comparison_type=1`.
    /// </summary>
    public static Instruction EndIfUnsignedNotEqual(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.End, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=0`, `comparison_type=2`.
    /// </summary>
    public static Instruction EndIfUnsignedGreaterThan(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.End, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=0`, `comparison_type=3`.
    /// </summary>
    public static Instruction EndIfUnsignedLessThan(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.End, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=0`, `comparison_type=4`.
    /// </summary>
    public static Instruction EndIfUnsignedGreaterThanOrEqual(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.End, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=0`, `comparison_type=5`.
    /// </summary>
    public static Instruction EndIfUnsignedLessThanOrEqual(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.End, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=1`, `comparison_type=0`.
    /// </summary>
    public static Instruction RestartIfUnsignedEqual(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.Restart, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=1`, `comparison_type=1`.
    /// </summary>
    public static Instruction RestartIfUnsignedNotEqual(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.Restart, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=1`, `comparison_type=2`.
    /// </summary>
    public static Instruction RestartIfUnsignedGreaterThan(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.Restart, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=1`, `comparison_type=3`.
    /// </summary>
    public static Instruction RestartIfUnsignedLessThan(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.Restart, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=1`, `comparison_type=4`.
    /// </summary>
    public static Instruction RestartIfUnsignedGreaterThanOrEqual(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.Restart, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `ReturnIfUnsignedComparison` with `event_return_type=1`, `comparison_type=5`.
    /// </summary>
    public static Instruction RestartIfUnsignedLessThanOrEqual(uint left, uint right)
        => ReturnIfUnsignedComparison(EventReturnType.Restart, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfConditionState(Label label, byte requiredState, ConditionGroup inputCondition)
        => new(1000, 101, (byte)label, requiredState, (sbyte)inputCondition);
    
    /// <summary>
    /// Calls `GotoIfConditionState` with `required_state=True`.
    /// </summary>
    public static Instruction GotoIfConditionTrue(Label label, ConditionGroup inputCondition)
        => GotoIfConditionState(label, 1, inputCondition);
    
    /// <summary>
    /// Calls `GotoIfConditionState` with `required_state=False`.
    /// </summary>
    public static Instruction GotoIfConditionFalse(Label label, ConditionGroup inputCondition)
        => GotoIfConditionState(label, 0, inputCondition);
    
    /// <summary>
    /// Unconditional GOTO.
    /// </summary>
    public static Instruction Goto(Label label)
        => new(1000, 103, (byte)label);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfValueComparison(Label label, ComparisonType comparisonType, int left, int right)
        => new(1000, 105, (byte)label, (sbyte)comparisonType, left, right);
    
    /// <summary>
    /// Go to label if the last result of the given condition (without re-evaluating) is `required_state`.
    /// </summary>
    public static Instruction GotoIfLastConditionResultState(Label label, byte requiredState, ConditionGroup inputCondition)
        => new(1000, 107, (byte)label, requiredState, (sbyte)inputCondition);
    
    /// <summary>
    /// Calls `GotoIfLastConditionResultState` with `required_state=True`.
    /// </summary>
    public static Instruction GotoIfLastConditionResultTrue(Label label, ConditionGroup inputCondition)
        => GotoIfLastConditionResultState(label, 1, inputCondition);
    
    /// <summary>
    /// Calls `GotoIfLastConditionResultState` with `required_state=False`.
    /// </summary>
    public static Instruction GotoIfLastConditionResultFalse(Label label, ConditionGroup inputCondition)
        => GotoIfLastConditionResultState(label, 0, inputCondition);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfUnsignedComparison(Label label, ComparisonType comparisonType, uint left, uint right)
        => new(1000, 108, (byte)label, (sbyte)comparisonType, left, right);
    
    /// <summary>
    /// Calls `GotoIfUnsignedComparison` with `comparison_type=0`.
    /// </summary>
    public static Instruction GotoIfUnsignedEqual(Label label, uint left, uint right)
        => GotoIfUnsignedComparison(label, ComparisonType.Equal, left, right);
    
    /// <summary>
    /// Calls `GotoIfUnsignedComparison` with `comparison_type=1`.
    /// </summary>
    public static Instruction GotoIfUnsignedNotEqual(Label label, uint left, uint right)
        => GotoIfUnsignedComparison(label, ComparisonType.NotEqual, left, right);
    
    /// <summary>
    /// Calls `GotoIfUnsignedComparison` with `comparison_type=2`.
    /// </summary>
    public static Instruction GotoIfUnsignedGreaterThan(Label label, uint left, uint right)
        => GotoIfUnsignedComparison(label, ComparisonType.GreaterThan, left, right);
    
    /// <summary>
    /// Calls `GotoIfUnsignedComparison` with `comparison_type=3`.
    /// </summary>
    public static Instruction GotoIfUnsignedLessThan(Label label, uint left, uint right)
        => GotoIfUnsignedComparison(label, ComparisonType.LessThan, left, right);
    
    /// <summary>
    /// Calls `GotoIfUnsignedComparison` with `comparison_type=4`.
    /// </summary>
    public static Instruction GotoIfUnsignedGreaterThanOrEqual(Label label, uint left, uint right)
        => GotoIfUnsignedComparison(label, ComparisonType.GreaterThanOrEqual, left, right);
    
    /// <summary>
    /// Calls `GotoIfUnsignedComparison` with `comparison_type=5`.
    /// </summary>
    public static Instruction GotoIfUnsignedLessThanOrEqual(Label label, uint left, uint right)
        => GotoIfUnsignedComparison(label, ComparisonType.LessThanOrEqual, left, right);
    
    /// <summary>
    /// Pause event script until time of day is between the given earliest/latest times.
    /// </summary>
    public static Instruction WaitUntilTimeOfDayInRange(
        byte earliestHour,
        byte earliestMinute,
        byte earliestSecond,
        byte latestHour,
        byte latestMinute,
        byte latestSecond)
        => new(1001, 5, earliestHour, earliestMinute, earliestSecond, latestHour, latestMinute, latestSecond);
    
    /// <summary>
    /// Wait a given number of real frames. Always used after cutscene instructions with argument `frames=1`.
    /// </summary>
    public static Instruction WaitRealFrames(int frames)
        => new(1001, 6, frames);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction WaitUntilArenaHalfTime(ArenaMatchType matchType, byte isSecondHalf)
        => new(1001, 8, (byte)matchType, isSecondHalf);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfMultiplayerState(byte lineCount, MultiplayerState state)
        => new(1003, 5, lineCount, (sbyte)state);
    
    /// <summary>
    /// Calls `SkipLinesIfMultiplayerState` with `state=0`.
    /// </summary>
    public static Instruction SkipLinesIfHost(byte lineCount)
        => SkipLinesIfMultiplayerState(lineCount, MultiplayerState.Host);
    
    /// <summary>
    /// Calls `SkipLinesIfMultiplayerState` with `state=1`.
    /// </summary>
    public static Instruction SkipLinesIfClient(byte lineCount)
        => SkipLinesIfMultiplayerState(lineCount, MultiplayerState.Client);
    
    /// <summary>
    /// Calls `SkipLinesIfMultiplayerState` with `state=2`.
    /// </summary>
    public static Instruction SkipLinesIfMultiplayer(byte lineCount)
        => SkipLinesIfMultiplayerState(lineCount, MultiplayerState.Multiplayer);
    
    /// <summary>
    /// Calls `SkipLinesIfMultiplayerState` with `state=3`.
    /// </summary>
    public static Instruction SkipLinesIfMultiplayerPending(byte lineCount)
        => SkipLinesIfMultiplayerState(lineCount, MultiplayerState.MultiplayerPending);
    
    /// <summary>
    /// Calls `SkipLinesIfMultiplayerState` with `state=4`.
    /// </summary>
    public static Instruction SkipLinesIfSingleplayer(byte lineCount)
        => SkipLinesIfMultiplayerState(lineCount, MultiplayerState.Singleplayer);
    
    /// <summary>
    /// Calls `SkipLinesIfMultiplayerState` with `state=5`.
    /// </summary>
    public static Instruction SkipLinesIfInvasion(byte lineCount)
        => SkipLinesIfMultiplayerState(lineCount, MultiplayerState.Invasion);
    
    /// <summary>
    /// Calls `SkipLinesIfMultiplayerState` with `state=6`.
    /// </summary>
    public static Instruction SkipLinesIfInvasionPending(byte lineCount)
        => SkipLinesIfMultiplayerState(lineCount, MultiplayerState.InvasionPending);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfMultiplayerState(EventReturnType eventReturnType, MultiplayerState state)
        => new(1003, 6, (byte)eventReturnType, (sbyte)state);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=0`, `state=0`.
    /// </summary>
    public static Instruction EndIfHost()
        => ReturnIfMultiplayerState(EventReturnType.End, MultiplayerState.Host);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=0`, `state=1`.
    /// </summary>
    public static Instruction EndIfClient()
        => ReturnIfMultiplayerState(EventReturnType.End, MultiplayerState.Client);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=0`, `state=2`.
    /// </summary>
    public static Instruction EndIfMultiplayer()
        => ReturnIfMultiplayerState(EventReturnType.End, MultiplayerState.Multiplayer);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=0`, `state=3`.
    /// </summary>
    public static Instruction EndIfMultiplayerPending()
        => ReturnIfMultiplayerState(EventReturnType.End, MultiplayerState.MultiplayerPending);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=0`, `state=4`.
    /// </summary>
    public static Instruction EndIfSingleplayer()
        => ReturnIfMultiplayerState(EventReturnType.End, MultiplayerState.Singleplayer);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=0`, `state=5`.
    /// </summary>
    public static Instruction EndIfInvasion()
        => ReturnIfMultiplayerState(EventReturnType.End, MultiplayerState.Invasion);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=0`, `state=6`.
    /// </summary>
    public static Instruction EndIfInvasionPending()
        => ReturnIfMultiplayerState(EventReturnType.End, MultiplayerState.InvasionPending);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=1`, `state=0`.
    /// </summary>
    public static Instruction RestartIfHost()
        => ReturnIfMultiplayerState(EventReturnType.Restart, MultiplayerState.Host);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=1`, `state=1`.
    /// </summary>
    public static Instruction RestartIfClient()
        => ReturnIfMultiplayerState(EventReturnType.Restart, MultiplayerState.Client);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=1`, `state=2`.
    /// </summary>
    public static Instruction RestartIfMultiplayer()
        => ReturnIfMultiplayerState(EventReturnType.Restart, MultiplayerState.Multiplayer);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=1`, `state=3`.
    /// </summary>
    public static Instruction RestartIfMultiplayerPending()
        => ReturnIfMultiplayerState(EventReturnType.Restart, MultiplayerState.MultiplayerPending);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=1`, `state=4`.
    /// </summary>
    public static Instruction RestartIfSingleplayer()
        => ReturnIfMultiplayerState(EventReturnType.Restart, MultiplayerState.Singleplayer);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=1`, `state=5`.
    /// </summary>
    public static Instruction RestartIfInvasion()
        => ReturnIfMultiplayerState(EventReturnType.Restart, MultiplayerState.Invasion);
    
    /// <summary>
    /// Calls `ReturnIfMultiplayerState` with `event_return_type=1`, `state=6`.
    /// </summary>
    public static Instruction RestartIfInvasionPending()
        => ReturnIfMultiplayerState(EventReturnType.Restart, MultiplayerState.InvasionPending);
    
    /// <summary>
    /// Value should be from 0 to 4.
    /// </summary>
    public static Instruction SkipLinesIfCoopClientCountComparison(byte skipLines, ComparisonType comparisonType, byte value)
        => new(1003, 9, skipLines, (byte)comparisonType, value);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfCoopClientCountComparison(EventReturnType eventReturnType, ComparisonType comparisonType, byte value)
        => new(1003, 10, (byte)eventReturnType, (byte)comparisonType, value);
    
    /// <summary>
    /// Calls `ReturnIfCoopClientCountComparison` with `event_return_type=0`.
    /// </summary>
    public static Instruction EndIfCoopClientCountComparison(ComparisonType comparisonType, byte value)
        => ReturnIfCoopClientCountComparison(EventReturnType.End, comparisonType, value);
    
    /// <summary>
    /// Calls `ReturnIfCoopClientCountComparison` with `event_return_type=1`.
    /// </summary>
    public static Instruction RestartIfCoopClientCountComparison(ComparisonType comparisonType, byte value)
        => ReturnIfCoopClientCountComparison(EventReturnType.Restart, comparisonType, value);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfPlayerOwnWorldState(byte lineCount, byte notInOwnWorld)
        => new(1003, 12, lineCount, notInOwnWorld);
    
    /// <summary>
    /// Calls `SkipLinesIfPlayerOwnWorldState` with `not_in_own_world=False`.
    /// </summary>
    public static Instruction SkipLinesIfPlayerInOwnWorld(byte lineCount)
        => SkipLinesIfPlayerOwnWorldState(lineCount, 0);
    
    /// <summary>
    /// Calls `SkipLinesIfPlayerOwnWorldState` with `not_in_own_world=True`.
    /// </summary>
    public static Instruction SkipLinesIfPlayerNotInOwnWorld(byte lineCount)
        => SkipLinesIfPlayerOwnWorldState(lineCount, 1);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfPlayerOwnWorldState(Label label, byte notInOwnWorld)
        => new(1003, 13, (byte)label, notInOwnWorld);
    
    /// <summary>
    /// Calls `GotoIfPlayerOwnWorldState` with `not_in_own_world=False`.
    /// </summary>
    public static Instruction GotoIfPlayerInOwnWorld(Label label)
        => GotoIfPlayerOwnWorldState(label, 0);
    
    /// <summary>
    /// Calls `GotoIfPlayerOwnWorldState` with `not_in_own_world=True`.
    /// </summary>
    public static Instruction GotoIfPlayerNotInOwnWorld(Label label)
        => GotoIfPlayerOwnWorldState(label, 1);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfPlayerOwnWorldState(EventReturnType eventReturnType, byte notInOwnWorld)
        => new(1003, 14, (byte)eventReturnType, notInOwnWorld);
    
    /// <summary>
    /// Calls `ReturnIfPlayerOwnWorldState` with `event_return_type=0`, `not_in_own_world=False`.
    /// </summary>
    public static Instruction EndIfPlayerInOwnWorld()
        => ReturnIfPlayerOwnWorldState(EventReturnType.End, 0);
    
    /// <summary>
    /// Calls `ReturnIfPlayerOwnWorldState` with `event_return_type=0`, `not_in_own_world=True`.
    /// </summary>
    public static Instruction EndIfPlayerNotInOwnWorld()
        => ReturnIfPlayerOwnWorldState(EventReturnType.End, 1);
    
    /// <summary>
    /// Calls `ReturnIfPlayerOwnWorldState` with `event_return_type=1`, `not_in_own_world=False`.
    /// </summary>
    public static Instruction RestartIfPlayerInOwnWorld()
        => ReturnIfPlayerOwnWorldState(EventReturnType.Restart, 0);
    
    /// <summary>
    /// Calls `ReturnIfPlayerOwnWorldState` with `event_return_type=1`, `not_in_own_world=True`.
    /// </summary>
    public static Instruction RestartIfPlayerNotInOwnWorld()
        => ReturnIfPlayerOwnWorldState(EventReturnType.Restart, 1);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfFlagState(Label label, byte state, FlagType flagType, uint flag)
        => new(1003, 101, (byte)label, state, (byte)flagType, flag);
    
    /// <summary>
    /// Calls `GotoIfFlagState` with `state=True`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction GotoIfThisEventFlagEnabled(Label label)
        => GotoIfFlagState(label, 1, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `GotoIfFlagState` with `state=False`, `flag_type=1`, `flag=0`.
    /// </summary>
    public static Instruction GotoIfThisEventFlagDisabled(Label label)
        => GotoIfFlagState(label, 0, FlagType.RelativeToThisEvent, 0);
    
    /// <summary>
    /// Calls `GotoIfFlagState` with `state=True`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction GotoIfThisEventSlotFlagEnabled(Label label)
        => GotoIfFlagState(label, 1, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Calls `GotoIfFlagState` with `state=False`, `flag_type=2`, `flag=0`.
    /// </summary>
    public static Instruction GotoIfThisEventSlotFlagDisabled(Label label)
        => GotoIfFlagState(label, 0, FlagType.RelativeToThisEventSlot, 0);
    
    /// <summary>
    /// Calls `GotoIfFlagState` with `state=True`, `flag_type=0`.
    /// </summary>
    public static Instruction GotoIfFlagEnabled(Label label, uint flag)
        => GotoIfFlagState(label, 1, FlagType.Absolute, flag);
    
    /// <summary>
    /// Calls `GotoIfFlagState` with `state=False`, `flag_type=0`.
    /// </summary>
    public static Instruction GotoIfFlagDisabled(Label label, uint flag)
        => GotoIfFlagState(label, 0, FlagType.Absolute, flag);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfFlagRangeState(Label label, RangeState state, FlagType flagType, uint firstFlag, uint lastFlag)
        => new(1003, 103, (byte)label, (byte)state, (byte)flagType, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `GotoIfFlagRangeState` with `state=0`, `flag_type=0`.
    /// </summary>
    public static Instruction GotoIfFlagRangeAllEnabled(Label label, uint firstFlag, uint lastFlag)
        => GotoIfFlagRangeState(label, RangeState.AllOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `GotoIfFlagRangeState` with `state=1`, `flag_type=0`.
    /// </summary>
    public static Instruction GotoIfFlagRangeAllDisabled(Label label, uint firstFlag, uint lastFlag)
        => GotoIfFlagRangeState(label, RangeState.AllOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `GotoIfFlagRangeState` with `state=2`, `flag_type=0`.
    /// </summary>
    public static Instruction GotoIfFlagRangeAnyEnabled(Label label, uint firstFlag, uint lastFlag)
        => GotoIfFlagRangeState(label, RangeState.AnyOn, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// Calls `GotoIfFlagRangeState` with `state=3`, `flag_type=0`.
    /// </summary>
    public static Instruction GotoIfFlagRangeAnyDisabled(Label label, uint firstFlag, uint lastFlag)
        => GotoIfFlagRangeState(label, RangeState.AnyOff, FlagType.Absolute, firstFlag, lastFlag);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfMultiplayerState(Label label, MultiplayerState state)
        => new(1003, 105, (byte)label, (sbyte)state);
    
    /// <summary>
    /// Calls `GotoIfMultiplayerState` with `state=0`.
    /// </summary>
    public static Instruction GotoIfHost(Label label)
        => GotoIfMultiplayerState(label, MultiplayerState.Host);
    
    /// <summary>
    /// Calls `GotoIfMultiplayerState` with `state=1`.
    /// </summary>
    public static Instruction GotoIfClient(Label label)
        => GotoIfMultiplayerState(label, MultiplayerState.Client);
    
    /// <summary>
    /// Calls `GotoIfMultiplayerState` with `state=2`.
    /// </summary>
    public static Instruction GotoIfMultiplayer(Label label)
        => GotoIfMultiplayerState(label, MultiplayerState.Multiplayer);
    
    /// <summary>
    /// Calls `GotoIfMultiplayerState` with `state=3`.
    /// </summary>
    public static Instruction GotoIfMultiplayerPending(Label label)
        => GotoIfMultiplayerState(label, MultiplayerState.MultiplayerPending);
    
    /// <summary>
    /// Calls `GotoIfMultiplayerState` with `state=4`.
    /// </summary>
    public static Instruction GotoIfSingleplayer(Label label)
        => GotoIfMultiplayerState(label, MultiplayerState.Singleplayer);
    
    /// <summary>
    /// Calls `GotoIfMultiplayerState` with `state=5`.
    /// </summary>
    public static Instruction GotoIfInvasion(Label label)
        => GotoIfMultiplayerState(label, MultiplayerState.Invasion);
    
    /// <summary>
    /// Calls `GotoIfMultiplayerState` with `state=6`.
    /// </summary>
    public static Instruction GotoIfInvasionPending(Label label)
        => GotoIfMultiplayerState(label, MultiplayerState.InvasionPending);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfMapPresenceState(Label label, byte state, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => new(1003, 107, (byte)label, state, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `GotoIfMapPresenceState` with `state=True`.
    /// </summary>
    public static Instruction GotoIfInsideMap(Label label, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => GotoIfMapPresenceState(label, 1, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `GotoIfMapPresenceState` with `state=False`.
    /// </summary>
    public static Instruction GotoIfOutsideMap(Label label, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => GotoIfMapPresenceState(label, 0, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfCoopClientCountComparison(Label label, ComparisonType comparisonType, byte value)
        => new(1003, 109, (byte)label, (byte)comparisonType, value);
    
    /// <summary>
    /// EMEDF does not have the final new argument listed (it's the same as the other region/distance checks).
    /// </summary>
    public static Instruction GotoIfCharacterRegionState(Label label, byte state, uint character, uint region, int minTargetCount = 1)
        => new(1003, 200, (byte)label, state, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `GotoIfCharacterRegionState` with `character=10000`, `state=True`.
    /// </summary>
    public static Instruction GotoIfPlayerInsideRegion(Label label, uint region, int minTargetCount = 1)
        => GotoIfCharacterRegionState(label, 1, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `GotoIfCharacterRegionState` with `character=10000`, `state=False`.
    /// </summary>
    public static Instruction GotoIfPlayerOutsideRegion(Label label, uint region, int minTargetCount = 1)
        => GotoIfCharacterRegionState(label, 0, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `GotoIfCharacterRegionState` with `state=True`.
    /// </summary>
    public static Instruction GotoIfCharacterInsideRegion(Label label, uint character, uint region, int minTargetCount = 1)
        => GotoIfCharacterRegionState(label, 1, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `GotoIfCharacterRegionState` with `state=False`.
    /// </summary>
    public static Instruction GotoIfCharacterOutsideRegion(Label label, uint character, uint region, int minTargetCount = 1)
        => GotoIfCharacterRegionState(label, 0, character, region, minTargetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfCharacterRegionState(
        EventReturnType eventReturnType,
        byte state,
        uint character,
        uint region,
        int minTargetCount = 1)
        => new(1003, 201, (byte)eventReturnType, state, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterRegionState` with `event_return_type=0`, `character=10000`, `state=True`.
    /// </summary>
    public static Instruction EndIfPlayerInsideRegion(uint region, int minTargetCount = 1)
        => ReturnIfCharacterRegionState(EventReturnType.End, 1, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterRegionState` with `event_return_type=0`, `character=10000`, `state=False`.
    /// </summary>
    public static Instruction EndIfPlayerOutsideRegion(uint region, int minTargetCount = 1)
        => ReturnIfCharacterRegionState(EventReturnType.End, 0, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterRegionState` with `event_return_type=1`, `character=10000`, `state=True`.
    /// </summary>
    public static Instruction RestartIfPlayerInsideRegion(uint region, int minTargetCount = 1)
        => ReturnIfCharacterRegionState(EventReturnType.Restart, 1, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterRegionState` with `event_return_type=1`, `character=10000`, `state=False`.
    /// </summary>
    public static Instruction RestartIfPlayerOutsideRegion(uint region, int minTargetCount = 1)
        => ReturnIfCharacterRegionState(EventReturnType.Restart, 0, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterRegionState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIfCharacterInsideRegion(uint character, uint region, int minTargetCount = 1)
        => ReturnIfCharacterRegionState(EventReturnType.End, 1, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterRegionState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIfCharacterOutsideRegion(uint character, uint region, int minTargetCount = 1)
        => ReturnIfCharacterRegionState(EventReturnType.End, 0, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterRegionState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIfCharacterInsideRegion(uint character, uint region, int minTargetCount = 1)
        => ReturnIfCharacterRegionState(EventReturnType.Restart, 1, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterRegionState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIfCharacterOutsideRegion(uint character, uint region, int minTargetCount = 1)
        => ReturnIfCharacterRegionState(EventReturnType.Restart, 0, character, region, minTargetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfCharacterRegionState(byte lineCount, byte state, uint character, uint region, int minTargetCount = 1)
        => new(1003, 202, lineCount, state, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfCharacterRegionState` with `state=True`, `character=10000`.
    /// </summary>
    public static Instruction SkipLinesIfPlayerInsideRegion(byte lineCount, uint region, int minTargetCount = 1)
        => SkipLinesIfCharacterRegionState(lineCount, 1, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfCharacterRegionState` with `state=False`, `character=10000`.
    /// </summary>
    public static Instruction SkipLinesIfPlayerOutsideRegion(byte lineCount, uint region, int minTargetCount = 1)
        => SkipLinesIfCharacterRegionState(lineCount, 0, 10000, region, minTargetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfCharacterRegionState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfCharacterInsideRegion(byte lineCount, uint character, uint region, int minTargetCount = 1)
        => SkipLinesIfCharacterRegionState(lineCount, 1, character, region, minTargetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfCharacterRegionState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfCharacterOutsideRegion(byte lineCount, uint character, uint region, int minTargetCount = 1)
        => SkipLinesIfCharacterRegionState(lineCount, 0, character, region, minTargetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfMapUpdatePermissionState(
        byte lineCount,
        byte state,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => new(1003, 203, lineCount, state, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `SkipLinesIfMapUpdatePermissionState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfMapHasUpdatePermission(
        byte lineCount,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => SkipLinesIfMapUpdatePermissionState(lineCount, 1, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `SkipLinesIfMapUpdatePermissionState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfMapDoesNotHaveUpdatePermission(
        byte lineCount,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => SkipLinesIfMapUpdatePermissionState(lineCount, 0, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfMapUpdatePermissionState(
        Label label,
        byte state,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => new(1003, 204, (byte)label, state, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `GotoIfMapUpdatePermissionState` with `state=True`.
    /// </summary>
    public static Instruction GotoIfMapHasUpdatePermission(Label label, byte unkState, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => GotoIfMapUpdatePermissionState(label, 1, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `GotoIfMapUpdatePermissionState` with `state=False`.
    /// </summary>
    public static Instruction GotoIfMapDoesNotHaveUpdatePermission(
        Label label,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => GotoIfMapUpdatePermissionState(label, 0, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfMapUpdatePermissionState(
        EventReturnType eventReturnType,
        byte state,
        byte unkState,
        sbyte areaID,
        sbyte blockID,
        sbyte ccID,
        sbyte ddID)
        => new(1003, 205, (byte)eventReturnType, state, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `ReturnIfMapUpdatePermissionState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIfMapHasUpdatePermission(byte unkState, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => ReturnIfMapUpdatePermissionState(EventReturnType.End, 1, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `ReturnIfMapUpdatePermissionState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIfMapDoesNotHaveUpdatePermission(byte unkState, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => ReturnIfMapUpdatePermissionState(EventReturnType.End, 0, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `ReturnIfMapUpdatePermissionState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIfMapHasUpdatePermission(byte unkState, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => ReturnIfMapUpdatePermissionState(EventReturnType.Restart, 1, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// Calls `ReturnIfMapUpdatePermissionState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIfMapDoesNotHaveUpdatePermission(byte unkState, sbyte areaID, sbyte blockID, sbyte ccID, sbyte ddID)
        => ReturnIfMapUpdatePermissionState(EventReturnType.Restart, 0, unkState, areaID, blockID, ccID, ddID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfCeremonyState(byte lineCount, byte state, int ceremony)
        => new(1003, 206, lineCount, state, ceremony);
    
    /// <summary>
    /// Calls `SkipLinesIfCeremonyState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfCeremonyActive(byte lineCount, int ceremony)
        => SkipLinesIfCeremonyState(lineCount, 1, ceremony);
    
    /// <summary>
    /// Calls `SkipLinesIfCeremonyState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfCeremonyInactive(byte lineCount, int ceremony)
        => SkipLinesIfCeremonyState(lineCount, 0, ceremony);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfCeremonyState(Label label, byte state, int ceremony)
        => new(1003, 207, (byte)label, state, ceremony);
    
    /// <summary>
    /// Calls `GotoIfCeremonyState` with `state=True`.
    /// </summary>
    public static Instruction GotoIfCeremonyActive(Label label, int ceremony)
        => GotoIfCeremonyState(label, 1, ceremony);
    
    /// <summary>
    /// Calls `GotoIfCeremonyState` with `state=False`.
    /// </summary>
    public static Instruction GotoIfCeremonyInactive(Label label, int ceremony)
        => GotoIfCeremonyState(label, 0, ceremony);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfCeremonyState(EventReturnType eventReturnType, byte state, int ceremony)
        => new(1003, 208, (byte)eventReturnType, state, ceremony);
    
    /// <summary>
    /// Calls `ReturnIfCeremonyState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIfCeremonyActive(int ceremony)
        => ReturnIfCeremonyState(EventReturnType.End, 1, ceremony);
    
    /// <summary>
    /// Calls `ReturnIfCeremonyState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIfCeremonyInactive(int ceremony)
        => ReturnIfCeremonyState(EventReturnType.End, 0, ceremony);
    
    /// <summary>
    /// Calls `ReturnIfCeremonyState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIfCeremonyActive(int ceremony)
        => ReturnIfCeremonyState(EventReturnType.Restart, 1, ceremony);
    
    /// <summary>
    /// Calls `ReturnIfCeremonyState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIfCeremonyInactive(int ceremony)
        => ReturnIfCeremonyState(EventReturnType.Restart, 0, ceremony);
    
    /// <summary>
    /// Skip some number of lines if the current arena match type is the given type.
    /// </summary>
    public static Instruction SkipLinesIfArenaMatchType(byte lineCount, ArenaMatchType matchType, byte hasSpiritSummon)
        => new(1003, 212, lineCount, (byte)matchType, hasSpiritSummon);
    
    /// <summary>
    /// Go to label if the current arena match type is the given type.
    /// </summary>
    public static Instruction GotoLinesIfArenaMatchType(Label label, ArenaMatchType matchType, byte hasSpiritSummon)
        => new(1003, 213, (byte)label, (byte)matchType, hasSpiritSummon);
    
    /// <summary>
    /// End or restart if the current arena match type is the given type.
    /// </summary>
    public static Instruction ReturnIfArenaMatchType(EventReturnType eventReturnType, ArenaMatchType matchType, byte hasSpiritSummon)
        => new(1003, 214, (byte)eventReturnType, (byte)matchType, hasSpiritSummon);
    
    /// <summary>
    /// Calls `ReturnIfArenaMatchType` with `event_return_type=0`.
    /// </summary>
    public static Instruction EndIfArenaMatchType(ArenaMatchType matchType, byte hasSpiritSummon)
        => ReturnIfArenaMatchType(EventReturnType.End, matchType, hasSpiritSummon);
    
    /// <summary>
    /// Calls `ReturnIfArenaMatchType` with `event_return_type=1`.
    /// </summary>
    public static Instruction RestartIfArenaMatchType(ArenaMatchType matchType, byte hasSpiritSummon)
        => ReturnIfArenaMatchType(EventReturnType.Restart, matchType, hasSpiritSummon);
    
    /// <summary>
    /// Note that the same instruction appeared in DS3 as 1003[112].
    /// </summary>
    public static Instruction SkipLinesIfCharacterSpecialEffectState(
        byte lineCount,
        uint character,
        int specialEffect,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => new(1004, 0, lineCount, character, specialEffect, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfCharacterSpecialEffectState` with `character=10000`, `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfPlayerHasSpecialEffect(
        byte lineCount,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => SkipLinesIfCharacterSpecialEffectState(lineCount, 10000, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfCharacterSpecialEffectState` with `character=10000`, `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfPlayerDoesNotHaveSpecialEffect(
        byte lineCount,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => SkipLinesIfCharacterSpecialEffectState(lineCount, 10000, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfCharacterSpecialEffectState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfCharacterHasSpecialEffect(
        byte lineCount,
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => SkipLinesIfCharacterSpecialEffectState(lineCount, character, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `SkipLinesIfCharacterSpecialEffectState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfCharacterDoesNotHaveSpecialEffect(
        byte lineCount,
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => SkipLinesIfCharacterSpecialEffectState(lineCount, character, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Note that the same instruction appeared in DS3 as 1003[11].
    /// </summary>
    public static Instruction GotoIfCharacterSpecialEffectState(
        Label label,
        uint character,
        int specialEffect,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => new(1004, 1, (byte)label, character, specialEffect, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `GotoIfCharacterSpecialEffectState` with `character=10000`, `state=True`.
    /// </summary>
    public static Instruction GotoIfPlayerHasSpecialEffect(
        Label label,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => GotoIfCharacterSpecialEffectState(label, 10000, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `GotoIfCharacterSpecialEffectState` with `character=10000`, `state=False`.
    /// </summary>
    public static Instruction GotoIfPlayerDoesNotHaveSpecialEffect(
        Label label,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => GotoIfCharacterSpecialEffectState(label, 10000, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `GotoIfCharacterSpecialEffectState` with `state=True`.
    /// </summary>
    public static Instruction GotoIfCharacterHasSpecialEffect(
        Label label,
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => GotoIfCharacterSpecialEffectState(label, character, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `GotoIfCharacterSpecialEffectState` with `state=False`.
    /// </summary>
    public static Instruction GotoIfCharacterDoesNotHaveSpecialEffect(
        Label label,
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => GotoIfCharacterSpecialEffectState(label, character, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Note that the same instruction appeared in DS3 as 1003[111].
    /// </summary>
    public static Instruction ReturnIfCharacterSpecialEffectState(
        EventReturnType eventReturnType,
        uint character,
        int specialEffect,
        byte state,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => new(1004, 2, (byte)eventReturnType, character, specialEffect, state, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterSpecialEffectState` with `event_return_type=0`, `character=10000`, `state=True`.
    /// </summary>
    public static Instruction EndIfPlayerHasSpecialEffect(
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => ReturnIfCharacterSpecialEffectState(EventReturnType.End, 10000, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterSpecialEffectState` with `event_return_type=0`, `character=10000`, `state=False`.
    /// </summary>
    public static Instruction EndIfPlayerDoesNotHaveSpecialEffect(
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => ReturnIfCharacterSpecialEffectState(EventReturnType.End, 10000, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterSpecialEffectState` with `event_return_type=1`, `character=10000`, `state=True`.
    /// </summary>
    public static Instruction RestartIfPlayerHasSpecialEffect(
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => ReturnIfCharacterSpecialEffectState(EventReturnType.Restart, 10000, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterSpecialEffectState` with `event_return_type=1`, `character=10000`, `state=False`.
    /// </summary>
    public static Instruction RestartIfPlayerDoesNotHaveSpecialEffect(
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => ReturnIfCharacterSpecialEffectState(EventReturnType.Restart, 10000, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterSpecialEffectState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIfCharacterHasSpecialEffect(
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => ReturnIfCharacterSpecialEffectState(EventReturnType.End, character, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterSpecialEffectState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIfCharacterDoesNotHaveSpecialEffect(
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => ReturnIfCharacterSpecialEffectState(EventReturnType.End, character, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterSpecialEffectState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIfCharacterHasSpecialEffect(
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => ReturnIfCharacterSpecialEffectState(EventReturnType.Restart, character, specialEffect, 1, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `ReturnIfCharacterSpecialEffectState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIfCharacterDoesNotHaveSpecialEffect(
        uint character,
        int specialEffect,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        int targetCount = 1)
        => ReturnIfCharacterSpecialEffectState(EventReturnType.Restart, character, specialEffect, 0, targetComparisonType, targetCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SkipLinesIfSpecialStandbyEndedFlagState(byte lineCount, uint character, byte state)
        => new(1004, 3, lineCount, character, state);
    
    /// <summary>
    /// Calls `SkipLinesIfSpecialStandbyEndedFlagState` with `state=True`.
    /// </summary>
    public static Instruction SkipLinesIfSpecialStandbyEndedFlagEnabled(byte lineCount, uint character)
        => SkipLinesIfSpecialStandbyEndedFlagState(lineCount, character, 1);
    
    /// <summary>
    /// Calls `SkipLinesIfSpecialStandbyEndedFlagState` with `state=False`.
    /// </summary>
    public static Instruction SkipLinesIfSpecialStandbyEndedFlagDisabled(byte lineCount, uint character)
        => SkipLinesIfSpecialStandbyEndedFlagState(lineCount, character, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction GotoIfSpecialStandbyEndedFlagState(Label label, uint character, byte state)
        => new(1004, 4, (byte)label, character, state);
    
    /// <summary>
    /// Calls `GotoIfSpecialStandbyEndedFlagState` with `state=True`.
    /// </summary>
    public static Instruction GotoIfSpecialStandbyEndedFlagEnabled(Label label, uint character)
        => GotoIfSpecialStandbyEndedFlagState(label, character, 1);
    
    /// <summary>
    /// Calls `GotoIfSpecialStandbyEndedFlagState` with `state=False`.
    /// </summary>
    public static Instruction GotoIfSpecialStandbyEndedFlagDisabled(Label label, uint character)
        => GotoIfSpecialStandbyEndedFlagState(label, character, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ReturnIfSpecialStandbyEndedFlagState(EventReturnType eventReturnType, uint character, byte state)
        => new(1004, 5, (byte)eventReturnType, character, state);
    
    /// <summary>
    /// Calls `ReturnIfSpecialStandbyEndedFlagState` with `event_return_type=0`, `state=True`.
    /// </summary>
    public static Instruction EndIffSpecialStandbyEndedFlagEnabled(uint character)
        => ReturnIfSpecialStandbyEndedFlagState(EventReturnType.End, character, 1);
    
    /// <summary>
    /// Calls `ReturnIfSpecialStandbyEndedFlagState` with `event_return_type=0`, `state=False`.
    /// </summary>
    public static Instruction EndIffSpecialStandbyEndedFlagDisabled(uint character)
        => ReturnIfSpecialStandbyEndedFlagState(EventReturnType.End, character, 0);
    
    /// <summary>
    /// Calls `ReturnIfSpecialStandbyEndedFlagState` with `event_return_type=1`, `state=True`.
    /// </summary>
    public static Instruction RestartIffSpecialStandbyEndedFlagEnabled(uint character)
        => ReturnIfSpecialStandbyEndedFlagState(EventReturnType.Restart, character, 1);
    
    /// <summary>
    /// Calls `ReturnIfSpecialStandbyEndedFlagState` with `event_return_type=1`, `state=False`.
    /// </summary>
    public static Instruction RestartIffSpecialStandbyEndedFlagDisabled(uint character)
        => ReturnIfSpecialStandbyEndedFlagState(EventReturnType.Restart, character, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction AwaitAssetDestructionState(
        byte state,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(1005, 0, state, asset, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `AwaitAssetDestructionState` with `state=True`.
    /// </summary>
    public static Instruction AwaitAssetDestroyed(
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => AwaitAssetDestructionState(1, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `AwaitAssetDestructionState` with `state=False`.
    /// </summary>
    public static Instruction AwaitAssetNotDestroyed(
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => AwaitAssetDestructionState(0, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Note change in argument order.
    /// </summary>
    public static Instruction GotoIfAssetDestructionState(
        Label label,
        byte state,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => new(1005, 101, (byte)label, state, asset, (sbyte)targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `GotoIfAssetDestructionState` with `state=True`.
    /// </summary>
    public static Instruction GotoIfAssetDestroyed(
        Label label,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => GotoIfAssetDestructionState(label, 1, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Calls `GotoIfAssetDestructionState` with `state=False`.
    /// </summary>
    public static Instruction GotoIfAssetNotDestroyed(
        Label label,
        uint asset,
        ComparisonType targetComparisonType = ComparisonType.Equal,
        float targetCount = 1.0f)
        => GotoIfAssetDestructionState(label, 0, asset, targetComparisonType, targetCount);
    
    /// <summary>
    /// Define position of label 0 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_0()
        => new(1014, 0);
    
    /// <summary>
    /// Define position of label 1 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_1()
        => new(1014, 1);
    
    /// <summary>
    /// Define position of label 2 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_2()
        => new(1014, 2);
    
    /// <summary>
    /// Define position of label 3 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_3()
        => new(1014, 3);
    
    /// <summary>
    /// Define position of label 4 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_4()
        => new(1014, 4);
    
    /// <summary>
    /// Define position of label 5 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_5()
        => new(1014, 5);
    
    /// <summary>
    /// Define position of label 6 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_6()
        => new(1014, 6);
    
    /// <summary>
    /// Define position of label 7 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_7()
        => new(1014, 7);
    
    /// <summary>
    /// Define position of label 8 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_8()
        => new(1014, 8);
    
    /// <summary>
    /// Define position of label 9 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_9()
        => new(1014, 9);
    
    /// <summary>
    /// Define position of label 10 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_10()
        => new(1014, 10);
    
    /// <summary>
    /// Define position of label 11 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_11()
        => new(1014, 11);
    
    /// <summary>
    /// Define position of label 12 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_12()
        => new(1014, 12);
    
    /// <summary>
    /// Define position of label 13 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_13()
        => new(1014, 13);
    
    /// <summary>
    /// Define position of label 14 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_14()
        => new(1014, 14);
    
    /// <summary>
    /// Define position of label 15 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_15()
        => new(1014, 15);
    
    /// <summary>
    /// Define position of label 16 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_16()
        => new(1014, 16);
    
    /// <summary>
    /// Define position of label 17 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_17()
        => new(1014, 17);
    
    /// <summary>
    /// Define position of label 18 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_18()
        => new(1014, 18);
    
    /// <summary>
    /// Define position of label 19 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_19()
        => new(1014, 19);
    
    /// <summary>
    /// Define position of label 20 for Goto instructions.
    /// </summary>
    public static Instruction DefineLabel_20()
        => new(1014, 20);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetCurrentTime(
        byte hour,
        byte minute,
        byte second,
        byte fadeTransition,
        byte waitForCompletion,
        byte showClock,
        float clockStartDelay,
        float clockChangeDuration,
        float clockFinishDelay)
        => new(2001, 4, hour, minute, second, fadeTransition, waitForCompletion, showClock, clockStartDelay, clockChangeDuration, clockFinishDelay);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetTimeFreezeState(byte state)
        => new(2001, 5, state);
    
    /// <summary>
    /// Calls `SetTimeFreezeState` with `state=True`.
    /// </summary>
    public static Instruction FreezeTime()
        => SetTimeFreezeState(1);
    
    /// <summary>
    /// Calls `SetTimeFreezeState` with `state=False`.
    /// </summary>
    public static Instruction UnfreezeTime()
        => SetTimeFreezeState(0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction PlayCutsceneToPlayerWithWeatherAndTime(
        int cutsceneID,
        CutsceneFlags cutsceneFlags,
        uint playerID,
        byte changeWeather,
        Weather weather,
        float weatherDuration,
        byte changeTime,
        byte hour,
        byte minute,
        byte second)
        => new(2002, 10, cutsceneID, (uint)cutsceneFlags, playerID, changeWeather, (sbyte)weather, weatherDuration, changeTime, hour, minute, second);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction PlayCutsceneToPlayerAndWarp(
        int cutsceneID,
        CutsceneFlags cutsceneFlags,
        uint moveToRegion,
        int mapID,
        uint playerID,
        int unk2024,
        byte unk2425)
        => new(2002, 11, cutsceneID, (uint)cutsceneFlags, moveToRegion, mapID, playerID, unk2024, unk2425);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction PlayCutsceneToPlayerAndWarpWithWeatherAndTime(
        int cutsceneID,
        CutsceneFlags cutsceneFlags,
        uint moveToRegion,
        int mapID,
        uint playerID,
        int unk2024,
        byte unk2425,
        byte changeWeather,
        Weather weather,
        float weatherDuration,
        byte changeTime,
        byte hour,
        byte minute,
        byte second)
        => new(2002, 12, cutsceneID, (uint)cutsceneFlags, moveToRegion, mapID, playerID, unk2024, unk2425, changeWeather, (sbyte)weather, weatherDuration, changeTime, hour, minute, second);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction PlayCutsceneToPlayerAndWarpWithStablePositionUpdate(
        int cutsceneID,
        CutsceneFlags cutsceneFlags,
        uint moveToRegion,
        int mapID,
        uint playerID,
        int unk1620,
        byte unk2021,
        byte updateStablePosition)
        => new(2002, 13, cutsceneID, (uint)cutsceneFlags, moveToRegion, mapID, playerID, unk1620, unk2021, updateStablePosition);
    
    /// <summary>
    /// Stores some amount of items read from a flag array.
    /// </summary>
    public static Instruction StoreItemAmountSpecifiedByFlagValue(ItemType itemType, int item, uint flag, uint bitCount)
        => new(2003, 42, (byte)itemType, item, flag, bitCount);
    
    /// <summary>
    /// Gives player some amount of items read from a flag array. Probably used when taking items out of storage
    /// (i.e. the reverse of the above instruction).
    /// </summary>
    public static Instruction GivePlayerItemAmountSpecifiedByFlagValue(ItemType itemType, int item, uint flag, uint bitCount)
        => new(2003, 43, (byte)itemType, item, flag, bitCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetDirectionDisplay(byte state)
        => new(2003, 44, state);
    
    /// <summary>
    /// Calls `SetDirectionDisplay` with `state=True`.
    /// </summary>
    public static Instruction EnableDirectionDisplay()
        => SetDirectionDisplay(1);
    
    /// <summary>
    /// Calls `SetDirectionDisplay` with `state=False`.
    /// </summary>
    public static Instruction DisableDirectionDisplay()
        => SetDirectionDisplay(0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction TriggerAISound(int aiSoundParamID, uint anchorEntity, byte unk812)
        => new(2003, 52, aiSoundParamID, anchorEntity, unk812);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ForceSpawnerToSpawn(uint spawner)
        => new(2003, 54, spawner);
    
    /// <summary>
    /// Network-synchronized variant of `SetFlagRangeState` (2003[22]).
    /// </summary>
    public static Instruction SetNetworkConnectedFlagRangeState(uint firstFlag, uint lastFlag, FlagSetting state)
        => new(2003, 63, firstFlag, lastFlag, (byte)state);
    
    /// <summary>
    /// Calls `SetNetworkConnectedFlagRangeState` with `state=1`.
    /// </summary>
    public static Instruction EnableNetworkConnectedFlagRange(uint firstFlag, uint lastFlag)
        => SetNetworkConnectedFlagRangeState(firstFlag, lastFlag, FlagSetting.On);
    
    /// <summary>
    /// Calls `SetNetworkConnectedFlagRangeState` with `state=0`.
    /// </summary>
    public static Instruction DisableNetworkConnectedFlagRange(uint firstFlag, uint lastFlag)
        => SetNetworkConnectedFlagRangeState(firstFlag, lastFlag, FlagSetting.Off);
    
    /// <summary>
    /// Calls `SetNetworkConnectedFlagRangeState` with `state=2`.
    /// </summary>
    public static Instruction ToggleNetworkConnectedFlagRange(uint firstFlag, uint lastFlag)
        => SetNetworkConnectedFlagRangeState(firstFlag, lastFlag, FlagSetting.Change);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetOmissionModeCounts(int level1Count, int level2Count)
        => new(2003, 64, level1Count, level2Count);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ResetOmissionModeCountsToDefault()
        => new(2003, 65);
    
    /// <summary>
    /// Predominant flag-setting instruction in Elden Ring. It can set relative flags, unlike the old 2003[2].
    /// </summary>
    public static Instruction SetFlagState(FlagType flagType, uint flag, FlagSetting state)
        => new(2003, 66, (byte)flagType, flag, (byte)state);
    
    /// <summary>
    /// Calls `SetFlagState` with `flag_type=0`, `state=1`.
    /// </summary>
    public static Instruction EnableFlag(uint flag)
        => SetFlagState(FlagType.Absolute, flag, FlagSetting.On);
    
    /// <summary>
    /// Calls `SetFlagState` with `flag_type=0`, `state=0`.
    /// </summary>
    public static Instruction DisableFlag(uint flag)
        => SetFlagState(FlagType.Absolute, flag, FlagSetting.Off);
    
    /// <summary>
    /// Calls `SetFlagState` with `flag_type=0`, `state=2`.
    /// </summary>
    public static Instruction ToggleFlag(uint flag)
        => SetFlagState(FlagType.Absolute, flag, FlagSetting.Change);
    
    /// <summary>
    /// Calls `SetFlagState` with `flag_type=0`.
    /// </summary>
    public static Instruction SetAbsoluteFlagState(uint flag, FlagSetting state)
        => SetFlagState(FlagType.Absolute, flag, state);
    
    /// <summary>
    /// Calls `SetFlagState` with `flag_type=2`, `flag=0`, `state=1`.
    /// </summary>
    public static Instruction EnableThisSlotFlag()
        => SetFlagState(FlagType.RelativeToThisEventSlot, 0, FlagSetting.On);
    
    /// <summary>
    /// Calls `SetFlagState` with `flag_type=2`, `flag=0`, `state=0`.
    /// </summary>
    public static Instruction DisableThisSlotFlag()
        => SetFlagState(FlagType.RelativeToThisEventSlot, 0, FlagSetting.Off);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetWeather(Weather weather, float duration, byte immediateChange)
        => new(2003, 68, (sbyte)weather, duration, immediateChange);
    
    /// <summary>
    /// Enable, disable, or toggle (change) a binary flag for all network-connected players.
    /// </summary>
    public static Instruction SetNetworkFlagState(FlagType flagType, uint flag, FlagSetting state)
        => new(2003, 69, (byte)flagType, flag, (byte)state);
    
    /// <summary>
    /// Calls `SetNetworkFlagState` with `flag_type=0`, `state=1`.
    /// </summary>
    public static Instruction EnableNetworkFlag(uint flag)
        => SetNetworkFlagState(FlagType.Absolute, flag, FlagSetting.On);
    
    /// <summary>
    /// Calls `SetNetworkFlagState` with `flag_type=0`, `state=0`.
    /// </summary>
    public static Instruction DisableNetworkFlag(uint flag)
        => SetNetworkFlagState(FlagType.Absolute, flag, FlagSetting.Off);
    
    /// <summary>
    /// Calls `SetNetworkFlagState` with `flag_type=0`, `state=2`.
    /// </summary>
    public static Instruction ToggleNetworkFlag(uint flag)
        => SetNetworkFlagState(FlagType.Absolute, flag, FlagSetting.Change);
    
    /// <summary>
    /// Calls `SetNetworkFlagState` with `flag_type=0`.
    /// </summary>
    public static Instruction SetAbsoluteNetworkFlagState(uint flag, FlagSetting state)
        => SetNetworkFlagState(FlagType.Absolute, flag, state);
    
    /// <summary>
    /// Calls `SetNetworkFlagState` with `flag_type=1`, `flag=0`, `state=1`.
    /// </summary>
    public static Instruction EnableThisNetworkFlag()
        => SetNetworkFlagState(FlagType.RelativeToThisEvent, 0, FlagSetting.On);
    
    /// <summary>
    /// Calls `SetNetworkFlagState` with `flag_type=1`, `flag=0`, `state=0`.
    /// </summary>
    public static Instruction DisableThisNetworkFlag()
        => SetNetworkFlagState(FlagType.RelativeToThisEvent, 0, FlagSetting.Off);
    
    /// <summary>
    /// Calls `SetNetworkFlagState` with `flag_type=2`, `flag=0`, `state=1`.
    /// </summary>
    public static Instruction EnableThisNetworkSlotFlag()
        => SetNetworkFlagState(FlagType.RelativeToThisEventSlot, 0, FlagSetting.On);
    
    /// <summary>
    /// Calls `SetNetworkFlagState` with `flag_type=2`, `flag=0`, `state=0`.
    /// </summary>
    public static Instruction DisableThisNetworSlotFlag()
        => SetNetworkFlagState(FlagType.RelativeToThisEventSlot, 0, FlagSetting.Off);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetNetworkInteractionState(byte state)
        => new(2003, 70, state);
    
    /// <summary>
    /// Awards a Gesture item to player.
    /// </summary>
    public static Instruction AwardGesture(int gestureParamID)
        => new(2003, 71, gestureParamID);
    
    /// <summary>
    /// Apply a multiplier to the amount of souls/echoes/runes waiting to be retrieved from the bloodstain with
    /// the given save slot ID.
    /// </summary>
    public static Instruction MultiplyBloodstainSouls(float multiplier, int bloodstainSaveSlotID)
        => new(2003, 72, multiplier, bloodstainSaveSlotID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IncreaseCharacterSoulReward(uint character, int fixedIncreaseAmount, int soulAmountLoadSlotID)
        => new(2003, 73, character, fixedIncreaseAmount, soulAmountLoadSlotID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction IssueEndOfPseudoMultiplayerNotification(byte success)
        => new(2003, 74, success);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction UseFarViewCamera(uint farViewID, uint asset, int dummyID = -1)
        => new(2003, 75, farViewID, asset, dummyID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetPlayerPositionDisplay(
        byte state,
        byte aboveground,
        byte areaID,
        byte blockID,
        byte ccID,
        byte ddID,
        float x,
        float y,
        float z)
        => new(2003, 76, state, aboveground, areaID, blockID, ccID, ddID, x, y, z);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetPseudoMultiplayerReturnPosition(uint region)
        => new(2003, 77, region);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction OpenWorldMapPoint(int worldMapPointParamID, float distance)
        => new(2003, 78, worldMapPointParamID, distance);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SendNPCSummonHome(uint character)
        => new(2003, 79, character);
    
    /// <summary>
    /// Enable or disable text on loading screens.
    /// </summary>
    public static Instruction ShowLoadingScreenText(byte state)
        => new(2003, 80, state);
    
    /// <summary>
    /// Calls `ShowLoadingScreenText` with `state=True`.
    /// </summary>
    public static Instruction EnableLoadingScreenText()
        => ShowLoadingScreenText(1);
    
    /// <summary>
    /// Calls `ShowLoadingScreenText` with `state=False`.
    /// </summary>
    public static Instruction DisableLoadingScreenText()
        => ShowLoadingScreenText(0);
    
    /// <summary>
    /// Remove given Gesture from player's inventory'.
    /// </summary>
    public static Instruction RemoveGesture(int gestureParamID)
        => new(2003, 81, gestureParamID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction EraseNPCSummonSign(uint character)
        => new(2003, 82, character);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction Unknown_2003_83(byte unk01)
        => new(2003, 83, unk01);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ChangeCharacterCloth(uint character, byte bitCount, byte stateID)
        => new(2004, 48, character, bitCount, stateID);
    
    /// <summary>
    /// I don't know what a 'patrol_information_id' actually is.
    /// </summary>
    public static Instruction ChangePatrolBehavior(uint character, uint patrolInformationID)
        => new(2004, 49, character, patrolInformationID);
    
    /// <summary>
    /// Presumably changes the point that is locked on to by the player.
    /// </summary>
    public static Instruction SetLockOnPoint(uint character, int lockOnDummyID, byte state)
        => new(2004, 50, character, lockOnDummyID, state);
    
    /// <summary>
    /// I assume this affects the player.
    /// </summary>
    public static Instruction ChangePlayerCharacterInitParam(int characterInitParam)
        => new(2004, 52, characterInitParam);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetCharacterTalkRange(uint character, float distance)
        => new(2004, 55, character, distance);
    
    /// <summary>
    /// Used to connect trolls to the caravans they pull.
    /// </summary>
    public static Instruction ConnectCharacterToCaravan(uint character, uint caravanAsset)
        => new(2004, 60, character, caravanAsset);
    
    /// <summary>
    /// Used only once: in Stranded Graveyard with argument 9999.
    /// </summary>
    public static Instruction Unknown_2004_61(int unk04)
        => new(2004, 61, unk04);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetCharacterEnableDistance(uint character, float distance)
        => new(2004, 63, character, distance);
    
    /// <summary>
    /// Used, for example, to initialize Mimics and set up Gideon's boss loadout.
    /// </summary>
    public static Instruction CopyPlayerCharacterData(uint sourceCharacter, uint destCharacter)
        => new(2004, 67, sourceCharacter, destCharacter);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction AttachAssetToCharacter(uint character, int dummyID, uint asset)
        => new(2004, 68, character, dummyID, asset);
    
    /// <summary>
    /// I believe this will, if enabled for a character, cause that character to be disabled when the collision they
    /// are standing on (or possibly their draw parent) is unloaded.
    /// </summary>
    public static Instruction SetCharacterDisableOnCollisionUnload(uint character, byte state)
        => new(2004, 69, character, state);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetDistanceBasedNetworkAuthorityUpdate(uint character, byte state)
        => new(2004, 70, character, state);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction Unknown_2004_71(sbyte unk04, uint entityA, uint entityB)
        => new(2004, 71, unk04, entityA, entityB);
    
    /// <summary>
    /// Determines if character will fade-in when enabled, I believe.
    /// </summary>
    public static Instruction SetCharacterFadeOnEnable(uint character, byte state)
        => new(2004, 73, character, state);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction MoveCharacterAndCopyDrawParentWithFadeout(
        uint character,
        CoordEntityType destinationType,
        uint destination,
        int dummyID,
        uint copyDrawParent,
        byte useBonfireEffect,
        byte resetCamera)
        => new(2004, 74, character, (byte)destinationType, destination, dummyID, copyDrawParent, useBonfireEffect, resetCamera);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetCharacterFaceParamOverride(uint character, sbyte overrideSlot, int faceParamID)
        => new(2004, 75, character, overrideSlot, faceParamID);
    
    /// <summary>
    /// Unknown. `flag` appears to be a boss death flag and `item_lot` the reward for that boss.
    /// 
    /// Called on the first line of boss-despawning common event 90005860 if an item lot was passed in.
    /// </summary>
    public static Instruction Unknown_2004_76(uint flag, int itemLot)
        => new(2004, 76, flag, itemLot);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction FadeToBlack(float strength, float duration, byte freezePlayer, float freezePlayerDelay)
        => new(2004, 77, strength, duration, freezePlayer, freezePlayerDelay);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction CopyPlayerCharacterDataFromOnlinePlayers(sbyte poolType, int failcasePlayerParamID, uint targetCharacter)
        => new(2004, 78, poolType, failcasePlayerParamID, targetCharacter);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction RequestPlayerCharacterDataFromOnlinePlayers(sbyte poolType, int dataCount)
        => new(2004, 79, poolType, dataCount);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SendPlayerCharacterDataToOnlinePlayers(sbyte poolType)
        => new(2004, 80, poolType);
    
    /// <summary>
    /// Resets character position to MSB coordinates, I assume.
    /// </summary>
    public static Instruction ResetCharacterPosition(uint character)
        => new(2004, 81, character);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetSpecialStandbyEndedFlag(uint character, byte state)
        => new(2004, 83, character, state);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetCharacterEnableDistanceWithUnknown(uint character, float enableDistance, float unknownDistance)
        => new(2004, 84, character, enableDistance, unknownDistance);
    
    /// <summary>
    /// Attaches caravan to trolls pulling it, presuamably (there is also an inverse event).
    /// </summary>
    public static Instruction AttachCaravanToController(uint caravanAsset, uint character)
        => new(2005, 17, caravanAsset, character);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction AttachAssetToAsset(uint childAsset, uint parentAsset, int parentDummyID = -1)
        => new(2005, 18, childAsset, parentAsset, parentDummyID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction CreateBigHazardousAsset(
        uint assetFlag,
        uint asset,
        int dummyIDStart,
        int dummyIDEnd,
        int behaviourID,
        DamageTargetType targetType,
        float radius,
        float life,
        float repetitionTime)
        => new(2005, 20, assetFlag, asset, dummyIDStart, dummyIDEnd, behaviourID, (int)targetType, radius, life, repetitionTime);
    
    /// <summary>
    /// Not sure if argument is an MSB VFX Event ID (more likely) or an absolute VFX asset ID.
    /// </summary>
    public static Instruction SetWindVFX(int windVfxID)
        => new(2006, 6, windVfxID);
    
    /// <summary>
    /// Displays a dialog and enables one of three flags, depending on the player's response. Very useful. `right`
    /// and `cancel` flags are often identical.
    /// 
    /// Halts execution until the player responds.
    /// </summary>
    public static Instruction AwaitDialogResponse(
        int message,
        ButtonType buttonType,
        NumberButtons numberButtons,
        uint anchorEntity,
        float displayDistance,
        uint leftFlag,
        uint rightFlag,
        uint cancelFlag)
        => new(2007, 10, message, (short)buttonType, (short)numberButtons, anchorEntity, displayDistance, leftFlag, rightFlag, cancelFlag);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction DisplayFlashingMessageWithPriority(int text, short priority, byte shouldInterrupt)
        => new(2007, 12, text, priority, shouldInterrupt);
    
    /// <summary>
    /// Uses PlaceName FMG.
    /// </summary>
    public static Instruction DisplaySubareaWelcomeMessage(int placeNameID)
        => new(2007, 13, placeNameID);
    
    /// <summary>
    /// Uses PlaceName FMG.
    /// </summary>
    public static Instruction DisplayAreaWelcomeMessage(int placeNameID)
        => new(2007, 14, placeNameID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction DisplayTutorialMessage(int tutorialParamID, byte unk45, byte unk56)
        => new(2007, 15, tutorialParamID, unk45, unk56);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction DisplayNetworkMessage(int text, byte unk45)
        => new(2007, 16, text, unk45);
    
    /// <summary>
    /// Used very often, presumably to gently push the camera to a specific latitude/longitude.
    /// </summary>
    public static Instruction SetCameraAngle(float xAngle, float yAngle)
        => new(2008, 4, xAngle, yAngle);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction BanishInvaders(int unknown)
        => new(2009, 8, unknown);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction BanishPhantoms(int unknown)
        => new(2009, 11, unknown);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction BanishPhantomsAndUpdateServerPvPStats(int unknown)
        => new(2009, 12, unknown);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SuppressSoundEvent(int soundID, int unk48, byte suppressionActive)
        => new(2010, 7, soundID, unk48, suppressionActive);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction UnknownSound_2010_8(int soundID)
        => new(2010, 8, soundID);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetBossMusic(int bgmBossConvParamID, BossMusicState state)
        => new(2010, 10, bgmBossConvParamID, (int)state);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SuppressSoundForFogGate(float duration)
        => new(2010, 11, duration);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetFieldBattleMusicHeatUp(uint npcThreatLevel, byte state)
        => new(2010, 12, npcThreatLevel, state);
    
    /// <summary>
    /// Calls `SetFieldBattleMusicHeatUp` with `state=True`.
    /// </summary>
    public static Instruction EnableFieldBattleMusicHeatUp(uint npcThreatLevel)
        => SetFieldBattleMusicHeatUp(npcThreatLevel, 1);
    
    /// <summary>
    /// Calls `SetFieldBattleMusicHeatUp` with `state=False`.
    /// </summary>
    public static Instruction DisableFieldBattleMusicHeatUp(uint npcThreatLevel)
        => SetFieldBattleMusicHeatUp(npcThreatLevel, 0);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction SetAreaWelcomeMessageState(byte state)
        => new(2012, 8, state);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction ActivateGparamOverride(int gparamSubID, float changeDuration)
        => new(2012, 11, gparamSubID, changeDuration);
    
    /// <summary>
    /// TODO
    /// </summary>
    public static Instruction DeactivateGparamOverride(float changeDuration)
        => new(2012, 12, changeDuration);
}
