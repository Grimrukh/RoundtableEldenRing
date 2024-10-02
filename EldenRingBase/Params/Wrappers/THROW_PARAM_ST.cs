using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class THROW_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int AtkChrId
        {
            get => (int)row["AtkChrId"].Value;
            set => row["AtkChrId"].Value = value;
        }

        // Unknown.
        public int DefChrId
        {
            get => (int)row["DefChrId"].Value;
            set => row["DefChrId"].Value = value;
        }

        // Unknown.
        public float Dist
        {
            get => (float)row["Dist"].Value;
            set => row["Dist"].Value = value;
        }

        // Unknown.
        public float DiffAngMin
        {
            get => (float)row["DiffAngMin"].Value;
            set => row["DiffAngMin"].Value = value;
        }

        // Unknown.
        public float DiffAngMax
        {
            get => (float)row["DiffAngMax"].Value;
            set => row["DiffAngMax"].Value = value;
        }

        // Unknown.
        public float upperYRange
        {
            get => (float)row["upperYRange"].Value;
            set => row["upperYRange"].Value = value;
        }

        // Unknown.
        public float lowerYRange
        {
            get => (float)row["lowerYRange"].Value;
            set => row["lowerYRange"].Value = value;
        }

        // Unknown.
        public float diffAngMyToDef
        {
            get => (float)row["diffAngMyToDef"].Value;
            set => row["diffAngMyToDef"].Value = value;
        }

        // Unknown.
        public int throwTypeId
        {
            get => (int)row["throwTypeId"].Value;
            set => row["throwTypeId"].Value = value;
        }

        // Unknown.
        public int atkAnimId
        {
            get => (int)row["atkAnimId"].Value;
            set => row["atkAnimId"].Value = value;
        }

        // Unknown.
        public int defAnimId
        {
            get => (int)row["defAnimId"].Value;
            set => row["defAnimId"].Value = value;
        }

        // Unknown.
        public ushort escHp
        {
            get => (ushort)row["escHp"].Value;
            set => row["escHp"].Value = value;
        }

        // Unknown.
        public ushort selfEscCycleTime
        {
            get => (ushort)row["selfEscCycleTime"].Value;
            set => row["selfEscCycleTime"].Value = value;
        }

        // Unknown.
        public ushort sphereCastRadiusRateTop
        {
            get => (ushort)row["sphereCastRadiusRateTop"].Value;
            set => row["sphereCastRadiusRateTop"].Value = value;
        }

        // Unknown.
        public ushort sphereCastRadiusRateLow
        {
            get => (ushort)row["sphereCastRadiusRateLow"].Value;
            set => row["sphereCastRadiusRateLow"].Value = value;
        }

        // Unknown.
        public byte PadType
        {
            get => (byte)row["PadType"].Value;
            set => row["PadType"].Value = value;
        }

        // Unknown.
        public byte AtkEnableState
        {
            get => (byte)row["AtkEnableState"].Value;
            set => row["AtkEnableState"].Value = value;
        }

        // Unknown.
        public byte throwFollowingType
        {
            get => (byte)row["throwFollowingType"].Value;
            set => row["throwFollowingType"].Value = value;
        }

        // Unknown.
        public byte throwType
        {
            get => (byte)row["throwType"].Value;
            set => row["throwType"].Value = value;
        }

        // Unknown.
        public byte selfEscCycleCnt
        {
            get => (byte)row["selfEscCycleCnt"].Value;
            set => row["selfEscCycleCnt"].Value = value;
        }

        // Unknown.
        public byte dmyHasChrDirType
        {
            get => (byte)row["dmyHasChrDirType"].Value;
            set => row["dmyHasChrDirType"].Value = value;
        }

        // Unknown.
        public byte isTurnAtker
        {
            get => (byte)row["isTurnAtker"].Value;
            set => row["isTurnAtker"].Value = value;
        }

        // Unknown.
        public byte isSkipWepCate
        {
            get => (byte)row["isSkipWepCate"].Value;
            set => row["isSkipWepCate"].Value = value;
        }

        // Unknown.
        public byte isSkipSphereCast
        {
            get => (byte)row["isSkipSphereCast"].Value;
            set => row["isSkipSphereCast"].Value = value;
        }

        // Unknown.
        public byte isEnableCorrectPos_forThrowAdjust
        {
            get => (byte)row["isEnableCorrectPos_forThrowAdjust"].Value;
            set => row["isEnableCorrectPos_forThrowAdjust"].Value = value;
        }

        // Unknown.
        public byte isEnableThrowFollowingFallAssist
        {
            get => (byte)row["isEnableThrowFollowingFallAssist"].Value;
            set => row["isEnableThrowFollowingFallAssist"].Value = value;
        }

        // Unknown.
        public byte isEnableThrowFollowingFeedback
        {
            get => (byte)row["isEnableThrowFollowingFeedback"].Value;
            set => row["isEnableThrowFollowingFeedback"].Value = value;
        }

        // Unknown.
        public short atkSorbDmyId
        {
            get => (short)row["atkSorbDmyId"].Value;
            set => row["atkSorbDmyId"].Value = value;
        }

        // Unknown.
        public short defSorbDmyId
        {
            get => (short)row["defSorbDmyId"].Value;
            set => row["defSorbDmyId"].Value = value;
        }

        // Unknown.
        public float Dist_start
        {
            get => (float)row["Dist_start"].Value;
            set => row["Dist_start"].Value = value;
        }

        // Unknown.
        public float DiffAngMin_start
        {
            get => (float)row["DiffAngMin_start"].Value;
            set => row["DiffAngMin_start"].Value = value;
        }

        // Unknown.
        public float DiffAngMax_start
        {
            get => (float)row["DiffAngMax_start"].Value;
            set => row["DiffAngMax_start"].Value = value;
        }

        // Unknown.
        public float upperYRange_start
        {
            get => (float)row["upperYRange_start"].Value;
            set => row["upperYRange_start"].Value = value;
        }

        // Unknown.
        public float lowerYRange_start
        {
            get => (float)row["lowerYRange_start"].Value;
            set => row["lowerYRange_start"].Value = value;
        }

        // Unknown.
        public float diffAngMyToDef_start
        {
            get => (float)row["diffAngMyToDef_start"].Value;
            set => row["diffAngMyToDef_start"].Value = value;
        }

        // Unknown.
        public int judgeRangeBasePosDmyId1
        {
            get => (int)row["judgeRangeBasePosDmyId1"].Value;
            set => row["judgeRangeBasePosDmyId1"].Value = value;
        }

        // Unknown.
        public int judgeRangeBasePosDmyId2
        {
            get => (int)row["judgeRangeBasePosDmyId2"].Value;
            set => row["judgeRangeBasePosDmyId2"].Value = value;
        }

        // Unknown.
        public float adsrobModelPosInterpolationTime
        {
            get => (float)row["adsrobModelPosInterpolationTime"].Value;
            set => row["adsrobModelPosInterpolationTime"].Value = value;
        }

        // Unknown.
        public float throwFollowingEndEasingTime
        {
            get => (float)row["throwFollowingEndEasingTime"].Value;
            set => row["throwFollowingEndEasingTime"].Value = value;
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
    public THROW_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public THROW_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
