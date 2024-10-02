using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class WEATHER_ASSET_REPLACE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public uint mapId
        {
            get => (uint)row["mapId"].Value;
            set => row["mapId"].Value = value;
        }

        // Unknown.
        public short TransitionSrcWeather
        {
            get => (short)row["TransitionSrcWeather"].Value;
            set => row["TransitionSrcWeather"].Value = value;
        }

        // Unknown.
        public byte isFireAsh
        {
            get => (byte)row["isFireAsh"].Value;
            set => row["isFireAsh"].Value = value;
        }

        public uint reserved2
        {
            get => (uint)row["reserved2"].Value;
            set => row["reserved2"].Value = value;
        }

        // Unknown.
        public int AssetId0
        {
            get => (int)row["AssetId0"].Value;
            set => row["AssetId0"].Value = value;
        }

        // Unknown.
        public int AssetId1
        {
            get => (int)row["AssetId1"].Value;
            set => row["AssetId1"].Value = value;
        }

        // Unknown.
        public int AssetId2
        {
            get => (int)row["AssetId2"].Value;
            set => row["AssetId2"].Value = value;
        }

        // Unknown.
        public int AssetId3
        {
            get => (int)row["AssetId3"].Value;
            set => row["AssetId3"].Value = value;
        }

        // Unknown.
        public int AssetId4
        {
            get => (int)row["AssetId4"].Value;
            set => row["AssetId4"].Value = value;
        }

        // Unknown.
        public int AssetId5
        {
            get => (int)row["AssetId5"].Value;
            set => row["AssetId5"].Value = value;
        }

        // Unknown.
        public int AssetId6
        {
            get => (int)row["AssetId6"].Value;
            set => row["AssetId6"].Value = value;
        }

        // Unknown.
        public int AssetId7
        {
            get => (int)row["AssetId7"].Value;
            set => row["AssetId7"].Value = value;
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
    public WEATHER_ASSET_REPLACE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WEATHER_ASSET_REPLACE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
