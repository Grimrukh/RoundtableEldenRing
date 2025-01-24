using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class ASSET_MODEL_SFX_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int sfxId_0
        {
            get => (int)row["sfxId_0"].Value;
            set => row["sfxId_0"].Value = value;
        }

        // Unknown.
        public int dmypolyId_0
        {
            get => (int)row["dmypolyId_0"].Value;
            set => row["dmypolyId_0"].Value = value;
        }

        // Unknown.
        public int sfxId_1
        {
            get => (int)row["sfxId_1"].Value;
            set => row["sfxId_1"].Value = value;
        }

        // Unknown.
        public int dmypolyId_1
        {
            get => (int)row["dmypolyId_1"].Value;
            set => row["dmypolyId_1"].Value = value;
        }

        // Unknown.
        public int sfxId_2
        {
            get => (int)row["sfxId_2"].Value;
            set => row["sfxId_2"].Value = value;
        }

        // Unknown.
        public int dmypolyId_2
        {
            get => (int)row["dmypolyId_2"].Value;
            set => row["dmypolyId_2"].Value = value;
        }

        // Unknown.
        public int sfxId_3
        {
            get => (int)row["sfxId_3"].Value;
            set => row["sfxId_3"].Value = value;
        }

        // Unknown.
        public int dmypolyId_3
        {
            get => (int)row["dmypolyId_3"].Value;
            set => row["dmypolyId_3"].Value = value;
        }

        // Unknown.
        public int sfxId_4
        {
            get => (int)row["sfxId_4"].Value;
            set => row["sfxId_4"].Value = value;
        }

        // Unknown.
        public int dmypolyId_4
        {
            get => (int)row["dmypolyId_4"].Value;
            set => row["dmypolyId_4"].Value = value;
        }

        // Unknown.
        public int sfxId_5
        {
            get => (int)row["sfxId_5"].Value;
            set => row["sfxId_5"].Value = value;
        }

        // Unknown.
        public int dmypolyId_5
        {
            get => (int)row["dmypolyId_5"].Value;
            set => row["dmypolyId_5"].Value = value;
        }

        // Unknown.
        public int sfxId_6
        {
            get => (int)row["sfxId_6"].Value;
            set => row["sfxId_6"].Value = value;
        }

        // Unknown.
        public int dmypolyId_6
        {
            get => (int)row["dmypolyId_6"].Value;
            set => row["dmypolyId_6"].Value = value;
        }

        // Unknown.
        public int sfxId_7
        {
            get => (int)row["sfxId_7"].Value;
            set => row["sfxId_7"].Value = value;
        }

        // Unknown.
        public int dmypolyId_7
        {
            get => (int)row["dmypolyId_7"].Value;
            set => row["dmypolyId_7"].Value = value;
        }

        // Unknown.
        public byte isDisableIV
        {
            get => (byte)row["isDisableIV"].Value;
            set => row["isDisableIV"].Value = value;
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
    public ASSET_MODEL_SFX_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ASSET_MODEL_SFX_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
