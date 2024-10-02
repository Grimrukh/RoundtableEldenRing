using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class TOUGHNESS_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float correctionRate
        {
            get => (float)row["correctionRate"].Value;
            set => row["correctionRate"].Value = value;
        }

        // Unknown.
        public ushort minToughness
        {
            get => (ushort)row["minToughness"].Value;
            set => row["minToughness"].Value = value;
        }

        // Unknown.
        public byte isNonEffectiveCorrectionForMin
        {
            get => (byte)row["isNonEffectiveCorrectionForMin"].Value;
            set => row["isNonEffectiveCorrectionForMin"].Value = value;
        }

        // Unknown.
        public int spEffectId
        {
            get => (int)row["spEffectId"].Value;
            set => row["spEffectId"].Value = value;
        }

        // Unknown.
        public float proCorrectionRate
        {
            get => (float)row["proCorrectionRate"].Value;
            set => row["proCorrectionRate"].Value = value;
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
    public TOUGHNESS_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public TOUGHNESS_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
