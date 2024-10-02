using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class EQUIP_PARAM_WEAPON_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte disableParam_NT
        {
            get => (byte)row["disableParam_NT"].Value;
            set => row["disableParam_NT"].Value = value;
        }

        // Unknown.
        public int behaviorVariationId
        {
            get => (int)row["behaviorVariationId"].Value;
            set => row["behaviorVariationId"].Value = value;
        }

        // Unknown.
        public int sortId
        {
            get => (int)row["sortId"].Value;
            set => row["sortId"].Value = value;
        }

        // Unknown.
        public uint wanderingEquipId
        {
            get => (uint)row["wanderingEquipId"].Value;
            set => row["wanderingEquipId"].Value = value;
        }

        // Unknown.
        public float weight
        {
            get => (float)row["weight"].Value;
            set => row["weight"].Value = value;
        }

        // Unknown.
        public float weaponWeightRate
        {
            get => (float)row["weaponWeightRate"].Value;
            set => row["weaponWeightRate"].Value = value;
        }

        // Unknown.
        public int fixPrice
        {
            get => (int)row["fixPrice"].Value;
            set => row["fixPrice"].Value = value;
        }

        // Unknown.
        public int reinforcePrice
        {
            get => (int)row["reinforcePrice"].Value;
            set => row["reinforcePrice"].Value = value;
        }

        // Unknown.
        public int sellValue
        {
            get => (int)row["sellValue"].Value;
            set => row["sellValue"].Value = value;
        }

        // Unknown.
        public float correctStrength
        {
            get => (float)row["correctStrength"].Value;
            set => row["correctStrength"].Value = value;
        }

        // Unknown.
        public float correctAgility
        {
            get => (float)row["correctAgility"].Value;
            set => row["correctAgility"].Value = value;
        }

        // Unknown.
        public float correctMagic
        {
            get => (float)row["correctMagic"].Value;
            set => row["correctMagic"].Value = value;
        }

        // Unknown.
        public float correctFaith
        {
            get => (float)row["correctFaith"].Value;
            set => row["correctFaith"].Value = value;
        }

        // Unknown.
        public float physGuardCutRate
        {
            get => (float)row["physGuardCutRate"].Value;
            set => row["physGuardCutRate"].Value = value;
        }

        // Unknown.
        public float magGuardCutRate
        {
            get => (float)row["magGuardCutRate"].Value;
            set => row["magGuardCutRate"].Value = value;
        }

        // Unknown.
        public float fireGuardCutRate
        {
            get => (float)row["fireGuardCutRate"].Value;
            set => row["fireGuardCutRate"].Value = value;
        }

        // Unknown.
        public float thunGuardCutRate
        {
            get => (float)row["thunGuardCutRate"].Value;
            set => row["thunGuardCutRate"].Value = value;
        }

        // Unknown.
        public int spEffectBehaviorId0
        {
            get => (int)row["spEffectBehaviorId0"].Value;
            set => row["spEffectBehaviorId0"].Value = value;
        }

        // Unknown.
        public int spEffectBehaviorId1
        {
            get => (int)row["spEffectBehaviorId1"].Value;
            set => row["spEffectBehaviorId1"].Value = value;
        }

        // Unknown.
        public int spEffectBehaviorId2
        {
            get => (int)row["spEffectBehaviorId2"].Value;
            set => row["spEffectBehaviorId2"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId
        {
            get => (int)row["residentSpEffectId"].Value;
            set => row["residentSpEffectId"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId1
        {
            get => (int)row["residentSpEffectId1"].Value;
            set => row["residentSpEffectId1"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId2
        {
            get => (int)row["residentSpEffectId2"].Value;
            set => row["residentSpEffectId2"].Value = value;
        }

        // Unknown.
        public int materialSetId
        {
            get => (int)row["materialSetId"].Value;
            set => row["materialSetId"].Value = value;
        }

        // Unknown.
        public int originEquipWep
        {
            get => (int)row["originEquipWep"].Value;
            set => row["originEquipWep"].Value = value;
        }

        // Unknown.
        public int originEquipWep1
        {
            get => (int)row["originEquipWep1"].Value;
            set => row["originEquipWep1"].Value = value;
        }

        // Unknown.
        public int originEquipWep2
        {
            get => (int)row["originEquipWep2"].Value;
            set => row["originEquipWep2"].Value = value;
        }

        // Unknown.
        public int originEquipWep3
        {
            get => (int)row["originEquipWep3"].Value;
            set => row["originEquipWep3"].Value = value;
        }

        // Unknown.
        public int originEquipWep4
        {
            get => (int)row["originEquipWep4"].Value;
            set => row["originEquipWep4"].Value = value;
        }

        // Unknown.
        public int originEquipWep5
        {
            get => (int)row["originEquipWep5"].Value;
            set => row["originEquipWep5"].Value = value;
        }

        // Unknown.
        public int originEquipWep6
        {
            get => (int)row["originEquipWep6"].Value;
            set => row["originEquipWep6"].Value = value;
        }

        // Unknown.
        public int originEquipWep7
        {
            get => (int)row["originEquipWep7"].Value;
            set => row["originEquipWep7"].Value = value;
        }

        // Unknown.
        public int originEquipWep8
        {
            get => (int)row["originEquipWep8"].Value;
            set => row["originEquipWep8"].Value = value;
        }

        // Unknown.
        public int originEquipWep9
        {
            get => (int)row["originEquipWep9"].Value;
            set => row["originEquipWep9"].Value = value;
        }

        // Unknown.
        public int originEquipWep10
        {
            get => (int)row["originEquipWep10"].Value;
            set => row["originEquipWep10"].Value = value;
        }

        // Unknown.
        public int originEquipWep11
        {
            get => (int)row["originEquipWep11"].Value;
            set => row["originEquipWep11"].Value = value;
        }

        // Unknown.
        public int originEquipWep12
        {
            get => (int)row["originEquipWep12"].Value;
            set => row["originEquipWep12"].Value = value;
        }

        // Unknown.
        public int originEquipWep13
        {
            get => (int)row["originEquipWep13"].Value;
            set => row["originEquipWep13"].Value = value;
        }

        // Unknown.
        public int originEquipWep14
        {
            get => (int)row["originEquipWep14"].Value;
            set => row["originEquipWep14"].Value = value;
        }

        // Unknown.
        public int originEquipWep15
        {
            get => (int)row["originEquipWep15"].Value;
            set => row["originEquipWep15"].Value = value;
        }

        // Unknown.
        public float weakA_DamageRate
        {
            get => (float)row["weakA_DamageRate"].Value;
            set => row["weakA_DamageRate"].Value = value;
        }

        // Unknown.
        public float weakB_DamageRate
        {
            get => (float)row["weakB_DamageRate"].Value;
            set => row["weakB_DamageRate"].Value = value;
        }

        // Unknown.
        public float weakC_DamageRate
        {
            get => (float)row["weakC_DamageRate"].Value;
            set => row["weakC_DamageRate"].Value = value;
        }

        // Unknown.
        public float weakD_DamageRate
        {
            get => (float)row["weakD_DamageRate"].Value;
            set => row["weakD_DamageRate"].Value = value;
        }

        // Unknown.
        public float sleepGuardResist_MaxCorrect
        {
            get => (float)row["sleepGuardResist_MaxCorrect"].Value;
            set => row["sleepGuardResist_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float madnessGuardResist_MaxCorrect
        {
            get => (float)row["madnessGuardResist_MaxCorrect"].Value;
            set => row["madnessGuardResist_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float saWeaponDamage
        {
            get => (float)row["saWeaponDamage"].Value;
            set => row["saWeaponDamage"].Value = value;
        }

        // Unknown.
        public ushort equipModelId
        {
            get => (ushort)row["equipModelId"].Value;
            set => row["equipModelId"].Value = value;
        }

        // Unknown.
        public ushort iconId
        {
            get => (ushort)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public ushort durability
        {
            get => (ushort)row["durability"].Value;
            set => row["durability"].Value = value;
        }

        // Unknown.
        public ushort durabilityMax
        {
            get => (ushort)row["durabilityMax"].Value;
            set => row["durabilityMax"].Value = value;
        }

        // Unknown.
        public ushort attackThrowEscape
        {
            get => (ushort)row["attackThrowEscape"].Value;
            set => row["attackThrowEscape"].Value = value;
        }

        // Unknown.
        public short parryDamageLife
        {
            get => (short)row["parryDamageLife"].Value;
            set => row["parryDamageLife"].Value = value;
        }

        // Unknown.
        public ushort attackBasePhysics
        {
            get => (ushort)row["attackBasePhysics"].Value;
            set => row["attackBasePhysics"].Value = value;
        }

        // Unknown.
        public ushort attackBaseMagic
        {
            get => (ushort)row["attackBaseMagic"].Value;
            set => row["attackBaseMagic"].Value = value;
        }

        // Unknown.
        public ushort attackBaseFire
        {
            get => (ushort)row["attackBaseFire"].Value;
            set => row["attackBaseFire"].Value = value;
        }

        // Unknown.
        public ushort attackBaseThunder
        {
            get => (ushort)row["attackBaseThunder"].Value;
            set => row["attackBaseThunder"].Value = value;
        }

        // Unknown.
        public ushort attackBaseStamina
        {
            get => (ushort)row["attackBaseStamina"].Value;
            set => row["attackBaseStamina"].Value = value;
        }

        // Unknown.
        public short guardAngle
        {
            get => (short)row["guardAngle"].Value;
            set => row["guardAngle"].Value = value;
        }

        // Unknown.
        public float saDurability
        {
            get => (float)row["saDurability"].Value;
            set => row["saDurability"].Value = value;
        }

        // Unknown.
        public short staminaGuardDef
        {
            get => (short)row["staminaGuardDef"].Value;
            set => row["staminaGuardDef"].Value = value;
        }

        // Unknown.
        public short reinforceTypeId
        {
            get => (short)row["reinforceTypeId"].Value;
            set => row["reinforceTypeId"].Value = value;
        }

        // Unknown.
        public short trophySGradeId
        {
            get => (short)row["trophySGradeId"].Value;
            set => row["trophySGradeId"].Value = value;
        }

        // Unknown.
        public short trophySeqId
        {
            get => (short)row["trophySeqId"].Value;
            set => row["trophySeqId"].Value = value;
        }

        // Unknown.
        public short throwAtkRate
        {
            get => (short)row["throwAtkRate"].Value;
            set => row["throwAtkRate"].Value = value;
        }

        // Unknown.
        public short bowDistRate
        {
            get => (short)row["bowDistRate"].Value;
            set => row["bowDistRate"].Value = value;
        }

        // Unknown.
        public byte equipModelCategory
        {
            get => (byte)row["equipModelCategory"].Value;
            set => row["equipModelCategory"].Value = value;
        }

        // Unknown.
        public byte equipModelGender
        {
            get => (byte)row["equipModelGender"].Value;
            set => row["equipModelGender"].Value = value;
        }

        // Unknown.
        public byte weaponCategory
        {
            get => (byte)row["weaponCategory"].Value;
            set => row["weaponCategory"].Value = value;
        }

        // Unknown.
        public byte wepmotionCategory
        {
            get => (byte)row["wepmotionCategory"].Value;
            set => row["wepmotionCategory"].Value = value;
        }

        // Unknown.
        public byte guardmotionCategory
        {
            get => (byte)row["guardmotionCategory"].Value;
            set => row["guardmotionCategory"].Value = value;
        }

        // Unknown.
        public byte atkMaterial
        {
            get => (byte)row["atkMaterial"].Value;
            set => row["atkMaterial"].Value = value;
        }

        // Unknown.
        public ushort defSeMaterial1
        {
            get => (ushort)row["defSeMaterial1"].Value;
            set => row["defSeMaterial1"].Value = value;
        }

        // Unknown.
        public byte correctType_Physics
        {
            get => (byte)row["correctType_Physics"].Value;
            set => row["correctType_Physics"].Value = value;
        }

        // Unknown.
        public byte spAttribute
        {
            get => (byte)row["spAttribute"].Value;
            set => row["spAttribute"].Value = value;
        }

        // Unknown.
        public ushort spAtkcategory
        {
            get => (ushort)row["spAtkcategory"].Value;
            set => row["spAtkcategory"].Value = value;
        }

        // Unknown.
        public byte wepmotionOneHandId
        {
            get => (byte)row["wepmotionOneHandId"].Value;
            set => row["wepmotionOneHandId"].Value = value;
        }

        // Unknown.
        public byte wepmotionBothHandId
        {
            get => (byte)row["wepmotionBothHandId"].Value;
            set => row["wepmotionBothHandId"].Value = value;
        }

        // Unknown.
        public byte properStrength
        {
            get => (byte)row["properStrength"].Value;
            set => row["properStrength"].Value = value;
        }

        // Unknown.
        public byte properAgility
        {
            get => (byte)row["properAgility"].Value;
            set => row["properAgility"].Value = value;
        }

        // Unknown.
        public byte properMagic
        {
            get => (byte)row["properMagic"].Value;
            set => row["properMagic"].Value = value;
        }

        // Unknown.
        public byte properFaith
        {
            get => (byte)row["properFaith"].Value;
            set => row["properFaith"].Value = value;
        }

        // Unknown.
        public byte overStrength
        {
            get => (byte)row["overStrength"].Value;
            set => row["overStrength"].Value = value;
        }

        // Unknown.
        public byte attackBaseParry
        {
            get => (byte)row["attackBaseParry"].Value;
            set => row["attackBaseParry"].Value = value;
        }

        // Unknown.
        public byte defenseBaseParry
        {
            get => (byte)row["defenseBaseParry"].Value;
            set => row["defenseBaseParry"].Value = value;
        }

        // Unknown.
        public byte guardBaseRepel
        {
            get => (byte)row["guardBaseRepel"].Value;
            set => row["guardBaseRepel"].Value = value;
        }

        // Unknown.
        public byte attackBaseRepel
        {
            get => (byte)row["attackBaseRepel"].Value;
            set => row["attackBaseRepel"].Value = value;
        }

        // Unknown.
        public sbyte guardCutCancelRate
        {
            get => (sbyte)row["guardCutCancelRate"].Value;
            set => row["guardCutCancelRate"].Value = value;
        }

        // Unknown.
        public sbyte guardLevel
        {
            get => (sbyte)row["guardLevel"].Value;
            set => row["guardLevel"].Value = value;
        }

        // Unknown.
        public sbyte slashGuardCutRate
        {
            get => (sbyte)row["slashGuardCutRate"].Value;
            set => row["slashGuardCutRate"].Value = value;
        }

        // Unknown.
        public sbyte blowGuardCutRate
        {
            get => (sbyte)row["blowGuardCutRate"].Value;
            set => row["blowGuardCutRate"].Value = value;
        }

        // Unknown.
        public sbyte thrustGuardCutRate
        {
            get => (sbyte)row["thrustGuardCutRate"].Value;
            set => row["thrustGuardCutRate"].Value = value;
        }

        // Unknown.
        public sbyte poisonGuardResist
        {
            get => (sbyte)row["poisonGuardResist"].Value;
            set => row["poisonGuardResist"].Value = value;
        }

        // Unknown.
        public sbyte diseaseGuardResist
        {
            get => (sbyte)row["diseaseGuardResist"].Value;
            set => row["diseaseGuardResist"].Value = value;
        }

        // Unknown.
        public sbyte bloodGuardResist
        {
            get => (sbyte)row["bloodGuardResist"].Value;
            set => row["bloodGuardResist"].Value = value;
        }

        // Unknown.
        public sbyte curseGuardResist
        {
            get => (sbyte)row["curseGuardResist"].Value;
            set => row["curseGuardResist"].Value = value;
        }

        // Unknown.
        public byte atkAttribute
        {
            get => (byte)row["atkAttribute"].Value;
            set => row["atkAttribute"].Value = value;
        }

        // Unknown.
        public byte rightHandEquipable
        {
            get => (byte)row["rightHandEquipable"].Value;
            set => row["rightHandEquipable"].Value = value;
        }

        // Unknown.
        public byte leftHandEquipable
        {
            get => (byte)row["leftHandEquipable"].Value;
            set => row["leftHandEquipable"].Value = value;
        }

        // Unknown.
        public byte bothHandEquipable
        {
            get => (byte)row["bothHandEquipable"].Value;
            set => row["bothHandEquipable"].Value = value;
        }

        // Unknown.
        public byte arrowSlotEquipable
        {
            get => (byte)row["arrowSlotEquipable"].Value;
            set => row["arrowSlotEquipable"].Value = value;
        }

        // Unknown.
        public byte boltSlotEquipable
        {
            get => (byte)row["boltSlotEquipable"].Value;
            set => row["boltSlotEquipable"].Value = value;
        }

        // Unknown.
        public byte enableGuard
        {
            get => (byte)row["enableGuard"].Value;
            set => row["enableGuard"].Value = value;
        }

        // Unknown.
        public byte enableParry
        {
            get => (byte)row["enableParry"].Value;
            set => row["enableParry"].Value = value;
        }

        // Unknown.
        public byte enableMagic
        {
            get => (byte)row["enableMagic"].Value;
            set => row["enableMagic"].Value = value;
        }

        // Unknown.
        public byte enableSorcery
        {
            get => (byte)row["enableSorcery"].Value;
            set => row["enableSorcery"].Value = value;
        }

        // Unknown.
        public byte enableMiracle
        {
            get => (byte)row["enableMiracle"].Value;
            set => row["enableMiracle"].Value = value;
        }

        // Unknown.
        public byte enableVowMagic
        {
            get => (byte)row["enableVowMagic"].Value;
            set => row["enableVowMagic"].Value = value;
        }

        // Unknown.
        public byte isNormalAttackType
        {
            get => (byte)row["isNormalAttackType"].Value;
            set => row["isNormalAttackType"].Value = value;
        }

        // Unknown.
        public byte isBlowAttackType
        {
            get => (byte)row["isBlowAttackType"].Value;
            set => row["isBlowAttackType"].Value = value;
        }

        // Unknown.
        public byte isSlashAttackType
        {
            get => (byte)row["isSlashAttackType"].Value;
            set => row["isSlashAttackType"].Value = value;
        }

        // Unknown.
        public byte isThrustAttackType
        {
            get => (byte)row["isThrustAttackType"].Value;
            set => row["isThrustAttackType"].Value = value;
        }

        // Unknown.
        public byte isEnhance
        {
            get => (byte)row["isEnhance"].Value;
            set => row["isEnhance"].Value = value;
        }

        // Unknown.
        public byte isHeroPointCorrect
        {
            get => (byte)row["isHeroPointCorrect"].Value;
            set => row["isHeroPointCorrect"].Value = value;
        }

        // Unknown.
        public byte isCustom
        {
            get => (byte)row["isCustom"].Value;
            set => row["isCustom"].Value = value;
        }

        // Unknown.
        public byte disableBaseChangeReset
        {
            get => (byte)row["disableBaseChangeReset"].Value;
            set => row["disableBaseChangeReset"].Value = value;
        }

        // Unknown.
        public byte disableRepair
        {
            get => (byte)row["disableRepair"].Value;
            set => row["disableRepair"].Value = value;
        }

        // Unknown.
        public byte isDarkHand
        {
            get => (byte)row["isDarkHand"].Value;
            set => row["isDarkHand"].Value = value;
        }

        // Unknown.
        public byte simpleModelForDlc
        {
            get => (byte)row["simpleModelForDlc"].Value;
            set => row["simpleModelForDlc"].Value = value;
        }

        // Unknown.
        public byte lanternWep
        {
            get => (byte)row["lanternWep"].Value;
            set => row["lanternWep"].Value = value;
        }

        // Unknown.
        public byte isVersusGhostWep
        {
            get => (byte)row["isVersusGhostWep"].Value;
            set => row["isVersusGhostWep"].Value = value;
        }

        // Unknown.
        public byte baseChangeCategory
        {
            get => (byte)row["baseChangeCategory"].Value;
            set => row["baseChangeCategory"].Value = value;
        }

        // Unknown.
        public byte isDragonSlayer
        {
            get => (byte)row["isDragonSlayer"].Value;
            set => row["isDragonSlayer"].Value = value;
        }

        // Unknown.
        public byte isDeposit
        {
            get => (byte)row["isDeposit"].Value;
            set => row["isDeposit"].Value = value;
        }

        // Unknown.
        public byte disableMultiDropShare
        {
            get => (byte)row["disableMultiDropShare"].Value;
            set => row["disableMultiDropShare"].Value = value;
        }

        // Unknown.
        public byte isDiscard
        {
            get => (byte)row["isDiscard"].Value;
            set => row["isDiscard"].Value = value;
        }

        // Unknown.
        public byte isDrop
        {
            get => (byte)row["isDrop"].Value;
            set => row["isDrop"].Value = value;
        }

        // Unknown.
        public byte showLogCondType
        {
            get => (byte)row["showLogCondType"].Value;
            set => row["showLogCondType"].Value = value;
        }

        // Unknown.
        public byte enableThrow
        {
            get => (byte)row["enableThrow"].Value;
            set => row["enableThrow"].Value = value;
        }

        // Unknown.
        public byte showDialogCondType
        {
            get => (byte)row["showDialogCondType"].Value;
            set => row["showDialogCondType"].Value = value;
        }

        // Unknown.
        public byte disableGemAttr
        {
            get => (byte)row["disableGemAttr"].Value;
            set => row["disableGemAttr"].Value = value;
        }

        // Unknown.
        public ushort defSfxMaterial1
        {
            get => (ushort)row["defSfxMaterial1"].Value;
            set => row["defSfxMaterial1"].Value = value;
        }

        // Unknown.
        public byte wepCollidableType0
        {
            get => (byte)row["wepCollidableType0"].Value;
            set => row["wepCollidableType0"].Value = value;
        }

        // Unknown.
        public byte wepCollidableType1
        {
            get => (byte)row["wepCollidableType1"].Value;
            set => row["wepCollidableType1"].Value = value;
        }

        // Unknown.
        public byte postureControlId_Right
        {
            get => (byte)row["postureControlId_Right"].Value;
            set => row["postureControlId_Right"].Value = value;
        }

        // Unknown.
        public byte postureControlId_Left
        {
            get => (byte)row["postureControlId_Left"].Value;
            set => row["postureControlId_Left"].Value = value;
        }

        // Unknown.
        public int traceSfxId0
        {
            get => (int)row["traceSfxId0"].Value;
            set => row["traceSfxId0"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead0
        {
            get => (int)row["traceDmyIdHead0"].Value;
            set => row["traceDmyIdHead0"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail0
        {
            get => (int)row["traceDmyIdTail0"].Value;
            set => row["traceDmyIdTail0"].Value = value;
        }

        // Unknown.
        public int traceSfxId1
        {
            get => (int)row["traceSfxId1"].Value;
            set => row["traceSfxId1"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead1
        {
            get => (int)row["traceDmyIdHead1"].Value;
            set => row["traceDmyIdHead1"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail1
        {
            get => (int)row["traceDmyIdTail1"].Value;
            set => row["traceDmyIdTail1"].Value = value;
        }

        // Unknown.
        public int traceSfxId2
        {
            get => (int)row["traceSfxId2"].Value;
            set => row["traceSfxId2"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead2
        {
            get => (int)row["traceDmyIdHead2"].Value;
            set => row["traceDmyIdHead2"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail2
        {
            get => (int)row["traceDmyIdTail2"].Value;
            set => row["traceDmyIdTail2"].Value = value;
        }

        // Unknown.
        public int traceSfxId3
        {
            get => (int)row["traceSfxId3"].Value;
            set => row["traceSfxId3"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead3
        {
            get => (int)row["traceDmyIdHead3"].Value;
            set => row["traceDmyIdHead3"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail3
        {
            get => (int)row["traceDmyIdTail3"].Value;
            set => row["traceDmyIdTail3"].Value = value;
        }

        // Unknown.
        public int traceSfxId4
        {
            get => (int)row["traceSfxId4"].Value;
            set => row["traceSfxId4"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead4
        {
            get => (int)row["traceDmyIdHead4"].Value;
            set => row["traceDmyIdHead4"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail4
        {
            get => (int)row["traceDmyIdTail4"].Value;
            set => row["traceDmyIdTail4"].Value = value;
        }

        // Unknown.
        public int traceSfxId5
        {
            get => (int)row["traceSfxId5"].Value;
            set => row["traceSfxId5"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead5
        {
            get => (int)row["traceDmyIdHead5"].Value;
            set => row["traceDmyIdHead5"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail5
        {
            get => (int)row["traceDmyIdTail5"].Value;
            set => row["traceDmyIdTail5"].Value = value;
        }

        // Unknown.
        public int traceSfxId6
        {
            get => (int)row["traceSfxId6"].Value;
            set => row["traceSfxId6"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead6
        {
            get => (int)row["traceDmyIdHead6"].Value;
            set => row["traceDmyIdHead6"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail6
        {
            get => (int)row["traceDmyIdTail6"].Value;
            set => row["traceDmyIdTail6"].Value = value;
        }

        // Unknown.
        public int traceSfxId7
        {
            get => (int)row["traceSfxId7"].Value;
            set => row["traceSfxId7"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead7
        {
            get => (int)row["traceDmyIdHead7"].Value;
            set => row["traceDmyIdHead7"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail7
        {
            get => (int)row["traceDmyIdTail7"].Value;
            set => row["traceDmyIdTail7"].Value = value;
        }

        // Unknown.
        public ushort defSfxMaterial2
        {
            get => (ushort)row["defSfxMaterial2"].Value;
            set => row["defSfxMaterial2"].Value = value;
        }

        // Unknown.
        public ushort defSeMaterial2
        {
            get => (ushort)row["defSeMaterial2"].Value;
            set => row["defSeMaterial2"].Value = value;
        }

        // Unknown.
        public int absorpParamId
        {
            get => (int)row["absorpParamId"].Value;
            set => row["absorpParamId"].Value = value;
        }

        // Unknown.
        public float toughnessCorrectRate
        {
            get => (float)row["toughnessCorrectRate"].Value;
            set => row["toughnessCorrectRate"].Value = value;
        }

        // Unknown.
        public byte isValidTough_ProtSADmg
        {
            get => (byte)row["isValidTough_ProtSADmg"].Value;
            set => row["isValidTough_ProtSADmg"].Value = value;
        }

        // Unknown.
        public byte isDualBlade
        {
            get => (byte)row["isDualBlade"].Value;
            set => row["isDualBlade"].Value = value;
        }

        // Unknown.
        public byte isAutoEquip
        {
            get => (byte)row["isAutoEquip"].Value;
            set => row["isAutoEquip"].Value = value;
        }

        // Unknown.
        public byte isEnableEmergencyStep
        {
            get => (byte)row["isEnableEmergencyStep"].Value;
            set => row["isEnableEmergencyStep"].Value = value;
        }

        // Unknown.
        public byte invisibleOnRemo
        {
            get => (byte)row["invisibleOnRemo"].Value;
            set => row["invisibleOnRemo"].Value = value;
        }

        // Unknown.
        public byte correctType_Magic
        {
            get => (byte)row["correctType_Magic"].Value;
            set => row["correctType_Magic"].Value = value;
        }

        // Unknown.
        public byte correctType_Fire
        {
            get => (byte)row["correctType_Fire"].Value;
            set => row["correctType_Fire"].Value = value;
        }

        // Unknown.
        public byte correctType_Thunder
        {
            get => (byte)row["correctType_Thunder"].Value;
            set => row["correctType_Thunder"].Value = value;
        }

        // Unknown.
        public float weakE_DamageRate
        {
            get => (float)row["weakE_DamageRate"].Value;
            set => row["weakE_DamageRate"].Value = value;
        }

        // Unknown.
        public float weakF_DamageRate
        {
            get => (float)row["weakF_DamageRate"].Value;
            set => row["weakF_DamageRate"].Value = value;
        }

        // Unknown.
        public float darkGuardCutRate
        {
            get => (float)row["darkGuardCutRate"].Value;
            set => row["darkGuardCutRate"].Value = value;
        }

        // Unknown.
        public ushort attackBaseDark
        {
            get => (ushort)row["attackBaseDark"].Value;
            set => row["attackBaseDark"].Value = value;
        }

        // Unknown.
        public byte correctType_Dark
        {
            get => (byte)row["correctType_Dark"].Value;
            set => row["correctType_Dark"].Value = value;
        }

        // Unknown.
        public byte correctType_Poison
        {
            get => (byte)row["correctType_Poison"].Value;
            set => row["correctType_Poison"].Value = value;
        }

        // Unknown.
        public byte sortGroupId
        {
            get => (byte)row["sortGroupId"].Value;
            set => row["sortGroupId"].Value = value;
        }

        // Unknown.
        public byte atkAttribute2
        {
            get => (byte)row["atkAttribute2"].Value;
            set => row["atkAttribute2"].Value = value;
        }

        // Unknown.
        public sbyte sleepGuardResist
        {
            get => (sbyte)row["sleepGuardResist"].Value;
            set => row["sleepGuardResist"].Value = value;
        }

        // Unknown.
        public sbyte madnessGuardResist
        {
            get => (sbyte)row["madnessGuardResist"].Value;
            set => row["madnessGuardResist"].Value = value;
        }

        // Unknown.
        public byte correctType_Blood
        {
            get => (byte)row["correctType_Blood"].Value;
            set => row["correctType_Blood"].Value = value;
        }

        // Unknown.
        public byte properLuck
        {
            get => (byte)row["properLuck"].Value;
            set => row["properLuck"].Value = value;
        }

        // Unknown.
        public sbyte freezeGuardResist
        {
            get => (sbyte)row["freezeGuardResist"].Value;
            set => row["freezeGuardResist"].Value = value;
        }

        // Unknown.
        public byte autoReplenishType
        {
            get => (byte)row["autoReplenishType"].Value;
            set => row["autoReplenishType"].Value = value;
        }

        // Unknown.
        public int swordArtsParamId
        {
            get => (int)row["swordArtsParamId"].Value;
            set => row["swordArtsParamId"].Value = value;
        }

        // Unknown.
        public float correctLuck
        {
            get => (float)row["correctLuck"].Value;
            set => row["correctLuck"].Value = value;
        }

        // Unknown.
        public uint arrowBoltEquipId
        {
            get => (uint)row["arrowBoltEquipId"].Value;
            set => row["arrowBoltEquipId"].Value = value;
        }

        // Unknown.
        public byte DerivationLevelType
        {
            get => (byte)row["DerivationLevelType"].Value;
            set => row["DerivationLevelType"].Value = value;
        }

        // Unknown.
        public byte enchantSfxSize
        {
            get => (byte)row["enchantSfxSize"].Value;
            set => row["enchantSfxSize"].Value = value;
        }

        // Unknown.
        public ushort wepType
        {
            get => (ushort)row["wepType"].Value;
            set => row["wepType"].Value = value;
        }

        // Unknown.
        public float physGuardCutRate_MaxCorrect
        {
            get => (float)row["physGuardCutRate_MaxCorrect"].Value;
            set => row["physGuardCutRate_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float magGuardCutRate_MaxCorrect
        {
            get => (float)row["magGuardCutRate_MaxCorrect"].Value;
            set => row["magGuardCutRate_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float fireGuardCutRate_MaxCorrect
        {
            get => (float)row["fireGuardCutRate_MaxCorrect"].Value;
            set => row["fireGuardCutRate_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float thunGuardCutRate_MaxCorrect
        {
            get => (float)row["thunGuardCutRate_MaxCorrect"].Value;
            set => row["thunGuardCutRate_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float darkGuardCutRate_MaxCorrect
        {
            get => (float)row["darkGuardCutRate_MaxCorrect"].Value;
            set => row["darkGuardCutRate_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float poisonGuardResist_MaxCorrect
        {
            get => (float)row["poisonGuardResist_MaxCorrect"].Value;
            set => row["poisonGuardResist_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float diseaseGuardResist_MaxCorrect
        {
            get => (float)row["diseaseGuardResist_MaxCorrect"].Value;
            set => row["diseaseGuardResist_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float bloodGuardResist_MaxCorrect
        {
            get => (float)row["bloodGuardResist_MaxCorrect"].Value;
            set => row["bloodGuardResist_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float curseGuardResist_MaxCorrect
        {
            get => (float)row["curseGuardResist_MaxCorrect"].Value;
            set => row["curseGuardResist_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float freezeGuardResist_MaxCorrect
        {
            get => (float)row["freezeGuardResist_MaxCorrect"].Value;
            set => row["freezeGuardResist_MaxCorrect"].Value = value;
        }

        // Unknown.
        public float staminaGuardDef_MaxCorrect
        {
            get => (float)row["staminaGuardDef_MaxCorrect"].Value;
            set => row["staminaGuardDef_MaxCorrect"].Value = value;
        }

        // Unknown.
        public int residentSfxId_1
        {
            get => (int)row["residentSfxId_1"].Value;
            set => row["residentSfxId_1"].Value = value;
        }

        // Unknown.
        public int residentSfxId_2
        {
            get => (int)row["residentSfxId_2"].Value;
            set => row["residentSfxId_2"].Value = value;
        }

        // Unknown.
        public int residentSfxId_3
        {
            get => (int)row["residentSfxId_3"].Value;
            set => row["residentSfxId_3"].Value = value;
        }

        // Unknown.
        public int residentSfxId_4
        {
            get => (int)row["residentSfxId_4"].Value;
            set => row["residentSfxId_4"].Value = value;
        }

        // Unknown.
        public int residentSfx_DmyId_1
        {
            get => (int)row["residentSfx_DmyId_1"].Value;
            set => row["residentSfx_DmyId_1"].Value = value;
        }

        // Unknown.
        public int residentSfx_DmyId_2
        {
            get => (int)row["residentSfx_DmyId_2"].Value;
            set => row["residentSfx_DmyId_2"].Value = value;
        }

        // Unknown.
        public int residentSfx_DmyId_3
        {
            get => (int)row["residentSfx_DmyId_3"].Value;
            set => row["residentSfx_DmyId_3"].Value = value;
        }

        // Unknown.
        public int residentSfx_DmyId_4
        {
            get => (int)row["residentSfx_DmyId_4"].Value;
            set => row["residentSfx_DmyId_4"].Value = value;
        }

        // Unknown.
        public float staminaConsumptionRate
        {
            get => (float)row["staminaConsumptionRate"].Value;
            set => row["staminaConsumptionRate"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Physics
        {
            get => (float)row["vsPlayerDmgCorrectRate_Physics"].Value;
            set => row["vsPlayerDmgCorrectRate_Physics"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Magic
        {
            get => (float)row["vsPlayerDmgCorrectRate_Magic"].Value;
            set => row["vsPlayerDmgCorrectRate_Magic"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Fire
        {
            get => (float)row["vsPlayerDmgCorrectRate_Fire"].Value;
            set => row["vsPlayerDmgCorrectRate_Fire"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Thunder
        {
            get => (float)row["vsPlayerDmgCorrectRate_Thunder"].Value;
            set => row["vsPlayerDmgCorrectRate_Thunder"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Dark
        {
            get => (float)row["vsPlayerDmgCorrectRate_Dark"].Value;
            set => row["vsPlayerDmgCorrectRate_Dark"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Poison
        {
            get => (float)row["vsPlayerDmgCorrectRate_Poison"].Value;
            set => row["vsPlayerDmgCorrectRate_Poison"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Blood
        {
            get => (float)row["vsPlayerDmgCorrectRate_Blood"].Value;
            set => row["vsPlayerDmgCorrectRate_Blood"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Freeze
        {
            get => (float)row["vsPlayerDmgCorrectRate_Freeze"].Value;
            set => row["vsPlayerDmgCorrectRate_Freeze"].Value = value;
        }

        // Unknown.
        public int attainmentWepStatusStr
        {
            get => (int)row["attainmentWepStatusStr"].Value;
            set => row["attainmentWepStatusStr"].Value = value;
        }

        // Unknown.
        public int attainmentWepStatusDex
        {
            get => (int)row["attainmentWepStatusDex"].Value;
            set => row["attainmentWepStatusDex"].Value = value;
        }

        // Unknown.
        public int attainmentWepStatusMag
        {
            get => (int)row["attainmentWepStatusMag"].Value;
            set => row["attainmentWepStatusMag"].Value = value;
        }

        // Unknown.
        public int attainmentWepStatusFai
        {
            get => (int)row["attainmentWepStatusFai"].Value;
            set => row["attainmentWepStatusFai"].Value = value;
        }

        // Unknown.
        public int attainmentWepStatusLuc
        {
            get => (int)row["attainmentWepStatusLuc"].Value;
            set => row["attainmentWepStatusLuc"].Value = value;
        }

        // Unknown.
        public int attackElementCorrectId
        {
            get => (int)row["attackElementCorrectId"].Value;
            set => row["attackElementCorrectId"].Value = value;
        }

        // Unknown.
        public int saleValue
        {
            get => (int)row["saleValue"].Value;
            set => row["saleValue"].Value = value;
        }

        // Unknown.
        public byte reinforceShopCategory
        {
            get => (byte)row["reinforceShopCategory"].Value;
            set => row["reinforceShopCategory"].Value = value;
        }

        // Unknown.
        public byte maxArrowQuantity
        {
            get => (byte)row["maxArrowQuantity"].Value;
            set => row["maxArrowQuantity"].Value = value;
        }

        // Unknown.
        public byte residentSfx_1_IsVisibleForHang
        {
            get => (byte)row["residentSfx_1_IsVisibleForHang"].Value;
            set => row["residentSfx_1_IsVisibleForHang"].Value = value;
        }

        // Unknown.
        public byte residentSfx_2_IsVisibleForHang
        {
            get => (byte)row["residentSfx_2_IsVisibleForHang"].Value;
            set => row["residentSfx_2_IsVisibleForHang"].Value = value;
        }

        // Unknown.
        public byte residentSfx_3_IsVisibleForHang
        {
            get => (byte)row["residentSfx_3_IsVisibleForHang"].Value;
            set => row["residentSfx_3_IsVisibleForHang"].Value = value;
        }

        // Unknown.
        public byte residentSfx_4_IsVisibleForHang
        {
            get => (byte)row["residentSfx_4_IsVisibleForHang"].Value;
            set => row["residentSfx_4_IsVisibleForHang"].Value = value;
        }

        // Unknown.
        public byte isSoulParamIdChange_model0
        {
            get => (byte)row["isSoulParamIdChange_model0"].Value;
            set => row["isSoulParamIdChange_model0"].Value = value;
        }

        // Unknown.
        public byte isSoulParamIdChange_model1
        {
            get => (byte)row["isSoulParamIdChange_model1"].Value;
            set => row["isSoulParamIdChange_model1"].Value = value;
        }

        // Unknown.
        public byte isSoulParamIdChange_model2
        {
            get => (byte)row["isSoulParamIdChange_model2"].Value;
            set => row["isSoulParamIdChange_model2"].Value = value;
        }

        // Unknown.
        public byte isSoulParamIdChange_model3
        {
            get => (byte)row["isSoulParamIdChange_model3"].Value;
            set => row["isSoulParamIdChange_model3"].Value = value;
        }

        // Unknown.
        public sbyte wepSeIdOffset
        {
            get => (sbyte)row["wepSeIdOffset"].Value;
            set => row["wepSeIdOffset"].Value = value;
        }

        // Unknown.
        public int baseChangePrice
        {
            get => (int)row["baseChangePrice"].Value;
            set => row["baseChangePrice"].Value = value;
        }

        // Unknown.
        public short levelSyncCorrectId
        {
            get => (short)row["levelSyncCorrectId"].Value;
            set => row["levelSyncCorrectId"].Value = value;
        }

        // Unknown.
        public byte correctType_Sleep
        {
            get => (byte)row["correctType_Sleep"].Value;
            set => row["correctType_Sleep"].Value = value;
        }

        // Unknown.
        public byte correctType_Madness
        {
            get => (byte)row["correctType_Madness"].Value;
            set => row["correctType_Madness"].Value = value;
        }

        // Unknown.
        public byte rarity
        {
            get => (byte)row["rarity"].Value;
            set => row["rarity"].Value = value;
        }

        // Unknown.
        public byte gemMountType
        {
            get => (byte)row["gemMountType"].Value;
            set => row["gemMountType"].Value = value;
        }

        // Unknown.
        public ushort wepRegainHp
        {
            get => (ushort)row["wepRegainHp"].Value;
            set => row["wepRegainHp"].Value = value;
        }

        // Unknown.
        public int spEffectMsgId0
        {
            get => (int)row["spEffectMsgId0"].Value;
            set => row["spEffectMsgId0"].Value = value;
        }

        // Unknown.
        public int spEffectMsgId1
        {
            get => (int)row["spEffectMsgId1"].Value;
            set => row["spEffectMsgId1"].Value = value;
        }

        // Unknown.
        public int spEffectMsgId2
        {
            get => (int)row["spEffectMsgId2"].Value;
            set => row["spEffectMsgId2"].Value = value;
        }

        // Unknown.
        public int originEquipWep16
        {
            get => (int)row["originEquipWep16"].Value;
            set => row["originEquipWep16"].Value = value;
        }

        // Unknown.
        public int originEquipWep17
        {
            get => (int)row["originEquipWep17"].Value;
            set => row["originEquipWep17"].Value = value;
        }

        // Unknown.
        public int originEquipWep18
        {
            get => (int)row["originEquipWep18"].Value;
            set => row["originEquipWep18"].Value = value;
        }

        // Unknown.
        public int originEquipWep19
        {
            get => (int)row["originEquipWep19"].Value;
            set => row["originEquipWep19"].Value = value;
        }

        // Unknown.
        public int originEquipWep20
        {
            get => (int)row["originEquipWep20"].Value;
            set => row["originEquipWep20"].Value = value;
        }

        // Unknown.
        public int originEquipWep21
        {
            get => (int)row["originEquipWep21"].Value;
            set => row["originEquipWep21"].Value = value;
        }

        // Unknown.
        public int originEquipWep22
        {
            get => (int)row["originEquipWep22"].Value;
            set => row["originEquipWep22"].Value = value;
        }

        // Unknown.
        public int originEquipWep23
        {
            get => (int)row["originEquipWep23"].Value;
            set => row["originEquipWep23"].Value = value;
        }

        // Unknown.
        public int originEquipWep24
        {
            get => (int)row["originEquipWep24"].Value;
            set => row["originEquipWep24"].Value = value;
        }

        // Unknown.
        public int originEquipWep25
        {
            get => (int)row["originEquipWep25"].Value;
            set => row["originEquipWep25"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Sleep
        {
            get => (float)row["vsPlayerDmgCorrectRate_Sleep"].Value;
            set => row["vsPlayerDmgCorrectRate_Sleep"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Madness
        {
            get => (float)row["vsPlayerDmgCorrectRate_Madness"].Value;
            set => row["vsPlayerDmgCorrectRate_Madness"].Value = value;
        }

        // Unknown.
        public float saGuardCutRate
        {
            get => (float)row["saGuardCutRate"].Value;
            set => row["saGuardCutRate"].Value = value;
        }

        // Unknown.
        public byte defMaterialVariationValue
        {
            get => (byte)row["defMaterialVariationValue"].Value;
            set => row["defMaterialVariationValue"].Value = value;
        }

        // Unknown.
        public byte spAttributeVariationValue
        {
            get => (byte)row["spAttributeVariationValue"].Value;
            set => row["spAttributeVariationValue"].Value = value;
        }

        // Unknown.
        public short stealthAtkRate
        {
            get => (short)row["stealthAtkRate"].Value;
            set => row["stealthAtkRate"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Disease
        {
            get => (float)row["vsPlayerDmgCorrectRate_Disease"].Value;
            set => row["vsPlayerDmgCorrectRate_Disease"].Value = value;
        }

        // Unknown.
        public float vsPlayerDmgCorrectRate_Curse
        {
            get => (float)row["vsPlayerDmgCorrectRate_Curse"].Value;
            set => row["vsPlayerDmgCorrectRate_Curse"].Value = value;
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
    public EQUIP_PARAM_WEAPON_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public EQUIP_PARAM_WEAPON_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
