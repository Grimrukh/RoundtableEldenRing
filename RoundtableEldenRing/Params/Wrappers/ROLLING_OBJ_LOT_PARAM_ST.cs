using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class ROLLING_OBJ_LOT_PARAM_ST
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
        public int AssetId_0
        {
            get => (int)row["AssetId_0"].Value;
            set => row["AssetId_0"].Value = value;
        }

        // Unknown.
        public int AssetId_1
        {
            get => (int)row["AssetId_1"].Value;
            set => row["AssetId_1"].Value = value;
        }

        // Unknown.
        public int AssetId_2
        {
            get => (int)row["AssetId_2"].Value;
            set => row["AssetId_2"].Value = value;
        }

        // Unknown.
        public int AssetId_3
        {
            get => (int)row["AssetId_3"].Value;
            set => row["AssetId_3"].Value = value;
        }

        // Unknown.
        public int AssetId_4
        {
            get => (int)row["AssetId_4"].Value;
            set => row["AssetId_4"].Value = value;
        }

        // Unknown.
        public int AssetId_5
        {
            get => (int)row["AssetId_5"].Value;
            set => row["AssetId_5"].Value = value;
        }

        // Unknown.
        public int AssetId_6
        {
            get => (int)row["AssetId_6"].Value;
            set => row["AssetId_6"].Value = value;
        }

        // Unknown.
        public int AssetId_7
        {
            get => (int)row["AssetId_7"].Value;
            set => row["AssetId_7"].Value = value;
        }

        // Unknown.
        public byte CreateWeight_0
        {
            get => (byte)row["CreateWeight_0"].Value;
            set => row["CreateWeight_0"].Value = value;
        }

        // Unknown.
        public byte CreateWeight_1
        {
            get => (byte)row["CreateWeight_1"].Value;
            set => row["CreateWeight_1"].Value = value;
        }

        // Unknown.
        public byte CreateWeight_2
        {
            get => (byte)row["CreateWeight_2"].Value;
            set => row["CreateWeight_2"].Value = value;
        }

        // Unknown.
        public byte CreateWeight_3
        {
            get => (byte)row["CreateWeight_3"].Value;
            set => row["CreateWeight_3"].Value = value;
        }

        // Unknown.
        public byte CreateWeight_4
        {
            get => (byte)row["CreateWeight_4"].Value;
            set => row["CreateWeight_4"].Value = value;
        }

        // Unknown.
        public byte CreateWeight_5
        {
            get => (byte)row["CreateWeight_5"].Value;
            set => row["CreateWeight_5"].Value = value;
        }

        // Unknown.
        public byte CreateWeight_6
        {
            get => (byte)row["CreateWeight_6"].Value;
            set => row["CreateWeight_6"].Value = value;
        }

        // Unknown.
        public byte CreateWeight_7
        {
            get => (byte)row["CreateWeight_7"].Value;
            set => row["CreateWeight_7"].Value = value;
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
    public ROLLING_OBJ_LOT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ROLLING_OBJ_LOT_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
