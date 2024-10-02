using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class WET_ASPECT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte baseColorR
        {
            get => (byte)row["baseColorR"].Value;
            set => row["baseColorR"].Value = value;
        }

        // Unknown.
        public byte baseColorG
        {
            get => (byte)row["baseColorG"].Value;
            set => row["baseColorG"].Value = value;
        }

        // Unknown.
        public byte baseColorB
        {
            get => (byte)row["baseColorB"].Value;
            set => row["baseColorB"].Value = value;
        }

        // Unknown.
        public float baseColorA
        {
            get => (float)row["baseColorA"].Value;
            set => row["baseColorA"].Value = value;
        }

        // Unknown.
        public byte metallic
        {
            get => (byte)row["metallic"].Value;
            set => row["metallic"].Value = value;
        }

        // Unknown.
        public float metallicRate
        {
            get => (float)row["metallicRate"].Value;
            set => row["metallicRate"].Value = value;
        }

        // Unknown.
        public float shininessRate
        {
            get => (float)row["shininessRate"].Value;
            set => row["shininessRate"].Value = value;
        }

        // Unknown.
        public byte shininess
        {
            get => (byte)row["shininess"].Value;
            set => row["shininess"].Value = value;
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
    public WET_ASPECT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WET_ASPECT_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
