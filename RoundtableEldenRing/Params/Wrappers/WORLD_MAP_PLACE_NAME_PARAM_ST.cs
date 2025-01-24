using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class WORLD_MAP_PLACE_NAME_PARAM_ST
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
        public int worldMapPieceId
        {
            get => (int)row["worldMapPieceId"].Value;
            set => row["worldMapPieceId"].Value = value;
        }

        // Unknown.
        public int textId
        {
            get => (int)row["textId"].Value;
            set => row["textId"].Value = value;
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

        public object this[string fieldName]
        {
            get => row[fieldName].Value;
            set => row[fieldName].Value = value;
        }
    }
    
    /// <summary>
    /// Construct from a standard `PARAM` read from disk.
    /// </summary>
    public WORLD_MAP_PLACE_NAME_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WORLD_MAP_PLACE_NAME_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
