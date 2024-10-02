using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MENU_OFFSCR_REND_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float camAtPosX
        {
            get => (float)row["camAtPosX"].Value;
            set => row["camAtPosX"].Value = value;
        }

        // Unknown.
        public float camAtPosY
        {
            get => (float)row["camAtPosY"].Value;
            set => row["camAtPosY"].Value = value;
        }

        // Unknown.
        public float camAtPosZ
        {
            get => (float)row["camAtPosZ"].Value;
            set => row["camAtPosZ"].Value = value;
        }

        // Unknown.
        public float camDist
        {
            get => (float)row["camDist"].Value;
            set => row["camDist"].Value = value;
        }

        // Unknown.
        public float camRotX
        {
            get => (float)row["camRotX"].Value;
            set => row["camRotX"].Value = value;
        }

        // Unknown.
        public float camRotY
        {
            get => (float)row["camRotY"].Value;
            set => row["camRotY"].Value = value;
        }

        // Unknown.
        public float camFov
        {
            get => (float)row["camFov"].Value;
            set => row["camFov"].Value = value;
        }

        // Unknown.
        public float camDistMin
        {
            get => (float)row["camDistMin"].Value;
            set => row["camDistMin"].Value = value;
        }

        // Unknown.
        public float camDistMax
        {
            get => (float)row["camDistMax"].Value;
            set => row["camDistMax"].Value = value;
        }

        // Unknown.
        public float camRotXMin
        {
            get => (float)row["camRotXMin"].Value;
            set => row["camRotXMin"].Value = value;
        }

        // Unknown.
        public float camRotXMax
        {
            get => (float)row["camRotXMax"].Value;
            set => row["camRotXMax"].Value = value;
        }

        // Unknown.
        public uint GparamID
        {
            get => (uint)row["GparamID"].Value;
            set => row["GparamID"].Value = value;
        }

        // Unknown.
        public uint envTexId
        {
            get => (uint)row["envTexId"].Value;
            set => row["envTexId"].Value = value;
        }

        // Unknown.
        public uint Grapm_ID_forPS4
        {
            get => (uint)row["Grapm_ID_forPS4"].Value;
            set => row["Grapm_ID_forPS4"].Value = value;
        }

        // Unknown.
        public uint Grapm_ID_forXB1
        {
            get => (uint)row["Grapm_ID_forXB1"].Value;
            set => row["Grapm_ID_forXB1"].Value = value;
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
    public MENU_OFFSCR_REND_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MENU_OFFSCR_REND_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
