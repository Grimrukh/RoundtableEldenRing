using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class CHARMAKEMENU_LISTITEM_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int value
        {
            get => (int)row["value"].Value;
            set => row["value"].Value = value;
        }

        // Unknown.
        public int captionId
        {
            get => (int)row["captionId"].Value;
            set => row["captionId"].Value = value;
        }

        // Unknown.
        public byte iconId
        {
            get => (byte)row["iconId"].Value;
            set => row["iconId"].Value = value;
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
    public CHARMAKEMENU_LISTITEM_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CHARMAKEMENU_LISTITEM_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
