using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class WEATHER_ASSET_CREATE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public uint AssetId
        {
            get => (uint)row["AssetId"].Value;
            set => row["AssetId"].Value = value;
        }

        // Unknown.
        public uint SlotNo
        {
            get => (uint)row["SlotNo"].Value;
            set => row["SlotNo"].Value = value;
        }

        // Unknown.
        public byte CreateConditionType
        {
            get => (byte)row["CreateConditionType"].Value;
            set => row["CreateConditionType"].Value = value;
        }

        // Unknown.
        public short TransitionSrcWeather
        {
            get => (short)row["TransitionSrcWeather"].Value;
            set => row["TransitionSrcWeather"].Value = value;
        }

        // Unknown.
        public short TransitionDstWeather
        {
            get => (short)row["TransitionDstWeather"].Value;
            set => row["TransitionDstWeather"].Value = value;
        }

        // Unknown.
        public short ElapsedTimeCheckweather
        {
            get => (short)row["ElapsedTimeCheckweather"].Value;
            set => row["ElapsedTimeCheckweather"].Value = value;
        }

        // Unknown.
        public float ElapsedTime
        {
            get => (float)row["ElapsedTime"].Value;
            set => row["ElapsedTime"].Value = value;
        }

        // Unknown.
        public float CreateDelayTime
        {
            get => (float)row["CreateDelayTime"].Value;
            set => row["CreateDelayTime"].Value = value;
        }

        // Unknown.
        public uint CreateProbability
        {
            get => (uint)row["CreateProbability"].Value;
            set => row["CreateProbability"].Value = value;
        }

        // Unknown.
        public float LifeTime
        {
            get => (float)row["LifeTime"].Value;
            set => row["LifeTime"].Value = value;
        }

        // Unknown.
        public float FadeTime
        {
            get => (float)row["FadeTime"].Value;
            set => row["FadeTime"].Value = value;
        }

        // Unknown.
        public float EnableCreateTimeMin
        {
            get => (float)row["EnableCreateTimeMin"].Value;
            set => row["EnableCreateTimeMin"].Value = value;
        }

        // Unknown.
        public float EnableCreateTimeMax
        {
            get => (float)row["EnableCreateTimeMax"].Value;
            set => row["EnableCreateTimeMax"].Value = value;
        }

        // Unknown.
        public short CreatePoint0
        {
            get => (short)row["CreatePoint0"].Value;
            set => row["CreatePoint0"].Value = value;
        }

        // Unknown.
        public short CreatePoint1
        {
            get => (short)row["CreatePoint1"].Value;
            set => row["CreatePoint1"].Value = value;
        }

        // Unknown.
        public short CreatePoint2
        {
            get => (short)row["CreatePoint2"].Value;
            set => row["CreatePoint2"].Value = value;
        }

        // Unknown.
        public short CreatePoint3
        {
            get => (short)row["CreatePoint3"].Value;
            set => row["CreatePoint3"].Value = value;
        }

        // Unknown.
        public sbyte CreateAssetLimitId0
        {
            get => (sbyte)row["CreateAssetLimitId0"].Value;
            set => row["CreateAssetLimitId0"].Value = value;
        }

        // Unknown.
        public sbyte CreateAssetLimitId1
        {
            get => (sbyte)row["CreateAssetLimitId1"].Value;
            set => row["CreateAssetLimitId1"].Value = value;
        }

        // Unknown.
        public sbyte CreateAssetLimitId2
        {
            get => (sbyte)row["CreateAssetLimitId2"].Value;
            set => row["CreateAssetLimitId2"].Value = value;
        }

        // Unknown.
        public sbyte CreateAssetLimitId3
        {
            get => (sbyte)row["CreateAssetLimitId3"].Value;
            set => row["CreateAssetLimitId3"].Value = value;
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
    public WEATHER_ASSET_CREATE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WEATHER_ASSET_CREATE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
