﻿namespace EldenRingBase.Events;

public static class EMEDFNames
{
    public static readonly Dictionary<(int bank, int id), string> Names = new()
    {
        [(0, 0)] = "IfConditionState",
        [(0, 1)] = "IfValueComparison",
        [(1, 0)] = "IfTimeElapsed",
        [(1, 1)] = "IfFramesElapsed",
        [(1, 2)] = "IfRandomTimeElapsed",
        [(1, 3)] = "IfRandomFramesElapsed",
        [(1, 4)] = "IfTimeOfDay",
        [(1, 5)] = "IfTimeOfDayInRange",
        [(3, 0)] = "IfFlagState",
        [(3, 1)] = "IfFlagRangeState",
        [(3, 2)] = "IfCharacterRegionState",
        [(3, 3)] = "IfEntityDistanceState",
        [(3, 4)] = "IfPlayerItemStateExcludingStorage",
        [(3, 6)] = "IfMultiplayerState",
        [(3, 7)] = "IfAllPlayersRegionState",
        [(3, 8)] = "IfMapPresenceState",
        [(3, 9)] = "IfMultiplayerEvent",
        [(3, 10)] = "IfEnabledFlagCountComparison",
        [(3, 12)] = "IfEventValueComparison",
        [(3, 14)] = "IfAnyItemDroppedInRegion",
        [(3, 15)] = "IfItemDropped",
        [(3, 16)] = "IfPlayerItemStateIncludingStorage",
        [(3, 17)] = "IfNewGameCycleComparison",
        [(3, 20)] = "IfEventsComparison",
        [(3, 22)] = "IfOnlineState",
        [(4, 0)] = "IfCharacterDeathState",
        [(4, 2)] = "IfHealthRatioComparison",
        [(4, 3)] = "IfCharacterIsType",
        [(4, 4)] = "IfCharacterTargetingState",
        [(4, 5)] = "IfCharacterSpecialEffectState",
        [(4, 6)] = "IfCharacterPartHealthComparison",
        [(4, 7)] = "IfCharacterBackreadState",
        [(4, 8)] = "IfCharacterTAEEventState",
        [(4, 9)] = "IfHasAIStatus",
        [(4, 11)] = "IfPlayerClass",
        [(4, 12)] = "IfPlayerCovenant",
        [(4, 13)] = "IfPlayerLevelComparison",
        [(4, 14)] = "IfHealthValueComparison",
        [(5, 0)] = "IfAssetDestructionState",
        [(5, 1)] = "IfAssetDamaged",
        [(5, 2)] = "IfAssetActivated",
        [(5, 3)] = "IfAssetHealthValueComparison",
        [(11, 0)] = "IfPlayerMovingOnCollision",
        [(11, 1)] = "IfPlayerRunningOnCollision",
        [(11, 2)] = "IfPlayerStandingOnCollision",
        [(1000, 0)] = "AwaitConditionState",
        [(1000, 1)] = "SkipLinesIfConditionState",
        [(1000, 2)] = "ReturnIfConditionState",
        [(1000, 3)] = "SkipLines",
        [(1000, 4)] = "Return",
        [(1000, 5)] = "SkipLinesIfValueComparison",
        [(1000, 6)] = "ReturnIfValueComparison",
        [(1000, 7)] = "SkipLinesIfLastConditionResultState",
        [(1000, 8)] = "ReturnIfLastConditionResultState",
        [(1001, 0)] = "Wait",
        [(1001, 1)] = "WaitFrames",
        [(1001, 2)] = "WaitRandomSeconds",
        [(1001, 3)] = "WaitRandomFrames",
        [(1003, 0)] = "AwaitFlagState",
        [(1003, 1)] = "SkipLinesIfFlagState",
        [(1003, 2)] = "ReturnIfFlagState",
        [(1003, 3)] = "SkipLinesIfFlagRangeState",
        [(1003, 4)] = "ReturnIfFlagRangeState",
        [(1003, 7)] = "SkipLinesIfMapPresenceState",
        [(1003, 8)] = "ReturnIfMapPresenceState",
        [(1005, 1)] = "SkipLinesIfAssetDestructionState",
        [(1005, 2)] = "ReturnIfAssetDestructionState",
        [(2000, 0)] = "RunEvent",
        [(2000, 2)] = "SetNetworkSyncState",
        [(2000, 3)] = "ClearMainCondition",
        [(2000, 5)] = "SaveRequest",
        [(2000, 6)] = "RunCommonEvent",
        [(2000, 7)] = "StartPS5Activity",
        [(2000, 8)] = "EndPS5Activity",
        [(2002, 1)] = "PlayCutsceneToAll",
        [(2002, 3)] = "PlayCutsceneToPlayer",
        [(2002, 4)] = "PlayCutsceneToPlayer_Unknown_2002_04",
        [(2002, 9)] = "PlayCutsceneToPlayer_Unknown_2002_09",
        [(2003, 3)] = "SetSpawnerState",
        [(2003, 4)] = "AwardItemLotToAllPlayers",
        [(2003, 5)] = "ShootProjectile",
        [(2003, 6)] = "SetMapCollisionState_2003_06",
        [(2003, 7)] = "SetMapVisibilityState",
        [(2003, 8)] = "SetEventSlotState",
        [(2003, 9)] = "InvertFlag",
        [(2003, 11)] = "SetBossHealthBarState",
        [(2003, 12)] = "KillBossAndDisplayBanner",
        [(2003, 13)] = "SetNavmeshType",
        [(2003, 14)] = "WarpToMap",
        [(2003, 15)] = "HandleMinibossDefeat",
        [(2003, 16)] = "TriggerMultiplayerEvent",
        [(2003, 17)] = "SetRandomFlagInRange",
        [(2003, 18)] = "ForceAnimation",
        [(2003, 21)] = "IncrementNewGameCycle",
        [(2003, 22)] = "SetFlagRangeState",
        [(2003, 23)] = "SetRespawnPoint",
        [(2003, 24)] = "RemoveItemFromPlayer",
        [(2003, 25)] = "PlaceSummonSign",
        [(2003, 26)] = "SetSoapstoneMessageState",
        [(2003, 28)] = "AwardAchievement",
        [(2003, 31)] = "IncrementEventValue",
        [(2003, 32)] = "ClearEventValue",
        [(2003, 35)] = "MoveRemains",
        [(2003, 36)] = "AwardItemLotToHostOnly",
        [(2003, 41)] = "EventValueOperation",
        [(2004, 1)] = "SetAIState",
        [(2004, 2)] = "SetTeamType",
        [(2004, 4)] = "Kill",
        [(2004, 5)] = "SetCharacterState",
        [(2004, 6)] = "EzstateAIRequest",
        [(2004, 7)] = "CreateProjectileOwner",
        [(2004, 8)] = "AddSpecialEffect",
        [(2004, 10)] = "SetGravityState",
        [(2004, 11)] = "SetCharacterEventTarget",
        [(2004, 12)] = "SetImmortalityState",
        [(2004, 13)] = "SetNest",
        [(2004, 14)] = "FaceEntityAndForceAnimation",
        [(2004, 15)] = "SetInvincibilityState",
        [(2004, 16)] = "ClearTargetList",
        [(2004, 17)] = "AICommand",
        [(2004, 18)] = "SetEventPoint",
        [(2004, 19)] = "SetAIParamID",
        [(2004, 20)] = "ReplanAI",
        [(2004, 21)] = "RemoveSpecialEffect",
        [(2004, 22)] = "CreateNPCPart",
        [(2004, 23)] = "SetNPCPartHealth",
        [(2004, 24)] = "SetNPCPartEffects",
        [(2004, 25)] = "SetNPCPartBulletDamageScaling",
        [(2004, 26)] = "SetDisplayMask",
        [(2004, 27)] = "SetCollisionMask",
        [(2004, 28)] = "SetNetworkUpdateAuthority",
        [(2004, 29)] = "SetBackreadState",
        [(2004, 30)] = "SetHealthBarState",
        [(2004, 31)] = "SetCharacterCollisionState",
        [(2004, 33)] = "ReferDamageToEntity",
        [(2004, 34)] = "SetNetworkUpdateRate",
        [(2004, 35)] = "SetBackreadStateAlternate",
        [(2004, 37)] = "DropMandatoryTreasure",
        [(2004, 38)] = "BetrayCurrentCovenant",
        [(2004, 39)] = "SetAnimationsState",
        [(2004, 40)] = "MoveAndSetDrawParent",
        [(2004, 41)] = "ShortMove",
        [(2004, 42)] = "MoveAndCopyDrawParent",
        [(2004, 43)] = "ResetAnimation",
        [(2004, 47)] = "EqualRecovery",
        [(2005, 1)] = "DestroyAsset",
        [(2005, 2)] = "RestoreAsset",
        [(2005, 3)] = "SetAssetState",
        [(2005, 4)] = "SetTreasureState",
        [(2005, 5)] = "ActivateAsset",
        [(2005, 6)] = "SetAssetActivation",
        [(2005, 7)] = "EndOfAnimation",
        [(2005, 8)] = "PostDestruction",
        [(2005, 9)] = "CreateHazard",
        [(2005, 11)] = "MoveAssetToCharacter",
        [(2005, 12)] = "RemoveAssetFlag",
        [(2005, 13)] = "SetAssetInvulnerabilityState",
        [(2005, 14)] = "SetAssetActivationWithIdx",
        [(2005, 15)] = "EnableTreasureCollection",
        [(2006, 1)] = "DeleteVFX",
        [(2006, 2)] = "CreateVFX",
        [(2006, 3)] = "CreateTemporaryVFX",
        [(2006, 4)] = "CreateAssetVFX",
        [(2006, 5)] = "DeleteAssetVFX",
        [(2007, 1)] = "DisplayDialog",
        [(2007, 2)] = "DisplayBanner",
        [(2007, 3)] = "DisplayStatus",
        [(2007, 4)] = "DisplayFlashingMessage",
        [(2007, 9)] = "DisplayFullScreenMessage",
        [(2008, 1)] = "ChangeCamera",
        [(2008, 2)] = "SetCameraVibration",
        [(2008, 3)] = "SetLockedCameraSlot",
        [(2009, 0)] = "RegisterLadder",
        [(2009, 3)] = "RegisterGrace",
        [(2009, 4)] = "ActivateMultiplayerBuffs",
        [(2009, 6)] = "NotifyBossBattleStart",
        [(2010, 2)] = "PlaySoundEffect",
        [(2011, 1)] = "SetMapCollisionState",
        [(2011, 2)] = "SetMapCollisionBackreadMaskState",
        [(2012, 1)] = "SetMapPieceState",
        [(0, 2)] = "IfUnsignedComparison",
        [(3, 23)] = "IfAttackedWithDamageType",
        [(3, 24)] = "IfActionButtonParamActivated",
        [(3, 26)] = "IfPlayerOwnWorldState",
        [(3, 30)] = "IfMapLoaded",
        [(3, 31)] = "IfWeatherState",
        [(3, 32)] = "IfMapUpdatePermissionState",
        [(3, 33)] = "IfFieldBattleMusicState",
        [(3, 34)] = "IfPlayerHasArmorEquipped",
        [(3, 35)] = "IfCeremonyState",
        [(3, 37)] = "IfWeatherLotState",
        [(3, 38)] = "IfPlayerGender",
        [(3, 39)] = "IfArenaMatchReadyState",
        [(3, 40)] = "IfArenaSoloResult",
        [(3, 41)] = "IfArenaSoloScoreComparison",
        [(3, 42)] = "IfArenaTeamResults",
        [(3, 43)] = "IfArenaTeamScoreComparison",
        [(3, 44)] = "IfArenaMatchType",
        [(3, 45)] = "IfPlayerRespawnedInArena",
        [(4, 15)] = "IfCharacterProportionDeathState",
        [(4, 19)] = "IfCharacterProportionSpecialEffectState",
        [(4, 28)] = "IfPlayerTargeted",
        [(4, 30)] = "IfNPCPartAttackedWithDamageType",
        [(4, 31)] = "IfCharacterInvadeType",
        [(4, 32)] = "IfCharacterMountState",
        [(4, 34)] = "IfCharacterStateInfoState",
        [(4, 35)] = "IfSpecialStandbyEndedFlagState",
        [(5, 6)] = "IfAssetProportionDestructionState",
        [(5, 10)] = "IfAssetBackreadState",
        [(1000, 10)] = "SkipLinesIfUnsignedComparison",
        [(1000, 11)] = "ReturnIfUnsignedComparison",
        [(1000, 101)] = "GotoIfConditionState",
        [(1000, 103)] = "Goto",
        [(1000, 105)] = "GotoIfValueComparison",
        [(1000, 107)] = "GotoIfLastConditionResultState",
        [(1000, 108)] = "GotoIfUnsignedComparison",
        [(1001, 5)] = "WaitUntilTimeOfDayInRange",
        [(1001, 6)] = "WaitRealFrames",
        [(1001, 8)] = "WaitUntilArenaHalfTime",
        [(1003, 5)] = "SkipLinesIfMultiplayerState",
        [(1003, 6)] = "ReturnIfMultiplayerState",
        [(1003, 9)] = "SkipLinesIfCoopClientCountComparison",
        [(1003, 10)] = "ReturnIfCoopClientCountComparison",
        [(1003, 12)] = "SkipLinesIfPlayerOwnWorldState",
        [(1003, 13)] = "GotoIfPlayerOwnWorldState",
        [(1003, 14)] = "ReturnIfPlayerOwnWorldState",
        [(1003, 101)] = "GotoIfFlagState",
        [(1003, 103)] = "GotoIfFlagRangeState",
        [(1003, 105)] = "GotoIfMultiplayerState",
        [(1003, 107)] = "GotoIfMapPresenceState",
        [(1003, 109)] = "GotoIfCoopClientCountComparison",
        [(1003, 200)] = "GotoIfCharacterRegionState",
        [(1003, 201)] = "ReturnIfCharacterRegionState",
        [(1003, 202)] = "SkipLinesIfCharacterRegionState",
        [(1003, 203)] = "SkipLinesIfMapUpdatePermissionState",
        [(1003, 204)] = "GotoIfMapUpdatePermissionState",
        [(1003, 205)] = "ReturnIfMapUpdatePermissionState",
        [(1003, 206)] = "SkipLinesIfCeremonyState",
        [(1003, 207)] = "GotoIfCeremonyState",
        [(1003, 208)] = "ReturnIfCeremonyState",
        [(1003, 212)] = "SkipLinesIfArenaMatchType",
        [(1003, 213)] = "GotoLinesIfArenaMatchType",
        [(1003, 214)] = "ReturnIfArenaMatchType",
        [(1004, 0)] = "SkipLinesIfCharacterSpecialEffectState",
        [(1004, 1)] = "GotoIfCharacterSpecialEffectState",
        [(1004, 2)] = "ReturnIfCharacterSpecialEffectState",
        [(1004, 3)] = "SkipLinesIfSpecialStandbyEndedFlagState",
        [(1004, 4)] = "GotoIfSpecialStandbyEndedFlagState",
        [(1004, 5)] = "ReturnIfSpecialStandbyEndedFlagState",
        [(1005, 0)] = "AwaitAssetDestrucionState",
        [(1005, 101)] = "GotoIfAssetDestructionState",
        [(1014, 0)] = "DefineLabel_0",
        [(1014, 1)] = "DefineLabel_1",
        [(1014, 2)] = "DefineLabel_2",
        [(1014, 3)] = "DefineLabel_3",
        [(1014, 4)] = "DefineLabel_4",
        [(1014, 5)] = "DefineLabel_5",
        [(1014, 6)] = "DefineLabel_6",
        [(1014, 7)] = "DefineLabel_7",
        [(1014, 8)] = "DefineLabel_8",
        [(1014, 9)] = "DefineLabel_9",
        [(1014, 10)] = "DefineLabel_10",
        [(1014, 11)] = "DefineLabel_11",
        [(1014, 12)] = "DefineLabel_12",
        [(1014, 13)] = "DefineLabel_13",
        [(1014, 14)] = "DefineLabel_14",
        [(1014, 15)] = "DefineLabel_15",
        [(1014, 16)] = "DefineLabel_16",
        [(1014, 17)] = "DefineLabel_17",
        [(1014, 18)] = "DefineLabel_18",
        [(1014, 19)] = "DefineLabel_19",
        [(1014, 20)] = "DefineLabel_20",
        [(2001, 4)] = "SetCurrentTime",
        [(2001, 5)] = "SetTimeFreezeState",
        [(2002, 10)] = "PlayCutsceneToPlayerWithWeatherAndTime",
        [(2002, 11)] = "PlayCutsceneToPlayerAndWarp",
        [(2002, 12)] = "PlayCutsceneToPlayerAndWarpWithWeatherAndTime",
        [(2002, 13)] = "PlayCutsceneToPlayerAndWarpWithStablePositionUpdate",
        [(2003, 42)] = "StoreItemAmountSpecifiedByFlagValue",
        [(2003, 43)] = "GivePlayerItemAmountSpecifiedByFlagValue",
        [(2003, 44)] = "SetDirectionDisplay",
        [(2003, 52)] = "TriggerAISound",
        [(2003, 54)] = "ForceSpawnerToSpawn",
        [(2003, 63)] = "SetNetworkConnectedFlagRangeState",
        [(2003, 64)] = "SetOmissionModeCounts",
        [(2003, 65)] = "ResetOmissionModeCountsToDefault",
        [(2003, 66)] = "SetFlagState",
        [(2003, 68)] = "SetWeather",
        [(2003, 69)] = "SetNetworkFlagState",
        [(2003, 70)] = "SetNetworkInteractionState",
        [(2003, 71)] = "AwardGesture",
        [(2003, 72)] = "MultiplyBloodstainSouls",
        [(2003, 73)] = "IncreaseCharacterSoulReward",
        [(2003, 74)] = "IssueEndOfPseudoMultiplayerNotification",
        [(2003, 75)] = "UseFarViewCamera",
        [(2003, 76)] = "SetPlayerPositionDisplay",
        [(2003, 77)] = "SetPseudoMultiplayerReturnPosition",
        [(2003, 78)] = "OpenWorldMapPoint",
        [(2003, 79)] = "SendNPCSummonHome",
        [(2003, 80)] = "ShowLoadingScreenText",
        [(2003, 81)] = "RemoveGesture",
        [(2003, 82)] = "EraseNPCSummonSign",
        [(2003, 83)] = "Unknown_2003_83",
        [(2004, 48)] = "ChangeCharacterCloth",
        [(2004, 49)] = "ChangePatrolBehavior",
        [(2004, 50)] = "SetLockOnPoint",
        [(2004, 52)] = "ChangePlayerCharacterInitParam",
        [(2004, 55)] = "SetCharacterTalkRange",
        [(2004, 60)] = "ConnectCharacterToCaravan",
        [(2004, 61)] = "Unknown_2004_61",
        [(2004, 63)] = "SetCharacterEnableDistance",
        [(2004, 67)] = "CopyPlayerCharacterData",
        [(2004, 68)] = "AttachAssetToCharacter",
        [(2004, 69)] = "SetCharacterDisableOnCollisionUnload",
        [(2004, 70)] = "SetDistanceBasedNetworkAuthorityUpdate",
        [(2004, 71)] = "Unknown_2004_71",
        [(2004, 73)] = "SetCharacterFadeOnEnable",
        [(2004, 74)] = "MoveCharacterAndCopyDrawParentWithFadeout",
        [(2004, 75)] = "SetCharacterFaceParamOverride",
        [(2004, 76)] = "Unknown_2004_76",
        [(2004, 77)] = "FadeToBlack",
        [(2004, 78)] = "CopyPlayerCharacterDataFromOnlinePlayers",
        [(2004, 79)] = "RequestPlayerCharacterDataFromOnlinePlayers",
        [(2004, 80)] = "SendPlayerCharacterDataToOnlinePlayers",
        [(2004, 81)] = "ResetCharacterPosition",
        [(2004, 83)] = "SetSpecialStandbyEndedFlag",
        [(2004, 84)] = "SetCharacterEnableDistanceWithUnknown",
        [(2005, 17)] = "AttachCaravanToController",
        [(2005, 18)] = "AttachAssetToAsset",
        [(2005, 20)] = "CreateBigHazardousAsset",
        [(2006, 6)] = "SetWindVFX",
        [(2007, 10)] = "AwaitDialogResponse",
        [(2007, 12)] = "DisplayFlashingMessageWithPriority",
        [(2007, 13)] = "DisplaySubareaWelcomeMessage",
        [(2007, 14)] = "DisplayAreaWelcomeMessage",
        [(2007, 15)] = "DisplayTutorialMessage",
        [(2007, 16)] = "DisplayNetworkMessage",
        [(2008, 4)] = "SetCameraAngle",
        [(2009, 8)] = "BanishInvaders",
        [(2009, 11)] = "BanishPhantoms",
        [(2009, 12)] = "BanishPhantomsAndUpdateServerPvPStats",
        [(2010, 7)] = "SuppressSoundEvent",
        [(2010, 8)] = "UnknownSound_2010_8",
        [(2010, 10)] = "SetBossMusic",
        [(2010, 11)] = "SuppressSoundForFogGate",
        [(2010, 12)] = "SetFieldBattleMusicHeatUp",
        [(2012, 8)] = "SetAreaWelcomeMessageState",
        [(2012, 11)] = "ActivateGparamOverride",
        [(2012, 12)] = "DeactivateGparamOverride",
    };
}