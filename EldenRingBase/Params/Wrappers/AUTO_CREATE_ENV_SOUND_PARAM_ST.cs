using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class AUTO_CREATE_ENV_SOUND_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float RangeMin
        {
            get => (float)row["RangeMin"].Value;
            set => row["RangeMin"].Value = value;
        }

        // Unknown.
        public float RangeMax
        {
            get => (float)row["RangeMax"].Value;
            set => row["RangeMax"].Value = value;
        }

        // Unknown.
        public float LifeTimeMin
        {
            get => (float)row["LifeTimeMin"].Value;
            set => row["LifeTimeMin"].Value = value;
        }

        // Unknown.
        public float LifeTimeMax
        {
            get => (float)row["LifeTimeMax"].Value;
            set => row["LifeTimeMax"].Value = value;
        }

        // Unknown.
        public float DeleteDist
        {
            get => (float)row["DeleteDist"].Value;
            set => row["DeleteDist"].Value = value;
        }

        // Unknown.
        public float NearDist
        {
            get => (float)row["NearDist"].Value;
            set => row["NearDist"].Value = value;
        }

        // Unknown.
        public float LimiteRotateMin
        {
            get => (float)row["LimiteRotateMin"].Value;
            set => row["LimiteRotateMin"].Value = value;
        }

        // Unknown.
        public float LimiteRotateMax
        {
            get => (float)row["LimiteRotateMax"].Value;
            set => row["LimiteRotateMax"].Value = value;
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
    public AUTO_CREATE_ENV_SOUND_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public AUTO_CREATE_ENV_SOUND_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
