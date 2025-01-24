using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class THROW_DIRECTION_SFX_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int sfxId_00
        {
            get => (int)row["sfxId_00"].Value;
            set => row["sfxId_00"].Value = value;
        }

        // Unknown.
        public int sfxId_01
        {
            get => (int)row["sfxId_01"].Value;
            set => row["sfxId_01"].Value = value;
        }

        // Unknown.
        public int sfxId_02
        {
            get => (int)row["sfxId_02"].Value;
            set => row["sfxId_02"].Value = value;
        }

        // Unknown.
        public int sfxId_03
        {
            get => (int)row["sfxId_03"].Value;
            set => row["sfxId_03"].Value = value;
        }

        // Unknown.
        public int sfxId_04
        {
            get => (int)row["sfxId_04"].Value;
            set => row["sfxId_04"].Value = value;
        }

        // Unknown.
        public int sfxId_05
        {
            get => (int)row["sfxId_05"].Value;
            set => row["sfxId_05"].Value = value;
        }

        // Unknown.
        public int sfxId_06
        {
            get => (int)row["sfxId_06"].Value;
            set => row["sfxId_06"].Value = value;
        }

        // Unknown.
        public int sfxId_07
        {
            get => (int)row["sfxId_07"].Value;
            set => row["sfxId_07"].Value = value;
        }

        // Unknown.
        public int sfxId_08
        {
            get => (int)row["sfxId_08"].Value;
            set => row["sfxId_08"].Value = value;
        }

        // Unknown.
        public int sfxId_09
        {
            get => (int)row["sfxId_09"].Value;
            set => row["sfxId_09"].Value = value;
        }

        // Unknown.
        public int sfxId_10
        {
            get => (int)row["sfxId_10"].Value;
            set => row["sfxId_10"].Value = value;
        }

        // Unknown.
        public int sfxId_11
        {
            get => (int)row["sfxId_11"].Value;
            set => row["sfxId_11"].Value = value;
        }

        // Unknown.
        public int sfxId_12
        {
            get => (int)row["sfxId_12"].Value;
            set => row["sfxId_12"].Value = value;
        }

        // Unknown.
        public int sfxId_13
        {
            get => (int)row["sfxId_13"].Value;
            set => row["sfxId_13"].Value = value;
        }

        // Unknown.
        public int sfxId_14
        {
            get => (int)row["sfxId_14"].Value;
            set => row["sfxId_14"].Value = value;
        }

        // Unknown.
        public int sfxId_15
        {
            get => (int)row["sfxId_15"].Value;
            set => row["sfxId_15"].Value = value;
        }

        // Unknown.
        public int sfxId_16
        {
            get => (int)row["sfxId_16"].Value;
            set => row["sfxId_16"].Value = value;
        }

        // Unknown.
        public int sfxId_17
        {
            get => (int)row["sfxId_17"].Value;
            set => row["sfxId_17"].Value = value;
        }

        // Unknown.
        public int sfxId_18
        {
            get => (int)row["sfxId_18"].Value;
            set => row["sfxId_18"].Value = value;
        }

        // Unknown.
        public int sfxId_19
        {
            get => (int)row["sfxId_19"].Value;
            set => row["sfxId_19"].Value = value;
        }

        // Unknown.
        public int sfxId_20
        {
            get => (int)row["sfxId_20"].Value;
            set => row["sfxId_20"].Value = value;
        }

        // Unknown.
        public int sfxId_21
        {
            get => (int)row["sfxId_21"].Value;
            set => row["sfxId_21"].Value = value;
        }

        // Unknown.
        public int sfxId_22
        {
            get => (int)row["sfxId_22"].Value;
            set => row["sfxId_22"].Value = value;
        }

        // Unknown.
        public int sfxId_23
        {
            get => (int)row["sfxId_23"].Value;
            set => row["sfxId_23"].Value = value;
        }

        // Unknown.
        public int sfxId_24
        {
            get => (int)row["sfxId_24"].Value;
            set => row["sfxId_24"].Value = value;
        }

        // Unknown.
        public int sfxId_25
        {
            get => (int)row["sfxId_25"].Value;
            set => row["sfxId_25"].Value = value;
        }

        // Unknown.
        public int sfxId_26
        {
            get => (int)row["sfxId_26"].Value;
            set => row["sfxId_26"].Value = value;
        }

        // Unknown.
        public int sfxId_27
        {
            get => (int)row["sfxId_27"].Value;
            set => row["sfxId_27"].Value = value;
        }

        // Unknown.
        public int sfxId_28
        {
            get => (int)row["sfxId_28"].Value;
            set => row["sfxId_28"].Value = value;
        }

        // Unknown.
        public int sfxId_29
        {
            get => (int)row["sfxId_29"].Value;
            set => row["sfxId_29"].Value = value;
        }

        // Unknown.
        public int sfxId_30
        {
            get => (int)row["sfxId_30"].Value;
            set => row["sfxId_30"].Value = value;
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
    public THROW_DIRECTION_SFX_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public THROW_DIRECTION_SFX_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
