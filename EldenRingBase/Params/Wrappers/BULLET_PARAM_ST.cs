using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class BULLET_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public int atkId_Bullet
        {
            get => (int)row["atkId_Bullet"].Value;
            set => row["atkId_Bullet"].Value = value;
        }

        // Unknown.
        public int sfxId_Bullet
        {
            get => (int)row["sfxId_Bullet"].Value;
            set => row["sfxId_Bullet"].Value = value;
        }

        // Unknown.
        public int sfxId_Hit
        {
            get => (int)row["sfxId_Hit"].Value;
            set => row["sfxId_Hit"].Value = value;
        }

        // Unknown.
        public int sfxId_Flick
        {
            get => (int)row["sfxId_Flick"].Value;
            set => row["sfxId_Flick"].Value = value;
        }

        // Unknown.
        public float life
        {
            get => (float)row["life"].Value;
            set => row["life"].Value = value;
        }

        // Unknown.
        public float dist
        {
            get => (float)row["dist"].Value;
            set => row["dist"].Value = value;
        }

        // Unknown.
        public float shootInterval
        {
            get => (float)row["shootInterval"].Value;
            set => row["shootInterval"].Value = value;
        }

        // Unknown.
        public float gravityInRange
        {
            get => (float)row["gravityInRange"].Value;
            set => row["gravityInRange"].Value = value;
        }

        // Unknown.
        public float gravityOutRange
        {
            get => (float)row["gravityOutRange"].Value;
            set => row["gravityOutRange"].Value = value;
        }

        // Unknown.
        public float hormingStopRange
        {
            get => (float)row["hormingStopRange"].Value;
            set => row["hormingStopRange"].Value = value;
        }

        // Unknown.
        public float initVellocity
        {
            get => (float)row["initVellocity"].Value;
            set => row["initVellocity"].Value = value;
        }

        // Unknown.
        public float accelInRange
        {
            get => (float)row["accelInRange"].Value;
            set => row["accelInRange"].Value = value;
        }

        // Unknown.
        public float accelOutRange
        {
            get => (float)row["accelOutRange"].Value;
            set => row["accelOutRange"].Value = value;
        }

        // Unknown.
        public float maxVellocity
        {
            get => (float)row["maxVellocity"].Value;
            set => row["maxVellocity"].Value = value;
        }

        // Unknown.
        public float minVellocity
        {
            get => (float)row["minVellocity"].Value;
            set => row["minVellocity"].Value = value;
        }

        // Unknown.
        public float accelTime
        {
            get => (float)row["accelTime"].Value;
            set => row["accelTime"].Value = value;
        }

        // Unknown.
        public float homingBeginDist
        {
            get => (float)row["homingBeginDist"].Value;
            set => row["homingBeginDist"].Value = value;
        }

        // Unknown.
        public float hitRadius
        {
            get => (float)row["hitRadius"].Value;
            set => row["hitRadius"].Value = value;
        }

        // Unknown.
        public float hitRadiusMax
        {
            get => (float)row["hitRadiusMax"].Value;
            set => row["hitRadiusMax"].Value = value;
        }

        // Unknown.
        public float spreadTime
        {
            get => (float)row["spreadTime"].Value;
            set => row["spreadTime"].Value = value;
        }

        // Unknown.
        public float expDelay
        {
            get => (float)row["expDelay"].Value;
            set => row["expDelay"].Value = value;
        }

        // Unknown.
        public float hormingOffsetRange
        {
            get => (float)row["hormingOffsetRange"].Value;
            set => row["hormingOffsetRange"].Value = value;
        }

        // Unknown.
        public float dmgHitRecordLifeTime
        {
            get => (float)row["dmgHitRecordLifeTime"].Value;
            set => row["dmgHitRecordLifeTime"].Value = value;
        }

        // Unknown.
        public float externalForce
        {
            get => (float)row["externalForce"].Value;
            set => row["externalForce"].Value = value;
        }

        // Unknown.
        public int spEffectIDForShooter
        {
            get => (int)row["spEffectIDForShooter"].Value;
            set => row["spEffectIDForShooter"].Value = value;
        }

        // Unknown.
        public int autoSearchNPCThinkID
        {
            get => (int)row["autoSearchNPCThinkID"].Value;
            set => row["autoSearchNPCThinkID"].Value = value;
        }

        // Unknown.
        public int HitBulletID
        {
            get => (int)row["HitBulletID"].Value;
            set => row["HitBulletID"].Value = value;
        }

        // Unknown.
        public int spEffectId0
        {
            get => (int)row["spEffectId0"].Value;
            set => row["spEffectId0"].Value = value;
        }

        // Unknown.
        public int spEffectId1
        {
            get => (int)row["spEffectId1"].Value;
            set => row["spEffectId1"].Value = value;
        }

        // Unknown.
        public int spEffectId2
        {
            get => (int)row["spEffectId2"].Value;
            set => row["spEffectId2"].Value = value;
        }

        // Unknown.
        public int spEffectId3
        {
            get => (int)row["spEffectId3"].Value;
            set => row["spEffectId3"].Value = value;
        }

        // Unknown.
        public int spEffectId4
        {
            get => (int)row["spEffectId4"].Value;
            set => row["spEffectId4"].Value = value;
        }

        // Unknown.
        public ushort numShoot
        {
            get => (ushort)row["numShoot"].Value;
            set => row["numShoot"].Value = value;
        }

        // Unknown.
        public short homingAngle
        {
            get => (short)row["homingAngle"].Value;
            set => row["homingAngle"].Value = value;
        }

        // Unknown.
        public short shootAngle
        {
            get => (short)row["shootAngle"].Value;
            set => row["shootAngle"].Value = value;
        }

        // Unknown.
        public short shootAngleInterval
        {
            get => (short)row["shootAngleInterval"].Value;
            set => row["shootAngleInterval"].Value = value;
        }

        // Unknown.
        public short shootAngleXInterval
        {
            get => (short)row["shootAngleXInterval"].Value;
            set => row["shootAngleXInterval"].Value = value;
        }

        // Unknown.
        public sbyte damageDamp
        {
            get => (sbyte)row["damageDamp"].Value;
            set => row["damageDamp"].Value = value;
        }

        // Unknown.
        public sbyte spelDamageDamp
        {
            get => (sbyte)row["spelDamageDamp"].Value;
            set => row["spelDamageDamp"].Value = value;
        }

        // Unknown.
        public sbyte fireDamageDamp
        {
            get => (sbyte)row["fireDamageDamp"].Value;
            set => row["fireDamageDamp"].Value = value;
        }

        // Unknown.
        public sbyte thunderDamageDamp
        {
            get => (sbyte)row["thunderDamageDamp"].Value;
            set => row["thunderDamageDamp"].Value = value;
        }

        // Unknown.
        public sbyte staminaDamp
        {
            get => (sbyte)row["staminaDamp"].Value;
            set => row["staminaDamp"].Value = value;
        }

        // Unknown.
        public sbyte knockbackDamp
        {
            get => (sbyte)row["knockbackDamp"].Value;
            set => row["knockbackDamp"].Value = value;
        }

        // Unknown.
        public sbyte shootAngleXZ
        {
            get => (sbyte)row["shootAngleXZ"].Value;
            set => row["shootAngleXZ"].Value = value;
        }

        // Unknown.
        public byte lockShootLimitAng
        {
            get => (byte)row["lockShootLimitAng"].Value;
            set => row["lockShootLimitAng"].Value = value;
        }

        // Unknown.
        public byte prevVelocityDirRate
        {
            get => (byte)row["prevVelocityDirRate"].Value;
            set => row["prevVelocityDirRate"].Value = value;
        }

        // Unknown.
        public byte atkAttribute
        {
            get => (byte)row["atkAttribute"].Value;
            set => row["atkAttribute"].Value = value;
        }

        // Unknown.
        public byte spAttribute
        {
            get => (byte)row["spAttribute"].Value;
            set => row["spAttribute"].Value = value;
        }

        // Unknown.
        public byte Material_AttackType
        {
            get => (byte)row["Material_AttackType"].Value;
            set => row["Material_AttackType"].Value = value;
        }

        // Unknown.
        public byte Material_AttackMaterial
        {
            get => (byte)row["Material_AttackMaterial"].Value;
            set => row["Material_AttackMaterial"].Value = value;
        }

        // Unknown.
        public byte isPenetrateChr
        {
            get => (byte)row["isPenetrateChr"].Value;
            set => row["isPenetrateChr"].Value = value;
        }

        // Unknown.
        public byte isPenetrateObj
        {
            get => (byte)row["isPenetrateObj"].Value;
            set => row["isPenetrateObj"].Value = value;
        }

        // Unknown.
        public byte launchConditionType
        {
            get => (byte)row["launchConditionType"].Value;
            set => row["launchConditionType"].Value = value;
        }

        // Unknown.
        public byte FollowType
        {
            get => (byte)row["FollowType"].Value;
            set => row["FollowType"].Value = value;
        }

        // Unknown.
        public byte EmittePosType
        {
            get => (byte)row["EmittePosType"].Value;
            set => row["EmittePosType"].Value = value;
        }

        // Unknown.
        public byte isAttackSFX
        {
            get => (byte)row["isAttackSFX"].Value;
            set => row["isAttackSFX"].Value = value;
        }

        // Unknown.
        public byte isEndlessHit
        {
            get => (byte)row["isEndlessHit"].Value;
            set => row["isEndlessHit"].Value = value;
        }

        // Unknown.
        public byte isPenetrateMap
        {
            get => (byte)row["isPenetrateMap"].Value;
            set => row["isPenetrateMap"].Value = value;
        }

        // Unknown.
        public byte isHitBothTeam
        {
            get => (byte)row["isHitBothTeam"].Value;
            set => row["isHitBothTeam"].Value = value;
        }

        // Unknown.
        public byte isUseSharedHitList
        {
            get => (byte)row["isUseSharedHitList"].Value;
            set => row["isUseSharedHitList"].Value = value;
        }

        // Unknown.
        public byte isUseMultiDmyPolyIfPlace
        {
            get => (byte)row["isUseMultiDmyPolyIfPlace"].Value;
            set => row["isUseMultiDmyPolyIfPlace"].Value = value;
        }

        // Unknown.
        public byte isHitOtherBulletForceEraseA
        {
            get => (byte)row["isHitOtherBulletForceEraseA"].Value;
            set => row["isHitOtherBulletForceEraseA"].Value = value;
        }

        // Unknown.
        public byte isHitOtherBulletForceEraseB
        {
            get => (byte)row["isHitOtherBulletForceEraseB"].Value;
            set => row["isHitOtherBulletForceEraseB"].Value = value;
        }

        // Unknown.
        public byte isHitForceMagic
        {
            get => (byte)row["isHitForceMagic"].Value;
            set => row["isHitForceMagic"].Value = value;
        }

        // Unknown.
        public byte isIgnoreSfxIfHitWater
        {
            get => (byte)row["isIgnoreSfxIfHitWater"].Value;
            set => row["isIgnoreSfxIfHitWater"].Value = value;
        }

        // Unknown.
        public byte isIgnoreMoveStateIfHitWater
        {
            get => (byte)row["isIgnoreMoveStateIfHitWater"].Value;
            set => row["isIgnoreMoveStateIfHitWater"].Value = value;
        }

        // Unknown.
        public byte isHitDarkForceMagic
        {
            get => (byte)row["isHitDarkForceMagic"].Value;
            set => row["isHitDarkForceMagic"].Value = value;
        }

        // Unknown.
        public byte dmgCalcSide
        {
            get => (byte)row["dmgCalcSide"].Value;
            set => row["dmgCalcSide"].Value = value;
        }

        // Unknown.
        public byte isEnableAutoHoming
        {
            get => (byte)row["isEnableAutoHoming"].Value;
            set => row["isEnableAutoHoming"].Value = value;
        }

        // Unknown.
        public byte isSyncBulletCulcDumypolyPos
        {
            get => (byte)row["isSyncBulletCulcDumypolyPos"].Value;
            set => row["isSyncBulletCulcDumypolyPos"].Value = value;
        }

        // Unknown.
        public byte isOwnerOverrideInitAngle
        {
            get => (byte)row["isOwnerOverrideInitAngle"].Value;
            set => row["isOwnerOverrideInitAngle"].Value = value;
        }

        // Unknown.
        public byte isInheritSfxToChild
        {
            get => (byte)row["isInheritSfxToChild"].Value;
            set => row["isInheritSfxToChild"].Value = value;
        }

        // Unknown.
        public sbyte darkDamageDamp
        {
            get => (sbyte)row["darkDamageDamp"].Value;
            set => row["darkDamageDamp"].Value = value;
        }

        // Unknown.
        public sbyte bulletSfxDeleteType_byHit
        {
            get => (sbyte)row["bulletSfxDeleteType_byHit"].Value;
            set => row["bulletSfxDeleteType_byHit"].Value = value;
        }

        // Unknown.
        public sbyte bulletSfxDeleteType_byLifeDead
        {
            get => (sbyte)row["bulletSfxDeleteType_byLifeDead"].Value;
            set => row["bulletSfxDeleteType_byLifeDead"].Value = value;
        }

        // Unknown.
        public float targetYOffsetRange
        {
            get => (float)row["targetYOffsetRange"].Value;
            set => row["targetYOffsetRange"].Value = value;
        }

        // Unknown.
        public float shootAngleYMaxRandom
        {
            get => (float)row["shootAngleYMaxRandom"].Value;
            set => row["shootAngleYMaxRandom"].Value = value;
        }

        // Unknown.
        public float shootAngleXMaxRandom
        {
            get => (float)row["shootAngleXMaxRandom"].Value;
            set => row["shootAngleXMaxRandom"].Value = value;
        }

        // Unknown.
        public int intervalCreateBulletId
        {
            get => (int)row["intervalCreateBulletId"].Value;
            set => row["intervalCreateBulletId"].Value = value;
        }

        // Unknown.
        public float intervalCreateTimeMin
        {
            get => (float)row["intervalCreateTimeMin"].Value;
            set => row["intervalCreateTimeMin"].Value = value;
        }

        // Unknown.
        public float intervalCreateTimeMax
        {
            get => (float)row["intervalCreateTimeMax"].Value;
            set => row["intervalCreateTimeMax"].Value = value;
        }

        // Unknown.
        public float predictionShootObserveTime
        {
            get => (float)row["predictionShootObserveTime"].Value;
            set => row["predictionShootObserveTime"].Value = value;
        }

        // Unknown.
        public float intervalCreateWaitTime
        {
            get => (float)row["intervalCreateWaitTime"].Value;
            set => row["intervalCreateWaitTime"].Value = value;
        }

        // Unknown.
        public byte sfxPostureType
        {
            get => (byte)row["sfxPostureType"].Value;
            set => row["sfxPostureType"].Value = value;
        }

        // Unknown.
        public byte createLimitGroupId
        {
            get => (byte)row["createLimitGroupId"].Value;
            set => row["createLimitGroupId"].Value = value;
        }

        // Unknown.
        public byte isInheritSpeedToChild
        {
            get => (byte)row["isInheritSpeedToChild"].Value;
            set => row["isInheritSpeedToChild"].Value = value;
        }

        // Unknown.
        public byte isDisableHitSfx_byChrAndObj
        {
            get => (byte)row["isDisableHitSfx_byChrAndObj"].Value;
            set => row["isDisableHitSfx_byChrAndObj"].Value = value;
        }

        // Unknown.
        public byte isCheckWall_byCenterRay
        {
            get => (byte)row["isCheckWall_byCenterRay"].Value;
            set => row["isCheckWall_byCenterRay"].Value = value;
        }

        // Unknown.
        public byte isHitFlare
        {
            get => (byte)row["isHitFlare"].Value;
            set => row["isHitFlare"].Value = value;
        }

        // Unknown.
        public byte isUseBulletWallFilter
        {
            get => (byte)row["isUseBulletWallFilter"].Value;
            set => row["isUseBulletWallFilter"].Value = value;
        }

        // Unknown.
        public byte isNonDependenceMagicForFunnleNum
        {
            get => (byte)row["isNonDependenceMagicForFunnleNum"].Value;
            set => row["isNonDependenceMagicForFunnleNum"].Value = value;
        }

        // Unknown.
        public byte isAiInterruptShootNoDamageBullet
        {
            get => (byte)row["isAiInterruptShootNoDamageBullet"].Value;
            set => row["isAiInterruptShootNoDamageBullet"].Value = value;
        }

        // Unknown.
        public float randomCreateRadius
        {
            get => (float)row["randomCreateRadius"].Value;
            set => row["randomCreateRadius"].Value = value;
        }

        // Unknown.
        public float followOffset_BaseHeight
        {
            get => (float)row["followOffset_BaseHeight"].Value;
            set => row["followOffset_BaseHeight"].Value = value;
        }

        // Unknown.
        public int assetNo_Hit
        {
            get => (int)row["assetNo_Hit"].Value;
            set => row["assetNo_Hit"].Value = value;
        }

        // Unknown.
        public float lifeRandomRange
        {
            get => (float)row["lifeRandomRange"].Value;
            set => row["lifeRandomRange"].Value = value;
        }

        // Unknown.
        public short homingAngleX
        {
            get => (short)row["homingAngleX"].Value;
            set => row["homingAngleX"].Value = value;
        }

        // Unknown.
        public byte ballisticCalcType
        {
            get => (byte)row["ballisticCalcType"].Value;
            set => row["ballisticCalcType"].Value = value;
        }

        // Unknown.
        public byte attachEffectType
        {
            get => (byte)row["attachEffectType"].Value;
            set => row["attachEffectType"].Value = value;
        }

        // Unknown.
        public int seId_Bullet1
        {
            get => (int)row["seId_Bullet1"].Value;
            set => row["seId_Bullet1"].Value = value;
        }

        // Unknown.
        public int seId_Bullet2
        {
            get => (int)row["seId_Bullet2"].Value;
            set => row["seId_Bullet2"].Value = value;
        }

        // Unknown.
        public int seId_Hit
        {
            get => (int)row["seId_Hit"].Value;
            set => row["seId_Hit"].Value = value;
        }

        // Unknown.
        public int seId_Flick
        {
            get => (int)row["seId_Flick"].Value;
            set => row["seId_Flick"].Value = value;
        }

        // Unknown.
        public short howitzerShootAngleXMin
        {
            get => (short)row["howitzerShootAngleXMin"].Value;
            set => row["howitzerShootAngleXMin"].Value = value;
        }

        // Unknown.
        public short howitzerShootAngleXMax
        {
            get => (short)row["howitzerShootAngleXMax"].Value;
            set => row["howitzerShootAngleXMax"].Value = value;
        }

        // Unknown.
        public float howitzerInitMinVelocity
        {
            get => (float)row["howitzerInitMinVelocity"].Value;
            set => row["howitzerInitMinVelocity"].Value = value;
        }

        // Unknown.
        public float howitzerInitMaxVelocity
        {
            get => (float)row["howitzerInitMaxVelocity"].Value;
            set => row["howitzerInitMaxVelocity"].Value = value;
        }

        // Unknown.
        public int sfxId_ForceErase
        {
            get => (int)row["sfxId_ForceErase"].Value;
            set => row["sfxId_ForceErase"].Value = value;
        }

        // Unknown.
        public sbyte bulletSfxDeleteType_byForceErase
        {
            get => (sbyte)row["bulletSfxDeleteType_byForceErase"].Value;
            set => row["bulletSfxDeleteType_byForceErase"].Value = value;
        }

        // Unknown.
        public short followDmypoly_forSfxPose
        {
            get => (short)row["followDmypoly_forSfxPose"].Value;
            set => row["followDmypoly_forSfxPose"].Value = value;
        }

        // Unknown.
        public float followOffset_Radius
        {
            get => (float)row["followOffset_Radius"].Value;
            set => row["followOffset_Radius"].Value = value;
        }

        // Unknown.
        public float spBulletDistUpRate
        {
            get => (float)row["spBulletDistUpRate"].Value;
            set => row["spBulletDistUpRate"].Value = value;
        }

        // Unknown.
        public float nolockTargetDist
        {
            get => (float)row["nolockTargetDist"].Value;
            set => row["nolockTargetDist"].Value = value;
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
    public BULLET_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public BULLET_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
