using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class HIT_EFFECT_SFX_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int Slash_Normal
        {
            get => (int)row["Slash_Normal"].Value;
            set => row["Slash_Normal"].Value = value;
        }

        // Unknown.
        public int Slash_S
        {
            get => (int)row["Slash_S"].Value;
            set => row["Slash_S"].Value = value;
        }

        // Unknown.
        public int Slash_L
        {
            get => (int)row["Slash_L"].Value;
            set => row["Slash_L"].Value = value;
        }

        // Unknown.
        public int Slash_Specific1
        {
            get => (int)row["Slash_Specific1"].Value;
            set => row["Slash_Specific1"].Value = value;
        }

        // Unknown.
        public int Slash_Specific2
        {
            get => (int)row["Slash_Specific2"].Value;
            set => row["Slash_Specific2"].Value = value;
        }

        // Unknown.
        public int Blow_Normal
        {
            get => (int)row["Blow_Normal"].Value;
            set => row["Blow_Normal"].Value = value;
        }

        // Unknown.
        public int Blow_S
        {
            get => (int)row["Blow_S"].Value;
            set => row["Blow_S"].Value = value;
        }

        // Unknown.
        public int Blow_L
        {
            get => (int)row["Blow_L"].Value;
            set => row["Blow_L"].Value = value;
        }

        // Unknown.
        public int Blow_Specific1
        {
            get => (int)row["Blow_Specific1"].Value;
            set => row["Blow_Specific1"].Value = value;
        }

        // Unknown.
        public int Blow_Specific2
        {
            get => (int)row["Blow_Specific2"].Value;
            set => row["Blow_Specific2"].Value = value;
        }

        // Unknown.
        public int Thrust_Normal
        {
            get => (int)row["Thrust_Normal"].Value;
            set => row["Thrust_Normal"].Value = value;
        }

        // Unknown.
        public int Thrust_S
        {
            get => (int)row["Thrust_S"].Value;
            set => row["Thrust_S"].Value = value;
        }

        // Unknown.
        public int Thrust_L
        {
            get => (int)row["Thrust_L"].Value;
            set => row["Thrust_L"].Value = value;
        }

        // Unknown.
        public int Thrust_Specific1
        {
            get => (int)row["Thrust_Specific1"].Value;
            set => row["Thrust_Specific1"].Value = value;
        }

        // Unknown.
        public int Thrust_Specific2
        {
            get => (int)row["Thrust_Specific2"].Value;
            set => row["Thrust_Specific2"].Value = value;
        }

        // Unknown.
        public int Neutral_Normal
        {
            get => (int)row["Neutral_Normal"].Value;
            set => row["Neutral_Normal"].Value = value;
        }

        // Unknown.
        public int Neutral_S
        {
            get => (int)row["Neutral_S"].Value;
            set => row["Neutral_S"].Value = value;
        }

        // Unknown.
        public int Neutral_L
        {
            get => (int)row["Neutral_L"].Value;
            set => row["Neutral_L"].Value = value;
        }

        // Unknown.
        public int Neutral_Specific1
        {
            get => (int)row["Neutral_Specific1"].Value;
            set => row["Neutral_Specific1"].Value = value;
        }

        // Unknown.
        public int Neutral_Specific2
        {
            get => (int)row["Neutral_Specific2"].Value;
            set => row["Neutral_Specific2"].Value = value;
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
    public HIT_EFFECT_SFX_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public HIT_EFFECT_SFX_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
