using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class POSTURE_CONTROL_PARAM_PRO_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public short a000_rightArmIO
        {
            get => (short)row["a000_rightArmIO"].Value;
            set => row["a000_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a000_rightArmFB
        {
            get => (short)row["a000_rightArmFB"].Value;
            set => row["a000_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a000_leftArmIO
        {
            get => (short)row["a000_leftArmIO"].Value;
            set => row["a000_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a000_leftArmFB
        {
            get => (short)row["a000_leftArmFB"].Value;
            set => row["a000_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a002_rightArmIO
        {
            get => (short)row["a002_rightArmIO"].Value;
            set => row["a002_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a002_rightArmFB
        {
            get => (short)row["a002_rightArmFB"].Value;
            set => row["a002_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a002_leftArmIO
        {
            get => (short)row["a002_leftArmIO"].Value;
            set => row["a002_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a002_leftArmFB
        {
            get => (short)row["a002_leftArmFB"].Value;
            set => row["a002_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a003_rightArmIO
        {
            get => (short)row["a003_rightArmIO"].Value;
            set => row["a003_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a003_rightArmFB
        {
            get => (short)row["a003_rightArmFB"].Value;
            set => row["a003_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a003_leftArmIO
        {
            get => (short)row["a003_leftArmIO"].Value;
            set => row["a003_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a003_leftArmFB
        {
            get => (short)row["a003_leftArmFB"].Value;
            set => row["a003_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a010_rightArmIO
        {
            get => (short)row["a010_rightArmIO"].Value;
            set => row["a010_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a010_rightArmFB
        {
            get => (short)row["a010_rightArmFB"].Value;
            set => row["a010_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a010_leftArmIO
        {
            get => (short)row["a010_leftArmIO"].Value;
            set => row["a010_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a010_leftArmFB
        {
            get => (short)row["a010_leftArmFB"].Value;
            set => row["a010_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a012_rightArmIO
        {
            get => (short)row["a012_rightArmIO"].Value;
            set => row["a012_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a012_rightArmFB
        {
            get => (short)row["a012_rightArmFB"].Value;
            set => row["a012_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a012_leftArmIO
        {
            get => (short)row["a012_leftArmIO"].Value;
            set => row["a012_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a012_leftArmFB
        {
            get => (short)row["a012_leftArmFB"].Value;
            set => row["a012_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a013_rightArmIO
        {
            get => (short)row["a013_rightArmIO"].Value;
            set => row["a013_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a013_rightArmFB
        {
            get => (short)row["a013_rightArmFB"].Value;
            set => row["a013_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a013_leftArmIO
        {
            get => (short)row["a013_leftArmIO"].Value;
            set => row["a013_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a013_leftArmFB
        {
            get => (short)row["a013_leftArmFB"].Value;
            set => row["a013_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a014_rightArmIO
        {
            get => (short)row["a014_rightArmIO"].Value;
            set => row["a014_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a014_rightArmFB
        {
            get => (short)row["a014_rightArmFB"].Value;
            set => row["a014_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a014_leftArmIO
        {
            get => (short)row["a014_leftArmIO"].Value;
            set => row["a014_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a014_leftArmFB
        {
            get => (short)row["a014_leftArmFB"].Value;
            set => row["a014_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a015_rightArmIO
        {
            get => (short)row["a015_rightArmIO"].Value;
            set => row["a015_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a015_rightArmFB
        {
            get => (short)row["a015_rightArmFB"].Value;
            set => row["a015_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a015_leftArmIO
        {
            get => (short)row["a015_leftArmIO"].Value;
            set => row["a015_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a015_leftArmFB
        {
            get => (short)row["a015_leftArmFB"].Value;
            set => row["a015_leftArmFB"].Value = value;
        }

        // Unknown.
        public short a016_rightArmIO
        {
            get => (short)row["a016_rightArmIO"].Value;
            set => row["a016_rightArmIO"].Value = value;
        }

        // Unknown.
        public short a016_rightArmFB
        {
            get => (short)row["a016_rightArmFB"].Value;
            set => row["a016_rightArmFB"].Value = value;
        }

        // Unknown.
        public short a016_leftArmIO
        {
            get => (short)row["a016_leftArmIO"].Value;
            set => row["a016_leftArmIO"].Value = value;
        }

        // Unknown.
        public short a016_leftArmFB
        {
            get => (short)row["a016_leftArmFB"].Value;
            set => row["a016_leftArmFB"].Value = value;
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
    public POSTURE_CONTROL_PARAM_PRO_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public POSTURE_CONTROL_PARAM_PRO_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
