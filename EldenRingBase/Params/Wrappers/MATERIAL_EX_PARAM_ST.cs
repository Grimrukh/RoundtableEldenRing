using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MATERIAL_EX_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public string paramName
        {
            get => (string)row["paramName"].Value;
            set => row["paramName"].Value = value;
        }

        // Unknown.
        public int materialId
        {
            get => (int)row["materialId"].Value;
            set => row["materialId"].Value = value;
        }

        // Unknown.
        public float materialParamValue0
        {
            get => (float)row["materialParamValue0"].Value;
            set => row["materialParamValue0"].Value = value;
        }

        // Unknown.
        public float materialParamValue1
        {
            get => (float)row["materialParamValue1"].Value;
            set => row["materialParamValue1"].Value = value;
        }

        // Unknown.
        public float materialParamValue2
        {
            get => (float)row["materialParamValue2"].Value;
            set => row["materialParamValue2"].Value = value;
        }

        // Unknown.
        public float materialParamValue3
        {
            get => (float)row["materialParamValue3"].Value;
            set => row["materialParamValue3"].Value = value;
        }

        // Unknown.
        public float materialParamValue4
        {
            get => (float)row["materialParamValue4"].Value;
            set => row["materialParamValue4"].Value = value;
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
    public MATERIAL_EX_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MATERIAL_EX_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
