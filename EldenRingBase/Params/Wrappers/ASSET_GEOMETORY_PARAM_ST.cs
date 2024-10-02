using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class ASSET_GEOMETORY_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int soundBankId
        {
            get => (int)row["soundBankId"].Value;
            set => row["soundBankId"].Value = value;
        }

        // Unknown.
        public int soundBreakSEId
        {
            get => (int)row["soundBreakSEId"].Value;
            set => row["soundBreakSEId"].Value = value;
        }

        // Unknown.
        public int refDrawParamId
        {
            get => (int)row["refDrawParamId"].Value;
            set => row["refDrawParamId"].Value = value;
        }

        // Unknown.
        public sbyte hitCreateType
        {
            get => (sbyte)row["hitCreateType"].Value;
            set => row["hitCreateType"].Value = value;
        }

        // Unknown.
        public byte behaviorType
        {
            get => (byte)row["behaviorType"].Value;
            set => row["behaviorType"].Value = value;
        }

        // Unknown.
        public byte collisionType
        {
            get => (byte)row["collisionType"].Value;
            set => row["collisionType"].Value = value;
        }

        // Unknown.
        public byte rainBlockingType
        {
            get => (byte)row["rainBlockingType"].Value;
            set => row["rainBlockingType"].Value = value;
        }

        // Unknown.
        public short hp
        {
            get => (short)row["hp"].Value;
            set => row["hp"].Value = value;
        }

        // Unknown.
        public ushort defense
        {
            get => (ushort)row["defense"].Value;
            set => row["defense"].Value = value;
        }

        // Unknown.
        public float breakStopTime
        {
            get => (float)row["breakStopTime"].Value;
            set => row["breakStopTime"].Value = value;
        }

        // Unknown.
        public int breakSfxId
        {
            get => (int)row["breakSfxId"].Value;
            set => row["breakSfxId"].Value = value;
        }

        // Unknown.
        public int breakSfxCpId
        {
            get => (int)row["breakSfxCpId"].Value;
            set => row["breakSfxCpId"].Value = value;
        }

        // Unknown.
        public int breakLandingSfxId
        {
            get => (int)row["breakLandingSfxId"].Value;
            set => row["breakLandingSfxId"].Value = value;
        }

        // Unknown.
        public int breakBulletBehaviorId
        {
            get => (int)row["breakBulletBehaviorId"].Value;
            set => row["breakBulletBehaviorId"].Value = value;
        }

        // Unknown.
        public int breakBulletCpId
        {
            get => (int)row["breakBulletCpId"].Value;
            set => row["breakBulletCpId"].Value = value;
        }

        // Unknown.
        public float FragmentInvisibleWaitTime
        {
            get => (float)row["FragmentInvisibleWaitTime"].Value;
            set => row["FragmentInvisibleWaitTime"].Value = value;
        }

        // Unknown.
        public float FragmentInvisibleTime
        {
            get => (float)row["FragmentInvisibleTime"].Value;
            set => row["FragmentInvisibleTime"].Value = value;
        }

        // Unknown.
        public int BreakAiSoundID
        {
            get => (int)row["BreakAiSoundID"].Value;
            set => row["BreakAiSoundID"].Value = value;
        }

        // Unknown.
        public sbyte breakItemLotType
        {
            get => (sbyte)row["breakItemLotType"].Value;
            set => row["breakItemLotType"].Value = value;
        }

        // Unknown.
        public byte animBreakIdMax
        {
            get => (byte)row["animBreakIdMax"].Value;
            set => row["animBreakIdMax"].Value = value;
        }

        // Unknown.
        public sbyte breakBulletAttributeDamageType
        {
            get => (sbyte)row["breakBulletAttributeDamageType"].Value;
            set => row["breakBulletAttributeDamageType"].Value = value;
        }

        // Unknown.
        public byte isBreakByPlayerCollide
        {
            get => (byte)row["isBreakByPlayerCollide"].Value;
            set => row["isBreakByPlayerCollide"].Value = value;
        }

        // Unknown.
        public byte isBreakByEnemyCollide
        {
            get => (byte)row["isBreakByEnemyCollide"].Value;
            set => row["isBreakByEnemyCollide"].Value = value;
        }

        // Unknown.
        public byte isBreak_ByChrRide
        {
            get => (byte)row["isBreak_ByChrRide"].Value;
            set => row["isBreak_ByChrRide"].Value = value;
        }

        // Unknown.
        public byte isDisableBreakForFirstAppear
        {
            get => (byte)row["isDisableBreakForFirstAppear"].Value;
            set => row["isDisableBreakForFirstAppear"].Value = value;
        }

        // Unknown.
        public byte isAnimBreak
        {
            get => (byte)row["isAnimBreak"].Value;
            set => row["isAnimBreak"].Value = value;
        }

        // Unknown.
        public byte isDamageCover
        {
            get => (byte)row["isDamageCover"].Value;
            set => row["isDamageCover"].Value = value;
        }

        // Unknown.
        public byte isAttackBacklash
        {
            get => (byte)row["isAttackBacklash"].Value;
            set => row["isAttackBacklash"].Value = value;
        }

        // Unknown.
        public byte isLadder
        {
            get => (byte)row["isLadder"].Value;
            set => row["isLadder"].Value = value;
        }

        // Unknown.
        public byte isMoveObj
        {
            get => (byte)row["isMoveObj"].Value;
            set => row["isMoveObj"].Value = value;
        }

        // Unknown.
        public byte isSkydomeFlag
        {
            get => (byte)row["isSkydomeFlag"].Value;
            set => row["isSkydomeFlag"].Value = value;
        }

        // Unknown.
        public byte isAnimPauseOnRemoPlay
        {
            get => (byte)row["isAnimPauseOnRemoPlay"].Value;
            set => row["isAnimPauseOnRemoPlay"].Value = value;
        }

        // Unknown.
        public byte isBurn
        {
            get => (byte)row["isBurn"].Value;
            set => row["isBurn"].Value = value;
        }

        // Unknown.
        public byte isEnableRepick
        {
            get => (byte)row["isEnableRepick"].Value;
            set => row["isEnableRepick"].Value = value;
        }

        // Unknown.
        public byte isBreakOnPickUp
        {
            get => (byte)row["isBreakOnPickUp"].Value;
            set => row["isBreakOnPickUp"].Value = value;
        }

        // Unknown.
        public byte isBreakByHugeenemyCollide
        {
            get => (byte)row["isBreakByHugeenemyCollide"].Value;
            set => row["isBreakByHugeenemyCollide"].Value = value;
        }

        // Unknown.
        public byte navimeshFlag
        {
            get => (byte)row["navimeshFlag"].Value;
            set => row["navimeshFlag"].Value = value;
        }

        // Unknown.
        public ushort burnBulletInterval
        {
            get => (ushort)row["burnBulletInterval"].Value;
            set => row["burnBulletInterval"].Value = value;
        }

        // Unknown.
        public float clothUpdateDist
        {
            get => (float)row["clothUpdateDist"].Value;
            set => row["clothUpdateDist"].Value = value;
        }

        // Unknown.
        public float lifeTime_forRuntimeCreate
        {
            get => (float)row["lifeTime_forRuntimeCreate"].Value;
            set => row["lifeTime_forRuntimeCreate"].Value = value;
        }

        // Unknown.
        public int contactSeId
        {
            get => (int)row["contactSeId"].Value;
            set => row["contactSeId"].Value = value;
        }

        // Unknown.
        public int repickAnimIdOffset
        {
            get => (int)row["repickAnimIdOffset"].Value;
            set => row["repickAnimIdOffset"].Value = value;
        }

        // Unknown.
        public float windEffectRate_0
        {
            get => (float)row["windEffectRate_0"].Value;
            set => row["windEffectRate_0"].Value = value;
        }

        // Unknown.
        public float windEffectRate_1
        {
            get => (float)row["windEffectRate_1"].Value;
            set => row["windEffectRate_1"].Value = value;
        }

        // Unknown.
        public byte windEffectType_0
        {
            get => (byte)row["windEffectType_0"].Value;
            set => row["windEffectType_0"].Value = value;
        }

        // Unknown.
        public byte windEffectType_1
        {
            get => (byte)row["windEffectType_1"].Value;
            set => row["windEffectType_1"].Value = value;
        }

        // Unknown.
        public short overrideMaterialId
        {
            get => (short)row["overrideMaterialId"].Value;
            set => row["overrideMaterialId"].Value = value;
        }

        // Unknown.
        public float autoCreateOffsetHeight
        {
            get => (float)row["autoCreateOffsetHeight"].Value;
            set => row["autoCreateOffsetHeight"].Value = value;
        }

        // Unknown.
        public float burnTime
        {
            get => (float)row["burnTime"].Value;
            set => row["burnTime"].Value = value;
        }

        // Unknown.
        public float burnBraekRate
        {
            get => (float)row["burnBraekRate"].Value;
            set => row["burnBraekRate"].Value = value;
        }

        // Unknown.
        public int burnSfxId
        {
            get => (int)row["burnSfxId"].Value;
            set => row["burnSfxId"].Value = value;
        }

        // Unknown.
        public int burnSfxId_1
        {
            get => (int)row["burnSfxId_1"].Value;
            set => row["burnSfxId_1"].Value = value;
        }

        // Unknown.
        public int burnSfxId_2
        {
            get => (int)row["burnSfxId_2"].Value;
            set => row["burnSfxId_2"].Value = value;
        }

        // Unknown.
        public int burnSfxId_3
        {
            get => (int)row["burnSfxId_3"].Value;
            set => row["burnSfxId_3"].Value = value;
        }

        // Unknown.
        public float burnSfxDelayTimeMin
        {
            get => (float)row["burnSfxDelayTimeMin"].Value;
            set => row["burnSfxDelayTimeMin"].Value = value;
        }

        // Unknown.
        public float burnSfxDelayTimeMin_1
        {
            get => (float)row["burnSfxDelayTimeMin_1"].Value;
            set => row["burnSfxDelayTimeMin_1"].Value = value;
        }

        // Unknown.
        public float burnSfxDelayTimeMin_2
        {
            get => (float)row["burnSfxDelayTimeMin_2"].Value;
            set => row["burnSfxDelayTimeMin_2"].Value = value;
        }

        // Unknown.
        public float burnSfxDelayTimeMin_3
        {
            get => (float)row["burnSfxDelayTimeMin_3"].Value;
            set => row["burnSfxDelayTimeMin_3"].Value = value;
        }

        // Unknown.
        public float burnSfxDelayTimeMax
        {
            get => (float)row["burnSfxDelayTimeMax"].Value;
            set => row["burnSfxDelayTimeMax"].Value = value;
        }

        // Unknown.
        public float burnSfxDelayTimeMax_1
        {
            get => (float)row["burnSfxDelayTimeMax_1"].Value;
            set => row["burnSfxDelayTimeMax_1"].Value = value;
        }

        // Unknown.
        public float burnSfxDelayTimeMax_2
        {
            get => (float)row["burnSfxDelayTimeMax_2"].Value;
            set => row["burnSfxDelayTimeMax_2"].Value = value;
        }

        // Unknown.
        public float burnSfxDelayTimeMax_3
        {
            get => (float)row["burnSfxDelayTimeMax_3"].Value;
            set => row["burnSfxDelayTimeMax_3"].Value = value;
        }

        // Unknown.
        public int burnBulletBehaviorId
        {
            get => (int)row["burnBulletBehaviorId"].Value;
            set => row["burnBulletBehaviorId"].Value = value;
        }

        // Unknown.
        public int burnBulletBehaviorId_1
        {
            get => (int)row["burnBulletBehaviorId_1"].Value;
            set => row["burnBulletBehaviorId_1"].Value = value;
        }

        // Unknown.
        public int burnBulletBehaviorId_2
        {
            get => (int)row["burnBulletBehaviorId_2"].Value;
            set => row["burnBulletBehaviorId_2"].Value = value;
        }

        // Unknown.
        public int burnBulletBehaviorId_3
        {
            get => (int)row["burnBulletBehaviorId_3"].Value;
            set => row["burnBulletBehaviorId_3"].Value = value;
        }

        // Unknown.
        public float burnBulletDelayTime
        {
            get => (float)row["burnBulletDelayTime"].Value;
            set => row["burnBulletDelayTime"].Value = value;
        }

        // Unknown.
        public ushort paintDecalTargetTextureSize
        {
            get => (ushort)row["paintDecalTargetTextureSize"].Value;
            set => row["paintDecalTargetTextureSize"].Value = value;
        }

        // Unknown.
        public byte navimeshFlag_after
        {
            get => (byte)row["navimeshFlag_after"].Value;
            set => row["navimeshFlag_after"].Value = value;
        }

        // Unknown.
        public sbyte camNearBehaviorType
        {
            get => (sbyte)row["camNearBehaviorType"].Value;
            set => row["camNearBehaviorType"].Value = value;
        }

        // Unknown.
        public int breakItemLotParamId
        {
            get => (int)row["breakItemLotParamId"].Value;
            set => row["breakItemLotParamId"].Value = value;
        }

        // Unknown.
        public int pickUpActionButtonParamId
        {
            get => (int)row["pickUpActionButtonParamId"].Value;
            set => row["pickUpActionButtonParamId"].Value = value;
        }

        // Unknown.
        public int pickUpItemLotParamId
        {
            get => (int)row["pickUpItemLotParamId"].Value;
            set => row["pickUpItemLotParamId"].Value = value;
        }

        // Unknown.
        public byte autoDrawGroupBackFaceCheck
        {
            get => (byte)row["autoDrawGroupBackFaceCheck"].Value;
            set => row["autoDrawGroupBackFaceCheck"].Value = value;
        }

        // Unknown.
        public byte autoDrawGroupDepthWrite
        {
            get => (byte)row["autoDrawGroupDepthWrite"].Value;
            set => row["autoDrawGroupDepthWrite"].Value = value;
        }

        // Unknown.
        public byte autoDrawGroupShadowTest
        {
            get => (byte)row["autoDrawGroupShadowTest"].Value;
            set => row["autoDrawGroupShadowTest"].Value = value;
        }

        // Unknown.
        public byte debug_isHeightCheckEnable
        {
            get => (byte)row["debug_isHeightCheckEnable"].Value;
            set => row["debug_isHeightCheckEnable"].Value = value;
        }

        // Unknown.
        public byte hitCarverCancelAreaFlag
        {
            get => (byte)row["hitCarverCancelAreaFlag"].Value;
            set => row["hitCarverCancelAreaFlag"].Value = value;
        }

        // Unknown.
        public byte assetNavimeshNoCombine
        {
            get => (byte)row["assetNavimeshNoCombine"].Value;
            set => row["assetNavimeshNoCombine"].Value = value;
        }

        // Unknown.
        public byte navimeshFlagApply
        {
            get => (byte)row["navimeshFlagApply"].Value;
            set => row["navimeshFlagApply"].Value = value;
        }

        // Unknown.
        public byte navimeshFlagApply_after
        {
            get => (byte)row["navimeshFlagApply_after"].Value;
            set => row["navimeshFlagApply_after"].Value = value;
        }

        // Unknown.
        public float autoDrawGroupPassPixelNum
        {
            get => (float)row["autoDrawGroupPassPixelNum"].Value;
            set => row["autoDrawGroupPassPixelNum"].Value = value;
        }

        // Unknown.
        public uint pickUpReplacementEventFlag
        {
            get => (uint)row["pickUpReplacementEventFlag"].Value;
            set => row["pickUpReplacementEventFlag"].Value = value;
        }

        // Unknown.
        public int pickUpReplacementAnimIdOffset
        {
            get => (int)row["pickUpReplacementAnimIdOffset"].Value;
            set => row["pickUpReplacementAnimIdOffset"].Value = value;
        }

        // Unknown.
        public int pickUpReplacementActionButtonParamId
        {
            get => (int)row["pickUpReplacementActionButtonParamId"].Value;
            set => row["pickUpReplacementActionButtonParamId"].Value = value;
        }

        // Unknown.
        public int pickUpReplacementItemLotParamId
        {
            get => (int)row["pickUpReplacementItemLotParamId"].Value;
            set => row["pickUpReplacementItemLotParamId"].Value = value;
        }

        // Unknown.
        public byte slidingBulletHitType
        {
            get => (byte)row["slidingBulletHitType"].Value;
            set => row["slidingBulletHitType"].Value = value;
        }

        // Unknown.
        public byte isBushesForDamage
        {
            get => (byte)row["isBushesForDamage"].Value;
            set => row["isBushesForDamage"].Value = value;
        }

        // Unknown.
        public byte penetrationBulletType
        {
            get => (byte)row["penetrationBulletType"].Value;
            set => row["penetrationBulletType"].Value = value;
        }

        // Unknown.
        public int soundBreakSECpId
        {
            get => (int)row["soundBreakSECpId"].Value;
            set => row["soundBreakSECpId"].Value = value;
        }

        // Unknown.
        public float debug_HeightCheckCapacityMin
        {
            get => (float)row["debug_HeightCheckCapacityMin"].Value;
            set => row["debug_HeightCheckCapacityMin"].Value = value;
        }

        // Unknown.
        public float debug_HeightCheckCapacityMax
        {
            get => (float)row["debug_HeightCheckCapacityMax"].Value;
            set => row["debug_HeightCheckCapacityMax"].Value = value;
        }

        // Unknown.
        public int repickActionButtonParamId
        {
            get => (int)row["repickActionButtonParamId"].Value;
            set => row["repickActionButtonParamId"].Value = value;
        }

        // Unknown.
        public int repickItemLotParamId
        {
            get => (int)row["repickItemLotParamId"].Value;
            set => row["repickItemLotParamId"].Value = value;
        }

        // Unknown.
        public int repickReplacementAnimIdOffset
        {
            get => (int)row["repickReplacementAnimIdOffset"].Value;
            set => row["repickReplacementAnimIdOffset"].Value = value;
        }

        // Unknown.
        public int repickReplacementActionButtonParamId
        {
            get => (int)row["repickReplacementActionButtonParamId"].Value;
            set => row["repickReplacementActionButtonParamId"].Value = value;
        }

        // Unknown.
        public int repickReplacementItemLotParamId
        {
            get => (int)row["repickReplacementItemLotParamId"].Value;
            set => row["repickReplacementItemLotParamId"].Value = value;
        }

        // Unknown.
        public byte noGenerateCarver
        {
            get => (byte)row["noGenerateCarver"].Value;
            set => row["noGenerateCarver"].Value = value;
        }

        // Unknown.
        public byte noHitHugeAfterBreak
        {
            get => (byte)row["noHitHugeAfterBreak"].Value;
            set => row["noHitHugeAfterBreak"].Value = value;
        }

        // Unknown.
        public byte isEnabledBreakSync
        {
            get => (byte)row["isEnabledBreakSync"].Value;
            set => row["isEnabledBreakSync"].Value = value;
        }

        // Unknown.
        public byte isHiddenOnRepick
        {
            get => (byte)row["isHiddenOnRepick"].Value;
            set => row["isHiddenOnRepick"].Value = value;
        }

        // Unknown.
        public byte isCreateMultiPlayOnly
        {
            get => (byte)row["isCreateMultiPlayOnly"].Value;
            set => row["isCreateMultiPlayOnly"].Value = value;
        }

        // Unknown.
        public byte isDisableBulletHitSfx
        {
            get => (byte)row["isDisableBulletHitSfx"].Value;
            set => row["isDisableBulletHitSfx"].Value = value;
        }

        // Unknown.
        public byte isEnableSignPreBreak
        {
            get => (byte)row["isEnableSignPreBreak"].Value;
            set => row["isEnableSignPreBreak"].Value = value;
        }

        // Unknown.
        public byte isEnableSignPostBreak
        {
            get => (byte)row["isEnableSignPostBreak"].Value;
            set => row["isEnableSignPostBreak"].Value = value;
        }

        // Unknown.
        public byte generateMultiForbiddenRegion
        {
            get => (byte)row["generateMultiForbiddenRegion"].Value;
            set => row["generateMultiForbiddenRegion"].Value = value;
        }

        // Unknown.
        public int residentSeId0
        {
            get => (int)row["residentSeId0"].Value;
            set => row["residentSeId0"].Value = value;
        }

        // Unknown.
        public int residentSeId1
        {
            get => (int)row["residentSeId1"].Value;
            set => row["residentSeId1"].Value = value;
        }

        // Unknown.
        public int residentSeId2
        {
            get => (int)row["residentSeId2"].Value;
            set => row["residentSeId2"].Value = value;
        }

        // Unknown.
        public int residentSeId3
        {
            get => (int)row["residentSeId3"].Value;
            set => row["residentSeId3"].Value = value;
        }

        // Unknown.
        public short residentSeDmypolyId0
        {
            get => (short)row["residentSeDmypolyId0"].Value;
            set => row["residentSeDmypolyId0"].Value = value;
        }

        // Unknown.
        public short residentSeDmypolyId1
        {
            get => (short)row["residentSeDmypolyId1"].Value;
            set => row["residentSeDmypolyId1"].Value = value;
        }

        // Unknown.
        public short residentSeDmypolyId2
        {
            get => (short)row["residentSeDmypolyId2"].Value;
            set => row["residentSeDmypolyId2"].Value = value;
        }

        // Unknown.
        public short residentSeDmypolyId3
        {
            get => (short)row["residentSeDmypolyId3"].Value;
            set => row["residentSeDmypolyId3"].Value = value;
        }

        // Unknown.
        public byte excludeActivateRatio_Xboxone_Grid
        {
            get => (byte)row["excludeActivateRatio_Xboxone_Grid"].Value;
            set => row["excludeActivateRatio_Xboxone_Grid"].Value = value;
        }

        // Unknown.
        public byte excludeActivateRatio_Xboxone_Legacy
        {
            get => (byte)row["excludeActivateRatio_Xboxone_Legacy"].Value;
            set => row["excludeActivateRatio_Xboxone_Legacy"].Value = value;
        }

        // Unknown.
        public byte excludeActivateRatio_PS4_Grid
        {
            get => (byte)row["excludeActivateRatio_PS4_Grid"].Value;
            set => row["excludeActivateRatio_PS4_Grid"].Value = value;
        }

        // Unknown.
        public byte excludeActivateRatio_PS4_Legacy
        {
            get => (byte)row["excludeActivateRatio_PS4_Legacy"].Value;
            set => row["excludeActivateRatio_PS4_Legacy"].Value = value;
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
    public ASSET_GEOMETORY_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ASSET_GEOMETORY_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
