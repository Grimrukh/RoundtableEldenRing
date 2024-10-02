using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class RUNTIME_BONE_CONTROL_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public uint chrId
        {
            get => (uint)row["chrId"].Value;
            set => row["chrId"].Value = value;
        }

        // Unknown.
        public byte ctrlType
        {
            get => (byte)row["ctrlType"].Value;
            set => row["ctrlType"].Value = value;
        }

        // Unknown.
        public string applyBone
        {
            get => (string)row["applyBone"].Value;
            set => row["applyBone"].Value = value;
        }

        // Unknown.
        public string targetBone1
        {
            get => (string)row["targetBone1"].Value;
            set => row["targetBone1"].Value = value;
        }

        // Unknown.
        public string targetBone2
        {
            get => (string)row["targetBone2"].Value;
            set => row["targetBone2"].Value = value;
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
    public RUNTIME_BONE_CONTROL_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public RUNTIME_BONE_CONTROL_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
