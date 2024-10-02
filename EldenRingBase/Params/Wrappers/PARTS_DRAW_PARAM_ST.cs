using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class PARTS_DRAW_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float lv01_BorderDist
        {
            get => (float)row["lv01_BorderDist"].Value;
            set => row["lv01_BorderDist"].Value = value;
        }

        // Unknown.
        public float lv01_PlayDist
        {
            get => (float)row["lv01_PlayDist"].Value;
            set => row["lv01_PlayDist"].Value = value;
        }

        // Unknown.
        public float lv12_BorderDist
        {
            get => (float)row["lv12_BorderDist"].Value;
            set => row["lv12_BorderDist"].Value = value;
        }

        // Unknown.
        public float lv12_PlayDist
        {
            get => (float)row["lv12_PlayDist"].Value;
            set => row["lv12_PlayDist"].Value = value;
        }

        // Unknown.
        public float lv23_BorderDist
        {
            get => (float)row["lv23_BorderDist"].Value;
            set => row["lv23_BorderDist"].Value = value;
        }

        // Unknown.
        public float lv23_PlayDist
        {
            get => (float)row["lv23_PlayDist"].Value;
            set => row["lv23_PlayDist"].Value = value;
        }

        // Unknown.
        public float lv34_BorderDist
        {
            get => (float)row["lv34_BorderDist"].Value;
            set => row["lv34_BorderDist"].Value = value;
        }

        // Unknown.
        public float lv34_PlayDist
        {
            get => (float)row["lv34_PlayDist"].Value;
            set => row["lv34_PlayDist"].Value = value;
        }

        // Unknown.
        public float lv45_BorderDist
        {
            get => (float)row["lv45_BorderDist"].Value;
            set => row["lv45_BorderDist"].Value = value;
        }

        // Unknown.
        public float lv45_PlayDist
        {
            get => (float)row["lv45_PlayDist"].Value;
            set => row["lv45_PlayDist"].Value = value;
        }

        // Unknown.
        public float tex_lv01_BorderDist
        {
            get => (float)row["tex_lv01_BorderDist"].Value;
            set => row["tex_lv01_BorderDist"].Value = value;
        }

        // Unknown.
        public float tex_lv01_PlayDist
        {
            get => (float)row["tex_lv01_PlayDist"].Value;
            set => row["tex_lv01_PlayDist"].Value = value;
        }

        // Unknown.
        public uint enableCrossFade
        {
            get => (uint)row["enableCrossFade"].Value;
            set => row["enableCrossFade"].Value = value;
        }

        // Unknown.
        public float drawDist
        {
            get => (float)row["drawDist"].Value;
            set => row["drawDist"].Value = value;
        }

        // Unknown.
        public float drawFadeRange
        {
            get => (float)row["drawFadeRange"].Value;
            set => row["drawFadeRange"].Value = value;
        }

        // Unknown.
        public float shadowDrawDist
        {
            get => (float)row["shadowDrawDist"].Value;
            set => row["shadowDrawDist"].Value = value;
        }

        // Unknown.
        public float shadowFadeRange
        {
            get => (float)row["shadowFadeRange"].Value;
            set => row["shadowFadeRange"].Value = value;
        }

        // Unknown.
        public float motionBlur_BorderDist
        {
            get => (float)row["motionBlur_BorderDist"].Value;
            set => row["motionBlur_BorderDist"].Value = value;
        }

        // Unknown.
        public sbyte isPointLightShadowSrc
        {
            get => (sbyte)row["isPointLightShadowSrc"].Value;
            set => row["isPointLightShadowSrc"].Value = value;
        }

        // Unknown.
        public sbyte isDirLightShadowSrc
        {
            get => (sbyte)row["isDirLightShadowSrc"].Value;
            set => row["isDirLightShadowSrc"].Value = value;
        }

        // Unknown.
        public sbyte isShadowDst
        {
            get => (sbyte)row["isShadowDst"].Value;
            set => row["isShadowDst"].Value = value;
        }

        // Unknown.
        public sbyte isShadowOnly
        {
            get => (sbyte)row["isShadowOnly"].Value;
            set => row["isShadowOnly"].Value = value;
        }

        // Unknown.
        public sbyte drawByReflectCam
        {
            get => (sbyte)row["drawByReflectCam"].Value;
            set => row["drawByReflectCam"].Value = value;
        }

        // Unknown.
        public sbyte drawOnlyReflectCam
        {
            get => (sbyte)row["drawOnlyReflectCam"].Value;
            set => row["drawOnlyReflectCam"].Value = value;
        }

        // Unknown.
        public sbyte IncludeLodMapLv
        {
            get => (sbyte)row["IncludeLodMapLv"].Value;
            set => row["IncludeLodMapLv"].Value = value;
        }

        // Unknown.
        public byte isNoFarClipDraw
        {
            get => (byte)row["isNoFarClipDraw"].Value;
            set => row["isNoFarClipDraw"].Value = value;
        }

        // Unknown.
        public byte lodType
        {
            get => (byte)row["lodType"].Value;
            set => row["lodType"].Value = value;
        }

        // Unknown.
        public sbyte shadowDrawLodOffset
        {
            get => (sbyte)row["shadowDrawLodOffset"].Value;
            set => row["shadowDrawLodOffset"].Value = value;
        }

        // Unknown.
        public byte isTraceCameraXZ
        {
            get => (byte)row["isTraceCameraXZ"].Value;
            set => row["isTraceCameraXZ"].Value = value;
        }

        // Unknown.
        public byte isSkydomeDrawPhase
        {
            get => (byte)row["isSkydomeDrawPhase"].Value;
            set => row["isSkydomeDrawPhase"].Value = value;
        }

        // Unknown.
        public float DistantViewModel_BorderDist
        {
            get => (float)row["DistantViewModel_BorderDist"].Value;
            set => row["DistantViewModel_BorderDist"].Value = value;
        }

        // Unknown.
        public float DistantViewModel_PlayDist
        {
            get => (float)row["DistantViewModel_PlayDist"].Value;
            set => row["DistantViewModel_PlayDist"].Value = value;
        }

        // Unknown.
        public float LimtedActivate_BorderDist_forGrid
        {
            get => (float)row["LimtedActivate_BorderDist_forGrid"].Value;
            set => row["LimtedActivate_BorderDist_forGrid"].Value = value;
        }

        // Unknown.
        public float LimtedActivate_PlayDist_forGrid
        {
            get => (float)row["LimtedActivate_PlayDist_forGrid"].Value;
            set => row["LimtedActivate_PlayDist_forGrid"].Value = value;
        }

        // Unknown.
        public float zSortOffsetForNoFarClipDraw
        {
            get => (float)row["zSortOffsetForNoFarClipDraw"].Value;
            set => row["zSortOffsetForNoFarClipDraw"].Value = value;
        }

        // Unknown.
        public float shadowDrawAlphaTestDist
        {
            get => (float)row["shadowDrawAlphaTestDist"].Value;
            set => row["shadowDrawAlphaTestDist"].Value = value;
        }

        // Unknown.
        public byte fowardDrawEnvmapBlendType
        {
            get => (byte)row["fowardDrawEnvmapBlendType"].Value;
            set => row["fowardDrawEnvmapBlendType"].Value = value;
        }

        // Unknown.
        public byte LBDrawDistScaleParamID
        {
            get => (byte)row["LBDrawDistScaleParamID"].Value;
            set => row["LBDrawDistScaleParamID"].Value = value;
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
    public PARTS_DRAW_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public PARTS_DRAW_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
