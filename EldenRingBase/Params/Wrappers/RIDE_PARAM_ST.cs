using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class RIDE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public uint atkChrId
        {
            get => (uint)row["atkChrId"].Value;
            set => row["atkChrId"].Value = value;
        }

        // Unknown.
        public uint defChrId
        {
            get => (uint)row["defChrId"].Value;
            set => row["defChrId"].Value = value;
        }

        // Unknown.
        public int rideCamParamId
        {
            get => (int)row["rideCamParamId"].Value;
            set => row["rideCamParamId"].Value = value;
        }

        // Unknown.
        public uint atkChrAnimId
        {
            get => (uint)row["atkChrAnimId"].Value;
            set => row["atkChrAnimId"].Value = value;
        }

        // Unknown.
        public uint defChrAnimId
        {
            get => (uint)row["defChrAnimId"].Value;
            set => row["defChrAnimId"].Value = value;
        }

        // Unknown.
        public int defAdjustDmyId
        {
            get => (int)row["defAdjustDmyId"].Value;
            set => row["defAdjustDmyId"].Value = value;
        }

        // Unknown.
        public int defCheckDmyId
        {
            get => (int)row["defCheckDmyId"].Value;
            set => row["defCheckDmyId"].Value = value;
        }

        // Unknown.
        public float diffAngMyToDef
        {
            get => (float)row["diffAngMyToDef"].Value;
            set => row["diffAngMyToDef"].Value = value;
        }

        // Unknown.
        public float dist
        {
            get => (float)row["dist"].Value;
            set => row["dist"].Value = value;
        }

        // Unknown.
        public float upperYRange
        {
            get => (float)row["upperYRange"].Value;
            set => row["upperYRange"].Value = value;
        }

        // Unknown.
        public float lowerYRange
        {
            get => (float)row["lowerYRange"].Value;
            set => row["lowerYRange"].Value = value;
        }

        // Unknown.
        public float diffAngMin
        {
            get => (float)row["diffAngMin"].Value;
            set => row["diffAngMin"].Value = value;
        }

        // Unknown.
        public float diffAngMax
        {
            get => (float)row["diffAngMax"].Value;
            set => row["diffAngMax"].Value = value;
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
    public RIDE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public RIDE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
