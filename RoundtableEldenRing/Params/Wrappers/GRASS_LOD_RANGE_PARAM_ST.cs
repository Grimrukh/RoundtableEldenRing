using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class GRASS_LOD_RANGE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        public float LOD0_range
        {
            get => (float)row["LOD0_range"].Value;
            set => row["LOD0_range"].Value = value;
        }

        public float LOD0_play
        {
            get => (float)row["LOD0_play"].Value;
            set => row["LOD0_play"].Value = value;
        }

        public float LOD1_range
        {
            get => (float)row["LOD1_range"].Value;
            set => row["LOD1_range"].Value = value;
        }

        public float LOD1_play
        {
            get => (float)row["LOD1_play"].Value;
            set => row["LOD1_play"].Value = value;
        }

        public float LOD2_range
        {
            get => (float)row["LOD2_range"].Value;
            set => row["LOD2_range"].Value = value;
        }

        public float LOD2_play
        {
            get => (float)row["LOD2_play"].Value;
            set => row["LOD2_play"].Value = value;
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
    public GRASS_LOD_RANGE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public GRASS_LOD_RANGE_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
