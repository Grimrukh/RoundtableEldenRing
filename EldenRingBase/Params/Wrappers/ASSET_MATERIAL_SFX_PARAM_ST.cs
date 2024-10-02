using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class ASSET_MATERIAL_SFX_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public uint sfxId_00
        {
            get => (uint)row["sfxId_00"].Value;
            set => row["sfxId_00"].Value = value;
        }

        // Unknown.
        public uint sfxId_01
        {
            get => (uint)row["sfxId_01"].Value;
            set => row["sfxId_01"].Value = value;
        }

        // Unknown.
        public uint sfxId_02
        {
            get => (uint)row["sfxId_02"].Value;
            set => row["sfxId_02"].Value = value;
        }

        // Unknown.
        public uint sfxId_03
        {
            get => (uint)row["sfxId_03"].Value;
            set => row["sfxId_03"].Value = value;
        }

        // Unknown.
        public uint sfxId_04
        {
            get => (uint)row["sfxId_04"].Value;
            set => row["sfxId_04"].Value = value;
        }

        // Unknown.
        public uint sfxId_05
        {
            get => (uint)row["sfxId_05"].Value;
            set => row["sfxId_05"].Value = value;
        }

        // Unknown.
        public uint sfxId_06
        {
            get => (uint)row["sfxId_06"].Value;
            set => row["sfxId_06"].Value = value;
        }

        // Unknown.
        public uint sfxId_07
        {
            get => (uint)row["sfxId_07"].Value;
            set => row["sfxId_07"].Value = value;
        }

        // Unknown.
        public uint sfxId_08
        {
            get => (uint)row["sfxId_08"].Value;
            set => row["sfxId_08"].Value = value;
        }

        // Unknown.
        public uint sfxId_09
        {
            get => (uint)row["sfxId_09"].Value;
            set => row["sfxId_09"].Value = value;
        }

        // Unknown.
        public uint sfxId_10
        {
            get => (uint)row["sfxId_10"].Value;
            set => row["sfxId_10"].Value = value;
        }

        // Unknown.
        public uint sfxId_11
        {
            get => (uint)row["sfxId_11"].Value;
            set => row["sfxId_11"].Value = value;
        }

        // Unknown.
        public uint sfxId_12
        {
            get => (uint)row["sfxId_12"].Value;
            set => row["sfxId_12"].Value = value;
        }

        // Unknown.
        public uint sfxId_13
        {
            get => (uint)row["sfxId_13"].Value;
            set => row["sfxId_13"].Value = value;
        }

        // Unknown.
        public uint sfxId_14
        {
            get => (uint)row["sfxId_14"].Value;
            set => row["sfxId_14"].Value = value;
        }

        // Unknown.
        public uint sfxId_15
        {
            get => (uint)row["sfxId_15"].Value;
            set => row["sfxId_15"].Value = value;
        }

        // Unknown.
        public uint sfxId_16
        {
            get => (uint)row["sfxId_16"].Value;
            set => row["sfxId_16"].Value = value;
        }

        // Unknown.
        public uint sfxId_17
        {
            get => (uint)row["sfxId_17"].Value;
            set => row["sfxId_17"].Value = value;
        }

        // Unknown.
        public uint sfxId_18
        {
            get => (uint)row["sfxId_18"].Value;
            set => row["sfxId_18"].Value = value;
        }

        // Unknown.
        public uint sfxId_19
        {
            get => (uint)row["sfxId_19"].Value;
            set => row["sfxId_19"].Value = value;
        }

        // Unknown.
        public uint sfxId_20
        {
            get => (uint)row["sfxId_20"].Value;
            set => row["sfxId_20"].Value = value;
        }

        // Unknown.
        public uint sfxId_21
        {
            get => (uint)row["sfxId_21"].Value;
            set => row["sfxId_21"].Value = value;
        }

        // Unknown.
        public uint sfxId_22
        {
            get => (uint)row["sfxId_22"].Value;
            set => row["sfxId_22"].Value = value;
        }

        // Unknown.
        public uint sfxId_23
        {
            get => (uint)row["sfxId_23"].Value;
            set => row["sfxId_23"].Value = value;
        }

        // Unknown.
        public uint sfxId_24
        {
            get => (uint)row["sfxId_24"].Value;
            set => row["sfxId_24"].Value = value;
        }

        // Unknown.
        public uint sfxId_25
        {
            get => (uint)row["sfxId_25"].Value;
            set => row["sfxId_25"].Value = value;
        }

        // Unknown.
        public uint sfxId_26
        {
            get => (uint)row["sfxId_26"].Value;
            set => row["sfxId_26"].Value = value;
        }

        // Unknown.
        public uint sfxId_27
        {
            get => (uint)row["sfxId_27"].Value;
            set => row["sfxId_27"].Value = value;
        }

        // Unknown.
        public uint sfxId_28
        {
            get => (uint)row["sfxId_28"].Value;
            set => row["sfxId_28"].Value = value;
        }

        // Unknown.
        public uint sfxId_29
        {
            get => (uint)row["sfxId_29"].Value;
            set => row["sfxId_29"].Value = value;
        }

        // Unknown.
        public uint sfxId_30
        {
            get => (uint)row["sfxId_30"].Value;
            set => row["sfxId_30"].Value = value;
        }

        // Unknown.
        public uint sfxId_31
        {
            get => (uint)row["sfxId_31"].Value;
            set => row["sfxId_31"].Value = value;
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
    public ASSET_MATERIAL_SFX_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ASSET_MATERIAL_SFX_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
