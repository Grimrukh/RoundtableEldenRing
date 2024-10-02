using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class DECAL_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int textureId
        {
            get => (int)row["textureId"].Value;
            set => row["textureId"].Value = value;
        }

        // Unknown.
        public int dmypolyId
        {
            get => (int)row["dmypolyId"].Value;
            set => row["dmypolyId"].Value = value;
        }

        // Unknown.
        public float pitchAngle
        {
            get => (float)row["pitchAngle"].Value;
            set => row["pitchAngle"].Value = value;
        }

        // Unknown.
        public float yawAngle
        {
            get => (float)row["yawAngle"].Value;
            set => row["yawAngle"].Value = value;
        }

        // Unknown.
        public float nearDistance
        {
            get => (float)row["nearDistance"].Value;
            set => row["nearDistance"].Value = value;
        }

        // Unknown.
        public float farDistance
        {
            get => (float)row["farDistance"].Value;
            set => row["farDistance"].Value = value;
        }

        // Unknown.
        public float nearSize
        {
            get => (float)row["nearSize"].Value;
            set => row["nearSize"].Value = value;
        }

        // Unknown.
        public float farSize
        {
            get => (float)row["farSize"].Value;
            set => row["farSize"].Value = value;
        }

        // Unknown.
        public int maskSpeffectId
        {
            get => (int)row["maskSpeffectId"].Value;
            set => row["maskSpeffectId"].Value = value;
        }

        // Unknown.
        public uint pad_10
        {
            get => (uint)row["pad_10"].Value;
            set => row["pad_10"].Value = value;
        }

        // Unknown.
        public uint replaceTextureId_byMaterial
        {
            get => (uint)row["replaceTextureId_byMaterial"].Value;
            set => row["replaceTextureId_byMaterial"].Value = value;
        }

        // Unknown.
        public uint dmypolyCategory
        {
            get => (uint)row["dmypolyCategory"].Value;
            set => row["dmypolyCategory"].Value = value;
        }

        // Unknown.
        public uint pad_05
        {
            get => (uint)row["pad_05"].Value;
            set => row["pad_05"].Value = value;
        }

        // Unknown.
        public uint useDeferredDecal
        {
            get => (uint)row["useDeferredDecal"].Value;
            set => row["useDeferredDecal"].Value = value;
        }

        // Unknown.
        public uint usePaintDecal
        {
            get => (uint)row["usePaintDecal"].Value;
            set => row["usePaintDecal"].Value = value;
        }

        // Unknown.
        public uint bloodTypeEnable
        {
            get => (uint)row["bloodTypeEnable"].Value;
            set => row["bloodTypeEnable"].Value = value;
        }

        // Unknown.
        public uint bUseNormal
        {
            get => (uint)row["bUseNormal"].Value;
            set => row["bUseNormal"].Value = value;
        }

        // Unknown.
        public uint pad_08
        {
            get => (uint)row["pad_08"].Value;
            set => row["pad_08"].Value = value;
        }

        // Unknown.
        public uint pad_09
        {
            get => (uint)row["pad_09"].Value;
            set => row["pad_09"].Value = value;
        }

        // Unknown.
        public uint usePom
        {
            get => (uint)row["usePom"].Value;
            set => row["usePom"].Value = value;
        }

        // Unknown.
        public uint useEmissive
        {
            get => (uint)row["useEmissive"].Value;
            set => row["useEmissive"].Value = value;
        }

        // Unknown.
        public uint putVertical
        {
            get => (uint)row["putVertical"].Value;
            set => row["putVertical"].Value = value;
        }

        // Unknown.
        public short randomSizeMin
        {
            get => (short)row["randomSizeMin"].Value;
            set => row["randomSizeMin"].Value = value;
        }

        // Unknown.
        public short randomSizeMax
        {
            get => (short)row["randomSizeMax"].Value;
            set => row["randomSizeMax"].Value = value;
        }

        // Unknown.
        public float randomRollMin
        {
            get => (float)row["randomRollMin"].Value;
            set => row["randomRollMin"].Value = value;
        }

        // Unknown.
        public float randomRollMax
        {
            get => (float)row["randomRollMax"].Value;
            set => row["randomRollMax"].Value = value;
        }

        // Unknown.
        public float randomPitchMin
        {
            get => (float)row["randomPitchMin"].Value;
            set => row["randomPitchMin"].Value = value;
        }

        // Unknown.
        public float randomPitchMax
        {
            get => (float)row["randomPitchMax"].Value;
            set => row["randomPitchMax"].Value = value;
        }

        // Unknown.
        public float randomYawMin
        {
            get => (float)row["randomYawMin"].Value;
            set => row["randomYawMin"].Value = value;
        }

        // Unknown.
        public float randomYawMax
        {
            get => (float)row["randomYawMax"].Value;
            set => row["randomYawMax"].Value = value;
        }

        // Unknown.
        public float pomHightScale
        {
            get => (float)row["pomHightScale"].Value;
            set => row["pomHightScale"].Value = value;
        }

        // Unknown.
        public byte pomSampleMin
        {
            get => (byte)row["pomSampleMin"].Value;
            set => row["pomSampleMin"].Value = value;
        }

        // Unknown.
        public byte pomSampleMax
        {
            get => (byte)row["pomSampleMax"].Value;
            set => row["pomSampleMax"].Value = value;
        }

        // Unknown.
        public sbyte blendMode
        {
            get => (sbyte)row["blendMode"].Value;
            set => row["blendMode"].Value = value;
        }

        // Unknown.
        public sbyte appearDirType
        {
            get => (sbyte)row["appearDirType"].Value;
            set => row["appearDirType"].Value = value;
        }

        // Unknown.
        public float emissiveValueBegin
        {
            get => (float)row["emissiveValueBegin"].Value;
            set => row["emissiveValueBegin"].Value = value;
        }

        // Unknown.
        public float emissiveValueEnd
        {
            get => (float)row["emissiveValueEnd"].Value;
            set => row["emissiveValueEnd"].Value = value;
        }

        // Unknown.
        public float emissiveTime
        {
            get => (float)row["emissiveTime"].Value;
            set => row["emissiveTime"].Value = value;
        }

        // Unknown.
        public byte bIntpEnable
        {
            get => (byte)row["bIntpEnable"].Value;
            set => row["bIntpEnable"].Value = value;
        }

        // Unknown.
        public float intpIntervalDist
        {
            get => (float)row["intpIntervalDist"].Value;
            set => row["intpIntervalDist"].Value = value;
        }

        // Unknown.
        public int beginIntpTextureId
        {
            get => (int)row["beginIntpTextureId"].Value;
            set => row["beginIntpTextureId"].Value = value;
        }

        // Unknown.
        public int endIntpTextureId
        {
            get => (int)row["endIntpTextureId"].Value;
            set => row["endIntpTextureId"].Value = value;
        }

        // Unknown.
        public int appearSfxId
        {
            get => (int)row["appearSfxId"].Value;
            set => row["appearSfxId"].Value = value;
        }

        // Unknown.
        public float appearSfxOffsetPos
        {
            get => (float)row["appearSfxOffsetPos"].Value;
            set => row["appearSfxOffsetPos"].Value = value;
        }

        // Unknown.
        public int maskTextureId
        {
            get => (int)row["maskTextureId"].Value;
            set => row["maskTextureId"].Value = value;
        }

        // Unknown.
        public int diffuseTextureId
        {
            get => (int)row["diffuseTextureId"].Value;
            set => row["diffuseTextureId"].Value = value;
        }

        // Unknown.
        public int reflecTextureId
        {
            get => (int)row["reflecTextureId"].Value;
            set => row["reflecTextureId"].Value = value;
        }

        // Unknown.
        public float maskScale
        {
            get => (float)row["maskScale"].Value;
            set => row["maskScale"].Value = value;
        }

        // Unknown.
        public int normalTextureId
        {
            get => (int)row["normalTextureId"].Value;
            set => row["normalTextureId"].Value = value;
        }

        // Unknown.
        public int heightTextureId
        {
            get => (int)row["heightTextureId"].Value;
            set => row["heightTextureId"].Value = value;
        }

        // Unknown.
        public int emissiveTextureId
        {
            get => (int)row["emissiveTextureId"].Value;
            set => row["emissiveTextureId"].Value = value;
        }

        // Unknown.
        public byte diffuseColorR
        {
            get => (byte)row["diffuseColorR"].Value;
            set => row["diffuseColorR"].Value = value;
        }

        // Unknown.
        public byte diffuseColorG
        {
            get => (byte)row["diffuseColorG"].Value;
            set => row["diffuseColorG"].Value = value;
        }

        // Unknown.
        public byte diffuseColorB
        {
            get => (byte)row["diffuseColorB"].Value;
            set => row["diffuseColorB"].Value = value;
        }

        // Unknown.
        public byte reflecColorR
        {
            get => (byte)row["reflecColorR"].Value;
            set => row["reflecColorR"].Value = value;
        }

        // Unknown.
        public byte reflecColorG
        {
            get => (byte)row["reflecColorG"].Value;
            set => row["reflecColorG"].Value = value;
        }

        // Unknown.
        public byte reflecColorB
        {
            get => (byte)row["reflecColorB"].Value;
            set => row["reflecColorB"].Value = value;
        }

        // Unknown.
        public byte bLifeEnable
        {
            get => (byte)row["bLifeEnable"].Value;
            set => row["bLifeEnable"].Value = value;
        }

        // Unknown.
        public float siniScale
        {
            get => (float)row["siniScale"].Value;
            set => row["siniScale"].Value = value;
        }

        // Unknown.
        public float lifeTimeSec
        {
            get => (float)row["lifeTimeSec"].Value;
            set => row["lifeTimeSec"].Value = value;
        }

        // Unknown.
        public float fadeOutTimeSec
        {
            get => (float)row["fadeOutTimeSec"].Value;
            set => row["fadeOutTimeSec"].Value = value;
        }

        // Unknown.
        public short priority
        {
            get => (short)row["priority"].Value;
            set => row["priority"].Value = value;
        }

        // Unknown.
        public byte bDistThinOutEnable
        {
            get => (byte)row["bDistThinOutEnable"].Value;
            set => row["bDistThinOutEnable"].Value = value;
        }

        // Unknown.
        public byte bAlignedTexRandomVariationEnable
        {
            get => (byte)row["bAlignedTexRandomVariationEnable"].Value;
            set => row["bAlignedTexRandomVariationEnable"].Value = value;
        }

        // Unknown.
        public float distThinOutCheckDist
        {
            get => (float)row["distThinOutCheckDist"].Value;
            set => row["distThinOutCheckDist"].Value = value;
        }

        // Unknown.
        public float distThinOutCheckAngleDeg
        {
            get => (float)row["distThinOutCheckAngleDeg"].Value;
            set => row["distThinOutCheckAngleDeg"].Value = value;
        }

        // Unknown.
        public byte distThinOutMaxNum
        {
            get => (byte)row["distThinOutMaxNum"].Value;
            set => row["distThinOutMaxNum"].Value = value;
        }

        // Unknown.
        public byte distThinOutCheckNum
        {
            get => (byte)row["distThinOutCheckNum"].Value;
            set => row["distThinOutCheckNum"].Value = value;
        }

        // Unknown.
        public short delayAppearFrame
        {
            get => (short)row["delayAppearFrame"].Value;
            set => row["delayAppearFrame"].Value = value;
        }

        // Unknown.
        public uint randVaria_Diffuse
        {
            get => (uint)row["randVaria_Diffuse"].Value;
            set => row["randVaria_Diffuse"].Value = value;
        }

        // Unknown.
        public uint randVaria_Mask
        {
            get => (uint)row["randVaria_Mask"].Value;
            set => row["randVaria_Mask"].Value = value;
        }

        // Unknown.
        public uint randVaria_Reflec
        {
            get => (uint)row["randVaria_Reflec"].Value;
            set => row["randVaria_Reflec"].Value = value;
        }

        public uint pad_12
        {
            get => (uint)row["pad_12"].Value;
            set => row["pad_12"].Value = value;
        }

        // Unknown.
        public uint randVaria_Normal
        {
            get => (uint)row["randVaria_Normal"].Value;
            set => row["randVaria_Normal"].Value = value;
        }

        // Unknown.
        public uint randVaria_Height
        {
            get => (uint)row["randVaria_Height"].Value;
            set => row["randVaria_Height"].Value = value;
        }

        // Unknown.
        public uint randVaria_Emissive
        {
            get => (uint)row["randVaria_Emissive"].Value;
            set => row["randVaria_Emissive"].Value = value;
        }

        // Unknown.
        public uint pad_11
        {
            get => (uint)row["pad_11"].Value;
            set => row["pad_11"].Value = value;
        }

        // Unknown.
        public float fadeInTimeSec
        {
            get => (float)row["fadeInTimeSec"].Value;
            set => row["fadeInTimeSec"].Value = value;
        }

        // Unknown.
        public float thinOutOverlapMultiRadius
        {
            get => (float)row["thinOutOverlapMultiRadius"].Value;
            set => row["thinOutOverlapMultiRadius"].Value = value;
        }

        // Unknown.
        public float thinOutNeighborAddRadius
        {
            get => (float)row["thinOutNeighborAddRadius"].Value;
            set => row["thinOutNeighborAddRadius"].Value = value;
        }

        // Unknown.
        public uint thinOutOverlapLimitNum
        {
            get => (uint)row["thinOutOverlapLimitNum"].Value;
            set => row["thinOutOverlapLimitNum"].Value = value;
        }

        // Unknown.
        public uint thinOutNeighborLimitNum
        {
            get => (uint)row["thinOutNeighborLimitNum"].Value;
            set => row["thinOutNeighborLimitNum"].Value = value;
        }

        // Unknown.
        public sbyte thinOutMode
        {
            get => (sbyte)row["thinOutMode"].Value;
            set => row["thinOutMode"].Value = value;
        }

        // Unknown.
        public byte emissiveColorR
        {
            get => (byte)row["emissiveColorR"].Value;
            set => row["emissiveColorR"].Value = value;
        }

        // Unknown.
        public byte emissiveColorG
        {
            get => (byte)row["emissiveColorG"].Value;
            set => row["emissiveColorG"].Value = value;
        }

        // Unknown.
        public byte emissiveColorB
        {
            get => (byte)row["emissiveColorB"].Value;
            set => row["emissiveColorB"].Value = value;
        }

        // Unknown.
        public float maxDecalSfxCreatableSlopeAngleDeg
        {
            get => (float)row["maxDecalSfxCreatableSlopeAngleDeg"].Value;
            set => row["maxDecalSfxCreatableSlopeAngleDeg"].Value = value;
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
    public DECAL_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public DECAL_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
