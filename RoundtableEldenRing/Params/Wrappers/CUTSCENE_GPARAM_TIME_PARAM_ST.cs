using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class CUTSCENE_GPARAM_TIME_PARAM_ST
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
        public byte disableParam_Debug
        {
            get => (byte)row["disableParam_Debug"].Value;
            set => row["disableParam_Debug"].Value = value;
        }

        // Unknown.
        public byte DstTimezone_Morning
        {
            get => (byte)row["DstTimezone_Morning"].Value;
            set => row["DstTimezone_Morning"].Value = value;
        }

        // Unknown.
        public byte DstTimezone_Noon
        {
            get => (byte)row["DstTimezone_Noon"].Value;
            set => row["DstTimezone_Noon"].Value = value;
        }

        // Unknown.
        public byte DstTimezone_AfterNoon
        {
            get => (byte)row["DstTimezone_AfterNoon"].Value;
            set => row["DstTimezone_AfterNoon"].Value = value;
        }

        // Unknown.
        public byte DstTimezone_Evening
        {
            get => (byte)row["DstTimezone_Evening"].Value;
            set => row["DstTimezone_Evening"].Value = value;
        }

        // Unknown.
        public byte DstTimezone_Night
        {
            get => (byte)row["DstTimezone_Night"].Value;
            set => row["DstTimezone_Night"].Value = value;
        }

        // Unknown.
        public byte DstTimezone_DeepNightA
        {
            get => (byte)row["DstTimezone_DeepNightA"].Value;
            set => row["DstTimezone_DeepNightA"].Value = value;
        }

        // Unknown.
        public byte DstTimezone_DeepNightB
        {
            get => (byte)row["DstTimezone_DeepNightB"].Value;
            set => row["DstTimezone_DeepNightB"].Value = value;
        }

        // Unknown.
        public float PostPlayIngameTime
        {
            get => (float)row["PostPlayIngameTime"].Value;
            set => row["PostPlayIngameTime"].Value = value;
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
    public CUTSCENE_GPARAM_TIME_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CUTSCENE_GPARAM_TIME_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
