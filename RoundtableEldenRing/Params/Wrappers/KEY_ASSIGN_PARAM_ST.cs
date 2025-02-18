using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class KEY_ASSIGN_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int padKeyId
        {
            get => (int)row["padKeyId"].Value;
            set => row["padKeyId"].Value = value;
        }

        // Unknown.
        public int keyboardModifyKey
        {
            get => (int)row["keyboardModifyKey"].Value;
            set => row["keyboardModifyKey"].Value = value;
        }

        // Unknown.
        public int keyboardKeyId
        {
            get => (int)row["keyboardKeyId"].Value;
            set => row["keyboardKeyId"].Value = value;
        }

        // Unknown.
        public int mouseModifyKey
        {
            get => (int)row["mouseModifyKey"].Value;
            set => row["mouseModifyKey"].Value = value;
        }

        // Unknown.
        public int mouseKeyId
        {
            get => (int)row["mouseKeyId"].Value;
            set => row["mouseKeyId"].Value = value;
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
    public KEY_ASSIGN_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public KEY_ASSIGN_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
