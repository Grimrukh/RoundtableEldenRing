using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class FACE_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte face_partsId
        {
            get => (byte)row["face_partsId"].Value;
            set => row["face_partsId"].Value = value;
        }

        // Unknown.
        public byte skin_color_R
        {
            get => (byte)row["skin_color_R"].Value;
            set => row["skin_color_R"].Value = value;
        }

        // Unknown.
        public byte skin_color_G
        {
            get => (byte)row["skin_color_G"].Value;
            set => row["skin_color_G"].Value = value;
        }

        // Unknown.
        public byte skin_color_B
        {
            get => (byte)row["skin_color_B"].Value;
            set => row["skin_color_B"].Value = value;
        }

        // Unknown.
        public byte skin_gloss
        {
            get => (byte)row["skin_gloss"].Value;
            set => row["skin_gloss"].Value = value;
        }

        // Unknown.
        public byte skin_pores
        {
            get => (byte)row["skin_pores"].Value;
            set => row["skin_pores"].Value = value;
        }

        // Unknown.
        public byte face_beard
        {
            get => (byte)row["face_beard"].Value;
            set => row["face_beard"].Value = value;
        }

        // Unknown.
        public byte face_aroundEye
        {
            get => (byte)row["face_aroundEye"].Value;
            set => row["face_aroundEye"].Value = value;
        }

        // Unknown.
        public byte face_aroundEyeColor_R
        {
            get => (byte)row["face_aroundEyeColor_R"].Value;
            set => row["face_aroundEyeColor_R"].Value = value;
        }

        // Unknown.
        public byte face_aroundEyeColor_G
        {
            get => (byte)row["face_aroundEyeColor_G"].Value;
            set => row["face_aroundEyeColor_G"].Value = value;
        }

        // Unknown.
        public byte face_aroundEyeColor_B
        {
            get => (byte)row["face_aroundEyeColor_B"].Value;
            set => row["face_aroundEyeColor_B"].Value = value;
        }

        // Unknown.
        public byte face_cheek
        {
            get => (byte)row["face_cheek"].Value;
            set => row["face_cheek"].Value = value;
        }

        // Unknown.
        public byte face_cheekColor_R
        {
            get => (byte)row["face_cheekColor_R"].Value;
            set => row["face_cheekColor_R"].Value = value;
        }

        // Unknown.
        public byte face_cheekColor_G
        {
            get => (byte)row["face_cheekColor_G"].Value;
            set => row["face_cheekColor_G"].Value = value;
        }

        // Unknown.
        public byte face_cheekColor_B
        {
            get => (byte)row["face_cheekColor_B"].Value;
            set => row["face_cheekColor_B"].Value = value;
        }

        // Unknown.
        public byte face_eyeLine
        {
            get => (byte)row["face_eyeLine"].Value;
            set => row["face_eyeLine"].Value = value;
        }

        // Unknown.
        public byte face_eyeLineColor_R
        {
            get => (byte)row["face_eyeLineColor_R"].Value;
            set => row["face_eyeLineColor_R"].Value = value;
        }

        // Unknown.
        public byte face_eyeLineColor_G
        {
            get => (byte)row["face_eyeLineColor_G"].Value;
            set => row["face_eyeLineColor_G"].Value = value;
        }

        // Unknown.
        public byte face_eyeLineColor_B
        {
            get => (byte)row["face_eyeLineColor_B"].Value;
            set => row["face_eyeLineColor_B"].Value = value;
        }

        // Unknown.
        public byte face_eyeShadowDown
        {
            get => (byte)row["face_eyeShadowDown"].Value;
            set => row["face_eyeShadowDown"].Value = value;
        }

        // Unknown.
        public byte face_eyeShadowDownColor_R
        {
            get => (byte)row["face_eyeShadowDownColor_R"].Value;
            set => row["face_eyeShadowDownColor_R"].Value = value;
        }

        // Unknown.
        public byte face_eyeShadowDownColor_G
        {
            get => (byte)row["face_eyeShadowDownColor_G"].Value;
            set => row["face_eyeShadowDownColor_G"].Value = value;
        }

        // Unknown.
        public byte face_eyeShadowDownColor_B
        {
            get => (byte)row["face_eyeShadowDownColor_B"].Value;
            set => row["face_eyeShadowDownColor_B"].Value = value;
        }

        // Unknown.
        public byte face_eyeShadowUp
        {
            get => (byte)row["face_eyeShadowUp"].Value;
            set => row["face_eyeShadowUp"].Value = value;
        }

        // Unknown.
        public byte face_eyeShadowUpColor_R
        {
            get => (byte)row["face_eyeShadowUpColor_R"].Value;
            set => row["face_eyeShadowUpColor_R"].Value = value;
        }

        // Unknown.
        public byte face_eyeShadowUpColor_G
        {
            get => (byte)row["face_eyeShadowUpColor_G"].Value;
            set => row["face_eyeShadowUpColor_G"].Value = value;
        }

        // Unknown.
        public byte face_eyeShadowUpColor_B
        {
            get => (byte)row["face_eyeShadowUpColor_B"].Value;
            set => row["face_eyeShadowUpColor_B"].Value = value;
        }

        // Unknown.
        public byte face_lip
        {
            get => (byte)row["face_lip"].Value;
            set => row["face_lip"].Value = value;
        }

        // Unknown.
        public byte face_lipColor_R
        {
            get => (byte)row["face_lipColor_R"].Value;
            set => row["face_lipColor_R"].Value = value;
        }

        // Unknown.
        public byte face_lipColor_G
        {
            get => (byte)row["face_lipColor_G"].Value;
            set => row["face_lipColor_G"].Value = value;
        }

        // Unknown.
        public byte face_lipColor_B
        {
            get => (byte)row["face_lipColor_B"].Value;
            set => row["face_lipColor_B"].Value = value;
        }

        // Unknown.
        public byte body_hair
        {
            get => (byte)row["body_hair"].Value;
            set => row["body_hair"].Value = value;
        }

        // Unknown.
        public byte body_hairColor_R
        {
            get => (byte)row["body_hairColor_R"].Value;
            set => row["body_hairColor_R"].Value = value;
        }

        // Unknown.
        public byte body_hairColor_G
        {
            get => (byte)row["body_hairColor_G"].Value;
            set => row["body_hairColor_G"].Value = value;
        }

        // Unknown.
        public byte body_hairColor_B
        {
            get => (byte)row["body_hairColor_B"].Value;
            set => row["body_hairColor_B"].Value = value;
        }

        // Unknown.
        public byte eye_partsId
        {
            get => (byte)row["eye_partsId"].Value;
            set => row["eye_partsId"].Value = value;
        }

        // Unknown.
        public byte eyeR_irisColor_R
        {
            get => (byte)row["eyeR_irisColor_R"].Value;
            set => row["eyeR_irisColor_R"].Value = value;
        }

        // Unknown.
        public byte eyeR_irisColor_G
        {
            get => (byte)row["eyeR_irisColor_G"].Value;
            set => row["eyeR_irisColor_G"].Value = value;
        }

        // Unknown.
        public byte eyeR_irisColor_B
        {
            get => (byte)row["eyeR_irisColor_B"].Value;
            set => row["eyeR_irisColor_B"].Value = value;
        }

        // Unknown.
        public byte eyeR_irisScale
        {
            get => (byte)row["eyeR_irisScale"].Value;
            set => row["eyeR_irisScale"].Value = value;
        }

        // Unknown.
        public byte eyeR_cataract
        {
            get => (byte)row["eyeR_cataract"].Value;
            set => row["eyeR_cataract"].Value = value;
        }

        // Unknown.
        public byte eyeR_cataractColor_R
        {
            get => (byte)row["eyeR_cataractColor_R"].Value;
            set => row["eyeR_cataractColor_R"].Value = value;
        }

        // Unknown.
        public byte eyeR_cataractColor_G
        {
            get => (byte)row["eyeR_cataractColor_G"].Value;
            set => row["eyeR_cataractColor_G"].Value = value;
        }

        // Unknown.
        public byte eyeR_cataractColor_B
        {
            get => (byte)row["eyeR_cataractColor_B"].Value;
            set => row["eyeR_cataractColor_B"].Value = value;
        }

        // Unknown.
        public byte eyeR_scleraColor_R
        {
            get => (byte)row["eyeR_scleraColor_R"].Value;
            set => row["eyeR_scleraColor_R"].Value = value;
        }

        // Unknown.
        public byte eyeR_scleraColor_G
        {
            get => (byte)row["eyeR_scleraColor_G"].Value;
            set => row["eyeR_scleraColor_G"].Value = value;
        }

        // Unknown.
        public byte eyeR_scleraColor_B
        {
            get => (byte)row["eyeR_scleraColor_B"].Value;
            set => row["eyeR_scleraColor_B"].Value = value;
        }

        // Unknown.
        public byte eyeR_irisDistance
        {
            get => (byte)row["eyeR_irisDistance"].Value;
            set => row["eyeR_irisDistance"].Value = value;
        }

        // Unknown.
        public byte eyeL_irisColor_R
        {
            get => (byte)row["eyeL_irisColor_R"].Value;
            set => row["eyeL_irisColor_R"].Value = value;
        }

        // Unknown.
        public byte eyeL_irisColor_G
        {
            get => (byte)row["eyeL_irisColor_G"].Value;
            set => row["eyeL_irisColor_G"].Value = value;
        }

        // Unknown.
        public byte eyeL_irisColor_B
        {
            get => (byte)row["eyeL_irisColor_B"].Value;
            set => row["eyeL_irisColor_B"].Value = value;
        }

        // Unknown.
        public byte eyeL_irisScale
        {
            get => (byte)row["eyeL_irisScale"].Value;
            set => row["eyeL_irisScale"].Value = value;
        }

        // Unknown.
        public byte eyeL_cataract
        {
            get => (byte)row["eyeL_cataract"].Value;
            set => row["eyeL_cataract"].Value = value;
        }

        // Unknown.
        public byte eyeL_cataractColor_R
        {
            get => (byte)row["eyeL_cataractColor_R"].Value;
            set => row["eyeL_cataractColor_R"].Value = value;
        }

        // Unknown.
        public byte eyeL_cataractColor_G
        {
            get => (byte)row["eyeL_cataractColor_G"].Value;
            set => row["eyeL_cataractColor_G"].Value = value;
        }

        // Unknown.
        public byte eyeL_cataractColor_B
        {
            get => (byte)row["eyeL_cataractColor_B"].Value;
            set => row["eyeL_cataractColor_B"].Value = value;
        }

        // Unknown.
        public byte eyeL_scleraColor_R
        {
            get => (byte)row["eyeL_scleraColor_R"].Value;
            set => row["eyeL_scleraColor_R"].Value = value;
        }

        // Unknown.
        public byte eyeL_scleraColor_G
        {
            get => (byte)row["eyeL_scleraColor_G"].Value;
            set => row["eyeL_scleraColor_G"].Value = value;
        }

        // Unknown.
        public byte eyeL_scleraColor_B
        {
            get => (byte)row["eyeL_scleraColor_B"].Value;
            set => row["eyeL_scleraColor_B"].Value = value;
        }

        // Unknown.
        public byte eyeL_irisDistance
        {
            get => (byte)row["eyeL_irisDistance"].Value;
            set => row["eyeL_irisDistance"].Value = value;
        }

        // Unknown.
        public byte hair_partsId
        {
            get => (byte)row["hair_partsId"].Value;
            set => row["hair_partsId"].Value = value;
        }

        // Unknown.
        public byte hair_color_R
        {
            get => (byte)row["hair_color_R"].Value;
            set => row["hair_color_R"].Value = value;
        }

        // Unknown.
        public byte hair_color_G
        {
            get => (byte)row["hair_color_G"].Value;
            set => row["hair_color_G"].Value = value;
        }

        // Unknown.
        public byte hair_color_B
        {
            get => (byte)row["hair_color_B"].Value;
            set => row["hair_color_B"].Value = value;
        }

        // Unknown.
        public byte hair_shininess
        {
            get => (byte)row["hair_shininess"].Value;
            set => row["hair_shininess"].Value = value;
        }

        // Unknown.
        public byte hair_rootBlack
        {
            get => (byte)row["hair_rootBlack"].Value;
            set => row["hair_rootBlack"].Value = value;
        }

        // Unknown.
        public byte hair_whiteDensity
        {
            get => (byte)row["hair_whiteDensity"].Value;
            set => row["hair_whiteDensity"].Value = value;
        }

        // Unknown.
        public byte beard_partsId
        {
            get => (byte)row["beard_partsId"].Value;
            set => row["beard_partsId"].Value = value;
        }

        // Unknown.
        public byte beard_color_R
        {
            get => (byte)row["beard_color_R"].Value;
            set => row["beard_color_R"].Value = value;
        }

        // Unknown.
        public byte beard_color_G
        {
            get => (byte)row["beard_color_G"].Value;
            set => row["beard_color_G"].Value = value;
        }

        // Unknown.
        public byte beard_color_B
        {
            get => (byte)row["beard_color_B"].Value;
            set => row["beard_color_B"].Value = value;
        }

        // Unknown.
        public byte beard_shininess
        {
            get => (byte)row["beard_shininess"].Value;
            set => row["beard_shininess"].Value = value;
        }

        // Unknown.
        public byte beard_rootBlack
        {
            get => (byte)row["beard_rootBlack"].Value;
            set => row["beard_rootBlack"].Value = value;
        }

        // Unknown.
        public byte beard_whiteDensity
        {
            get => (byte)row["beard_whiteDensity"].Value;
            set => row["beard_whiteDensity"].Value = value;
        }

        // Unknown.
        public byte eyebrow_partsId
        {
            get => (byte)row["eyebrow_partsId"].Value;
            set => row["eyebrow_partsId"].Value = value;
        }

        // Unknown.
        public byte eyebrow_color_R
        {
            get => (byte)row["eyebrow_color_R"].Value;
            set => row["eyebrow_color_R"].Value = value;
        }

        // Unknown.
        public byte eyebrow_color_G
        {
            get => (byte)row["eyebrow_color_G"].Value;
            set => row["eyebrow_color_G"].Value = value;
        }

        // Unknown.
        public byte eyebrow_color_B
        {
            get => (byte)row["eyebrow_color_B"].Value;
            set => row["eyebrow_color_B"].Value = value;
        }

        // Unknown.
        public byte eyebrow_shininess
        {
            get => (byte)row["eyebrow_shininess"].Value;
            set => row["eyebrow_shininess"].Value = value;
        }

        // Unknown.
        public byte eyebrow_rootBlack
        {
            get => (byte)row["eyebrow_rootBlack"].Value;
            set => row["eyebrow_rootBlack"].Value = value;
        }

        // Unknown.
        public byte eyebrow_whiteDensity
        {
            get => (byte)row["eyebrow_whiteDensity"].Value;
            set => row["eyebrow_whiteDensity"].Value = value;
        }

        // Unknown.
        public byte eyelash_partsId
        {
            get => (byte)row["eyelash_partsId"].Value;
            set => row["eyelash_partsId"].Value = value;
        }

        // Unknown.
        public byte eyelash_color_R
        {
            get => (byte)row["eyelash_color_R"].Value;
            set => row["eyelash_color_R"].Value = value;
        }

        // Unknown.
        public byte eyelash_color_G
        {
            get => (byte)row["eyelash_color_G"].Value;
            set => row["eyelash_color_G"].Value = value;
        }

        // Unknown.
        public byte eyelash_color_B
        {
            get => (byte)row["eyelash_color_B"].Value;
            set => row["eyelash_color_B"].Value = value;
        }

        // Unknown.
        public byte accessories_partsId
        {
            get => (byte)row["accessories_partsId"].Value;
            set => row["accessories_partsId"].Value = value;
        }

        // Unknown.
        public byte accessories_color_R
        {
            get => (byte)row["accessories_color_R"].Value;
            set => row["accessories_color_R"].Value = value;
        }

        // Unknown.
        public byte accessories_color_G
        {
            get => (byte)row["accessories_color_G"].Value;
            set => row["accessories_color_G"].Value = value;
        }

        // Unknown.
        public byte accessories_color_B
        {
            get => (byte)row["accessories_color_B"].Value;
            set => row["accessories_color_B"].Value = value;
        }

        // Unknown.
        public byte decal_partsId
        {
            get => (byte)row["decal_partsId"].Value;
            set => row["decal_partsId"].Value = value;
        }

        // Unknown.
        public byte decal_posX
        {
            get => (byte)row["decal_posX"].Value;
            set => row["decal_posX"].Value = value;
        }

        // Unknown.
        public byte decal_posY
        {
            get => (byte)row["decal_posY"].Value;
            set => row["decal_posY"].Value = value;
        }

        // Unknown.
        public byte decal_angle
        {
            get => (byte)row["decal_angle"].Value;
            set => row["decal_angle"].Value = value;
        }

        // Unknown.
        public byte decal_scale
        {
            get => (byte)row["decal_scale"].Value;
            set => row["decal_scale"].Value = value;
        }

        // Unknown.
        public byte decal_color_R
        {
            get => (byte)row["decal_color_R"].Value;
            set => row["decal_color_R"].Value = value;
        }

        // Unknown.
        public byte decal_color_G
        {
            get => (byte)row["decal_color_G"].Value;
            set => row["decal_color_G"].Value = value;
        }

        // Unknown.
        public byte decal_color_B
        {
            get => (byte)row["decal_color_B"].Value;
            set => row["decal_color_B"].Value = value;
        }

        // Unknown.
        public byte decal_gloss
        {
            get => (byte)row["decal_gloss"].Value;
            set => row["decal_gloss"].Value = value;
        }

        // Unknown.
        public byte decal_mirror
        {
            get => (byte)row["decal_mirror"].Value;
            set => row["decal_mirror"].Value = value;
        }

        // Unknown.
        public byte chrBodyScaleHead
        {
            get => (byte)row["chrBodyScaleHead"].Value;
            set => row["chrBodyScaleHead"].Value = value;
        }

        // Unknown.
        public byte chrBodyScaleBreast
        {
            get => (byte)row["chrBodyScaleBreast"].Value;
            set => row["chrBodyScaleBreast"].Value = value;
        }

        // Unknown.
        public byte chrBodyScaleAbdomen
        {
            get => (byte)row["chrBodyScaleAbdomen"].Value;
            set => row["chrBodyScaleAbdomen"].Value = value;
        }

        // Unknown.
        public byte chrBodyScaleRArm
        {
            get => (byte)row["chrBodyScaleRArm"].Value;
            set => row["chrBodyScaleRArm"].Value = value;
        }

        // Unknown.
        public byte chrBodyScaleRLeg
        {
            get => (byte)row["chrBodyScaleRLeg"].Value;
            set => row["chrBodyScaleRLeg"].Value = value;
        }

        // Unknown.
        public byte chrBodyScaleLArm
        {
            get => (byte)row["chrBodyScaleLArm"].Value;
            set => row["chrBodyScaleLArm"].Value = value;
        }

        // Unknown.
        public byte chrBodyScaleLLeg
        {
            get => (byte)row["chrBodyScaleLLeg"].Value;
            set => row["chrBodyScaleLLeg"].Value = value;
        }

        // Unknown.
        public byte burn_scar
        {
            get => (byte)row["burn_scar"].Value;
            set => row["burn_scar"].Value = value;
        }

        // Unknown.
        public byte override_eye_partsId
        {
            get => (byte)row["override_eye_partsId"].Value;
            set => row["override_eye_partsId"].Value = value;
        }

        // Unknown.
        public byte override_eye_irisColor
        {
            get => (byte)row["override_eye_irisColor"].Value;
            set => row["override_eye_irisColor"].Value = value;
        }

        // Unknown.
        public byte override_eye_cataract
        {
            get => (byte)row["override_eye_cataract"].Value;
            set => row["override_eye_cataract"].Value = value;
        }

        // Unknown.
        public byte override_eye_cataractColor
        {
            get => (byte)row["override_eye_cataractColor"].Value;
            set => row["override_eye_cataractColor"].Value = value;
        }

        // Unknown.
        public byte override_eye_scleraColor
        {
            get => (byte)row["override_eye_scleraColor"].Value;
            set => row["override_eye_scleraColor"].Value = value;
        }

        // Unknown.
        public byte override_burn_scar
        {
            get => (byte)row["override_burn_scar"].Value;
            set => row["override_burn_scar"].Value = value;
        }

        // Unknown.
        public byte age
        {
            get => (byte)row["age"].Value;
            set => row["age"].Value = value;
        }

        // Unknown.
        public byte gender
        {
            get => (byte)row["gender"].Value;
            set => row["gender"].Value = value;
        }

        // Unknown.
        public byte caricatureGeometry
        {
            get => (byte)row["caricatureGeometry"].Value;
            set => row["caricatureGeometry"].Value = value;
        }

        // Unknown.
        public byte caricatureTexture
        {
            get => (byte)row["caricatureTexture"].Value;
            set => row["caricatureTexture"].Value = value;
        }

        // Unknown.
        public byte faceGeoData00
        {
            get => (byte)row["faceGeoData00"].Value;
            set => row["faceGeoData00"].Value = value;
        }

        // Unknown.
        public byte faceGeoData01
        {
            get => (byte)row["faceGeoData01"].Value;
            set => row["faceGeoData01"].Value = value;
        }

        // Unknown.
        public byte faceGeoData02
        {
            get => (byte)row["faceGeoData02"].Value;
            set => row["faceGeoData02"].Value = value;
        }

        // Unknown.
        public byte faceGeoData03
        {
            get => (byte)row["faceGeoData03"].Value;
            set => row["faceGeoData03"].Value = value;
        }

        // Unknown.
        public byte faceGeoData04
        {
            get => (byte)row["faceGeoData04"].Value;
            set => row["faceGeoData04"].Value = value;
        }

        // Unknown.
        public byte faceGeoData05
        {
            get => (byte)row["faceGeoData05"].Value;
            set => row["faceGeoData05"].Value = value;
        }

        // Unknown.
        public byte faceGeoData06
        {
            get => (byte)row["faceGeoData06"].Value;
            set => row["faceGeoData06"].Value = value;
        }

        // Unknown.
        public byte faceGeoData07
        {
            get => (byte)row["faceGeoData07"].Value;
            set => row["faceGeoData07"].Value = value;
        }

        // Unknown.
        public byte faceGeoData08
        {
            get => (byte)row["faceGeoData08"].Value;
            set => row["faceGeoData08"].Value = value;
        }

        // Unknown.
        public byte faceGeoData09
        {
            get => (byte)row["faceGeoData09"].Value;
            set => row["faceGeoData09"].Value = value;
        }

        // Unknown.
        public byte faceGeoData10
        {
            get => (byte)row["faceGeoData10"].Value;
            set => row["faceGeoData10"].Value = value;
        }

        // Unknown.
        public byte faceGeoData11
        {
            get => (byte)row["faceGeoData11"].Value;
            set => row["faceGeoData11"].Value = value;
        }

        // Unknown.
        public byte faceGeoData12
        {
            get => (byte)row["faceGeoData12"].Value;
            set => row["faceGeoData12"].Value = value;
        }

        // Unknown.
        public byte faceGeoData13
        {
            get => (byte)row["faceGeoData13"].Value;
            set => row["faceGeoData13"].Value = value;
        }

        // Unknown.
        public byte faceGeoData14
        {
            get => (byte)row["faceGeoData14"].Value;
            set => row["faceGeoData14"].Value = value;
        }

        // Unknown.
        public byte faceGeoData15
        {
            get => (byte)row["faceGeoData15"].Value;
            set => row["faceGeoData15"].Value = value;
        }

        // Unknown.
        public byte faceGeoData16
        {
            get => (byte)row["faceGeoData16"].Value;
            set => row["faceGeoData16"].Value = value;
        }

        // Unknown.
        public byte faceGeoData17
        {
            get => (byte)row["faceGeoData17"].Value;
            set => row["faceGeoData17"].Value = value;
        }

        // Unknown.
        public byte faceGeoData18
        {
            get => (byte)row["faceGeoData18"].Value;
            set => row["faceGeoData18"].Value = value;
        }

        // Unknown.
        public byte faceGeoData19
        {
            get => (byte)row["faceGeoData19"].Value;
            set => row["faceGeoData19"].Value = value;
        }

        // Unknown.
        public byte faceGeoData20
        {
            get => (byte)row["faceGeoData20"].Value;
            set => row["faceGeoData20"].Value = value;
        }

        // Unknown.
        public byte faceGeoData21
        {
            get => (byte)row["faceGeoData21"].Value;
            set => row["faceGeoData21"].Value = value;
        }

        // Unknown.
        public byte faceGeoData22
        {
            get => (byte)row["faceGeoData22"].Value;
            set => row["faceGeoData22"].Value = value;
        }

        // Unknown.
        public byte faceGeoData23
        {
            get => (byte)row["faceGeoData23"].Value;
            set => row["faceGeoData23"].Value = value;
        }

        // Unknown.
        public byte faceGeoData24
        {
            get => (byte)row["faceGeoData24"].Value;
            set => row["faceGeoData24"].Value = value;
        }

        // Unknown.
        public byte faceGeoData25
        {
            get => (byte)row["faceGeoData25"].Value;
            set => row["faceGeoData25"].Value = value;
        }

        // Unknown.
        public byte faceGeoData26
        {
            get => (byte)row["faceGeoData26"].Value;
            set => row["faceGeoData26"].Value = value;
        }

        // Unknown.
        public byte faceGeoData27
        {
            get => (byte)row["faceGeoData27"].Value;
            set => row["faceGeoData27"].Value = value;
        }

        // Unknown.
        public byte faceGeoData28
        {
            get => (byte)row["faceGeoData28"].Value;
            set => row["faceGeoData28"].Value = value;
        }

        // Unknown.
        public byte faceGeoData29
        {
            get => (byte)row["faceGeoData29"].Value;
            set => row["faceGeoData29"].Value = value;
        }

        // Unknown.
        public byte faceGeoData30
        {
            get => (byte)row["faceGeoData30"].Value;
            set => row["faceGeoData30"].Value = value;
        }

        // Unknown.
        public byte faceGeoData31
        {
            get => (byte)row["faceGeoData31"].Value;
            set => row["faceGeoData31"].Value = value;
        }

        // Unknown.
        public byte faceGeoData32
        {
            get => (byte)row["faceGeoData32"].Value;
            set => row["faceGeoData32"].Value = value;
        }

        // Unknown.
        public byte faceGeoData33
        {
            get => (byte)row["faceGeoData33"].Value;
            set => row["faceGeoData33"].Value = value;
        }

        // Unknown.
        public byte faceGeoData34
        {
            get => (byte)row["faceGeoData34"].Value;
            set => row["faceGeoData34"].Value = value;
        }

        // Unknown.
        public byte faceGeoData35
        {
            get => (byte)row["faceGeoData35"].Value;
            set => row["faceGeoData35"].Value = value;
        }

        // Unknown.
        public byte faceGeoData36
        {
            get => (byte)row["faceGeoData36"].Value;
            set => row["faceGeoData36"].Value = value;
        }

        // Unknown.
        public byte faceGeoData37
        {
            get => (byte)row["faceGeoData37"].Value;
            set => row["faceGeoData37"].Value = value;
        }

        // Unknown.
        public byte faceGeoData38
        {
            get => (byte)row["faceGeoData38"].Value;
            set => row["faceGeoData38"].Value = value;
        }

        // Unknown.
        public byte faceGeoData39
        {
            get => (byte)row["faceGeoData39"].Value;
            set => row["faceGeoData39"].Value = value;
        }

        // Unknown.
        public byte faceGeoData40
        {
            get => (byte)row["faceGeoData40"].Value;
            set => row["faceGeoData40"].Value = value;
        }

        // Unknown.
        public byte faceGeoData41
        {
            get => (byte)row["faceGeoData41"].Value;
            set => row["faceGeoData41"].Value = value;
        }

        // Unknown.
        public byte faceGeoData42
        {
            get => (byte)row["faceGeoData42"].Value;
            set => row["faceGeoData42"].Value = value;
        }

        // Unknown.
        public byte faceGeoData43
        {
            get => (byte)row["faceGeoData43"].Value;
            set => row["faceGeoData43"].Value = value;
        }

        // Unknown.
        public byte faceGeoData44
        {
            get => (byte)row["faceGeoData44"].Value;
            set => row["faceGeoData44"].Value = value;
        }

        // Unknown.
        public byte faceGeoData45
        {
            get => (byte)row["faceGeoData45"].Value;
            set => row["faceGeoData45"].Value = value;
        }

        // Unknown.
        public byte faceGeoData46
        {
            get => (byte)row["faceGeoData46"].Value;
            set => row["faceGeoData46"].Value = value;
        }

        // Unknown.
        public byte faceGeoData47
        {
            get => (byte)row["faceGeoData47"].Value;
            set => row["faceGeoData47"].Value = value;
        }

        // Unknown.
        public byte faceGeoData48
        {
            get => (byte)row["faceGeoData48"].Value;
            set => row["faceGeoData48"].Value = value;
        }

        // Unknown.
        public byte faceGeoData49
        {
            get => (byte)row["faceGeoData49"].Value;
            set => row["faceGeoData49"].Value = value;
        }

        // Unknown.
        public byte faceGeoData50
        {
            get => (byte)row["faceGeoData50"].Value;
            set => row["faceGeoData50"].Value = value;
        }

        // Unknown.
        public byte faceGeoData51
        {
            get => (byte)row["faceGeoData51"].Value;
            set => row["faceGeoData51"].Value = value;
        }

        // Unknown.
        public byte faceGeoData52
        {
            get => (byte)row["faceGeoData52"].Value;
            set => row["faceGeoData52"].Value = value;
        }

        // Unknown.
        public byte faceGeoData53
        {
            get => (byte)row["faceGeoData53"].Value;
            set => row["faceGeoData53"].Value = value;
        }

        // Unknown.
        public byte faceGeoData54
        {
            get => (byte)row["faceGeoData54"].Value;
            set => row["faceGeoData54"].Value = value;
        }

        // Unknown.
        public byte faceGeoData55
        {
            get => (byte)row["faceGeoData55"].Value;
            set => row["faceGeoData55"].Value = value;
        }

        // Unknown.
        public byte faceGeoData56
        {
            get => (byte)row["faceGeoData56"].Value;
            set => row["faceGeoData56"].Value = value;
        }

        // Unknown.
        public byte faceGeoData57
        {
            get => (byte)row["faceGeoData57"].Value;
            set => row["faceGeoData57"].Value = value;
        }

        // Unknown.
        public byte faceGeoData58
        {
            get => (byte)row["faceGeoData58"].Value;
            set => row["faceGeoData58"].Value = value;
        }

        // Unknown.
        public byte faceGeoData59
        {
            get => (byte)row["faceGeoData59"].Value;
            set => row["faceGeoData59"].Value = value;
        }

        // Unknown.
        public byte faceGeoData60
        {
            get => (byte)row["faceGeoData60"].Value;
            set => row["faceGeoData60"].Value = value;
        }

        // Unknown.
        public byte faceTexData00
        {
            get => (byte)row["faceTexData00"].Value;
            set => row["faceTexData00"].Value = value;
        }

        // Unknown.
        public byte faceTexData01
        {
            get => (byte)row["faceTexData01"].Value;
            set => row["faceTexData01"].Value = value;
        }

        // Unknown.
        public byte faceTexData02
        {
            get => (byte)row["faceTexData02"].Value;
            set => row["faceTexData02"].Value = value;
        }

        // Unknown.
        public byte faceTexData03
        {
            get => (byte)row["faceTexData03"].Value;
            set => row["faceTexData03"].Value = value;
        }

        // Unknown.
        public byte faceTexData04
        {
            get => (byte)row["faceTexData04"].Value;
            set => row["faceTexData04"].Value = value;
        }

        // Unknown.
        public byte faceTexData05
        {
            get => (byte)row["faceTexData05"].Value;
            set => row["faceTexData05"].Value = value;
        }

        // Unknown.
        public byte faceTexData06
        {
            get => (byte)row["faceTexData06"].Value;
            set => row["faceTexData06"].Value = value;
        }

        // Unknown.
        public byte faceTexData07
        {
            get => (byte)row["faceTexData07"].Value;
            set => row["faceTexData07"].Value = value;
        }

        // Unknown.
        public byte faceTexData08
        {
            get => (byte)row["faceTexData08"].Value;
            set => row["faceTexData08"].Value = value;
        }

        // Unknown.
        public byte faceTexData09
        {
            get => (byte)row["faceTexData09"].Value;
            set => row["faceTexData09"].Value = value;
        }

        // Unknown.
        public byte faceTexData10
        {
            get => (byte)row["faceTexData10"].Value;
            set => row["faceTexData10"].Value = value;
        }

        // Unknown.
        public byte faceTexData11
        {
            get => (byte)row["faceTexData11"].Value;
            set => row["faceTexData11"].Value = value;
        }

        // Unknown.
        public byte faceTexData12
        {
            get => (byte)row["faceTexData12"].Value;
            set => row["faceTexData12"].Value = value;
        }

        // Unknown.
        public byte faceTexData13
        {
            get => (byte)row["faceTexData13"].Value;
            set => row["faceTexData13"].Value = value;
        }

        // Unknown.
        public byte faceTexData14
        {
            get => (byte)row["faceTexData14"].Value;
            set => row["faceTexData14"].Value = value;
        }

        // Unknown.
        public byte faceTexData15
        {
            get => (byte)row["faceTexData15"].Value;
            set => row["faceTexData15"].Value = value;
        }

        // Unknown.
        public byte faceTexData16
        {
            get => (byte)row["faceTexData16"].Value;
            set => row["faceTexData16"].Value = value;
        }

        // Unknown.
        public byte faceTexData17
        {
            get => (byte)row["faceTexData17"].Value;
            set => row["faceTexData17"].Value = value;
        }

        // Unknown.
        public byte faceTexData18
        {
            get => (byte)row["faceTexData18"].Value;
            set => row["faceTexData18"].Value = value;
        }

        // Unknown.
        public byte faceTexData19
        {
            get => (byte)row["faceTexData19"].Value;
            set => row["faceTexData19"].Value = value;
        }

        // Unknown.
        public byte faceTexData20
        {
            get => (byte)row["faceTexData20"].Value;
            set => row["faceTexData20"].Value = value;
        }

        // Unknown.
        public byte faceTexData21
        {
            get => (byte)row["faceTexData21"].Value;
            set => row["faceTexData21"].Value = value;
        }

        // Unknown.
        public byte faceTexData22
        {
            get => (byte)row["faceTexData22"].Value;
            set => row["faceTexData22"].Value = value;
        }

        // Unknown.
        public byte faceTexData23
        {
            get => (byte)row["faceTexData23"].Value;
            set => row["faceTexData23"].Value = value;
        }

        // Unknown.
        public byte faceTexData24
        {
            get => (byte)row["faceTexData24"].Value;
            set => row["faceTexData24"].Value = value;
        }

        // Unknown.
        public byte faceTexData25
        {
            get => (byte)row["faceTexData25"].Value;
            set => row["faceTexData25"].Value = value;
        }

        // Unknown.
        public byte faceTexData26
        {
            get => (byte)row["faceTexData26"].Value;
            set => row["faceTexData26"].Value = value;
        }

        // Unknown.
        public byte faceTexData27
        {
            get => (byte)row["faceTexData27"].Value;
            set => row["faceTexData27"].Value = value;
        }

        // Unknown.
        public byte faceTexData28
        {
            get => (byte)row["faceTexData28"].Value;
            set => row["faceTexData28"].Value = value;
        }

        // Unknown.
        public byte faceTexData29
        {
            get => (byte)row["faceTexData29"].Value;
            set => row["faceTexData29"].Value = value;
        }

        // Unknown.
        public byte faceTexData30
        {
            get => (byte)row["faceTexData30"].Value;
            set => row["faceTexData30"].Value = value;
        }

        // Unknown.
        public byte faceTexData31
        {
            get => (byte)row["faceTexData31"].Value;
            set => row["faceTexData31"].Value = value;
        }

        // Unknown.
        public byte faceTexData32
        {
            get => (byte)row["faceTexData32"].Value;
            set => row["faceTexData32"].Value = value;
        }

        // Unknown.
        public byte faceTexData33
        {
            get => (byte)row["faceTexData33"].Value;
            set => row["faceTexData33"].Value = value;
        }

        // Unknown.
        public byte faceTexData34
        {
            get => (byte)row["faceTexData34"].Value;
            set => row["faceTexData34"].Value = value;
        }

        // Unknown.
        public byte faceTexData35
        {
            get => (byte)row["faceTexData35"].Value;
            set => row["faceTexData35"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData00
        {
            get => (byte)row["faceGeoAsymData00"].Value;
            set => row["faceGeoAsymData00"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData01
        {
            get => (byte)row["faceGeoAsymData01"].Value;
            set => row["faceGeoAsymData01"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData02
        {
            get => (byte)row["faceGeoAsymData02"].Value;
            set => row["faceGeoAsymData02"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData03
        {
            get => (byte)row["faceGeoAsymData03"].Value;
            set => row["faceGeoAsymData03"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData04
        {
            get => (byte)row["faceGeoAsymData04"].Value;
            set => row["faceGeoAsymData04"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData05
        {
            get => (byte)row["faceGeoAsymData05"].Value;
            set => row["faceGeoAsymData05"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData06
        {
            get => (byte)row["faceGeoAsymData06"].Value;
            set => row["faceGeoAsymData06"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData07
        {
            get => (byte)row["faceGeoAsymData07"].Value;
            set => row["faceGeoAsymData07"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData08
        {
            get => (byte)row["faceGeoAsymData08"].Value;
            set => row["faceGeoAsymData08"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData09
        {
            get => (byte)row["faceGeoAsymData09"].Value;
            set => row["faceGeoAsymData09"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData10
        {
            get => (byte)row["faceGeoAsymData10"].Value;
            set => row["faceGeoAsymData10"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData11
        {
            get => (byte)row["faceGeoAsymData11"].Value;
            set => row["faceGeoAsymData11"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData12
        {
            get => (byte)row["faceGeoAsymData12"].Value;
            set => row["faceGeoAsymData12"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData13
        {
            get => (byte)row["faceGeoAsymData13"].Value;
            set => row["faceGeoAsymData13"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData14
        {
            get => (byte)row["faceGeoAsymData14"].Value;
            set => row["faceGeoAsymData14"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData15
        {
            get => (byte)row["faceGeoAsymData15"].Value;
            set => row["faceGeoAsymData15"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData16
        {
            get => (byte)row["faceGeoAsymData16"].Value;
            set => row["faceGeoAsymData16"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData17
        {
            get => (byte)row["faceGeoAsymData17"].Value;
            set => row["faceGeoAsymData17"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData18
        {
            get => (byte)row["faceGeoAsymData18"].Value;
            set => row["faceGeoAsymData18"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData19
        {
            get => (byte)row["faceGeoAsymData19"].Value;
            set => row["faceGeoAsymData19"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData20
        {
            get => (byte)row["faceGeoAsymData20"].Value;
            set => row["faceGeoAsymData20"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData21
        {
            get => (byte)row["faceGeoAsymData21"].Value;
            set => row["faceGeoAsymData21"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData22
        {
            get => (byte)row["faceGeoAsymData22"].Value;
            set => row["faceGeoAsymData22"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData23
        {
            get => (byte)row["faceGeoAsymData23"].Value;
            set => row["faceGeoAsymData23"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData24
        {
            get => (byte)row["faceGeoAsymData24"].Value;
            set => row["faceGeoAsymData24"].Value = value;
        }

        // Unknown.
        public byte faceGeoAsymData25
        {
            get => (byte)row["faceGeoAsymData25"].Value;
            set => row["faceGeoAsymData25"].Value = value;
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
    public FACE_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public FACE_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
