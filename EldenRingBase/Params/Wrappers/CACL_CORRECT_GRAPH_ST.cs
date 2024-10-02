using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class CACL_CORRECT_GRAPH_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float stageMaxVal0
        {
            get => (float)row["stageMaxVal0"].Value;
            set => row["stageMaxVal0"].Value = value;
        }

        // Unknown.
        public float stageMaxVal1
        {
            get => (float)row["stageMaxVal1"].Value;
            set => row["stageMaxVal1"].Value = value;
        }

        // Unknown.
        public float stageMaxVal2
        {
            get => (float)row["stageMaxVal2"].Value;
            set => row["stageMaxVal2"].Value = value;
        }

        // Unknown.
        public float stageMaxVal3
        {
            get => (float)row["stageMaxVal3"].Value;
            set => row["stageMaxVal3"].Value = value;
        }

        // Unknown.
        public float stageMaxVal4
        {
            get => (float)row["stageMaxVal4"].Value;
            set => row["stageMaxVal4"].Value = value;
        }

        // Unknown.
        public float stageMaxGrowVal0
        {
            get => (float)row["stageMaxGrowVal0"].Value;
            set => row["stageMaxGrowVal0"].Value = value;
        }

        // Unknown.
        public float stageMaxGrowVal1
        {
            get => (float)row["stageMaxGrowVal1"].Value;
            set => row["stageMaxGrowVal1"].Value = value;
        }

        // Unknown.
        public float stageMaxGrowVal2
        {
            get => (float)row["stageMaxGrowVal2"].Value;
            set => row["stageMaxGrowVal2"].Value = value;
        }

        // Unknown.
        public float stageMaxGrowVal3
        {
            get => (float)row["stageMaxGrowVal3"].Value;
            set => row["stageMaxGrowVal3"].Value = value;
        }

        // Unknown.
        public float stageMaxGrowVal4
        {
            get => (float)row["stageMaxGrowVal4"].Value;
            set => row["stageMaxGrowVal4"].Value = value;
        }

        // Unknown.
        public float adjPt_maxGrowVal0
        {
            get => (float)row["adjPt_maxGrowVal0"].Value;
            set => row["adjPt_maxGrowVal0"].Value = value;
        }

        // Unknown.
        public float adjPt_maxGrowVal1
        {
            get => (float)row["adjPt_maxGrowVal1"].Value;
            set => row["adjPt_maxGrowVal1"].Value = value;
        }

        // Unknown.
        public float adjPt_maxGrowVal2
        {
            get => (float)row["adjPt_maxGrowVal2"].Value;
            set => row["adjPt_maxGrowVal2"].Value = value;
        }

        // Unknown.
        public float adjPt_maxGrowVal3
        {
            get => (float)row["adjPt_maxGrowVal3"].Value;
            set => row["adjPt_maxGrowVal3"].Value = value;
        }

        // Unknown.
        public float adjPt_maxGrowVal4
        {
            get => (float)row["adjPt_maxGrowVal4"].Value;
            set => row["adjPt_maxGrowVal4"].Value = value;
        }

        // Unknown.
        public float init_inclination_soul
        {
            get => (float)row["init_inclination_soul"].Value;
            set => row["init_inclination_soul"].Value = value;
        }

        // Unknown.
        public float adjustment_value
        {
            get => (float)row["adjustment_value"].Value;
            set => row["adjustment_value"].Value = value;
        }

        // Unknown.
        public float boundry_inclination_soul
        {
            get => (float)row["boundry_inclination_soul"].Value;
            set => row["boundry_inclination_soul"].Value = value;
        }

        // Unknown.
        public float boundry_value
        {
            get => (float)row["boundry_value"].Value;
            set => row["boundry_value"].Value = value;
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
    public CACL_CORRECT_GRAPH_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CACL_CORRECT_GRAPH_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
