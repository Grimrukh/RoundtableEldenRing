using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class GAME_SYSTEM_COMMON_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float baseToughnessRecoverTime
        {
            get => (float)row["baseToughnessRecoverTime"].Value;
            set => row["baseToughnessRecoverTime"].Value = value;
        }

        // Unknown.
        public int chrEventTrun_byLeft90
        {
            get => (int)row["chrEventTrun_byLeft90"].Value;
            set => row["chrEventTrun_byLeft90"].Value = value;
        }

        // Unknown.
        public int chrEventTrun_byRight90
        {
            get => (int)row["chrEventTrun_byRight90"].Value;
            set => row["chrEventTrun_byRight90"].Value = value;
        }

        // Unknown.
        public int chrEventTrun_byLeft180
        {
            get => (int)row["chrEventTrun_byLeft180"].Value;
            set => row["chrEventTrun_byLeft180"].Value = value;
        }

        // Unknown.
        public int chrEventTrun_byRight180
        {
            get => (int)row["chrEventTrun_byRight180"].Value;
            set => row["chrEventTrun_byRight180"].Value = value;
        }

        // Unknown.
        public short chrEventTrun_90TurnStartAngle
        {
            get => (short)row["chrEventTrun_90TurnStartAngle"].Value;
            set => row["chrEventTrun_90TurnStartAngle"].Value = value;
        }

        // Unknown.
        public short chrEventTrun_180TurnStartAngle
        {
            get => (short)row["chrEventTrun_180TurnStartAngle"].Value;
            set => row["chrEventTrun_180TurnStartAngle"].Value = value;
        }

        // Unknown.
        public float stealthAtkDamageRate
        {
            get => (float)row["stealthAtkDamageRate"].Value;
            set => row["stealthAtkDamageRate"].Value = value;
        }

        // Unknown.
        public float flickDamageCutRateSuccessGurad
        {
            get => (float)row["flickDamageCutRateSuccessGurad"].Value;
            set => row["flickDamageCutRateSuccessGurad"].Value = value;
        }

        // Unknown.
        public float npcTalkAnimBeginDiffAngle
        {
            get => (float)row["npcTalkAnimBeginDiffAngle"].Value;
            set => row["npcTalkAnimBeginDiffAngle"].Value = value;
        }

        // Unknown.
        public float npcTalkAnimEndDiffAngle
        {
            get => (float)row["npcTalkAnimEndDiffAngle"].Value;
            set => row["npcTalkAnimEndDiffAngle"].Value = value;
        }

        // Unknown.
        public int sleepCollectorItemActionButtonParamId
        {
            get => (int)row["sleepCollectorItemActionButtonParamId"].Value;
            set => row["sleepCollectorItemActionButtonParamId"].Value = value;
        }

        // Unknown.
        public float allowUseBuddyItem_sfxInterval
        {
            get => (float)row["allowUseBuddyItem_sfxInterval"].Value;
            set => row["allowUseBuddyItem_sfxInterval"].Value = value;
        }

        // Unknown.
        public int allowUseBuddyItem_sfxDmyPolyId
        {
            get => (int)row["allowUseBuddyItem_sfxDmyPolyId"].Value;
            set => row["allowUseBuddyItem_sfxDmyPolyId"].Value = value;
        }

        // Unknown.
        public int allowUseBuddyItem_sfxDmyPolyId_horse
        {
            get => (int)row["allowUseBuddyItem_sfxDmyPolyId_horse"].Value;
            set => row["allowUseBuddyItem_sfxDmyPolyId_horse"].Value = value;
        }

        // Unknown.
        public int allowUseBuddyItem_sfxId
        {
            get => (int)row["allowUseBuddyItem_sfxId"].Value;
            set => row["allowUseBuddyItem_sfxId"].Value = value;
        }

        // Unknown.
        public float onBuddySummon_inActivateRange_sfxInterval
        {
            get => (float)row["onBuddySummon_inActivateRange_sfxInterval"].Value;
            set => row["onBuddySummon_inActivateRange_sfxInterval"].Value = value;
        }

        // Unknown.
        public int onBuddySummon_inActivateRange_sfxDmyPolyId
        {
            get => (int)row["onBuddySummon_inActivateRange_sfxDmyPolyId"].Value;
            set => row["onBuddySummon_inActivateRange_sfxDmyPolyId"].Value = value;
        }

        // Unknown.
        public int onBuddySummon_inActivateRange_sfxDmyPolyId_horse
        {
            get => (int)row["onBuddySummon_inActivateRange_sfxDmyPolyId_horse"].Value;
            set => row["onBuddySummon_inActivateRange_sfxDmyPolyId_horse"].Value = value;
        }

        // Unknown.
        public int onBuddySummon_inActivateRange_sfxId
        {
            get => (int)row["onBuddySummon_inActivateRange_sfxId"].Value;
            set => row["onBuddySummon_inActivateRange_sfxId"].Value = value;
        }

        // Unknown.
        public int onBuddySummon_inActivateRange_spEffectId_pc
        {
            get => (int)row["onBuddySummon_inActivateRange_spEffectId_pc"].Value;
            set => row["onBuddySummon_inActivateRange_spEffectId_pc"].Value = value;
        }

        // Unknown.
        public int onBuddySummon_inWarnRange_spEffectId_pc
        {
            get => (int)row["onBuddySummon_inWarnRange_spEffectId_pc"].Value;
            set => row["onBuddySummon_inWarnRange_spEffectId_pc"].Value = value;
        }

        // Unknown.
        public int onBuddySummon_atBuddyUnsummon_spEffectId_pc
        {
            get => (int)row["onBuddySummon_atBuddyUnsummon_spEffectId_pc"].Value;
            set => row["onBuddySummon_atBuddyUnsummon_spEffectId_pc"].Value = value;
        }

        // Unknown.
        public int onBuddySummon_inWarnRange_spEffectId_buddy
        {
            get => (int)row["onBuddySummon_inWarnRange_spEffectId_buddy"].Value;
            set => row["onBuddySummon_inWarnRange_spEffectId_buddy"].Value = value;
        }

        // Unknown.
        public byte morningIngameHour
        {
            get => (byte)row["morningIngameHour"].Value;
            set => row["morningIngameHour"].Value = value;
        }

        // Unknown.
        public byte morningIngameMinute
        {
            get => (byte)row["morningIngameMinute"].Value;
            set => row["morningIngameMinute"].Value = value;
        }

        // Unknown.
        public byte morningIngameSecond
        {
            get => (byte)row["morningIngameSecond"].Value;
            set => row["morningIngameSecond"].Value = value;
        }

        // Unknown.
        public byte noonIngameHour
        {
            get => (byte)row["noonIngameHour"].Value;
            set => row["noonIngameHour"].Value = value;
        }

        // Unknown.
        public byte noonIngameMinute
        {
            get => (byte)row["noonIngameMinute"].Value;
            set => row["noonIngameMinute"].Value = value;
        }

        // Unknown.
        public byte noonIngameSecond
        {
            get => (byte)row["noonIngameSecond"].Value;
            set => row["noonIngameSecond"].Value = value;
        }

        // Unknown.
        public byte nightIngameHour
        {
            get => (byte)row["nightIngameHour"].Value;
            set => row["nightIngameHour"].Value = value;
        }

        // Unknown.
        public byte nightIngameMinute
        {
            get => (byte)row["nightIngameMinute"].Value;
            set => row["nightIngameMinute"].Value = value;
        }

        // Unknown.
        public byte nightIngameSecond
        {
            get => (byte)row["nightIngameSecond"].Value;
            set => row["nightIngameSecond"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Morning_Hour
        {
            get => (byte)row["aiSightRateStart_Morning_Hour"].Value;
            set => row["aiSightRateStart_Morning_Hour"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Morning_Minute
        {
            get => (byte)row["aiSightRateStart_Morning_Minute"].Value;
            set => row["aiSightRateStart_Morning_Minute"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Noon_Hour
        {
            get => (byte)row["aiSightRateStart_Noon_Hour"].Value;
            set => row["aiSightRateStart_Noon_Hour"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Noon_Minute
        {
            get => (byte)row["aiSightRateStart_Noon_Minute"].Value;
            set => row["aiSightRateStart_Noon_Minute"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Evening_Hour
        {
            get => (byte)row["aiSightRateStart_Evening_Hour"].Value;
            set => row["aiSightRateStart_Evening_Hour"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Evening_Minute
        {
            get => (byte)row["aiSightRateStart_Evening_Minute"].Value;
            set => row["aiSightRateStart_Evening_Minute"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Night_Hour
        {
            get => (byte)row["aiSightRateStart_Night_Hour"].Value;
            set => row["aiSightRateStart_Night_Hour"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Night_Minute
        {
            get => (byte)row["aiSightRateStart_Night_Minute"].Value;
            set => row["aiSightRateStart_Night_Minute"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Midnight_Hour
        {
            get => (byte)row["aiSightRateStart_Midnight_Hour"].Value;
            set => row["aiSightRateStart_Midnight_Hour"].Value = value;
        }

        // Unknown.
        public byte aiSightRateStart_Midnight_Minute
        {
            get => (byte)row["aiSightRateStart_Midnight_Minute"].Value;
            set => row["aiSightRateStart_Midnight_Minute"].Value = value;
        }

        // Unknown.
        public byte saLargeDamageHitSfx_Threshold
        {
            get => (byte)row["saLargeDamageHitSfx_Threshold"].Value;
            set => row["saLargeDamageHitSfx_Threshold"].Value = value;
        }

        // Unknown.
        public int saLargeDamageHitSfx_SfxId
        {
            get => (int)row["saLargeDamageHitSfx_SfxId"].Value;
            set => row["saLargeDamageHitSfx_SfxId"].Value = value;
        }

        // Unknown.
        public float signCreatableDistFromSafePos
        {
            get => (float)row["signCreatableDistFromSafePos"].Value;
            set => row["signCreatableDistFromSafePos"].Value = value;
        }

        // Unknown.
        public float guestResummonDist
        {
            get => (float)row["guestResummonDist"].Value;
            set => row["guestResummonDist"].Value = value;
        }

        // Unknown.
        public float guestLeavingMessageDistMax
        {
            get => (float)row["guestLeavingMessageDistMax"].Value;
            set => row["guestLeavingMessageDistMax"].Value = value;
        }

        // Unknown.
        public float guestLeavingMessageDistMin
        {
            get => (float)row["guestLeavingMessageDistMin"].Value;
            set => row["guestLeavingMessageDistMin"].Value = value;
        }

        // Unknown.
        public float guestLeaveSessionDist
        {
            get => (float)row["guestLeaveSessionDist"].Value;
            set => row["guestLeaveSessionDist"].Value = value;
        }

        // Unknown.
        public float retryPointAreaRadius
        {
            get => (float)row["retryPointAreaRadius"].Value;
            set => row["retryPointAreaRadius"].Value = value;
        }

        // Unknown.
        public int sleepCollectorSpEffectId
        {
            get => (int)row["sleepCollectorSpEffectId"].Value;
            set => row["sleepCollectorSpEffectId"].Value = value;
        }

        // Unknown.
        public int recoverBelowMaxHpCompletionNoticeSpEffectId
        {
            get => (int)row["recoverBelowMaxHpCompletionNoticeSpEffectId"].Value;
            set => row["recoverBelowMaxHpCompletionNoticeSpEffectId"].Value = value;
        }

        // Unknown.
        public int estusFlaskRecovery_AbsorptionProductionSfxId_byHp
        {
            get => (int)row["estusFlaskRecovery_AbsorptionProductionSfxId_byHp"].Value;
            set => row["estusFlaskRecovery_AbsorptionProductionSfxId_byHp"].Value = value;
        }

        // Unknown.
        public int estusFlaskRecovery_AbsorptionProductionSfxId_byMp
        {
            get => (int)row["estusFlaskRecovery_AbsorptionProductionSfxId_byMp"].Value;
            set => row["estusFlaskRecovery_AbsorptionProductionSfxId_byMp"].Value = value;
        }

        // Unknown.
        public int respawnSpecialEffectActiveCheckerSpEffectId
        {
            get => (int)row["respawnSpecialEffectActiveCheckerSpEffectId"].Value;
            set => row["respawnSpecialEffectActiveCheckerSpEffectId"].Value = value;
        }

        // Unknown.
        public int onBuddySummon_inActivateRange_spEffectId_buddy
        {
            get => (int)row["onBuddySummon_inActivateRange_spEffectId_buddy"].Value;
            set => row["onBuddySummon_inActivateRange_spEffectId_buddy"].Value = value;
        }

        // Unknown.
        public float estusFlaskRecovery_AddEstusTime
        {
            get => (float)row["estusFlaskRecovery_AddEstusTime"].Value;
            set => row["estusFlaskRecovery_AddEstusTime"].Value = value;
        }

        // Unknown.
        public float defeatMultiModeEnemyOfSoulCorrectRate_byHost
        {
            get => (float)row["defeatMultiModeEnemyOfSoulCorrectRate_byHost"].Value;
            set => row["defeatMultiModeEnemyOfSoulCorrectRate_byHost"].Value = value;
        }

        // Unknown.
        public float defeatMultiModeEnemyOfSoulCorrectRate_byTeamGhost
        {
            get => (float)row["defeatMultiModeEnemyOfSoulCorrectRate_byTeamGhost"].Value;
            set => row["defeatMultiModeEnemyOfSoulCorrectRate_byTeamGhost"].Value = value;
        }

        // Unknown.
        public float defeatMultiModeBossOfSoulCorrectRate_byHost
        {
            get => (float)row["defeatMultiModeBossOfSoulCorrectRate_byHost"].Value;
            set => row["defeatMultiModeBossOfSoulCorrectRate_byHost"].Value = value;
        }

        // Unknown.
        public float defeatMultiModeBossOfSoulCorrectRate_byTeamGhost
        {
            get => (float)row["defeatMultiModeBossOfSoulCorrectRate_byTeamGhost"].Value;
            set => row["defeatMultiModeBossOfSoulCorrectRate_byTeamGhost"].Value = value;
        }

        // Unknown.
        public ushort enemyHpGaugeScreenOffset_byUp
        {
            get => (ushort)row["enemyHpGaugeScreenOffset_byUp"].Value;
            set => row["enemyHpGaugeScreenOffset_byUp"].Value = value;
        }

        // Unknown.
        public ushort playRegionCollectDist
        {
            get => (ushort)row["playRegionCollectDist"].Value;
            set => row["playRegionCollectDist"].Value = value;
        }

        // Unknown.
        public ushort enemyDetectionSpEffect_ShootBulletDummypolyId
        {
            get => (ushort)row["enemyDetectionSpEffect_ShootBulletDummypolyId"].Value;
            set => row["enemyDetectionSpEffect_ShootBulletDummypolyId"].Value = value;
        }

        // Unknown.
        public ushort bigRuneGreaterDemonBreakInGoodsNum
        {
            get => (ushort)row["bigRuneGreaterDemonBreakInGoodsNum"].Value;
            set => row["bigRuneGreaterDemonBreakInGoodsNum"].Value = value;
        }

        // Unknown.
        public int bigRuneGreaterDemonBreakInGoodsId
        {
            get => (int)row["bigRuneGreaterDemonBreakInGoodsId"].Value;
            set => row["bigRuneGreaterDemonBreakInGoodsId"].Value = value;
        }

        // Unknown.
        public int rideJumpRegionDefaultSfxId
        {
            get => (int)row["rideJumpRegionDefaultSfxId"].Value;
            set => row["rideJumpRegionDefaultSfxId"].Value = value;
        }

        // Unknown.
        public float saAttackRate_forVsRideAtk
        {
            get => (float)row["saAttackRate_forVsRideAtk"].Value;
            set => row["saAttackRate_forVsRideAtk"].Value = value;
        }

        // Unknown.
        public int enemySpEffectIdAfterSleepCollectorItemLot
        {
            get => (int)row["enemySpEffectIdAfterSleepCollectorItemLot"].Value;
            set => row["enemySpEffectIdAfterSleepCollectorItemLot"].Value = value;
        }

        // Unknown.
        public int afterEndingMapUid
        {
            get => (int)row["afterEndingMapUid"].Value;
            set => row["afterEndingMapUid"].Value = value;
        }

        // Unknown.
        public uint afterEndingReturnPointEntityId
        {
            get => (uint)row["afterEndingReturnPointEntityId"].Value;
            set => row["afterEndingReturnPointEntityId"].Value = value;
        }

        // Unknown.
        public int enemyDetectionSpEffect_BulletId_byCoopRing_RedHunter
        {
            get => (int)row["enemyDetectionSpEffect_BulletId_byCoopRing_RedHunter"].Value;
            set => row["enemyDetectionSpEffect_BulletId_byCoopRing_RedHunter"].Value = value;
        }

        // Unknown.
        public int enemyDetectionSpEffect_BulletId_byInvadeOrb_None
        {
            get => (int)row["enemyDetectionSpEffect_BulletId_byInvadeOrb_None"].Value;
            set => row["enemyDetectionSpEffect_BulletId_byInvadeOrb_None"].Value = value;
        }

        // Unknown.
        public uint tutorialFlagOnAccessDistView
        {
            get => (uint)row["tutorialFlagOnAccessDistView"].Value;
            set => row["tutorialFlagOnAccessDistView"].Value = value;
        }

        // Unknown.
        public uint tutorialFlagOnAccessRetryPoint
        {
            get => (uint)row["tutorialFlagOnAccessRetryPoint"].Value;
            set => row["tutorialFlagOnAccessRetryPoint"].Value = value;
        }

        // Unknown.
        public uint tutorialFlagOnGetGroupReward
        {
            get => (uint)row["tutorialFlagOnGetGroupReward"].Value;
            set => row["tutorialFlagOnGetGroupReward"].Value = value;
        }

        // Unknown.
        public uint tutorialFlagOnEnterRideJumpRegion
        {
            get => (uint)row["tutorialFlagOnEnterRideJumpRegion"].Value;
            set => row["tutorialFlagOnEnterRideJumpRegion"].Value = value;
        }

        // Unknown.
        public float tutorialCheckRideJumpRegionExpandRange
        {
            get => (float)row["tutorialCheckRideJumpRegionExpandRange"].Value;
            set => row["tutorialCheckRideJumpRegionExpandRange"].Value = value;
        }

        // Unknown.
        public int retryPointActivatedPcAnimId
        {
            get => (int)row["retryPointActivatedPcAnimId"].Value;
            set => row["retryPointActivatedPcAnimId"].Value = value;
        }

        // Unknown.
        public float retryPointActivatedDialogDelayTime
        {
            get => (float)row["retryPointActivatedDialogDelayTime"].Value;
            set => row["retryPointActivatedDialogDelayTime"].Value = value;
        }

        // Unknown.
        public int retryPointActivatedDialogTextId
        {
            get => (int)row["retryPointActivatedDialogTextId"].Value;
            set => row["retryPointActivatedDialogTextId"].Value = value;
        }

        // Unknown.
        public int signPuddleOpenPcAnimId
        {
            get => (int)row["signPuddleOpenPcAnimId"].Value;
            set => row["signPuddleOpenPcAnimId"].Value = value;
        }

        // Unknown.
        public float signPuddleOpenDialogDelayTime
        {
            get => (float)row["signPuddleOpenDialogDelayTime"].Value;
            set => row["signPuddleOpenDialogDelayTime"].Value = value;
        }

        // Unknown.
        public int activityOfDeadSpEffect_BulletId
        {
            get => (int)row["activityOfDeadSpEffect_BulletId"].Value;
            set => row["activityOfDeadSpEffect_BulletId"].Value = value;
        }

        // Unknown.
        public int activityOfDeadSpEffect_ShootBulletDummypolyId
        {
            get => (int)row["activityOfDeadSpEffect_ShootBulletDummypolyId"].Value;
            set => row["activityOfDeadSpEffect_ShootBulletDummypolyId"].Value = value;
        }

        // Unknown.
        public float activityOfDeadSpEffect_DeadFadeOutTime
        {
            get => (float)row["activityOfDeadSpEffect_DeadFadeOutTime"].Value;
            set => row["activityOfDeadSpEffect_DeadFadeOutTime"].Value = value;
        }

        // Unknown.
        public float ignorNetStateSyncTime_ForThrow
        {
            get => (float)row["ignorNetStateSyncTime_ForThrow"].Value;
            set => row["ignorNetStateSyncTime_ForThrow"].Value = value;
        }

        // Unknown.
        public ushort netPenaltyPointLanDisconnect
        {
            get => (ushort)row["netPenaltyPointLanDisconnect"].Value;
            set => row["netPenaltyPointLanDisconnect"].Value = value;
        }

        // Unknown.
        public ushort netPenaltyPointProfileSignout
        {
            get => (ushort)row["netPenaltyPointProfileSignout"].Value;
            set => row["netPenaltyPointProfileSignout"].Value = value;
        }

        // Unknown.
        public ushort netPenaltyPointReboot
        {
            get => (ushort)row["netPenaltyPointReboot"].Value;
            set => row["netPenaltyPointReboot"].Value = value;
        }

        // Unknown.
        public ushort netPnaltyPointSuspend
        {
            get => (ushort)row["netPnaltyPointSuspend"].Value;
            set => row["netPnaltyPointSuspend"].Value = value;
        }

        // Unknown.
        public float netPenaltyForgiveItemLimitTime
        {
            get => (float)row["netPenaltyForgiveItemLimitTime"].Value;
            set => row["netPenaltyForgiveItemLimitTime"].Value = value;
        }

        // Unknown.
        public ushort netPenaltyPointThreshold
        {
            get => (ushort)row["netPenaltyPointThreshold"].Value;
            set => row["netPenaltyPointThreshold"].Value = value;
        }

        // Unknown.
        public ushort uncontrolledMoveThresholdTime
        {
            get => (ushort)row["uncontrolledMoveThresholdTime"].Value;
            set => row["uncontrolledMoveThresholdTime"].Value = value;
        }

        // Unknown.
        public int enemyDetectionSpEffect_BulletId_byNpcEnemy
        {
            get => (int)row["enemyDetectionSpEffect_BulletId_byNpcEnemy"].Value;
            set => row["enemyDetectionSpEffect_BulletId_byNpcEnemy"].Value = value;
        }

        // Unknown.
        public int activityOfDeadTargetSearchSpEffect_OnHitSpEffect
        {
            get => (int)row["activityOfDeadTargetSearchSpEffect_OnHitSpEffect"].Value;
            set => row["activityOfDeadTargetSearchSpEffect_OnHitSpEffect"].Value = value;
        }

        // Unknown.
        public float activityOfDeadTargetSearchSpEffect_MaxLength
        {
            get => (float)row["activityOfDeadTargetSearchSpEffect_MaxLength"].Value;
            set => row["activityOfDeadTargetSearchSpEffect_MaxLength"].Value = value;
        }

        // Unknown.
        public float sightRangeLowerPromiseRate
        {
            get => (float)row["sightRangeLowerPromiseRate"].Value;
            set => row["sightRangeLowerPromiseRate"].Value = value;
        }

        // Unknown.
        public short saLargeDamageHitSfx_MinDamage
        {
            get => (short)row["saLargeDamageHitSfx_MinDamage"].Value;
            set => row["saLargeDamageHitSfx_MinDamage"].Value = value;
        }

        // Unknown.
        public short saLargeDamageHitSfx_ForceDamage
        {
            get => (short)row["saLargeDamageHitSfx_ForceDamage"].Value;
            set => row["saLargeDamageHitSfx_ForceDamage"].Value = value;
        }

        // Unknown.
        public uint soloBreakInMaxPoint
        {
            get => (uint)row["soloBreakInMaxPoint"].Value;
            set => row["soloBreakInMaxPoint"].Value = value;
        }

        // Unknown.
        public float npcTalkTimeOutThreshold
        {
            get => (float)row["npcTalkTimeOutThreshold"].Value;
            set => row["npcTalkTimeOutThreshold"].Value = value;
        }

        // Unknown.
        public float sendPlayLogIntervalTime
        {
            get => (float)row["sendPlayLogIntervalTime"].Value;
            set => row["sendPlayLogIntervalTime"].Value = value;
        }

        // Unknown.
        public byte item370_MaxSfxNum
        {
            get => (byte)row["item370_MaxSfxNum"].Value;
            set => row["item370_MaxSfxNum"].Value = value;
        }

        // Unknown.
        public byte chrActivateDist_forLeavePC
        {
            get => (byte)row["chrActivateDist_forLeavePC"].Value;
            set => row["chrActivateDist_forLeavePC"].Value = value;
        }

        // Unknown.
        public short summonDataCoopMatchingLevelUpperAbs
        {
            get => (short)row["summonDataCoopMatchingLevelUpperAbs"].Value;
            set => row["summonDataCoopMatchingLevelUpperAbs"].Value = value;
        }

        // Unknown.
        public short summonDataCoopMatchingLevelUpperRel
        {
            get => (short)row["summonDataCoopMatchingLevelUpperRel"].Value;
            set => row["summonDataCoopMatchingLevelUpperRel"].Value = value;
        }

        // Unknown.
        public short summonDataCoopMatchingWepLevelMul
        {
            get => (short)row["summonDataCoopMatchingWepLevelMul"].Value;
            set => row["summonDataCoopMatchingWepLevelMul"].Value = value;
        }

        // Unknown.
        public int pickUpBerserkerSignSpEffectBulletId
        {
            get => (int)row["pickUpBerserkerSignSpEffectBulletId"].Value;
            set => row["pickUpBerserkerSignSpEffectBulletId"].Value = value;
        }

        // Unknown.
        public int succeedBerserkerSelfKillingEffectId
        {
            get => (int)row["succeedBerserkerSelfKillingEffectId"].Value;
            set => row["succeedBerserkerSelfKillingEffectId"].Value = value;
        }

        // Unknown.
        public byte machingLevelWhiteSignUpperRel
        {
            get => (byte)row["machingLevelWhiteSignUpperRel"].Value;
            set => row["machingLevelWhiteSignUpperRel"].Value = value;
        }

        // Unknown.
        public byte machingLevelWhiteSignUpperAbs
        {
            get => (byte)row["machingLevelWhiteSignUpperAbs"].Value;
            set => row["machingLevelWhiteSignUpperAbs"].Value = value;
        }

        // Unknown.
        public byte machingLevelRedSignUpperRel
        {
            get => (byte)row["machingLevelRedSignUpperRel"].Value;
            set => row["machingLevelRedSignUpperRel"].Value = value;
        }

        // Unknown.
        public byte machingLevelRedSignUpperAbs
        {
            get => (byte)row["machingLevelRedSignUpperAbs"].Value;
            set => row["machingLevelRedSignUpperAbs"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_0
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_0"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_0"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_1
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_1"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_1"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_2
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_2"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_2"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_3
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_3"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_3"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_4
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_4"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_4"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_5
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_5"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_5"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_6
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_6"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_6"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_7
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_7"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_7"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_8
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_8"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_8"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_9
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_9"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_9"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_10
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_10"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_10"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_0
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_0"].Value;
            set => row["machingWeaponLevelUpperRedSign_0"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_1
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_1"].Value;
            set => row["machingWeaponLevelUpperRedSign_1"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_2
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_2"].Value;
            set => row["machingWeaponLevelUpperRedSign_2"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_3
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_3"].Value;
            set => row["machingWeaponLevelUpperRedSign_3"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_4
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_4"].Value;
            set => row["machingWeaponLevelUpperRedSign_4"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_5
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_5"].Value;
            set => row["machingWeaponLevelUpperRedSign_5"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_6
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_6"].Value;
            set => row["machingWeaponLevelUpperRedSign_6"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_7
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_7"].Value;
            set => row["machingWeaponLevelUpperRedSign_7"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_8
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_8"].Value;
            set => row["machingWeaponLevelUpperRedSign_8"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_9
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_9"].Value;
            set => row["machingWeaponLevelUpperRedSign_9"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_10
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_10"].Value;
            set => row["machingWeaponLevelUpperRedSign_10"].Value = value;
        }

        // Unknown.
        public byte autoInvadePoint_generateDist
        {
            get => (byte)row["autoInvadePoint_generateDist"].Value;
            set => row["autoInvadePoint_generateDist"].Value = value;
        }

        // Unknown.
        public byte autoInvadePoint_cancelDist
        {
            get => (byte)row["autoInvadePoint_cancelDist"].Value;
            set => row["autoInvadePoint_cancelDist"].Value = value;
        }

        // Unknown.
        public float sendGlobalEventLogIntervalTime
        {
            get => (float)row["sendGlobalEventLogIntervalTime"].Value;
            set => row["sendGlobalEventLogIntervalTime"].Value = value;
        }

        // Unknown.
        public ushort addSoloBreakInPoint_White
        {
            get => (ushort)row["addSoloBreakInPoint_White"].Value;
            set => row["addSoloBreakInPoint_White"].Value = value;
        }

        // Unknown.
        public ushort addSoloBreakInPoint_Black
        {
            get => (ushort)row["addSoloBreakInPoint_Black"].Value;
            set => row["addSoloBreakInPoint_Black"].Value = value;
        }

        // Unknown.
        public ushort addSoloBreakInPoint_ForceJoin
        {
            get => (ushort)row["addSoloBreakInPoint_ForceJoin"].Value;
            set => row["addSoloBreakInPoint_ForceJoin"].Value = value;
        }

        // Unknown.
        public ushort addSoloBreakInPoint_VisitorGuardian
        {
            get => (ushort)row["addSoloBreakInPoint_VisitorGuardian"].Value;
            set => row["addSoloBreakInPoint_VisitorGuardian"].Value = value;
        }

        // Unknown.
        public ushort addSoloBreakInPoint_VisitorRedHunter
        {
            get => (ushort)row["addSoloBreakInPoint_VisitorRedHunter"].Value;
            set => row["addSoloBreakInPoint_VisitorRedHunter"].Value = value;
        }

        // Unknown.
        public byte invincibleTimer_forNetPC_initSync
        {
            get => (byte)row["invincibleTimer_forNetPC_initSync"].Value;
            set => row["invincibleTimer_forNetPC_initSync"].Value = value;
        }

        // Unknown.
        public byte invincibleTimer_forNetPC
        {
            get => (byte)row["invincibleTimer_forNetPC"].Value;
            set => row["invincibleTimer_forNetPC"].Value = value;
        }

        // Unknown.
        public float redHunter_HostBossAreaGetSoulRate
        {
            get => (float)row["redHunter_HostBossAreaGetSoulRate"].Value;
            set => row["redHunter_HostBossAreaGetSoulRate"].Value = value;
        }

        // Unknown.
        public int ghostFootprintDecalParamId
        {
            get => (int)row["ghostFootprintDecalParamId"].Value;
            set => row["ghostFootprintDecalParamId"].Value = value;
        }

        // Unknown.
        public float leaveAroundHostWarningTime
        {
            get => (float)row["leaveAroundHostWarningTime"].Value;
            set => row["leaveAroundHostWarningTime"].Value = value;
        }

        // Unknown.
        public int hostModeCostItemId
        {
            get => (int)row["hostModeCostItemId"].Value;
            set => row["hostModeCostItemId"].Value = value;
        }

        // Unknown.
        public float aIJump_DecelerateParam
        {
            get => (float)row["aIJump_DecelerateParam"].Value;
            set => row["aIJump_DecelerateParam"].Value = value;
        }

        // Unknown.
        public float buddyDisappearDelaySec
        {
            get => (float)row["buddyDisappearDelaySec"].Value;
            set => row["buddyDisappearDelaySec"].Value = value;
        }

        // Unknown.
        public float aIJump_AnimYMoveCorrectRate_onJumpOff
        {
            get => (float)row["aIJump_AnimYMoveCorrectRate_onJumpOff"].Value;
            set => row["aIJump_AnimYMoveCorrectRate_onJumpOff"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightRate_NotInStealthRigid_NotSightHide_StealthMode
        {
            get => (float)row["stealthSystemSightRate_NotInStealthRigid_NotSightHide_StealthMode"].Value;
            set => row["stealthSystemSightRate_NotInStealthRigid_NotSightHide_StealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightRate_NotInStealthRigid_SightHide_NotStealthMode
        {
            get => (float)row["stealthSystemSightRate_NotInStealthRigid_SightHide_NotStealthMode"].Value;
            set => row["stealthSystemSightRate_NotInStealthRigid_SightHide_NotStealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightRate_NotInStealthRigid_SightHide_StealthMode
        {
            get => (float)row["stealthSystemSightRate_NotInStealthRigid_SightHide_StealthMode"].Value;
            set => row["stealthSystemSightRate_NotInStealthRigid_SightHide_StealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightRate_InStealthRigid_NotSightHide_NotStealthMode
        {
            get => (float)row["stealthSystemSightRate_InStealthRigid_NotSightHide_NotStealthMode"].Value;
            set => row["stealthSystemSightRate_InStealthRigid_NotSightHide_NotStealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightRate_InStealthRigid_NotSightHide_StealthMode
        {
            get => (float)row["stealthSystemSightRate_InStealthRigid_NotSightHide_StealthMode"].Value;
            set => row["stealthSystemSightRate_InStealthRigid_NotSightHide_StealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightRate_InStealthRigid_SightHide_NotStealthMode
        {
            get => (float)row["stealthSystemSightRate_InStealthRigid_SightHide_NotStealthMode"].Value;
            set => row["stealthSystemSightRate_InStealthRigid_SightHide_NotStealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightRate_InStealthRigid_SightHide_StealthMode
        {
            get => (float)row["stealthSystemSightRate_InStealthRigid_SightHide_StealthMode"].Value;
            set => row["stealthSystemSightRate_InStealthRigid_SightHide_StealthMode"].Value = value;
        }

        // Unknown.
        public int msbEventGeomTreasureInfo_actionButtonParamId_corpse
        {
            get => (int)row["msbEventGeomTreasureInfo_actionButtonParamId_corpse"].Value;
            set => row["msbEventGeomTreasureInfo_actionButtonParamId_corpse"].Value = value;
        }

        // Unknown.
        public int msbEventGeomTreasureInfo_itemGetAnimId_corpse
        {
            get => (int)row["msbEventGeomTreasureInfo_itemGetAnimId_corpse"].Value;
            set => row["msbEventGeomTreasureInfo_itemGetAnimId_corpse"].Value = value;
        }

        // Unknown.
        public int msbEventGeomTreasureInfo_actionButtonParamId_box
        {
            get => (int)row["msbEventGeomTreasureInfo_actionButtonParamId_box"].Value;
            set => row["msbEventGeomTreasureInfo_actionButtonParamId_box"].Value = value;
        }

        // Unknown.
        public int msbEventGeomTreasureInfo_itemGetAnimId_box
        {
            get => (int)row["msbEventGeomTreasureInfo_itemGetAnimId_box"].Value;
            set => row["msbEventGeomTreasureInfo_itemGetAnimId_box"].Value = value;
        }

        // Unknown.
        public int msbEventGeomTreasureInfo_actionButtonParamId_shine
        {
            get => (int)row["msbEventGeomTreasureInfo_actionButtonParamId_shine"].Value;
            set => row["msbEventGeomTreasureInfo_actionButtonParamId_shine"].Value = value;
        }

        // Unknown.
        public int msbEventGeomTreasureInfo_itemGetAnimId_shine
        {
            get => (int)row["msbEventGeomTreasureInfo_itemGetAnimId_shine"].Value;
            set => row["msbEventGeomTreasureInfo_itemGetAnimId_shine"].Value = value;
        }

        // Unknown.
        public int signPuddleAssetId
        {
            get => (int)row["signPuddleAssetId"].Value;
            set => row["signPuddleAssetId"].Value = value;
        }

        // Unknown.
        public int signPuddleAppearDmypolyId0
        {
            get => (int)row["signPuddleAppearDmypolyId0"].Value;
            set => row["signPuddleAppearDmypolyId0"].Value = value;
        }

        // Unknown.
        public int signPuddleAppearDmypolyId1
        {
            get => (int)row["signPuddleAppearDmypolyId1"].Value;
            set => row["signPuddleAppearDmypolyId1"].Value = value;
        }

        // Unknown.
        public int signPuddleAppearDmypolyId2
        {
            get => (int)row["signPuddleAppearDmypolyId2"].Value;
            set => row["signPuddleAppearDmypolyId2"].Value = value;
        }

        // Unknown.
        public int signPuddleAppearDmypolyId3
        {
            get => (int)row["signPuddleAppearDmypolyId3"].Value;
            set => row["signPuddleAppearDmypolyId3"].Value = value;
        }

        // Unknown.
        public float fallDamageRate_forRidePC
        {
            get => (float)row["fallDamageRate_forRidePC"].Value;
            set => row["fallDamageRate_forRidePC"].Value = value;
        }

        // Unknown.
        public float fallDamageRate_forRideNPC
        {
            get => (float)row["fallDamageRate_forRideNPC"].Value;
            set => row["fallDamageRate_forRideNPC"].Value = value;
        }

        // Unknown.
        public int OldMonkOfYellow_CreateSignSpEffectId
        {
            get => (int)row["OldMonkOfYellow_CreateSignSpEffectId"].Value;
            set => row["OldMonkOfYellow_CreateSignSpEffectId"].Value = value;
        }

        // Unknown.
        public float StragglerActivateDist
        {
            get => (float)row["StragglerActivateDist"].Value;
            set => row["StragglerActivateDist"].Value = value;
        }

        // Unknown.
        public int SpEffectId_EnableUseItem_StragglerActivate
        {
            get => (int)row["SpEffectId_EnableUseItem_StragglerActivate"].Value;
            set => row["SpEffectId_EnableUseItem_StragglerActivate"].Value = value;
        }

        // Unknown.
        public int SpEffectId_StragglerWakeUp
        {
            get => (int)row["SpEffectId_StragglerWakeUp"].Value;
            set => row["SpEffectId_StragglerWakeUp"].Value = value;
        }

        // Unknown.
        public int SpEffectId_StragglerTarget
        {
            get => (int)row["SpEffectId_StragglerTarget"].Value;
            set => row["SpEffectId_StragglerTarget"].Value = value;
        }

        // Unknown.
        public int SpEffectId_StragglerOppose
        {
            get => (int)row["SpEffectId_StragglerOppose"].Value;
            set => row["SpEffectId_StragglerOppose"].Value = value;
        }

        // Unknown.
        public float buddyWarp_TriggerTimeRayBlocked
        {
            get => (float)row["buddyWarp_TriggerTimeRayBlocked"].Value;
            set => row["buddyWarp_TriggerTimeRayBlocked"].Value = value;
        }

        // Unknown.
        public float buddyWarp_TriggerDistToPlayer
        {
            get => (float)row["buddyWarp_TriggerDistToPlayer"].Value;
            set => row["buddyWarp_TriggerDistToPlayer"].Value = value;
        }

        // Unknown.
        public float buddyWarp_ThresholdTimePathStacked
        {
            get => (float)row["buddyWarp_ThresholdTimePathStacked"].Value;
            set => row["buddyWarp_ThresholdTimePathStacked"].Value = value;
        }

        // Unknown.
        public float buddyWarp_ThresholdRangePathStacked
        {
            get => (float)row["buddyWarp_ThresholdRangePathStacked"].Value;
            set => row["buddyWarp_ThresholdRangePathStacked"].Value = value;
        }

        // Unknown.
        public float aiSightRate_morning
        {
            get => (float)row["aiSightRate_morning"].Value;
            set => row["aiSightRate_morning"].Value = value;
        }

        // Unknown.
        public float aiSightRate_noonA
        {
            get => (float)row["aiSightRate_noonA"].Value;
            set => row["aiSightRate_noonA"].Value = value;
        }

        // Unknown.
        public float buddyPassThroughTriggerTime
        {
            get => (float)row["buddyPassThroughTriggerTime"].Value;
            set => row["buddyPassThroughTriggerTime"].Value = value;
        }

        // Unknown.
        public float aiSightRate_evening
        {
            get => (float)row["aiSightRate_evening"].Value;
            set => row["aiSightRate_evening"].Value = value;
        }

        // Unknown.
        public float aiSightRate_night
        {
            get => (float)row["aiSightRate_night"].Value;
            set => row["aiSightRate_night"].Value = value;
        }

        // Unknown.
        public float aiSightRate_midnightA
        {
            get => (float)row["aiSightRate_midnightA"].Value;
            set => row["aiSightRate_midnightA"].Value = value;
        }

        // Unknown.
        public float aiSightRate_sunloss_light
        {
            get => (float)row["aiSightRate_sunloss_light"].Value;
            set => row["aiSightRate_sunloss_light"].Value = value;
        }

        // Unknown.
        public float aiSightRate_sunloss_dark
        {
            get => (float)row["aiSightRate_sunloss_dark"].Value;
            set => row["aiSightRate_sunloss_dark"].Value = value;
        }

        // Unknown.
        public float aiSightRate_sunloss_veryDark
        {
            get => (float)row["aiSightRate_sunloss_veryDark"].Value;
            set => row["aiSightRate_sunloss_veryDark"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightAngleReduceRate_NotInStealthRigid_NotSightHide_StealthMode
        {
            get => (float)row["stealthSystemSightAngleReduceRate_NotInStealthRigid_NotSightHide_StealthMode"].Value;
            set => row["stealthSystemSightAngleReduceRate_NotInStealthRigid_NotSightHide_StealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightAngleReduceRate_NotInStealthRigid_SightHide_NotStealthMode
        {
            get => (float)row["stealthSystemSightAngleReduceRate_NotInStealthRigid_SightHide_NotStealthMode"].Value;
            set => row["stealthSystemSightAngleReduceRate_NotInStealthRigid_SightHide_NotStealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightAngleReduceRate_NotInStealthRigid_SightHide_StealthMode
        {
            get => (float)row["stealthSystemSightAngleReduceRate_NotInStealthRigid_SightHide_StealthMode"].Value;
            set => row["stealthSystemSightAngleReduceRate_NotInStealthRigid_SightHide_StealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightAngleReduceRate_InStealthRigid_NotSightHide_NotStealthMode
        {
            get => (float)row["stealthSystemSightAngleReduceRate_InStealthRigid_NotSightHide_NotStealthMode"].Value;
            set => row["stealthSystemSightAngleReduceRate_InStealthRigid_NotSightHide_NotStealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightAngleReduceRate_InStealthRigid_NotSightHide_StealthMode
        {
            get => (float)row["stealthSystemSightAngleReduceRate_InStealthRigid_NotSightHide_StealthMode"].Value;
            set => row["stealthSystemSightAngleReduceRate_InStealthRigid_NotSightHide_StealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightAngleReduceRate_InStealthRigid_SightHide_NotStealthMode
        {
            get => (float)row["stealthSystemSightAngleReduceRate_InStealthRigid_SightHide_NotStealthMode"].Value;
            set => row["stealthSystemSightAngleReduceRate_InStealthRigid_SightHide_NotStealthMode"].Value = value;
        }

        // Unknown.
        public float stealthSystemSightAngleReduceRate_InStealthRigid_SightHide_StealthMode
        {
            get => (float)row["stealthSystemSightAngleReduceRate_InStealthRigid_SightHide_StealthMode"].Value;
            set => row["stealthSystemSightAngleReduceRate_InStealthRigid_SightHide_StealthMode"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_Morning_Hour
        {
            get => (byte)row["weatherLotConditionStart_Morning_Hour"].Value;
            set => row["weatherLotConditionStart_Morning_Hour"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_Morning_Minute
        {
            get => (byte)row["weatherLotConditionStart_Morning_Minute"].Value;
            set => row["weatherLotConditionStart_Morning_Minute"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_Day_Hour
        {
            get => (byte)row["weatherLotConditionStart_Day_Hour"].Value;
            set => row["weatherLotConditionStart_Day_Hour"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_Day_Minute
        {
            get => (byte)row["weatherLotConditionStart_Day_Minute"].Value;
            set => row["weatherLotConditionStart_Day_Minute"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_Evening_Hour
        {
            get => (byte)row["weatherLotConditionStart_Evening_Hour"].Value;
            set => row["weatherLotConditionStart_Evening_Hour"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_Evening_Minute
        {
            get => (byte)row["weatherLotConditionStart_Evening_Minute"].Value;
            set => row["weatherLotConditionStart_Evening_Minute"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_Night_Hour
        {
            get => (byte)row["weatherLotConditionStart_Night_Hour"].Value;
            set => row["weatherLotConditionStart_Night_Hour"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_Night_Minute
        {
            get => (byte)row["weatherLotConditionStart_Night_Minute"].Value;
            set => row["weatherLotConditionStart_Night_Minute"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_DayBreak_Hour
        {
            get => (byte)row["weatherLotConditionStart_DayBreak_Hour"].Value;
            set => row["weatherLotConditionStart_DayBreak_Hour"].Value = value;
        }

        // Unknown.
        public byte weatherLotConditionStart_DayBreak_Minute
        {
            get => (byte)row["weatherLotConditionStart_DayBreak_Minute"].Value;
            set => row["weatherLotConditionStart_DayBreak_Minute"].Value = value;
        }

        // Unknown.
        public byte pclightScaleChangeStart_Hour
        {
            get => (byte)row["pclightScaleChangeStart_Hour"].Value;
            set => row["pclightScaleChangeStart_Hour"].Value = value;
        }

        // Unknown.
        public byte pclightScaleChangeStart_Minute
        {
            get => (byte)row["pclightScaleChangeStart_Minute"].Value;
            set => row["pclightScaleChangeStart_Minute"].Value = value;
        }

        // Unknown.
        public byte pclightScaleChangeEnd_Hour
        {
            get => (byte)row["pclightScaleChangeEnd_Hour"].Value;
            set => row["pclightScaleChangeEnd_Hour"].Value = value;
        }

        // Unknown.
        public byte pclightScaleChangeEnd_Minute
        {
            get => (byte)row["pclightScaleChangeEnd_Minute"].Value;
            set => row["pclightScaleChangeEnd_Minute"].Value = value;
        }

        // Unknown.
        public float pclightScaleByTimezone
        {
            get => (float)row["pclightScaleByTimezone"].Value;
            set => row["pclightScaleByTimezone"].Value = value;
        }

        // Unknown.
        public int bigRuneGreaterDemon_SummonBuddySpecialEffectId_Buddy
        {
            get => (int)row["bigRuneGreaterDemon_SummonBuddySpecialEffectId_Buddy"].Value;
            set => row["bigRuneGreaterDemon_SummonBuddySpecialEffectId_Buddy"].Value = value;
        }

        // Unknown.
        public int bigRuneGreaterDemon_SummonBuddySpecialEffectId_Pc
        {
            get => (int)row["bigRuneGreaterDemon_SummonBuddySpecialEffectId_Pc"].Value;
            set => row["bigRuneGreaterDemon_SummonBuddySpecialEffectId_Pc"].Value = value;
        }

        // Unknown.
        public int homeBonfireParamId
        {
            get => (int)row["homeBonfireParamId"].Value;
            set => row["homeBonfireParamId"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_11
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_11"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_11"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_12
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_12"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_12"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_13
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_13"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_13"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_14
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_14"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_14"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_15
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_15"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_15"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_16
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_16"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_16"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_17
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_17"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_17"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_18
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_18"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_18"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_19
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_19"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_19"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_20
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_20"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_20"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_21
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_21"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_21"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_22
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_22"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_22"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_23
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_23"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_23"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_24
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_24"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_24"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperWhiteSign_25
        {
            get => (byte)row["machingWeaponLevelUpperWhiteSign_25"].Value;
            set => row["machingWeaponLevelUpperWhiteSign_25"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_11
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_11"].Value;
            set => row["machingWeaponLevelUpperRedSign_11"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_12
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_12"].Value;
            set => row["machingWeaponLevelUpperRedSign_12"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_13
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_13"].Value;
            set => row["machingWeaponLevelUpperRedSign_13"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_14
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_14"].Value;
            set => row["machingWeaponLevelUpperRedSign_14"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_15
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_15"].Value;
            set => row["machingWeaponLevelUpperRedSign_15"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_16
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_16"].Value;
            set => row["machingWeaponLevelUpperRedSign_16"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_17
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_17"].Value;
            set => row["machingWeaponLevelUpperRedSign_17"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_18
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_18"].Value;
            set => row["machingWeaponLevelUpperRedSign_18"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_19
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_19"].Value;
            set => row["machingWeaponLevelUpperRedSign_19"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_20
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_20"].Value;
            set => row["machingWeaponLevelUpperRedSign_20"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_21
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_21"].Value;
            set => row["machingWeaponLevelUpperRedSign_21"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_22
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_22"].Value;
            set => row["machingWeaponLevelUpperRedSign_22"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_23
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_23"].Value;
            set => row["machingWeaponLevelUpperRedSign_23"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_24
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_24"].Value;
            set => row["machingWeaponLevelUpperRedSign_24"].Value = value;
        }

        // Unknown.
        public byte machingWeaponLevelUpperRedSign_25
        {
            get => (byte)row["machingWeaponLevelUpperRedSign_25"].Value;
            set => row["machingWeaponLevelUpperRedSign_25"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Morning_Hour
        {
            get => (byte)row["menuTimezoneStart_Morning_Hour"].Value;
            set => row["menuTimezoneStart_Morning_Hour"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Morning_Minute
        {
            get => (byte)row["menuTimezoneStart_Morning_Minute"].Value;
            set => row["menuTimezoneStart_Morning_Minute"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Day1_Hour
        {
            get => (byte)row["menuTimezoneStart_Day1_Hour"].Value;
            set => row["menuTimezoneStart_Day1_Hour"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Day1_Minute
        {
            get => (byte)row["menuTimezoneStart_Day1_Minute"].Value;
            set => row["menuTimezoneStart_Day1_Minute"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Day2_Hour
        {
            get => (byte)row["menuTimezoneStart_Day2_Hour"].Value;
            set => row["menuTimezoneStart_Day2_Hour"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Day2_Minute
        {
            get => (byte)row["menuTimezoneStart_Day2_Minute"].Value;
            set => row["menuTimezoneStart_Day2_Minute"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Evening_Hour
        {
            get => (byte)row["menuTimezoneStart_Evening_Hour"].Value;
            set => row["menuTimezoneStart_Evening_Hour"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Evening_Minute
        {
            get => (byte)row["menuTimezoneStart_Evening_Minute"].Value;
            set => row["menuTimezoneStart_Evening_Minute"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Night_Hour
        {
            get => (byte)row["menuTimezoneStart_Night_Hour"].Value;
            set => row["menuTimezoneStart_Night_Hour"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Night_Minute
        {
            get => (byte)row["menuTimezoneStart_Night_Minute"].Value;
            set => row["menuTimezoneStart_Night_Minute"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Midnight_Hour
        {
            get => (byte)row["menuTimezoneStart_Midnight_Hour"].Value;
            set => row["menuTimezoneStart_Midnight_Hour"].Value = value;
        }

        // Unknown.
        public byte menuTimezoneStart_Midnight_Minute
        {
            get => (byte)row["menuTimezoneStart_Midnight_Minute"].Value;
            set => row["menuTimezoneStart_Midnight_Minute"].Value = value;
        }

        // Unknown.
        public ushort remotePlayerThreatLvNotify_ThreatLv
        {
            get => (ushort)row["remotePlayerThreatLvNotify_ThreatLv"].Value;
            set => row["remotePlayerThreatLvNotify_ThreatLv"].Value = value;
        }

        // Unknown.
        public float remotePlayerThreatLvNotify_NotifyDist
        {
            get => (float)row["remotePlayerThreatLvNotify_NotifyDist"].Value;
            set => row["remotePlayerThreatLvNotify_NotifyDist"].Value = value;
        }

        // Unknown.
        public float remotePlayerThreatLvNotify_EndNotifyDist
        {
            get => (float)row["remotePlayerThreatLvNotify_EndNotifyDist"].Value;
            set => row["remotePlayerThreatLvNotify_EndNotifyDist"].Value = value;
        }

        // Unknown.
        public float worldMapPointDiscoveryExpandRange
        {
            get => (float)row["worldMapPointDiscoveryExpandRange"].Value;
            set => row["worldMapPointDiscoveryExpandRange"].Value = value;
        }

        // Unknown.
        public float worldMapPointReentryExpandRange
        {
            get => (float)row["worldMapPointReentryExpandRange"].Value;
            set => row["worldMapPointReentryExpandRange"].Value = value;
        }

        // Unknown.
        public ushort remotePlayerThreatLvNotify_NotifyTime
        {
            get => (ushort)row["remotePlayerThreatLvNotify_NotifyTime"].Value;
            set => row["remotePlayerThreatLvNotify_NotifyTime"].Value = value;
        }

        // Unknown.
        public ushort breakIn_A_rebreakInGoodsNum
        {
            get => (ushort)row["breakIn_A_rebreakInGoodsNum"].Value;
            set => row["breakIn_A_rebreakInGoodsNum"].Value = value;
        }

        // Unknown.
        public int breakIn_A_rebreakInGoodsId
        {
            get => (int)row["breakIn_A_rebreakInGoodsId"].Value;
            set => row["breakIn_A_rebreakInGoodsId"].Value = value;
        }

        // Unknown.
        public int rideJumpoff_SfxId
        {
            get => (int)row["rideJumpoff_SfxId"].Value;
            set => row["rideJumpoff_SfxId"].Value = value;
        }

        // Unknown.
        public float rideJumpoff_SfxHeightOffset
        {
            get => (float)row["rideJumpoff_SfxHeightOffset"].Value;
            set => row["rideJumpoff_SfxHeightOffset"].Value = value;
        }

        // Unknown.
        public int rideJumpoff_SpEffectId
        {
            get => (int)row["rideJumpoff_SpEffectId"].Value;
            set => row["rideJumpoff_SpEffectId"].Value = value;
        }

        // Unknown.
        public int rideJumpoff_SpEffectIdPc
        {
            get => (int)row["rideJumpoff_SpEffectIdPc"].Value;
            set => row["rideJumpoff_SpEffectIdPc"].Value = value;
        }

        // Unknown.
        public uint unlockExchangeMenuEventFlagId
        {
            get => (uint)row["unlockExchangeMenuEventFlagId"].Value;
            set => row["unlockExchangeMenuEventFlagId"].Value = value;
        }

        // Unknown.
        public uint unlockMessageMenuEventFlagId
        {
            get => (uint)row["unlockMessageMenuEventFlagId"].Value;
            set => row["unlockMessageMenuEventFlagId"].Value = value;
        }

        // Unknown.
        public ushort breakInOnce_A_rebreakInGoodsNum
        {
            get => (ushort)row["breakInOnce_A_rebreakInGoodsNum"].Value;
            set => row["breakInOnce_A_rebreakInGoodsNum"].Value = value;
        }

        // Unknown.
        public ushort breakIn_B_rebreakInGoodsNum
        {
            get => (ushort)row["breakIn_B_rebreakInGoodsNum"].Value;
            set => row["breakIn_B_rebreakInGoodsNum"].Value = value;
        }

        // Unknown.
        public int breakInOnce_A_rebreakInGoodsId
        {
            get => (int)row["breakInOnce_A_rebreakInGoodsId"].Value;
            set => row["breakInOnce_A_rebreakInGoodsId"].Value = value;
        }

        // Unknown.
        public int breakIn_B_rebreakInGoodsId
        {
            get => (int)row["breakIn_B_rebreakInGoodsId"].Value;
            set => row["breakIn_B_rebreakInGoodsId"].Value = value;
        }

        // Unknown.
        public float actionButtonInputCancelTime
        {
            get => (float)row["actionButtonInputCancelTime"].Value;
            set => row["actionButtonInputCancelTime"].Value = value;
        }

        // Unknown.
        public float blockClearBonusDelayTime
        {
            get => (float)row["blockClearBonusDelayTime"].Value;
            set => row["blockClearBonusDelayTime"].Value = value;
        }

        // Unknown.
        public float bonfireCheckEnemyRange
        {
            get => (float)row["bonfireCheckEnemyRange"].Value;
            set => row["bonfireCheckEnemyRange"].Value = value;
        }

        public object this[string fieldName]
        {
            get => row[fieldName].Value;
            set => row[fieldName].Value = value;
        }
    }
    
    /// <summary>
    /// Construct from a standard `PARAM` read from disk.
    /// </summary>
    public GAME_SYSTEM_COMMON_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public GAME_SYSTEM_COMMON_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
