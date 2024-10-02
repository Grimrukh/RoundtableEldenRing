using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class MAP_DEFAULT_INFO_PARAM_ST
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
        public uint EnableFastTravelEventFlagId
        {
            get => (uint)row["EnableFastTravelEventFlagId"].Value;
            set => row["EnableFastTravelEventFlagId"].Value = value;
        }

        // Unknown.
        public int WeatherLotTimeOffsetIngameSeconds
        {
            get => (int)row["WeatherLotTimeOffsetIngameSeconds"].Value;
            set => row["WeatherLotTimeOffsetIngameSeconds"].Value = value;
        }

        // Unknown.
        public sbyte WeatherCreateAssetLimitId
        {
            get => (sbyte)row["WeatherCreateAssetLimitId"].Value;
            set => row["WeatherCreateAssetLimitId"].Value = value;
        }

        // Unknown.
        public byte MapAiSightType
        {
            get => (byte)row["MapAiSightType"].Value;
            set => row["MapAiSightType"].Value = value;
        }

        // Unknown.
        public byte SoundIndoorType
        {
            get => (byte)row["SoundIndoorType"].Value;
            set => row["SoundIndoorType"].Value = value;
        }

        // Unknown.
        public sbyte ReverbDefaultType
        {
            get => (sbyte)row["ReverbDefaultType"].Value;
            set => row["ReverbDefaultType"].Value = value;
        }

        // Unknown.
        public short BgmPlaceInfo
        {
            get => (short)row["BgmPlaceInfo"].Value;
            set => row["BgmPlaceInfo"].Value = value;
        }

        // Unknown.
        public short EnvPlaceInfo
        {
            get => (short)row["EnvPlaceInfo"].Value;
            set => row["EnvPlaceInfo"].Value = value;
        }

        // Unknown.
        public int MapAdditionalSoundBankId
        {
            get => (int)row["MapAdditionalSoundBankId"].Value;
            set => row["MapAdditionalSoundBankId"].Value = value;
        }

        // Unknown.
        public short MapHeightForSound
        {
            get => (short)row["MapHeightForSound"].Value;
            set => row["MapHeightForSound"].Value = value;
        }

        // Unknown.
        public byte IsEnableBlendTimezoneEnvmap
        {
            get => (byte)row["IsEnableBlendTimezoneEnvmap"].Value;
            set => row["IsEnableBlendTimezoneEnvmap"].Value = value;
        }

        // Unknown.
        public sbyte OverrideGIResolution_XSS
        {
            get => (sbyte)row["OverrideGIResolution_XSS"].Value;
            set => row["OverrideGIResolution_XSS"].Value = value;
        }

        // Unknown.
        public float MapLoHiChangeBorderDist_XZ
        {
            get => (float)row["MapLoHiChangeBorderDist_XZ"].Value;
            set => row["MapLoHiChangeBorderDist_XZ"].Value = value;
        }

        // Unknown.
        public float MapLoHiChangeBorderDist_Y
        {
            get => (float)row["MapLoHiChangeBorderDist_Y"].Value;
            set => row["MapLoHiChangeBorderDist_Y"].Value = value;
        }

        // Unknown.
        public float MapLoHiChangePlayDist
        {
            get => (float)row["MapLoHiChangePlayDist"].Value;
            set => row["MapLoHiChangePlayDist"].Value = value;
        }

        // Unknown.
        public uint MapAutoDrawGroupBackFacePixelNum
        {
            get => (uint)row["MapAutoDrawGroupBackFacePixelNum"].Value;
            set => row["MapAutoDrawGroupBackFacePixelNum"].Value = value;
        }

        // Unknown.
        public float PlayerLigntScale
        {
            get => (float)row["PlayerLigntScale"].Value;
            set => row["PlayerLigntScale"].Value = value;
        }

        // Unknown.
        public byte IsEnableTimezonnePlayerLigntScale
        {
            get => (byte)row["IsEnableTimezonnePlayerLigntScale"].Value;
            set => row["IsEnableTimezonnePlayerLigntScale"].Value = value;
        }

        // Unknown.
        public byte isDisableAutoCliffWind
        {
            get => (byte)row["isDisableAutoCliffWind"].Value;
            set => row["isDisableAutoCliffWind"].Value = value;
        }

        // Unknown.
        public short OpenChrActivateThreshold
        {
            get => (short)row["OpenChrActivateThreshold"].Value;
            set => row["OpenChrActivateThreshold"].Value = value;
        }

        // Unknown.
        public int MapMimicryEstablishmentParamId
        {
            get => (int)row["MapMimicryEstablishmentParamId"].Value;
            set => row["MapMimicryEstablishmentParamId"].Value = value;
        }

        // Unknown.
        public sbyte OverrideGIResolution_XSX
        {
            get => (sbyte)row["OverrideGIResolution_XSX"].Value;
            set => row["OverrideGIResolution_XSX"].Value = value;
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
    public MAP_DEFAULT_INFO_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public MAP_DEFAULT_INFO_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
