using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class HIT_EFFECT_SFX_CONCEPT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public short atkIron_1
        {
            get => (short)row["atkIron_1"].Value;
            set => row["atkIron_1"].Value = value;
        }

        // Unknown.
        public short atkIron_2
        {
            get => (short)row["atkIron_2"].Value;
            set => row["atkIron_2"].Value = value;
        }

        // Unknown.
        public short atkLeather_1
        {
            get => (short)row["atkLeather_1"].Value;
            set => row["atkLeather_1"].Value = value;
        }

        // Unknown.
        public short atkLeather_2
        {
            get => (short)row["atkLeather_2"].Value;
            set => row["atkLeather_2"].Value = value;
        }

        // Unknown.
        public short atkWood_1
        {
            get => (short)row["atkWood_1"].Value;
            set => row["atkWood_1"].Value = value;
        }

        // Unknown.
        public short atkWood_2
        {
            get => (short)row["atkWood_2"].Value;
            set => row["atkWood_2"].Value = value;
        }

        // Unknown.
        public short atkBody_1
        {
            get => (short)row["atkBody_1"].Value;
            set => row["atkBody_1"].Value = value;
        }

        // Unknown.
        public short atkBody_2
        {
            get => (short)row["atkBody_2"].Value;
            set => row["atkBody_2"].Value = value;
        }

        // Unknown.
        public short atkStone_1
        {
            get => (short)row["atkStone_1"].Value;
            set => row["atkStone_1"].Value = value;
        }

        // Unknown.
        public short atkStone_2
        {
            get => (short)row["atkStone_2"].Value;
            set => row["atkStone_2"].Value = value;
        }

        // Unknown.
        public short atkNone_1
        {
            get => (short)row["atkNone_1"].Value;
            set => row["atkNone_1"].Value = value;
        }

        // Unknown.
        public short atkNone_2
        {
            get => (short)row["atkNone_2"].Value;
            set => row["atkNone_2"].Value = value;
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
    public HIT_EFFECT_SFX_CONCEPT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public HIT_EFFECT_SFX_CONCEPT_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
