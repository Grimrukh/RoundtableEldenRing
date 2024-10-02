using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class POSTURE_CONTROL_PARAM_GENDER_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public short a000_rightElbowIO
        {
            get => (short)row["a000_rightElbowIO"].Value;
            set => row["a000_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a000_leftElbowIO
        {
            get => (short)row["a000_leftElbowIO"].Value;
            set => row["a000_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a000_bothLegsIO
        {
            get => (short)row["a000_bothLegsIO"].Value;
            set => row["a000_bothLegsIO"].Value = value;
        }

        // Unknown.
        public short a002_rightElbowIO
        {
            get => (short)row["a002_rightElbowIO"].Value;
            set => row["a002_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a002_leftElbowIO
        {
            get => (short)row["a002_leftElbowIO"].Value;
            set => row["a002_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a002_bothLegsIO
        {
            get => (short)row["a002_bothLegsIO"].Value;
            set => row["a002_bothLegsIO"].Value = value;
        }

        // Unknown.
        public short a003_rightElbowIO
        {
            get => (short)row["a003_rightElbowIO"].Value;
            set => row["a003_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a003_leftElbowIO
        {
            get => (short)row["a003_leftElbowIO"].Value;
            set => row["a003_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a003_bothLegsIO
        {
            get => (short)row["a003_bothLegsIO"].Value;
            set => row["a003_bothLegsIO"].Value = value;
        }

        // Unknown.
        public short a010_rightElbowIO
        {
            get => (short)row["a010_rightElbowIO"].Value;
            set => row["a010_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a010_leftElbowIO
        {
            get => (short)row["a010_leftElbowIO"].Value;
            set => row["a010_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a010_bothLegsIO
        {
            get => (short)row["a010_bothLegsIO"].Value;
            set => row["a010_bothLegsIO"].Value = value;
        }

        // Unknown.
        public short a012_rightElbowIO
        {
            get => (short)row["a012_rightElbowIO"].Value;
            set => row["a012_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a012_leftElbowIO
        {
            get => (short)row["a012_leftElbowIO"].Value;
            set => row["a012_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a012_bothLegsIO
        {
            get => (short)row["a012_bothLegsIO"].Value;
            set => row["a012_bothLegsIO"].Value = value;
        }

        // Unknown.
        public short a013_rightElbowIO
        {
            get => (short)row["a013_rightElbowIO"].Value;
            set => row["a013_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a013_leftElbowIO
        {
            get => (short)row["a013_leftElbowIO"].Value;
            set => row["a013_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a013_bothLegsIO
        {
            get => (short)row["a013_bothLegsIO"].Value;
            set => row["a013_bothLegsIO"].Value = value;
        }

        // Unknown.
        public short a014_rightElbowIO
        {
            get => (short)row["a014_rightElbowIO"].Value;
            set => row["a014_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a014_leftElbowIO
        {
            get => (short)row["a014_leftElbowIO"].Value;
            set => row["a014_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a014_bothLegsIO
        {
            get => (short)row["a014_bothLegsIO"].Value;
            set => row["a014_bothLegsIO"].Value = value;
        }

        // Unknown.
        public short a015_rightElbowIO
        {
            get => (short)row["a015_rightElbowIO"].Value;
            set => row["a015_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a015_leftElbowIO
        {
            get => (short)row["a015_leftElbowIO"].Value;
            set => row["a015_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a015_bothLegsIO
        {
            get => (short)row["a015_bothLegsIO"].Value;
            set => row["a015_bothLegsIO"].Value = value;
        }

        // Unknown.
        public short a016_rightElbowIO
        {
            get => (short)row["a016_rightElbowIO"].Value;
            set => row["a016_rightElbowIO"].Value = value;
        }

        // Unknown.
        public short a016_leftElbowIO
        {
            get => (short)row["a016_leftElbowIO"].Value;
            set => row["a016_leftElbowIO"].Value = value;
        }

        // Unknown.
        public short a016_bothLegsIO
        {
            get => (short)row["a016_bothLegsIO"].Value;
            set => row["a016_bothLegsIO"].Value = value;
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
    public POSTURE_CONTROL_PARAM_GENDER_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public POSTURE_CONTROL_PARAM_GENDER_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
