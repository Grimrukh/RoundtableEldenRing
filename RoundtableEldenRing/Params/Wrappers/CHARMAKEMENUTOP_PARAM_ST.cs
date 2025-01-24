using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class CHARMAKEMENUTOP_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int commandType
        {
            get => (int)row["commandType"].Value;
            set => row["commandType"].Value = value;
        }

        // Unknown.
        public int captionId
        {
            get => (int)row["captionId"].Value;
            set => row["captionId"].Value = value;
        }

        // Unknown.
        public int faceParamId
        {
            get => (int)row["faceParamId"].Value;
            set => row["faceParamId"].Value = value;
        }

        // Unknown.
        public int tableId
        {
            get => (int)row["tableId"].Value;
            set => row["tableId"].Value = value;
        }

        // Unknown.
        public int viewCondition
        {
            get => (int)row["viewCondition"].Value;
            set => row["viewCondition"].Value = value;
        }

        // Unknown.
        public sbyte previewMode
        {
            get => (sbyte)row["previewMode"].Value;
            set => row["previewMode"].Value = value;
        }

        // Unknown.
        public int tableId2
        {
            get => (int)row["tableId2"].Value;
            set => row["tableId2"].Value = value;
        }

        // Unknown.
        public int refFaceParamId
        {
            get => (int)row["refFaceParamId"].Value;
            set => row["refFaceParamId"].Value = value;
        }

        // Unknown.
        public int refTextId
        {
            get => (int)row["refTextId"].Value;
            set => row["refTextId"].Value = value;
        }

        // Unknown.
        public int helpTextId
        {
            get => (int)row["helpTextId"].Value;
            set => row["helpTextId"].Value = value;
        }

        // Unknown.
        public uint unlockEventFlagId
        {
            get => (uint)row["unlockEventFlagId"].Value;
            set => row["unlockEventFlagId"].Value = value;
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
    public CHARMAKEMENUTOP_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CHARMAKEMENUTOP_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
