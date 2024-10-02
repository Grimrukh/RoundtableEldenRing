using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class BUDDY_PARAM_ST
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
        public int triggerSpEffectId
        {
            get => (int)row["triggerSpEffectId"].Value;
            set => row["triggerSpEffectId"].Value = value;
        }

        // Unknown.
        public int npcParamId
        {
            get => (int)row["npcParamId"].Value;
            set => row["npcParamId"].Value = value;
        }

        // Unknown.
        public int npcThinkParamId
        {
            get => (int)row["npcThinkParamId"].Value;
            set => row["npcThinkParamId"].Value = value;
        }

        // Unknown.
        public int npcParamId_ridden
        {
            get => (int)row["npcParamId_ridden"].Value;
            set => row["npcParamId_ridden"].Value = value;
        }

        // Unknown.
        public int npcThinkParamId_ridden
        {
            get => (int)row["npcThinkParamId_ridden"].Value;
            set => row["npcThinkParamId_ridden"].Value = value;
        }

        // Unknown.
        public float x_offset
        {
            get => (float)row["x_offset"].Value;
            set => row["x_offset"].Value = value;
        }

        // Unknown.
        public float z_offset
        {
            get => (float)row["z_offset"].Value;
            set => row["z_offset"].Value = value;
        }

        // Unknown.
        public float y_angle
        {
            get => (float)row["y_angle"].Value;
            set => row["y_angle"].Value = value;
        }

        // Unknown.
        public byte appearOnAroundSekihi
        {
            get => (byte)row["appearOnAroundSekihi"].Value;
            set => row["appearOnAroundSekihi"].Value = value;
        }

        // Unknown.
        public byte disablePCTargetShare
        {
            get => (byte)row["disablePCTargetShare"].Value;
            set => row["disablePCTargetShare"].Value = value;
        }

        // Unknown.
        public byte pcFollowType
        {
            get => (byte)row["pcFollowType"].Value;
            set => row["pcFollowType"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv0
        {
            get => (int)row["dopingSpEffect_lv0"].Value;
            set => row["dopingSpEffect_lv0"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv1
        {
            get => (int)row["dopingSpEffect_lv1"].Value;
            set => row["dopingSpEffect_lv1"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv2
        {
            get => (int)row["dopingSpEffect_lv2"].Value;
            set => row["dopingSpEffect_lv2"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv3
        {
            get => (int)row["dopingSpEffect_lv3"].Value;
            set => row["dopingSpEffect_lv3"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv4
        {
            get => (int)row["dopingSpEffect_lv4"].Value;
            set => row["dopingSpEffect_lv4"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv5
        {
            get => (int)row["dopingSpEffect_lv5"].Value;
            set => row["dopingSpEffect_lv5"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv6
        {
            get => (int)row["dopingSpEffect_lv6"].Value;
            set => row["dopingSpEffect_lv6"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv7
        {
            get => (int)row["dopingSpEffect_lv7"].Value;
            set => row["dopingSpEffect_lv7"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv8
        {
            get => (int)row["dopingSpEffect_lv8"].Value;
            set => row["dopingSpEffect_lv8"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv9
        {
            get => (int)row["dopingSpEffect_lv9"].Value;
            set => row["dopingSpEffect_lv9"].Value = value;
        }

        // Unknown.
        public int dopingSpEffect_lv10
        {
            get => (int)row["dopingSpEffect_lv10"].Value;
            set => row["dopingSpEffect_lv10"].Value = value;
        }

        // Unknown.
        public int npcPlayerInitParamId
        {
            get => (int)row["npcPlayerInitParamId"].Value;
            set => row["npcPlayerInitParamId"].Value = value;
        }

        // Unknown.
        public int generateAnimId
        {
            get => (int)row["generateAnimId"].Value;
            set => row["generateAnimId"].Value = value;
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
    public BUDDY_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public BUDDY_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
