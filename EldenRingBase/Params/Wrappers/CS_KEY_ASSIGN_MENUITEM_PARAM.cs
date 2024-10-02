using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class CS_KEY_ASSIGN_MENUITEM_PARAM
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int textID
        {
            get => (int)row["textID"].Value;
            set => row["textID"].Value = value;
        }

        // Unknown.
        public int key
        {
            get => (int)row["key"].Value;
            set => row["key"].Value = value;
        }

        // Unknown.
        public byte enableUnassign
        {
            get => (byte)row["enableUnassign"].Value;
            set => row["enableUnassign"].Value = value;
        }

        // Unknown.
        public byte enablePadConfig
        {
            get => (byte)row["enablePadConfig"].Value;
            set => row["enablePadConfig"].Value = value;
        }

        // Unknown.
        public byte enableMouseConfig
        {
            get => (byte)row["enableMouseConfig"].Value;
            set => row["enableMouseConfig"].Value = value;
        }

        // Unknown.
        public byte group
        {
            get => (byte)row["group"].Value;
            set => row["group"].Value = value;
        }

        // Unknown.
        public int mappingTextID
        {
            get => (int)row["mappingTextID"].Value;
            set => row["mappingTextID"].Value = value;
        }

        // Unknown.
        public byte viewPad
        {
            get => (byte)row["viewPad"].Value;
            set => row["viewPad"].Value = value;
        }

        // Unknown.
        public byte viewKeyboardMouse
        {
            get => (byte)row["viewKeyboardMouse"].Value;
            set => row["viewKeyboardMouse"].Value = value;
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
    public CS_KEY_ASSIGN_MENUITEM_PARAM(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CS_KEY_ASSIGN_MENUITEM_PARAM(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
