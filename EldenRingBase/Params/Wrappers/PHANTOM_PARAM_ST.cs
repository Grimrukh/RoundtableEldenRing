using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class PHANTOM_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float edgeColorA
        {
            get => (float)row["edgeColorA"].Value;
            set => row["edgeColorA"].Value = value;
        }

        // Unknown.
        public float frontColorA
        {
            get => (float)row["frontColorA"].Value;
            set => row["frontColorA"].Value = value;
        }

        // Unknown.
        public float diffMulColorA
        {
            get => (float)row["diffMulColorA"].Value;
            set => row["diffMulColorA"].Value = value;
        }

        // Unknown.
        public float specMulColorA
        {
            get => (float)row["specMulColorA"].Value;
            set => row["specMulColorA"].Value = value;
        }

        // Unknown.
        public float lightColorA
        {
            get => (float)row["lightColorA"].Value;
            set => row["lightColorA"].Value = value;
        }

        // Unknown.
        public byte edgeColorR
        {
            get => (byte)row["edgeColorR"].Value;
            set => row["edgeColorR"].Value = value;
        }

        // Unknown.
        public byte edgeColorG
        {
            get => (byte)row["edgeColorG"].Value;
            set => row["edgeColorG"].Value = value;
        }

        // Unknown.
        public byte edgeColorB
        {
            get => (byte)row["edgeColorB"].Value;
            set => row["edgeColorB"].Value = value;
        }

        // Unknown.
        public byte frontColorR
        {
            get => (byte)row["frontColorR"].Value;
            set => row["frontColorR"].Value = value;
        }

        // Unknown.
        public byte frontColorG
        {
            get => (byte)row["frontColorG"].Value;
            set => row["frontColorG"].Value = value;
        }

        // Unknown.
        public byte frontColorB
        {
            get => (byte)row["frontColorB"].Value;
            set => row["frontColorB"].Value = value;
        }

        // Unknown.
        public byte diffMulColorR
        {
            get => (byte)row["diffMulColorR"].Value;
            set => row["diffMulColorR"].Value = value;
        }

        // Unknown.
        public byte diffMulColorG
        {
            get => (byte)row["diffMulColorG"].Value;
            set => row["diffMulColorG"].Value = value;
        }

        // Unknown.
        public byte diffMulColorB
        {
            get => (byte)row["diffMulColorB"].Value;
            set => row["diffMulColorB"].Value = value;
        }

        // Unknown.
        public byte specMulColorR
        {
            get => (byte)row["specMulColorR"].Value;
            set => row["specMulColorR"].Value = value;
        }

        // Unknown.
        public byte specMulColorG
        {
            get => (byte)row["specMulColorG"].Value;
            set => row["specMulColorG"].Value = value;
        }

        // Unknown.
        public byte specMulColorB
        {
            get => (byte)row["specMulColorB"].Value;
            set => row["specMulColorB"].Value = value;
        }

        // Unknown.
        public byte lightColorR
        {
            get => (byte)row["lightColorR"].Value;
            set => row["lightColorR"].Value = value;
        }

        // Unknown.
        public byte lightColorG
        {
            get => (byte)row["lightColorG"].Value;
            set => row["lightColorG"].Value = value;
        }

        // Unknown.
        public byte lightColorB
        {
            get => (byte)row["lightColorB"].Value;
            set => row["lightColorB"].Value = value;
        }

        // Unknown.
        public float alpha
        {
            get => (float)row["alpha"].Value;
            set => row["alpha"].Value = value;
        }

        // Unknown.
        public float blendRate
        {
            get => (float)row["blendRate"].Value;
            set => row["blendRate"].Value = value;
        }

        // Unknown.
        public byte blendType
        {
            get => (byte)row["blendType"].Value;
            set => row["blendType"].Value = value;
        }

        // Unknown.
        public byte isEdgeSubtract
        {
            get => (byte)row["isEdgeSubtract"].Value;
            set => row["isEdgeSubtract"].Value = value;
        }

        // Unknown.
        public byte isFrontSubtract
        {
            get => (byte)row["isFrontSubtract"].Value;
            set => row["isFrontSubtract"].Value = value;
        }

        // Unknown.
        public byte isNo2Pass
        {
            get => (byte)row["isNo2Pass"].Value;
            set => row["isNo2Pass"].Value = value;
        }

        // Unknown.
        public float edgePower
        {
            get => (float)row["edgePower"].Value;
            set => row["edgePower"].Value = value;
        }

        // Unknown.
        public float glowScale
        {
            get => (float)row["glowScale"].Value;
            set => row["glowScale"].Value = value;
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
    public PHANTOM_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public PHANTOM_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
