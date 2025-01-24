using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class POSTURE_CONTROL_PARAM_WEP_LEFT_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public short a000_leftArmFB
        {
            get => (short)row["a000_leftArmFB"].Value;
            set => row["a000_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a000_leftWristFB
        {
            get => (short)row["a000_leftWristFB"].Value;
            set => row["a000_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a000_leftWristIO
        {
            get => (short)row["a000_leftWristIO"].Value;
            set => row["a000_leftWristIO"].Value = value;
        }

        // Unknown.
        public short a002_leftArmFB
        {
            get => (short)row["a002_leftArmFB"].Value;
            set => row["a002_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a002_leftWristFB
        {
            get => (short)row["a002_leftWristFB"].Value;
            set => row["a002_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a002_leftWristIO
        {
            get => (short)row["a002_leftWristIO"].Value;
            set => row["a002_leftWristIO"].Value = value;
        }

        // Unknown.
        public short a003_leftArmFB
        {
            get => (short)row["a003_leftArmFB"].Value;
            set => row["a003_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a003_leftWristFB
        {
            get => (short)row["a003_leftWristFB"].Value;
            set => row["a003_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a003_leftWristIO
        {
            get => (short)row["a003_leftWristIO"].Value;
            set => row["a003_leftWristIO"].Value = value;
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
    public POSTURE_CONTROL_PARAM_WEP_LEFT_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public POSTURE_CONTROL_PARAM_WEP_LEFT_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
