using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class PLAYER_COMMON_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int playerFootEffect_bySFX
        {
            get => (int)row["playerFootEffect_bySFX"].Value;
            set => row["playerFootEffect_bySFX"].Value = value;
        }

        // Unknown.
        public float snipeModeDrawAlpha_FadeTime
        {
            get => (float)row["snipeModeDrawAlpha_FadeTime"].Value;
            set => row["snipeModeDrawAlpha_FadeTime"].Value = value;
        }

        // Unknown.
        public float toughnessRecoverCorrection
        {
            get => (float)row["toughnessRecoverCorrection"].Value;
            set => row["toughnessRecoverCorrection"].Value = value;
        }

        // Unknown.
        public byte baseMagicSlotSize
        {
            get => (byte)row["baseMagicSlotSize"].Value;
            set => row["baseMagicSlotSize"].Value = value;
        }

        // Unknown.
        public byte baseAccSlotNum
        {
            get => (byte)row["baseAccSlotNum"].Value;
            set => row["baseAccSlotNum"].Value = value;
        }

        // Unknown.
        public int animeID_DropItemPick
        {
            get => (int)row["animeID_DropItemPick"].Value;
            set => row["animeID_DropItemPick"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Sleep_Player
        {
            get => (float)row["resistRecoverPoint_Sleep_Player"].Value;
            set => row["resistRecoverPoint_Sleep_Player"].Value = value;
        }

        // Unknown.
        public int flareOverrideHomingAngle
        {
            get => (int)row["flareOverrideHomingAngle"].Value;
            set => row["flareOverrideHomingAngle"].Value = value;
        }

        // Unknown.
        public float flareOverrideHomingStopRange
        {
            get => (float)row["flareOverrideHomingStopRange"].Value;
            set => row["flareOverrideHomingStopRange"].Value = value;
        }

        // Unknown.
        public int animeID_SleepCollectorItemPick
        {
            get => (int)row["animeID_SleepCollectorItemPick"].Value;
            set => row["animeID_SleepCollectorItemPick"].Value = value;
        }

        // Unknown.
        public uint unlockEventFlagBaseId_forWepAttr
        {
            get => (uint)row["unlockEventFlagBaseId_forWepAttr"].Value;
            set => row["unlockEventFlagBaseId_forWepAttr"].Value = value;
        }

        // Unknown.
        public int systemEnchant_BigRune
        {
            get => (int)row["systemEnchant_BigRune"].Value;
            set => row["systemEnchant_BigRune"].Value = value;
        }

        // Unknown.
        public float lowStatus_AtkPowDown
        {
            get => (float)row["lowStatus_AtkPowDown"].Value;
            set => row["lowStatus_AtkPowDown"].Value = value;
        }

        // Unknown.
        public float lowStatus_ConsumeStaminaRate
        {
            get => (float)row["lowStatus_ConsumeStaminaRate"].Value;
            set => row["lowStatus_ConsumeStaminaRate"].Value = value;
        }

        // Unknown.
        public short lowStatus_AtkGuardBreak
        {
            get => (short)row["lowStatus_AtkGuardBreak"].Value;
            set => row["lowStatus_AtkGuardBreak"].Value = value;
        }

        // Unknown.
        public short guardStatusCorrect_MaxStatusVal
        {
            get => (short)row["guardStatusCorrect_MaxStatusVal"].Value;
            set => row["guardStatusCorrect_MaxStatusVal"].Value = value;
        }

        // Unknown.
        public ushort unlockEventFlagStepNum_forWepAttr
        {
            get => (ushort)row["unlockEventFlagStepNum_forWepAttr"].Value;
            set => row["unlockEventFlagStepNum_forWepAttr"].Value = value;
        }

        // Unknown.
        public ushort retributionMagic_damageCountNum
        {
            get => (ushort)row["retributionMagic_damageCountNum"].Value;
            set => row["retributionMagic_damageCountNum"].Value = value;
        }

        // Unknown.
        public ushort retributionMagic_damageCountRemainTime
        {
            get => (ushort)row["retributionMagic_damageCountRemainTime"].Value;
            set => row["retributionMagic_damageCountRemainTime"].Value = value;
        }

        // Unknown.
        public ushort retributionMagic_burstDmypolyId
        {
            get => (ushort)row["retributionMagic_burstDmypolyId"].Value;
            set => row["retributionMagic_burstDmypolyId"].Value = value;
        }

        // Unknown.
        public int retributionMagic_burstMagicParamId
        {
            get => (int)row["retributionMagic_burstMagicParamId"].Value;
            set => row["retributionMagic_burstMagicParamId"].Value = value;
        }

        // Unknown.
        public float chrAimCam_rideOffsetHeight
        {
            get => (float)row["chrAimCam_rideOffsetHeight"].Value;
            set => row["chrAimCam_rideOffsetHeight"].Value = value;
        }

        // Unknown.
        public int arrowCaseWepBindDmypolyId
        {
            get => (int)row["arrowCaseWepBindDmypolyId"].Value;
            set => row["arrowCaseWepBindDmypolyId"].Value = value;
        }

        // Unknown.
        public int boltPouchWepBindDmypolyId
        {
            get => (int)row["boltPouchWepBindDmypolyId"].Value;
            set => row["boltPouchWepBindDmypolyId"].Value = value;
        }

        // Unknown.
        public float estusFlaskAllocateRate
        {
            get => (float)row["estusFlaskAllocateRate"].Value;
            set => row["estusFlaskAllocateRate"].Value = value;
        }

        // Unknown.
        public byte kickAcceptanceDeg
        {
            get => (byte)row["kickAcceptanceDeg"].Value;
            set => row["kickAcceptanceDeg"].Value = value;
        }

        // Unknown.
        public byte npcPlayerAnalogWeightRate_Light
        {
            get => (byte)row["npcPlayerAnalogWeightRate_Light"].Value;
            set => row["npcPlayerAnalogWeightRate_Light"].Value = value;
        }

        // Unknown.
        public byte npcPlayerAnalogWeightRate_Normal
        {
            get => (byte)row["npcPlayerAnalogWeightRate_Normal"].Value;
            set => row["npcPlayerAnalogWeightRate_Normal"].Value = value;
        }

        // Unknown.
        public byte npcPlayerAnalogWeightRate_Heavy
        {
            get => (byte)row["npcPlayerAnalogWeightRate_Heavy"].Value;
            set => row["npcPlayerAnalogWeightRate_Heavy"].Value = value;
        }

        // Unknown.
        public byte npcPlayerAnalogWeightRate_WeightOver
        {
            get => (byte)row["npcPlayerAnalogWeightRate_WeightOver"].Value;
            set => row["npcPlayerAnalogWeightRate_WeightOver"].Value = value;
        }

        // Unknown.
        public byte npcPlayerAnalogWeightRate_SuperLight
        {
            get => (byte)row["npcPlayerAnalogWeightRate_SuperLight"].Value;
            set => row["npcPlayerAnalogWeightRate_SuperLight"].Value = value;
        }

        // Unknown.
        public int clearCountCorrectBaseSpEffectId
        {
            get => (int)row["clearCountCorrectBaseSpEffectId"].Value;
            set => row["clearCountCorrectBaseSpEffectId"].Value = value;
        }

        // Unknown.
        public int arrowBoltModelIdOffset
        {
            get => (int)row["arrowBoltModelIdOffset"].Value;
            set => row["arrowBoltModelIdOffset"].Value = value;
        }

        // Unknown.
        public sbyte arrowBoltRemainingNumModelMaskThreshold1
        {
            get => (sbyte)row["arrowBoltRemainingNumModelMaskThreshold1"].Value;
            set => row["arrowBoltRemainingNumModelMaskThreshold1"].Value = value;
        }

        // Unknown.
        public sbyte arrowBoltRemainingNumModelMaskThreshold2
        {
            get => (sbyte)row["arrowBoltRemainingNumModelMaskThreshold2"].Value;
            set => row["arrowBoltRemainingNumModelMaskThreshold2"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Poision_Player
        {
            get => (float)row["resistRecoverPoint_Poision_Player"].Value;
            set => row["resistRecoverPoint_Poision_Player"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Desease_Player
        {
            get => (float)row["resistRecoverPoint_Desease_Player"].Value;
            set => row["resistRecoverPoint_Desease_Player"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Blood_Player
        {
            get => (float)row["resistRecoverPoint_Blood_Player"].Value;
            set => row["resistRecoverPoint_Blood_Player"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Curse_Player
        {
            get => (float)row["resistRecoverPoint_Curse_Player"].Value;
            set => row["resistRecoverPoint_Curse_Player"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Freeze_Player
        {
            get => (float)row["resistRecoverPoint_Freeze_Player"].Value;
            set => row["resistRecoverPoint_Freeze_Player"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Poision_Enemy
        {
            get => (float)row["resistRecoverPoint_Poision_Enemy"].Value;
            set => row["resistRecoverPoint_Poision_Enemy"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Desease_Enemy
        {
            get => (float)row["resistRecoverPoint_Desease_Enemy"].Value;
            set => row["resistRecoverPoint_Desease_Enemy"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Blood_Enemy
        {
            get => (float)row["resistRecoverPoint_Blood_Enemy"].Value;
            set => row["resistRecoverPoint_Blood_Enemy"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Curse_Enemy
        {
            get => (float)row["resistRecoverPoint_Curse_Enemy"].Value;
            set => row["resistRecoverPoint_Curse_Enemy"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Freeze_Enemy
        {
            get => (float)row["resistRecoverPoint_Freeze_Enemy"].Value;
            set => row["resistRecoverPoint_Freeze_Enemy"].Value = value;
        }

        // Unknown.
        public float requestTimeLeftBothHand
        {
            get => (float)row["requestTimeLeftBothHand"].Value;
            set => row["requestTimeLeftBothHand"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Madness_Player
        {
            get => (float)row["resistRecoverPoint_Madness_Player"].Value;
            set => row["resistRecoverPoint_Madness_Player"].Value = value;
        }

        // Unknown.
        public int animeID_MaterialItemPick
        {
            get => (int)row["animeID_MaterialItemPick"].Value;
            set => row["animeID_MaterialItemPick"].Value = value;
        }

        // Unknown.
        public float hpEstusFlaskAllocateRateForYellowMonk
        {
            get => (float)row["hpEstusFlaskAllocateRateForYellowMonk"].Value;
            set => row["hpEstusFlaskAllocateRateForYellowMonk"].Value = value;
        }

        // Unknown.
        public int hpEstusFlaskAllocateOffsetForYellowMonk
        {
            get => (int)row["hpEstusFlaskAllocateOffsetForYellowMonk"].Value;
            set => row["hpEstusFlaskAllocateOffsetForYellowMonk"].Value = value;
        }

        // Unknown.
        public float mpEstusFlaskAllocateRateForYellowMonk
        {
            get => (float)row["mpEstusFlaskAllocateRateForYellowMonk"].Value;
            set => row["mpEstusFlaskAllocateRateForYellowMonk"].Value = value;
        }

        // Unknown.
        public int mpEstusFlaskAllocateOffsetForYellowMonk
        {
            get => (int)row["mpEstusFlaskAllocateOffsetForYellowMonk"].Value;
            set => row["mpEstusFlaskAllocateOffsetForYellowMonk"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Sleep_Enemy
        {
            get => (float)row["resistRecoverPoint_Sleep_Enemy"].Value;
            set => row["resistRecoverPoint_Sleep_Enemy"].Value = value;
        }

        // Unknown.
        public float resistRecoverPoint_Madness_Enemy
        {
            get => (float)row["resistRecoverPoint_Madness_Enemy"].Value;
            set => row["resistRecoverPoint_Madness_Enemy"].Value = value;
        }

        // Unknown.
        public int resistCurseItemId
        {
            get => (int)row["resistCurseItemId"].Value;
            set => row["resistCurseItemId"].Value = value;
        }

        // Unknown.
        public byte resistCurseItemMaxNum
        {
            get => (byte)row["resistCurseItemMaxNum"].Value;
            set => row["resistCurseItemMaxNum"].Value = value;
        }

        // Unknown.
        public int resistCurseItemSpEffectBaseId
        {
            get => (int)row["resistCurseItemSpEffectBaseId"].Value;
            set => row["resistCurseItemSpEffectBaseId"].Value = value;
        }

        // Unknown.
        public int resistCurseItemLotParamId_map
        {
            get => (int)row["resistCurseItemLotParamId_map"].Value;
            set => row["resistCurseItemLotParamId_map"].Value = value;
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
    public PLAYER_COMMON_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public PLAYER_COMMON_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
