using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class CHR_MODEL_PARAM_ST
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
        public byte modelMemoryType
        {
            get => (byte)row["modelMemoryType"].Value;
            set => row["modelMemoryType"].Value = value;
        }

        // Unknown.
        public byte texMemoryType
        {
            get => (byte)row["texMemoryType"].Value;
            set => row["texMemoryType"].Value = value;
        }

        // Unknown.
        public short cameraDitherFadeId
        {
            get => (short)row["cameraDitherFadeId"].Value;
            set => row["cameraDitherFadeId"].Value = value;
        }

        // Unknown.
        public float reportAnimMemSizeMb
        {
            get => (float)row["reportAnimMemSizeMb"].Value;
            set => row["reportAnimMemSizeMb"].Value = value;
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
    public CHR_MODEL_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CHR_MODEL_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
