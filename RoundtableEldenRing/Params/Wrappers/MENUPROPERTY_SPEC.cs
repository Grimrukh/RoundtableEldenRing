using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class MENUPROPERTY_SPEC
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        public int CaptionTextID
        {
            get => (int)row["CaptionTextID"].Value;
            set => row["CaptionTextID"].Value = value;
        }

        public int IconID
        {
            get => (int)row["IconID"].Value;
            set => row["IconID"].Value = value;
        }

        public uint RequiredPropertyID
        {
            get => (uint)row["RequiredPropertyID"].Value;
            set => row["RequiredPropertyID"].Value = value;
        }

        public sbyte CompareType
        {
            get => (sbyte)row["CompareType"].Value;
            set => row["CompareType"].Value = value;
        }

        public ushort FormatType
        {
            get => (ushort)row["FormatType"].Value;
            set => row["FormatType"].Value = value;
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
    public MENUPROPERTY_SPEC(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MENUPROPERTY_SPEC(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
