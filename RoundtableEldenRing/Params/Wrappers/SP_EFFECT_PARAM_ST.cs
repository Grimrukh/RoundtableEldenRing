using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class SP_EFFECT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int iconId
        {
            get => (int)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public float conditionHp
        {
            get => (float)row["conditionHp"].Value;
            set => row["conditionHp"].Value = value;
        }

        // Unknown.
        public float effectEndurance
        {
            get => (float)row["effectEndurance"].Value;
            set => row["effectEndurance"].Value = value;
        }

        // Unknown.
        public float motionInterval
        {
            get => (float)row["motionInterval"].Value;
            set => row["motionInterval"].Value = value;
        }

        // Unknown.
        public float maxHpRate
        {
            get => (float)row["maxHpRate"].Value;
            set => row["maxHpRate"].Value = value;
        }

        // Unknown.
        public float maxMpRate
        {
            get => (float)row["maxMpRate"].Value;
            set => row["maxMpRate"].Value = value;
        }

        // Unknown.
        public float maxStaminaRate
        {
            get => (float)row["maxStaminaRate"].Value;
            set => row["maxStaminaRate"].Value = value;
        }

        // Unknown.
        public float slashDamageCutRate
        {
            get => (float)row["slashDamageCutRate"].Value;
            set => row["slashDamageCutRate"].Value = value;
        }

        // Unknown.
        public float blowDamageCutRate
        {
            get => (float)row["blowDamageCutRate"].Value;
            set => row["blowDamageCutRate"].Value = value;
        }

        // Unknown.
        public float thrustDamageCutRate
        {
            get => (float)row["thrustDamageCutRate"].Value;
            set => row["thrustDamageCutRate"].Value = value;
        }

        // Unknown.
        public float neutralDamageCutRate
        {
            get => (float)row["neutralDamageCutRate"].Value;
            set => row["neutralDamageCutRate"].Value = value;
        }

        // Unknown.
        public float magicDamageCutRate
        {
            get => (float)row["magicDamageCutRate"].Value;
            set => row["magicDamageCutRate"].Value = value;
        }

        // Unknown.
        public float fireDamageCutRate
        {
            get => (float)row["fireDamageCutRate"].Value;
            set => row["fireDamageCutRate"].Value = value;
        }

        // Unknown.
        public float thunderDamageCutRate
        {
            get => (float)row["thunderDamageCutRate"].Value;
            set => row["thunderDamageCutRate"].Value = value;
        }

        // Unknown.
        public float physicsAttackRate
        {
            get => (float)row["physicsAttackRate"].Value;
            set => row["physicsAttackRate"].Value = value;
        }

        // Unknown.
        public float magicAttackRate
        {
            get => (float)row["magicAttackRate"].Value;
            set => row["magicAttackRate"].Value = value;
        }

        // Unknown.
        public float fireAttackRate
        {
            get => (float)row["fireAttackRate"].Value;
            set => row["fireAttackRate"].Value = value;
        }

        // Unknown.
        public float thunderAttackRate
        {
            get => (float)row["thunderAttackRate"].Value;
            set => row["thunderAttackRate"].Value = value;
        }

        // Unknown.
        public float physicsAttackPowerRate
        {
            get => (float)row["physicsAttackPowerRate"].Value;
            set => row["physicsAttackPowerRate"].Value = value;
        }

        // Unknown.
        public float magicAttackPowerRate
        {
            get => (float)row["magicAttackPowerRate"].Value;
            set => row["magicAttackPowerRate"].Value = value;
        }

        // Unknown.
        public float fireAttackPowerRate
        {
            get => (float)row["fireAttackPowerRate"].Value;
            set => row["fireAttackPowerRate"].Value = value;
        }

        // Unknown.
        public float thunderAttackPowerRate
        {
            get => (float)row["thunderAttackPowerRate"].Value;
            set => row["thunderAttackPowerRate"].Value = value;
        }

        // Unknown.
        public int physicsAttackPower
        {
            get => (int)row["physicsAttackPower"].Value;
            set => row["physicsAttackPower"].Value = value;
        }

        // Unknown.
        public int magicAttackPower
        {
            get => (int)row["magicAttackPower"].Value;
            set => row["magicAttackPower"].Value = value;
        }

        // Unknown.
        public int fireAttackPower
        {
            get => (int)row["fireAttackPower"].Value;
            set => row["fireAttackPower"].Value = value;
        }

        // Unknown.
        public int thunderAttackPower
        {
            get => (int)row["thunderAttackPower"].Value;
            set => row["thunderAttackPower"].Value = value;
        }

        // Unknown.
        public float physicsDiffenceRate
        {
            get => (float)row["physicsDiffenceRate"].Value;
            set => row["physicsDiffenceRate"].Value = value;
        }

        // Unknown.
        public float magicDiffenceRate
        {
            get => (float)row["magicDiffenceRate"].Value;
            set => row["magicDiffenceRate"].Value = value;
        }

        // Unknown.
        public float fireDiffenceRate
        {
            get => (float)row["fireDiffenceRate"].Value;
            set => row["fireDiffenceRate"].Value = value;
        }

        // Unknown.
        public float thunderDiffenceRate
        {
            get => (float)row["thunderDiffenceRate"].Value;
            set => row["thunderDiffenceRate"].Value = value;
        }

        // Unknown.
        public int physicsDiffence
        {
            get => (int)row["physicsDiffence"].Value;
            set => row["physicsDiffence"].Value = value;
        }

        // Unknown.
        public int magicDiffence
        {
            get => (int)row["magicDiffence"].Value;
            set => row["magicDiffence"].Value = value;
        }

        // Unknown.
        public int fireDiffence
        {
            get => (int)row["fireDiffence"].Value;
            set => row["fireDiffence"].Value = value;
        }

        // Unknown.
        public int thunderDiffence
        {
            get => (int)row["thunderDiffence"].Value;
            set => row["thunderDiffence"].Value = value;
        }

        // Unknown.
        public float NoGuardDamageRate
        {
            get => (float)row["NoGuardDamageRate"].Value;
            set => row["NoGuardDamageRate"].Value = value;
        }

        // Unknown.
        public float vitalSpotChangeRate
        {
            get => (float)row["vitalSpotChangeRate"].Value;
            set => row["vitalSpotChangeRate"].Value = value;
        }

        // Unknown.
        public float normalSpotChangeRate
        {
            get => (float)row["normalSpotChangeRate"].Value;
            set => row["normalSpotChangeRate"].Value = value;
        }

        // Unknown.
        public float lookAtTargetPosOffset
        {
            get => (float)row["lookAtTargetPosOffset"].Value;
            set => row["lookAtTargetPosOffset"].Value = value;
        }

        // Unknown.
        public int behaviorId
        {
            get => (int)row["behaviorId"].Value;
            set => row["behaviorId"].Value = value;
        }

        // Unknown.
        public float changeHpRate
        {
            get => (float)row["changeHpRate"].Value;
            set => row["changeHpRate"].Value = value;
        }

        // Unknown.
        public int changeHpPoint
        {
            get => (int)row["changeHpPoint"].Value;
            set => row["changeHpPoint"].Value = value;
        }

        // Unknown.
        public float changeMpRate
        {
            get => (float)row["changeMpRate"].Value;
            set => row["changeMpRate"].Value = value;
        }

        // Unknown.
        public int changeMpPoint
        {
            get => (int)row["changeMpPoint"].Value;
            set => row["changeMpPoint"].Value = value;
        }

        // Unknown.
        public int mpRecoverChangeSpeed
        {
            get => (int)row["mpRecoverChangeSpeed"].Value;
            set => row["mpRecoverChangeSpeed"].Value = value;
        }

        // Unknown.
        public float changeStaminaRate
        {
            get => (float)row["changeStaminaRate"].Value;
            set => row["changeStaminaRate"].Value = value;
        }

        // Unknown.
        public int changeStaminaPoint
        {
            get => (int)row["changeStaminaPoint"].Value;
            set => row["changeStaminaPoint"].Value = value;
        }

        // Unknown.
        public int staminaRecoverChangeSpeed
        {
            get => (int)row["staminaRecoverChangeSpeed"].Value;
            set => row["staminaRecoverChangeSpeed"].Value = value;
        }

        // Unknown.
        public float magicEffectTimeChange
        {
            get => (float)row["magicEffectTimeChange"].Value;
            set => row["magicEffectTimeChange"].Value = value;
        }

        // Unknown.
        public int insideDurability
        {
            get => (int)row["insideDurability"].Value;
            set => row["insideDurability"].Value = value;
        }

        // Unknown.
        public int maxDurability
        {
            get => (int)row["maxDurability"].Value;
            set => row["maxDurability"].Value = value;
        }

        // Unknown.
        public float staminaAttackRate
        {
            get => (float)row["staminaAttackRate"].Value;
            set => row["staminaAttackRate"].Value = value;
        }

        // Unknown.
        public int poizonAttackPower
        {
            get => (int)row["poizonAttackPower"].Value;
            set => row["poizonAttackPower"].Value = value;
        }

        // Unknown.
        public int diseaseAttackPower
        {
            get => (int)row["diseaseAttackPower"].Value;
            set => row["diseaseAttackPower"].Value = value;
        }

        // Unknown.
        public int bloodAttackPower
        {
            get => (int)row["bloodAttackPower"].Value;
            set => row["bloodAttackPower"].Value = value;
        }

        // Unknown.
        public int curseAttackPower
        {
            get => (int)row["curseAttackPower"].Value;
            set => row["curseAttackPower"].Value = value;
        }

        // Unknown.
        public float fallDamageRate
        {
            get => (float)row["fallDamageRate"].Value;
            set => row["fallDamageRate"].Value = value;
        }

        // Unknown.
        public float soulRate
        {
            get => (float)row["soulRate"].Value;
            set => row["soulRate"].Value = value;
        }

        // Unknown.
        public float equipWeightChangeRate
        {
            get => (float)row["equipWeightChangeRate"].Value;
            set => row["equipWeightChangeRate"].Value = value;
        }

        // Unknown.
        public float allItemWeightChangeRate
        {
            get => (float)row["allItemWeightChangeRate"].Value;
            set => row["allItemWeightChangeRate"].Value = value;
        }

        // Unknown.
        public int soul
        {
            get => (int)row["soul"].Value;
            set => row["soul"].Value = value;
        }

        // Unknown.
        public int animIdOffset
        {
            get => (int)row["animIdOffset"].Value;
            set => row["animIdOffset"].Value = value;
        }

        // Unknown.
        public float haveSoulRate
        {
            get => (float)row["haveSoulRate"].Value;
            set => row["haveSoulRate"].Value = value;
        }

        // Unknown.
        public float targetPriority
        {
            get => (float)row["targetPriority"].Value;
            set => row["targetPriority"].Value = value;
        }

        // Unknown.
        public float sightSearchEnemyRate
        {
            get => (float)row["sightSearchEnemyRate"].Value;
            set => row["sightSearchEnemyRate"].Value = value;
        }

        // Unknown.
        public float hearingSearchEnemyRate
        {
            get => (float)row["hearingSearchEnemyRate"].Value;
            set => row["hearingSearchEnemyRate"].Value = value;
        }

        // Unknown.
        public float grabityRate
        {
            get => (float)row["grabityRate"].Value;
            set => row["grabityRate"].Value = value;
        }

        // Unknown.
        public float registPoizonChangeRate
        {
            get => (float)row["registPoizonChangeRate"].Value;
            set => row["registPoizonChangeRate"].Value = value;
        }

        // Unknown.
        public float registDiseaseChangeRate
        {
            get => (float)row["registDiseaseChangeRate"].Value;
            set => row["registDiseaseChangeRate"].Value = value;
        }

        // Unknown.
        public float registBloodChangeRate
        {
            get => (float)row["registBloodChangeRate"].Value;
            set => row["registBloodChangeRate"].Value = value;
        }

        // Unknown.
        public float registCurseChangeRate
        {
            get => (float)row["registCurseChangeRate"].Value;
            set => row["registCurseChangeRate"].Value = value;
        }

        // Unknown.
        public float soulStealRate
        {
            get => (float)row["soulStealRate"].Value;
            set => row["soulStealRate"].Value = value;
        }

        public float lifeReductionRate
        {
            get => (float)row["lifeReductionRate"].Value;
            set => row["lifeReductionRate"].Value = value;
        }

        // Unknown.
        public float hpRecoverRate
        {
            get => (float)row["hpRecoverRate"].Value;
            set => row["hpRecoverRate"].Value = value;
        }

        // Unknown.
        public int replaceSpEffectId
        {
            get => (int)row["replaceSpEffectId"].Value;
            set => row["replaceSpEffectId"].Value = value;
        }

        // Unknown.
        public int cycleOccurrenceSpEffectId
        {
            get => (int)row["cycleOccurrenceSpEffectId"].Value;
            set => row["cycleOccurrenceSpEffectId"].Value = value;
        }

        // Unknown.
        public int atkOccurrenceSpEffectId
        {
            get => (int)row["atkOccurrenceSpEffectId"].Value;
            set => row["atkOccurrenceSpEffectId"].Value = value;
        }

        // Unknown.
        public float guardDefFlickPowerRate
        {
            get => (float)row["guardDefFlickPowerRate"].Value;
            set => row["guardDefFlickPowerRate"].Value = value;
        }

        // Unknown.
        public float guardStaminaCutRate
        {
            get => (float)row["guardStaminaCutRate"].Value;
            set => row["guardStaminaCutRate"].Value = value;
        }

        // Unknown.
        public short rayCastPassedTime
        {
            get => (short)row["rayCastPassedTime"].Value;
            set => row["rayCastPassedTime"].Value = value;
        }

        // Unknown.
        public byte magicSubCategoryChange1
        {
            get => (byte)row["magicSubCategoryChange1"].Value;
            set => row["magicSubCategoryChange1"].Value = value;
        }

        // Unknown.
        public byte magicSubCategoryChange2
        {
            get => (byte)row["magicSubCategoryChange2"].Value;
            set => row["magicSubCategoryChange2"].Value = value;
        }

        // Unknown.
        public short bowDistRate
        {
            get => (short)row["bowDistRate"].Value;
            set => row["bowDistRate"].Value = value;
        }

        // Unknown.
        public ushort spCategory
        {
            get => (ushort)row["spCategory"].Value;
            set => row["spCategory"].Value = value;
        }

        // Unknown.
        public byte categoryPriority
        {
            get => (byte)row["categoryPriority"].Value;
            set => row["categoryPriority"].Value = value;
        }

        // Unknown.
        public sbyte saveCategory
        {
            get => (sbyte)row["saveCategory"].Value;
            set => row["saveCategory"].Value = value;
        }

        // Unknown.
        public byte changeMagicSlot
        {
            get => (byte)row["changeMagicSlot"].Value;
            set => row["changeMagicSlot"].Value = value;
        }

        // Unknown.
        public byte changeMiracleSlot
        {
            get => (byte)row["changeMiracleSlot"].Value;
            set => row["changeMiracleSlot"].Value = value;
        }

        // Unknown.
        public sbyte heroPointDamage
        {
            get => (sbyte)row["heroPointDamage"].Value;
            set => row["heroPointDamage"].Value = value;
        }

        // Unknown.
        public byte defFlickPower
        {
            get => (byte)row["defFlickPower"].Value;
            set => row["defFlickPower"].Value = value;
        }

        // Unknown.
        public byte flickDamageCutRate
        {
            get => (byte)row["flickDamageCutRate"].Value;
            set => row["flickDamageCutRate"].Value = value;
        }

        // Unknown.
        public byte bloodDamageRate
        {
            get => (byte)row["bloodDamageRate"].Value;
            set => row["bloodDamageRate"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_None
        {
            get => (sbyte)row["dmgLv_None"].Value;
            set => row["dmgLv_None"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_S
        {
            get => (sbyte)row["dmgLv_S"].Value;
            set => row["dmgLv_S"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_M
        {
            get => (sbyte)row["dmgLv_M"].Value;
            set => row["dmgLv_M"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_L
        {
            get => (sbyte)row["dmgLv_L"].Value;
            set => row["dmgLv_L"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_BlowM
        {
            get => (sbyte)row["dmgLv_BlowM"].Value;
            set => row["dmgLv_BlowM"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_Push
        {
            get => (sbyte)row["dmgLv_Push"].Value;
            set => row["dmgLv_Push"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_Strike
        {
            get => (sbyte)row["dmgLv_Strike"].Value;
            set => row["dmgLv_Strike"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_BlowS
        {
            get => (sbyte)row["dmgLv_BlowS"].Value;
            set => row["dmgLv_BlowS"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_Min
        {
            get => (sbyte)row["dmgLv_Min"].Value;
            set => row["dmgLv_Min"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_Uppercut
        {
            get => (sbyte)row["dmgLv_Uppercut"].Value;
            set => row["dmgLv_Uppercut"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_BlowLL
        {
            get => (sbyte)row["dmgLv_BlowLL"].Value;
            set => row["dmgLv_BlowLL"].Value = value;
        }

        // Unknown.
        public sbyte dmgLv_Breath
        {
            get => (sbyte)row["dmgLv_Breath"].Value;
            set => row["dmgLv_Breath"].Value = value;
        }

        // Unknown.
        public byte atkAttribute
        {
            get => (byte)row["atkAttribute"].Value;
            set => row["atkAttribute"].Value = value;
        }

        // Unknown.
        public byte spAttribute
        {
            get => (byte)row["spAttribute"].Value;
            set => row["spAttribute"].Value = value;
        }

        // Unknown.
        public ushort stateInfo
        {
            get => (ushort)row["stateInfo"].Value;
            set => row["stateInfo"].Value = value;
        }

        // Unknown.
        public byte wepParamChange
        {
            get => (byte)row["wepParamChange"].Value;
            set => row["wepParamChange"].Value = value;
        }

        // Unknown.
        public byte moveType
        {
            get => (byte)row["moveType"].Value;
            set => row["moveType"].Value = value;
        }

        public ushort lifeReductionType
        {
            get => (ushort)row["lifeReductionType"].Value;
            set => row["lifeReductionType"].Value = value;
        }

        // Unknown.
        public byte throwCondition
        {
            get => (byte)row["throwCondition"].Value;
            set => row["throwCondition"].Value = value;
        }

        // Unknown.
        public sbyte addBehaviorJudgeId_condition
        {
            get => (sbyte)row["addBehaviorJudgeId_condition"].Value;
            set => row["addBehaviorJudgeId_condition"].Value = value;
        }

        // Unknown.
        public byte freezeDamageRate
        {
            get => (byte)row["freezeDamageRate"].Value;
            set => row["freezeDamageRate"].Value = value;
        }

        // Unknown.
        public byte effectTargetSelf
        {
            get => (byte)row["effectTargetSelf"].Value;
            set => row["effectTargetSelf"].Value = value;
        }

        // Unknown.
        public byte effectTargetFriend
        {
            get => (byte)row["effectTargetFriend"].Value;
            set => row["effectTargetFriend"].Value = value;
        }

        // Unknown.
        public byte effectTargetEnemy
        {
            get => (byte)row["effectTargetEnemy"].Value;
            set => row["effectTargetEnemy"].Value = value;
        }

        // Unknown.
        public byte effectTargetPlayer
        {
            get => (byte)row["effectTargetPlayer"].Value;
            set => row["effectTargetPlayer"].Value = value;
        }

        // Unknown.
        public byte effectTargetAI
        {
            get => (byte)row["effectTargetAI"].Value;
            set => row["effectTargetAI"].Value = value;
        }

        // Unknown.
        public byte effectTargetLive
        {
            get => (byte)row["effectTargetLive"].Value;
            set => row["effectTargetLive"].Value = value;
        }

        // Unknown.
        public byte effectTargetGhost
        {
            get => (byte)row["effectTargetGhost"].Value;
            set => row["effectTargetGhost"].Value = value;
        }

        // Unknown.
        public byte disableSleep
        {
            get => (byte)row["disableSleep"].Value;
            set => row["disableSleep"].Value = value;
        }

        // Unknown.
        public byte disableMadness
        {
            get => (byte)row["disableMadness"].Value;
            set => row["disableMadness"].Value = value;
        }

        // Unknown.
        public byte effectTargetAttacker
        {
            get => (byte)row["effectTargetAttacker"].Value;
            set => row["effectTargetAttacker"].Value = value;
        }

        // Unknown.
        public byte dispIconNonactive
        {
            get => (byte)row["dispIconNonactive"].Value;
            set => row["dispIconNonactive"].Value = value;
        }

        // Unknown.
        public byte regainGaugeDamage
        {
            get => (byte)row["regainGaugeDamage"].Value;
            set => row["regainGaugeDamage"].Value = value;
        }

        // Unknown.
        public byte bAdjustMagicAblity
        {
            get => (byte)row["bAdjustMagicAblity"].Value;
            set => row["bAdjustMagicAblity"].Value = value;
        }

        // Unknown.
        public byte bAdjustFaithAblity
        {
            get => (byte)row["bAdjustFaithAblity"].Value;
            set => row["bAdjustFaithAblity"].Value = value;
        }

        // Unknown.
        public byte bGameClearBonus
        {
            get => (byte)row["bGameClearBonus"].Value;
            set => row["bGameClearBonus"].Value = value;
        }

        // Unknown.
        public byte magParamChange
        {
            get => (byte)row["magParamChange"].Value;
            set => row["magParamChange"].Value = value;
        }

        // Unknown.
        public byte miracleParamChange
        {
            get => (byte)row["miracleParamChange"].Value;
            set => row["miracleParamChange"].Value = value;
        }

        // Unknown.
        public byte clearSoul
        {
            get => (byte)row["clearSoul"].Value;
            set => row["clearSoul"].Value = value;
        }

        // Unknown.
        public byte requestSOS
        {
            get => (byte)row["requestSOS"].Value;
            set => row["requestSOS"].Value = value;
        }

        // Unknown.
        public byte requestBlackSOS
        {
            get => (byte)row["requestBlackSOS"].Value;
            set => row["requestBlackSOS"].Value = value;
        }

        // Unknown.
        public byte requestForceJoinBlackSOS
        {
            get => (byte)row["requestForceJoinBlackSOS"].Value;
            set => row["requestForceJoinBlackSOS"].Value = value;
        }

        // Unknown.
        public byte requestKickSession
        {
            get => (byte)row["requestKickSession"].Value;
            set => row["requestKickSession"].Value = value;
        }

        // Unknown.
        public byte requestLeaveSession
        {
            get => (byte)row["requestLeaveSession"].Value;
            set => row["requestLeaveSession"].Value = value;
        }

        // Unknown.
        public byte requestNpcInveda
        {
            get => (byte)row["requestNpcInveda"].Value;
            set => row["requestNpcInveda"].Value = value;
        }

        // Unknown.
        public byte noDead
        {
            get => (byte)row["noDead"].Value;
            set => row["noDead"].Value = value;
        }

        // Unknown.
        public byte bCurrHPIndependeMaxHP
        {
            get => (byte)row["bCurrHPIndependeMaxHP"].Value;
            set => row["bCurrHPIndependeMaxHP"].Value = value;
        }

        // Unknown.
        public byte corrosionIgnore
        {
            get => (byte)row["corrosionIgnore"].Value;
            set => row["corrosionIgnore"].Value = value;
        }

        // Unknown.
        public byte sightSearchCutIgnore
        {
            get => (byte)row["sightSearchCutIgnore"].Value;
            set => row["sightSearchCutIgnore"].Value = value;
        }

        // Unknown.
        public byte hearingSearchCutIgnore
        {
            get => (byte)row["hearingSearchCutIgnore"].Value;
            set => row["hearingSearchCutIgnore"].Value = value;
        }

        // Unknown.
        public byte antiMagicIgnore
        {
            get => (byte)row["antiMagicIgnore"].Value;
            set => row["antiMagicIgnore"].Value = value;
        }

        // Unknown.
        public byte fakeTargetIgnore
        {
            get => (byte)row["fakeTargetIgnore"].Value;
            set => row["fakeTargetIgnore"].Value = value;
        }

        // Unknown.
        public byte fakeTargetIgnoreUndead
        {
            get => (byte)row["fakeTargetIgnoreUndead"].Value;
            set => row["fakeTargetIgnoreUndead"].Value = value;
        }

        // Unknown.
        public byte fakeTargetIgnoreAnimal
        {
            get => (byte)row["fakeTargetIgnoreAnimal"].Value;
            set => row["fakeTargetIgnoreAnimal"].Value = value;
        }

        // Unknown.
        public byte grabityIgnore
        {
            get => (byte)row["grabityIgnore"].Value;
            set => row["grabityIgnore"].Value = value;
        }

        // Unknown.
        public byte disablePoison
        {
            get => (byte)row["disablePoison"].Value;
            set => row["disablePoison"].Value = value;
        }

        // Unknown.
        public byte disableDisease
        {
            get => (byte)row["disableDisease"].Value;
            set => row["disableDisease"].Value = value;
        }

        // Unknown.
        public byte disableBlood
        {
            get => (byte)row["disableBlood"].Value;
            set => row["disableBlood"].Value = value;
        }

        // Unknown.
        public byte disableCurse
        {
            get => (byte)row["disableCurse"].Value;
            set => row["disableCurse"].Value = value;
        }

        // Unknown.
        public byte enableCharm
        {
            get => (byte)row["enableCharm"].Value;
            set => row["enableCharm"].Value = value;
        }

        // Unknown.
        public byte enableLifeTime
        {
            get => (byte)row["enableLifeTime"].Value;
            set => row["enableLifeTime"].Value = value;
        }

        // Unknown.
        public byte bAdjustStrengthAblity
        {
            get => (byte)row["bAdjustStrengthAblity"].Value;
            set => row["bAdjustStrengthAblity"].Value = value;
        }

        // Unknown.
        public byte bAdjustAgilityAblity
        {
            get => (byte)row["bAdjustAgilityAblity"].Value;
            set => row["bAdjustAgilityAblity"].Value = value;
        }

        // Unknown.
        public byte eraseOnBonfireRecover
        {
            get => (byte)row["eraseOnBonfireRecover"].Value;
            set => row["eraseOnBonfireRecover"].Value = value;
        }

        // Unknown.
        public byte throwAttackParamChange
        {
            get => (byte)row["throwAttackParamChange"].Value;
            set => row["throwAttackParamChange"].Value = value;
        }

        // Unknown.
        public byte requestLeaveColiseumSession
        {
            get => (byte)row["requestLeaveColiseumSession"].Value;
            set => row["requestLeaveColiseumSession"].Value = value;
        }

        // Unknown.
        public byte isExtendSpEffectLife
        {
            get => (byte)row["isExtendSpEffectLife"].Value;
            set => row["isExtendSpEffectLife"].Value = value;
        }

        // Unknown.
        public byte hasTarget
        {
            get => (byte)row["hasTarget"].Value;
            set => row["hasTarget"].Value = value;
        }

        // Unknown.
        public byte replanningOnFire
        {
            get => (byte)row["replanningOnFire"].Value;
            set => row["replanningOnFire"].Value = value;
        }

        // Unknown.
        public byte vowType0
        {
            get => (byte)row["vowType0"].Value;
            set => row["vowType0"].Value = value;
        }

        // Unknown.
        public byte vowType1
        {
            get => (byte)row["vowType1"].Value;
            set => row["vowType1"].Value = value;
        }

        // Unknown.
        public byte vowType2
        {
            get => (byte)row["vowType2"].Value;
            set => row["vowType2"].Value = value;
        }

        // Unknown.
        public byte vowType3
        {
            get => (byte)row["vowType3"].Value;
            set => row["vowType3"].Value = value;
        }

        // Unknown.
        public byte vowType4
        {
            get => (byte)row["vowType4"].Value;
            set => row["vowType4"].Value = value;
        }

        // Unknown.
        public byte vowType5
        {
            get => (byte)row["vowType5"].Value;
            set => row["vowType5"].Value = value;
        }

        // Unknown.
        public byte vowType6
        {
            get => (byte)row["vowType6"].Value;
            set => row["vowType6"].Value = value;
        }

        // Unknown.
        public byte vowType7
        {
            get => (byte)row["vowType7"].Value;
            set => row["vowType7"].Value = value;
        }

        // Unknown.
        public byte vowType8
        {
            get => (byte)row["vowType8"].Value;
            set => row["vowType8"].Value = value;
        }

        // Unknown.
        public byte vowType9
        {
            get => (byte)row["vowType9"].Value;
            set => row["vowType9"].Value = value;
        }

        // Unknown.
        public byte vowType10
        {
            get => (byte)row["vowType10"].Value;
            set => row["vowType10"].Value = value;
        }

        // Unknown.
        public byte vowType11
        {
            get => (byte)row["vowType11"].Value;
            set => row["vowType11"].Value = value;
        }

        // Unknown.
        public byte vowType12
        {
            get => (byte)row["vowType12"].Value;
            set => row["vowType12"].Value = value;
        }

        // Unknown.
        public byte vowType13
        {
            get => (byte)row["vowType13"].Value;
            set => row["vowType13"].Value = value;
        }

        // Unknown.
        public byte vowType14
        {
            get => (byte)row["vowType14"].Value;
            set => row["vowType14"].Value = value;
        }

        // Unknown.
        public byte vowType15
        {
            get => (byte)row["vowType15"].Value;
            set => row["vowType15"].Value = value;
        }

        // Unknown.
        public sbyte repAtkDmgLv
        {
            get => (sbyte)row["repAtkDmgLv"].Value;
            set => row["repAtkDmgLv"].Value = value;
        }

        // Unknown.
        public float sightSearchRate
        {
            get => (float)row["sightSearchRate"].Value;
            set => row["sightSearchRate"].Value = value;
        }

        // Unknown.
        public byte effectTargetOpposeTarget
        {
            get => (byte)row["effectTargetOpposeTarget"].Value;
            set => row["effectTargetOpposeTarget"].Value = value;
        }

        // Unknown.
        public byte effectTargetFriendlyTarget
        {
            get => (byte)row["effectTargetFriendlyTarget"].Value;
            set => row["effectTargetFriendlyTarget"].Value = value;
        }

        // Unknown.
        public byte effectTargetSelfTarget
        {
            get => (byte)row["effectTargetSelfTarget"].Value;
            set => row["effectTargetSelfTarget"].Value = value;
        }

        // Unknown.
        public byte effectTargetPcHorse
        {
            get => (byte)row["effectTargetPcHorse"].Value;
            set => row["effectTargetPcHorse"].Value = value;
        }

        // Unknown.
        public byte effectTargetPcDeceased
        {
            get => (byte)row["effectTargetPcDeceased"].Value;
            set => row["effectTargetPcDeceased"].Value = value;
        }

        // Unknown.
        public byte isContractSpEffectLife
        {
            get => (byte)row["isContractSpEffectLife"].Value;
            set => row["isContractSpEffectLife"].Value = value;
        }

        // Unknown.
        public byte isWaitModeDelete
        {
            get => (byte)row["isWaitModeDelete"].Value;
            set => row["isWaitModeDelete"].Value = value;
        }

        // Unknown.
        public byte isIgnoreNoDamage
        {
            get => (byte)row["isIgnoreNoDamage"].Value;
            set => row["isIgnoreNoDamage"].Value = value;
        }

        // Unknown.
        public sbyte changeTeamType
        {
            get => (sbyte)row["changeTeamType"].Value;
            set => row["changeTeamType"].Value = value;
        }

        // Unknown.
        public short dmypolyId
        {
            get => (short)row["dmypolyId"].Value;
            set => row["dmypolyId"].Value = value;
        }

        // Unknown.
        public int vfxId
        {
            get => (int)row["vfxId"].Value;
            set => row["vfxId"].Value = value;
        }

        // Unknown.
        public int accumuOverFireId
        {
            get => (int)row["accumuOverFireId"].Value;
            set => row["accumuOverFireId"].Value = value;
        }

        // Unknown.
        public int accumuOverVal
        {
            get => (int)row["accumuOverVal"].Value;
            set => row["accumuOverVal"].Value = value;
        }

        // Unknown.
        public int accumuUnderFireId
        {
            get => (int)row["accumuUnderFireId"].Value;
            set => row["accumuUnderFireId"].Value = value;
        }

        // Unknown.
        public int accumuUnderVal
        {
            get => (int)row["accumuUnderVal"].Value;
            set => row["accumuUnderVal"].Value = value;
        }

        // Unknown.
        public int accumuVal
        {
            get => (int)row["accumuVal"].Value;
            set => row["accumuVal"].Value = value;
        }

        // Unknown.
        public byte eye_angX
        {
            get => (byte)row["eye_angX"].Value;
            set => row["eye_angX"].Value = value;
        }

        // Unknown.
        public byte eye_angY
        {
            get => (byte)row["eye_angY"].Value;
            set => row["eye_angY"].Value = value;
        }

        // Unknown.
        public short addDeceasedLv
        {
            get => (short)row["addDeceasedLv"].Value;
            set => row["addDeceasedLv"].Value = value;
        }

        // Unknown.
        public int vfxId1
        {
            get => (int)row["vfxId1"].Value;
            set => row["vfxId1"].Value = value;
        }

        // Unknown.
        public int vfxId2
        {
            get => (int)row["vfxId2"].Value;
            set => row["vfxId2"].Value = value;
        }

        // Unknown.
        public int vfxId3
        {
            get => (int)row["vfxId3"].Value;
            set => row["vfxId3"].Value = value;
        }

        // Unknown.
        public int vfxId4
        {
            get => (int)row["vfxId4"].Value;
            set => row["vfxId4"].Value = value;
        }

        // Unknown.
        public int vfxId5
        {
            get => (int)row["vfxId5"].Value;
            set => row["vfxId5"].Value = value;
        }

        // Unknown.
        public int vfxId6
        {
            get => (int)row["vfxId6"].Value;
            set => row["vfxId6"].Value = value;
        }

        // Unknown.
        public int vfxId7
        {
            get => (int)row["vfxId7"].Value;
            set => row["vfxId7"].Value = value;
        }

        // Unknown.
        public int freezeAttackPower
        {
            get => (int)row["freezeAttackPower"].Value;
            set => row["freezeAttackPower"].Value = value;
        }

        // Unknown.
        public int AppearAiSoundId
        {
            get => (int)row["AppearAiSoundId"].Value;
            set => row["AppearAiSoundId"].Value = value;
        }

        // Unknown.
        public short addFootEffectSfxId
        {
            get => (short)row["addFootEffectSfxId"].Value;
            set => row["addFootEffectSfxId"].Value = value;
        }

        // Unknown.
        public sbyte dexterityCancelSystemOnlyAddDexterity
        {
            get => (sbyte)row["dexterityCancelSystemOnlyAddDexterity"].Value;
            set => row["dexterityCancelSystemOnlyAddDexterity"].Value = value;
        }

        // Unknown.
        public sbyte teamOffenseEffectivity
        {
            get => (sbyte)row["teamOffenseEffectivity"].Value;
            set => row["teamOffenseEffectivity"].Value = value;
        }

        // Unknown.
        public float toughnessDamageCutRate
        {
            get => (float)row["toughnessDamageCutRate"].Value;
            set => row["toughnessDamageCutRate"].Value = value;
        }

        // Unknown.
        public float weakDmgRateA
        {
            get => (float)row["weakDmgRateA"].Value;
            set => row["weakDmgRateA"].Value = value;
        }

        // Unknown.
        public float weakDmgRateB
        {
            get => (float)row["weakDmgRateB"].Value;
            set => row["weakDmgRateB"].Value = value;
        }

        // Unknown.
        public float weakDmgRateC
        {
            get => (float)row["weakDmgRateC"].Value;
            set => row["weakDmgRateC"].Value = value;
        }

        // Unknown.
        public float weakDmgRateD
        {
            get => (float)row["weakDmgRateD"].Value;
            set => row["weakDmgRateD"].Value = value;
        }

        // Unknown.
        public float weakDmgRateE
        {
            get => (float)row["weakDmgRateE"].Value;
            set => row["weakDmgRateE"].Value = value;
        }

        // Unknown.
        public float weakDmgRateF
        {
            get => (float)row["weakDmgRateF"].Value;
            set => row["weakDmgRateF"].Value = value;
        }

        // Unknown.
        public float darkDamageCutRate
        {
            get => (float)row["darkDamageCutRate"].Value;
            set => row["darkDamageCutRate"].Value = value;
        }

        // Unknown.
        public float darkDiffenceRate
        {
            get => (float)row["darkDiffenceRate"].Value;
            set => row["darkDiffenceRate"].Value = value;
        }

        // Unknown.
        public int darkDiffence
        {
            get => (int)row["darkDiffence"].Value;
            set => row["darkDiffence"].Value = value;
        }

        // Unknown.
        public float darkAttackRate
        {
            get => (float)row["darkAttackRate"].Value;
            set => row["darkAttackRate"].Value = value;
        }

        // Unknown.
        public float darkAttackPowerRate
        {
            get => (float)row["darkAttackPowerRate"].Value;
            set => row["darkAttackPowerRate"].Value = value;
        }

        // Unknown.
        public int darkAttackPower
        {
            get => (int)row["darkAttackPower"].Value;
            set => row["darkAttackPower"].Value = value;
        }

        // Unknown.
        public float antiDarkSightRadius
        {
            get => (float)row["antiDarkSightRadius"].Value;
            set => row["antiDarkSightRadius"].Value = value;
        }

        // Unknown.
        public int antiDarkSightDmypolyId
        {
            get => (int)row["antiDarkSightDmypolyId"].Value;
            set => row["antiDarkSightDmypolyId"].Value = value;
        }

        // Unknown.
        public float conditionHpRate
        {
            get => (float)row["conditionHpRate"].Value;
            set => row["conditionHpRate"].Value = value;
        }

        // Unknown.
        public float consumeStaminaRate
        {
            get => (float)row["consumeStaminaRate"].Value;
            set => row["consumeStaminaRate"].Value = value;
        }

        // Unknown.
        public float itemDropRate
        {
            get => (float)row["itemDropRate"].Value;
            set => row["itemDropRate"].Value = value;
        }

        // Unknown.
        public int changePoisonResistPoint
        {
            get => (int)row["changePoisonResistPoint"].Value;
            set => row["changePoisonResistPoint"].Value = value;
        }

        // Unknown.
        public int changeDiseaseResistPoint
        {
            get => (int)row["changeDiseaseResistPoint"].Value;
            set => row["changeDiseaseResistPoint"].Value = value;
        }

        // Unknown.
        public int changeBloodResistPoint
        {
            get => (int)row["changeBloodResistPoint"].Value;
            set => row["changeBloodResistPoint"].Value = value;
        }

        // Unknown.
        public int changeCurseResistPoint
        {
            get => (int)row["changeCurseResistPoint"].Value;
            set => row["changeCurseResistPoint"].Value = value;
        }

        // Unknown.
        public int changeFreezeResistPoint
        {
            get => (int)row["changeFreezeResistPoint"].Value;
            set => row["changeFreezeResistPoint"].Value = value;
        }

        // Unknown.
        public float slashAttackRate
        {
            get => (float)row["slashAttackRate"].Value;
            set => row["slashAttackRate"].Value = value;
        }

        // Unknown.
        public float blowAttackRate
        {
            get => (float)row["blowAttackRate"].Value;
            set => row["blowAttackRate"].Value = value;
        }

        // Unknown.
        public float thrustAttackRate
        {
            get => (float)row["thrustAttackRate"].Value;
            set => row["thrustAttackRate"].Value = value;
        }

        // Unknown.
        public float neutralAttackRate
        {
            get => (float)row["neutralAttackRate"].Value;
            set => row["neutralAttackRate"].Value = value;
        }

        // Unknown.
        public float slashAttackPowerRate
        {
            get => (float)row["slashAttackPowerRate"].Value;
            set => row["slashAttackPowerRate"].Value = value;
        }

        // Unknown.
        public float blowAttackPowerRate
        {
            get => (float)row["blowAttackPowerRate"].Value;
            set => row["blowAttackPowerRate"].Value = value;
        }

        // Unknown.
        public float thrustAttackPowerRate
        {
            get => (float)row["thrustAttackPowerRate"].Value;
            set => row["thrustAttackPowerRate"].Value = value;
        }

        // Unknown.
        public float neutralAttackPowerRate
        {
            get => (float)row["neutralAttackPowerRate"].Value;
            set => row["neutralAttackPowerRate"].Value = value;
        }

        // Unknown.
        public int slashAttackPower
        {
            get => (int)row["slashAttackPower"].Value;
            set => row["slashAttackPower"].Value = value;
        }

        // Unknown.
        public int blowAttackPower
        {
            get => (int)row["blowAttackPower"].Value;
            set => row["blowAttackPower"].Value = value;
        }

        // Unknown.
        public int thrustAttackPower
        {
            get => (int)row["thrustAttackPower"].Value;
            set => row["thrustAttackPower"].Value = value;
        }

        // Unknown.
        public int neutralAttackPower
        {
            get => (int)row["neutralAttackPower"].Value;
            set => row["neutralAttackPower"].Value = value;
        }

        // Unknown.
        public int changeStrengthPoint
        {
            get => (int)row["changeStrengthPoint"].Value;
            set => row["changeStrengthPoint"].Value = value;
        }

        // Unknown.
        public int changeAgilityPoint
        {
            get => (int)row["changeAgilityPoint"].Value;
            set => row["changeAgilityPoint"].Value = value;
        }

        // Unknown.
        public int changeMagicPoint
        {
            get => (int)row["changeMagicPoint"].Value;
            set => row["changeMagicPoint"].Value = value;
        }

        // Unknown.
        public int changeFaithPoint
        {
            get => (int)row["changeFaithPoint"].Value;
            set => row["changeFaithPoint"].Value = value;
        }

        // Unknown.
        public int changeLuckPoint
        {
            get => (int)row["changeLuckPoint"].Value;
            set => row["changeLuckPoint"].Value = value;
        }

        // Unknown.
        public sbyte recoverArtsPoint_Str
        {
            get => (sbyte)row["recoverArtsPoint_Str"].Value;
            set => row["recoverArtsPoint_Str"].Value = value;
        }

        // Unknown.
        public sbyte recoverArtsPoint_Dex
        {
            get => (sbyte)row["recoverArtsPoint_Dex"].Value;
            set => row["recoverArtsPoint_Dex"].Value = value;
        }

        // Unknown.
        public sbyte recoverArtsPoint_Magic
        {
            get => (sbyte)row["recoverArtsPoint_Magic"].Value;
            set => row["recoverArtsPoint_Magic"].Value = value;
        }

        // Unknown.
        public sbyte recoverArtsPoint_Miracle
        {
            get => (sbyte)row["recoverArtsPoint_Miracle"].Value;
            set => row["recoverArtsPoint_Miracle"].Value = value;
        }

        // Unknown.
        public byte madnessDamageRate
        {
            get => (byte)row["madnessDamageRate"].Value;
            set => row["madnessDamageRate"].Value = value;
        }

        // Unknown.
        public byte isUseStatusAilmentAtkPowerCorrect
        {
            get => (byte)row["isUseStatusAilmentAtkPowerCorrect"].Value;
            set => row["isUseStatusAilmentAtkPowerCorrect"].Value = value;
        }

        // Unknown.
        public byte isUseAtkParamAtkPowerCorrect
        {
            get => (byte)row["isUseAtkParamAtkPowerCorrect"].Value;
            set => row["isUseAtkParamAtkPowerCorrect"].Value = value;
        }

        // Unknown.
        public byte dontDeleteOnDead
        {
            get => (byte)row["dontDeleteOnDead"].Value;
            set => row["dontDeleteOnDead"].Value = value;
        }

        // Unknown.
        public byte disableFreeze
        {
            get => (byte)row["disableFreeze"].Value;
            set => row["disableFreeze"].Value = value;
        }

        // Unknown.
        public byte isDisableNetSync
        {
            get => (byte)row["isDisableNetSync"].Value;
            set => row["isDisableNetSync"].Value = value;
        }

        // Unknown.
        public byte shamanParamChange
        {
            get => (byte)row["shamanParamChange"].Value;
            set => row["shamanParamChange"].Value = value;
        }

        // Unknown.
        public byte isStopSearchedNotify
        {
            get => (byte)row["isStopSearchedNotify"].Value;
            set => row["isStopSearchedNotify"].Value = value;
        }

        // Unknown.
        public byte isCheckAboveShadowTest
        {
            get => (byte)row["isCheckAboveShadowTest"].Value;
            set => row["isCheckAboveShadowTest"].Value = value;
        }

        // Unknown.
        public ushort addBehaviorJudgeId_add
        {
            get => (ushort)row["addBehaviorJudgeId_add"].Value;
            set => row["addBehaviorJudgeId_add"].Value = value;
        }

        // Unknown.
        public float saReceiveDamageRate
        {
            get => (float)row["saReceiveDamageRate"].Value;
            set => row["saReceiveDamageRate"].Value = value;
        }

        // Unknown.
        public float defPlayerDmgCorrectRate_Physics
        {
            get => (float)row["defPlayerDmgCorrectRate_Physics"].Value;
            set => row["defPlayerDmgCorrectRate_Physics"].Value = value;
        }

        // Unknown.
        public float defPlayerDmgCorrectRate_Magic
        {
            get => (float)row["defPlayerDmgCorrectRate_Magic"].Value;
            set => row["defPlayerDmgCorrectRate_Magic"].Value = value;
        }

        // Unknown.
        public float defPlayerDmgCorrectRate_Fire
        {
            get => (float)row["defPlayerDmgCorrectRate_Fire"].Value;
            set => row["defPlayerDmgCorrectRate_Fire"].Value = value;
        }

        // Unknown.
        public float defPlayerDmgCorrectRate_Thunder
        {
            get => (float)row["defPlayerDmgCorrectRate_Thunder"].Value;
            set => row["defPlayerDmgCorrectRate_Thunder"].Value = value;
        }

        // Unknown.
        public float defPlayerDmgCorrectRate_Dark
        {
            get => (float)row["defPlayerDmgCorrectRate_Dark"].Value;
            set => row["defPlayerDmgCorrectRate_Dark"].Value = value;
        }

        // Unknown.
        public float defEnemyDmgCorrectRate_Physics
        {
            get => (float)row["defEnemyDmgCorrectRate_Physics"].Value;
            set => row["defEnemyDmgCorrectRate_Physics"].Value = value;
        }

        // Unknown.
        public float defEnemyDmgCorrectRate_Magic
        {
            get => (float)row["defEnemyDmgCorrectRate_Magic"].Value;
            set => row["defEnemyDmgCorrectRate_Magic"].Value = value;
        }

        // Unknown.
        public float defEnemyDmgCorrectRate_Fire
        {
            get => (float)row["defEnemyDmgCorrectRate_Fire"].Value;
            set => row["defEnemyDmgCorrectRate_Fire"].Value = value;
        }

        // Unknown.
        public float defEnemyDmgCorrectRate_Thunder
        {
            get => (float)row["defEnemyDmgCorrectRate_Thunder"].Value;
            set => row["defEnemyDmgCorrectRate_Thunder"].Value = value;
        }

        // Unknown.
        public float defEnemyDmgCorrectRate_Dark
        {
            get => (float)row["defEnemyDmgCorrectRate_Dark"].Value;
            set => row["defEnemyDmgCorrectRate_Dark"].Value = value;
        }

        // Unknown.
        public float defObjDmgCorrectRate
        {
            get => (float)row["defObjDmgCorrectRate"].Value;
            set => row["defObjDmgCorrectRate"].Value = value;
        }

        // Unknown.
        public float atkPlayerDmgCorrectRate_Physics
        {
            get => (float)row["atkPlayerDmgCorrectRate_Physics"].Value;
            set => row["atkPlayerDmgCorrectRate_Physics"].Value = value;
        }

        // Unknown.
        public float atkPlayerDmgCorrectRate_Magic
        {
            get => (float)row["atkPlayerDmgCorrectRate_Magic"].Value;
            set => row["atkPlayerDmgCorrectRate_Magic"].Value = value;
        }

        // Unknown.
        public float atkPlayerDmgCorrectRate_Fire
        {
            get => (float)row["atkPlayerDmgCorrectRate_Fire"].Value;
            set => row["atkPlayerDmgCorrectRate_Fire"].Value = value;
        }

        // Unknown.
        public float atkPlayerDmgCorrectRate_Thunder
        {
            get => (float)row["atkPlayerDmgCorrectRate_Thunder"].Value;
            set => row["atkPlayerDmgCorrectRate_Thunder"].Value = value;
        }

        // Unknown.
        public float atkPlayerDmgCorrectRate_Dark
        {
            get => (float)row["atkPlayerDmgCorrectRate_Dark"].Value;
            set => row["atkPlayerDmgCorrectRate_Dark"].Value = value;
        }

        // Unknown.
        public float atkEnemyDmgCorrectRate_Physics
        {
            get => (float)row["atkEnemyDmgCorrectRate_Physics"].Value;
            set => row["atkEnemyDmgCorrectRate_Physics"].Value = value;
        }

        // Unknown.
        public float atkEnemyDmgCorrectRate_Magic
        {
            get => (float)row["atkEnemyDmgCorrectRate_Magic"].Value;
            set => row["atkEnemyDmgCorrectRate_Magic"].Value = value;
        }

        // Unknown.
        public float atkEnemyDmgCorrectRate_Fire
        {
            get => (float)row["atkEnemyDmgCorrectRate_Fire"].Value;
            set => row["atkEnemyDmgCorrectRate_Fire"].Value = value;
        }

        // Unknown.
        public float atkEnemyDmgCorrectRate_Thunder
        {
            get => (float)row["atkEnemyDmgCorrectRate_Thunder"].Value;
            set => row["atkEnemyDmgCorrectRate_Thunder"].Value = value;
        }

        // Unknown.
        public float atkEnemyDmgCorrectRate_Dark
        {
            get => (float)row["atkEnemyDmgCorrectRate_Dark"].Value;
            set => row["atkEnemyDmgCorrectRate_Dark"].Value = value;
        }

        // Unknown.
        public float registFreezeChangeRate
        {
            get => (float)row["registFreezeChangeRate"].Value;
            set => row["registFreezeChangeRate"].Value = value;
        }

        // Unknown.
        public ushort invocationConditionsStateChange1
        {
            get => (ushort)row["invocationConditionsStateChange1"].Value;
            set => row["invocationConditionsStateChange1"].Value = value;
        }

        // Unknown.
        public ushort invocationConditionsStateChange2
        {
            get => (ushort)row["invocationConditionsStateChange2"].Value;
            set => row["invocationConditionsStateChange2"].Value = value;
        }

        // Unknown.
        public ushort invocationConditionsStateChange3
        {
            get => (ushort)row["invocationConditionsStateChange3"].Value;
            set => row["invocationConditionsStateChange3"].Value = value;
        }

        // Unknown.
        public short hearingAiSoundLevel
        {
            get => (short)row["hearingAiSoundLevel"].Value;
            set => row["hearingAiSoundLevel"].Value = value;
        }

        // Unknown.
        public float chrProxyHeightRate
        {
            get => (float)row["chrProxyHeightRate"].Value;
            set => row["chrProxyHeightRate"].Value = value;
        }

        // Unknown.
        public float addAwarePointCorrectValue_forMe
        {
            get => (float)row["addAwarePointCorrectValue_forMe"].Value;
            set => row["addAwarePointCorrectValue_forMe"].Value = value;
        }

        // Unknown.
        public float addAwarePointCorrectValue_forTarget
        {
            get => (float)row["addAwarePointCorrectValue_forTarget"].Value;
            set => row["addAwarePointCorrectValue_forTarget"].Value = value;
        }

        // Unknown.
        public float sightSearchEnemyAdd
        {
            get => (float)row["sightSearchEnemyAdd"].Value;
            set => row["sightSearchEnemyAdd"].Value = value;
        }

        // Unknown.
        public float sightSearchAdd
        {
            get => (float)row["sightSearchAdd"].Value;
            set => row["sightSearchAdd"].Value = value;
        }

        // Unknown.
        public float hearingSearchAdd
        {
            get => (float)row["hearingSearchAdd"].Value;
            set => row["hearingSearchAdd"].Value = value;
        }

        // Unknown.
        public float hearingSearchRate
        {
            get => (float)row["hearingSearchRate"].Value;
            set => row["hearingSearchRate"].Value = value;
        }

        // Unknown.
        public float hearingSearchEnemyAdd
        {
            get => (float)row["hearingSearchEnemyAdd"].Value;
            set => row["hearingSearchEnemyAdd"].Value = value;
        }

        // Unknown.
        public float value_Magnification
        {
            get => (float)row["value_Magnification"].Value;
            set => row["value_Magnification"].Value = value;
        }

        // Unknown.
        public float artsConsumptionRate
        {
            get => (float)row["artsConsumptionRate"].Value;
            set => row["artsConsumptionRate"].Value = value;
        }

        // Unknown.
        public float magicConsumptionRate
        {
            get => (float)row["magicConsumptionRate"].Value;
            set => row["magicConsumptionRate"].Value = value;
        }

        // Unknown.
        public float shamanConsumptionRate
        {
            get => (float)row["shamanConsumptionRate"].Value;
            set => row["shamanConsumptionRate"].Value = value;
        }

        // Unknown.
        public float miracleConsumptionRate
        {
            get => (float)row["miracleConsumptionRate"].Value;
            set => row["miracleConsumptionRate"].Value = value;
        }

        // Unknown.
        public int changeHpEstusFlaskRate
        {
            get => (int)row["changeHpEstusFlaskRate"].Value;
            set => row["changeHpEstusFlaskRate"].Value = value;
        }

        // Unknown.
        public int changeHpEstusFlaskPoint
        {
            get => (int)row["changeHpEstusFlaskPoint"].Value;
            set => row["changeHpEstusFlaskPoint"].Value = value;
        }

        // Unknown.
        public int changeMpEstusFlaskRate
        {
            get => (int)row["changeMpEstusFlaskRate"].Value;
            set => row["changeMpEstusFlaskRate"].Value = value;
        }

        // Unknown.
        public int changeMpEstusFlaskPoint
        {
            get => (int)row["changeMpEstusFlaskPoint"].Value;
            set => row["changeMpEstusFlaskPoint"].Value = value;
        }

        // Unknown.
        public float changeHpEstusFlaskCorrectRate
        {
            get => (float)row["changeHpEstusFlaskCorrectRate"].Value;
            set => row["changeHpEstusFlaskCorrectRate"].Value = value;
        }

        // Unknown.
        public float changeMpEstusFlaskCorrectRate
        {
            get => (float)row["changeMpEstusFlaskCorrectRate"].Value;
            set => row["changeMpEstusFlaskCorrectRate"].Value = value;
        }

        // Unknown.
        public int applyIdOnGetSoul
        {
            get => (int)row["applyIdOnGetSoul"].Value;
            set => row["applyIdOnGetSoul"].Value = value;
        }

        // Unknown.
        public float extendLifeRate
        {
            get => (float)row["extendLifeRate"].Value;
            set => row["extendLifeRate"].Value = value;
        }

        // Unknown.
        public float contractLifeRate
        {
            get => (float)row["contractLifeRate"].Value;
            set => row["contractLifeRate"].Value = value;
        }

        // Unknown.
        public float defObjectAttackPowerRate
        {
            get => (float)row["defObjectAttackPowerRate"].Value;
            set => row["defObjectAttackPowerRate"].Value = value;
        }

        // Unknown.
        public short effectEndDeleteDecalGroupId
        {
            get => (short)row["effectEndDeleteDecalGroupId"].Value;
            set => row["effectEndDeleteDecalGroupId"].Value = value;
        }

        // Unknown.
        public sbyte addLifeForceStatus
        {
            get => (sbyte)row["addLifeForceStatus"].Value;
            set => row["addLifeForceStatus"].Value = value;
        }

        // Unknown.
        public sbyte addWillpowerStatus
        {
            get => (sbyte)row["addWillpowerStatus"].Value;
            set => row["addWillpowerStatus"].Value = value;
        }

        // Unknown.
        public sbyte addEndureStatus
        {
            get => (sbyte)row["addEndureStatus"].Value;
            set => row["addEndureStatus"].Value = value;
        }

        // Unknown.
        public sbyte addVitalityStatus
        {
            get => (sbyte)row["addVitalityStatus"].Value;
            set => row["addVitalityStatus"].Value = value;
        }

        // Unknown.
        public sbyte addStrengthStatus
        {
            get => (sbyte)row["addStrengthStatus"].Value;
            set => row["addStrengthStatus"].Value = value;
        }

        // Unknown.
        public sbyte addDexterityStatus
        {
            get => (sbyte)row["addDexterityStatus"].Value;
            set => row["addDexterityStatus"].Value = value;
        }

        // Unknown.
        public sbyte addMagicStatus
        {
            get => (sbyte)row["addMagicStatus"].Value;
            set => row["addMagicStatus"].Value = value;
        }

        // Unknown.
        public sbyte addFaithStatus
        {
            get => (sbyte)row["addFaithStatus"].Value;
            set => row["addFaithStatus"].Value = value;
        }

        // Unknown.
        public sbyte addLuckStatus
        {
            get => (sbyte)row["addLuckStatus"].Value;
            set => row["addLuckStatus"].Value = value;
        }

        // Unknown.
        public byte deleteCriteriaDamage
        {
            get => (byte)row["deleteCriteriaDamage"].Value;
            set => row["deleteCriteriaDamage"].Value = value;
        }

        // Unknown.
        public byte magicSubCategoryChange3
        {
            get => (byte)row["magicSubCategoryChange3"].Value;
            set => row["magicSubCategoryChange3"].Value = value;
        }

        // Unknown.
        public byte spAttributeVariationValue
        {
            get => (byte)row["spAttributeVariationValue"].Value;
            set => row["spAttributeVariationValue"].Value = value;
        }

        // Unknown.
        public byte atkFlickPower
        {
            get => (byte)row["atkFlickPower"].Value;
            set => row["atkFlickPower"].Value = value;
        }

        // Unknown.
        public byte wetConditionDepth
        {
            get => (byte)row["wetConditionDepth"].Value;
            set => row["wetConditionDepth"].Value = value;
        }

        // Unknown.
        public float changeSaRecoveryVelocity
        {
            get => (float)row["changeSaRecoveryVelocity"].Value;
            set => row["changeSaRecoveryVelocity"].Value = value;
        }

        // Unknown.
        public float regainRate
        {
            get => (float)row["regainRate"].Value;
            set => row["regainRate"].Value = value;
        }

        // Unknown.
        public float saAttackPowerRate
        {
            get => (float)row["saAttackPowerRate"].Value;
            set => row["saAttackPowerRate"].Value = value;
        }

        // Unknown.
        public int sleepAttackPower
        {
            get => (int)row["sleepAttackPower"].Value;
            set => row["sleepAttackPower"].Value = value;
        }

        // Unknown.
        public int madnessAttackPower
        {
            get => (int)row["madnessAttackPower"].Value;
            set => row["madnessAttackPower"].Value = value;
        }

        // Unknown.
        public float registSleepChangeRate
        {
            get => (float)row["registSleepChangeRate"].Value;
            set => row["registSleepChangeRate"].Value = value;
        }

        // Unknown.
        public float registMadnessChangeRate
        {
            get => (float)row["registMadnessChangeRate"].Value;
            set => row["registMadnessChangeRate"].Value = value;
        }

        // Unknown.
        public int changeSleepResistPoint
        {
            get => (int)row["changeSleepResistPoint"].Value;
            set => row["changeSleepResistPoint"].Value = value;
        }

        // Unknown.
        public int changeMadnessResistPoint
        {
            get => (int)row["changeMadnessResistPoint"].Value;
            set => row["changeMadnessResistPoint"].Value = value;
        }

        // Unknown.
        public byte sleepDamageRate
        {
            get => (byte)row["sleepDamageRate"].Value;
            set => row["sleepDamageRate"].Value = value;
        }

        // Unknown.
        public byte applyPartsGroup
        {
            get => (byte)row["applyPartsGroup"].Value;
            set => row["applyPartsGroup"].Value = value;
        }

        // Unknown.
        public byte clearTarget
        {
            get => (byte)row["clearTarget"].Value;
            set => row["clearTarget"].Value = value;
        }

        // Unknown.
        public byte fakeTargetIgnoreAjin
        {
            get => (byte)row["fakeTargetIgnoreAjin"].Value;
            set => row["fakeTargetIgnoreAjin"].Value = value;
        }

        // Unknown.
        public byte fakeTargetIgnoreMirageArts
        {
            get => (byte)row["fakeTargetIgnoreMirageArts"].Value;
            set => row["fakeTargetIgnoreMirageArts"].Value = value;
        }

        // Unknown.
        public byte requestForceJoinBlackSOS_B
        {
            get => (byte)row["requestForceJoinBlackSOS_B"].Value;
            set => row["requestForceJoinBlackSOS_B"].Value = value;
        }

        public byte unk353_4
        {
            get => (byte)row["unk353_4"].Value;
            set => row["unk353_4"].Value = value;
        }

        // Unknown.
        public float changeSuperArmorPoint
        {
            get => (float)row["changeSuperArmorPoint"].Value;
            set => row["changeSuperArmorPoint"].Value = value;
        }

        // Unknown.
        public float changeSaPoint
        {
            get => (float)row["changeSaPoint"].Value;
            set => row["changeSaPoint"].Value = value;
        }

        // Unknown.
        public float hugeEnemyPickupHeightOverwrite
        {
            get => (float)row["hugeEnemyPickupHeightOverwrite"].Value;
            set => row["hugeEnemyPickupHeightOverwrite"].Value = value;
        }

        // Unknown.
        public float poisonDefDamageRate
        {
            get => (float)row["poisonDefDamageRate"].Value;
            set => row["poisonDefDamageRate"].Value = value;
        }

        // Unknown.
        public float diseaseDefDamageRate
        {
            get => (float)row["diseaseDefDamageRate"].Value;
            set => row["diseaseDefDamageRate"].Value = value;
        }

        // Unknown.
        public float bloodDefDamageRate
        {
            get => (float)row["bloodDefDamageRate"].Value;
            set => row["bloodDefDamageRate"].Value = value;
        }

        // Unknown.
        public float curseDefDamageRate
        {
            get => (float)row["curseDefDamageRate"].Value;
            set => row["curseDefDamageRate"].Value = value;
        }

        // Unknown.
        public float freezeDefDamageRate
        {
            get => (float)row["freezeDefDamageRate"].Value;
            set => row["freezeDefDamageRate"].Value = value;
        }

        // Unknown.
        public float sleepDefDamageRate
        {
            get => (float)row["sleepDefDamageRate"].Value;
            set => row["sleepDefDamageRate"].Value = value;
        }

        // Unknown.
        public float madnessDefDamageRate
        {
            get => (float)row["madnessDefDamageRate"].Value;
            set => row["madnessDefDamageRate"].Value = value;
        }

        // Unknown.
        public ushort overwrite_maxBackhomeDist
        {
            get => (ushort)row["overwrite_maxBackhomeDist"].Value;
            set => row["overwrite_maxBackhomeDist"].Value = value;
        }

        // Unknown.
        public ushort overwrite_backhomeDist
        {
            get => (ushort)row["overwrite_backhomeDist"].Value;
            set => row["overwrite_backhomeDist"].Value = value;
        }

        // Unknown.
        public ushort overwrite_backhomeBattleDist
        {
            get => (ushort)row["overwrite_backhomeBattleDist"].Value;
            set => row["overwrite_backhomeBattleDist"].Value = value;
        }

        // Unknown.
        public ushort overwrite_BackHome_LookTargetDist
        {
            get => (ushort)row["overwrite_BackHome_LookTargetDist"].Value;
            set => row["overwrite_BackHome_LookTargetDist"].Value = value;
        }

        // Unknown.
        public float goodsConsumptionRate
        {
            get => (float)row["goodsConsumptionRate"].Value;
            set => row["goodsConsumptionRate"].Value = value;
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
    public SP_EFFECT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SP_EFFECT_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
