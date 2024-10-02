using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class CS_GRAPHICS_CONFIG_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte m_textureFilterQuality
        {
            get => (byte)row["m_textureFilterQuality"].Value;
            set => row["m_textureFilterQuality"].Value = value;
        }

        // Unknown.
        public byte m_aaQuality
        {
            get => (byte)row["m_aaQuality"].Value;
            set => row["m_aaQuality"].Value = value;
        }

        // Unknown.
        public byte m_ssaoQuality
        {
            get => (byte)row["m_ssaoQuality"].Value;
            set => row["m_ssaoQuality"].Value = value;
        }

        // Unknown.
        public byte m_dofQuality
        {
            get => (byte)row["m_dofQuality"].Value;
            set => row["m_dofQuality"].Value = value;
        }

        // Unknown.
        public byte m_motionBlurQuality
        {
            get => (byte)row["m_motionBlurQuality"].Value;
            set => row["m_motionBlurQuality"].Value = value;
        }

        // Unknown.
        public byte m_shadowQuality
        {
            get => (byte)row["m_shadowQuality"].Value;
            set => row["m_shadowQuality"].Value = value;
        }

        // Unknown.
        public byte m_lightingQuality
        {
            get => (byte)row["m_lightingQuality"].Value;
            set => row["m_lightingQuality"].Value = value;
        }

        // Unknown.
        public byte m_effectQuality
        {
            get => (byte)row["m_effectQuality"].Value;
            set => row["m_effectQuality"].Value = value;
        }

        // Unknown.
        public byte m_decalQuality
        {
            get => (byte)row["m_decalQuality"].Value;
            set => row["m_decalQuality"].Value = value;
        }

        // Unknown.
        public byte m_reflectionQuality
        {
            get => (byte)row["m_reflectionQuality"].Value;
            set => row["m_reflectionQuality"].Value = value;
        }

        // Unknown.
        public byte m_waterQuality
        {
            get => (byte)row["m_waterQuality"].Value;
            set => row["m_waterQuality"].Value = value;
        }

        // Unknown.
        public byte m_shaderQuality
        {
            get => (byte)row["m_shaderQuality"].Value;
            set => row["m_shaderQuality"].Value = value;
        }

        // Unknown.
        public byte m_volumetricEffectQuality
        {
            get => (byte)row["m_volumetricEffectQuality"].Value;
            set => row["m_volumetricEffectQuality"].Value = value;
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
    public CS_GRAPHICS_CONFIG_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public CS_GRAPHICS_CONFIG_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
