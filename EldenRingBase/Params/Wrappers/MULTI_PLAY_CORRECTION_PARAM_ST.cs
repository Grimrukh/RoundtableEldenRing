using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MULTI_PLAY_CORRECTION_PARAM_ST
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
        public int client1SpEffectId
        {
            get => (int)row["client1SpEffectId"].Value;
            set => row["client1SpEffectId"].Value = value;
        }

        // Unknown.
        public int client2SpEffectId
        {
            get => (int)row["client2SpEffectId"].Value;
            set => row["client2SpEffectId"].Value = value;
        }

        // Unknown.
        public int client3SpEffectId
        {
            get => (int)row["client3SpEffectId"].Value;
            set => row["client3SpEffectId"].Value = value;
        }

        // Unknown.
        public byte bOverrideSpEffect
        {
            get => (byte)row["bOverrideSpEffect"].Value;
            set => row["bOverrideSpEffect"].Value = value;
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
    public MULTI_PLAY_CORRECTION_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MULTI_PLAY_CORRECTION_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
