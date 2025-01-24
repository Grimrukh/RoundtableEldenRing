using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class LOAD_BALANCER_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float lowerFpsThreshold
        {
            get => (float)row["lowerFpsThreshold"].Value;
            set => row["lowerFpsThreshold"].Value = value;
        }

        // Unknown.
        public float upperFpsThreshold
        {
            get => (float)row["upperFpsThreshold"].Value;
            set => row["upperFpsThreshold"].Value = value;
        }

        // Unknown.
        public uint lowerFpsContinousCount
        {
            get => (uint)row["lowerFpsContinousCount"].Value;
            set => row["lowerFpsContinousCount"].Value = value;
        }

        // Unknown.
        public uint upperFpsContinousCount
        {
            get => (uint)row["upperFpsContinousCount"].Value;
            set => row["upperFpsContinousCount"].Value = value;
        }

        // Unknown.
        public uint downAfterChangeSleep
        {
            get => (uint)row["downAfterChangeSleep"].Value;
            set => row["downAfterChangeSleep"].Value = value;
        }

        // Unknown.
        public uint upAfterChangeSleep
        {
            get => (uint)row["upAfterChangeSleep"].Value;
            set => row["upAfterChangeSleep"].Value = value;
        }

        // Unknown.
        public byte postProcessLightShaft
        {
            get => (byte)row["postProcessLightShaft"].Value;
            set => row["postProcessLightShaft"].Value = value;
        }

        // Unknown.
        public byte postProcessBloom
        {
            get => (byte)row["postProcessBloom"].Value;
            set => row["postProcessBloom"].Value = value;
        }

        // Unknown.
        public byte postProcessGlow
        {
            get => (byte)row["postProcessGlow"].Value;
            set => row["postProcessGlow"].Value = value;
        }

        // Unknown.
        public byte postProcessAA
        {
            get => (byte)row["postProcessAA"].Value;
            set => row["postProcessAA"].Value = value;
        }

        // Unknown.
        public byte postProcessSSAO
        {
            get => (byte)row["postProcessSSAO"].Value;
            set => row["postProcessSSAO"].Value = value;
        }

        // Unknown.
        public byte postProcessDOF
        {
            get => (byte)row["postProcessDOF"].Value;
            set => row["postProcessDOF"].Value = value;
        }

        // Unknown.
        public byte postProcessMotionBlur
        {
            get => (byte)row["postProcessMotionBlur"].Value;
            set => row["postProcessMotionBlur"].Value = value;
        }

        // Unknown.
        public byte postProcessMotionBlurIteration
        {
            get => (byte)row["postProcessMotionBlurIteration"].Value;
            set => row["postProcessMotionBlurIteration"].Value = value;
        }

        // Unknown.
        public byte shadowBlur
        {
            get => (byte)row["shadowBlur"].Value;
            set => row["shadowBlur"].Value = value;
        }

        // Unknown.
        public byte sfxParticleHalf
        {
            get => (byte)row["sfxParticleHalf"].Value;
            set => row["sfxParticleHalf"].Value = value;
        }

        // Unknown.
        public byte sfxReflection
        {
            get => (byte)row["sfxReflection"].Value;
            set => row["sfxReflection"].Value = value;
        }

        // Unknown.
        public byte sfxWaterInteraction
        {
            get => (byte)row["sfxWaterInteraction"].Value;
            set => row["sfxWaterInteraction"].Value = value;
        }

        // Unknown.
        public byte sfxGlow
        {
            get => (byte)row["sfxGlow"].Value;
            set => row["sfxGlow"].Value = value;
        }

        // Unknown.
        public byte sfxDistortion
        {
            get => (byte)row["sfxDistortion"].Value;
            set => row["sfxDistortion"].Value = value;
        }

        // Unknown.
        public byte sftSoftSprite
        {
            get => (byte)row["sftSoftSprite"].Value;
            set => row["sftSoftSprite"].Value = value;
        }

        // Unknown.
        public byte sfxLightShaft
        {
            get => (byte)row["sfxLightShaft"].Value;
            set => row["sfxLightShaft"].Value = value;
        }

        // Unknown.
        public byte sfxScaleRenderDistanceScale
        {
            get => (byte)row["sfxScaleRenderDistanceScale"].Value;
            set => row["sfxScaleRenderDistanceScale"].Value = value;
        }

        // Unknown.
        public byte dynamicResolution
        {
            get => (byte)row["dynamicResolution"].Value;
            set => row["dynamicResolution"].Value = value;
        }

        // Unknown.
        public byte shadowCascade0ResolutionHalf
        {
            get => (byte)row["shadowCascade0ResolutionHalf"].Value;
            set => row["shadowCascade0ResolutionHalf"].Value = value;
        }

        // Unknown.
        public byte shadowCascade1ResolutionHalf
        {
            get => (byte)row["shadowCascade1ResolutionHalf"].Value;
            set => row["shadowCascade1ResolutionHalf"].Value = value;
        }

        // Unknown.
        public byte chrWetDisablePlayer
        {
            get => (byte)row["chrWetDisablePlayer"].Value;
            set => row["chrWetDisablePlayer"].Value = value;
        }

        // Unknown.
        public byte chrWetDisableRemotePlayer
        {
            get => (byte)row["chrWetDisableRemotePlayer"].Value;
            set => row["chrWetDisableRemotePlayer"].Value = value;
        }

        // Unknown.
        public byte chrWetDisableEnemy
        {
            get => (byte)row["chrWetDisableEnemy"].Value;
            set => row["chrWetDisableEnemy"].Value = value;
        }

        // Unknown.
        public byte dynamicResolutionPercentageMin
        {
            get => (byte)row["dynamicResolutionPercentageMin"].Value;
            set => row["dynamicResolutionPercentageMin"].Value = value;
        }

        // Unknown.
        public byte dynamicResolutionPercentageMax
        {
            get => (byte)row["dynamicResolutionPercentageMax"].Value;
            set => row["dynamicResolutionPercentageMax"].Value = value;
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
    public LOAD_BALANCER_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public LOAD_BALANCER_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
