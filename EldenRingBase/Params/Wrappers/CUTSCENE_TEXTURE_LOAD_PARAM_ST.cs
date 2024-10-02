using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class CUTSCENE_TEXTURE_LOAD_PARAM_ST
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
        public string texName_00
        {
            get => (string)row["texName_00"].Value;
            set => row["texName_00"].Value = value;
        }

        // Unknown.
        public string texName_01
        {
            get => (string)row["texName_01"].Value;
            set => row["texName_01"].Value = value;
        }

        // Unknown.
        public string texName_02
        {
            get => (string)row["texName_02"].Value;
            set => row["texName_02"].Value = value;
        }

        // Unknown.
        public string texName_03
        {
            get => (string)row["texName_03"].Value;
            set => row["texName_03"].Value = value;
        }

        // Unknown.
        public string texName_04
        {
            get => (string)row["texName_04"].Value;
            set => row["texName_04"].Value = value;
        }

        // Unknown.
        public string texName_05
        {
            get => (string)row["texName_05"].Value;
            set => row["texName_05"].Value = value;
        }

        // Unknown.
        public string texName_06
        {
            get => (string)row["texName_06"].Value;
            set => row["texName_06"].Value = value;
        }

        // Unknown.
        public string texName_07
        {
            get => (string)row["texName_07"].Value;
            set => row["texName_07"].Value = value;
        }

        // Unknown.
        public string texName_08
        {
            get => (string)row["texName_08"].Value;
            set => row["texName_08"].Value = value;
        }

        // Unknown.
        public string texName_09
        {
            get => (string)row["texName_09"].Value;
            set => row["texName_09"].Value = value;
        }

        // Unknown.
        public string texName_10
        {
            get => (string)row["texName_10"].Value;
            set => row["texName_10"].Value = value;
        }

        // Unknown.
        public string texName_11
        {
            get => (string)row["texName_11"].Value;
            set => row["texName_11"].Value = value;
        }

        // Unknown.
        public string texName_12
        {
            get => (string)row["texName_12"].Value;
            set => row["texName_12"].Value = value;
        }

        // Unknown.
        public string texName_13
        {
            get => (string)row["texName_13"].Value;
            set => row["texName_13"].Value = value;
        }

        // Unknown.
        public string texName_14
        {
            get => (string)row["texName_14"].Value;
            set => row["texName_14"].Value = value;
        }

        // Unknown.
        public string texName_15
        {
            get => (string)row["texName_15"].Value;
            set => row["texName_15"].Value = value;
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
    public CUTSCENE_TEXTURE_LOAD_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CUTSCENE_TEXTURE_LOAD_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
