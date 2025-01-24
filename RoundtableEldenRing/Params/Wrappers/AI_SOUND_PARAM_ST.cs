using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class AI_SOUND_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float radius
        {
            get => (float)row["radius"].Value;
            set => row["radius"].Value = value;
        }

        // Unknown.
        public float lifeFrame
        {
            get => (float)row["lifeFrame"].Value;
            set => row["lifeFrame"].Value = value;
        }

        // Unknown.
        public byte bSpEffectEnable
        {
            get => (byte)row["bSpEffectEnable"].Value;
            set => row["bSpEffectEnable"].Value = value;
        }

        // Unknown.
        public byte type
        {
            get => (byte)row["type"].Value;
            set => row["type"].Value = value;
        }

        // Unknown.
        public byte opposeTarget
        {
            get => (byte)row["opposeTarget"].Value;
            set => row["opposeTarget"].Value = value;
        }

        // Unknown.
        public byte friendlyTarget
        {
            get => (byte)row["friendlyTarget"].Value;
            set => row["friendlyTarget"].Value = value;
        }

        // Unknown.
        public byte selfTarget
        {
            get => (byte)row["selfTarget"].Value;
            set => row["selfTarget"].Value = value;
        }

        // Unknown.
        public byte disableOnTargetPCompany
        {
            get => (byte)row["disableOnTargetPCompany"].Value;
            set => row["disableOnTargetPCompany"].Value = value;
        }

        // Unknown.
        public byte rank
        {
            get => (byte)row["rank"].Value;
            set => row["rank"].Value = value;
        }

        // Unknown.
        public float forgetTime
        {
            get => (float)row["forgetTime"].Value;
            set => row["forgetTime"].Value = value;
        }

        // Unknown.
        public int priority
        {
            get => (int)row["priority"].Value;
            set => row["priority"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId
        {
            get => (int)row["soundBehaviorId"].Value;
            set => row["soundBehaviorId"].Value = value;
        }

        // Unknown.
        public byte aiSoundLevel
        {
            get => (byte)row["aiSoundLevel"].Value;
            set => row["aiSoundLevel"].Value = value;
        }

        // Unknown.
        public byte replaningState
        {
            get => (byte)row["replaningState"].Value;
            set => row["replaningState"].Value = value;
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
    public AI_SOUND_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public AI_SOUND_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
