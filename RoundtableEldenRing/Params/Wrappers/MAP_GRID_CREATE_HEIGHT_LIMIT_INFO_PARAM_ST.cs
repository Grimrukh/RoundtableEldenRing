using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class MAP_GRID_CREATE_HEIGHT_LIMIT_INFO_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float GridEnableCreateHeightMin
        {
            get => (float)row["GridEnableCreateHeightMin"].Value;
            set => row["GridEnableCreateHeightMin"].Value = value;
        }

        // Unknown.
        public float GridEnableCreateHeightMax
        {
            get => (float)row["GridEnableCreateHeightMax"].Value;
            set => row["GridEnableCreateHeightMax"].Value = value;
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
    public MAP_GRID_CREATE_HEIGHT_LIMIT_INFO_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MAP_GRID_CREATE_HEIGHT_LIMIT_INFO_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
