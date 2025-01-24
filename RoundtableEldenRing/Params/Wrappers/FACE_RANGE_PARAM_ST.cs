using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class FACE_RANGE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float face_partsId
        {
            get => (float)row["face_partsId"].Value;
            set => row["face_partsId"].Value = value;
        }

        // Unknown.
        public float skin_color_R
        {
            get => (float)row["skin_color_R"].Value;
            set => row["skin_color_R"].Value = value;
        }

        // Unknown.
        public float skin_color_G
        {
            get => (float)row["skin_color_G"].Value;
            set => row["skin_color_G"].Value = value;
        }

        // Unknown.
        public float skin_color_B
        {
            get => (float)row["skin_color_B"].Value;
            set => row["skin_color_B"].Value = value;
        }

        // Unknown.
        public float skin_gloss
        {
            get => (float)row["skin_gloss"].Value;
            set => row["skin_gloss"].Value = value;
        }

        // Unknown.
        public float skin_pores
        {
            get => (float)row["skin_pores"].Value;
            set => row["skin_pores"].Value = value;
        }

        // Unknown.
        public float face_beard
        {
            get => (float)row["face_beard"].Value;
            set => row["face_beard"].Value = value;
        }

        // Unknown.
        public float face_aroundEye
        {
            get => (float)row["face_aroundEye"].Value;
            set => row["face_aroundEye"].Value = value;
        }

        // Unknown.
        public float face_aroundEyeColor_R
        {
            get => (float)row["face_aroundEyeColor_R"].Value;
            set => row["face_aroundEyeColor_R"].Value = value;
        }

        // Unknown.
        public float face_aroundEyeColor_G
        {
            get => (float)row["face_aroundEyeColor_G"].Value;
            set => row["face_aroundEyeColor_G"].Value = value;
        }

        // Unknown.
        public float face_aroundEyeColor_B
        {
            get => (float)row["face_aroundEyeColor_B"].Value;
            set => row["face_aroundEyeColor_B"].Value = value;
        }

        // Unknown.
        public float face_cheek
        {
            get => (float)row["face_cheek"].Value;
            set => row["face_cheek"].Value = value;
        }

        // Unknown.
        public float face_cheekColor_R
        {
            get => (float)row["face_cheekColor_R"].Value;
            set => row["face_cheekColor_R"].Value = value;
        }

        // Unknown.
        public float face_cheekColor_G
        {
            get => (float)row["face_cheekColor_G"].Value;
            set => row["face_cheekColor_G"].Value = value;
        }

        // Unknown.
        public float face_cheekColor_B
        {
            get => (float)row["face_cheekColor_B"].Value;
            set => row["face_cheekColor_B"].Value = value;
        }

        // Unknown.
        public float face_eyeLine
        {
            get => (float)row["face_eyeLine"].Value;
            set => row["face_eyeLine"].Value = value;
        }

        // Unknown.
        public float face_eyeLineColor_R
        {
            get => (float)row["face_eyeLineColor_R"].Value;
            set => row["face_eyeLineColor_R"].Value = value;
        }

        // Unknown.
        public float face_eyeLineColor_G
        {
            get => (float)row["face_eyeLineColor_G"].Value;
            set => row["face_eyeLineColor_G"].Value = value;
        }

        // Unknown.
        public float face_eyeLineColor_B
        {
            get => (float)row["face_eyeLineColor_B"].Value;
            set => row["face_eyeLineColor_B"].Value = value;
        }

        // Unknown.
        public float face_eyeShadowDown
        {
            get => (float)row["face_eyeShadowDown"].Value;
            set => row["face_eyeShadowDown"].Value = value;
        }

        // Unknown.
        public float face_eyeShadowDownColor_R
        {
            get => (float)row["face_eyeShadowDownColor_R"].Value;
            set => row["face_eyeShadowDownColor_R"].Value = value;
        }

        // Unknown.
        public float face_eyeShadowDownColor_G
        {
            get => (float)row["face_eyeShadowDownColor_G"].Value;
            set => row["face_eyeShadowDownColor_G"].Value = value;
        }

        // Unknown.
        public float face_eyeShadowDownColor_B
        {
            get => (float)row["face_eyeShadowDownColor_B"].Value;
            set => row["face_eyeShadowDownColor_B"].Value = value;
        }

        // Unknown.
        public float face_eyeShadowUp
        {
            get => (float)row["face_eyeShadowUp"].Value;
            set => row["face_eyeShadowUp"].Value = value;
        }

        // Unknown.
        public float face_eyeShadowUpColor_R
        {
            get => (float)row["face_eyeShadowUpColor_R"].Value;
            set => row["face_eyeShadowUpColor_R"].Value = value;
        }

        // Unknown.
        public float face_eyeShadowUpColor_G
        {
            get => (float)row["face_eyeShadowUpColor_G"].Value;
            set => row["face_eyeShadowUpColor_G"].Value = value;
        }

        // Unknown.
        public float face_eyeShadowUpColor_B
        {
            get => (float)row["face_eyeShadowUpColor_B"].Value;
            set => row["face_eyeShadowUpColor_B"].Value = value;
        }

        // Unknown.
        public float face_lip
        {
            get => (float)row["face_lip"].Value;
            set => row["face_lip"].Value = value;
        }

        // Unknown.
        public float face_lipColor_R
        {
            get => (float)row["face_lipColor_R"].Value;
            set => row["face_lipColor_R"].Value = value;
        }

        // Unknown.
        public float face_lipColor_G
        {
            get => (float)row["face_lipColor_G"].Value;
            set => row["face_lipColor_G"].Value = value;
        }

        // Unknown.
        public float face_lipColor_B
        {
            get => (float)row["face_lipColor_B"].Value;
            set => row["face_lipColor_B"].Value = value;
        }

        // Unknown.
        public float body_hair
        {
            get => (float)row["body_hair"].Value;
            set => row["body_hair"].Value = value;
        }

        // Unknown.
        public float body_hairColor_R
        {
            get => (float)row["body_hairColor_R"].Value;
            set => row["body_hairColor_R"].Value = value;
        }

        // Unknown.
        public float body_hairColor_G
        {
            get => (float)row["body_hairColor_G"].Value;
            set => row["body_hairColor_G"].Value = value;
        }

        // Unknown.
        public float body_hairColor_B
        {
            get => (float)row["body_hairColor_B"].Value;
            set => row["body_hairColor_B"].Value = value;
        }

        // Unknown.
        public float eye_partsId
        {
            get => (float)row["eye_partsId"].Value;
            set => row["eye_partsId"].Value = value;
        }

        // Unknown.
        public float eyeR_irisColor_R
        {
            get => (float)row["eyeR_irisColor_R"].Value;
            set => row["eyeR_irisColor_R"].Value = value;
        }

        // Unknown.
        public float eyeR_irisColor_G
        {
            get => (float)row["eyeR_irisColor_G"].Value;
            set => row["eyeR_irisColor_G"].Value = value;
        }

        // Unknown.
        public float eyeR_irisColor_B
        {
            get => (float)row["eyeR_irisColor_B"].Value;
            set => row["eyeR_irisColor_B"].Value = value;
        }

        // Unknown.
        public float eyeR_irisScale
        {
            get => (float)row["eyeR_irisScale"].Value;
            set => row["eyeR_irisScale"].Value = value;
        }

        // Unknown.
        public float eyeR_cataract
        {
            get => (float)row["eyeR_cataract"].Value;
            set => row["eyeR_cataract"].Value = value;
        }

        // Unknown.
        public float eyeR_cataractColor_R
        {
            get => (float)row["eyeR_cataractColor_R"].Value;
            set => row["eyeR_cataractColor_R"].Value = value;
        }

        // Unknown.
        public float eyeR_cataractColor_G
        {
            get => (float)row["eyeR_cataractColor_G"].Value;
            set => row["eyeR_cataractColor_G"].Value = value;
        }

        // Unknown.
        public float eyeR_cataractColor_B
        {
            get => (float)row["eyeR_cataractColor_B"].Value;
            set => row["eyeR_cataractColor_B"].Value = value;
        }

        // Unknown.
        public float eyeR_scleraColor_R
        {
            get => (float)row["eyeR_scleraColor_R"].Value;
            set => row["eyeR_scleraColor_R"].Value = value;
        }

        // Unknown.
        public float eyeR_scleraColor_G
        {
            get => (float)row["eyeR_scleraColor_G"].Value;
            set => row["eyeR_scleraColor_G"].Value = value;
        }

        // Unknown.
        public float eyeR_scleraColor_B
        {
            get => (float)row["eyeR_scleraColor_B"].Value;
            set => row["eyeR_scleraColor_B"].Value = value;
        }

        // Unknown.
        public float eyeR_irisDistance
        {
            get => (float)row["eyeR_irisDistance"].Value;
            set => row["eyeR_irisDistance"].Value = value;
        }

        // Unknown.
        public float eyeL_irisColor_R
        {
            get => (float)row["eyeL_irisColor_R"].Value;
            set => row["eyeL_irisColor_R"].Value = value;
        }

        // Unknown.
        public float eyeL_irisColor_G
        {
            get => (float)row["eyeL_irisColor_G"].Value;
            set => row["eyeL_irisColor_G"].Value = value;
        }

        // Unknown.
        public float eyeL_irisColor_B
        {
            get => (float)row["eyeL_irisColor_B"].Value;
            set => row["eyeL_irisColor_B"].Value = value;
        }

        // Unknown.
        public float eyeL_irisScale
        {
            get => (float)row["eyeL_irisScale"].Value;
            set => row["eyeL_irisScale"].Value = value;
        }

        // Unknown.
        public float eyeL_cataract
        {
            get => (float)row["eyeL_cataract"].Value;
            set => row["eyeL_cataract"].Value = value;
        }

        // Unknown.
        public float eyeL_cataractColor_R
        {
            get => (float)row["eyeL_cataractColor_R"].Value;
            set => row["eyeL_cataractColor_R"].Value = value;
        }

        // Unknown.
        public float eyeL_cataractColor_G
        {
            get => (float)row["eyeL_cataractColor_G"].Value;
            set => row["eyeL_cataractColor_G"].Value = value;
        }

        // Unknown.
        public float eyeL_cataractColor_B
        {
            get => (float)row["eyeL_cataractColor_B"].Value;
            set => row["eyeL_cataractColor_B"].Value = value;
        }

        // Unknown.
        public float eyeL_scleraColor_R
        {
            get => (float)row["eyeL_scleraColor_R"].Value;
            set => row["eyeL_scleraColor_R"].Value = value;
        }

        // Unknown.
        public float eyeL_scleraColor_G
        {
            get => (float)row["eyeL_scleraColor_G"].Value;
            set => row["eyeL_scleraColor_G"].Value = value;
        }

        // Unknown.
        public float eyeL_scleraColor_B
        {
            get => (float)row["eyeL_scleraColor_B"].Value;
            set => row["eyeL_scleraColor_B"].Value = value;
        }

        // Unknown.
        public float eyeL_irisDistance
        {
            get => (float)row["eyeL_irisDistance"].Value;
            set => row["eyeL_irisDistance"].Value = value;
        }

        // Unknown.
        public float hair_partsId
        {
            get => (float)row["hair_partsId"].Value;
            set => row["hair_partsId"].Value = value;
        }

        // Unknown.
        public float hair_color_R
        {
            get => (float)row["hair_color_R"].Value;
            set => row["hair_color_R"].Value = value;
        }

        // Unknown.
        public float hair_color_G
        {
            get => (float)row["hair_color_G"].Value;
            set => row["hair_color_G"].Value = value;
        }

        // Unknown.
        public float hair_color_B
        {
            get => (float)row["hair_color_B"].Value;
            set => row["hair_color_B"].Value = value;
        }

        // Unknown.
        public float hair_shininess
        {
            get => (float)row["hair_shininess"].Value;
            set => row["hair_shininess"].Value = value;
        }

        // Unknown.
        public float hair_rootBlack
        {
            get => (float)row["hair_rootBlack"].Value;
            set => row["hair_rootBlack"].Value = value;
        }

        // Unknown.
        public float hair_whiteDensity
        {
            get => (float)row["hair_whiteDensity"].Value;
            set => row["hair_whiteDensity"].Value = value;
        }

        // Unknown.
        public float beard_partsId
        {
            get => (float)row["beard_partsId"].Value;
            set => row["beard_partsId"].Value = value;
        }

        // Unknown.
        public float beard_color_R
        {
            get => (float)row["beard_color_R"].Value;
            set => row["beard_color_R"].Value = value;
        }

        // Unknown.
        public float beard_color_G
        {
            get => (float)row["beard_color_G"].Value;
            set => row["beard_color_G"].Value = value;
        }

        // Unknown.
        public float beard_color_B
        {
            get => (float)row["beard_color_B"].Value;
            set => row["beard_color_B"].Value = value;
        }

        // Unknown.
        public float beard_shininess
        {
            get => (float)row["beard_shininess"].Value;
            set => row["beard_shininess"].Value = value;
        }

        // Unknown.
        public float beard_rootBlack
        {
            get => (float)row["beard_rootBlack"].Value;
            set => row["beard_rootBlack"].Value = value;
        }

        // Unknown.
        public float beard_whiteDensity
        {
            get => (float)row["beard_whiteDensity"].Value;
            set => row["beard_whiteDensity"].Value = value;
        }

        // Unknown.
        public float eyebrow_partsId
        {
            get => (float)row["eyebrow_partsId"].Value;
            set => row["eyebrow_partsId"].Value = value;
        }

        // Unknown.
        public float eyebrow_color_R
        {
            get => (float)row["eyebrow_color_R"].Value;
            set => row["eyebrow_color_R"].Value = value;
        }

        // Unknown.
        public float eyebrow_color_G
        {
            get => (float)row["eyebrow_color_G"].Value;
            set => row["eyebrow_color_G"].Value = value;
        }

        // Unknown.
        public float eyebrow_color_B
        {
            get => (float)row["eyebrow_color_B"].Value;
            set => row["eyebrow_color_B"].Value = value;
        }

        // Unknown.
        public float eyebrow_shininess
        {
            get => (float)row["eyebrow_shininess"].Value;
            set => row["eyebrow_shininess"].Value = value;
        }

        // Unknown.
        public float eyebrow_rootBlack
        {
            get => (float)row["eyebrow_rootBlack"].Value;
            set => row["eyebrow_rootBlack"].Value = value;
        }

        // Unknown.
        public float eyebrow_whiteDensity
        {
            get => (float)row["eyebrow_whiteDensity"].Value;
            set => row["eyebrow_whiteDensity"].Value = value;
        }

        // Unknown.
        public float eyelash_partsId
        {
            get => (float)row["eyelash_partsId"].Value;
            set => row["eyelash_partsId"].Value = value;
        }

        // Unknown.
        public float eyelash_color_R
        {
            get => (float)row["eyelash_color_R"].Value;
            set => row["eyelash_color_R"].Value = value;
        }

        // Unknown.
        public float eyelash_color_G
        {
            get => (float)row["eyelash_color_G"].Value;
            set => row["eyelash_color_G"].Value = value;
        }

        // Unknown.
        public float eyelash_color_B
        {
            get => (float)row["eyelash_color_B"].Value;
            set => row["eyelash_color_B"].Value = value;
        }

        // Unknown.
        public float accessories_partsId
        {
            get => (float)row["accessories_partsId"].Value;
            set => row["accessories_partsId"].Value = value;
        }

        // Unknown.
        public float accessories_color_R
        {
            get => (float)row["accessories_color_R"].Value;
            set => row["accessories_color_R"].Value = value;
        }

        // Unknown.
        public float accessories_color_G
        {
            get => (float)row["accessories_color_G"].Value;
            set => row["accessories_color_G"].Value = value;
        }

        // Unknown.
        public float accessories_color_B
        {
            get => (float)row["accessories_color_B"].Value;
            set => row["accessories_color_B"].Value = value;
        }

        // Unknown.
        public float decal_partsId
        {
            get => (float)row["decal_partsId"].Value;
            set => row["decal_partsId"].Value = value;
        }

        // Unknown.
        public float decal_posX
        {
            get => (float)row["decal_posX"].Value;
            set => row["decal_posX"].Value = value;
        }

        // Unknown.
        public float decal_posY
        {
            get => (float)row["decal_posY"].Value;
            set => row["decal_posY"].Value = value;
        }

        // Unknown.
        public float decal_angle
        {
            get => (float)row["decal_angle"].Value;
            set => row["decal_angle"].Value = value;
        }

        // Unknown.
        public float decal_scale
        {
            get => (float)row["decal_scale"].Value;
            set => row["decal_scale"].Value = value;
        }

        // Unknown.
        public float decal_color_R
        {
            get => (float)row["decal_color_R"].Value;
            set => row["decal_color_R"].Value = value;
        }

        // Unknown.
        public float decal_color_G
        {
            get => (float)row["decal_color_G"].Value;
            set => row["decal_color_G"].Value = value;
        }

        // Unknown.
        public float decal_color_B
        {
            get => (float)row["decal_color_B"].Value;
            set => row["decal_color_B"].Value = value;
        }

        // Unknown.
        public float decal_gloss
        {
            get => (float)row["decal_gloss"].Value;
            set => row["decal_gloss"].Value = value;
        }

        // Unknown.
        public float decal_mirror
        {
            get => (float)row["decal_mirror"].Value;
            set => row["decal_mirror"].Value = value;
        }

        // Unknown.
        public float chrBodyScaleHead
        {
            get => (float)row["chrBodyScaleHead"].Value;
            set => row["chrBodyScaleHead"].Value = value;
        }

        // Unknown.
        public float chrBodyScaleBreast
        {
            get => (float)row["chrBodyScaleBreast"].Value;
            set => row["chrBodyScaleBreast"].Value = value;
        }

        // Unknown.
        public float chrBodyScaleAbdomen
        {
            get => (float)row["chrBodyScaleAbdomen"].Value;
            set => row["chrBodyScaleAbdomen"].Value = value;
        }

        // Unknown.
        public float chrBodyScaleArm
        {
            get => (float)row["chrBodyScaleArm"].Value;
            set => row["chrBodyScaleArm"].Value = value;
        }

        // Unknown.
        public float chrBodyScaleLeg
        {
            get => (float)row["chrBodyScaleLeg"].Value;
            set => row["chrBodyScaleLeg"].Value = value;
        }

        // Unknown.
        public float age
        {
            get => (float)row["age"].Value;
            set => row["age"].Value = value;
        }

        // Unknown.
        public float gender
        {
            get => (float)row["gender"].Value;
            set => row["gender"].Value = value;
        }

        // Unknown.
        public float caricatureGeometry
        {
            get => (float)row["caricatureGeometry"].Value;
            set => row["caricatureGeometry"].Value = value;
        }

        // Unknown.
        public float caricatureTexture
        {
            get => (float)row["caricatureTexture"].Value;
            set => row["caricatureTexture"].Value = value;
        }

        // Unknown.
        public float faceGeoData00
        {
            get => (float)row["faceGeoData00"].Value;
            set => row["faceGeoData00"].Value = value;
        }

        // Unknown.
        public float faceGeoData01
        {
            get => (float)row["faceGeoData01"].Value;
            set => row["faceGeoData01"].Value = value;
        }

        // Unknown.
        public float faceGeoData02
        {
            get => (float)row["faceGeoData02"].Value;
            set => row["faceGeoData02"].Value = value;
        }

        // Unknown.
        public float faceGeoData03
        {
            get => (float)row["faceGeoData03"].Value;
            set => row["faceGeoData03"].Value = value;
        }

        // Unknown.
        public float faceGeoData04
        {
            get => (float)row["faceGeoData04"].Value;
            set => row["faceGeoData04"].Value = value;
        }

        // Unknown.
        public float faceGeoData05
        {
            get => (float)row["faceGeoData05"].Value;
            set => row["faceGeoData05"].Value = value;
        }

        // Unknown.
        public float faceGeoData06
        {
            get => (float)row["faceGeoData06"].Value;
            set => row["faceGeoData06"].Value = value;
        }

        // Unknown.
        public float faceGeoData07
        {
            get => (float)row["faceGeoData07"].Value;
            set => row["faceGeoData07"].Value = value;
        }

        // Unknown.
        public float faceGeoData08
        {
            get => (float)row["faceGeoData08"].Value;
            set => row["faceGeoData08"].Value = value;
        }

        // Unknown.
        public float faceGeoData09
        {
            get => (float)row["faceGeoData09"].Value;
            set => row["faceGeoData09"].Value = value;
        }

        // Unknown.
        public float faceGeoData10
        {
            get => (float)row["faceGeoData10"].Value;
            set => row["faceGeoData10"].Value = value;
        }

        // Unknown.
        public float faceGeoData11
        {
            get => (float)row["faceGeoData11"].Value;
            set => row["faceGeoData11"].Value = value;
        }

        // Unknown.
        public float faceGeoData12
        {
            get => (float)row["faceGeoData12"].Value;
            set => row["faceGeoData12"].Value = value;
        }

        // Unknown.
        public float faceGeoData13
        {
            get => (float)row["faceGeoData13"].Value;
            set => row["faceGeoData13"].Value = value;
        }

        // Unknown.
        public float faceGeoData14
        {
            get => (float)row["faceGeoData14"].Value;
            set => row["faceGeoData14"].Value = value;
        }

        // Unknown.
        public float faceGeoData15
        {
            get => (float)row["faceGeoData15"].Value;
            set => row["faceGeoData15"].Value = value;
        }

        // Unknown.
        public float faceGeoData16
        {
            get => (float)row["faceGeoData16"].Value;
            set => row["faceGeoData16"].Value = value;
        }

        // Unknown.
        public float faceGeoData17
        {
            get => (float)row["faceGeoData17"].Value;
            set => row["faceGeoData17"].Value = value;
        }

        // Unknown.
        public float faceGeoData18
        {
            get => (float)row["faceGeoData18"].Value;
            set => row["faceGeoData18"].Value = value;
        }

        // Unknown.
        public float faceGeoData19
        {
            get => (float)row["faceGeoData19"].Value;
            set => row["faceGeoData19"].Value = value;
        }

        // Unknown.
        public float faceGeoData20
        {
            get => (float)row["faceGeoData20"].Value;
            set => row["faceGeoData20"].Value = value;
        }

        // Unknown.
        public float faceGeoData21
        {
            get => (float)row["faceGeoData21"].Value;
            set => row["faceGeoData21"].Value = value;
        }

        // Unknown.
        public float faceGeoData22
        {
            get => (float)row["faceGeoData22"].Value;
            set => row["faceGeoData22"].Value = value;
        }

        // Unknown.
        public float faceGeoData23
        {
            get => (float)row["faceGeoData23"].Value;
            set => row["faceGeoData23"].Value = value;
        }

        // Unknown.
        public float faceGeoData24
        {
            get => (float)row["faceGeoData24"].Value;
            set => row["faceGeoData24"].Value = value;
        }

        // Unknown.
        public float faceGeoData25
        {
            get => (float)row["faceGeoData25"].Value;
            set => row["faceGeoData25"].Value = value;
        }

        // Unknown.
        public float faceGeoData26
        {
            get => (float)row["faceGeoData26"].Value;
            set => row["faceGeoData26"].Value = value;
        }

        // Unknown.
        public float faceGeoData27
        {
            get => (float)row["faceGeoData27"].Value;
            set => row["faceGeoData27"].Value = value;
        }

        // Unknown.
        public float faceGeoData28
        {
            get => (float)row["faceGeoData28"].Value;
            set => row["faceGeoData28"].Value = value;
        }

        // Unknown.
        public float faceGeoData29
        {
            get => (float)row["faceGeoData29"].Value;
            set => row["faceGeoData29"].Value = value;
        }

        // Unknown.
        public float faceGeoData30
        {
            get => (float)row["faceGeoData30"].Value;
            set => row["faceGeoData30"].Value = value;
        }

        // Unknown.
        public float faceGeoData31
        {
            get => (float)row["faceGeoData31"].Value;
            set => row["faceGeoData31"].Value = value;
        }

        // Unknown.
        public float faceGeoData32
        {
            get => (float)row["faceGeoData32"].Value;
            set => row["faceGeoData32"].Value = value;
        }

        // Unknown.
        public float faceGeoData33
        {
            get => (float)row["faceGeoData33"].Value;
            set => row["faceGeoData33"].Value = value;
        }

        // Unknown.
        public float faceGeoData34
        {
            get => (float)row["faceGeoData34"].Value;
            set => row["faceGeoData34"].Value = value;
        }

        // Unknown.
        public float faceGeoData35
        {
            get => (float)row["faceGeoData35"].Value;
            set => row["faceGeoData35"].Value = value;
        }

        // Unknown.
        public float faceGeoData36
        {
            get => (float)row["faceGeoData36"].Value;
            set => row["faceGeoData36"].Value = value;
        }

        // Unknown.
        public float faceGeoData37
        {
            get => (float)row["faceGeoData37"].Value;
            set => row["faceGeoData37"].Value = value;
        }

        // Unknown.
        public float faceGeoData38
        {
            get => (float)row["faceGeoData38"].Value;
            set => row["faceGeoData38"].Value = value;
        }

        // Unknown.
        public float faceGeoData39
        {
            get => (float)row["faceGeoData39"].Value;
            set => row["faceGeoData39"].Value = value;
        }

        // Unknown.
        public float faceGeoData40
        {
            get => (float)row["faceGeoData40"].Value;
            set => row["faceGeoData40"].Value = value;
        }

        // Unknown.
        public float faceGeoData41
        {
            get => (float)row["faceGeoData41"].Value;
            set => row["faceGeoData41"].Value = value;
        }

        // Unknown.
        public float faceGeoData42
        {
            get => (float)row["faceGeoData42"].Value;
            set => row["faceGeoData42"].Value = value;
        }

        // Unknown.
        public float faceGeoData43
        {
            get => (float)row["faceGeoData43"].Value;
            set => row["faceGeoData43"].Value = value;
        }

        // Unknown.
        public float faceGeoData44
        {
            get => (float)row["faceGeoData44"].Value;
            set => row["faceGeoData44"].Value = value;
        }

        // Unknown.
        public float faceGeoData45
        {
            get => (float)row["faceGeoData45"].Value;
            set => row["faceGeoData45"].Value = value;
        }

        // Unknown.
        public float faceGeoData46
        {
            get => (float)row["faceGeoData46"].Value;
            set => row["faceGeoData46"].Value = value;
        }

        // Unknown.
        public float faceGeoData47
        {
            get => (float)row["faceGeoData47"].Value;
            set => row["faceGeoData47"].Value = value;
        }

        // Unknown.
        public float faceGeoData48
        {
            get => (float)row["faceGeoData48"].Value;
            set => row["faceGeoData48"].Value = value;
        }

        // Unknown.
        public float faceGeoData49
        {
            get => (float)row["faceGeoData49"].Value;
            set => row["faceGeoData49"].Value = value;
        }

        // Unknown.
        public float faceGeoData50
        {
            get => (float)row["faceGeoData50"].Value;
            set => row["faceGeoData50"].Value = value;
        }

        // Unknown.
        public float faceGeoData51
        {
            get => (float)row["faceGeoData51"].Value;
            set => row["faceGeoData51"].Value = value;
        }

        // Unknown.
        public float faceGeoData52
        {
            get => (float)row["faceGeoData52"].Value;
            set => row["faceGeoData52"].Value = value;
        }

        // Unknown.
        public float faceGeoData53
        {
            get => (float)row["faceGeoData53"].Value;
            set => row["faceGeoData53"].Value = value;
        }

        // Unknown.
        public float faceGeoData54
        {
            get => (float)row["faceGeoData54"].Value;
            set => row["faceGeoData54"].Value = value;
        }

        // Unknown.
        public float faceGeoData55
        {
            get => (float)row["faceGeoData55"].Value;
            set => row["faceGeoData55"].Value = value;
        }

        // Unknown.
        public float faceGeoData56
        {
            get => (float)row["faceGeoData56"].Value;
            set => row["faceGeoData56"].Value = value;
        }

        // Unknown.
        public float faceGeoData57
        {
            get => (float)row["faceGeoData57"].Value;
            set => row["faceGeoData57"].Value = value;
        }

        // Unknown.
        public float faceGeoData58
        {
            get => (float)row["faceGeoData58"].Value;
            set => row["faceGeoData58"].Value = value;
        }

        // Unknown.
        public float faceGeoData59
        {
            get => (float)row["faceGeoData59"].Value;
            set => row["faceGeoData59"].Value = value;
        }

        // Unknown.
        public float faceGeoData60
        {
            get => (float)row["faceGeoData60"].Value;
            set => row["faceGeoData60"].Value = value;
        }

        // Unknown.
        public float faceTexData00
        {
            get => (float)row["faceTexData00"].Value;
            set => row["faceTexData00"].Value = value;
        }

        // Unknown.
        public float faceTexData01
        {
            get => (float)row["faceTexData01"].Value;
            set => row["faceTexData01"].Value = value;
        }

        // Unknown.
        public float faceTexData02
        {
            get => (float)row["faceTexData02"].Value;
            set => row["faceTexData02"].Value = value;
        }

        // Unknown.
        public float faceTexData03
        {
            get => (float)row["faceTexData03"].Value;
            set => row["faceTexData03"].Value = value;
        }

        // Unknown.
        public float faceTexData04
        {
            get => (float)row["faceTexData04"].Value;
            set => row["faceTexData04"].Value = value;
        }

        // Unknown.
        public float faceTexData05
        {
            get => (float)row["faceTexData05"].Value;
            set => row["faceTexData05"].Value = value;
        }

        // Unknown.
        public float faceTexData06
        {
            get => (float)row["faceTexData06"].Value;
            set => row["faceTexData06"].Value = value;
        }

        // Unknown.
        public float faceTexData07
        {
            get => (float)row["faceTexData07"].Value;
            set => row["faceTexData07"].Value = value;
        }

        // Unknown.
        public float faceTexData08
        {
            get => (float)row["faceTexData08"].Value;
            set => row["faceTexData08"].Value = value;
        }

        // Unknown.
        public float faceTexData09
        {
            get => (float)row["faceTexData09"].Value;
            set => row["faceTexData09"].Value = value;
        }

        // Unknown.
        public float faceTexData10
        {
            get => (float)row["faceTexData10"].Value;
            set => row["faceTexData10"].Value = value;
        }

        // Unknown.
        public float faceTexData11
        {
            get => (float)row["faceTexData11"].Value;
            set => row["faceTexData11"].Value = value;
        }

        // Unknown.
        public float faceTexData12
        {
            get => (float)row["faceTexData12"].Value;
            set => row["faceTexData12"].Value = value;
        }

        // Unknown.
        public float faceTexData13
        {
            get => (float)row["faceTexData13"].Value;
            set => row["faceTexData13"].Value = value;
        }

        // Unknown.
        public float faceTexData14
        {
            get => (float)row["faceTexData14"].Value;
            set => row["faceTexData14"].Value = value;
        }

        // Unknown.
        public float faceTexData15
        {
            get => (float)row["faceTexData15"].Value;
            set => row["faceTexData15"].Value = value;
        }

        // Unknown.
        public float faceTexData16
        {
            get => (float)row["faceTexData16"].Value;
            set => row["faceTexData16"].Value = value;
        }

        // Unknown.
        public float faceTexData17
        {
            get => (float)row["faceTexData17"].Value;
            set => row["faceTexData17"].Value = value;
        }

        // Unknown.
        public float faceTexData18
        {
            get => (float)row["faceTexData18"].Value;
            set => row["faceTexData18"].Value = value;
        }

        // Unknown.
        public float faceTexData19
        {
            get => (float)row["faceTexData19"].Value;
            set => row["faceTexData19"].Value = value;
        }

        // Unknown.
        public float faceTexData20
        {
            get => (float)row["faceTexData20"].Value;
            set => row["faceTexData20"].Value = value;
        }

        // Unknown.
        public float faceTexData21
        {
            get => (float)row["faceTexData21"].Value;
            set => row["faceTexData21"].Value = value;
        }

        // Unknown.
        public float faceTexData22
        {
            get => (float)row["faceTexData22"].Value;
            set => row["faceTexData22"].Value = value;
        }

        // Unknown.
        public float faceTexData23
        {
            get => (float)row["faceTexData23"].Value;
            set => row["faceTexData23"].Value = value;
        }

        // Unknown.
        public float faceTexData24
        {
            get => (float)row["faceTexData24"].Value;
            set => row["faceTexData24"].Value = value;
        }

        // Unknown.
        public float faceTexData25
        {
            get => (float)row["faceTexData25"].Value;
            set => row["faceTexData25"].Value = value;
        }

        // Unknown.
        public float faceTexData26
        {
            get => (float)row["faceTexData26"].Value;
            set => row["faceTexData26"].Value = value;
        }

        // Unknown.
        public float faceTexData27
        {
            get => (float)row["faceTexData27"].Value;
            set => row["faceTexData27"].Value = value;
        }

        // Unknown.
        public float faceTexData28
        {
            get => (float)row["faceTexData28"].Value;
            set => row["faceTexData28"].Value = value;
        }

        // Unknown.
        public float faceTexData29
        {
            get => (float)row["faceTexData29"].Value;
            set => row["faceTexData29"].Value = value;
        }

        // Unknown.
        public float faceTexData30
        {
            get => (float)row["faceTexData30"].Value;
            set => row["faceTexData30"].Value = value;
        }

        // Unknown.
        public float faceTexData31
        {
            get => (float)row["faceTexData31"].Value;
            set => row["faceTexData31"].Value = value;
        }

        // Unknown.
        public float faceTexData32
        {
            get => (float)row["faceTexData32"].Value;
            set => row["faceTexData32"].Value = value;
        }

        // Unknown.
        public float faceTexData33
        {
            get => (float)row["faceTexData33"].Value;
            set => row["faceTexData33"].Value = value;
        }

        // Unknown.
        public float faceTexData34
        {
            get => (float)row["faceTexData34"].Value;
            set => row["faceTexData34"].Value = value;
        }

        // Unknown.
        public float faceTexData35
        {
            get => (float)row["faceTexData35"].Value;
            set => row["faceTexData35"].Value = value;
        }

        // Unknown.
        public float burn_scar
        {
            get => (float)row["burn_scar"].Value;
            set => row["burn_scar"].Value = value;
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
    public FACE_RANGE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public FACE_RANGE_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
