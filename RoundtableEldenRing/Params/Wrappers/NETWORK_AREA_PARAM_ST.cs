using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class NETWORK_AREA_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float cellSizeX
        {
            get => (float)row["cellSizeX"].Value;
            set => row["cellSizeX"].Value = value;
        }

        // Unknown.
        public float cellSizeY
        {
            get => (float)row["cellSizeY"].Value;
            set => row["cellSizeY"].Value = value;
        }

        // Unknown.
        public float cellSizeZ
        {
            get => (float)row["cellSizeZ"].Value;
            set => row["cellSizeZ"].Value = value;
        }

        // Unknown.
        public float cellOffsetX
        {
            get => (float)row["cellOffsetX"].Value;
            set => row["cellOffsetX"].Value = value;
        }

        // Unknown.
        public float cellOffsetY
        {
            get => (float)row["cellOffsetY"].Value;
            set => row["cellOffsetY"].Value = value;
        }

        // Unknown.
        public float cellOffsetZ
        {
            get => (float)row["cellOffsetZ"].Value;
            set => row["cellOffsetZ"].Value = value;
        }

        // Unknown.
        public byte enableBloodstain
        {
            get => (byte)row["enableBloodstain"].Value;
            set => row["enableBloodstain"].Value = value;
        }

        // Unknown.
        public byte enableBloodMessage
        {
            get => (byte)row["enableBloodMessage"].Value;
            set => row["enableBloodMessage"].Value = value;
        }

        // Unknown.
        public byte enableGhost
        {
            get => (byte)row["enableGhost"].Value;
            set => row["enableGhost"].Value = value;
        }

        // Unknown.
        public byte enableMultiPlay
        {
            get => (byte)row["enableMultiPlay"].Value;
            set => row["enableMultiPlay"].Value = value;
        }

        // Unknown.
        public byte enableRingSearch
        {
            get => (byte)row["enableRingSearch"].Value;
            set => row["enableRingSearch"].Value = value;
        }

        // Unknown.
        public byte enableBreakInSearch
        {
            get => (byte)row["enableBreakInSearch"].Value;
            set => row["enableBreakInSearch"].Value = value;
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
    public NETWORK_AREA_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public NETWORK_AREA_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
