using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class WHITE_SIGN_COOL_TIME_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float limitationTime_Normal
        {
            get => (float)row["limitationTime_Normal"].Value;
            set => row["limitationTime_Normal"].Value = value;
        }

        // Unknown.
        public float limitationTime_NormalDriedFinger
        {
            get => (float)row["limitationTime_NormalDriedFinger"].Value;
            set => row["limitationTime_NormalDriedFinger"].Value = value;
        }

        // Unknown.
        public float limitationTime_Guardian
        {
            get => (float)row["limitationTime_Guardian"].Value;
            set => row["limitationTime_Guardian"].Value = value;
        }

        // Unknown.
        public float limitationTime_GuardianDriedFinger
        {
            get => (float)row["limitationTime_GuardianDriedFinger"].Value;
            set => row["limitationTime_GuardianDriedFinger"].Value = value;
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
    public WHITE_SIGN_COOL_TIME_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WHITE_SIGN_COOL_TIME_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
