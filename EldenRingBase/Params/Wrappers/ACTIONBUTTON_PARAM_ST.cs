using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class ACTIONBUTTON_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte regionType
        {
            get => (byte)row["regionType"].Value;
            set => row["regionType"].Value = value;
        }

        // Unknown.
        public byte category
        {
            get => (byte)row["category"].Value;
            set => row["category"].Value = value;
        }

        // Unknown.
        public int dummyPoly1
        {
            get => (int)row["dummyPoly1"].Value;
            set => row["dummyPoly1"].Value = value;
        }

        // Unknown.
        public int dummyPoly2
        {
            get => (int)row["dummyPoly2"].Value;
            set => row["dummyPoly2"].Value = value;
        }

        // Unknown.
        public float radius
        {
            get => (float)row["radius"].Value;
            set => row["radius"].Value = value;
        }

        // Unknown.
        public int angle
        {
            get => (int)row["angle"].Value;
            set => row["angle"].Value = value;
        }

        // Unknown.
        public float depth
        {
            get => (float)row["depth"].Value;
            set => row["depth"].Value = value;
        }

        // Unknown.
        public float width
        {
            get => (float)row["width"].Value;
            set => row["width"].Value = value;
        }

        // Unknown.
        public float height
        {
            get => (float)row["height"].Value;
            set => row["height"].Value = value;
        }

        // Unknown.
        public float baseHeightOffset
        {
            get => (float)row["baseHeightOffset"].Value;
            set => row["baseHeightOffset"].Value = value;
        }

        // Unknown.
        public byte angleCheckType
        {
            get => (byte)row["angleCheckType"].Value;
            set => row["angleCheckType"].Value = value;
        }

        // Unknown.
        public int allowAngle
        {
            get => (int)row["allowAngle"].Value;
            set => row["allowAngle"].Value = value;
        }

        // Unknown.
        public int spotDummyPoly
        {
            get => (int)row["spotDummyPoly"].Value;
            set => row["spotDummyPoly"].Value = value;
        }

        // Unknown.
        public byte textBoxType
        {
            get => (byte)row["textBoxType"].Value;
            set => row["textBoxType"].Value = value;
        }

        // Unknown.
        public byte isInvalidForRide
        {
            get => (byte)row["isInvalidForRide"].Value;
            set => row["isInvalidForRide"].Value = value;
        }

        // Unknown.
        public byte isGrayoutForRide
        {
            get => (byte)row["isGrayoutForRide"].Value;
            set => row["isGrayoutForRide"].Value = value;
        }

        // Unknown.
        public byte isInvalidForCrouching
        {
            get => (byte)row["isInvalidForCrouching"].Value;
            set => row["isInvalidForCrouching"].Value = value;
        }

        // Unknown.
        public byte isGrayoutForCrouching
        {
            get => (byte)row["isGrayoutForCrouching"].Value;
            set => row["isGrayoutForCrouching"].Value = value;
        }

        // Unknown.
        public int textId
        {
            get => (int)row["textId"].Value;
            set => row["textId"].Value = value;
        }

        // Unknown.
        public uint invalidFlag
        {
            get => (uint)row["invalidFlag"].Value;
            set => row["invalidFlag"].Value = value;
        }

        // Unknown.
        public uint grayoutFlag
        {
            get => (uint)row["grayoutFlag"].Value;
            set => row["grayoutFlag"].Value = value;
        }

        // Unknown.
        public int overrideActionButtonIdForRide
        {
            get => (int)row["overrideActionButtonIdForRide"].Value;
            set => row["overrideActionButtonIdForRide"].Value = value;
        }

        // Unknown.
        public float execInvalidTime
        {
            get => (float)row["execInvalidTime"].Value;
            set => row["execInvalidTime"].Value = value;
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
    public ACTIONBUTTON_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ACTIONBUTTON_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
