using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class RESIST_CORRECT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float addPoint1
        {
            get => (float)row["addPoint1"].Value;
            set => row["addPoint1"].Value = value;
        }

        // Unknown.
        public float addPoint2
        {
            get => (float)row["addPoint2"].Value;
            set => row["addPoint2"].Value = value;
        }

        // Unknown.
        public float addPoint3
        {
            get => (float)row["addPoint3"].Value;
            set => row["addPoint3"].Value = value;
        }

        // Unknown.
        public float addPoint4
        {
            get => (float)row["addPoint4"].Value;
            set => row["addPoint4"].Value = value;
        }

        // Unknown.
        public float addPoint5
        {
            get => (float)row["addPoint5"].Value;
            set => row["addPoint5"].Value = value;
        }

        // Unknown.
        public float addRate1
        {
            get => (float)row["addRate1"].Value;
            set => row["addRate1"].Value = value;
        }

        // Unknown.
        public float addRate2
        {
            get => (float)row["addRate2"].Value;
            set => row["addRate2"].Value = value;
        }

        // Unknown.
        public float addRate3
        {
            get => (float)row["addRate3"].Value;
            set => row["addRate3"].Value = value;
        }

        // Unknown.
        public float addRate4
        {
            get => (float)row["addRate4"].Value;
            set => row["addRate4"].Value = value;
        }

        // Unknown.
        public float addRate5
        {
            get => (float)row["addRate5"].Value;
            set => row["addRate5"].Value = value;
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
    public RESIST_CORRECT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public RESIST_CORRECT_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
