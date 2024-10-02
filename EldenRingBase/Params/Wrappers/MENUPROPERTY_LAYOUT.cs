using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MENUPROPERTY_LAYOUT
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        public string LayoutPath
        {
            get => (string)row["LayoutPath"].Value;
            set => row["LayoutPath"].Value = value;
        }

        public int PropertyID
        {
            get => (int)row["PropertyID"].Value;
            set => row["PropertyID"].Value = value;
        }

        // Unknown.
        public int CaptionTextID
        {
            get => (int)row["CaptionTextID"].Value;
            set => row["CaptionTextID"].Value = value;
        }

        // Unknown.
        public int HelpTextID
        {
            get => (int)row["HelpTextID"].Value;
            set => row["HelpTextID"].Value = value;
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
    public MENUPROPERTY_LAYOUT(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MENUPROPERTY_LAYOUT(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
