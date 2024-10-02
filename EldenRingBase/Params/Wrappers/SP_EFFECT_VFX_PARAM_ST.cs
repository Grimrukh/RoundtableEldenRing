using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class SP_EFFECT_VFX_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int midstSfxId
        {
            get => (int)row["midstSfxId"].Value;
            set => row["midstSfxId"].Value = value;
        }

        // Unknown.
        public int midstSeId
        {
            get => (int)row["midstSeId"].Value;
            set => row["midstSeId"].Value = value;
        }

        // Unknown.
        public int initSfxId
        {
            get => (int)row["initSfxId"].Value;
            set => row["initSfxId"].Value = value;
        }

        // Unknown.
        public int initSeId
        {
            get => (int)row["initSeId"].Value;
            set => row["initSeId"].Value = value;
        }

        // Unknown.
        public int finishSfxId
        {
            get => (int)row["finishSfxId"].Value;
            set => row["finishSfxId"].Value = value;
        }

        // Unknown.
        public int finishSeId
        {
            get => (int)row["finishSeId"].Value;
            set => row["finishSeId"].Value = value;
        }

        // Unknown.
        public float camouflageBeginDist
        {
            get => (float)row["camouflageBeginDist"].Value;
            set => row["camouflageBeginDist"].Value = value;
        }

        // Unknown.
        public float camouflageEndDist
        {
            get => (float)row["camouflageEndDist"].Value;
            set => row["camouflageEndDist"].Value = value;
        }

        // Unknown.
        public int transformProtectorId
        {
            get => (int)row["transformProtectorId"].Value;
            set => row["transformProtectorId"].Value = value;
        }

        // Unknown.
        public short midstDmyId
        {
            get => (short)row["midstDmyId"].Value;
            set => row["midstDmyId"].Value = value;
        }

        // Unknown.
        public short initDmyId
        {
            get => (short)row["initDmyId"].Value;
            set => row["initDmyId"].Value = value;
        }

        // Unknown.
        public short finishDmyId
        {
            get => (short)row["finishDmyId"].Value;
            set => row["finishDmyId"].Value = value;
        }

        // Unknown.
        public byte effectType
        {
            get => (byte)row["effectType"].Value;
            set => row["effectType"].Value = value;
        }

        // Unknown.
        public byte soulParamIdForWepEnchant
        {
            get => (byte)row["soulParamIdForWepEnchant"].Value;
            set => row["soulParamIdForWepEnchant"].Value = value;
        }

        // Unknown.
        public byte playCategory
        {
            get => (byte)row["playCategory"].Value;
            set => row["playCategory"].Value = value;
        }

        // Unknown.
        public byte playPriority
        {
            get => (byte)row["playPriority"].Value;
            set => row["playPriority"].Value = value;
        }

        // Unknown.
        public byte existEffectForLarge
        {
            get => (byte)row["existEffectForLarge"].Value;
            set => row["existEffectForLarge"].Value = value;
        }

        // Unknown.
        public byte existEffectForSoul
        {
            get => (byte)row["existEffectForSoul"].Value;
            set => row["existEffectForSoul"].Value = value;
        }

        // Unknown.
        public byte effectInvisibleAtCamouflage
        {
            get => (byte)row["effectInvisibleAtCamouflage"].Value;
            set => row["effectInvisibleAtCamouflage"].Value = value;
        }

        // Unknown.
        public byte useCamouflage
        {
            get => (byte)row["useCamouflage"].Value;
            set => row["useCamouflage"].Value = value;
        }

        // Unknown.
        public byte invisibleAtFriendCamouflage
        {
            get => (byte)row["invisibleAtFriendCamouflage"].Value;
            set => row["invisibleAtFriendCamouflage"].Value = value;
        }

        // Unknown.
        public byte isHideFootEffect_forCamouflage
        {
            get => (byte)row["isHideFootEffect_forCamouflage"].Value;
            set => row["isHideFootEffect_forCamouflage"].Value = value;
        }

        // Unknown.
        public byte halfCamouflage
        {
            get => (byte)row["halfCamouflage"].Value;
            set => row["halfCamouflage"].Value = value;
        }

        // Unknown.
        public byte isFullBodyTransformProtectorId
        {
            get => (byte)row["isFullBodyTransformProtectorId"].Value;
            set => row["isFullBodyTransformProtectorId"].Value = value;
        }

        // Unknown.
        public byte isInvisibleWeapon
        {
            get => (byte)row["isInvisibleWeapon"].Value;
            set => row["isInvisibleWeapon"].Value = value;
        }

        // Unknown.
        public byte isSilence
        {
            get => (byte)row["isSilence"].Value;
            set => row["isSilence"].Value = value;
        }

        // Unknown.
        public byte isMidstFullbody
        {
            get => (byte)row["isMidstFullbody"].Value;
            set => row["isMidstFullbody"].Value = value;
        }

        // Unknown.
        public byte isInitFullbody
        {
            get => (byte)row["isInitFullbody"].Value;
            set => row["isInitFullbody"].Value = value;
        }

        // Unknown.
        public byte isFinishFullbody
        {
            get => (byte)row["isFinishFullbody"].Value;
            set => row["isFinishFullbody"].Value = value;
        }

        // Unknown.
        public byte isVisibleDeadChr
        {
            get => (byte)row["isVisibleDeadChr"].Value;
            set => row["isVisibleDeadChr"].Value = value;
        }

        // Unknown.
        public byte isUseOffsetEnchantSfxSize
        {
            get => (byte)row["isUseOffsetEnchantSfxSize"].Value;
            set => row["isUseOffsetEnchantSfxSize"].Value = value;
        }

        // Unknown.
        public int decalId1
        {
            get => (int)row["decalId1"].Value;
            set => row["decalId1"].Value = value;
        }

        // Unknown.
        public int decalId2
        {
            get => (int)row["decalId2"].Value;
            set => row["decalId2"].Value = value;
        }

        // Unknown.
        public byte footEffectPriority
        {
            get => (byte)row["footEffectPriority"].Value;
            set => row["footEffectPriority"].Value = value;
        }

        // Unknown.
        public byte footEffectOffset
        {
            get => (byte)row["footEffectOffset"].Value;
            set => row["footEffectOffset"].Value = value;
        }

        // Unknown.
        public byte traceSfxIdOffsetType
        {
            get => (byte)row["traceSfxIdOffsetType"].Value;
            set => row["traceSfxIdOffsetType"].Value = value;
        }

        // Unknown.
        public byte forceDeceasedType
        {
            get => (byte)row["forceDeceasedType"].Value;
            set => row["forceDeceasedType"].Value = value;
        }

        // Unknown.
        public int enchantStartDmyId_0
        {
            get => (int)row["enchantStartDmyId_0"].Value;
            set => row["enchantStartDmyId_0"].Value = value;
        }

        // Unknown.
        public int enchantEndDmyId_0
        {
            get => (int)row["enchantEndDmyId_0"].Value;
            set => row["enchantEndDmyId_0"].Value = value;
        }

        // Unknown.
        public int enchantStartDmyId_1
        {
            get => (int)row["enchantStartDmyId_1"].Value;
            set => row["enchantStartDmyId_1"].Value = value;
        }

        // Unknown.
        public int enchantEndDmyId_1
        {
            get => (int)row["enchantEndDmyId_1"].Value;
            set => row["enchantEndDmyId_1"].Value = value;
        }

        // Unknown.
        public int enchantStartDmyId_2
        {
            get => (int)row["enchantStartDmyId_2"].Value;
            set => row["enchantStartDmyId_2"].Value = value;
        }

        // Unknown.
        public int enchantEndDmyId_2
        {
            get => (int)row["enchantEndDmyId_2"].Value;
            set => row["enchantEndDmyId_2"].Value = value;
        }

        // Unknown.
        public int enchantStartDmyId_3
        {
            get => (int)row["enchantStartDmyId_3"].Value;
            set => row["enchantStartDmyId_3"].Value = value;
        }

        // Unknown.
        public int enchantEndDmyId_3
        {
            get => (int)row["enchantEndDmyId_3"].Value;
            set => row["enchantEndDmyId_3"].Value = value;
        }

        // Unknown.
        public int enchantStartDmyId_4
        {
            get => (int)row["enchantStartDmyId_4"].Value;
            set => row["enchantStartDmyId_4"].Value = value;
        }

        // Unknown.
        public int enchantEndDmyId_4
        {
            get => (int)row["enchantEndDmyId_4"].Value;
            set => row["enchantEndDmyId_4"].Value = value;
        }

        // Unknown.
        public int enchantStartDmyId_5
        {
            get => (int)row["enchantStartDmyId_5"].Value;
            set => row["enchantStartDmyId_5"].Value = value;
        }

        // Unknown.
        public int enchantEndDmyId_5
        {
            get => (int)row["enchantEndDmyId_5"].Value;
            set => row["enchantEndDmyId_5"].Value = value;
        }

        // Unknown.
        public int enchantStartDmyId_6
        {
            get => (int)row["enchantStartDmyId_6"].Value;
            set => row["enchantStartDmyId_6"].Value = value;
        }

        // Unknown.
        public int enchantEndDmyId_6
        {
            get => (int)row["enchantEndDmyId_6"].Value;
            set => row["enchantEndDmyId_6"].Value = value;
        }

        // Unknown.
        public int enchantStartDmyId_7
        {
            get => (int)row["enchantStartDmyId_7"].Value;
            set => row["enchantStartDmyId_7"].Value = value;
        }

        // Unknown.
        public int enchantEndDmyId_7
        {
            get => (int)row["enchantEndDmyId_7"].Value;
            set => row["enchantEndDmyId_7"].Value = value;
        }

        // Unknown.
        public byte SfxIdOffsetType
        {
            get => (byte)row["SfxIdOffsetType"].Value;
            set => row["SfxIdOffsetType"].Value = value;
        }

        // Unknown.
        public byte phantomParamOverwriteType
        {
            get => (byte)row["phantomParamOverwriteType"].Value;
            set => row["phantomParamOverwriteType"].Value = value;
        }

        // Unknown.
        public byte camouflageMinAlpha
        {
            get => (byte)row["camouflageMinAlpha"].Value;
            set => row["camouflageMinAlpha"].Value = value;
        }

        // Unknown.
        public byte wetAspectType
        {
            get => (byte)row["wetAspectType"].Value;
            set => row["wetAspectType"].Value = value;
        }

        // Unknown.
        public int phantomParamOverwriteId
        {
            get => (int)row["phantomParamOverwriteId"].Value;
            set => row["phantomParamOverwriteId"].Value = value;
        }

        // Unknown.
        public int materialParamId
        {
            get => (int)row["materialParamId"].Value;
            set => row["materialParamId"].Value = value;
        }

        // Unknown.
        public float materialParamInitValue
        {
            get => (float)row["materialParamInitValue"].Value;
            set => row["materialParamInitValue"].Value = value;
        }

        // Unknown.
        public float materialParamTargetValue
        {
            get => (float)row["materialParamTargetValue"].Value;
            set => row["materialParamTargetValue"].Value = value;
        }

        // Unknown.
        public float materialParamFadeTime
        {
            get => (float)row["materialParamFadeTime"].Value;
            set => row["materialParamFadeTime"].Value = value;
        }

        // Unknown.
        public short footDecalMaterialOffsetOverwriteId
        {
            get => (short)row["footDecalMaterialOffsetOverwriteId"].Value;
            set => row["footDecalMaterialOffsetOverwriteId"].Value = value;
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
    public SP_EFFECT_VFX_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public SP_EFFECT_VFX_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
