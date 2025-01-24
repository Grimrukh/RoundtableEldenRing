using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class WEP_ABSORP_POS_PARAM_ST
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
        public byte hangPosType
        {
            get => (byte)row["hangPosType"].Value;
            set => row["hangPosType"].Value = value;
        }

        // Unknown.
        public byte isSkeletonBind
        {
            get => (byte)row["isSkeletonBind"].Value;
            set => row["isSkeletonBind"].Value = value;
        }

        // Unknown.
        public short right_0
        {
            get => (short)row["right_0"].Value;
            set => row["right_0"].Value = value;
        }

        // Unknown.
        public short left_0
        {
            get => (short)row["left_0"].Value;
            set => row["left_0"].Value = value;
        }

        // Unknown.
        public short both_0
        {
            get => (short)row["both_0"].Value;
            set => row["both_0"].Value = value;
        }

        // Unknown.
        public short leftHang_0
        {
            get => (short)row["leftHang_0"].Value;
            set => row["leftHang_0"].Value = value;
        }

        // Unknown.
        public short rightHang_0
        {
            get => (short)row["rightHang_0"].Value;
            set => row["rightHang_0"].Value = value;
        }

        // Unknown.
        public short right_1
        {
            get => (short)row["right_1"].Value;
            set => row["right_1"].Value = value;
        }

        // Unknown.
        public short left_1
        {
            get => (short)row["left_1"].Value;
            set => row["left_1"].Value = value;
        }

        // Unknown.
        public short both_1
        {
            get => (short)row["both_1"].Value;
            set => row["both_1"].Value = value;
        }

        // Unknown.
        public short leftHang_1
        {
            get => (short)row["leftHang_1"].Value;
            set => row["leftHang_1"].Value = value;
        }

        // Unknown.
        public short rightHang_1
        {
            get => (short)row["rightHang_1"].Value;
            set => row["rightHang_1"].Value = value;
        }

        // Unknown.
        public short right_2
        {
            get => (short)row["right_2"].Value;
            set => row["right_2"].Value = value;
        }

        // Unknown.
        public short left_2
        {
            get => (short)row["left_2"].Value;
            set => row["left_2"].Value = value;
        }

        // Unknown.
        public short both_2
        {
            get => (short)row["both_2"].Value;
            set => row["both_2"].Value = value;
        }

        // Unknown.
        public short leftHang_2
        {
            get => (short)row["leftHang_2"].Value;
            set => row["leftHang_2"].Value = value;
        }

        // Unknown.
        public short rightHang_2
        {
            get => (short)row["rightHang_2"].Value;
            set => row["rightHang_2"].Value = value;
        }

        // Unknown.
        public short right_3
        {
            get => (short)row["right_3"].Value;
            set => row["right_3"].Value = value;
        }

        // Unknown.
        public short left_3
        {
            get => (short)row["left_3"].Value;
            set => row["left_3"].Value = value;
        }

        // Unknown.
        public short both_3
        {
            get => (short)row["both_3"].Value;
            set => row["both_3"].Value = value;
        }

        // Unknown.
        public short leftHang_3
        {
            get => (short)row["leftHang_3"].Value;
            set => row["leftHang_3"].Value = value;
        }

        // Unknown.
        public short rightHang_3
        {
            get => (short)row["rightHang_3"].Value;
            set => row["rightHang_3"].Value = value;
        }

        // Unknown.
        public byte wepInvisibleType_0
        {
            get => (byte)row["wepInvisibleType_0"].Value;
            set => row["wepInvisibleType_0"].Value = value;
        }

        // Unknown.
        public byte wepInvisibleType_1
        {
            get => (byte)row["wepInvisibleType_1"].Value;
            set => row["wepInvisibleType_1"].Value = value;
        }

        // Unknown.
        public byte wepInvisibleType_2
        {
            get => (byte)row["wepInvisibleType_2"].Value;
            set => row["wepInvisibleType_2"].Value = value;
        }

        // Unknown.
        public byte wepInvisibleType_3
        {
            get => (byte)row["wepInvisibleType_3"].Value;
            set => row["wepInvisibleType_3"].Value = value;
        }

        // Unknown.
        public short leftBoth_0
        {
            get => (short)row["leftBoth_0"].Value;
            set => row["leftBoth_0"].Value = value;
        }

        // Unknown.
        public short leftBoth_1
        {
            get => (short)row["leftBoth_1"].Value;
            set => row["leftBoth_1"].Value = value;
        }

        // Unknown.
        public short leftBoth_2
        {
            get => (short)row["leftBoth_2"].Value;
            set => row["leftBoth_2"].Value = value;
        }

        // Unknown.
        public short leftBoth_3
        {
            get => (short)row["leftBoth_3"].Value;
            set => row["leftBoth_3"].Value = value;
        }

        // Unknown.
        public byte dispPosType_right_0
        {
            get => (byte)row["dispPosType_right_0"].Value;
            set => row["dispPosType_right_0"].Value = value;
        }

        // Unknown.
        public byte dispPosType_left_0
        {
            get => (byte)row["dispPosType_left_0"].Value;
            set => row["dispPosType_left_0"].Value = value;
        }

        // Unknown.
        public byte dispPosType_rightBoth_0
        {
            get => (byte)row["dispPosType_rightBoth_0"].Value;
            set => row["dispPosType_rightBoth_0"].Value = value;
        }

        // Unknown.
        public byte dispPosType_leftBoth_0
        {
            get => (byte)row["dispPosType_leftBoth_0"].Value;
            set => row["dispPosType_leftBoth_0"].Value = value;
        }

        // Unknown.
        public byte dispPosType_rightHang_0
        {
            get => (byte)row["dispPosType_rightHang_0"].Value;
            set => row["dispPosType_rightHang_0"].Value = value;
        }

        // Unknown.
        public byte dispPosType_leftHang_0
        {
            get => (byte)row["dispPosType_leftHang_0"].Value;
            set => row["dispPosType_leftHang_0"].Value = value;
        }

        // Unknown.
        public byte dispPosType_right_1
        {
            get => (byte)row["dispPosType_right_1"].Value;
            set => row["dispPosType_right_1"].Value = value;
        }

        // Unknown.
        public byte dispPosType_left_1
        {
            get => (byte)row["dispPosType_left_1"].Value;
            set => row["dispPosType_left_1"].Value = value;
        }

        // Unknown.
        public byte dispPosType_rightBoth_1
        {
            get => (byte)row["dispPosType_rightBoth_1"].Value;
            set => row["dispPosType_rightBoth_1"].Value = value;
        }

        // Unknown.
        public byte dispPosType_leftBoth_1
        {
            get => (byte)row["dispPosType_leftBoth_1"].Value;
            set => row["dispPosType_leftBoth_1"].Value = value;
        }

        // Unknown.
        public byte dispPosType_rightHang_1
        {
            get => (byte)row["dispPosType_rightHang_1"].Value;
            set => row["dispPosType_rightHang_1"].Value = value;
        }

        // Unknown.
        public byte dispPosType_leftHang_1
        {
            get => (byte)row["dispPosType_leftHang_1"].Value;
            set => row["dispPosType_leftHang_1"].Value = value;
        }

        // Unknown.
        public byte dispPosType_right_2
        {
            get => (byte)row["dispPosType_right_2"].Value;
            set => row["dispPosType_right_2"].Value = value;
        }

        // Unknown.
        public byte dispPosType_left_2
        {
            get => (byte)row["dispPosType_left_2"].Value;
            set => row["dispPosType_left_2"].Value = value;
        }

        // Unknown.
        public byte dispPosType_rightBoth_2
        {
            get => (byte)row["dispPosType_rightBoth_2"].Value;
            set => row["dispPosType_rightBoth_2"].Value = value;
        }

        // Unknown.
        public byte dispPosType_leftBoth_2
        {
            get => (byte)row["dispPosType_leftBoth_2"].Value;
            set => row["dispPosType_leftBoth_2"].Value = value;
        }

        // Unknown.
        public byte dispPosType_rightHang_2
        {
            get => (byte)row["dispPosType_rightHang_2"].Value;
            set => row["dispPosType_rightHang_2"].Value = value;
        }

        // Unknown.
        public byte dispPosType_leftHang_2
        {
            get => (byte)row["dispPosType_leftHang_2"].Value;
            set => row["dispPosType_leftHang_2"].Value = value;
        }

        // Unknown.
        public byte dispPosType_right_3
        {
            get => (byte)row["dispPosType_right_3"].Value;
            set => row["dispPosType_right_3"].Value = value;
        }

        // Unknown.
        public byte dispPosType_left_3
        {
            get => (byte)row["dispPosType_left_3"].Value;
            set => row["dispPosType_left_3"].Value = value;
        }

        // Unknown.
        public byte dispPosType_rightBoth_3
        {
            get => (byte)row["dispPosType_rightBoth_3"].Value;
            set => row["dispPosType_rightBoth_3"].Value = value;
        }

        // Unknown.
        public byte dispPosType_leftBoth_3
        {
            get => (byte)row["dispPosType_leftBoth_3"].Value;
            set => row["dispPosType_leftBoth_3"].Value = value;
        }

        // Unknown.
        public byte dispPosType_rightHang_3
        {
            get => (byte)row["dispPosType_rightHang_3"].Value;
            set => row["dispPosType_rightHang_3"].Value = value;
        }

        // Unknown.
        public byte dispPosType_leftHang_3
        {
            get => (byte)row["dispPosType_leftHang_3"].Value;
            set => row["dispPosType_leftHang_3"].Value = value;
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
    public WEP_ABSORP_POS_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WEP_ABSORP_POS_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
