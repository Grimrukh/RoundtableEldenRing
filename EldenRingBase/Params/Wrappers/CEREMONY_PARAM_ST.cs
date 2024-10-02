using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class CEREMONY_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int eventLayerId
        {
            get => (int)row["eventLayerId"].Value;
            set => row["eventLayerId"].Value = value;
        }

        // Unknown.
        public int mapStudioLayerId
        {
            get => (int)row["mapStudioLayerId"].Value;
            set => row["mapStudioLayerId"].Value = value;
        }

        // Unknown.
        public int multiPlayAreaOffset
        {
            get => (int)row["multiPlayAreaOffset"].Value;
            set => row["multiPlayAreaOffset"].Value = value;
        }

        // Unknown.
        public int overrideMapPlaceNameId
        {
            get => (int)row["overrideMapPlaceNameId"].Value;
            set => row["overrideMapPlaceNameId"].Value = value;
        }

        // Unknown.
        public int overrideSaveMapNameId
        {
            get => (int)row["overrideSaveMapNameId"].Value;
            set => row["overrideSaveMapNameId"].Value = value;
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
    public CEREMONY_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CEREMONY_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
