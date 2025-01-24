using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class CUTSCENE_MAP_ID_PARAM_ST
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
        public uint PlayMapId
        {
            get => (uint)row["PlayMapId"].Value;
            set => row["PlayMapId"].Value = value;
        }

        // Unknown.
        public uint RequireMapId0
        {
            get => (uint)row["RequireMapId0"].Value;
            set => row["RequireMapId0"].Value = value;
        }

        // Unknown.
        public uint RequireMapId1
        {
            get => (uint)row["RequireMapId1"].Value;
            set => row["RequireMapId1"].Value = value;
        }

        // Unknown.
        public uint RequireMapId2
        {
            get => (uint)row["RequireMapId2"].Value;
            set => row["RequireMapId2"].Value = value;
        }

        // Unknown.
        public int RefCamPosHitPartsID
        {
            get => (int)row["RefCamPosHitPartsID"].Value;
            set => row["RefCamPosHitPartsID"].Value = value;
        }

        // Unknown.
        public ushort ClientDisableViewTimeForProgress
        {
            get => (ushort)row["ClientDisableViewTimeForProgress"].Value;
            set => row["ClientDisableViewTimeForProgress"].Value = value;
        }

        // Unknown.
        public int HitParts_0
        {
            get => (int)row["HitParts_0"].Value;
            set => row["HitParts_0"].Value = value;
        }

        // Unknown.
        public int HitParts_1
        {
            get => (int)row["HitParts_1"].Value;
            set => row["HitParts_1"].Value = value;
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
    public CUTSCENE_MAP_ID_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CUTSCENE_MAP_ID_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
