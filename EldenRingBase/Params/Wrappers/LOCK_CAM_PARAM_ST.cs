using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class LOCK_CAM_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float camDistTarget
        {
            get => (float)row["camDistTarget"].Value;
            set => row["camDistTarget"].Value = value;
        }

        // Unknown.
        public float rotRangeMinX
        {
            get => (float)row["rotRangeMinX"].Value;
            set => row["rotRangeMinX"].Value = value;
        }

        // Unknown.
        public float lockRotXShiftRatio
        {
            get => (float)row["lockRotXShiftRatio"].Value;
            set => row["lockRotXShiftRatio"].Value = value;
        }

        // Unknown.
        public float chrOrgOffset_Y
        {
            get => (float)row["chrOrgOffset_Y"].Value;
            set => row["chrOrgOffset_Y"].Value = value;
        }

        // Unknown.
        public float chrLockRangeMaxRadius
        {
            get => (float)row["chrLockRangeMaxRadius"].Value;
            set => row["chrLockRangeMaxRadius"].Value = value;
        }

        // Unknown.
        public float camFovY
        {
            get => (float)row["camFovY"].Value;
            set => row["camFovY"].Value = value;
        }

        // Unknown.
        public float chrLockRangeMaxRadius_forD
        {
            get => (float)row["chrLockRangeMaxRadius_forD"].Value;
            set => row["chrLockRangeMaxRadius_forD"].Value = value;
        }

        // Unknown.
        public float chrLockRangeMaxRadius_forPD
        {
            get => (float)row["chrLockRangeMaxRadius_forPD"].Value;
            set => row["chrLockRangeMaxRadius_forPD"].Value = value;
        }

        // Unknown.
        public float closeMaxHeight
        {
            get => (float)row["closeMaxHeight"].Value;
            set => row["closeMaxHeight"].Value = value;
        }

        // Unknown.
        public float closeMinHeight
        {
            get => (float)row["closeMinHeight"].Value;
            set => row["closeMinHeight"].Value = value;
        }

        // Unknown.
        public float closeAngRange
        {
            get => (float)row["closeAngRange"].Value;
            set => row["closeAngRange"].Value = value;
        }

        // Unknown.
        public float closeMaxRadius
        {
            get => (float)row["closeMaxRadius"].Value;
            set => row["closeMaxRadius"].Value = value;
        }

        // Unknown.
        public float closeMaxRadius_forD
        {
            get => (float)row["closeMaxRadius_forD"].Value;
            set => row["closeMaxRadius_forD"].Value = value;
        }

        // Unknown.
        public float closeMaxRadius_forPD
        {
            get => (float)row["closeMaxRadius_forPD"].Value;
            set => row["closeMaxRadius_forPD"].Value = value;
        }

        // Unknown.
        public float bulletMaxRadius
        {
            get => (float)row["bulletMaxRadius"].Value;
            set => row["bulletMaxRadius"].Value = value;
        }

        // Unknown.
        public float bulletMaxRadius_forD
        {
            get => (float)row["bulletMaxRadius_forD"].Value;
            set => row["bulletMaxRadius_forD"].Value = value;
        }

        // Unknown.
        public float bulletMaxRadius_forPD
        {
            get => (float)row["bulletMaxRadius_forPD"].Value;
            set => row["bulletMaxRadius_forPD"].Value = value;
        }

        // Unknown.
        public float bulletAngRange
        {
            get => (float)row["bulletAngRange"].Value;
            set => row["bulletAngRange"].Value = value;
        }

        // Unknown.
        public float lockTgtKeepTime
        {
            get => (float)row["lockTgtKeepTime"].Value;
            set => row["lockTgtKeepTime"].Value = value;
        }

        // Unknown.
        public float chrTransChaseRateForNormal
        {
            get => (float)row["chrTransChaseRateForNormal"].Value;
            set => row["chrTransChaseRateForNormal"].Value = value;
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
    public LOCK_CAM_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public LOCK_CAM_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
