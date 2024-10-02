using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class WEATHER_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int SfxId
        {
            get => (int)row["SfxId"].Value;
            set => row["SfxId"].Value = value;
        }

        // Unknown.
        public int WindSfxId
        {
            get => (int)row["WindSfxId"].Value;
            set => row["WindSfxId"].Value = value;
        }

        // Unknown.
        public int GroundHitSfxId
        {
            get => (int)row["GroundHitSfxId"].Value;
            set => row["GroundHitSfxId"].Value = value;
        }

        // Unknown.
        public int SoundId
        {
            get => (int)row["SoundId"].Value;
            set => row["SoundId"].Value = value;
        }

        // Unknown.
        public float WetTime
        {
            get => (float)row["WetTime"].Value;
            set => row["WetTime"].Value = value;
        }

        // Unknown.
        public uint GparamId
        {
            get => (uint)row["GparamId"].Value;
            set => row["GparamId"].Value = value;
        }

        // Unknown.
        public uint NextLotIngameSecondsMin
        {
            get => (uint)row["NextLotIngameSecondsMin"].Value;
            set => row["NextLotIngameSecondsMin"].Value = value;
        }

        // Unknown.
        public uint NextLotIngameSecondsMax
        {
            get => (uint)row["NextLotIngameSecondsMax"].Value;
            set => row["NextLotIngameSecondsMax"].Value = value;
        }

        // Unknown.
        public int WetSpEffectId00
        {
            get => (int)row["WetSpEffectId00"].Value;
            set => row["WetSpEffectId00"].Value = value;
        }

        // Unknown.
        public int WetSpEffectId01
        {
            get => (int)row["WetSpEffectId01"].Value;
            set => row["WetSpEffectId01"].Value = value;
        }

        // Unknown.
        public int WetSpEffectId02
        {
            get => (int)row["WetSpEffectId02"].Value;
            set => row["WetSpEffectId02"].Value = value;
        }

        // Unknown.
        public int WetSpEffectId03
        {
            get => (int)row["WetSpEffectId03"].Value;
            set => row["WetSpEffectId03"].Value = value;
        }

        // Unknown.
        public int WetSpEffectId04
        {
            get => (int)row["WetSpEffectId04"].Value;
            set => row["WetSpEffectId04"].Value = value;
        }

        // Unknown.
        public int SfxIdInoor
        {
            get => (int)row["SfxIdInoor"].Value;
            set => row["SfxIdInoor"].Value = value;
        }

        // Unknown.
        public int SfxIdOutdoor
        {
            get => (int)row["SfxIdOutdoor"].Value;
            set => row["SfxIdOutdoor"].Value = value;
        }

        // Unknown.
        public float aiSightRate
        {
            get => (float)row["aiSightRate"].Value;
            set => row["aiSightRate"].Value = value;
        }

        // Unknown.
        public float DistViewWeatherGparamOverrideWeight
        {
            get => (float)row["DistViewWeatherGparamOverrideWeight"].Value;
            set => row["DistViewWeatherGparamOverrideWeight"].Value = value;
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
    public WEATHER_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public WEATHER_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
