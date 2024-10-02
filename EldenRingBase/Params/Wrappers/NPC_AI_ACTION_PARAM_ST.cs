using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class NPC_AI_ACTION_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte moveDir
        {
            get => (byte)row["moveDir"].Value;
            set => row["moveDir"].Value = value;
        }

        // Unknown.
        public byte key1
        {
            get => (byte)row["key1"].Value;
            set => row["key1"].Value = value;
        }

        // Unknown.
        public byte key2
        {
            get => (byte)row["key2"].Value;
            set => row["key2"].Value = value;
        }

        // Unknown.
        public byte key3
        {
            get => (byte)row["key3"].Value;
            set => row["key3"].Value = value;
        }

        // Unknown.
        public byte bMoveDirHold
        {
            get => (byte)row["bMoveDirHold"].Value;
            set => row["bMoveDirHold"].Value = value;
        }

        // Unknown.
        public byte bKeyHold1
        {
            get => (byte)row["bKeyHold1"].Value;
            set => row["bKeyHold1"].Value = value;
        }

        // Unknown.
        public byte bKeyHold2
        {
            get => (byte)row["bKeyHold2"].Value;
            set => row["bKeyHold2"].Value = value;
        }

        // Unknown.
        public byte bKeyHold3
        {
            get => (byte)row["bKeyHold3"].Value;
            set => row["bKeyHold3"].Value = value;
        }

        // Unknown.
        public int gestureId
        {
            get => (int)row["gestureId"].Value;
            set => row["gestureId"].Value = value;
        }

        // Unknown.
        public byte bLifeEndSuccess
        {
            get => (byte)row["bLifeEndSuccess"].Value;
            set => row["bLifeEndSuccess"].Value = value;
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
    public NPC_AI_ACTION_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public NPC_AI_ACTION_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
