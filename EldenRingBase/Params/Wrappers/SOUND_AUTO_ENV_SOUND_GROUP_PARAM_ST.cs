using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class SOUND_AUTO_ENV_SOUND_GROUP_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int SoundNo
        {
            get => (int)row["SoundNo"].Value;
            set => row["SoundNo"].Value = value;
        }

        // Unknown.
        public float ExpandRange
        {
            get => (float)row["ExpandRange"].Value;
            set => row["ExpandRange"].Value = value;
        }

        // Unknown.
        public float FollowSpeed
        {
            get => (float)row["FollowSpeed"].Value;
            set => row["FollowSpeed"].Value = value;
        }

        // Unknown.
        public float FollowRate
        {
            get => (float)row["FollowRate"].Value;
            set => row["FollowRate"].Value = value;
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
    public SOUND_AUTO_ENV_SOUND_GROUP_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SOUND_AUTO_ENV_SOUND_GROUP_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
