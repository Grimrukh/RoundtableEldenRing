using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class PLAY_REGION_PARAM_ST
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
        public int matchAreaId
        {
            get => (int)row["matchAreaId"].Value;
            set => row["matchAreaId"].Value = value;
        }

        // Unknown.
        public uint multiPlayStartLimitEventFlagId
        {
            get => (uint)row["multiPlayStartLimitEventFlagId"].Value;
            set => row["multiPlayStartLimitEventFlagId"].Value = value;
        }

        // Unknown.
        public float otherDisableDistance
        {
            get => (float)row["otherDisableDistance"].Value;
            set => row["otherDisableDistance"].Value = value;
        }

        // Unknown.
        public uint pcPositionSaveLimitEventFlagId
        {
            get => (uint)row["pcPositionSaveLimitEventFlagId"].Value;
            set => row["pcPositionSaveLimitEventFlagId"].Value = value;
        }

        // Unknown.
        public uint bossAreaId
        {
            get => (uint)row["bossAreaId"].Value;
            set => row["bossAreaId"].Value = value;
        }

        // Unknown.
        public short cultNpcWhiteGhostEntityId_byFree
        {
            get => (short)row["cultNpcWhiteGhostEntityId_byFree"].Value;
            set => row["cultNpcWhiteGhostEntityId_byFree"].Value = value;
        }

        // Unknown.
        public byte bMapGuradianRegion
        {
            get => (byte)row["bMapGuradianRegion"].Value;
            set => row["bMapGuradianRegion"].Value = value;
        }

        // Unknown.
        public byte bYellowCostumeRegion
        {
            get => (byte)row["bYellowCostumeRegion"].Value;
            set => row["bYellowCostumeRegion"].Value = value;
        }

        // Unknown.
        public byte multiPlayStartLimitEventFlagId_targetFlagState
        {
            get => (byte)row["multiPlayStartLimitEventFlagId_targetFlagState"].Value;
            set => row["multiPlayStartLimitEventFlagId_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte breakInLimitEventFlagId_1_targetFlagState
        {
            get => (byte)row["breakInLimitEventFlagId_1_targetFlagState"].Value;
            set => row["breakInLimitEventFlagId_1_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte whiteSignLimitEventFlagId_1_targetFlagState
        {
            get => (byte)row["whiteSignLimitEventFlagId_1_targetFlagState"].Value;
            set => row["whiteSignLimitEventFlagId_1_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte redSignLimitEventFlagId_1_targetFlagState
        {
            get => (byte)row["redSignLimitEventFlagId_1_targetFlagState"].Value;
            set => row["redSignLimitEventFlagId_1_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte breakInLimitEventFlagId_2_targetFlagState
        {
            get => (byte)row["breakInLimitEventFlagId_2_targetFlagState"].Value;
            set => row["breakInLimitEventFlagId_2_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte breakInLimitEventFlagId_3_targetFlagState
        {
            get => (byte)row["breakInLimitEventFlagId_3_targetFlagState"].Value;
            set => row["breakInLimitEventFlagId_3_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte whiteSignLimitEventFlagId_2_targetFlagState
        {
            get => (byte)row["whiteSignLimitEventFlagId_2_targetFlagState"].Value;
            set => row["whiteSignLimitEventFlagId_2_targetFlagState"].Value = value;
        }

        // Unknown.
        public uint warpItemUsePermitBonfireId_1
        {
            get => (uint)row["warpItemUsePermitBonfireId_1"].Value;
            set => row["warpItemUsePermitBonfireId_1"].Value = value;
        }

        // Unknown.
        public uint warpItemUsePermitBonfireId_2
        {
            get => (uint)row["warpItemUsePermitBonfireId_2"].Value;
            set => row["warpItemUsePermitBonfireId_2"].Value = value;
        }

        // Unknown.
        public uint warpItemUsePermitBonfireId_3
        {
            get => (uint)row["warpItemUsePermitBonfireId_3"].Value;
            set => row["warpItemUsePermitBonfireId_3"].Value = value;
        }

        // Unknown.
        public uint warpItemUsePermitBonfireId_4
        {
            get => (uint)row["warpItemUsePermitBonfireId_4"].Value;
            set => row["warpItemUsePermitBonfireId_4"].Value = value;
        }

        // Unknown.
        public uint warpItemUsePermitBonfireId_5
        {
            get => (uint)row["warpItemUsePermitBonfireId_5"].Value;
            set => row["warpItemUsePermitBonfireId_5"].Value = value;
        }

        // Unknown.
        public uint warpItemProhibitionEventFlagId_1
        {
            get => (uint)row["warpItemProhibitionEventFlagId_1"].Value;
            set => row["warpItemProhibitionEventFlagId_1"].Value = value;
        }

        // Unknown.
        public uint warpItemProhibitionEventFlagId_2
        {
            get => (uint)row["warpItemProhibitionEventFlagId_2"].Value;
            set => row["warpItemProhibitionEventFlagId_2"].Value = value;
        }

        // Unknown.
        public uint warpItemProhibitionEventFlagId_3
        {
            get => (uint)row["warpItemProhibitionEventFlagId_3"].Value;
            set => row["warpItemProhibitionEventFlagId_3"].Value = value;
        }

        // Unknown.
        public uint warpItemProhibitionEventFlagId_4
        {
            get => (uint)row["warpItemProhibitionEventFlagId_4"].Value;
            set => row["warpItemProhibitionEventFlagId_4"].Value = value;
        }

        // Unknown.
        public uint warpItemProhibitionEventFlagId_5
        {
            get => (uint)row["warpItemProhibitionEventFlagId_5"].Value;
            set => row["warpItemProhibitionEventFlagId_5"].Value = value;
        }

        // Unknown.
        public byte enableBloodstain
        {
            get => (byte)row["enableBloodstain"].Value;
            set => row["enableBloodstain"].Value = value;
        }

        // Unknown.
        public byte enableBloodMessage
        {
            get => (byte)row["enableBloodMessage"].Value;
            set => row["enableBloodMessage"].Value = value;
        }

        // Unknown.
        public byte enableGhost
        {
            get => (byte)row["enableGhost"].Value;
            set => row["enableGhost"].Value = value;
        }

        // Unknown.
        public byte dispMask00
        {
            get => (byte)row["dispMask00"].Value;
            set => row["dispMask00"].Value = value;
        }

        // Unknown.
        public byte dispMask01
        {
            get => (byte)row["dispMask01"].Value;
            set => row["dispMask01"].Value = value;
        }

        // Unknown.
        public byte whiteSignLimitEventFlagId_3_targetFlagState
        {
            get => (byte)row["whiteSignLimitEventFlagId_3_targetFlagState"].Value;
            set => row["whiteSignLimitEventFlagId_3_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte redSignLimitEventFlagId_2_targetFlagState
        {
            get => (byte)row["redSignLimitEventFlagId_2_targetFlagState"].Value;
            set => row["redSignLimitEventFlagId_2_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte redSignLimitEventFlagId_3_targetFlagState
        {
            get => (byte)row["redSignLimitEventFlagId_3_targetFlagState"].Value;
            set => row["redSignLimitEventFlagId_3_targetFlagState"].Value = value;
        }

        // Unknown.
        public byte isAutoIntrudePoint
        {
            get => (byte)row["isAutoIntrudePoint"].Value;
            set => row["isAutoIntrudePoint"].Value = value;
        }

        // Unknown.
        public uint multiPlayHASHostLimitEventFlagId
        {
            get => (uint)row["multiPlayHASHostLimitEventFlagId"].Value;
            set => row["multiPlayHASHostLimitEventFlagId"].Value = value;
        }

        // Unknown.
        public float otherMaxDistance
        {
            get => (float)row["otherMaxDistance"].Value;
            set => row["otherMaxDistance"].Value = value;
        }

        // Unknown.
        public uint signPuddleOpenEventFlagId
        {
            get => (uint)row["signPuddleOpenEventFlagId"].Value;
            set => row["signPuddleOpenEventFlagId"].Value = value;
        }

        // Unknown.
        public byte areaNo
        {
            get => (byte)row["areaNo"].Value;
            set => row["areaNo"].Value = value;
        }

        // Unknown.
        public byte gridXNo
        {
            get => (byte)row["gridXNo"].Value;
            set => row["gridXNo"].Value = value;
        }

        // Unknown.
        public byte gridZNo
        {
            get => (byte)row["gridZNo"].Value;
            set => row["gridZNo"].Value = value;
        }

        // Unknown.
        public float posX
        {
            get => (float)row["posX"].Value;
            set => row["posX"].Value = value;
        }

        // Unknown.
        public float posY
        {
            get => (float)row["posY"].Value;
            set => row["posY"].Value = value;
        }

        // Unknown.
        public float posZ
        {
            get => (float)row["posZ"].Value;
            set => row["posZ"].Value = value;
        }

        // Unknown.
        public uint breakInLimitEventFlagId_1
        {
            get => (uint)row["breakInLimitEventFlagId_1"].Value;
            set => row["breakInLimitEventFlagId_1"].Value = value;
        }

        // Unknown.
        public uint whiteSignLimitEventFlagId_1
        {
            get => (uint)row["whiteSignLimitEventFlagId_1"].Value;
            set => row["whiteSignLimitEventFlagId_1"].Value = value;
        }

        // Unknown.
        public uint matchAreaSignCreateLimitEventFlagId
        {
            get => (uint)row["matchAreaSignCreateLimitEventFlagId"].Value;
            set => row["matchAreaSignCreateLimitEventFlagId"].Value = value;
        }

        // Unknown.
        public uint signAimId_1
        {
            get => (uint)row["signAimId_1"].Value;
            set => row["signAimId_1"].Value = value;
        }

        // Unknown.
        public uint signAimId_2
        {
            get => (uint)row["signAimId_2"].Value;
            set => row["signAimId_2"].Value = value;
        }

        // Unknown.
        public uint signAimId_3
        {
            get => (uint)row["signAimId_3"].Value;
            set => row["signAimId_3"].Value = value;
        }

        // Unknown.
        public uint signAimId_4
        {
            get => (uint)row["signAimId_4"].Value;
            set => row["signAimId_4"].Value = value;
        }

        // Unknown.
        public uint signAimId_5
        {
            get => (uint)row["signAimId_5"].Value;
            set => row["signAimId_5"].Value = value;
        }

        // Unknown.
        public uint signAimId_6
        {
            get => (uint)row["signAimId_6"].Value;
            set => row["signAimId_6"].Value = value;
        }

        // Unknown.
        public uint signAimId_7
        {
            get => (uint)row["signAimId_7"].Value;
            set => row["signAimId_7"].Value = value;
        }

        // Unknown.
        public uint signAimId_8
        {
            get => (uint)row["signAimId_8"].Value;
            set => row["signAimId_8"].Value = value;
        }

        // Unknown.
        public uint redSignLimitEventFlagId_1
        {
            get => (uint)row["redSignLimitEventFlagId_1"].Value;
            set => row["redSignLimitEventFlagId_1"].Value = value;
        }

        // Unknown.
        public uint breakInLimitEventFlagId_2
        {
            get => (uint)row["breakInLimitEventFlagId_2"].Value;
            set => row["breakInLimitEventFlagId_2"].Value = value;
        }

        // Unknown.
        public uint breakInLimitEventFlagId_3
        {
            get => (uint)row["breakInLimitEventFlagId_3"].Value;
            set => row["breakInLimitEventFlagId_3"].Value = value;
        }

        // Unknown.
        public uint whiteSignLimitEventFlagId_2
        {
            get => (uint)row["whiteSignLimitEventFlagId_2"].Value;
            set => row["whiteSignLimitEventFlagId_2"].Value = value;
        }

        // Unknown.
        public uint whiteSignLimitEventFlagId_3
        {
            get => (uint)row["whiteSignLimitEventFlagId_3"].Value;
            set => row["whiteSignLimitEventFlagId_3"].Value = value;
        }

        // Unknown.
        public uint redSignLimitEventFlagId_2
        {
            get => (uint)row["redSignLimitEventFlagId_2"].Value;
            set => row["redSignLimitEventFlagId_2"].Value = value;
        }

        // Unknown.
        public uint redSignLimitEventFlagId_3
        {
            get => (uint)row["redSignLimitEventFlagId_3"].Value;
            set => row["redSignLimitEventFlagId_3"].Value = value;
        }

        // Unknown.
        public uint bossId_1
        {
            get => (uint)row["bossId_1"].Value;
            set => row["bossId_1"].Value = value;
        }

        // Unknown.
        public uint bossId_2
        {
            get => (uint)row["bossId_2"].Value;
            set => row["bossId_2"].Value = value;
        }

        // Unknown.
        public uint bossId_3
        {
            get => (uint)row["bossId_3"].Value;
            set => row["bossId_3"].Value = value;
        }

        // Unknown.
        public uint bossId_4
        {
            get => (uint)row["bossId_4"].Value;
            set => row["bossId_4"].Value = value;
        }

        // Unknown.
        public uint bossId_5
        {
            get => (uint)row["bossId_5"].Value;
            set => row["bossId_5"].Value = value;
        }

        // Unknown.
        public uint bossId_6
        {
            get => (uint)row["bossId_6"].Value;
            set => row["bossId_6"].Value = value;
        }

        // Unknown.
        public uint bossId_7
        {
            get => (uint)row["bossId_7"].Value;
            set => row["bossId_7"].Value = value;
        }

        // Unknown.
        public uint bossId_8
        {
            get => (uint)row["bossId_8"].Value;
            set => row["bossId_8"].Value = value;
        }

        // Unknown.
        public uint bossId_9
        {
            get => (uint)row["bossId_9"].Value;
            set => row["bossId_9"].Value = value;
        }

        // Unknown.
        public uint bossId_10
        {
            get => (uint)row["bossId_10"].Value;
            set => row["bossId_10"].Value = value;
        }

        // Unknown.
        public uint bossId_11
        {
            get => (uint)row["bossId_11"].Value;
            set => row["bossId_11"].Value = value;
        }

        // Unknown.
        public uint bossId_12
        {
            get => (uint)row["bossId_12"].Value;
            set => row["bossId_12"].Value = value;
        }

        // Unknown.
        public uint bossId_13
        {
            get => (uint)row["bossId_13"].Value;
            set => row["bossId_13"].Value = value;
        }

        // Unknown.
        public uint bossId_14
        {
            get => (uint)row["bossId_14"].Value;
            set => row["bossId_14"].Value = value;
        }

        // Unknown.
        public uint bossId_15
        {
            get => (uint)row["bossId_15"].Value;
            set => row["bossId_15"].Value = value;
        }

        // Unknown.
        public uint bossId_16
        {
            get => (uint)row["bossId_16"].Value;
            set => row["bossId_16"].Value = value;
        }

        // Unknown.
        public uint mapMenuUnlockEventId
        {
            get => (uint)row["mapMenuUnlockEventId"].Value;
            set => row["mapMenuUnlockEventId"].Value = value;
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
    public PLAY_REGION_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public PLAY_REGION_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
