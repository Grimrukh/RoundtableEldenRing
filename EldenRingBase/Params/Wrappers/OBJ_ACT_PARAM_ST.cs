using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class OBJ_ACT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int actionEnableMsgId
        {
            get => (int)row["actionEnableMsgId"].Value;
            set => row["actionEnableMsgId"].Value = value;
        }

        // Unknown.
        public int actionFailedMsgId
        {
            get => (int)row["actionFailedMsgId"].Value;
            set => row["actionFailedMsgId"].Value = value;
        }

        // Unknown.
        public uint spQualifiedPassEventFlag
        {
            get => (uint)row["spQualifiedPassEventFlag"].Value;
            set => row["spQualifiedPassEventFlag"].Value = value;
        }

        // Unknown.
        public uint playerAnimId
        {
            get => (uint)row["playerAnimId"].Value;
            set => row["playerAnimId"].Value = value;
        }

        // Unknown.
        public uint chrAnimId
        {
            get => (uint)row["chrAnimId"].Value;
            set => row["chrAnimId"].Value = value;
        }

        // Unknown.
        public ushort validDist
        {
            get => (ushort)row["validDist"].Value;
            set => row["validDist"].Value = value;
        }

        // Unknown.
        public ushort spQualifiedId
        {
            get => (ushort)row["spQualifiedId"].Value;
            set => row["spQualifiedId"].Value = value;
        }

        // Unknown.
        public ushort spQualifiedId2
        {
            get => (ushort)row["spQualifiedId2"].Value;
            set => row["spQualifiedId2"].Value = value;
        }

        // Unknown.
        public byte objDummyId
        {
            get => (byte)row["objDummyId"].Value;
            set => row["objDummyId"].Value = value;
        }

        // Unknown.
        public byte isEventKickSync
        {
            get => (byte)row["isEventKickSync"].Value;
            set => row["isEventKickSync"].Value = value;
        }

        // Unknown.
        public uint objAnimId
        {
            get => (uint)row["objAnimId"].Value;
            set => row["objAnimId"].Value = value;
        }

        // Unknown.
        public byte validPlayerAngle
        {
            get => (byte)row["validPlayerAngle"].Value;
            set => row["validPlayerAngle"].Value = value;
        }

        // Unknown.
        public byte spQualifiedType
        {
            get => (byte)row["spQualifiedType"].Value;
            set => row["spQualifiedType"].Value = value;
        }

        // Unknown.
        public byte spQualifiedType2
        {
            get => (byte)row["spQualifiedType2"].Value;
            set => row["spQualifiedType2"].Value = value;
        }

        // Unknown.
        public byte validObjAngle
        {
            get => (byte)row["validObjAngle"].Value;
            set => row["validObjAngle"].Value = value;
        }

        // Unknown.
        public byte chrSorbType
        {
            get => (byte)row["chrSorbType"].Value;
            set => row["chrSorbType"].Value = value;
        }

        // Unknown.
        public byte eventKickTiming
        {
            get => (byte)row["eventKickTiming"].Value;
            set => row["eventKickTiming"].Value = value;
        }

        // Unknown.
        public int actionButtonParamId
        {
            get => (int)row["actionButtonParamId"].Value;
            set => row["actionButtonParamId"].Value = value;
        }

        // Unknown.
        public float enableTreasureDelaySec
        {
            get => (float)row["enableTreasureDelaySec"].Value;
            set => row["enableTreasureDelaySec"].Value = value;
        }

        // Unknown.
        public int preActionSfxDmypolyId
        {
            get => (int)row["preActionSfxDmypolyId"].Value;
            set => row["preActionSfxDmypolyId"].Value = value;
        }

        // Unknown.
        public int preActionSfxId
        {
            get => (int)row["preActionSfxId"].Value;
            set => row["preActionSfxId"].Value = value;
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
    public OBJ_ACT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public OBJ_ACT_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
