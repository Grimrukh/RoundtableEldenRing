using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MAGIC_PARAM_ST
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
        public int yesNoDialogMessageId
        {
            get => (int)row["yesNoDialogMessageId"].Value;
            set => row["yesNoDialogMessageId"].Value = value;
        }

        // Unknown.
        public int limitCancelSpEffectId
        {
            get => (int)row["limitCancelSpEffectId"].Value;
            set => row["limitCancelSpEffectId"].Value = value;
        }

        // Unknown.
        public short sortId
        {
            get => (short)row["sortId"].Value;
            set => row["sortId"].Value = value;
        }

        // Unknown.
        public byte requirementLuck
        {
            get => (byte)row["requirementLuck"].Value;
            set => row["requirementLuck"].Value = value;
        }

        // Unknown.
        public byte aiNotifyType
        {
            get => (byte)row["aiNotifyType"].Value;
            set => row["aiNotifyType"].Value = value;
        }

        // Unknown.
        public short mp
        {
            get => (short)row["mp"].Value;
            set => row["mp"].Value = value;
        }

        // Unknown.
        public short stamina
        {
            get => (short)row["stamina"].Value;
            set => row["stamina"].Value = value;
        }

        // Unknown.
        public short iconId
        {
            get => (short)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public short behaviorId
        {
            get => (short)row["behaviorId"].Value;
            set => row["behaviorId"].Value = value;
        }

        // Unknown.
        public short mtrlItemId
        {
            get => (short)row["mtrlItemId"].Value;
            set => row["mtrlItemId"].Value = value;
        }

        // Unknown.
        public short replaceMagicId
        {
            get => (short)row["replaceMagicId"].Value;
            set => row["replaceMagicId"].Value = value;
        }

        // Unknown.
        public short maxQuantity
        {
            get => (short)row["maxQuantity"].Value;
            set => row["maxQuantity"].Value = value;
        }

        // Unknown.
        public byte refCategory1
        {
            get => (byte)row["refCategory1"].Value;
            set => row["refCategory1"].Value = value;
        }

        // Unknown.
        public byte overDexterity
        {
            get => (byte)row["overDexterity"].Value;
            set => row["overDexterity"].Value = value;
        }

        // Unknown.
        public byte refCategory2
        {
            get => (byte)row["refCategory2"].Value;
            set => row["refCategory2"].Value = value;
        }

        // Unknown.
        public byte slotLength
        {
            get => (byte)row["slotLength"].Value;
            set => row["slotLength"].Value = value;
        }

        // Unknown.
        public byte requirementIntellect
        {
            get => (byte)row["requirementIntellect"].Value;
            set => row["requirementIntellect"].Value = value;
        }

        // Unknown.
        public byte requirementFaith
        {
            get => (byte)row["requirementFaith"].Value;
            set => row["requirementFaith"].Value = value;
        }

        // Unknown.
        public byte analogDexterityMin
        {
            get => (byte)row["analogDexterityMin"].Value;
            set => row["analogDexterityMin"].Value = value;
        }

        // Unknown.
        public byte analogDexterityMax
        {
            get => (byte)row["analogDexterityMax"].Value;
            set => row["analogDexterityMax"].Value = value;
        }

        // Unknown.
        public byte ezStateBehaviorType
        {
            get => (byte)row["ezStateBehaviorType"].Value;
            set => row["ezStateBehaviorType"].Value = value;
        }

        // Unknown.
        public byte refCategory3
        {
            get => (byte)row["refCategory3"].Value;
            set => row["refCategory3"].Value = value;
        }

        // Unknown.
        public byte spEffectCategory
        {
            get => (byte)row["spEffectCategory"].Value;
            set => row["spEffectCategory"].Value = value;
        }

        // Unknown.
        public byte refType
        {
            get => (byte)row["refType"].Value;
            set => row["refType"].Value = value;
        }

        // Unknown.
        public byte opmeMenuType
        {
            get => (byte)row["opmeMenuType"].Value;
            set => row["opmeMenuType"].Value = value;
        }

        // Unknown.
        public byte refCategory4
        {
            get => (byte)row["refCategory4"].Value;
            set => row["refCategory4"].Value = value;
        }

        // Unknown.
        public ushort hasSpEffectType
        {
            get => (ushort)row["hasSpEffectType"].Value;
            set => row["hasSpEffectType"].Value = value;
        }

        // Unknown.
        public byte replaceCategory
        {
            get => (byte)row["replaceCategory"].Value;
            set => row["replaceCategory"].Value = value;
        }

        // Unknown.
        public byte useLimitCategory
        {
            get => (byte)row["useLimitCategory"].Value;
            set => row["useLimitCategory"].Value = value;
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
        public byte enable_multi
        {
            get => (byte)row["enable_multi"].Value;
            set => row["enable_multi"].Value = value;
        }

        // Unknown.
        public byte enable_multi_only
        {
            get => (byte)row["enable_multi_only"].Value;
            set => row["enable_multi_only"].Value = value;
        }

        // Unknown.
        public byte isEnchant
        {
            get => (byte)row["isEnchant"].Value;
            set => row["isEnchant"].Value = value;
        }

        // Unknown.
        public byte isShieldEnchant
        {
            get => (byte)row["isShieldEnchant"].Value;
            set => row["isShieldEnchant"].Value = value;
        }

        // Unknown.
        public byte enable_live
        {
            get => (byte)row["enable_live"].Value;
            set => row["enable_live"].Value = value;
        }

        // Unknown.
        public byte enable_gray
        {
            get => (byte)row["enable_gray"].Value;
            set => row["enable_gray"].Value = value;
        }

        // Unknown.
        public byte enable_white
        {
            get => (byte)row["enable_white"].Value;
            set => row["enable_white"].Value = value;
        }

        // Unknown.
        public byte enable_black
        {
            get => (byte)row["enable_black"].Value;
            set => row["enable_black"].Value = value;
        }

        // Unknown.
        public byte disableOffline
        {
            get => (byte)row["disableOffline"].Value;
            set => row["disableOffline"].Value = value;
        }

        // Unknown.
        public byte castResonanceMagic
        {
            get => (byte)row["castResonanceMagic"].Value;
            set => row["castResonanceMagic"].Value = value;
        }

        // Unknown.
        public byte isValidTough_ProtSADmg
        {
            get => (byte)row["isValidTough_ProtSADmg"].Value;
            set => row["isValidTough_ProtSADmg"].Value = value;
        }

        // Unknown.
        public byte isWarpMagic
        {
            get => (byte)row["isWarpMagic"].Value;
            set => row["isWarpMagic"].Value = value;
        }

        // Unknown.
        public byte enableRiding
        {
            get => (byte)row["enableRiding"].Value;
            set => row["enableRiding"].Value = value;
        }

        // Unknown.
        public byte disableRiding
        {
            get => (byte)row["disableRiding"].Value;
            set => row["disableRiding"].Value = value;
        }

        // Unknown.
        public byte isUseNoAttackRegion
        {
            get => (byte)row["isUseNoAttackRegion"].Value;
            set => row["isUseNoAttackRegion"].Value = value;
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
        public int castSfxId
        {
            get => (int)row["castSfxId"].Value;
            set => row["castSfxId"].Value = value;
        }

        // Unknown.
        public int fireSfxId
        {
            get => (int)row["fireSfxId"].Value;
            set => row["fireSfxId"].Value = value;
        }

        // Unknown.
        public int effectSfxId
        {
            get => (int)row["effectSfxId"].Value;
            set => row["effectSfxId"].Value = value;
        }

        // Unknown.
        public float toughnessCorrectRate
        {
            get => (float)row["toughnessCorrectRate"].Value;
            set => row["toughnessCorrectRate"].Value = value;
        }

        // Unknown.
        public byte ReplacementStatusType
        {
            get => (byte)row["ReplacementStatusType"].Value;
            set => row["ReplacementStatusType"].Value = value;
        }

        // Unknown.
        public sbyte ReplacementStatus1
        {
            get => (sbyte)row["ReplacementStatus1"].Value;
            set => row["ReplacementStatus1"].Value = value;
        }

        // Unknown.
        public sbyte ReplacementStatus2
        {
            get => (sbyte)row["ReplacementStatus2"].Value;
            set => row["ReplacementStatus2"].Value = value;
        }

        // Unknown.
        public sbyte ReplacementStatus3
        {
            get => (sbyte)row["ReplacementStatus3"].Value;
            set => row["ReplacementStatus3"].Value = value;
        }

        // Unknown.
        public sbyte ReplacementStatus4
        {
            get => (sbyte)row["ReplacementStatus4"].Value;
            set => row["ReplacementStatus4"].Value = value;
        }

        // Unknown.
        public byte refCategory5
        {
            get => (byte)row["refCategory5"].Value;
            set => row["refCategory5"].Value = value;
        }

        // Unknown.
        public short consumeSA
        {
            get => (short)row["consumeSA"].Value;
            set => row["consumeSA"].Value = value;
        }

        // Unknown.
        public int ReplacementMagic1
        {
            get => (int)row["ReplacementMagic1"].Value;
            set => row["ReplacementMagic1"].Value = value;
        }

        // Unknown.
        public int ReplacementMagic2
        {
            get => (int)row["ReplacementMagic2"].Value;
            set => row["ReplacementMagic2"].Value = value;
        }

        // Unknown.
        public int ReplacementMagic3
        {
            get => (int)row["ReplacementMagic3"].Value;
            set => row["ReplacementMagic3"].Value = value;
        }

        // Unknown.
        public int ReplacementMagic4
        {
            get => (int)row["ReplacementMagic4"].Value;
            set => row["ReplacementMagic4"].Value = value;
        }

        // Unknown.
        public short mp_charge
        {
            get => (short)row["mp_charge"].Value;
            set => row["mp_charge"].Value = value;
        }

        // Unknown.
        public short stamina_charge
        {
            get => (short)row["stamina_charge"].Value;
            set => row["stamina_charge"].Value = value;
        }

        // Unknown.
        public byte createLimitGroupId
        {
            get => (byte)row["createLimitGroupId"].Value;
            set => row["createLimitGroupId"].Value = value;
        }

        // Unknown.
        public byte refCategory6
        {
            get => (byte)row["refCategory6"].Value;
            set => row["refCategory6"].Value = value;
        }

        // Unknown.
        public byte subCategory1
        {
            get => (byte)row["subCategory1"].Value;
            set => row["subCategory1"].Value = value;
        }

        // Unknown.
        public byte subCategory2
        {
            get => (byte)row["subCategory2"].Value;
            set => row["subCategory2"].Value = value;
        }

        // Unknown.
        public byte refCategory7
        {
            get => (byte)row["refCategory7"].Value;
            set => row["refCategory7"].Value = value;
        }

        // Unknown.
        public byte refCategory8
        {
            get => (byte)row["refCategory8"].Value;
            set => row["refCategory8"].Value = value;
        }

        // Unknown.
        public byte refCategory9
        {
            get => (byte)row["refCategory9"].Value;
            set => row["refCategory9"].Value = value;
        }

        // Unknown.
        public byte refCategory10
        {
            get => (byte)row["refCategory10"].Value;
            set => row["refCategory10"].Value = value;
        }

        // Unknown.
        public int refId1
        {
            get => (int)row["refId1"].Value;
            set => row["refId1"].Value = value;
        }

        // Unknown.
        public int refId2
        {
            get => (int)row["refId2"].Value;
            set => row["refId2"].Value = value;
        }

        // Unknown.
        public int refId3
        {
            get => (int)row["refId3"].Value;
            set => row["refId3"].Value = value;
        }

        // Unknown.
        public int aiUseJudgeId
        {
            get => (int)row["aiUseJudgeId"].Value;
            set => row["aiUseJudgeId"].Value = value;
        }

        // Unknown.
        public int refId4
        {
            get => (int)row["refId4"].Value;
            set => row["refId4"].Value = value;
        }

        // Unknown.
        public int refId5
        {
            get => (int)row["refId5"].Value;
            set => row["refId5"].Value = value;
        }

        // Unknown.
        public int refId6
        {
            get => (int)row["refId6"].Value;
            set => row["refId6"].Value = value;
        }

        // Unknown.
        public int refId7
        {
            get => (int)row["refId7"].Value;
            set => row["refId7"].Value = value;
        }

        // Unknown.
        public int refId8
        {
            get => (int)row["refId8"].Value;
            set => row["refId8"].Value = value;
        }

        // Unknown.
        public int refId9
        {
            get => (int)row["refId9"].Value;
            set => row["refId9"].Value = value;
        }

        // Unknown.
        public int refId10
        {
            get => (int)row["refId10"].Value;
            set => row["refId10"].Value = value;
        }

        // Unknown.
        public byte consumeType1
        {
            get => (byte)row["consumeType1"].Value;
            set => row["consumeType1"].Value = value;
        }

        // Unknown.
        public byte consumeType2
        {
            get => (byte)row["consumeType2"].Value;
            set => row["consumeType2"].Value = value;
        }

        // Unknown.
        public byte consumeType3
        {
            get => (byte)row["consumeType3"].Value;
            set => row["consumeType3"].Value = value;
        }

        // Unknown.
        public byte consumeType4
        {
            get => (byte)row["consumeType4"].Value;
            set => row["consumeType4"].Value = value;
        }

        // Unknown.
        public byte consumeType5
        {
            get => (byte)row["consumeType5"].Value;
            set => row["consumeType5"].Value = value;
        }

        // Unknown.
        public byte consumeType6
        {
            get => (byte)row["consumeType6"].Value;
            set => row["consumeType6"].Value = value;
        }

        // Unknown.
        public byte consumeType7
        {
            get => (byte)row["consumeType7"].Value;
            set => row["consumeType7"].Value = value;
        }

        // Unknown.
        public byte consumeType8
        {
            get => (byte)row["consumeType8"].Value;
            set => row["consumeType8"].Value = value;
        }

        // Unknown.
        public byte consumeType9
        {
            get => (byte)row["consumeType9"].Value;
            set => row["consumeType9"].Value = value;
        }

        // Unknown.
        public byte consumeType10
        {
            get => (byte)row["consumeType10"].Value;
            set => row["consumeType10"].Value = value;
        }

        // Unknown.
        public short consumeLoopMP_forMenu
        {
            get => (short)row["consumeLoopMP_forMenu"].Value;
            set => row["consumeLoopMP_forMenu"].Value = value;
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
    public MAGIC_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MAGIC_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
