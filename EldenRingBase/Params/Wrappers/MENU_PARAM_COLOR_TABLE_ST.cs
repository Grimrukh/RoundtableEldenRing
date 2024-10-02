using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MENU_PARAM_COLOR_TABLE_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte lerpMode
        {
            get => (byte)row["lerpMode"].Value;
            set => row["lerpMode"].Value = value;
        }

        // Unknown.
        public ushort h
        {
            get => (ushort)row["h"].Value;
            set => row["h"].Value = value;
        }

        // Unknown.
        public float s1
        {
            get => (float)row["s1"].Value;
            set => row["s1"].Value = value;
        }

        // Unknown.
        public float v1
        {
            get => (float)row["v1"].Value;
            set => row["v1"].Value = value;
        }

        // Unknown.
        public float s2
        {
            get => (float)row["s2"].Value;
            set => row["s2"].Value = value;
        }

        // Unknown.
        public float v2
        {
            get => (float)row["v2"].Value;
            set => row["v2"].Value = value;
        }

        // Unknown.
        public float s3
        {
            get => (float)row["s3"].Value;
            set => row["s3"].Value = value;
        }

        // Unknown.
        public float v3
        {
            get => (float)row["v3"].Value;
            set => row["v3"].Value = value;
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
    public MENU_PARAM_COLOR_TABLE_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MENU_PARAM_COLOR_TABLE_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
