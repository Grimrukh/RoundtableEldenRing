using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class CHR_ACTIVATE_CONDITION_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte weatherSunny
        {
            get => (byte)row["weatherSunny"].Value;
            set => row["weatherSunny"].Value = value;
        }

        // Unknown.
        public byte weatherClearSky
        {
            get => (byte)row["weatherClearSky"].Value;
            set => row["weatherClearSky"].Value = value;
        }

        // Unknown.
        public byte weatherWeakCloudy
        {
            get => (byte)row["weatherWeakCloudy"].Value;
            set => row["weatherWeakCloudy"].Value = value;
        }

        // Unknown.
        public byte weatherCloudy
        {
            get => (byte)row["weatherCloudy"].Value;
            set => row["weatherCloudy"].Value = value;
        }

        // Unknown.
        public byte weatherRain
        {
            get => (byte)row["weatherRain"].Value;
            set => row["weatherRain"].Value = value;
        }

        // Unknown.
        public byte weatherHeavyRain
        {
            get => (byte)row["weatherHeavyRain"].Value;
            set => row["weatherHeavyRain"].Value = value;
        }

        // Unknown.
        public byte weatherStorm
        {
            get => (byte)row["weatherStorm"].Value;
            set => row["weatherStorm"].Value = value;
        }

        // Unknown.
        public byte weatherStormForBattle
        {
            get => (byte)row["weatherStormForBattle"].Value;
            set => row["weatherStormForBattle"].Value = value;
        }

        // Unknown.
        public byte weatherSnow
        {
            get => (byte)row["weatherSnow"].Value;
            set => row["weatherSnow"].Value = value;
        }

        // Unknown.
        public byte weatherHeavySnow
        {
            get => (byte)row["weatherHeavySnow"].Value;
            set => row["weatherHeavySnow"].Value = value;
        }

        // Unknown.
        public byte weatherFog
        {
            get => (byte)row["weatherFog"].Value;
            set => row["weatherFog"].Value = value;
        }

        // Unknown.
        public byte weatherHeavyFog
        {
            get => (byte)row["weatherHeavyFog"].Value;
            set => row["weatherHeavyFog"].Value = value;
        }

        // Unknown.
        public byte weatherHeavyFogRain
        {
            get => (byte)row["weatherHeavyFogRain"].Value;
            set => row["weatherHeavyFogRain"].Value = value;
        }

        // Unknown.
        public byte weatherSandStorm
        {
            get => (byte)row["weatherSandStorm"].Value;
            set => row["weatherSandStorm"].Value = value;
        }

        // Unknown.
        public byte timeStartHour
        {
            get => (byte)row["timeStartHour"].Value;
            set => row["timeStartHour"].Value = value;
        }

        // Unknown.
        public byte timeStartMin
        {
            get => (byte)row["timeStartMin"].Value;
            set => row["timeStartMin"].Value = value;
        }

        // Unknown.
        public byte timeEndHour
        {
            get => (byte)row["timeEndHour"].Value;
            set => row["timeEndHour"].Value = value;
        }

        // Unknown.
        public byte timeEndMin
        {
            get => (byte)row["timeEndMin"].Value;
            set => row["timeEndMin"].Value = value;
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
    public CHR_ACTIVATE_CONDITION_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CHR_ACTIVATE_CONDITION_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
