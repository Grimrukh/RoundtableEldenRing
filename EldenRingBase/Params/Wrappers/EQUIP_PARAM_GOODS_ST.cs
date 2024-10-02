using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class EQUIP_PARAM_GOODS_ST
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
        public int refId_default
        {
            get => (int)row["refId_default"].Value;
            set => row["refId_default"].Value = value;
        }

        // Unknown.
        public int sfxVariationId
        {
            get => (int)row["sfxVariationId"].Value;
            set => row["sfxVariationId"].Value = value;
        }

        // Unknown.
        public float weight
        {
            get => (float)row["weight"].Value;
            set => row["weight"].Value = value;
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
        public int behaviorId
        {
            get => (int)row["behaviorId"].Value;
            set => row["behaviorId"].Value = value;
        }

        // Unknown.
        public int replaceItemId
        {
            get => (int)row["replaceItemId"].Value;
            set => row["replaceItemId"].Value = value;
        }

        // Unknown.
        public int sortId
        {
            get => (int)row["sortId"].Value;
            set => row["sortId"].Value = value;
        }

        // Unknown.
        public int appearanceReplaceItemId
        {
            get => (int)row["appearanceReplaceItemId"].Value;
            set => row["appearanceReplaceItemId"].Value = value;
        }

        // Unknown.
        public int yesNoDialogMessageId
        {
            get => (int)row["yesNoDialogMessageId"].Value;
            set => row["yesNoDialogMessageId"].Value = value;
        }

        // Unknown.
        public ushort useEnableSpEffectType
        {
            get => (ushort)row["useEnableSpEffectType"].Value;
            set => row["useEnableSpEffectType"].Value = value;
        }

        // Unknown.
        public sbyte potGroupId
        {
            get => (sbyte)row["potGroupId"].Value;
            set => row["potGroupId"].Value = value;
        }

        // Unknown.
        public ushort iconId
        {
            get => (ushort)row["iconId"].Value;
            set => row["iconId"].Value = value;
        }

        // Unknown.
        public ushort modelId
        {
            get => (ushort)row["modelId"].Value;
            set => row["modelId"].Value = value;
        }

        // Unknown.
        public short shopLv
        {
            get => (short)row["shopLv"].Value;
            set => row["shopLv"].Value = value;
        }

        // Unknown.
        public short compTrophySedId
        {
            get => (short)row["compTrophySedId"].Value;
            set => row["compTrophySedId"].Value = value;
        }

        // Unknown.
        public short trophySeqId
        {
            get => (short)row["trophySeqId"].Value;
            set => row["trophySeqId"].Value = value;
        }

        // Unknown.
        public short maxNum
        {
            get => (short)row["maxNum"].Value;
            set => row["maxNum"].Value = value;
        }

        // Unknown.
        public byte consumeHeroPoint
        {
            get => (byte)row["consumeHeroPoint"].Value;
            set => row["consumeHeroPoint"].Value = value;
        }

        // Unknown.
        public byte overDexterity
        {
            get => (byte)row["overDexterity"].Value;
            set => row["overDexterity"].Value = value;
        }

        // Unknown.
        public byte goodsType
        {
            get => (byte)row["goodsType"].Value;
            set => row["goodsType"].Value = value;
        }

        // Unknown.
        public byte refCategory
        {
            get => (byte)row["refCategory"].Value;
            set => row["refCategory"].Value = value;
        }

        // Unknown.
        public byte spEffectCategory
        {
            get => (byte)row["spEffectCategory"].Value;
            set => row["spEffectCategory"].Value = value;
        }

        // Unknown.
        public byte goodsUseAnim
        {
            get => (byte)row["goodsUseAnim"].Value;
            set => row["goodsUseAnim"].Value = value;
        }

        // Unknown.
        public byte opmeMenuType
        {
            get => (byte)row["opmeMenuType"].Value;
            set => row["opmeMenuType"].Value = value;
        }

        // Unknown.
        public byte useLimitCategory
        {
            get => (byte)row["useLimitCategory"].Value;
            set => row["useLimitCategory"].Value = value;
        }

        // Unknown.
        public byte replaceCategory
        {
            get => (byte)row["replaceCategory"].Value;
            set => row["replaceCategory"].Value = value;
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
        public byte enable_multi
        {
            get => (byte)row["enable_multi"].Value;
            set => row["enable_multi"].Value = value;
        }

        // Unknown.
        public byte disable_offline
        {
            get => (byte)row["disable_offline"].Value;
            set => row["disable_offline"].Value = value;
        }

        // Unknown.
        public byte isEquip
        {
            get => (byte)row["isEquip"].Value;
            set => row["isEquip"].Value = value;
        }

        // Unknown.
        public byte isConsume
        {
            get => (byte)row["isConsume"].Value;
            set => row["isConsume"].Value = value;
        }

        // Unknown.
        public byte isAutoEquip
        {
            get => (byte)row["isAutoEquip"].Value;
            set => row["isAutoEquip"].Value = value;
        }

        // Unknown.
        public byte isEstablishment
        {
            get => (byte)row["isEstablishment"].Value;
            set => row["isEstablishment"].Value = value;
        }

        // Unknown.
        public byte isOnlyOne
        {
            get => (byte)row["isOnlyOne"].Value;
            set => row["isOnlyOne"].Value = value;
        }

        // Unknown.
        public byte isDiscard
        {
            get => (byte)row["isDiscard"].Value;
            set => row["isDiscard"].Value = value;
        }

        // Unknown.
        public byte isDeposit
        {
            get => (byte)row["isDeposit"].Value;
            set => row["isDeposit"].Value = value;
        }

        // Unknown.
        public byte isDisableHand
        {
            get => (byte)row["isDisableHand"].Value;
            set => row["isDisableHand"].Value = value;
        }

        // Unknown.
        public byte isRemoveItem_forGameClear
        {
            get => (byte)row["isRemoveItem_forGameClear"].Value;
            set => row["isRemoveItem_forGameClear"].Value = value;
        }

        // Unknown.
        public byte isSuppleItem
        {
            get => (byte)row["isSuppleItem"].Value;
            set => row["isSuppleItem"].Value = value;
        }

        // Unknown.
        public byte isFullSuppleItem
        {
            get => (byte)row["isFullSuppleItem"].Value;
            set => row["isFullSuppleItem"].Value = value;
        }

        // Unknown.
        public byte isEnhance
        {
            get => (byte)row["isEnhance"].Value;
            set => row["isEnhance"].Value = value;
        }

        // Unknown.
        public byte isFixItem
        {
            get => (byte)row["isFixItem"].Value;
            set => row["isFixItem"].Value = value;
        }

        // Unknown.
        public byte disableMultiDropShare
        {
            get => (byte)row["disableMultiDropShare"].Value;
            set => row["disableMultiDropShare"].Value = value;
        }

        // Unknown.
        public byte disableUseAtColiseum
        {
            get => (byte)row["disableUseAtColiseum"].Value;
            set => row["disableUseAtColiseum"].Value = value;
        }

        // Unknown.
        public byte disableUseAtOutOfColiseum
        {
            get => (byte)row["disableUseAtOutOfColiseum"].Value;
            set => row["disableUseAtOutOfColiseum"].Value = value;
        }

        // Unknown.
        public byte isEnableFastUseItem
        {
            get => (byte)row["isEnableFastUseItem"].Value;
            set => row["isEnableFastUseItem"].Value = value;
        }

        // Unknown.
        public byte isApplySpecialEffect
        {
            get => (byte)row["isApplySpecialEffect"].Value;
            set => row["isApplySpecialEffect"].Value = value;
        }

        // Unknown.
        public byte syncNumVaryId
        {
            get => (byte)row["syncNumVaryId"].Value;
            set => row["syncNumVaryId"].Value = value;
        }

        // Unknown.
        public int refId_1
        {
            get => (int)row["refId_1"].Value;
            set => row["refId_1"].Value = value;
        }

        // Unknown.
        public int refVirtualWepId
        {
            get => (int)row["refVirtualWepId"].Value;
            set => row["refVirtualWepId"].Value = value;
        }

        // Unknown.
        public int vagrantItemLotId
        {
            get => (int)row["vagrantItemLotId"].Value;
            set => row["vagrantItemLotId"].Value = value;
        }

        // Unknown.
        public int vagrantBonusEneDropItemLotId
        {
            get => (int)row["vagrantBonusEneDropItemLotId"].Value;
            set => row["vagrantBonusEneDropItemLotId"].Value = value;
        }

        // Unknown.
        public int vagrantItemEneDropItemLotId
        {
            get => (int)row["vagrantItemEneDropItemLotId"].Value;
            set => row["vagrantItemEneDropItemLotId"].Value = value;
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
        public byte enable_ActiveBigRune
        {
            get => (byte)row["enable_ActiveBigRune"].Value;
            set => row["enable_ActiveBigRune"].Value = value;
        }

        // Unknown.
        public byte isBonfireWarpItem
        {
            get => (byte)row["isBonfireWarpItem"].Value;
            set => row["isBonfireWarpItem"].Value = value;
        }

        // Unknown.
        public byte enable_Ladder
        {
            get => (byte)row["enable_Ladder"].Value;
            set => row["enable_Ladder"].Value = value;
        }

        // Unknown.
        public byte isUseMultiPlayPreparation
        {
            get => (byte)row["isUseMultiPlayPreparation"].Value;
            set => row["isUseMultiPlayPreparation"].Value = value;
        }

        // Unknown.
        public byte canMultiUse
        {
            get => (byte)row["canMultiUse"].Value;
            set => row["canMultiUse"].Value = value;
        }

        // Unknown.
        public byte isShieldEnchant
        {
            get => (byte)row["isShieldEnchant"].Value;
            set => row["isShieldEnchant"].Value = value;
        }

        // Unknown.
        public byte isWarpProhibited
        {
            get => (byte)row["isWarpProhibited"].Value;
            set => row["isWarpProhibited"].Value = value;
        }

        // Unknown.
        public byte isUseMultiPenaltyOnly
        {
            get => (byte)row["isUseMultiPenaltyOnly"].Value;
            set => row["isUseMultiPenaltyOnly"].Value = value;
        }

        // Unknown.
        public byte suppleType
        {
            get => (byte)row["suppleType"].Value;
            set => row["suppleType"].Value = value;
        }

        // Unknown.
        public byte autoReplenishType
        {
            get => (byte)row["autoReplenishType"].Value;
            set => row["autoReplenishType"].Value = value;
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
        public byte isSummonHorse
        {
            get => (byte)row["isSummonHorse"].Value;
            set => row["isSummonHorse"].Value = value;
        }

        // Unknown.
        public byte showDialogCondType
        {
            get => (byte)row["showDialogCondType"].Value;
            set => row["showDialogCondType"].Value = value;
        }

        // Unknown.
        public byte isSleepCollectionItem
        {
            get => (byte)row["isSleepCollectionItem"].Value;
            set => row["isSleepCollectionItem"].Value = value;
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
        public short maxRepositoryNum
        {
            get => (short)row["maxRepositoryNum"].Value;
            set => row["maxRepositoryNum"].Value = value;
        }

        // Unknown.
        public byte sortGroupId
        {
            get => (byte)row["sortGroupId"].Value;
            set => row["sortGroupId"].Value = value;
        }

        // Unknown.
        public byte isUseNoAttackRegion
        {
            get => (byte)row["isUseNoAttackRegion"].Value;
            set => row["isUseNoAttackRegion"].Value = value;
        }

        // Unknown.
        public int saleValue
        {
            get => (int)row["saleValue"].Value;
            set => row["saleValue"].Value = value;
        }

        // Unknown.
        public byte rarity
        {
            get => (byte)row["rarity"].Value;
            set => row["rarity"].Value = value;
        }

        // Unknown.
        public byte useLimitSummonBuddy
        {
            get => (byte)row["useLimitSummonBuddy"].Value;
            set => row["useLimitSummonBuddy"].Value = value;
        }

        // Unknown.
        public ushort useLimitSpEffectType
        {
            get => (ushort)row["useLimitSpEffectType"].Value;
            set => row["useLimitSpEffectType"].Value = value;
        }

        // Unknown.
        public int aiUseJudgeId
        {
            get => (int)row["aiUseJudgeId"].Value;
            set => row["aiUseJudgeId"].Value = value;
        }

        // Unknown.
        public short consumeMP
        {
            get => (short)row["consumeMP"].Value;
            set => row["consumeMP"].Value = value;
        }

        // Unknown.
        public short consumeHP
        {
            get => (short)row["consumeHP"].Value;
            set => row["consumeHP"].Value = value;
        }

        // Unknown.
        public int reinforceGoodsId
        {
            get => (int)row["reinforceGoodsId"].Value;
            set => row["reinforceGoodsId"].Value = value;
        }

        // Unknown.
        public int reinforceMaterialId
        {
            get => (int)row["reinforceMaterialId"].Value;
            set => row["reinforceMaterialId"].Value = value;
        }

        // Unknown.
        public int reinforcePrice
        {
            get => (int)row["reinforcePrice"].Value;
            set => row["reinforcePrice"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType0
        {
            get => (sbyte)row["useLevel_vowType0"].Value;
            set => row["useLevel_vowType0"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType1
        {
            get => (sbyte)row["useLevel_vowType1"].Value;
            set => row["useLevel_vowType1"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType2
        {
            get => (sbyte)row["useLevel_vowType2"].Value;
            set => row["useLevel_vowType2"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType3
        {
            get => (sbyte)row["useLevel_vowType3"].Value;
            set => row["useLevel_vowType3"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType4
        {
            get => (sbyte)row["useLevel_vowType4"].Value;
            set => row["useLevel_vowType4"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType5
        {
            get => (sbyte)row["useLevel_vowType5"].Value;
            set => row["useLevel_vowType5"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType6
        {
            get => (sbyte)row["useLevel_vowType6"].Value;
            set => row["useLevel_vowType6"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType7
        {
            get => (sbyte)row["useLevel_vowType7"].Value;
            set => row["useLevel_vowType7"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType8
        {
            get => (sbyte)row["useLevel_vowType8"].Value;
            set => row["useLevel_vowType8"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType9
        {
            get => (sbyte)row["useLevel_vowType9"].Value;
            set => row["useLevel_vowType9"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType10
        {
            get => (sbyte)row["useLevel_vowType10"].Value;
            set => row["useLevel_vowType10"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType11
        {
            get => (sbyte)row["useLevel_vowType11"].Value;
            set => row["useLevel_vowType11"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType12
        {
            get => (sbyte)row["useLevel_vowType12"].Value;
            set => row["useLevel_vowType12"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType13
        {
            get => (sbyte)row["useLevel_vowType13"].Value;
            set => row["useLevel_vowType13"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType14
        {
            get => (sbyte)row["useLevel_vowType14"].Value;
            set => row["useLevel_vowType14"].Value = value;
        }

        // Unknown.
        public sbyte useLevel_vowType15
        {
            get => (sbyte)row["useLevel_vowType15"].Value;
            set => row["useLevel_vowType15"].Value = value;
        }

        // Unknown.
        public ushort useLevel
        {
            get => (ushort)row["useLevel"].Value;
            set => row["useLevel"].Value = value;
        }

        // Unknown.
        public uint itemGetTutorialFlagId
        {
            get => (uint)row["itemGetTutorialFlagId"].Value;
            set => row["itemGetTutorialFlagId"].Value = value;
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
    public EQUIP_PARAM_GOODS_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public EQUIP_PARAM_GOODS_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
