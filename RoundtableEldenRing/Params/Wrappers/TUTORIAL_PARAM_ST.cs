using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class TUTORIAL_PARAM_ST
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
        public byte menuType
        {
            get => (byte)row["menuType"].Value;
            set => row["menuType"].Value = value;
        }

        // Unknown.
        public byte triggerType
        {
            get => (byte)row["triggerType"].Value;
            set => row["triggerType"].Value = value;
        }

        // Unknown.
        public byte repeatType
        {
            get => (byte)row["repeatType"].Value;
            set => row["repeatType"].Value = value;
        }

        // Unknown.
        public ushort imageId
        {
            get => (ushort)row["imageId"].Value;
            set => row["imageId"].Value = value;
        }

        // Unknown.
        public uint unlockEventFlagId
        {
            get => (uint)row["unlockEventFlagId"].Value;
            set => row["unlockEventFlagId"].Value = value;
        }

        // Unknown.
        public int textId
        {
            get => (int)row["textId"].Value;
            set => row["textId"].Value = value;
        }

        // Unknown.
        public float displayMinTime
        {
            get => (float)row["displayMinTime"].Value;
            set => row["displayMinTime"].Value = value;
        }

        // Unknown.
        public float displayTime
        {
            get => (float)row["displayTime"].Value;
            set => row["displayTime"].Value = value;
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
    public TUTORIAL_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public TUTORIAL_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
