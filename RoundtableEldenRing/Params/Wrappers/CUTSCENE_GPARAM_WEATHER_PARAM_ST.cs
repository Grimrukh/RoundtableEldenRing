using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class CUTSCENE_GPARAM_WEATHER_PARAM_ST
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
        public short DstWeather_Sunny
        {
            get => (short)row["DstWeather_Sunny"].Value;
            set => row["DstWeather_Sunny"].Value = value;
        }

        // Unknown.
        public short DstWeather_ClearSky
        {
            get => (short)row["DstWeather_ClearSky"].Value;
            set => row["DstWeather_ClearSky"].Value = value;
        }

        // Unknown.
        public short DstWeather_WeakCloudy
        {
            get => (short)row["DstWeather_WeakCloudy"].Value;
            set => row["DstWeather_WeakCloudy"].Value = value;
        }

        // Unknown.
        public short DstWeather_Cloud
        {
            get => (short)row["DstWeather_Cloud"].Value;
            set => row["DstWeather_Cloud"].Value = value;
        }

        // Unknown.
        public short DstWeather_Rain
        {
            get => (short)row["DstWeather_Rain"].Value;
            set => row["DstWeather_Rain"].Value = value;
        }

        // Unknown.
        public short DstWeather_HeavyRain
        {
            get => (short)row["DstWeather_HeavyRain"].Value;
            set => row["DstWeather_HeavyRain"].Value = value;
        }

        // Unknown.
        public short DstWeather_Storm
        {
            get => (short)row["DstWeather_Storm"].Value;
            set => row["DstWeather_Storm"].Value = value;
        }

        // Unknown.
        public short DstWeather_StormForBattle
        {
            get => (short)row["DstWeather_StormForBattle"].Value;
            set => row["DstWeather_StormForBattle"].Value = value;
        }

        // Unknown.
        public short DstWeather_Snow
        {
            get => (short)row["DstWeather_Snow"].Value;
            set => row["DstWeather_Snow"].Value = value;
        }

        // Unknown.
        public short DstWeather_HeavySnow
        {
            get => (short)row["DstWeather_HeavySnow"].Value;
            set => row["DstWeather_HeavySnow"].Value = value;
        }

        // Unknown.
        public short DstWeather_Fog
        {
            get => (short)row["DstWeather_Fog"].Value;
            set => row["DstWeather_Fog"].Value = value;
        }

        // Unknown.
        public short DstWeather_HeavyFog
        {
            get => (short)row["DstWeather_HeavyFog"].Value;
            set => row["DstWeather_HeavyFog"].Value = value;
        }

        // Unknown.
        public short DstWeather_SandStorm
        {
            get => (short)row["DstWeather_SandStorm"].Value;
            set => row["DstWeather_SandStorm"].Value = value;
        }

        // Unknown.
        public short DstWeather_HeavyFogRain
        {
            get => (short)row["DstWeather_HeavyFogRain"].Value;
            set => row["DstWeather_HeavyFogRain"].Value = value;
        }

        // Unknown.
        public short PostPlayIngameWeather
        {
            get => (short)row["PostPlayIngameWeather"].Value;
            set => row["PostPlayIngameWeather"].Value = value;
        }

        // Unknown.
        public byte IndoorOutdoorType
        {
            get => (byte)row["IndoorOutdoorType"].Value;
            set => row["IndoorOutdoorType"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Sunny
        {
            get => (byte)row["TakeOverDstWeather_Sunny"].Value;
            set => row["TakeOverDstWeather_Sunny"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_ClearSky
        {
            get => (byte)row["TakeOverDstWeather_ClearSky"].Value;
            set => row["TakeOverDstWeather_ClearSky"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_WeakCloudy
        {
            get => (byte)row["TakeOverDstWeather_WeakCloudy"].Value;
            set => row["TakeOverDstWeather_WeakCloudy"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Cloud
        {
            get => (byte)row["TakeOverDstWeather_Cloud"].Value;
            set => row["TakeOverDstWeather_Cloud"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Rain
        {
            get => (byte)row["TakeOverDstWeather_Rain"].Value;
            set => row["TakeOverDstWeather_Rain"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_HeavyRain
        {
            get => (byte)row["TakeOverDstWeather_HeavyRain"].Value;
            set => row["TakeOverDstWeather_HeavyRain"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Storm
        {
            get => (byte)row["TakeOverDstWeather_Storm"].Value;
            set => row["TakeOverDstWeather_Storm"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_StormForBattle
        {
            get => (byte)row["TakeOverDstWeather_StormForBattle"].Value;
            set => row["TakeOverDstWeather_StormForBattle"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Snow
        {
            get => (byte)row["TakeOverDstWeather_Snow"].Value;
            set => row["TakeOverDstWeather_Snow"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_HeavySnow
        {
            get => (byte)row["TakeOverDstWeather_HeavySnow"].Value;
            set => row["TakeOverDstWeather_HeavySnow"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Fog
        {
            get => (byte)row["TakeOverDstWeather_Fog"].Value;
            set => row["TakeOverDstWeather_Fog"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_HeavyFog
        {
            get => (byte)row["TakeOverDstWeather_HeavyFog"].Value;
            set => row["TakeOverDstWeather_HeavyFog"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_SandStorm
        {
            get => (byte)row["TakeOverDstWeather_SandStorm"].Value;
            set => row["TakeOverDstWeather_SandStorm"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_HeavyFogRain
        {
            get => (byte)row["TakeOverDstWeather_HeavyFogRain"].Value;
            set => row["TakeOverDstWeather_HeavyFogRain"].Value = value;
        }

        // Unknown.
        public short DstWeather_Snowstorm
        {
            get => (short)row["DstWeather_Snowstorm"].Value;
            set => row["DstWeather_Snowstorm"].Value = value;
        }

        // Unknown.
        public short DstWeather_LightningStorm
        {
            get => (short)row["DstWeather_LightningStorm"].Value;
            set => row["DstWeather_LightningStorm"].Value = value;
        }

        // Unknown.
        public short DstWeather_Reserved3
        {
            get => (short)row["DstWeather_Reserved3"].Value;
            set => row["DstWeather_Reserved3"].Value = value;
        }

        // Unknown.
        public short DstWeather_Reserved4
        {
            get => (short)row["DstWeather_Reserved4"].Value;
            set => row["DstWeather_Reserved4"].Value = value;
        }

        // Unknown.
        public short DstWeather_Reserved5
        {
            get => (short)row["DstWeather_Reserved5"].Value;
            set => row["DstWeather_Reserved5"].Value = value;
        }

        // Unknown.
        public short DstWeather_Reserved6
        {
            get => (short)row["DstWeather_Reserved6"].Value;
            set => row["DstWeather_Reserved6"].Value = value;
        }

        // Unknown.
        public short DstWeather_Reserved7
        {
            get => (short)row["DstWeather_Reserved7"].Value;
            set => row["DstWeather_Reserved7"].Value = value;
        }

        // Unknown.
        public short DstWeather_Reserved8
        {
            get => (short)row["DstWeather_Reserved8"].Value;
            set => row["DstWeather_Reserved8"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Snowstorm
        {
            get => (byte)row["TakeOverDstWeather_Snowstorm"].Value;
            set => row["TakeOverDstWeather_Snowstorm"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_LightningStorm
        {
            get => (byte)row["TakeOverDstWeather_LightningStorm"].Value;
            set => row["TakeOverDstWeather_LightningStorm"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Reserved3
        {
            get => (byte)row["TakeOverDstWeather_Reserved3"].Value;
            set => row["TakeOverDstWeather_Reserved3"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Reserved4
        {
            get => (byte)row["TakeOverDstWeather_Reserved4"].Value;
            set => row["TakeOverDstWeather_Reserved4"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Reserved5
        {
            get => (byte)row["TakeOverDstWeather_Reserved5"].Value;
            set => row["TakeOverDstWeather_Reserved5"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Reserved6
        {
            get => (byte)row["TakeOverDstWeather_Reserved6"].Value;
            set => row["TakeOverDstWeather_Reserved6"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Reserved7
        {
            get => (byte)row["TakeOverDstWeather_Reserved7"].Value;
            set => row["TakeOverDstWeather_Reserved7"].Value = value;
        }

        // Unknown.
        public byte TakeOverDstWeather_Reserved8
        {
            get => (byte)row["TakeOverDstWeather_Reserved8"].Value;
            set => row["TakeOverDstWeather_Reserved8"].Value = value;
        }

        // Unknown.
        public byte IsEnableApplyMapGdRegionIdForGparam
        {
            get => (byte)row["IsEnableApplyMapGdRegionIdForGparam"].Value;
            set => row["IsEnableApplyMapGdRegionIdForGparam"].Value = value;
        }

        // Unknown.
        public short OverrideMapGdRegionId
        {
            get => (short)row["OverrideMapGdRegionId"].Value;
            set => row["OverrideMapGdRegionId"].Value = value;
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
    public CUTSCENE_GPARAM_WEATHER_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CUTSCENE_GPARAM_WEATHER_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
