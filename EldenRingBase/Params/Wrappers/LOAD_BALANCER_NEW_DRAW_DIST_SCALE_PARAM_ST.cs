using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class LOAD_BALANCER_NEW_DRAW_DIST_SCALE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte DrawDist_LvBegin
        {
            get => (byte)row["DrawDist_LvBegin"].Value;
            set => row["DrawDist_LvBegin"].Value = value;
        }

        // Unknown.
        public byte DrawDist_LvEnd
        {
            get => (byte)row["DrawDist_LvEnd"].Value;
            set => row["DrawDist_LvEnd"].Value = value;
        }

        // Unknown.
        public float DrawDist_ScaleBegin
        {
            get => (float)row["DrawDist_ScaleBegin"].Value;
            set => row["DrawDist_ScaleBegin"].Value = value;
        }

        // Unknown.
        public float DrawDist_ScaleEnd
        {
            get => (float)row["DrawDist_ScaleEnd"].Value;
            set => row["DrawDist_ScaleEnd"].Value = value;
        }

        // Unknown.
        public byte ShadwDrawDist_LvBegin
        {
            get => (byte)row["ShadwDrawDist_LvBegin"].Value;
            set => row["ShadwDrawDist_LvBegin"].Value = value;
        }

        // Unknown.
        public byte ShadwDrawDist_LvEnd
        {
            get => (byte)row["ShadwDrawDist_LvEnd"].Value;
            set => row["ShadwDrawDist_LvEnd"].Value = value;
        }

        // Unknown.
        public float ShadwDrawDist_ScaleBegin
        {
            get => (float)row["ShadwDrawDist_ScaleBegin"].Value;
            set => row["ShadwDrawDist_ScaleBegin"].Value = value;
        }

        // Unknown.
        public float ShadwDrawDist_ScaleEnd
        {
            get => (float)row["ShadwDrawDist_ScaleEnd"].Value;
            set => row["ShadwDrawDist_ScaleEnd"].Value = value;
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
    public LOAD_BALANCER_NEW_DRAW_DIST_SCALE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public LOAD_BALANCER_NEW_DRAW_DIST_SCALE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
