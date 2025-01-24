using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class POSTURE_CONTROL_PARAM_WEP_RIGHT_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public short a000_rightArmFB
        {
            get => (short)row["a000_rightArmFB"].Value;
            set => row["a000_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a000_rightWristFB
        {
            get => (short)row["a000_rightWristFB"].Value;
            set => row["a000_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a000_rightWristIO
        {
            get => (short)row["a000_rightWristIO"].Value;
            set => row["a000_rightWristIO"].Value = value;
        }

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
        public short a002_rightArmFB
        {
            get => (short)row["a002_rightArmFB"].Value;
            set => row["a002_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a002_rightWristFB
        {
            get => (short)row["a002_rightWristFB"].Value;
            set => row["a002_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a002_rightWristIO
        {
            get => (short)row["a002_rightWristIO"].Value;
            set => row["a002_rightWristIO"].Value = value;
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
        public short a003_rightArmFB
        {
            get => (short)row["a003_rightArmFB"].Value;
            set => row["a003_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a003_rightWristFB
        {
            get => (short)row["a003_rightWristFB"].Value;
            set => row["a003_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a003_rightWristIO
        {
            get => (short)row["a003_rightWristIO"].Value;
            set => row["a003_rightWristIO"].Value = value;
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

        // Unknown.
        public short a010_rightArmFB
        {
            get => (short)row["a010_rightArmFB"].Value;
            set => row["a010_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a010_rightWristFB
        {
            get => (short)row["a010_rightWristFB"].Value;
            set => row["a010_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a010_rightWristIO
        {
            get => (short)row["a010_rightWristIO"].Value;
            set => row["a010_rightWristIO"].Value = value;
        }

        // Unknown.
        public short a010_leftArmFB
        {
            get => (short)row["a010_leftArmFB"].Value;
            set => row["a010_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a010_leftWristFB
        {
            get => (short)row["a010_leftWristFB"].Value;
            set => row["a010_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a010_leftWristIO
        {
            get => (short)row["a010_leftWristIO"].Value;
            set => row["a010_leftWristIO"].Value = value;
        }

        // Unknown.
        public short a012_rightArmFB
        {
            get => (short)row["a012_rightArmFB"].Value;
            set => row["a012_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a012_rightWristFB
        {
            get => (short)row["a012_rightWristFB"].Value;
            set => row["a012_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a012_rightWristIO
        {
            get => (short)row["a012_rightWristIO"].Value;
            set => row["a012_rightWristIO"].Value = value;
        }

        // Unknown.
        public short a012_leftArmFB
        {
            get => (short)row["a012_leftArmFB"].Value;
            set => row["a012_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a012_leftWristFB
        {
            get => (short)row["a012_leftWristFB"].Value;
            set => row["a012_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a012_leftWristIO
        {
            get => (short)row["a012_leftWristIO"].Value;
            set => row["a012_leftWristIO"].Value = value;
        }

        // Unknown.
        public short a013_rightArmFB
        {
            get => (short)row["a013_rightArmFB"].Value;
            set => row["a013_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a013_rightWristFB
        {
            get => (short)row["a013_rightWristFB"].Value;
            set => row["a013_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a013_rightWristIO
        {
            get => (short)row["a013_rightWristIO"].Value;
            set => row["a013_rightWristIO"].Value = value;
        }

        // Unknown.
        public short a013_leftArmFB
        {
            get => (short)row["a013_leftArmFB"].Value;
            set => row["a013_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a013_leftWristFB
        {
            get => (short)row["a013_leftWristFB"].Value;
            set => row["a013_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a013_leftWristIO
        {
            get => (short)row["a013_leftWristIO"].Value;
            set => row["a013_leftWristIO"].Value = value;
        }

        // Unknown.
        public short a014_rightArmFB
        {
            get => (short)row["a014_rightArmFB"].Value;
            set => row["a014_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a014_rightWristFB
        {
            get => (short)row["a014_rightWristFB"].Value;
            set => row["a014_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a014_rightWristIO
        {
            get => (short)row["a014_rightWristIO"].Value;
            set => row["a014_rightWristIO"].Value = value;
        }

        // Unknown.
        public short a014_leftArmFB
        {
            get => (short)row["a014_leftArmFB"].Value;
            set => row["a014_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a014_leftWristFB
        {
            get => (short)row["a014_leftWristFB"].Value;
            set => row["a014_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a014_leftWristIO
        {
            get => (short)row["a014_leftWristIO"].Value;
            set => row["a014_leftWristIO"].Value = value;
        }

        // Unknown.
        public short a015_rightArmFB
        {
            get => (short)row["a015_rightArmFB"].Value;
            set => row["a015_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a015_rightWristFB
        {
            get => (short)row["a015_rightWristFB"].Value;
            set => row["a015_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a015_rightWristIO
        {
            get => (short)row["a015_rightWristIO"].Value;
            set => row["a015_rightWristIO"].Value = value;
        }

        // Unknown.
        public short a015_leftArmFB
        {
            get => (short)row["a015_leftArmFB"].Value;
            set => row["a015_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a015_leftWristFB
        {
            get => (short)row["a015_leftWristFB"].Value;
            set => row["a015_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a015_leftWristIO
        {
            get => (short)row["a015_leftWristIO"].Value;
            set => row["a015_leftWristIO"].Value = value;
        }

        // Unknown.
        public short a016_rightArmFB
        {
            get => (short)row["a016_rightArmFB"].Value;
            set => row["a016_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a016_rightWristFB
        {
            get => (short)row["a016_rightWristFB"].Value;
            set => row["a016_rightWristFB"].Value = value;
        }

        // Unknown.
        public short a016_rightWristIO
        {
            get => (short)row["a016_rightWristIO"].Value;
            set => row["a016_rightWristIO"].Value = value;
        }

        // Unknown.
        public short a016_leftArmFB
        {
            get => (short)row["a016_leftArmFB"].Value;
            set => row["a016_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a016_leftWristFB
        {
            get => (short)row["a016_leftWristFB"].Value;
            set => row["a016_leftWristFB"].Value = value;
        }

        // Unknown.
        public short a016_leftWristIO
        {
            get => (short)row["a016_leftWristIO"].Value;
            set => row["a016_leftWristIO"].Value = value;
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
    public POSTURE_CONTROL_PARAM_WEP_RIGHT_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public POSTURE_CONTROL_PARAM_WEP_RIGHT_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
