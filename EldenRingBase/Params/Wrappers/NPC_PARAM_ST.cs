using SoulsFormats;
             
namespace EldenRingBase.Params.Wrappers;

public class NPC_PARAM_ST
{
    public PARAM? Param { get; }
    public List<Row> Rows { get; }
    
    public class Row(PARAM.Row row) : IParamRow
    {
        public PARAM.Row InternalRow => row;
    
        public int ID => row.ID;

        // Unknown.
        public byte disableParam_NT
        {
            get => (byte)row["disableParam_NT"].Value;
            set => row["disableParam_NT"].Value = value;
        }

        // Unknown.
        public int behaviorVariationId
        {
            get => (int)row["behaviorVariationId"].Value;
            set => row["behaviorVariationId"].Value = value;
        }

        // Unknown.
        public int resistCorrectId_poison
        {
            get => (int)row["resistCorrectId_poison"].Value;
            set => row["resistCorrectId_poison"].Value = value;
        }

        // Unknown.
        public int nameId
        {
            get => (int)row["nameId"].Value;
            set => row["nameId"].Value = value;
        }

        // Unknown.
        public float turnVellocity
        {
            get => (float)row["turnVellocity"].Value;
            set => row["turnVellocity"].Value = value;
        }

        // Unknown.
        public float hitHeight
        {
            get => (float)row["hitHeight"].Value;
            set => row["hitHeight"].Value = value;
        }

        // Unknown.
        public float hitRadius
        {
            get => (float)row["hitRadius"].Value;
            set => row["hitRadius"].Value = value;
        }

        // Unknown.
        public uint weight
        {
            get => (uint)row["weight"].Value;
            set => row["weight"].Value = value;
        }

        // Unknown.
        public float hitYOffset
        {
            get => (float)row["hitYOffset"].Value;
            set => row["hitYOffset"].Value = value;
        }

        // Unknown.
        public uint hp
        {
            get => (uint)row["hp"].Value;
            set => row["hp"].Value = value;
        }

        // Unknown.
        public uint mp
        {
            get => (uint)row["mp"].Value;
            set => row["mp"].Value = value;
        }

        // Unknown.
        public uint getSoul
        {
            get => (uint)row["getSoul"].Value;
            set => row["getSoul"].Value = value;
        }

        // Unknown.
        public int itemLotId_enemy
        {
            get => (int)row["itemLotId_enemy"].Value;
            set => row["itemLotId_enemy"].Value = value;
        }

        // Unknown.
        public int itemLotId_map
        {
            get => (int)row["itemLotId_map"].Value;
            set => row["itemLotId_map"].Value = value;
        }

        // Unknown.
        public float maxAnkleRollAngle
        {
            get => (float)row["maxAnkleRollAngle"].Value;
            set => row["maxAnkleRollAngle"].Value = value;
        }

        // Unknown.
        public byte chrHitGroupAndNavimesh
        {
            get => (byte)row["chrHitGroupAndNavimesh"].Value;
            set => row["chrHitGroupAndNavimesh"].Value = value;
        }

        // Unknown.
        public byte faceIconId
        {
            get => (byte)row["faceIconId"].Value;
            set => row["faceIconId"].Value = value;
        }

        // Unknown.
        public short deactivateDist
        {
            get => (short)row["deactivateDist"].Value;
            set => row["deactivateDist"].Value = value;
        }

        // Unknown.
        public uint chrActivateConditionParamId
        {
            get => (uint)row["chrActivateConditionParamId"].Value;
            set => row["chrActivateConditionParamId"].Value = value;
        }

        // Unknown.
        public float footIkErrorHeightLimit
        {
            get => (float)row["footIkErrorHeightLimit"].Value;
            set => row["footIkErrorHeightLimit"].Value = value;
        }

        // Unknown.
        public int humanityLotId
        {
            get => (int)row["humanityLotId"].Value;
            set => row["humanityLotId"].Value = value;
        }

        // Unknown.
        public int spEffectID0
        {
            get => (int)row["spEffectID0"].Value;
            set => row["spEffectID0"].Value = value;
        }

        // Unknown.
        public int spEffectID1
        {
            get => (int)row["spEffectID1"].Value;
            set => row["spEffectID1"].Value = value;
        }

        // Unknown.
        public int spEffectID2
        {
            get => (int)row["spEffectID2"].Value;
            set => row["spEffectID2"].Value = value;
        }

        // Unknown.
        public int spEffectID3
        {
            get => (int)row["spEffectID3"].Value;
            set => row["spEffectID3"].Value = value;
        }

        // Unknown.
        public int spEffectID4
        {
            get => (int)row["spEffectID4"].Value;
            set => row["spEffectID4"].Value = value;
        }

        // Unknown.
        public int spEffectID5
        {
            get => (int)row["spEffectID5"].Value;
            set => row["spEffectID5"].Value = value;
        }

        // Unknown.
        public int spEffectID6
        {
            get => (int)row["spEffectID6"].Value;
            set => row["spEffectID6"].Value = value;
        }

        // Unknown.
        public int spEffectID7
        {
            get => (int)row["spEffectID7"].Value;
            set => row["spEffectID7"].Value = value;
        }

        // Unknown.
        public int GameClearSpEffectID
        {
            get => (int)row["GameClearSpEffectID"].Value;
            set => row["GameClearSpEffectID"].Value = value;
        }

        // Unknown.
        public float physGuardCutRate
        {
            get => (float)row["physGuardCutRate"].Value;
            set => row["physGuardCutRate"].Value = value;
        }

        // Unknown.
        public float magGuardCutRate
        {
            get => (float)row["magGuardCutRate"].Value;
            set => row["magGuardCutRate"].Value = value;
        }

        // Unknown.
        public float fireGuardCutRate
        {
            get => (float)row["fireGuardCutRate"].Value;
            set => row["fireGuardCutRate"].Value = value;
        }

        // Unknown.
        public float thunGuardCutRate
        {
            get => (float)row["thunGuardCutRate"].Value;
            set => row["thunGuardCutRate"].Value = value;
        }

        // Unknown.
        public int animIdOffset
        {
            get => (int)row["animIdOffset"].Value;
            set => row["animIdOffset"].Value = value;
        }

        // Unknown.
        public short lockGazePoint0
        {
            get => (short)row["lockGazePoint0"].Value;
            set => row["lockGazePoint0"].Value = value;
        }

        // Unknown.
        public short lockGazePoint1
        {
            get => (short)row["lockGazePoint1"].Value;
            set => row["lockGazePoint1"].Value = value;
        }

        // Unknown.
        public short lockGazePoint2
        {
            get => (short)row["lockGazePoint2"].Value;
            set => row["lockGazePoint2"].Value = value;
        }

        // Unknown.
        public short lockGazePoint3
        {
            get => (short)row["lockGazePoint3"].Value;
            set => row["lockGazePoint3"].Value = value;
        }

        // Unknown.
        public short lockGazePoint4
        {
            get => (short)row["lockGazePoint4"].Value;
            set => row["lockGazePoint4"].Value = value;
        }

        // Unknown.
        public short lockGazePoint5
        {
            get => (short)row["lockGazePoint5"].Value;
            set => row["lockGazePoint5"].Value = value;
        }

        // Unknown.
        public float networkWarpDist
        {
            get => (float)row["networkWarpDist"].Value;
            set => row["networkWarpDist"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorR1
        {
            get => (int)row["dbgBehaviorR1"].Value;
            set => row["dbgBehaviorR1"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorL1
        {
            get => (int)row["dbgBehaviorL1"].Value;
            set => row["dbgBehaviorL1"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorR2
        {
            get => (int)row["dbgBehaviorR2"].Value;
            set => row["dbgBehaviorR2"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorL2
        {
            get => (int)row["dbgBehaviorL2"].Value;
            set => row["dbgBehaviorL2"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorRL
        {
            get => (int)row["dbgBehaviorRL"].Value;
            set => row["dbgBehaviorRL"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorRR
        {
            get => (int)row["dbgBehaviorRR"].Value;
            set => row["dbgBehaviorRR"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorRD
        {
            get => (int)row["dbgBehaviorRD"].Value;
            set => row["dbgBehaviorRD"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorRU
        {
            get => (int)row["dbgBehaviorRU"].Value;
            set => row["dbgBehaviorRU"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorLL
        {
            get => (int)row["dbgBehaviorLL"].Value;
            set => row["dbgBehaviorLL"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorLR
        {
            get => (int)row["dbgBehaviorLR"].Value;
            set => row["dbgBehaviorLR"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorLD
        {
            get => (int)row["dbgBehaviorLD"].Value;
            set => row["dbgBehaviorLD"].Value = value;
        }

        // Unknown.
        public int dbgBehaviorLU
        {
            get => (int)row["dbgBehaviorLU"].Value;
            set => row["dbgBehaviorLU"].Value = value;
        }

        // Unknown.
        public int animIdOffset2
        {
            get => (int)row["animIdOffset2"].Value;
            set => row["animIdOffset2"].Value = value;
        }

        // Unknown.
        public float partsDamageRate1
        {
            get => (float)row["partsDamageRate1"].Value;
            set => row["partsDamageRate1"].Value = value;
        }

        // Unknown.
        public float partsDamageRate2
        {
            get => (float)row["partsDamageRate2"].Value;
            set => row["partsDamageRate2"].Value = value;
        }

        // Unknown.
        public float partsDamageRate3
        {
            get => (float)row["partsDamageRate3"].Value;
            set => row["partsDamageRate3"].Value = value;
        }

        // Unknown.
        public float partsDamageRate4
        {
            get => (float)row["partsDamageRate4"].Value;
            set => row["partsDamageRate4"].Value = value;
        }

        // Unknown.
        public float partsDamageRate5
        {
            get => (float)row["partsDamageRate5"].Value;
            set => row["partsDamageRate5"].Value = value;
        }

        // Unknown.
        public float partsDamageRate6
        {
            get => (float)row["partsDamageRate6"].Value;
            set => row["partsDamageRate6"].Value = value;
        }

        // Unknown.
        public float partsDamageRate7
        {
            get => (float)row["partsDamageRate7"].Value;
            set => row["partsDamageRate7"].Value = value;
        }

        // Unknown.
        public float partsDamageRate8
        {
            get => (float)row["partsDamageRate8"].Value;
            set => row["partsDamageRate8"].Value = value;
        }

        // Unknown.
        public float weakPartsDamageRate
        {
            get => (float)row["weakPartsDamageRate"].Value;
            set => row["weakPartsDamageRate"].Value = value;
        }

        // Unknown.
        public float superArmorRecoverCorrection
        {
            get => (float)row["superArmorRecoverCorrection"].Value;
            set => row["superArmorRecoverCorrection"].Value = value;
        }

        // Unknown.
        public float superArmorBrakeKnockbackDist
        {
            get => (float)row["superArmorBrakeKnockbackDist"].Value;
            set => row["superArmorBrakeKnockbackDist"].Value = value;
        }

        // Unknown.
        public ushort stamina
        {
            get => (ushort)row["stamina"].Value;
            set => row["stamina"].Value = value;
        }

        // Unknown.
        public ushort staminaRecoverBaseVel
        {
            get => (ushort)row["staminaRecoverBaseVel"].Value;
            set => row["staminaRecoverBaseVel"].Value = value;
        }

        // Unknown.
        public ushort def_phys
        {
            get => (ushort)row["def_phys"].Value;
            set => row["def_phys"].Value = value;
        }

        // Unknown.
        public short def_slash
        {
            get => (short)row["def_slash"].Value;
            set => row["def_slash"].Value = value;
        }

        // Unknown.
        public short def_blow
        {
            get => (short)row["def_blow"].Value;
            set => row["def_blow"].Value = value;
        }

        // Unknown.
        public short def_thrust
        {
            get => (short)row["def_thrust"].Value;
            set => row["def_thrust"].Value = value;
        }

        // Unknown.
        public ushort def_mag
        {
            get => (ushort)row["def_mag"].Value;
            set => row["def_mag"].Value = value;
        }

        // Unknown.
        public ushort def_fire
        {
            get => (ushort)row["def_fire"].Value;
            set => row["def_fire"].Value = value;
        }

        // Unknown.
        public ushort def_thunder
        {
            get => (ushort)row["def_thunder"].Value;
            set => row["def_thunder"].Value = value;
        }

        // Unknown.
        public ushort defFlickPower
        {
            get => (ushort)row["defFlickPower"].Value;
            set => row["defFlickPower"].Value = value;
        }

        // Unknown.
        public ushort resist_poison
        {
            get => (ushort)row["resist_poison"].Value;
            set => row["resist_poison"].Value = value;
        }

        // Unknown.
        public ushort resist_desease
        {
            get => (ushort)row["resist_desease"].Value;
            set => row["resist_desease"].Value = value;
        }

        // Unknown.
        public ushort resist_blood
        {
            get => (ushort)row["resist_blood"].Value;
            set => row["resist_blood"].Value = value;
        }

        // Unknown.
        public ushort resist_curse
        {
            get => (ushort)row["resist_curse"].Value;
            set => row["resist_curse"].Value = value;
        }

        // Unknown.
        public short ghostModelId
        {
            get => (short)row["ghostModelId"].Value;
            set => row["ghostModelId"].Value = value;
        }

        // Unknown.
        public short normalChangeResouceId
        {
            get => (short)row["normalChangeResouceId"].Value;
            set => row["normalChangeResouceId"].Value = value;
        }

        // Unknown.
        public short guardAngle
        {
            get => (short)row["guardAngle"].Value;
            set => row["guardAngle"].Value = value;
        }

        // Unknown.
        public short slashGuardCutRate
        {
            get => (short)row["slashGuardCutRate"].Value;
            set => row["slashGuardCutRate"].Value = value;
        }

        // Unknown.
        public short blowGuardCutRate
        {
            get => (short)row["blowGuardCutRate"].Value;
            set => row["blowGuardCutRate"].Value = value;
        }

        // Unknown.
        public short thrustGuardCutRate
        {
            get => (short)row["thrustGuardCutRate"].Value;
            set => row["thrustGuardCutRate"].Value = value;
        }

        // Unknown.
        public short lockGazePoint6
        {
            get => (short)row["lockGazePoint6"].Value;
            set => row["lockGazePoint6"].Value = value;
        }

        // Unknown.
        public short normalChangeTexChrId
        {
            get => (short)row["normalChangeTexChrId"].Value;
            set => row["normalChangeTexChrId"].Value = value;
        }

        // Unknown.
        public ushort dropType
        {
            get => (ushort)row["dropType"].Value;
            set => row["dropType"].Value = value;
        }

        // Unknown.
        public byte knockbackRate
        {
            get => (byte)row["knockbackRate"].Value;
            set => row["knockbackRate"].Value = value;
        }

        // Unknown.
        public byte knockbackParamId
        {
            get => (byte)row["knockbackParamId"].Value;
            set => row["knockbackParamId"].Value = value;
        }

        // Unknown.
        public byte fallDamageDump
        {
            get => (byte)row["fallDamageDump"].Value;
            set => row["fallDamageDump"].Value = value;
        }

        // Unknown.
        public byte staminaGuardDef
        {
            get => (byte)row["staminaGuardDef"].Value;
            set => row["staminaGuardDef"].Value = value;
        }

        // Unknown.
        public ushort resist_sleep
        {
            get => (ushort)row["resist_sleep"].Value;
            set => row["resist_sleep"].Value = value;
        }

        // Unknown.
        public ushort resist_madness
        {
            get => (ushort)row["resist_madness"].Value;
            set => row["resist_madness"].Value = value;
        }

        // Unknown.
        public sbyte sleepGuardResist
        {
            get => (sbyte)row["sleepGuardResist"].Value;
            set => row["sleepGuardResist"].Value = value;
        }

        // Unknown.
        public sbyte madnessGuardResist
        {
            get => (sbyte)row["madnessGuardResist"].Value;
            set => row["madnessGuardResist"].Value = value;
        }

        // Unknown.
        public short lockGazePoint7
        {
            get => (short)row["lockGazePoint7"].Value;
            set => row["lockGazePoint7"].Value = value;
        }

        // Unknown.
        public byte mpRecoverBaseVel
        {
            get => (byte)row["mpRecoverBaseVel"].Value;
            set => row["mpRecoverBaseVel"].Value = value;
        }

        // Unknown.
        public byte flickDamageCutRate
        {
            get => (byte)row["flickDamageCutRate"].Value;
            set => row["flickDamageCutRate"].Value = value;
        }

        // Unknown.
        public sbyte defaultLodParamId
        {
            get => (sbyte)row["defaultLodParamId"].Value;
            set => row["defaultLodParamId"].Value = value;
        }

        // Unknown.
        public sbyte drawType
        {
            get => (sbyte)row["drawType"].Value;
            set => row["drawType"].Value = value;
        }

        // Unknown.
        public byte npcType
        {
            get => (byte)row["npcType"].Value;
            set => row["npcType"].Value = value;
        }

        // Unknown.
        public byte teamType
        {
            get => (byte)row["teamType"].Value;
            set => row["teamType"].Value = value;
        }

        // Unknown.
        public byte moveType
        {
            get => (byte)row["moveType"].Value;
            set => row["moveType"].Value = value;
        }

        // Unknown.
        public byte lockDist
        {
            get => (byte)row["lockDist"].Value;
            set => row["lockDist"].Value = value;
        }

        // Unknown.
        public ushort materialSe_Weak1
        {
            get => (ushort)row["materialSe_Weak1"].Value;
            set => row["materialSe_Weak1"].Value = value;
        }

        // Unknown.
        public ushort materialSfx_Weak1
        {
            get => (ushort)row["materialSfx_Weak1"].Value;
            set => row["materialSfx_Weak1"].Value = value;
        }

        // Unknown.
        public byte partsDamageType
        {
            get => (byte)row["partsDamageType"].Value;
            set => row["partsDamageType"].Value = value;
        }

        // Unknown.
        public byte vowType
        {
            get => (byte)row["vowType"].Value;
            set => row["vowType"].Value = value;
        }

        // Unknown.
        public sbyte guardLevel
        {
            get => (sbyte)row["guardLevel"].Value;
            set => row["guardLevel"].Value = value;
        }

        // Unknown.
        public byte burnSfxType
        {
            get => (byte)row["burnSfxType"].Value;
            set => row["burnSfxType"].Value = value;
        }

        // Unknown.
        public sbyte poisonGuardResist
        {
            get => (sbyte)row["poisonGuardResist"].Value;
            set => row["poisonGuardResist"].Value = value;
        }

        // Unknown.
        public sbyte diseaseGuardResist
        {
            get => (sbyte)row["diseaseGuardResist"].Value;
            set => row["diseaseGuardResist"].Value = value;
        }

        // Unknown.
        public sbyte bloodGuardResist
        {
            get => (sbyte)row["bloodGuardResist"].Value;
            set => row["bloodGuardResist"].Value = value;
        }

        // Unknown.
        public sbyte curseGuardResist
        {
            get => (sbyte)row["curseGuardResist"].Value;
            set => row["curseGuardResist"].Value = value;
        }

        // Unknown.
        public byte parryAttack
        {
            get => (byte)row["parryAttack"].Value;
            set => row["parryAttack"].Value = value;
        }

        // Unknown.
        public byte parryDefence
        {
            get => (byte)row["parryDefence"].Value;
            set => row["parryDefence"].Value = value;
        }

        // Unknown.
        public byte sfxSize
        {
            get => (byte)row["sfxSize"].Value;
            set => row["sfxSize"].Value = value;
        }

        // Unknown.
        public byte pushOutCamRegionRadius
        {
            get => (byte)row["pushOutCamRegionRadius"].Value;
            set => row["pushOutCamRegionRadius"].Value = value;
        }

        // Unknown.
        public byte hitStopType
        {
            get => (byte)row["hitStopType"].Value;
            set => row["hitStopType"].Value = value;
        }

        // Unknown.
        public byte ladderEndChkOffsetTop
        {
            get => (byte)row["ladderEndChkOffsetTop"].Value;
            set => row["ladderEndChkOffsetTop"].Value = value;
        }

        // Unknown.
        public byte ladderEndChkOffsetLow
        {
            get => (byte)row["ladderEndChkOffsetLow"].Value;
            set => row["ladderEndChkOffsetLow"].Value = value;
        }

        // Unknown.
        public byte useRagdollCamHit
        {
            get => (byte)row["useRagdollCamHit"].Value;
            set => row["useRagdollCamHit"].Value = value;
        }

        // Unknown.
        public byte disableClothRigidHit
        {
            get => (byte)row["disableClothRigidHit"].Value;
            set => row["disableClothRigidHit"].Value = value;
        }

        // Unknown.
        public byte useUndulationAddAnimFB
        {
            get => (byte)row["useUndulationAddAnimFB"].Value;
            set => row["useUndulationAddAnimFB"].Value = value;
        }

        // Unknown.
        public byte isWeakA
        {
            get => (byte)row["isWeakA"].Value;
            set => row["isWeakA"].Value = value;
        }

        // Unknown.
        public byte isGhost
        {
            get => (byte)row["isGhost"].Value;
            set => row["isGhost"].Value = value;
        }

        // Unknown.
        public byte isNoDamageMotion
        {
            get => (byte)row["isNoDamageMotion"].Value;
            set => row["isNoDamageMotion"].Value = value;
        }

        // Unknown.
        public byte isUnduration
        {
            get => (byte)row["isUnduration"].Value;
            set => row["isUnduration"].Value = value;
        }

        // Unknown.
        public byte isChangeWanderGhost
        {
            get => (byte)row["isChangeWanderGhost"].Value;
            set => row["isChangeWanderGhost"].Value = value;
        }

        // Unknown.
        public byte modelDispMask0
        {
            get => (byte)row["modelDispMask0"].Value;
            set => row["modelDispMask0"].Value = value;
        }

        // Unknown.
        public byte modelDispMask1
        {
            get => (byte)row["modelDispMask1"].Value;
            set => row["modelDispMask1"].Value = value;
        }

        // Unknown.
        public byte modelDispMask2
        {
            get => (byte)row["modelDispMask2"].Value;
            set => row["modelDispMask2"].Value = value;
        }

        // Unknown.
        public byte modelDispMask3
        {
            get => (byte)row["modelDispMask3"].Value;
            set => row["modelDispMask3"].Value = value;
        }

        // Unknown.
        public byte modelDispMask4
        {
            get => (byte)row["modelDispMask4"].Value;
            set => row["modelDispMask4"].Value = value;
        }

        // Unknown.
        public byte modelDispMask5
        {
            get => (byte)row["modelDispMask5"].Value;
            set => row["modelDispMask5"].Value = value;
        }

        // Unknown.
        public byte modelDispMask6
        {
            get => (byte)row["modelDispMask6"].Value;
            set => row["modelDispMask6"].Value = value;
        }

        // Unknown.
        public byte modelDispMask7
        {
            get => (byte)row["modelDispMask7"].Value;
            set => row["modelDispMask7"].Value = value;
        }

        // Unknown.
        public byte modelDispMask8
        {
            get => (byte)row["modelDispMask8"].Value;
            set => row["modelDispMask8"].Value = value;
        }

        // Unknown.
        public byte modelDispMask9
        {
            get => (byte)row["modelDispMask9"].Value;
            set => row["modelDispMask9"].Value = value;
        }

        // Unknown.
        public byte modelDispMask10
        {
            get => (byte)row["modelDispMask10"].Value;
            set => row["modelDispMask10"].Value = value;
        }

        // Unknown.
        public byte modelDispMask11
        {
            get => (byte)row["modelDispMask11"].Value;
            set => row["modelDispMask11"].Value = value;
        }

        // Unknown.
        public byte modelDispMask12
        {
            get => (byte)row["modelDispMask12"].Value;
            set => row["modelDispMask12"].Value = value;
        }

        // Unknown.
        public byte modelDispMask13
        {
            get => (byte)row["modelDispMask13"].Value;
            set => row["modelDispMask13"].Value = value;
        }

        // Unknown.
        public byte modelDispMask14
        {
            get => (byte)row["modelDispMask14"].Value;
            set => row["modelDispMask14"].Value = value;
        }

        // Unknown.
        public byte modelDispMask15
        {
            get => (byte)row["modelDispMask15"].Value;
            set => row["modelDispMask15"].Value = value;
        }

        // Unknown.
        public byte isEnableNeckTurn
        {
            get => (byte)row["isEnableNeckTurn"].Value;
            set => row["isEnableNeckTurn"].Value = value;
        }

        // Unknown.
        public byte disableRespawn
        {
            get => (byte)row["disableRespawn"].Value;
            set => row["disableRespawn"].Value = value;
        }

        // Unknown.
        public byte isMoveAnimWait
        {
            get => (byte)row["isMoveAnimWait"].Value;
            set => row["isMoveAnimWait"].Value = value;
        }

        // Unknown.
        public byte isCrowd
        {
            get => (byte)row["isCrowd"].Value;
            set => row["isCrowd"].Value = value;
        }

        // Unknown.
        public byte isWeakB
        {
            get => (byte)row["isWeakB"].Value;
            set => row["isWeakB"].Value = value;
        }

        // Unknown.
        public byte isWeakC
        {
            get => (byte)row["isWeakC"].Value;
            set => row["isWeakC"].Value = value;
        }

        // Unknown.
        public byte isWeakD
        {
            get => (byte)row["isWeakD"].Value;
            set => row["isWeakD"].Value = value;
        }

        // Unknown.
        public byte doesAlwaysUseSpecialTurn
        {
            get => (byte)row["doesAlwaysUseSpecialTurn"].Value;
            set => row["doesAlwaysUseSpecialTurn"].Value = value;
        }

        // Unknown.
        public byte isRideAtkTarget
        {
            get => (byte)row["isRideAtkTarget"].Value;
            set => row["isRideAtkTarget"].Value = value;
        }

        // Unknown.
        public byte isEnableStepDispInterpolate
        {
            get => (byte)row["isEnableStepDispInterpolate"].Value;
            set => row["isEnableStepDispInterpolate"].Value = value;
        }

        // Unknown.
        public byte isStealthTarget
        {
            get => (byte)row["isStealthTarget"].Value;
            set => row["isStealthTarget"].Value = value;
        }

        // Unknown.
        public byte disableInitializeDead
        {
            get => (byte)row["disableInitializeDead"].Value;
            set => row["disableInitializeDead"].Value = value;
        }

        // Unknown.
        public byte isHitRumble
        {
            get => (byte)row["isHitRumble"].Value;
            set => row["isHitRumble"].Value = value;
        }

        // Unknown.
        public byte isSmoothTurn
        {
            get => (byte)row["isSmoothTurn"].Value;
            set => row["isSmoothTurn"].Value = value;
        }

        // Unknown.
        public byte isWeakE
        {
            get => (byte)row["isWeakE"].Value;
            set => row["isWeakE"].Value = value;
        }

        // Unknown.
        public byte isWeakF
        {
            get => (byte)row["isWeakF"].Value;
            set => row["isWeakF"].Value = value;
        }

        // Unknown.
        public byte modelDispMask16
        {
            get => (byte)row["modelDispMask16"].Value;
            set => row["modelDispMask16"].Value = value;
        }

        // Unknown.
        public byte modelDispMask17
        {
            get => (byte)row["modelDispMask17"].Value;
            set => row["modelDispMask17"].Value = value;
        }

        // Unknown.
        public byte modelDispMask18
        {
            get => (byte)row["modelDispMask18"].Value;
            set => row["modelDispMask18"].Value = value;
        }

        // Unknown.
        public byte modelDispMask19
        {
            get => (byte)row["modelDispMask19"].Value;
            set => row["modelDispMask19"].Value = value;
        }

        // Unknown.
        public byte modelDispMask20
        {
            get => (byte)row["modelDispMask20"].Value;
            set => row["modelDispMask20"].Value = value;
        }

        // Unknown.
        public byte modelDispMask21
        {
            get => (byte)row["modelDispMask21"].Value;
            set => row["modelDispMask21"].Value = value;
        }

        // Unknown.
        public byte modelDispMask22
        {
            get => (byte)row["modelDispMask22"].Value;
            set => row["modelDispMask22"].Value = value;
        }

        // Unknown.
        public byte modelDispMask23
        {
            get => (byte)row["modelDispMask23"].Value;
            set => row["modelDispMask23"].Value = value;
        }

        // Unknown.
        public byte modelDispMask24
        {
            get => (byte)row["modelDispMask24"].Value;
            set => row["modelDispMask24"].Value = value;
        }

        // Unknown.
        public byte modelDispMask25
        {
            get => (byte)row["modelDispMask25"].Value;
            set => row["modelDispMask25"].Value = value;
        }

        // Unknown.
        public byte modelDispMask26
        {
            get => (byte)row["modelDispMask26"].Value;
            set => row["modelDispMask26"].Value = value;
        }

        // Unknown.
        public byte modelDispMask27
        {
            get => (byte)row["modelDispMask27"].Value;
            set => row["modelDispMask27"].Value = value;
        }

        // Unknown.
        public byte modelDispMask28
        {
            get => (byte)row["modelDispMask28"].Value;
            set => row["modelDispMask28"].Value = value;
        }

        // Unknown.
        public byte modelDispMask29
        {
            get => (byte)row["modelDispMask29"].Value;
            set => row["modelDispMask29"].Value = value;
        }

        // Unknown.
        public byte modelDispMask30
        {
            get => (byte)row["modelDispMask30"].Value;
            set => row["modelDispMask30"].Value = value;
        }

        // Unknown.
        public byte modelDispMask31
        {
            get => (byte)row["modelDispMask31"].Value;
            set => row["modelDispMask31"].Value = value;
        }

        // Unknown.
        public float itemSearchRadius
        {
            get => (float)row["itemSearchRadius"].Value;
            set => row["itemSearchRadius"].Value = value;
        }

        // Unknown.
        public float chrHitHeight
        {
            get => (float)row["chrHitHeight"].Value;
            set => row["chrHitHeight"].Value = value;
        }

        // Unknown.
        public float chrHitRadius
        {
            get => (float)row["chrHitRadius"].Value;
            set => row["chrHitRadius"].Value = value;
        }

        // Unknown.
        public byte specialTurnType
        {
            get => (byte)row["specialTurnType"].Value;
            set => row["specialTurnType"].Value = value;
        }

        // Unknown.
        public byte isSoulGetByBoss
        {
            get => (byte)row["isSoulGetByBoss"].Value;
            set => row["isSoulGetByBoss"].Value = value;
        }

        // Unknown.
        public byte isBulletOwner_byObject
        {
            get => (byte)row["isBulletOwner_byObject"].Value;
            set => row["isBulletOwner_byObject"].Value = value;
        }

        // Unknown.
        public byte isUseLowHitFootIk
        {
            get => (byte)row["isUseLowHitFootIk"].Value;
            set => row["isUseLowHitFootIk"].Value = value;
        }

        // Unknown.
        public byte isCalculatePvPDamage
        {
            get => (byte)row["isCalculatePvPDamage"].Value;
            set => row["isCalculatePvPDamage"].Value = value;
        }

        // Unknown.
        public byte isHostSyncChr
        {
            get => (byte)row["isHostSyncChr"].Value;
            set => row["isHostSyncChr"].Value = value;
        }

        // Unknown.
        public byte isSkipWeakDamageAnim
        {
            get => (byte)row["isSkipWeakDamageAnim"].Value;
            set => row["isSkipWeakDamageAnim"].Value = value;
        }

        // Unknown.
        public byte isKeepHitOnRide
        {
            get => (byte)row["isKeepHitOnRide"].Value;
            set => row["isKeepHitOnRide"].Value = value;
        }

        // Unknown.
        public byte isSpCollide
        {
            get => (byte)row["isSpCollide"].Value;
            set => row["isSpCollide"].Value = value;
        }

        // Unknown.
        public ushort def_dark
        {
            get => (ushort)row["def_dark"].Value;
            set => row["def_dark"].Value = value;
        }

        // Unknown.
        public uint threatLv
        {
            get => (uint)row["threatLv"].Value;
            set => row["threatLv"].Value = value;
        }

        // Unknown.
        public float specialTurnDistanceThreshold
        {
            get => (float)row["specialTurnDistanceThreshold"].Value;
            set => row["specialTurnDistanceThreshold"].Value = value;
        }

        // Unknown.
        public int autoFootEffectSfxId
        {
            get => (int)row["autoFootEffectSfxId"].Value;
            set => row["autoFootEffectSfxId"].Value = value;
        }

        // Unknown.
        public ushort materialSe1
        {
            get => (ushort)row["materialSe1"].Value;
            set => row["materialSe1"].Value = value;
        }

        // Unknown.
        public ushort materialSfx1
        {
            get => (ushort)row["materialSfx1"].Value;
            set => row["materialSfx1"].Value = value;
        }

        // Unknown.
        public ushort materialSe_Weak2
        {
            get => (ushort)row["materialSe_Weak2"].Value;
            set => row["materialSe_Weak2"].Value = value;
        }

        // Unknown.
        public ushort materialSfx_Weak2
        {
            get => (ushort)row["materialSfx_Weak2"].Value;
            set => row["materialSfx_Weak2"].Value = value;
        }

        // Unknown.
        public ushort materialSe2
        {
            get => (ushort)row["materialSe2"].Value;
            set => row["materialSe2"].Value = value;
        }

        // Unknown.
        public ushort materialSfx2
        {
            get => (ushort)row["materialSfx2"].Value;
            set => row["materialSfx2"].Value = value;
        }

        // Unknown.
        public int spEffectID8
        {
            get => (int)row["spEffectID8"].Value;
            set => row["spEffectID8"].Value = value;
        }

        // Unknown.
        public int spEffectID9
        {
            get => (int)row["spEffectID9"].Value;
            set => row["spEffectID9"].Value = value;
        }

        // Unknown.
        public int spEffectID10
        {
            get => (int)row["spEffectID10"].Value;
            set => row["spEffectID10"].Value = value;
        }

        // Unknown.
        public int spEffectID11
        {
            get => (int)row["spEffectID11"].Value;
            set => row["spEffectID11"].Value = value;
        }

        // Unknown.
        public int spEffectID12
        {
            get => (int)row["spEffectID12"].Value;
            set => row["spEffectID12"].Value = value;
        }

        // Unknown.
        public int spEffectID13
        {
            get => (int)row["spEffectID13"].Value;
            set => row["spEffectID13"].Value = value;
        }

        // Unknown.
        public int spEffectID14
        {
            get => (int)row["spEffectID14"].Value;
            set => row["spEffectID14"].Value = value;
        }

        // Unknown.
        public int spEffectID15
        {
            get => (int)row["spEffectID15"].Value;
            set => row["spEffectID15"].Value = value;
        }

        // Unknown.
        public int autoFootEffectDecalBaseId1
        {
            get => (int)row["autoFootEffectDecalBaseId1"].Value;
            set => row["autoFootEffectDecalBaseId1"].Value = value;
        }

        // Unknown.
        public uint toughness
        {
            get => (uint)row["toughness"].Value;
            set => row["toughness"].Value = value;
        }

        // Unknown.
        public float toughnessRecoverCorrection
        {
            get => (float)row["toughnessRecoverCorrection"].Value;
            set => row["toughnessRecoverCorrection"].Value = value;
        }

        // Unknown.
        public float neutralDamageCutRate
        {
            get => (float)row["neutralDamageCutRate"].Value;
            set => row["neutralDamageCutRate"].Value = value;
        }

        // Unknown.
        public float slashDamageCutRate
        {
            get => (float)row["slashDamageCutRate"].Value;
            set => row["slashDamageCutRate"].Value = value;
        }

        // Unknown.
        public float blowDamageCutRate
        {
            get => (float)row["blowDamageCutRate"].Value;
            set => row["blowDamageCutRate"].Value = value;
        }

        // Unknown.
        public float thrustDamageCutRate
        {
            get => (float)row["thrustDamageCutRate"].Value;
            set => row["thrustDamageCutRate"].Value = value;
        }

        // Unknown.
        public float magicDamageCutRate
        {
            get => (float)row["magicDamageCutRate"].Value;
            set => row["magicDamageCutRate"].Value = value;
        }

        // Unknown.
        public float fireDamageCutRate
        {
            get => (float)row["fireDamageCutRate"].Value;
            set => row["fireDamageCutRate"].Value = value;
        }

        // Unknown.
        public float thunderDamageCutRate
        {
            get => (float)row["thunderDamageCutRate"].Value;
            set => row["thunderDamageCutRate"].Value = value;
        }

        // Unknown.
        public float darkDamageCutRate
        {
            get => (float)row["darkDamageCutRate"].Value;
            set => row["darkDamageCutRate"].Value = value;
        }

        // Unknown.
        public float darkGuardCutRate
        {
            get => (float)row["darkGuardCutRate"].Value;
            set => row["darkGuardCutRate"].Value = value;
        }

        // Unknown.
        public sbyte clothUpdateOffset
        {
            get => (sbyte)row["clothUpdateOffset"].Value;
            set => row["clothUpdateOffset"].Value = value;
        }

        // Unknown.
        public byte npcPlayerWeightType
        {
            get => (byte)row["npcPlayerWeightType"].Value;
            set => row["npcPlayerWeightType"].Value = value;
        }

        // Unknown.
        public short normalChangeModelId
        {
            get => (short)row["normalChangeModelId"].Value;
            set => row["normalChangeModelId"].Value = value;
        }

        // Unknown.
        public short normalChangeAnimChrId
        {
            get => (short)row["normalChangeAnimChrId"].Value;
            set => row["normalChangeAnimChrId"].Value = value;
        }

        // Unknown.
        public ushort paintRenderTargetSize
        {
            get => (ushort)row["paintRenderTargetSize"].Value;
            set => row["paintRenderTargetSize"].Value = value;
        }

        // Unknown.
        public int resistCorrectId_disease
        {
            get => (int)row["resistCorrectId_disease"].Value;
            set => row["resistCorrectId_disease"].Value = value;
        }

        // Unknown.
        public int phantomShaderId
        {
            get => (int)row["phantomShaderId"].Value;
            set => row["phantomShaderId"].Value = value;
        }

        // Unknown.
        public int multiPlayCorrectionParamId
        {
            get => (int)row["multiPlayCorrectionParamId"].Value;
            set => row["multiPlayCorrectionParamId"].Value = value;
        }

        // Unknown.
        public float maxAnklePitchAngle
        {
            get => (float)row["maxAnklePitchAngle"].Value;
            set => row["maxAnklePitchAngle"].Value = value;
        }

        // Unknown.
        public ushort resist_freeze
        {
            get => (ushort)row["resist_freeze"].Value;
            set => row["resist_freeze"].Value = value;
        }

        // Unknown.
        public sbyte freezeGuardResist
        {
            get => (sbyte)row["freezeGuardResist"].Value;
            set => row["freezeGuardResist"].Value = value;
        }

        // Unknown.
        public int lockCameraParamId
        {
            get => (int)row["lockCameraParamId"].Value;
            set => row["lockCameraParamId"].Value = value;
        }

        // Unknown.
        public int spEffectID16
        {
            get => (int)row["spEffectID16"].Value;
            set => row["spEffectID16"].Value = value;
        }

        // Unknown.
        public int spEffectID17
        {
            get => (int)row["spEffectID17"].Value;
            set => row["spEffectID17"].Value = value;
        }

        // Unknown.
        public int spEffectID18
        {
            get => (int)row["spEffectID18"].Value;
            set => row["spEffectID18"].Value = value;
        }

        // Unknown.
        public int spEffectID19
        {
            get => (int)row["spEffectID19"].Value;
            set => row["spEffectID19"].Value = value;
        }

        // Unknown.
        public int spEffectID20
        {
            get => (int)row["spEffectID20"].Value;
            set => row["spEffectID20"].Value = value;
        }

        // Unknown.
        public int spEffectID21
        {
            get => (int)row["spEffectID21"].Value;
            set => row["spEffectID21"].Value = value;
        }

        // Unknown.
        public int spEffectID22
        {
            get => (int)row["spEffectID22"].Value;
            set => row["spEffectID22"].Value = value;
        }

        // Unknown.
        public int spEffectID23
        {
            get => (int)row["spEffectID23"].Value;
            set => row["spEffectID23"].Value = value;
        }

        // Unknown.
        public int spEffectID24
        {
            get => (int)row["spEffectID24"].Value;
            set => row["spEffectID24"].Value = value;
        }

        // Unknown.
        public int spEffectID25
        {
            get => (int)row["spEffectID25"].Value;
            set => row["spEffectID25"].Value = value;
        }

        // Unknown.
        public int spEffectID26
        {
            get => (int)row["spEffectID26"].Value;
            set => row["spEffectID26"].Value = value;
        }

        // Unknown.
        public int spEffectID27
        {
            get => (int)row["spEffectID27"].Value;
            set => row["spEffectID27"].Value = value;
        }

        // Unknown.
        public int spEffectID28
        {
            get => (int)row["spEffectID28"].Value;
            set => row["spEffectID28"].Value = value;
        }

        // Unknown.
        public int spEffectID29
        {
            get => (int)row["spEffectID29"].Value;
            set => row["spEffectID29"].Value = value;
        }

        // Unknown.
        public int spEffectID30
        {
            get => (int)row["spEffectID30"].Value;
            set => row["spEffectID30"].Value = value;
        }

        // Unknown.
        public int spEffectID31
        {
            get => (int)row["spEffectID31"].Value;
            set => row["spEffectID31"].Value = value;
        }

        // Unknown.
        public float disableLockOnAng
        {
            get => (float)row["disableLockOnAng"].Value;
            set => row["disableLockOnAng"].Value = value;
        }

        // Unknown.
        public sbyte clothOffLodLevel
        {
            get => (sbyte)row["clothOffLodLevel"].Value;
            set => row["clothOffLodLevel"].Value = value;
        }

        // Unknown.
        public byte isUseFootIKNormalByUnduration
        {
            get => (byte)row["isUseFootIKNormalByUnduration"].Value;
            set => row["isUseFootIKNormalByUnduration"].Value = value;
        }

        // Unknown.
        public byte attachHitInitializeDead
        {
            get => (byte)row["attachHitInitializeDead"].Value;
            set => row["attachHitInitializeDead"].Value = value;
        }

        // Unknown.
        public byte excludeGroupRewardCheck
        {
            get => (byte)row["excludeGroupRewardCheck"].Value;
            set => row["excludeGroupRewardCheck"].Value = value;
        }

        // Unknown.
        public byte enableAILockDmyPoly_212
        {
            get => (byte)row["enableAILockDmyPoly_212"].Value;
            set => row["enableAILockDmyPoly_212"].Value = value;
        }

        // Unknown.
        public byte enableAILockDmyPoly_213
        {
            get => (byte)row["enableAILockDmyPoly_213"].Value;
            set => row["enableAILockDmyPoly_213"].Value = value;
        }

        // Unknown.
        public byte enableAILockDmyPoly_214
        {
            get => (byte)row["enableAILockDmyPoly_214"].Value;
            set => row["enableAILockDmyPoly_214"].Value = value;
        }

        // Unknown.
        public byte disableActivateOpen_xb1
        {
            get => (byte)row["disableActivateOpen_xb1"].Value;
            set => row["disableActivateOpen_xb1"].Value = value;
        }

        // Unknown.
        public byte disableActivateLegacy_xb1
        {
            get => (byte)row["disableActivateLegacy_xb1"].Value;
            set => row["disableActivateLegacy_xb1"].Value = value;
        }

        // Unknown.
        public short estusFlaskRecoveryParamId
        {
            get => (short)row["estusFlaskRecoveryParamId"].Value;
            set => row["estusFlaskRecoveryParamId"].Value = value;
        }

        // Unknown.
        public int roleNameId
        {
            get => (int)row["roleNameId"].Value;
            set => row["roleNameId"].Value = value;
        }

        // Unknown.
        public ushort estusFlaskLotPoint
        {
            get => (ushort)row["estusFlaskLotPoint"].Value;
            set => row["estusFlaskLotPoint"].Value = value;
        }

        // Unknown.
        public ushort hpEstusFlaskLotPoint
        {
            get => (ushort)row["hpEstusFlaskLotPoint"].Value;
            set => row["hpEstusFlaskLotPoint"].Value = value;
        }

        // Unknown.
        public ushort mpEstusFlaskLotPoint
        {
            get => (ushort)row["mpEstusFlaskLotPoint"].Value;
            set => row["mpEstusFlaskLotPoint"].Value = value;
        }

        // Unknown.
        public ushort estusFlaskRecovery_failedLotPointAdd
        {
            get => (ushort)row["estusFlaskRecovery_failedLotPointAdd"].Value;
            set => row["estusFlaskRecovery_failedLotPointAdd"].Value = value;
        }

        // Unknown.
        public ushort hpEstusFlaskRecovery_failedLotPointAdd
        {
            get => (ushort)row["hpEstusFlaskRecovery_failedLotPointAdd"].Value;
            set => row["hpEstusFlaskRecovery_failedLotPointAdd"].Value = value;
        }

        // Unknown.
        public ushort mpEstusFlaskRecovery_failedLotPointAdd
        {
            get => (ushort)row["mpEstusFlaskRecovery_failedLotPointAdd"].Value;
            set => row["mpEstusFlaskRecovery_failedLotPointAdd"].Value = value;
        }

        // Unknown.
        public int WanderGhostPhantomId
        {
            get => (int)row["WanderGhostPhantomId"].Value;
            set => row["WanderGhostPhantomId"].Value = value;
        }

        // Unknown.
        public float hearingHeadSize
        {
            get => (float)row["hearingHeadSize"].Value;
            set => row["hearingHeadSize"].Value = value;
        }

        // Unknown.
        public short SoundBankId
        {
            get => (short)row["SoundBankId"].Value;
            set => row["SoundBankId"].Value = value;
        }

        // Unknown.
        public byte forwardUndulationLimit
        {
            get => (byte)row["forwardUndulationLimit"].Value;
            set => row["forwardUndulationLimit"].Value = value;
        }

        // Unknown.
        public byte sideUndulationLimit
        {
            get => (byte)row["sideUndulationLimit"].Value;
            set => row["sideUndulationLimit"].Value = value;
        }

        // Unknown.
        public float deactiveMoveSpeed
        {
            get => (float)row["deactiveMoveSpeed"].Value;
            set => row["deactiveMoveSpeed"].Value = value;
        }

        // Unknown.
        public float deactiveMoveDist
        {
            get => (float)row["deactiveMoveDist"].Value;
            set => row["deactiveMoveDist"].Value = value;
        }

        // Unknown.
        public float enableSoundObjDist
        {
            get => (float)row["enableSoundObjDist"].Value;
            set => row["enableSoundObjDist"].Value = value;
        }

        // Unknown.
        public float undulationCorrectGain
        {
            get => (float)row["undulationCorrectGain"].Value;
            set => row["undulationCorrectGain"].Value = value;
        }

        // Unknown.
        public short autoFootEffectDecalBaseId2
        {
            get => (short)row["autoFootEffectDecalBaseId2"].Value;
            set => row["autoFootEffectDecalBaseId2"].Value = value;
        }

        // Unknown.
        public short autoFootEffectDecalBaseId3
        {
            get => (short)row["autoFootEffectDecalBaseId3"].Value;
            set => row["autoFootEffectDecalBaseId3"].Value = value;
        }

        // Unknown.
        public short RetargetReferenceChrId
        {
            get => (short)row["RetargetReferenceChrId"].Value;
            set => row["RetargetReferenceChrId"].Value = value;
        }

        // Unknown.
        public short SfxResBankId
        {
            get => (short)row["SfxResBankId"].Value;
            set => row["SfxResBankId"].Value = value;
        }

        // Unknown.
        public float updateActivatePriolity
        {
            get => (float)row["updateActivatePriolity"].Value;
            set => row["updateActivatePriolity"].Value = value;
        }

        // Unknown.
        public byte chrNavimeshFlag_Alive
        {
            get => (byte)row["chrNavimeshFlag_Alive"].Value;
            set => row["chrNavimeshFlag_Alive"].Value = value;
        }

        // Unknown.
        public byte chrNavimeshFlag_Dead
        {
            get => (byte)row["chrNavimeshFlag_Dead"].Value;
            set => row["chrNavimeshFlag_Dead"].Value = value;
        }

        // Unknown.
        public byte wheelRotType
        {
            get => (byte)row["wheelRotType"].Value;
            set => row["wheelRotType"].Value = value;
        }

        // Unknown.
        public float wheelRotRadius
        {
            get => (float)row["wheelRotRadius"].Value;
            set => row["wheelRotRadius"].Value = value;
        }

        // Unknown.
        public float retargetMoveRate
        {
            get => (float)row["retargetMoveRate"].Value;
            set => row["retargetMoveRate"].Value = value;
        }

        // Unknown.
        public float ladderWarpOffset
        {
            get => (float)row["ladderWarpOffset"].Value;
            set => row["ladderWarpOffset"].Value = value;
        }

        // Unknown.
        public int loadAssetId
        {
            get => (int)row["loadAssetId"].Value;
            set => row["loadAssetId"].Value = value;
        }

        // Unknown.
        public int overlapCameraDmypolyId
        {
            get => (int)row["overlapCameraDmypolyId"].Value;
            set => row["overlapCameraDmypolyId"].Value = value;
        }

        // Unknown.
        public int residentMaterialExParamId00
        {
            get => (int)row["residentMaterialExParamId00"].Value;
            set => row["residentMaterialExParamId00"].Value = value;
        }

        // Unknown.
        public int residentMaterialExParamId01
        {
            get => (int)row["residentMaterialExParamId01"].Value;
            set => row["residentMaterialExParamId01"].Value = value;
        }

        // Unknown.
        public int residentMaterialExParamId02
        {
            get => (int)row["residentMaterialExParamId02"].Value;
            set => row["residentMaterialExParamId02"].Value = value;
        }

        // Unknown.
        public int residentMaterialExParamId03
        {
            get => (int)row["residentMaterialExParamId03"].Value;
            set => row["residentMaterialExParamId03"].Value = value;
        }

        // Unknown.
        public int residentMaterialExParamId04
        {
            get => (int)row["residentMaterialExParamId04"].Value;
            set => row["residentMaterialExParamId04"].Value = value;
        }

        // Unknown.
        public int sleepCollectorItemLotId_enemy
        {
            get => (int)row["sleepCollectorItemLotId_enemy"].Value;
            set => row["sleepCollectorItemLotId_enemy"].Value = value;
        }

        // Unknown.
        public int sleepCollectorItemLotId_map
        {
            get => (int)row["sleepCollectorItemLotId_map"].Value;
            set => row["sleepCollectorItemLotId_map"].Value = value;
        }

        // Unknown.
        public float footIkErrorOnGain
        {
            get => (float)row["footIkErrorOnGain"].Value;
            set => row["footIkErrorOnGain"].Value = value;
        }

        // Unknown.
        public float footIkErrorOffGain
        {
            get => (float)row["footIkErrorOffGain"].Value;
            set => row["footIkErrorOffGain"].Value = value;
        }

        // Unknown.
        public short SoundAddBankId
        {
            get => (short)row["SoundAddBankId"].Value;
            set => row["SoundAddBankId"].Value = value;
        }

        // Unknown.
        public byte materialVariationValue
        {
            get => (byte)row["materialVariationValue"].Value;
            set => row["materialVariationValue"].Value = value;
        }

        // Unknown.
        public byte materialVariationValue_Weak
        {
            get => (byte)row["materialVariationValue_Weak"].Value;
            set => row["materialVariationValue_Weak"].Value = value;
        }

        // Unknown.
        public float superArmorDurability
        {
            get => (float)row["superArmorDurability"].Value;
            set => row["superArmorDurability"].Value = value;
        }

        // Unknown.
        public float saRecoveryRate
        {
            get => (float)row["saRecoveryRate"].Value;
            set => row["saRecoveryRate"].Value = value;
        }

        // Unknown.
        public float saGuardCutRate
        {
            get => (float)row["saGuardCutRate"].Value;
            set => row["saGuardCutRate"].Value = value;
        }

        // Unknown.
        public int resistCorrectId_blood
        {
            get => (int)row["resistCorrectId_blood"].Value;
            set => row["resistCorrectId_blood"].Value = value;
        }

        // Unknown.
        public int resistCorrectId_curse
        {
            get => (int)row["resistCorrectId_curse"].Value;
            set => row["resistCorrectId_curse"].Value = value;
        }

        // Unknown.
        public int resistCorrectId_freeze
        {
            get => (int)row["resistCorrectId_freeze"].Value;
            set => row["resistCorrectId_freeze"].Value = value;
        }

        // Unknown.
        public int resistCorrectId_sleep
        {
            get => (int)row["resistCorrectId_sleep"].Value;
            set => row["resistCorrectId_sleep"].Value = value;
        }

        // Unknown.
        public int resistCorrectId_madness
        {
            get => (int)row["resistCorrectId_madness"].Value;
            set => row["resistCorrectId_madness"].Value = value;
        }

        // Unknown.
        public uint chrDeadTutorialFlagId
        {
            get => (uint)row["chrDeadTutorialFlagId"].Value;
            set => row["chrDeadTutorialFlagId"].Value = value;
        }

        // Unknown.
        public float stepDispInterpolateTime
        {
            get => (float)row["stepDispInterpolateTime"].Value;
            set => row["stepDispInterpolateTime"].Value = value;
        }

        // Unknown.
        public float stepDispInterpolateTriggerValue
        {
            get => (float)row["stepDispInterpolateTriggerValue"].Value;
            set => row["stepDispInterpolateTriggerValue"].Value = value;
        }

        // Unknown.
        public float lockScoreOffset
        {
            get => (float)row["lockScoreOffset"].Value;
            set => row["lockScoreOffset"].Value = value;
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
    public NPC_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public NPC_PARAM_ST(ParamInMemory param)
    {
        Param = null;  // not accessible   
        Rows = param.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
