using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class ESTUS_FLASK_RECOVERY_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte host
        {
            get => (byte)row["host"].Value;
            set => row["host"].Value = value;
        }

        // Unknown.
        public byte invadeOrb_None
        {
            get => (byte)row["invadeOrb_None"].Value;
            set => row["invadeOrb_None"].Value = value;
        }

        // Unknown.
        public byte invadeOrb_Umbasa
        {
            get => (byte)row["invadeOrb_Umbasa"].Value;
            set => row["invadeOrb_Umbasa"].Value = value;
        }

        // Unknown.
        public byte invadeOrb_Berserker
        {
            get => (byte)row["invadeOrb_Berserker"].Value;
            set => row["invadeOrb_Berserker"].Value = value;
        }

        // Unknown.
        public byte invadeOrb_Sinners
        {
            get => (byte)row["invadeOrb_Sinners"].Value;
            set => row["invadeOrb_Sinners"].Value = value;
        }

        // Unknown.
        public byte invadeSign_None
        {
            get => (byte)row["invadeSign_None"].Value;
            set => row["invadeSign_None"].Value = value;
        }

        // Unknown.
        public byte invadeSign_Umbasa
        {
            get => (byte)row["invadeSign_Umbasa"].Value;
            set => row["invadeSign_Umbasa"].Value = value;
        }

        // Unknown.
        public byte invadeSign_Berserker
        {
            get => (byte)row["invadeSign_Berserker"].Value;
            set => row["invadeSign_Berserker"].Value = value;
        }

        // Unknown.
        public byte invadeSign_Sinners
        {
            get => (byte)row["invadeSign_Sinners"].Value;
            set => row["invadeSign_Sinners"].Value = value;
        }

        // Unknown.
        public byte invadeRing_Sinners
        {
            get => (byte)row["invadeRing_Sinners"].Value;
            set => row["invadeRing_Sinners"].Value = value;
        }

        // Unknown.
        public byte invadeRing_Rosalia
        {
            get => (byte)row["invadeRing_Rosalia"].Value;
            set => row["invadeRing_Rosalia"].Value = value;
        }

        // Unknown.
        public byte invadeRing_Forest
        {
            get => (byte)row["invadeRing_Forest"].Value;
            set => row["invadeRing_Forest"].Value = value;
        }

        // Unknown.
        public byte coopSign_None
        {
            get => (byte)row["coopSign_None"].Value;
            set => row["coopSign_None"].Value = value;
        }

        // Unknown.
        public byte coopSign_Umbasa
        {
            get => (byte)row["coopSign_Umbasa"].Value;
            set => row["coopSign_Umbasa"].Value = value;
        }

        // Unknown.
        public byte coopSign_Berserker
        {
            get => (byte)row["coopSign_Berserker"].Value;
            set => row["coopSign_Berserker"].Value = value;
        }

        // Unknown.
        public byte coopSign_Sinners
        {
            get => (byte)row["coopSign_Sinners"].Value;
            set => row["coopSign_Sinners"].Value = value;
        }

        // Unknown.
        public byte coopRing_RedHunter
        {
            get => (byte)row["coopRing_RedHunter"].Value;
            set => row["coopRing_RedHunter"].Value = value;
        }

        // Unknown.
        public byte invadeRing_Anor
        {
            get => (byte)row["invadeRing_Anor"].Value;
            set => row["invadeRing_Anor"].Value = value;
        }

        // Unknown.
        public ushort paramReplaceRate
        {
            get => (ushort)row["paramReplaceRate"].Value;
            set => row["paramReplaceRate"].Value = value;
        }

        // Unknown.
        public int paramReplaceId
        {
            get => (int)row["paramReplaceId"].Value;
            set => row["paramReplaceId"].Value = value;
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
    public ESTUS_FLASK_RECOVERY_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ESTUS_FLASK_RECOVERY_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
