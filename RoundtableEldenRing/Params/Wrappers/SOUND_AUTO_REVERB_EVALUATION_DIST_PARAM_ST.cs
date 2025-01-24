using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class SOUND_AUTO_REVERB_EVALUATION_DIST_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float NoHitDist
        {
            get => (float)row["NoHitDist"].Value;
            set => row["NoHitDist"].Value = value;
        }

        // Unknown.
        public byte isCollectNoHitPoint
        {
            get => (byte)row["isCollectNoHitPoint"].Value;
            set => row["isCollectNoHitPoint"].Value = value;
        }

        // Unknown.
        public byte isCollectOutdoorPoint
        {
            get => (byte)row["isCollectOutdoorPoint"].Value;
            set => row["isCollectOutdoorPoint"].Value = value;
        }

        // Unknown.
        public byte isCollectFloorPoint
        {
            get => (byte)row["isCollectFloorPoint"].Value;
            set => row["isCollectFloorPoint"].Value = value;
        }

        // Unknown.
        public byte distValCalcType
        {
            get => (byte)row["distValCalcType"].Value;
            set => row["distValCalcType"].Value = value;
        }

        // Unknown.
        public float enableLifeTime
        {
            get => (float)row["enableLifeTime"].Value;
            set => row["enableLifeTime"].Value = value;
        }

        // Unknown.
        public uint maxDistRecordNum
        {
            get => (uint)row["maxDistRecordNum"].Value;
            set => row["maxDistRecordNum"].Value = value;
        }

        // Unknown.
        public uint ignoreDistNumForMax
        {
            get => (uint)row["ignoreDistNumForMax"].Value;
            set => row["ignoreDistNumForMax"].Value = value;
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
    public SOUND_AUTO_REVERB_EVALUATION_DIST_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SOUND_AUTO_REVERB_EVALUATION_DIST_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
