using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class MENU_VALUE_TABLE_SPEC
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
        public int textId
        {
            get => (int)row["textId"].Value;
            set => row["textId"].Value = value;
        }

        // Unknown.
        public sbyte compareType
        {
            get => (sbyte)row["compareType"].Value;
            set => row["compareType"].Value = value;
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
    public MENU_VALUE_TABLE_SPEC(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MENU_VALUE_TABLE_SPEC(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
