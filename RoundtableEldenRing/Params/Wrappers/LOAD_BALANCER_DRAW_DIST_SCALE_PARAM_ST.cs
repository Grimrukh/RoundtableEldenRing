using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class LOAD_BALANCER_DRAW_DIST_SCALE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float Lv00
        {
            get => (float)row["Lv00"].Value;
            set => row["Lv00"].Value = value;
        }

        // Unknown.
        public float Lv01
        {
            get => (float)row["Lv01"].Value;
            set => row["Lv01"].Value = value;
        }

        // Unknown.
        public float Lv02
        {
            get => (float)row["Lv02"].Value;
            set => row["Lv02"].Value = value;
        }

        // Unknown.
        public float Lv03
        {
            get => (float)row["Lv03"].Value;
            set => row["Lv03"].Value = value;
        }

        // Unknown.
        public float Lv04
        {
            get => (float)row["Lv04"].Value;
            set => row["Lv04"].Value = value;
        }

        // Unknown.
        public float Lv05
        {
            get => (float)row["Lv05"].Value;
            set => row["Lv05"].Value = value;
        }

        // Unknown.
        public float Lv06
        {
            get => (float)row["Lv06"].Value;
            set => row["Lv06"].Value = value;
        }

        // Unknown.
        public float Lv07
        {
            get => (float)row["Lv07"].Value;
            set => row["Lv07"].Value = value;
        }

        // Unknown.
        public float Lv08
        {
            get => (float)row["Lv08"].Value;
            set => row["Lv08"].Value = value;
        }

        // Unknown.
        public float Lv09
        {
            get => (float)row["Lv09"].Value;
            set => row["Lv09"].Value = value;
        }

        // Unknown.
        public float Lv10
        {
            get => (float)row["Lv10"].Value;
            set => row["Lv10"].Value = value;
        }

        // Unknown.
        public float Lv11
        {
            get => (float)row["Lv11"].Value;
            set => row["Lv11"].Value = value;
        }

        // Unknown.
        public float Lv12
        {
            get => (float)row["Lv12"].Value;
            set => row["Lv12"].Value = value;
        }

        // Unknown.
        public float Lv13
        {
            get => (float)row["Lv13"].Value;
            set => row["Lv13"].Value = value;
        }

        // Unknown.
        public float Lv14
        {
            get => (float)row["Lv14"].Value;
            set => row["Lv14"].Value = value;
        }

        // Unknown.
        public float Lv15
        {
            get => (float)row["Lv15"].Value;
            set => row["Lv15"].Value = value;
        }

        // Unknown.
        public float Lv16
        {
            get => (float)row["Lv16"].Value;
            set => row["Lv16"].Value = value;
        }

        // Unknown.
        public float Lv17
        {
            get => (float)row["Lv17"].Value;
            set => row["Lv17"].Value = value;
        }

        // Unknown.
        public float Lv18
        {
            get => (float)row["Lv18"].Value;
            set => row["Lv18"].Value = value;
        }

        // Unknown.
        public float Lv19
        {
            get => (float)row["Lv19"].Value;
            set => row["Lv19"].Value = value;
        }

        // Unknown.
        public float Lv20
        {
            get => (float)row["Lv20"].Value;
            set => row["Lv20"].Value = value;
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
    public LOAD_BALANCER_DRAW_DIST_SCALE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public LOAD_BALANCER_DRAW_DIST_SCALE_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
