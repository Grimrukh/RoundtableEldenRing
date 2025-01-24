using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class EQUIP_PARAM_PROTECTOR_ST
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
        public ushort resistSleep
        {
            get => (ushort)row["resistSleep"].Value;
            set => row["resistSleep"].Value = value;
        }

        // Unknown.
        public ushort resistMadness
        {
            get => (ushort)row["resistMadness"].Value;
            set => row["resistMadness"].Value = value;
        }

        // Unknown.
        public float saDurability
        {
            get => (float)row["saDurability"].Value;
            set => row["saDurability"].Value = value;
        }

        // Unknown.
        public float toughnessCorrectRate
        {
            get => (float)row["toughnessCorrectRate"].Value;
            set => row["toughnessCorrectRate"].Value = value;
        }

        // Unknown.
        public int fixPrice
        {
            get => (int)row["fixPrice"].Value;
            set => row["fixPrice"].Value = value;
        }

        // Unknown.
        public int basicPrice
        {
            get => (int)row["basicPrice"].Value;
            set => row["basicPrice"].Value = value;
        }

        // Unknown.
        public int sellValue
        {
            get => (int)row["sellValue"].Value;
            set => row["sellValue"].Value = value;
        }

        // Unknown.
        public float weight
        {
            get => (float)row["weight"].Value;
            set => row["weight"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId
        {
            get => (int)row["residentSpEffectId"].Value;
            set => row["residentSpEffectId"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId2
        {
            get => (int)row["residentSpEffectId2"].Value;
            set => row["residentSpEffectId2"].Value = value;
        }

        // Unknown.
        public int residentSpEffectId3
        {
            get => (int)row["residentSpEffectId3"].Value;
            set => row["residentSpEffectId3"].Value = value;
        }

        // Unknown.
        public int materialSetId
        {
            get => (int)row["materialSetId"].Value;
            set => row["materialSetId"].Value = value;
        }

        // Unknown.
        public float partsDamageRate
        {
            get => (float)row["partsDamageRate"].Value;
            set => row["partsDamageRate"].Value = value;
        }

        // Unknown.
        public float corectSARecover
        {
            get => (float)row["corectSARecover"].Value;
            set => row["corectSARecover"].Value = value;
        }

        // Unknown.
        public int originEquipPro
        {
            get => (int)row["originEquipPro"].Value;
            set => row["originEquipPro"].Value = value;
        }

        // Unknown.
        public int originEquipPro1
        {
            get => (int)row["originEquipPro1"].Value;
            set => row["originEquipPro1"].Value = value;
        }

        // Unknown.
        public int originEquipPro2
        {
            get => (int)row["originEquipPro2"].Value;
            set => row["originEquipPro2"].Value = value;
        }

        // Unknown.
        public int originEquipPro3
        {
            get => (int)row["originEquipPro3"].Value;
            set => row["originEquipPro3"].Value = value;
        }

        // Unknown.
        public int originEquipPro4
        {
            get => (int)row["originEquipPro4"].Value;
            set => row["originEquipPro4"].Value = value;
        }

        // Unknown.
        public int originEquipPro5
        {
            get => (int)row["originEquipPro5"].Value;
            set => row["originEquipPro5"].Value = value;
        }

        // Unknown.
        public int originEquipPro6
        {
            get => (int)row["originEquipPro6"].Value;
            set => row["originEquipPro6"].Value = value;
        }

        // Unknown.
        public int originEquipPro7
        {
            get => (int)row["originEquipPro7"].Value;
            set => row["originEquipPro7"].Value = value;
        }

        // Unknown.
        public int originEquipPro8
        {
            get => (int)row["originEquipPro8"].Value;
            set => row["originEquipPro8"].Value = value;
        }

        // Unknown.
        public int originEquipPro9
        {
            get => (int)row["originEquipPro9"].Value;
            set => row["originEquipPro9"].Value = value;
        }

        // Unknown.
        public int originEquipPro10
        {
            get => (int)row["originEquipPro10"].Value;
            set => row["originEquipPro10"].Value = value;
        }

        // Unknown.
        public int originEquipPro11
        {
            get => (int)row["originEquipPro11"].Value;
            set => row["originEquipPro11"].Value = value;
        }

        // Unknown.
        public int originEquipPro12
        {
            get => (int)row["originEquipPro12"].Value;
            set => row["originEquipPro12"].Value = value;
        }

        // Unknown.
        public int originEquipPro13
        {
            get => (int)row["originEquipPro13"].Value;
            set => row["originEquipPro13"].Value = value;
        }

        // Unknown.
        public int originEquipPro14
        {
            get => (int)row["originEquipPro14"].Value;
            set => row["originEquipPro14"].Value = value;
        }

        // Unknown.
        public int originEquipPro15
        {
            get => (int)row["originEquipPro15"].Value;
            set => row["originEquipPro15"].Value = value;
        }

        public float faceScaleM_ScaleX
        {
            get => (float)row["faceScaleM_ScaleX"].Value;
            set => row["faceScaleM_ScaleX"].Value = value;
        }

        public float faceScaleM_ScaleZ
        {
            get => (float)row["faceScaleM_ScaleZ"].Value;
            set => row["faceScaleM_ScaleZ"].Value = value;
        }

        public float faceScaleM_MaxX
        {
            get => (float)row["faceScaleM_MaxX"].Value;
            set => row["faceScaleM_MaxX"].Value = value;
        }

        public float faceScaleM_MaxZ
        {
            get => (float)row["faceScaleM_MaxZ"].Value;
            set => row["faceScaleM_MaxZ"].Value = value;
        }

        public float faceScaleF_ScaleX
        {
            get => (float)row["faceScaleF_ScaleX"].Value;
            set => row["faceScaleF_ScaleX"].Value = value;
        }

        public float faceScaleF_ScaleZ
        {
            get => (float)row["faceScaleF_ScaleZ"].Value;
            set => row["faceScaleF_ScaleZ"].Value = value;
        }

        public float faceScaleF_MaxX
        {
            get => (float)row["faceScaleF_MaxX"].Value;
            set => row["faceScaleF_MaxX"].Value = value;
        }

        public float faceScaleF_MaxZ
        {
            get => (float)row["faceScaleF_MaxZ"].Value;
            set => row["faceScaleF_MaxZ"].Value = value;
        }

        // Unknown.
        public int qwcId
        {
            get => (int)row["qwcId"].Value;
            set => row["qwcId"].Value = value;
        }

        // Unknown.
        public ushort equipModelId
        {
            get => (ushort)row["equipModelId"].Value;
            set => row["equipModelId"].Value = value;
        }

        // Unknown.
        public ushort iconIdM
        {
            get => (ushort)row["iconIdM"].Value;
            set => row["iconIdM"].Value = value;
        }

        // Unknown.
        public ushort iconIdF
        {
            get => (ushort)row["iconIdF"].Value;
            set => row["iconIdF"].Value = value;
        }

        // Unknown.
        public ushort knockBack
        {
            get => (ushort)row["knockBack"].Value;
            set => row["knockBack"].Value = value;
        }

        // Unknown.
        public ushort knockbackBounceRate
        {
            get => (ushort)row["knockbackBounceRate"].Value;
            set => row["knockbackBounceRate"].Value = value;
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
        public ushort defFlickPower
        {
            get => (ushort)row["defFlickPower"].Value;
            set => row["defFlickPower"].Value = value;
        }

        // Unknown.
        public ushort defensePhysics
        {
            get => (ushort)row["defensePhysics"].Value;
            set => row["defensePhysics"].Value = value;
        }

        // Unknown.
        public ushort defenseMagic
        {
            get => (ushort)row["defenseMagic"].Value;
            set => row["defenseMagic"].Value = value;
        }

        // Unknown.
        public ushort defenseFire
        {
            get => (ushort)row["defenseFire"].Value;
            set => row["defenseFire"].Value = value;
        }

        // Unknown.
        public ushort defenseThunder
        {
            get => (ushort)row["defenseThunder"].Value;
            set => row["defenseThunder"].Value = value;
        }

        // Unknown.
        public short defenseSlash
        {
            get => (short)row["defenseSlash"].Value;
            set => row["defenseSlash"].Value = value;
        }

        // Unknown.
        public short defenseBlow
        {
            get => (short)row["defenseBlow"].Value;
            set => row["defenseBlow"].Value = value;
        }

        // Unknown.
        public short defenseThrust
        {
            get => (short)row["defenseThrust"].Value;
            set => row["defenseThrust"].Value = value;
        }

        // Unknown.
        public ushort resistPoison
        {
            get => (ushort)row["resistPoison"].Value;
            set => row["resistPoison"].Value = value;
        }

        // Unknown.
        public ushort resistDisease
        {
            get => (ushort)row["resistDisease"].Value;
            set => row["resistDisease"].Value = value;
        }

        // Unknown.
        public ushort resistBlood
        {
            get => (ushort)row["resistBlood"].Value;
            set => row["resistBlood"].Value = value;
        }

        // Unknown.
        public ushort resistCurse
        {
            get => (ushort)row["resistCurse"].Value;
            set => row["resistCurse"].Value = value;
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
        public short shopLv
        {
            get => (short)row["shopLv"].Value;
            set => row["shopLv"].Value = value;
        }

        // Unknown.
        public byte knockbackParamId
        {
            get => (byte)row["knockbackParamId"].Value;
            set => row["knockbackParamId"].Value = value;
        }

        // Unknown.
        public byte flickDamageCutRate
        {
            get => (byte)row["flickDamageCutRate"].Value;
            set => row["flickDamageCutRate"].Value = value;
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
        public byte protectorCategory
        {
            get => (byte)row["protectorCategory"].Value;
            set => row["protectorCategory"].Value = value;
        }

        // Unknown.
        public byte rarity
        {
            get => (byte)row["rarity"].Value;
            set => row["rarity"].Value = value;
        }

        // Unknown.
        public byte sortGroupId
        {
            get => (byte)row["sortGroupId"].Value;
            set => row["sortGroupId"].Value = value;
        }

        // Unknown.
        public byte partsDmgType
        {
            get => (byte)row["partsDmgType"].Value;
            set => row["partsDmgType"].Value = value;
        }

        // Unknown.
        public byte isDeposit
        {
            get => (byte)row["isDeposit"].Value;
            set => row["isDeposit"].Value = value;
        }

        // Unknown.
        public byte headEquip
        {
            get => (byte)row["headEquip"].Value;
            set => row["headEquip"].Value = value;
        }

        // Unknown.
        public byte bodyEquip
        {
            get => (byte)row["bodyEquip"].Value;
            set => row["bodyEquip"].Value = value;
        }

        // Unknown.
        public byte armEquip
        {
            get => (byte)row["armEquip"].Value;
            set => row["armEquip"].Value = value;
        }

        // Unknown.
        public byte legEquip
        {
            get => (byte)row["legEquip"].Value;
            set => row["legEquip"].Value = value;
        }

        // Unknown.
        public byte useFaceScale
        {
            get => (byte)row["useFaceScale"].Value;
            set => row["useFaceScale"].Value = value;
        }

        // Unknown.
        public byte isSkipWeakDamageAnim
        {
            get => (byte)row["isSkipWeakDamageAnim"].Value;
            set => row["isSkipWeakDamageAnim"].Value = value;
        }

        // Unknown.
        public byte defenseMaterialVariationValue_Weak
        {
            get => (byte)row["defenseMaterialVariationValue_Weak"].Value;
            set => row["defenseMaterialVariationValue_Weak"].Value = value;
        }

        // Unknown.
        public short autoFootEffectDecalBaseId2
        {
            get => (short)row["autoFootEffectDecalBaseId2"].Value;
            set => row["autoFootEffectDecalBaseId2"].Value = value;
        }

        // Unknown.
        public short autoFootEffectDecalBaseId3
        {
            get => (short)row["autoFootEffectDecalBaseId3"].Value;
            set => row["autoFootEffectDecalBaseId3"].Value = value;
        }

        // Unknown.
        public byte defenseMaterialVariationValue
        {
            get => (byte)row["defenseMaterialVariationValue"].Value;
            set => row["defenseMaterialVariationValue"].Value = value;
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
        public byte disableMultiDropShare
        {
            get => (byte)row["disableMultiDropShare"].Value;
            set => row["disableMultiDropShare"].Value = value;
        }

        // Unknown.
        public byte simpleModelForDlc
        {
            get => (byte)row["simpleModelForDlc"].Value;
            set => row["simpleModelForDlc"].Value = value;
        }

        // Unknown.
        public byte showLogCondType
        {
            get => (byte)row["showLogCondType"].Value;
            set => row["showLogCondType"].Value = value;
        }

        // Unknown.
        public byte showDialogCondType
        {
            get => (byte)row["showDialogCondType"].Value;
            set => row["showDialogCondType"].Value = value;
        }

        // Unknown.
        public float neutralDamageCutRate
        {
            get => (float)row["neutralDamageCutRate"].Value;
            set => row["neutralDamageCutRate"].Value = value;
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
        public ushort defenseMaterialSfx1
        {
            get => (ushort)row["defenseMaterialSfx1"].Value;
            set => row["defenseMaterialSfx1"].Value = value;
        }

        // Unknown.
        public ushort defenseMaterialSfx_Weak1
        {
            get => (ushort)row["defenseMaterialSfx_Weak1"].Value;
            set => row["defenseMaterialSfx_Weak1"].Value = value;
        }

        // Unknown.
        public ushort defenseMaterial1
        {
            get => (ushort)row["defenseMaterial1"].Value;
            set => row["defenseMaterial1"].Value = value;
        }

        // Unknown.
        public ushort defenseMaterial_Weak1
        {
            get => (ushort)row["defenseMaterial_Weak1"].Value;
            set => row["defenseMaterial_Weak1"].Value = value;
        }

        // Unknown.
        public ushort defenseMaterialSfx2
        {
            get => (ushort)row["defenseMaterialSfx2"].Value;
            set => row["defenseMaterialSfx2"].Value = value;
        }

        // Unknown.
        public ushort defenseMaterialSfx_Weak2
        {
            get => (ushort)row["defenseMaterialSfx_Weak2"].Value;
            set => row["defenseMaterialSfx_Weak2"].Value = value;
        }

        // Unknown.
        public ushort footMaterialSe
        {
            get => (ushort)row["footMaterialSe"].Value;
            set => row["footMaterialSe"].Value = value;
        }

        // Unknown.
        public ushort defenseMaterial_Weak2
        {
            get => (ushort)row["defenseMaterial_Weak2"].Value;
            set => row["defenseMaterial_Weak2"].Value = value;
        }

        // Unknown.
        public int autoFootEffectDecalBaseId1
        {
            get => (int)row["autoFootEffectDecalBaseId1"].Value;
            set => row["autoFootEffectDecalBaseId1"].Value = value;
        }

        // Unknown.
        public float toughnessDamageCutRate
        {
            get => (float)row["toughnessDamageCutRate"].Value;
            set => row["toughnessDamageCutRate"].Value = value;
        }

        // Unknown.
        public float toughnessRecoverCorrection
        {
            get => (float)row["toughnessRecoverCorrection"].Value;
            set => row["toughnessRecoverCorrection"].Value = value;
        }

        // Unknown.
        public float darkDamageCutRate
        {
            get => (float)row["darkDamageCutRate"].Value;
            set => row["darkDamageCutRate"].Value = value;
        }

        // Unknown.
        public ushort defenseDark
        {
            get => (ushort)row["defenseDark"].Value;
            set => row["defenseDark"].Value = value;
        }

        // Unknown.
        public byte postureControlId
        {
            get => (byte)row["postureControlId"].Value;
            set => row["postureControlId"].Value = value;
        }

        // Unknown.
        public int saleValue
        {
            get => (int)row["saleValue"].Value;
            set => row["saleValue"].Value = value;
        }

        // Unknown.
        public ushort resistFreeze
        {
            get => (ushort)row["resistFreeze"].Value;
            set => row["resistFreeze"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer00
        {
            get => (byte)row["invisibleFlag_SexVer00"].Value;
            set => row["invisibleFlag_SexVer00"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer01
        {
            get => (byte)row["invisibleFlag_SexVer01"].Value;
            set => row["invisibleFlag_SexVer01"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer02
        {
            get => (byte)row["invisibleFlag_SexVer02"].Value;
            set => row["invisibleFlag_SexVer02"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer03
        {
            get => (byte)row["invisibleFlag_SexVer03"].Value;
            set => row["invisibleFlag_SexVer03"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer04
        {
            get => (byte)row["invisibleFlag_SexVer04"].Value;
            set => row["invisibleFlag_SexVer04"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer05
        {
            get => (byte)row["invisibleFlag_SexVer05"].Value;
            set => row["invisibleFlag_SexVer05"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer06
        {
            get => (byte)row["invisibleFlag_SexVer06"].Value;
            set => row["invisibleFlag_SexVer06"].Value = value;
        }

        public byte invisibleFlag_SexVer07
        {
            get => (byte)row["invisibleFlag_SexVer07"].Value;
            set => row["invisibleFlag_SexVer07"].Value = value;
        }

        public byte invisibleFlag_SexVer08
        {
            get => (byte)row["invisibleFlag_SexVer08"].Value;
            set => row["invisibleFlag_SexVer08"].Value = value;
        }

        public byte invisibleFlag_SexVer09
        {
            get => (byte)row["invisibleFlag_SexVer09"].Value;
            set => row["invisibleFlag_SexVer09"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer10
        {
            get => (byte)row["invisibleFlag_SexVer10"].Value;
            set => row["invisibleFlag_SexVer10"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer11
        {
            get => (byte)row["invisibleFlag_SexVer11"].Value;
            set => row["invisibleFlag_SexVer11"].Value = value;
        }

        public byte invisibleFlag_SexVer12
        {
            get => (byte)row["invisibleFlag_SexVer12"].Value;
            set => row["invisibleFlag_SexVer12"].Value = value;
        }

        public byte invisibleFlag_SexVer13
        {
            get => (byte)row["invisibleFlag_SexVer13"].Value;
            set => row["invisibleFlag_SexVer13"].Value = value;
        }

        public byte invisibleFlag_SexVer14
        {
            get => (byte)row["invisibleFlag_SexVer14"].Value;
            set => row["invisibleFlag_SexVer14"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer15
        {
            get => (byte)row["invisibleFlag_SexVer15"].Value;
            set => row["invisibleFlag_SexVer15"].Value = value;
        }

        public byte invisibleFlag_SexVer16
        {
            get => (byte)row["invisibleFlag_SexVer16"].Value;
            set => row["invisibleFlag_SexVer16"].Value = value;
        }

        public byte invisibleFlag_SexVer17
        {
            get => (byte)row["invisibleFlag_SexVer17"].Value;
            set => row["invisibleFlag_SexVer17"].Value = value;
        }

        public byte invisibleFlag_SexVer18
        {
            get => (byte)row["invisibleFlag_SexVer18"].Value;
            set => row["invisibleFlag_SexVer18"].Value = value;
        }

        public byte invisibleFlag_SexVer19
        {
            get => (byte)row["invisibleFlag_SexVer19"].Value;
            set => row["invisibleFlag_SexVer19"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer20
        {
            get => (byte)row["invisibleFlag_SexVer20"].Value;
            set => row["invisibleFlag_SexVer20"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer21
        {
            get => (byte)row["invisibleFlag_SexVer21"].Value;
            set => row["invisibleFlag_SexVer21"].Value = value;
        }

        public byte invisibleFlag_SexVer22
        {
            get => (byte)row["invisibleFlag_SexVer22"].Value;
            set => row["invisibleFlag_SexVer22"].Value = value;
        }

        public byte invisibleFlag_SexVer23
        {
            get => (byte)row["invisibleFlag_SexVer23"].Value;
            set => row["invisibleFlag_SexVer23"].Value = value;
        }

        public byte invisibleFlag_SexVer24
        {
            get => (byte)row["invisibleFlag_SexVer24"].Value;
            set => row["invisibleFlag_SexVer24"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer25
        {
            get => (byte)row["invisibleFlag_SexVer25"].Value;
            set => row["invisibleFlag_SexVer25"].Value = value;
        }

        public byte invisibleFlag_SexVer26
        {
            get => (byte)row["invisibleFlag_SexVer26"].Value;
            set => row["invisibleFlag_SexVer26"].Value = value;
        }

        public byte invisibleFlag_SexVer27
        {
            get => (byte)row["invisibleFlag_SexVer27"].Value;
            set => row["invisibleFlag_SexVer27"].Value = value;
        }

        public byte invisibleFlag_SexVer28
        {
            get => (byte)row["invisibleFlag_SexVer28"].Value;
            set => row["invisibleFlag_SexVer28"].Value = value;
        }

        public byte invisibleFlag_SexVer29
        {
            get => (byte)row["invisibleFlag_SexVer29"].Value;
            set => row["invisibleFlag_SexVer29"].Value = value;
        }

        // Unknown.
        public byte invisibleFlag_SexVer30
        {
            get => (byte)row["invisibleFlag_SexVer30"].Value;
            set => row["invisibleFlag_SexVer30"].Value = value;
        }

        public byte invisibleFlag_SexVer31
        {
            get => (byte)row["invisibleFlag_SexVer31"].Value;
            set => row["invisibleFlag_SexVer31"].Value = value;
        }

        public byte invisibleFlag_SexVer32
        {
            get => (byte)row["invisibleFlag_SexVer32"].Value;
            set => row["invisibleFlag_SexVer32"].Value = value;
        }

        public byte invisibleFlag_SexVer33
        {
            get => (byte)row["invisibleFlag_SexVer33"].Value;
            set => row["invisibleFlag_SexVer33"].Value = value;
        }

        public byte invisibleFlag_SexVer34
        {
            get => (byte)row["invisibleFlag_SexVer34"].Value;
            set => row["invisibleFlag_SexVer34"].Value = value;
        }

        public byte invisibleFlag_SexVer35
        {
            get => (byte)row["invisibleFlag_SexVer35"].Value;
            set => row["invisibleFlag_SexVer35"].Value = value;
        }

        public byte invisibleFlag_SexVer36
        {
            get => (byte)row["invisibleFlag_SexVer36"].Value;
            set => row["invisibleFlag_SexVer36"].Value = value;
        }

        public byte invisibleFlag_SexVer37
        {
            get => (byte)row["invisibleFlag_SexVer37"].Value;
            set => row["invisibleFlag_SexVer37"].Value = value;
        }

        public byte invisibleFlag_SexVer38
        {
            get => (byte)row["invisibleFlag_SexVer38"].Value;
            set => row["invisibleFlag_SexVer38"].Value = value;
        }

        public byte invisibleFlag_SexVer39
        {
            get => (byte)row["invisibleFlag_SexVer39"].Value;
            set => row["invisibleFlag_SexVer39"].Value = value;
        }

        public byte invisibleFlag_SexVer40
        {
            get => (byte)row["invisibleFlag_SexVer40"].Value;
            set => row["invisibleFlag_SexVer40"].Value = value;
        }

        public byte invisibleFlag_SexVer41
        {
            get => (byte)row["invisibleFlag_SexVer41"].Value;
            set => row["invisibleFlag_SexVer41"].Value = value;
        }

        public byte invisibleFlag_SexVer42
        {
            get => (byte)row["invisibleFlag_SexVer42"].Value;
            set => row["invisibleFlag_SexVer42"].Value = value;
        }

        public byte invisibleFlag_SexVer43
        {
            get => (byte)row["invisibleFlag_SexVer43"].Value;
            set => row["invisibleFlag_SexVer43"].Value = value;
        }

        public byte invisibleFlag_SexVer44
        {
            get => (byte)row["invisibleFlag_SexVer44"].Value;
            set => row["invisibleFlag_SexVer44"].Value = value;
        }

        public byte invisibleFlag_SexVer45
        {
            get => (byte)row["invisibleFlag_SexVer45"].Value;
            set => row["invisibleFlag_SexVer45"].Value = value;
        }

        public byte invisibleFlag_SexVer46
        {
            get => (byte)row["invisibleFlag_SexVer46"].Value;
            set => row["invisibleFlag_SexVer46"].Value = value;
        }

        public byte invisibleFlag_SexVer47
        {
            get => (byte)row["invisibleFlag_SexVer47"].Value;
            set => row["invisibleFlag_SexVer47"].Value = value;
        }

        public byte invisibleFlag_SexVer48
        {
            get => (byte)row["invisibleFlag_SexVer48"].Value;
            set => row["invisibleFlag_SexVer48"].Value = value;
        }

        public byte invisibleFlag_SexVer49
        {
            get => (byte)row["invisibleFlag_SexVer49"].Value;
            set => row["invisibleFlag_SexVer49"].Value = value;
        }

        public byte invisibleFlag_SexVer50
        {
            get => (byte)row["invisibleFlag_SexVer50"].Value;
            set => row["invisibleFlag_SexVer50"].Value = value;
        }

        public byte invisibleFlag_SexVer51
        {
            get => (byte)row["invisibleFlag_SexVer51"].Value;
            set => row["invisibleFlag_SexVer51"].Value = value;
        }

        public byte invisibleFlag_SexVer52
        {
            get => (byte)row["invisibleFlag_SexVer52"].Value;
            set => row["invisibleFlag_SexVer52"].Value = value;
        }

        public byte invisibleFlag_SexVer53
        {
            get => (byte)row["invisibleFlag_SexVer53"].Value;
            set => row["invisibleFlag_SexVer53"].Value = value;
        }

        public byte invisibleFlag_SexVer54
        {
            get => (byte)row["invisibleFlag_SexVer54"].Value;
            set => row["invisibleFlag_SexVer54"].Value = value;
        }

        public byte invisibleFlag_SexVer55
        {
            get => (byte)row["invisibleFlag_SexVer55"].Value;
            set => row["invisibleFlag_SexVer55"].Value = value;
        }

        public byte invisibleFlag_SexVer56
        {
            get => (byte)row["invisibleFlag_SexVer56"].Value;
            set => row["invisibleFlag_SexVer56"].Value = value;
        }

        public byte invisibleFlag_SexVer57
        {
            get => (byte)row["invisibleFlag_SexVer57"].Value;
            set => row["invisibleFlag_SexVer57"].Value = value;
        }

        public byte invisibleFlag_SexVer58
        {
            get => (byte)row["invisibleFlag_SexVer58"].Value;
            set => row["invisibleFlag_SexVer58"].Value = value;
        }

        public byte invisibleFlag_SexVer59
        {
            get => (byte)row["invisibleFlag_SexVer59"].Value;
            set => row["invisibleFlag_SexVer59"].Value = value;
        }

        public byte invisibleFlag_SexVer60
        {
            get => (byte)row["invisibleFlag_SexVer60"].Value;
            set => row["invisibleFlag_SexVer60"].Value = value;
        }

        public byte invisibleFlag_SexVer61
        {
            get => (byte)row["invisibleFlag_SexVer61"].Value;
            set => row["invisibleFlag_SexVer61"].Value = value;
        }

        public byte invisibleFlag_SexVer62
        {
            get => (byte)row["invisibleFlag_SexVer62"].Value;
            set => row["invisibleFlag_SexVer62"].Value = value;
        }

        public byte invisibleFlag_SexVer63
        {
            get => (byte)row["invisibleFlag_SexVer63"].Value;
            set => row["invisibleFlag_SexVer63"].Value = value;
        }

        public byte invisibleFlag_SexVer64
        {
            get => (byte)row["invisibleFlag_SexVer64"].Value;
            set => row["invisibleFlag_SexVer64"].Value = value;
        }

        public byte invisibleFlag_SexVer65
        {
            get => (byte)row["invisibleFlag_SexVer65"].Value;
            set => row["invisibleFlag_SexVer65"].Value = value;
        }

        public byte invisibleFlag_SexVer66
        {
            get => (byte)row["invisibleFlag_SexVer66"].Value;
            set => row["invisibleFlag_SexVer66"].Value = value;
        }

        public byte invisibleFlag_SexVer67
        {
            get => (byte)row["invisibleFlag_SexVer67"].Value;
            set => row["invisibleFlag_SexVer67"].Value = value;
        }

        public byte invisibleFlag_SexVer68
        {
            get => (byte)row["invisibleFlag_SexVer68"].Value;
            set => row["invisibleFlag_SexVer68"].Value = value;
        }

        public byte invisibleFlag_SexVer69
        {
            get => (byte)row["invisibleFlag_SexVer69"].Value;
            set => row["invisibleFlag_SexVer69"].Value = value;
        }

        public byte invisibleFlag_SexVer70
        {
            get => (byte)row["invisibleFlag_SexVer70"].Value;
            set => row["invisibleFlag_SexVer70"].Value = value;
        }

        public byte invisibleFlag_SexVer71
        {
            get => (byte)row["invisibleFlag_SexVer71"].Value;
            set => row["invisibleFlag_SexVer71"].Value = value;
        }

        public byte invisibleFlag_SexVer72
        {
            get => (byte)row["invisibleFlag_SexVer72"].Value;
            set => row["invisibleFlag_SexVer72"].Value = value;
        }

        public byte invisibleFlag_SexVer73
        {
            get => (byte)row["invisibleFlag_SexVer73"].Value;
            set => row["invisibleFlag_SexVer73"].Value = value;
        }

        public byte invisibleFlag_SexVer74
        {
            get => (byte)row["invisibleFlag_SexVer74"].Value;
            set => row["invisibleFlag_SexVer74"].Value = value;
        }

        public byte invisibleFlag_SexVer75
        {
            get => (byte)row["invisibleFlag_SexVer75"].Value;
            set => row["invisibleFlag_SexVer75"].Value = value;
        }

        public byte invisibleFlag_SexVer76
        {
            get => (byte)row["invisibleFlag_SexVer76"].Value;
            set => row["invisibleFlag_SexVer76"].Value = value;
        }

        public byte invisibleFlag_SexVer77
        {
            get => (byte)row["invisibleFlag_SexVer77"].Value;
            set => row["invisibleFlag_SexVer77"].Value = value;
        }

        public byte invisibleFlag_SexVer78
        {
            get => (byte)row["invisibleFlag_SexVer78"].Value;
            set => row["invisibleFlag_SexVer78"].Value = value;
        }

        public byte invisibleFlag_SexVer79
        {
            get => (byte)row["invisibleFlag_SexVer79"].Value;
            set => row["invisibleFlag_SexVer79"].Value = value;
        }

        public byte invisibleFlag_SexVer80
        {
            get => (byte)row["invisibleFlag_SexVer80"].Value;
            set => row["invisibleFlag_SexVer80"].Value = value;
        }

        public byte invisibleFlag_SexVer81
        {
            get => (byte)row["invisibleFlag_SexVer81"].Value;
            set => row["invisibleFlag_SexVer81"].Value = value;
        }

        public byte invisibleFlag_SexVer82
        {
            get => (byte)row["invisibleFlag_SexVer82"].Value;
            set => row["invisibleFlag_SexVer82"].Value = value;
        }

        public byte invisibleFlag_SexVer83
        {
            get => (byte)row["invisibleFlag_SexVer83"].Value;
            set => row["invisibleFlag_SexVer83"].Value = value;
        }

        public byte invisibleFlag_SexVer84
        {
            get => (byte)row["invisibleFlag_SexVer84"].Value;
            set => row["invisibleFlag_SexVer84"].Value = value;
        }

        public byte invisibleFlag_SexVer85
        {
            get => (byte)row["invisibleFlag_SexVer85"].Value;
            set => row["invisibleFlag_SexVer85"].Value = value;
        }

        public byte invisibleFlag_SexVer86
        {
            get => (byte)row["invisibleFlag_SexVer86"].Value;
            set => row["invisibleFlag_SexVer86"].Value = value;
        }

        public byte invisibleFlag_SexVer87
        {
            get => (byte)row["invisibleFlag_SexVer87"].Value;
            set => row["invisibleFlag_SexVer87"].Value = value;
        }

        public byte invisibleFlag_SexVer88
        {
            get => (byte)row["invisibleFlag_SexVer88"].Value;
            set => row["invisibleFlag_SexVer88"].Value = value;
        }

        public byte invisibleFlag_SexVer89
        {
            get => (byte)row["invisibleFlag_SexVer89"].Value;
            set => row["invisibleFlag_SexVer89"].Value = value;
        }

        public byte invisibleFlag_SexVer90
        {
            get => (byte)row["invisibleFlag_SexVer90"].Value;
            set => row["invisibleFlag_SexVer90"].Value = value;
        }

        public byte invisibleFlag_SexVer91
        {
            get => (byte)row["invisibleFlag_SexVer91"].Value;
            set => row["invisibleFlag_SexVer91"].Value = value;
        }

        public byte invisibleFlag_SexVer92
        {
            get => (byte)row["invisibleFlag_SexVer92"].Value;
            set => row["invisibleFlag_SexVer92"].Value = value;
        }

        public byte invisibleFlag_SexVer93
        {
            get => (byte)row["invisibleFlag_SexVer93"].Value;
            set => row["invisibleFlag_SexVer93"].Value = value;
        }

        public byte invisibleFlag_SexVer94
        {
            get => (byte)row["invisibleFlag_SexVer94"].Value;
            set => row["invisibleFlag_SexVer94"].Value = value;
        }

        public byte invisibleFlag_SexVer95
        {
            get => (byte)row["invisibleFlag_SexVer95"].Value;
            set => row["invisibleFlag_SexVer95"].Value = value;
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
    public EQUIP_PARAM_PROTECTOR_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public EQUIP_PARAM_PROTECTOR_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
