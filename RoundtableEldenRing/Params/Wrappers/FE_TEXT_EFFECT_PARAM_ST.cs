using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class FE_TEXT_EFFECT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public short resId
        {
            get => (short)row["resId"].Value;
            set => row["resId"].Value = value;
        }

        // Unknown.
        public int textId
        {
            get => (int)row["textId"].Value;
            set => row["textId"].Value = value;
        }

        // Unknown.
        public int seId
        {
            get => (int)row["seId"].Value;
            set => row["seId"].Value = value;
        }

        // Unknown.
        public byte canMixMapName
        {
            get => (byte)row["canMixMapName"].Value;
            set => row["canMixMapName"].Value = value;
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
    public FE_TEXT_EFFECT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public FE_TEXT_EFFECT_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
