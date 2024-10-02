using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MIMICRY_ESTABLISHMENT_TEX_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte disableParam_NT
        {
            get => (byte)row["disableParam_NT"].Value;
            set => row["disableParam_NT"].Value = value;
        }

        // Unknown.
        public byte srcR
        {
            get => (byte)row["srcR"].Value;
            set => row["srcR"].Value = value;
        }

        // Unknown.
        public byte srcG
        {
            get => (byte)row["srcG"].Value;
            set => row["srcG"].Value = value;
        }

        // Unknown.
        public byte srcB
        {
            get => (byte)row["srcB"].Value;
            set => row["srcB"].Value = value;
        }

        // Unknown.
        public int mimicryEstablishmentParamId
        {
            get => (int)row["mimicryEstablishmentParamId"].Value;
            set => row["mimicryEstablishmentParamId"].Value = value;
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
    public MIMICRY_ESTABLISHMENT_TEX_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MIMICRY_ESTABLISHMENT_TEX_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
