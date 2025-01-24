using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class WORLD_MAP_PIECE_PARAM_ST
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
        public uint openEventFlagId
        {
            get => (uint)row["openEventFlagId"].Value;
            set => row["openEventFlagId"].Value = value;
        }

        // Unknown.
        public float openTravelAreaLeft
        {
            get => (float)row["openTravelAreaLeft"].Value;
            set => row["openTravelAreaLeft"].Value = value;
        }

        // Unknown.
        public float openTravelAreaRight
        {
            get => (float)row["openTravelAreaRight"].Value;
            set => row["openTravelAreaRight"].Value = value;
        }

        // Unknown.
        public float openTravelAreaTop
        {
            get => (float)row["openTravelAreaTop"].Value;
            set => row["openTravelAreaTop"].Value = value;
        }

        // Unknown.
        public float openTravelAreaBottom
        {
            get => (float)row["openTravelAreaBottom"].Value;
            set => row["openTravelAreaBottom"].Value = value;
        }

        // Unknown.
        public uint acquisitionEventFlagId
        {
            get => (uint)row["acquisitionEventFlagId"].Value;
            set => row["acquisitionEventFlagId"].Value = value;
        }

        // Unknown.
        public float acquisitionEventScale
        {
            get => (float)row["acquisitionEventScale"].Value;
            set => row["acquisitionEventScale"].Value = value;
        }

        // Unknown.
        public float acquisitionEventCenterX
        {
            get => (float)row["acquisitionEventCenterX"].Value;
            set => row["acquisitionEventCenterX"].Value = value;
        }

        // Unknown.
        public float acquisitionEventCenterY
        {
            get => (float)row["acquisitionEventCenterY"].Value;
            set => row["acquisitionEventCenterY"].Value = value;
        }

        // Unknown.
        public float acquisitionEventResScale
        {
            get => (float)row["acquisitionEventResScale"].Value;
            set => row["acquisitionEventResScale"].Value = value;
        }

        // Unknown.
        public float acquisitionEventResOffsetX
        {
            get => (float)row["acquisitionEventResOffsetX"].Value;
            set => row["acquisitionEventResOffsetX"].Value = value;
        }

        // Unknown.
        public float acquisitionEventResOffsetY
        {
            get => (float)row["acquisitionEventResOffsetY"].Value;
            set => row["acquisitionEventResOffsetY"].Value = value;
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
    public WORLD_MAP_PIECE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WORLD_MAP_PIECE_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
