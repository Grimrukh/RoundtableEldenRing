using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class MAP_MIMICRY_ESTABLISHMENT_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float mimicryEstablishment0
        {
            get => (float)row["mimicryEstablishment0"].Value;
            set => row["mimicryEstablishment0"].Value = value;
        }

        // Unknown.
        public float mimicryEstablishment1
        {
            get => (float)row["mimicryEstablishment1"].Value;
            set => row["mimicryEstablishment1"].Value = value;
        }

        // Unknown.
        public float mimicryEstablishment2
        {
            get => (float)row["mimicryEstablishment2"].Value;
            set => row["mimicryEstablishment2"].Value = value;
        }

        // Unknown.
        public int mimicryBeginSfxId0
        {
            get => (int)row["mimicryBeginSfxId0"].Value;
            set => row["mimicryBeginSfxId0"].Value = value;
        }

        // Unknown.
        public int mimicrySfxId0
        {
            get => (int)row["mimicrySfxId0"].Value;
            set => row["mimicrySfxId0"].Value = value;
        }

        // Unknown.
        public int mimicryEndSfxId0
        {
            get => (int)row["mimicryEndSfxId0"].Value;
            set => row["mimicryEndSfxId0"].Value = value;
        }

        // Unknown.
        public int mimicryBeginSfxId1
        {
            get => (int)row["mimicryBeginSfxId1"].Value;
            set => row["mimicryBeginSfxId1"].Value = value;
        }

        // Unknown.
        public int mimicrySfxId1
        {
            get => (int)row["mimicrySfxId1"].Value;
            set => row["mimicrySfxId1"].Value = value;
        }

        // Unknown.
        public int mimicryEndSfxId1
        {
            get => (int)row["mimicryEndSfxId1"].Value;
            set => row["mimicryEndSfxId1"].Value = value;
        }

        // Unknown.
        public int mimicryBeginSfxId2
        {
            get => (int)row["mimicryBeginSfxId2"].Value;
            set => row["mimicryBeginSfxId2"].Value = value;
        }

        // Unknown.
        public int mimicrySfxId2
        {
            get => (int)row["mimicrySfxId2"].Value;
            set => row["mimicrySfxId2"].Value = value;
        }

        // Unknown.
        public int mimicryEndSfxId2
        {
            get => (int)row["mimicryEndSfxId2"].Value;
            set => row["mimicryEndSfxId2"].Value = value;
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
    public MAP_MIMICRY_ESTABLISHMENT_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MAP_MIMICRY_ESTABLISHMENT_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
