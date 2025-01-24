using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class BEHAVIOR_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int variationId
        {
            get => (int)row["variationId"].Value;
            set => row["variationId"].Value = value;
        }

        // Unknown.
        public int behaviorJudgeId
        {
            get => (int)row["behaviorJudgeId"].Value;
            set => row["behaviorJudgeId"].Value = value;
        }

        // Unknown.
        public byte ezStateBehaviorType_old
        {
            get => (byte)row["ezStateBehaviorType_old"].Value;
            set => row["ezStateBehaviorType_old"].Value = value;
        }

        // Unknown.
        public byte refType
        {
            get => (byte)row["refType"].Value;
            set => row["refType"].Value = value;
        }

        // Unknown.
        public int refId
        {
            get => (int)row["refId"].Value;
            set => row["refId"].Value = value;
        }

        // Unknown.
        public float consumeSA
        {
            get => (float)row["consumeSA"].Value;
            set => row["consumeSA"].Value = value;
        }

        // Unknown.
        public int stamina
        {
            get => (int)row["stamina"].Value;
            set => row["stamina"].Value = value;
        }

        // Unknown.
        public int consumeDurability
        {
            get => (int)row["consumeDurability"].Value;
            set => row["consumeDurability"].Value = value;
        }

        // Unknown.
        public byte category
        {
            get => (byte)row["category"].Value;
            set => row["category"].Value = value;
        }

        // Unknown.
        public byte heroPoint
        {
            get => (byte)row["heroPoint"].Value;
            set => row["heroPoint"].Value = value;
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
    public BEHAVIOR_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public BEHAVIOR_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
