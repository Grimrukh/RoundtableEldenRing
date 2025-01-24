using SoulsFormats;
             
namespace RoundtableEldenRing.Params.Wrappers;

public class NPC_THINK_PARAM_ST
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
        public int logicId
        {
            get => (int)row["logicId"].Value;
            set => row["logicId"].Value = value;
        }

        // Unknown.
        public int battleGoalID
        {
            get => (int)row["battleGoalID"].Value;
            set => row["battleGoalID"].Value = value;
        }

        // Unknown.
        public ushort searchEye_dist
        {
            get => (ushort)row["searchEye_dist"].Value;
            set => row["searchEye_dist"].Value = value;
        }

        // Unknown.
        public byte searchEye_angY
        {
            get => (byte)row["searchEye_angY"].Value;
            set => row["searchEye_angY"].Value = value;
        }

        // Unknown.
        public byte isNoAvoidHugeEnemy
        {
            get => (byte)row["isNoAvoidHugeEnemy"].Value;
            set => row["isNoAvoidHugeEnemy"].Value = value;
        }

        // Unknown.
        public byte enableWeaponOnOff
        {
            get => (byte)row["enableWeaponOnOff"].Value;
            set => row["enableWeaponOnOff"].Value = value;
        }

        // Unknown.
        public byte targetAILockDmyPoly
        {
            get => (byte)row["targetAILockDmyPoly"].Value;
            set => row["targetAILockDmyPoly"].Value = value;
        }

        // Unknown.
        public int spEffectId_RangedAttack
        {
            get => (int)row["spEffectId_RangedAttack"].Value;
            set => row["spEffectId_RangedAttack"].Value = value;
        }

        // Unknown.
        public float searchTargetLv1ForgetTime
        {
            get => (float)row["searchTargetLv1ForgetTime"].Value;
            set => row["searchTargetLv1ForgetTime"].Value = value;
        }

        // Unknown.
        public float searchTargetLv2ForgetTime
        {
            get => (float)row["searchTargetLv2ForgetTime"].Value;
            set => row["searchTargetLv2ForgetTime"].Value = value;
        }

        // Unknown.
        public float BackHomeLife_OnHitEneWal
        {
            get => (float)row["BackHomeLife_OnHitEneWal"].Value;
            set => row["BackHomeLife_OnHitEneWal"].Value = value;
        }

        // Unknown.
        public float SightTargetForgetTime
        {
            get => (float)row["SightTargetForgetTime"].Value;
            set => row["SightTargetForgetTime"].Value = value;
        }

        // Unknown.
        public int idAttackCannotMove
        {
            get => (int)row["idAttackCannotMove"].Value;
            set => row["idAttackCannotMove"].Value = value;
        }

        // Unknown.
        public float ear_dist
        {
            get => (float)row["ear_dist"].Value;
            set => row["ear_dist"].Value = value;
        }

        // Unknown.
        public int callHelp_ActionAnimId
        {
            get => (int)row["callHelp_ActionAnimId"].Value;
            set => row["callHelp_ActionAnimId"].Value = value;
        }

        // Unknown.
        public int callHelp_CallActionId
        {
            get => (int)row["callHelp_CallActionId"].Value;
            set => row["callHelp_CallActionId"].Value = value;
        }

        // Unknown.
        public ushort eye_dist
        {
            get => (ushort)row["eye_dist"].Value;
            set => row["eye_dist"].Value = value;
        }

        // Unknown.
        public byte isGuard_Act
        {
            get => (byte)row["isGuard_Act"].Value;
            set => row["isGuard_Act"].Value = value;
        }

        // Unknown.
        public ushort ear_soundcut_dist
        {
            get => (ushort)row["ear_soundcut_dist"].Value;
            set => row["ear_soundcut_dist"].Value = value;
        }

        // Unknown.
        public ushort nose_dist
        {
            get => (ushort)row["nose_dist"].Value;
            set => row["nose_dist"].Value = value;
        }

        // Unknown.
        public ushort maxBackhomeDist
        {
            get => (ushort)row["maxBackhomeDist"].Value;
            set => row["maxBackhomeDist"].Value = value;
        }

        // Unknown.
        public ushort backhomeDist
        {
            get => (ushort)row["backhomeDist"].Value;
            set => row["backhomeDist"].Value = value;
        }

        // Unknown.
        public ushort backhomeBattleDist
        {
            get => (ushort)row["backhomeBattleDist"].Value;
            set => row["backhomeBattleDist"].Value = value;
        }

        // Unknown.
        public ushort nonBattleActLife
        {
            get => (ushort)row["nonBattleActLife"].Value;
            set => row["nonBattleActLife"].Value = value;
        }

        // Unknown.
        public ushort BackHome_LookTargetTime
        {
            get => (ushort)row["BackHome_LookTargetTime"].Value;
            set => row["BackHome_LookTargetTime"].Value = value;
        }

        // Unknown.
        public ushort BackHome_LookTargetDist
        {
            get => (ushort)row["BackHome_LookTargetDist"].Value;
            set => row["BackHome_LookTargetDist"].Value = value;
        }

        // Unknown.
        public float SoundTargetForgetTime
        {
            get => (float)row["SoundTargetForgetTime"].Value;
            set => row["SoundTargetForgetTime"].Value = value;
        }

        public ushort BattleStartDist
        {
            get => (ushort)row["BattleStartDist"].Value;
            set => row["BattleStartDist"].Value = value;
        }

        // Unknown.
        public ushort callHelp_MyPeerId
        {
            get => (ushort)row["callHelp_MyPeerId"].Value;
            set => row["callHelp_MyPeerId"].Value = value;
        }

        // Unknown.
        public ushort callHelp_CallPeerId
        {
            get => (ushort)row["callHelp_CallPeerId"].Value;
            set => row["callHelp_CallPeerId"].Value = value;
        }

        // Unknown.
        public ushort targetSys_DmgEffectRate
        {
            get => (ushort)row["targetSys_DmgEffectRate"].Value;
            set => row["targetSys_DmgEffectRate"].Value = value;
        }

        // Unknown.
        public byte TeamAttackEffectivity
        {
            get => (byte)row["TeamAttackEffectivity"].Value;
            set => row["TeamAttackEffectivity"].Value = value;
        }

        // Unknown.
        public byte eye_angX
        {
            get => (byte)row["eye_angX"].Value;
            set => row["eye_angX"].Value = value;
        }

        // Unknown.
        public byte eye_angY
        {
            get => (byte)row["eye_angY"].Value;
            set => row["eye_angY"].Value = value;
        }

        // Unknown.
        public byte disableDark
        {
            get => (byte)row["disableDark"].Value;
            set => row["disableDark"].Value = value;
        }

        // Unknown.
        public byte caravanRole
        {
            get => (byte)row["caravanRole"].Value;
            set => row["caravanRole"].Value = value;
        }

        // Unknown.
        public byte callHelp_CallValidMinDistTarget
        {
            get => (byte)row["callHelp_CallValidMinDistTarget"].Value;
            set => row["callHelp_CallValidMinDistTarget"].Value = value;
        }

        // Unknown.
        public byte callHelp_CallValidRange
        {
            get => (byte)row["callHelp_CallValidRange"].Value;
            set => row["callHelp_CallValidRange"].Value = value;
        }

        // Unknown.
        public byte callHelp_ForgetTimeByArrival
        {
            get => (byte)row["callHelp_ForgetTimeByArrival"].Value;
            set => row["callHelp_ForgetTimeByArrival"].Value = value;
        }

        // Unknown.
        public byte callHelp_MinWaitTime
        {
            get => (byte)row["callHelp_MinWaitTime"].Value;
            set => row["callHelp_MinWaitTime"].Value = value;
        }

        // Unknown.
        public byte callHelp_MaxWaitTime
        {
            get => (byte)row["callHelp_MaxWaitTime"].Value;
            set => row["callHelp_MaxWaitTime"].Value = value;
        }

        // Unknown.
        public byte goalAction_ToCaution
        {
            get => (byte)row["goalAction_ToCaution"].Value;
            set => row["goalAction_ToCaution"].Value = value;
        }

        // Unknown.
        public byte ear_listenLevel
        {
            get => (byte)row["ear_listenLevel"].Value;
            set => row["ear_listenLevel"].Value = value;
        }

        // Unknown.
        public byte callHelp_ReplyBehaviorType
        {
            get => (byte)row["callHelp_ReplyBehaviorType"].Value;
            set => row["callHelp_ReplyBehaviorType"].Value = value;
        }

        // Unknown.
        public byte disablePathMove
        {
            get => (byte)row["disablePathMove"].Value;
            set => row["disablePathMove"].Value = value;
        }

        // Unknown.
        public byte skipArrivalVisibleCheck
        {
            get => (byte)row["skipArrivalVisibleCheck"].Value;
            set => row["skipArrivalVisibleCheck"].Value = value;
        }

        // Unknown.
        public byte thinkAttr_doAdmirer
        {
            get => (byte)row["thinkAttr_doAdmirer"].Value;
            set => row["thinkAttr_doAdmirer"].Value = value;
        }

        // Unknown.
        public byte enableNaviFlg_Edge
        {
            get => (byte)row["enableNaviFlg_Edge"].Value;
            set => row["enableNaviFlg_Edge"].Value = value;
        }

        // Unknown.
        public byte enableNaviFlg_LargeSpace
        {
            get => (byte)row["enableNaviFlg_LargeSpace"].Value;
            set => row["enableNaviFlg_LargeSpace"].Value = value;
        }

        // Unknown.
        public byte enableNaviFlg_Ladder
        {
            get => (byte)row["enableNaviFlg_Ladder"].Value;
            set => row["enableNaviFlg_Ladder"].Value = value;
        }

        // Unknown.
        public byte enableNaviFlg_Hole
        {
            get => (byte)row["enableNaviFlg_Hole"].Value;
            set => row["enableNaviFlg_Hole"].Value = value;
        }

        // Unknown.
        public byte enableNaviFlg_Door
        {
            get => (byte)row["enableNaviFlg_Door"].Value;
            set => row["enableNaviFlg_Door"].Value = value;
        }

        // Unknown.
        public byte enableNaviFlg_InSideWall
        {
            get => (byte)row["enableNaviFlg_InSideWall"].Value;
            set => row["enableNaviFlg_InSideWall"].Value = value;
        }

        // Unknown.
        public byte enableNaviFlg_Lava
        {
            get => (byte)row["enableNaviFlg_Lava"].Value;
            set => row["enableNaviFlg_Lava"].Value = value;
        }

        // Unknown.
        public byte enableNaviFlg_Edge_Ordinary
        {
            get => (byte)row["enableNaviFlg_Edge_Ordinary"].Value;
            set => row["enableNaviFlg_Edge_Ordinary"].Value = value;
        }

        // Unknown.
        public int searchThreshold_Lv0toLv1
        {
            get => (int)row["searchThreshold_Lv0toLv1"].Value;
            set => row["searchThreshold_Lv0toLv1"].Value = value;
        }

        // Unknown.
        public int searchThreshold_Lv1toLv2
        {
            get => (int)row["searchThreshold_Lv1toLv2"].Value;
            set => row["searchThreshold_Lv1toLv2"].Value = value;
        }

        // Unknown.
        public float platoonReplyTime
        {
            get => (float)row["platoonReplyTime"].Value;
            set => row["platoonReplyTime"].Value = value;
        }

        // Unknown.
        public float platoonReplyAddRandomTime
        {
            get => (float)row["platoonReplyAddRandomTime"].Value;
            set => row["platoonReplyAddRandomTime"].Value = value;
        }

        // Unknown.
        public byte searchEye_angX
        {
            get => (byte)row["searchEye_angX"].Value;
            set => row["searchEye_angX"].Value = value;
        }

        // Unknown.
        public byte isUpdateBattleSight
        {
            get => (byte)row["isUpdateBattleSight"].Value;
            set => row["isUpdateBattleSight"].Value = value;
        }

        // Unknown.
        public ushort battleEye_updateDist
        {
            get => (ushort)row["battleEye_updateDist"].Value;
            set => row["battleEye_updateDist"].Value = value;
        }

        // Unknown.
        public byte battleEye_updateAngX
        {
            get => (byte)row["battleEye_updateAngX"].Value;
            set => row["battleEye_updateAngX"].Value = value;
        }

        // Unknown.
        public byte battleEye_updateAngY
        {
            get => (byte)row["battleEye_updateAngY"].Value;
            set => row["battleEye_updateAngY"].Value = value;
        }

        // Unknown.
        public ushort eye_BackOffsetDist
        {
            get => (ushort)row["eye_BackOffsetDist"].Value;
            set => row["eye_BackOffsetDist"].Value = value;
        }

        // Unknown.
        public ushort eye_BeginDist
        {
            get => (ushort)row["eye_BeginDist"].Value;
            set => row["eye_BeginDist"].Value = value;
        }

        // Unknown.
        public byte actTypeOnFailedPath
        {
            get => (byte)row["actTypeOnFailedPath"].Value;
            set => row["actTypeOnFailedPath"].Value = value;
        }

        // Unknown.
        public byte goalAction_ToCautionImportant
        {
            get => (byte)row["goalAction_ToCautionImportant"].Value;
            set => row["goalAction_ToCautionImportant"].Value = value;
        }

        // Unknown.
        public int shiftAnimeId_RangedAttack
        {
            get => (int)row["shiftAnimeId_RangedAttack"].Value;
            set => row["shiftAnimeId_RangedAttack"].Value = value;
        }

        // Unknown.
        public byte actTypeOnNonBtlFailedPath
        {
            get => (byte)row["actTypeOnNonBtlFailedPath"].Value;
            set => row["actTypeOnNonBtlFailedPath"].Value = value;
        }

        // Unknown.
        public byte isBuddyAI
        {
            get => (byte)row["isBuddyAI"].Value;
            set => row["isBuddyAI"].Value = value;
        }

        // Unknown.
        public byte goalAction_ToSearchLv1
        {
            get => (byte)row["goalAction_ToSearchLv1"].Value;
            set => row["goalAction_ToSearchLv1"].Value = value;
        }

        // Unknown.
        public byte goalAction_ToSearchLv2
        {
            get => (byte)row["goalAction_ToSearchLv2"].Value;
            set => row["goalAction_ToSearchLv2"].Value = value;
        }

        // Unknown.
        public byte enableJumpMove
        {
            get => (byte)row["enableJumpMove"].Value;
            set => row["enableJumpMove"].Value = value;
        }

        // Unknown.
        public byte disableLocalSteering
        {
            get => (byte)row["disableLocalSteering"].Value;
            set => row["disableLocalSteering"].Value = value;
        }

        // Unknown.
        public byte goalAction_ToDisappear
        {
            get => (byte)row["goalAction_ToDisappear"].Value;
            set => row["goalAction_ToDisappear"].Value = value;
        }

        // Unknown.
        public byte changeStateAction_ToNormal
        {
            get => (byte)row["changeStateAction_ToNormal"].Value;
            set => row["changeStateAction_ToNormal"].Value = value;
        }

        // Unknown.
        public float MemoryTargetForgetTime
        {
            get => (float)row["MemoryTargetForgetTime"].Value;
            set => row["MemoryTargetForgetTime"].Value = value;
        }

        // Unknown.
        public int rangedAttackId
        {
            get => (int)row["rangedAttackId"].Value;
            set => row["rangedAttackId"].Value = value;
        }

        // Unknown.
        public byte useFall_onNormalCaution
        {
            get => (byte)row["useFall_onNormalCaution"].Value;
            set => row["useFall_onNormalCaution"].Value = value;
        }

        // Unknown.
        public byte useFall_onSearchBattle
        {
            get => (byte)row["useFall_onSearchBattle"].Value;
            set => row["useFall_onSearchBattle"].Value = value;
        }

        // Unknown.
        public byte enableJumpMove_onBattle
        {
            get => (byte)row["enableJumpMove_onBattle"].Value;
            set => row["enableJumpMove_onBattle"].Value = value;
        }

        // Unknown.
        public byte backToHomeStuckAct
        {
            get => (byte)row["backToHomeStuckAct"].Value;
            set => row["backToHomeStuckAct"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId01
        {
            get => (int)row["soundBehaviorId01"].Value;
            set => row["soundBehaviorId01"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId02
        {
            get => (int)row["soundBehaviorId02"].Value;
            set => row["soundBehaviorId02"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId03
        {
            get => (int)row["soundBehaviorId03"].Value;
            set => row["soundBehaviorId03"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId04
        {
            get => (int)row["soundBehaviorId04"].Value;
            set => row["soundBehaviorId04"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId05
        {
            get => (int)row["soundBehaviorId05"].Value;
            set => row["soundBehaviorId05"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId06
        {
            get => (int)row["soundBehaviorId06"].Value;
            set => row["soundBehaviorId06"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId07
        {
            get => (int)row["soundBehaviorId07"].Value;
            set => row["soundBehaviorId07"].Value = value;
        }

        // Unknown.
        public int soundBehaviorId08
        {
            get => (int)row["soundBehaviorId08"].Value;
            set => row["soundBehaviorId08"].Value = value;
        }

        // Unknown.
        public int weaponOffSpecialEffectId
        {
            get => (int)row["weaponOffSpecialEffectId"].Value;
            set => row["weaponOffSpecialEffectId"].Value = value;
        }

        // Unknown.
        public int weaponOnSpecialEffectId
        {
            get => (int)row["weaponOnSpecialEffectId"].Value;
            set => row["weaponOnSpecialEffectId"].Value = value;
        }

        // Unknown.
        public int weaponOffAnimId
        {
            get => (int)row["weaponOffAnimId"].Value;
            set => row["weaponOffAnimId"].Value = value;
        }

        // Unknown.
        public int weaponOnAnimId
        {
            get => (int)row["weaponOnAnimId"].Value;
            set => row["weaponOnAnimId"].Value = value;
        }

        // Unknown.
        public int surpriseAnimId
        {
            get => (int)row["surpriseAnimId"].Value;
            set => row["surpriseAnimId"].Value = value;
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
    public NPC_THINK_PARAM_ST(PARAM param)
    {
        if (param.AppliedParamdef == null)
            throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
        Param = param;   
        Rows = Param.Rows.Select(r => new Row(r)).ToList();
    }
    
    /// <summary>
    /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
    /// </summary>
    public NPC_THINK_PARAM_ST(MemoryPARAM memoryParam)
    {
        Param = null;  // not accessible   
        Rows = memoryParam.Rows.Select(r => new Row(r)).ToList();
    }
    
    public Row? FindRow(int id)
    {
        return Rows.Find(r => r.ID == id);
    }
}
