using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class WAYPOINT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        public short attribute1
        {
            get => (short)row["attribute1"].Value;
            set => row["attribute1"].Value = value;
        }

        public short attribute2
        {
            get => (short)row["attribute2"].Value;
            set => row["attribute2"].Value = value;
        }

        public short attribute3
        {
            get => (short)row["attribute3"].Value;
            set => row["attribute3"].Value = value;
        }

        public short attribute4
        {
            get => (short)row["attribute4"].Value;
            set => row["attribute4"].Value = value;
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
    public WAYPOINT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WAYPOINT_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
