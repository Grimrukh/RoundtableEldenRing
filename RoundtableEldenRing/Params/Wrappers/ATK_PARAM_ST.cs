using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class ATK_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public float hit0_Radius
        {
            get => (float)row["hit0_Radius"].Value;
            set => row["hit0_Radius"].Value = value;
        }

        // Unknown.
        public float hit1_Radius
        {
            get => (float)row["hit1_Radius"].Value;
            set => row["hit1_Radius"].Value = value;
        }

        // Unknown.
        public float hit2_Radius
        {
            get => (float)row["hit2_Radius"].Value;
            set => row["hit2_Radius"].Value = value;
        }

        // Unknown.
        public float hit3_Radius
        {
            get => (float)row["hit3_Radius"].Value;
            set => row["hit3_Radius"].Value = value;
        }

        // Unknown.
        public float knockbackDist
        {
            get => (float)row["knockbackDist"].Value;
            set => row["knockbackDist"].Value = value;
        }

        // Unknown.
        public float hitStopTime
        {
            get => (float)row["hitStopTime"].Value;
            set => row["hitStopTime"].Value = value;
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
        public short hit0_DmyPoly1
        {
            get => (short)row["hit0_DmyPoly1"].Value;
            set => row["hit0_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit1_DmyPoly1
        {
            get => (short)row["hit1_DmyPoly1"].Value;
            set => row["hit1_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit2_DmyPoly1
        {
            get => (short)row["hit2_DmyPoly1"].Value;
            set => row["hit2_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit3_DmyPoly1
        {
            get => (short)row["hit3_DmyPoly1"].Value;
            set => row["hit3_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit0_DmyPoly2
        {
            get => (short)row["hit0_DmyPoly2"].Value;
            set => row["hit0_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit1_DmyPoly2
        {
            get => (short)row["hit1_DmyPoly2"].Value;
            set => row["hit1_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit2_DmyPoly2
        {
            get => (short)row["hit2_DmyPoly2"].Value;
            set => row["hit2_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit3_DmyPoly2
        {
            get => (short)row["hit3_DmyPoly2"].Value;
            set => row["hit3_DmyPoly2"].Value = value;
        }

        // Unknown.
        public ushort blowingCorrection
        {
            get => (ushort)row["blowingCorrection"].Value;
            set => row["blowingCorrection"].Value = value;
        }

        // Unknown.
        public ushort atkPhysCorrection
        {
            get => (ushort)row["atkPhysCorrection"].Value;
            set => row["atkPhysCorrection"].Value = value;
        }

        // Unknown.
        public ushort atkMagCorrection
        {
            get => (ushort)row["atkMagCorrection"].Value;
            set => row["atkMagCorrection"].Value = value;
        }

        // Unknown.
        public ushort atkFireCorrection
        {
            get => (ushort)row["atkFireCorrection"].Value;
            set => row["atkFireCorrection"].Value = value;
        }

        // Unknown.
        public ushort atkThunCorrection
        {
            get => (ushort)row["atkThunCorrection"].Value;
            set => row["atkThunCorrection"].Value = value;
        }

        // Unknown.
        public ushort atkStamCorrection
        {
            get => (ushort)row["atkStamCorrection"].Value;
            set => row["atkStamCorrection"].Value = value;
        }

        // Unknown.
        public ushort guardAtkRateCorrection
        {
            get => (ushort)row["guardAtkRateCorrection"].Value;
            set => row["guardAtkRateCorrection"].Value = value;
        }

        // Unknown.
        public ushort guardBreakCorrection
        {
            get => (ushort)row["guardBreakCorrection"].Value;
            set => row["guardBreakCorrection"].Value = value;
        }

        // Unknown.
        public ushort atkThrowEscapeCorrection
        {
            get => (ushort)row["atkThrowEscapeCorrection"].Value;
            set => row["atkThrowEscapeCorrection"].Value = value;
        }

        // Unknown.
        public byte subCategory1
        {
            get => (byte)row["subCategory1"].Value;
            set => row["subCategory1"].Value = value;
        }

        // Unknown.
        public byte subCategory2
        {
            get => (byte)row["subCategory2"].Value;
            set => row["subCategory2"].Value = value;
        }

        // Unknown.
        public ushort atkPhys
        {
            get => (ushort)row["atkPhys"].Value;
            set => row["atkPhys"].Value = value;
        }

        // Unknown.
        public ushort atkMag
        {
            get => (ushort)row["atkMag"].Value;
            set => row["atkMag"].Value = value;
        }

        // Unknown.
        public ushort atkFire
        {
            get => (ushort)row["atkFire"].Value;
            set => row["atkFire"].Value = value;
        }

        // Unknown.
        public ushort atkThun
        {
            get => (ushort)row["atkThun"].Value;
            set => row["atkThun"].Value = value;
        }

        // Unknown.
        public ushort atkStam
        {
            get => (ushort)row["atkStam"].Value;
            set => row["atkStam"].Value = value;
        }

        // Unknown.
        public ushort guardAtkRate
        {
            get => (ushort)row["guardAtkRate"].Value;
            set => row["guardAtkRate"].Value = value;
        }

        // Unknown.
        public ushort guardBreakRate
        {
            get => (ushort)row["guardBreakRate"].Value;
            set => row["guardBreakRate"].Value = value;
        }

        // Unknown.
        public byte isEnableCalcDamageForBushesObj
        {
            get => (byte)row["isEnableCalcDamageForBushesObj"].Value;
            set => row["isEnableCalcDamageForBushesObj"].Value = value;
        }

        // Unknown.
        public ushort atkThrowEscape
        {
            get => (ushort)row["atkThrowEscape"].Value;
            set => row["atkThrowEscape"].Value = value;
        }

        // Unknown.
        public ushort atkObj
        {
            get => (ushort)row["atkObj"].Value;
            set => row["atkObj"].Value = value;
        }

        // Unknown.
        public short guardStaminaCutRate
        {
            get => (short)row["guardStaminaCutRate"].Value;
            set => row["guardStaminaCutRate"].Value = value;
        }

        // Unknown.
        public short guardRate
        {
            get => (short)row["guardRate"].Value;
            set => row["guardRate"].Value = value;
        }

        // Unknown.
        public ushort throwTypeId
        {
            get => (ushort)row["throwTypeId"].Value;
            set => row["throwTypeId"].Value = value;
        }

        // Unknown.
        public byte hit0_hitType
        {
            get => (byte)row["hit0_hitType"].Value;
            set => row["hit0_hitType"].Value = value;
        }

        // Unknown.
        public byte hit1_hitType
        {
            get => (byte)row["hit1_hitType"].Value;
            set => row["hit1_hitType"].Value = value;
        }

        // Unknown.
        public byte hit2_hitType
        {
            get => (byte)row["hit2_hitType"].Value;
            set => row["hit2_hitType"].Value = value;
        }

        // Unknown.
        public byte hit3_hitType
        {
            get => (byte)row["hit3_hitType"].Value;
            set => row["hit3_hitType"].Value = value;
        }

        // Unknown.
        public byte hti0_Priority
        {
            get => (byte)row["hti0_Priority"].Value;
            set => row["hti0_Priority"].Value = value;
        }

        // Unknown.
        public byte hti1_Priority
        {
            get => (byte)row["hti1_Priority"].Value;
            set => row["hti1_Priority"].Value = value;
        }

        // Unknown.
        public byte hti2_Priority
        {
            get => (byte)row["hti2_Priority"].Value;
            set => row["hti2_Priority"].Value = value;
        }

        // Unknown.
        public byte hti3_Priority
        {
            get => (byte)row["hti3_Priority"].Value;
            set => row["hti3_Priority"].Value = value;
        }

        // Unknown.
        public byte dmgLevel
        {
            get => (byte)row["dmgLevel"].Value;
            set => row["dmgLevel"].Value = value;
        }

        // Unknown.
        public byte mapHitType
        {
            get => (byte)row["mapHitType"].Value;
            set => row["mapHitType"].Value = value;
        }

        // Unknown.
        public sbyte guardCutCancelRate
        {
            get => (sbyte)row["guardCutCancelRate"].Value;
            set => row["guardCutCancelRate"].Value = value;
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
        public byte atkType
        {
            get => (byte)row["atkType"].Value;
            set => row["atkType"].Value = value;
        }

        // Unknown.
        public byte atkMaterial
        {
            get => (byte)row["atkMaterial"].Value;
            set => row["atkMaterial"].Value = value;
        }

        // Unknown.
        public byte guardRangeType
        {
            get => (byte)row["guardRangeType"].Value;
            set => row["guardRangeType"].Value = value;
        }

        // Unknown.
        public ushort defSeMaterial1
        {
            get => (ushort)row["defSeMaterial1"].Value;
            set => row["defSeMaterial1"].Value = value;
        }

        // Unknown.
        public byte hitSourceType
        {
            get => (byte)row["hitSourceType"].Value;
            set => row["hitSourceType"].Value = value;
        }

        // Unknown.
        public byte throwFlag
        {
            get => (byte)row["throwFlag"].Value;
            set => row["throwFlag"].Value = value;
        }

        // Unknown.
        public byte disableGuard
        {
            get => (byte)row["disableGuard"].Value;
            set => row["disableGuard"].Value = value;
        }

        // Unknown.
        public byte disableStaminaAttack
        {
            get => (byte)row["disableStaminaAttack"].Value;
            set => row["disableStaminaAttack"].Value = value;
        }

        // Unknown.
        public byte disableHitSpEffect
        {
            get => (byte)row["disableHitSpEffect"].Value;
            set => row["disableHitSpEffect"].Value = value;
        }

        // Unknown.
        public byte IgnoreNotifyMissSwingForAI
        {
            get => (byte)row["IgnoreNotifyMissSwingForAI"].Value;
            set => row["IgnoreNotifyMissSwingForAI"].Value = value;
        }

        // Unknown.
        public byte repeatHitSfx
        {
            get => (byte)row["repeatHitSfx"].Value;
            set => row["repeatHitSfx"].Value = value;
        }

        // Unknown.
        public byte isArrowAtk
        {
            get => (byte)row["isArrowAtk"].Value;
            set => row["isArrowAtk"].Value = value;
        }

        // Unknown.
        public byte isGhostAtk
        {
            get => (byte)row["isGhostAtk"].Value;
            set => row["isGhostAtk"].Value = value;
        }

        // Unknown.
        public byte isDisableNoDamage
        {
            get => (byte)row["isDisableNoDamage"].Value;
            set => row["isDisableNoDamage"].Value = value;
        }

        // Unknown.
        public sbyte atkPow_forSfx
        {
            get => (sbyte)row["atkPow_forSfx"].Value;
            set => row["atkPow_forSfx"].Value = value;
        }

        // Unknown.
        public sbyte atkDir_forSfx
        {
            get => (sbyte)row["atkDir_forSfx"].Value;
            set => row["atkDir_forSfx"].Value = value;
        }

        // Unknown.
        public byte opposeTarget
        {
            get => (byte)row["opposeTarget"].Value;
            set => row["opposeTarget"].Value = value;
        }

        // Unknown.
        public byte friendlyTarget
        {
            get => (byte)row["friendlyTarget"].Value;
            set => row["friendlyTarget"].Value = value;
        }

        // Unknown.
        public byte selfTarget
        {
            get => (byte)row["selfTarget"].Value;
            set => row["selfTarget"].Value = value;
        }

        // Unknown.
        public byte isCheckDoorPenetration
        {
            get => (byte)row["isCheckDoorPenetration"].Value;
            set => row["isCheckDoorPenetration"].Value = value;
        }

        // Unknown.
        public byte isVsRideAtk
        {
            get => (byte)row["isVsRideAtk"].Value;
            set => row["isVsRideAtk"].Value = value;
        }

        // Unknown.
        public byte isAddBaseAtk
        {
            get => (byte)row["isAddBaseAtk"].Value;
            set => row["isAddBaseAtk"].Value = value;
        }

        // Unknown.
        public byte excludeThreatLvNotify
        {
            get => (byte)row["excludeThreatLvNotify"].Value;
            set => row["excludeThreatLvNotify"].Value = value;
        }

        // Unknown.
        public byte atkBehaviorId
        {
            get => (byte)row["atkBehaviorId"].Value;
            set => row["atkBehaviorId"].Value = value;
        }

        // Unknown.
        public sbyte atkPow_forSe
        {
            get => (sbyte)row["atkPow_forSe"].Value;
            set => row["atkPow_forSe"].Value = value;
        }

        // Unknown.
        public float atkSuperArmor
        {
            get => (float)row["atkSuperArmor"].Value;
            set => row["atkSuperArmor"].Value = value;
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
        public int AppearAiSoundId
        {
            get => (int)row["AppearAiSoundId"].Value;
            set => row["AppearAiSoundId"].Value = value;
        }

        // Unknown.
        public int HitAiSoundId
        {
            get => (int)row["HitAiSoundId"].Value;
            set => row["HitAiSoundId"].Value = value;
        }

        // Unknown.
        public int HitRumbleId
        {
            get => (int)row["HitRumbleId"].Value;
            set => row["HitRumbleId"].Value = value;
        }

        // Unknown.
        public int HitRumbleIdByNormal
        {
            get => (int)row["HitRumbleIdByNormal"].Value;
            set => row["HitRumbleIdByNormal"].Value = value;
        }

        // Unknown.
        public int HitRumbleIdByMiddle
        {
            get => (int)row["HitRumbleIdByMiddle"].Value;
            set => row["HitRumbleIdByMiddle"].Value = value;
        }

        // Unknown.
        public int HitRumbleIdByRoot
        {
            get => (int)row["HitRumbleIdByRoot"].Value;
            set => row["HitRumbleIdByRoot"].Value = value;
        }

        // Unknown.
        public int traceSfxId0
        {
            get => (int)row["traceSfxId0"].Value;
            set => row["traceSfxId0"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead0
        {
            get => (int)row["traceDmyIdHead0"].Value;
            set => row["traceDmyIdHead0"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail0
        {
            get => (int)row["traceDmyIdTail0"].Value;
            set => row["traceDmyIdTail0"].Value = value;
        }

        // Unknown.
        public int traceSfxId1
        {
            get => (int)row["traceSfxId1"].Value;
            set => row["traceSfxId1"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead1
        {
            get => (int)row["traceDmyIdHead1"].Value;
            set => row["traceDmyIdHead1"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail1
        {
            get => (int)row["traceDmyIdTail1"].Value;
            set => row["traceDmyIdTail1"].Value = value;
        }

        // Unknown.
        public int traceSfxId2
        {
            get => (int)row["traceSfxId2"].Value;
            set => row["traceSfxId2"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead2
        {
            get => (int)row["traceDmyIdHead2"].Value;
            set => row["traceDmyIdHead2"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail2
        {
            get => (int)row["traceDmyIdTail2"].Value;
            set => row["traceDmyIdTail2"].Value = value;
        }

        // Unknown.
        public int traceSfxId3
        {
            get => (int)row["traceSfxId3"].Value;
            set => row["traceSfxId3"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead3
        {
            get => (int)row["traceDmyIdHead3"].Value;
            set => row["traceDmyIdHead3"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail3
        {
            get => (int)row["traceDmyIdTail3"].Value;
            set => row["traceDmyIdTail3"].Value = value;
        }

        // Unknown.
        public int traceSfxId4
        {
            get => (int)row["traceSfxId4"].Value;
            set => row["traceSfxId4"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead4
        {
            get => (int)row["traceDmyIdHead4"].Value;
            set => row["traceDmyIdHead4"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail4
        {
            get => (int)row["traceDmyIdTail4"].Value;
            set => row["traceDmyIdTail4"].Value = value;
        }

        // Unknown.
        public int traceSfxId5
        {
            get => (int)row["traceSfxId5"].Value;
            set => row["traceSfxId5"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead5
        {
            get => (int)row["traceDmyIdHead5"].Value;
            set => row["traceDmyIdHead5"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail5
        {
            get => (int)row["traceDmyIdTail5"].Value;
            set => row["traceDmyIdTail5"].Value = value;
        }

        // Unknown.
        public int traceSfxId6
        {
            get => (int)row["traceSfxId6"].Value;
            set => row["traceSfxId6"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead6
        {
            get => (int)row["traceDmyIdHead6"].Value;
            set => row["traceDmyIdHead6"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail6
        {
            get => (int)row["traceDmyIdTail6"].Value;
            set => row["traceDmyIdTail6"].Value = value;
        }

        // Unknown.
        public int traceSfxId7
        {
            get => (int)row["traceSfxId7"].Value;
            set => row["traceSfxId7"].Value = value;
        }

        // Unknown.
        public int traceDmyIdHead7
        {
            get => (int)row["traceDmyIdHead7"].Value;
            set => row["traceDmyIdHead7"].Value = value;
        }

        // Unknown.
        public int traceDmyIdTail7
        {
            get => (int)row["traceDmyIdTail7"].Value;
            set => row["traceDmyIdTail7"].Value = value;
        }

        // Unknown.
        public float hit4_Radius
        {
            get => (float)row["hit4_Radius"].Value;
            set => row["hit4_Radius"].Value = value;
        }

        // Unknown.
        public float hit5_Radius
        {
            get => (float)row["hit5_Radius"].Value;
            set => row["hit5_Radius"].Value = value;
        }

        // Unknown.
        public float hit6_Radius
        {
            get => (float)row["hit6_Radius"].Value;
            set => row["hit6_Radius"].Value = value;
        }

        // Unknown.
        public float hit7_Radius
        {
            get => (float)row["hit7_Radius"].Value;
            set => row["hit7_Radius"].Value = value;
        }

        // Unknown.
        public float hit8_Radius
        {
            get => (float)row["hit8_Radius"].Value;
            set => row["hit8_Radius"].Value = value;
        }

        // Unknown.
        public float hit9_Radius
        {
            get => (float)row["hit9_Radius"].Value;
            set => row["hit9_Radius"].Value = value;
        }

        // Unknown.
        public float hit10_Radius
        {
            get => (float)row["hit10_Radius"].Value;
            set => row["hit10_Radius"].Value = value;
        }

        // Unknown.
        public float hit11_Radius
        {
            get => (float)row["hit11_Radius"].Value;
            set => row["hit11_Radius"].Value = value;
        }

        // Unknown.
        public float hit12_Radius
        {
            get => (float)row["hit12_Radius"].Value;
            set => row["hit12_Radius"].Value = value;
        }

        // Unknown.
        public float hit13_Radius
        {
            get => (float)row["hit13_Radius"].Value;
            set => row["hit13_Radius"].Value = value;
        }

        // Unknown.
        public float hit14_Radius
        {
            get => (float)row["hit14_Radius"].Value;
            set => row["hit14_Radius"].Value = value;
        }

        // Unknown.
        public float hit15_Radius
        {
            get => (float)row["hit15_Radius"].Value;
            set => row["hit15_Radius"].Value = value;
        }

        // Unknown.
        public short hit4_DmyPoly1
        {
            get => (short)row["hit4_DmyPoly1"].Value;
            set => row["hit4_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit5_DmyPoly1
        {
            get => (short)row["hit5_DmyPoly1"].Value;
            set => row["hit5_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit6_DmyPoly1
        {
            get => (short)row["hit6_DmyPoly1"].Value;
            set => row["hit6_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit7_DmyPoly1
        {
            get => (short)row["hit7_DmyPoly1"].Value;
            set => row["hit7_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit8_DmyPoly1
        {
            get => (short)row["hit8_DmyPoly1"].Value;
            set => row["hit8_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit9_DmyPoly1
        {
            get => (short)row["hit9_DmyPoly1"].Value;
            set => row["hit9_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit10_DmyPoly1
        {
            get => (short)row["hit10_DmyPoly1"].Value;
            set => row["hit10_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit11_DmyPoly1
        {
            get => (short)row["hit11_DmyPoly1"].Value;
            set => row["hit11_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit12_DmyPoly1
        {
            get => (short)row["hit12_DmyPoly1"].Value;
            set => row["hit12_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit13_DmyPoly1
        {
            get => (short)row["hit13_DmyPoly1"].Value;
            set => row["hit13_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit14_DmyPoly1
        {
            get => (short)row["hit14_DmyPoly1"].Value;
            set => row["hit14_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit15_DmyPoly1
        {
            get => (short)row["hit15_DmyPoly1"].Value;
            set => row["hit15_DmyPoly1"].Value = value;
        }

        // Unknown.
        public short hit4_DmyPoly2
        {
            get => (short)row["hit4_DmyPoly2"].Value;
            set => row["hit4_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit5_DmyPoly2
        {
            get => (short)row["hit5_DmyPoly2"].Value;
            set => row["hit5_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit6_DmyPoly2
        {
            get => (short)row["hit6_DmyPoly2"].Value;
            set => row["hit6_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit7_DmyPoly2
        {
            get => (short)row["hit7_DmyPoly2"].Value;
            set => row["hit7_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit8_DmyPoly2
        {
            get => (short)row["hit8_DmyPoly2"].Value;
            set => row["hit8_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit9_DmyPoly2
        {
            get => (short)row["hit9_DmyPoly2"].Value;
            set => row["hit9_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit10_DmyPoly2
        {
            get => (short)row["hit10_DmyPoly2"].Value;
            set => row["hit10_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit11_DmyPoly2
        {
            get => (short)row["hit11_DmyPoly2"].Value;
            set => row["hit11_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit12_DmyPoly2
        {
            get => (short)row["hit12_DmyPoly2"].Value;
            set => row["hit12_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit13_DmyPoly2
        {
            get => (short)row["hit13_DmyPoly2"].Value;
            set => row["hit13_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit14_DmyPoly2
        {
            get => (short)row["hit14_DmyPoly2"].Value;
            set => row["hit14_DmyPoly2"].Value = value;
        }

        // Unknown.
        public short hit15_DmyPoly2
        {
            get => (short)row["hit15_DmyPoly2"].Value;
            set => row["hit15_DmyPoly2"].Value = value;
        }

        // Unknown.
        public byte hit4_hitType
        {
            get => (byte)row["hit4_hitType"].Value;
            set => row["hit4_hitType"].Value = value;
        }

        // Unknown.
        public byte hit5_hitType
        {
            get => (byte)row["hit5_hitType"].Value;
            set => row["hit5_hitType"].Value = value;
        }

        // Unknown.
        public byte hit6_hitType
        {
            get => (byte)row["hit6_hitType"].Value;
            set => row["hit6_hitType"].Value = value;
        }

        // Unknown.
        public byte hit7_hitType
        {
            get => (byte)row["hit7_hitType"].Value;
            set => row["hit7_hitType"].Value = value;
        }

        // Unknown.
        public byte hit8_hitType
        {
            get => (byte)row["hit8_hitType"].Value;
            set => row["hit8_hitType"].Value = value;
        }

        // Unknown.
        public byte hit9_hitType
        {
            get => (byte)row["hit9_hitType"].Value;
            set => row["hit9_hitType"].Value = value;
        }

        // Unknown.
        public byte hit10_hitType
        {
            get => (byte)row["hit10_hitType"].Value;
            set => row["hit10_hitType"].Value = value;
        }

        // Unknown.
        public byte hit11_hitType
        {
            get => (byte)row["hit11_hitType"].Value;
            set => row["hit11_hitType"].Value = value;
        }

        // Unknown.
        public byte hit12_hitType
        {
            get => (byte)row["hit12_hitType"].Value;
            set => row["hit12_hitType"].Value = value;
        }

        // Unknown.
        public byte hit13_hitType
        {
            get => (byte)row["hit13_hitType"].Value;
            set => row["hit13_hitType"].Value = value;
        }

        // Unknown.
        public byte hit14_hitType
        {
            get => (byte)row["hit14_hitType"].Value;
            set => row["hit14_hitType"].Value = value;
        }

        // Unknown.
        public byte hit15_hitType
        {
            get => (byte)row["hit15_hitType"].Value;
            set => row["hit15_hitType"].Value = value;
        }

        // Unknown.
        public byte hti4_Priority
        {
            get => (byte)row["hti4_Priority"].Value;
            set => row["hti4_Priority"].Value = value;
        }

        // Unknown.
        public byte hti5_Priority
        {
            get => (byte)row["hti5_Priority"].Value;
            set => row["hti5_Priority"].Value = value;
        }

        // Unknown.
        public byte hti6_Priority
        {
            get => (byte)row["hti6_Priority"].Value;
            set => row["hti6_Priority"].Value = value;
        }

        // Unknown.
        public byte hti7_Priority
        {
            get => (byte)row["hti7_Priority"].Value;
            set => row["hti7_Priority"].Value = value;
        }

        // Unknown.
        public byte hti8_Priority
        {
            get => (byte)row["hti8_Priority"].Value;
            set => row["hti8_Priority"].Value = value;
        }

        // Unknown.
        public byte hti9_Priority
        {
            get => (byte)row["hti9_Priority"].Value;
            set => row["hti9_Priority"].Value = value;
        }

        // Unknown.
        public byte hti10_Priority
        {
            get => (byte)row["hti10_Priority"].Value;
            set => row["hti10_Priority"].Value = value;
        }

        // Unknown.
        public byte hti11_Priority
        {
            get => (byte)row["hti11_Priority"].Value;
            set => row["hti11_Priority"].Value = value;
        }

        // Unknown.
        public byte hti12_Priority
        {
            get => (byte)row["hti12_Priority"].Value;
            set => row["hti12_Priority"].Value = value;
        }

        // Unknown.
        public byte hti13_Priority
        {
            get => (byte)row["hti13_Priority"].Value;
            set => row["hti13_Priority"].Value = value;
        }

        // Unknown.
        public byte hti14_Priority
        {
            get => (byte)row["hti14_Priority"].Value;
            set => row["hti14_Priority"].Value = value;
        }

        // Unknown.
        public byte hti15_Priority
        {
            get => (byte)row["hti15_Priority"].Value;
            set => row["hti15_Priority"].Value = value;
        }

        // Unknown.
        public ushort defSfxMaterial1
        {
            get => (ushort)row["defSfxMaterial1"].Value;
            set => row["defSfxMaterial1"].Value = value;
        }

        // Unknown.
        public ushort defSeMaterial2
        {
            get => (ushort)row["defSeMaterial2"].Value;
            set => row["defSeMaterial2"].Value = value;
        }

        // Unknown.
        public ushort defSfxMaterial2
        {
            get => (ushort)row["defSfxMaterial2"].Value;
            set => row["defSfxMaterial2"].Value = value;
        }

        // Unknown.
        public ushort atkDarkCorrection
        {
            get => (ushort)row["atkDarkCorrection"].Value;
            set => row["atkDarkCorrection"].Value = value;
        }

        // Unknown.
        public ushort atkDark
        {
            get => (ushort)row["atkDark"].Value;
            set => row["atkDark"].Value = value;
        }

        // Unknown.
        public byte isDisableParry
        {
            get => (byte)row["isDisableParry"].Value;
            set => row["isDisableParry"].Value = value;
        }

        // Unknown.
        public byte isDisableBothHandsAtkBonus
        {
            get => (byte)row["isDisableBothHandsAtkBonus"].Value;
            set => row["isDisableBothHandsAtkBonus"].Value = value;
        }

        // Unknown.
        public byte isInvalidatedByNoDamageInAir
        {
            get => (byte)row["isInvalidatedByNoDamageInAir"].Value;
            set => row["isInvalidatedByNoDamageInAir"].Value = value;
        }

        // Unknown.
        public sbyte dmgLevel_vsPlayer
        {
            get => (sbyte)row["dmgLevel_vsPlayer"].Value;
            set => row["dmgLevel_vsPlayer"].Value = value;
        }

        // Unknown.
        public ushort statusAilmentAtkPowerCorrectRate
        {
            get => (ushort)row["statusAilmentAtkPowerCorrectRate"].Value;
            set => row["statusAilmentAtkPowerCorrectRate"].Value = value;
        }

        // Unknown.
        public ushort spEffectAtkPowerCorrectRate_byPoint
        {
            get => (ushort)row["spEffectAtkPowerCorrectRate_byPoint"].Value;
            set => row["spEffectAtkPowerCorrectRate_byPoint"].Value = value;
        }

        // Unknown.
        public ushort spEffectAtkPowerCorrectRate_byRate
        {
            get => (ushort)row["spEffectAtkPowerCorrectRate_byRate"].Value;
            set => row["spEffectAtkPowerCorrectRate_byRate"].Value = value;
        }

        // Unknown.
        public ushort spEffectAtkPowerCorrectRate_byDmg
        {
            get => (ushort)row["spEffectAtkPowerCorrectRate_byDmg"].Value;
            set => row["spEffectAtkPowerCorrectRate_byDmg"].Value = value;
        }

        // Unknown.
        public byte atkBehaviorId_2
        {
            get => (byte)row["atkBehaviorId_2"].Value;
            set => row["atkBehaviorId_2"].Value = value;
        }

        // Unknown.
        public byte throwDamageAttribute
        {
            get => (byte)row["throwDamageAttribute"].Value;
            set => row["throwDamageAttribute"].Value = value;
        }

        // Unknown.
        public ushort statusAilmentAtkPowerCorrectRate_byPoint
        {
            get => (ushort)row["statusAilmentAtkPowerCorrectRate_byPoint"].Value;
            set => row["statusAilmentAtkPowerCorrectRate_byPoint"].Value = value;
        }

        // Unknown.
        public int overwriteAttackElementCorrectId
        {
            get => (int)row["overwriteAttackElementCorrectId"].Value;
            set => row["overwriteAttackElementCorrectId"].Value = value;
        }

        // Unknown.
        public short decalBaseId1
        {
            get => (short)row["decalBaseId1"].Value;
            set => row["decalBaseId1"].Value = value;
        }

        // Unknown.
        public short decalBaseId2
        {
            get => (short)row["decalBaseId2"].Value;
            set => row["decalBaseId2"].Value = value;
        }

        // Unknown.
        public ushort wepRegainHpScale
        {
            get => (ushort)row["wepRegainHpScale"].Value;
            set => row["wepRegainHpScale"].Value = value;
        }

        // Unknown.
        public ushort atkRegainHp
        {
            get => (ushort)row["atkRegainHp"].Value;
            set => row["atkRegainHp"].Value = value;
        }

        // Unknown.
        public float regainableTimeScale
        {
            get => (float)row["regainableTimeScale"].Value;
            set => row["regainableTimeScale"].Value = value;
        }

        // Unknown.
        public float regainableHpRateScale
        {
            get => (float)row["regainableHpRateScale"].Value;
            set => row["regainableHpRateScale"].Value = value;
        }

        // Unknown.
        public sbyte regainableSlotId
        {
            get => (sbyte)row["regainableSlotId"].Value;
            set => row["regainableSlotId"].Value = value;
        }

        // Unknown.
        public byte spAttributeVariationValue
        {
            get => (byte)row["spAttributeVariationValue"].Value;
            set => row["spAttributeVariationValue"].Value = value;
        }

        // Unknown.
        public short parryForwardOffset
        {
            get => (short)row["parryForwardOffset"].Value;
            set => row["parryForwardOffset"].Value = value;
        }

        // Unknown.
        public float atkSuperArmorCorrection
        {
            get => (float)row["atkSuperArmorCorrection"].Value;
            set => row["atkSuperArmorCorrection"].Value = value;
        }

        // Unknown.
        public byte defSfxMaterialVariationValue
        {
            get => (byte)row["defSfxMaterialVariationValue"].Value;
            set => row["defSfxMaterialVariationValue"].Value = value;
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
    public ATK_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public ATK_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
