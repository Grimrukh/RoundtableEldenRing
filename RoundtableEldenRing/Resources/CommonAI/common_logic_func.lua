function COMMON_Initialize(arg0)
    local local0 = true
    if not not arg0:IsBattleState() or not not arg0:IsCautionState() or not not arg0:IsSearchHighState() or not not arg0:IsSearchLowState() or arg0:IsMemoryState() then
        local0 = false
    end
    COMMON_SoundBehavior_FlagInitialize(arg0)
    COMMON_PatrolBehavior_FlagInitialize(arg0)
    if arg0:IsChangeState() and local0 == true then
        arg0:SetStringIndexedNumber("COMMON_WAA__isPointCreated", 0)
    end
    arg0:SetStringIndexedNumber("NeglectTarget", 0)
    arg0:SetStringIndexedNumber("IsEnableFadeWarp_OnFailedPath", 0)
    if arg0:GetTimer(15) <= 0 then
        arg0:SetNumber(15, 0)
    end
    if local0 == true then
        arg0:SetStringIndexedNumber("DisableFearOfFire", 0)
    end
    if arg0:GetStringIndexedNumber("IsIgnore_Sideway_onFailedPath") == 1 then
        if arg0:IsBattleState() then
            if 8 <= arg0:GetDist(TARGET_ENE_0) then
                arg0:SetStringIndexedNumber("IsIgnore_Sideway_onFailedPath", 0)
            end
        else
            arg0:SetStringIndexedNumber("IsIgnore_Sideway_onFailedPath", 0)
        end
    end
    if 1 <= arg0:GetStringIndexedNumber("RepCount_Disable_FailedPath") then
        arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", arg0:GetStringIndexedNumber("RepCount_Disable_FailedPath") - 1)
    else
        arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", 0)
    end
    if not not arg0:IsOmissionLevel30() or local0 == false then
        arg0:ClearMoveToSomewhereSmoothMemory()
    end
    return false
end

function COMMON_EasySetup_Initial(arg0)
    if arg0:IsLadderAct(TARGET_SELF) then
        arg0:AddTopGoal(GOAL_COMMON_LadderMove, -1, 3000, TARGET_SELF, arg0:GetLadderDirMove(TARGET_SELF))
        return true
    elseif arg0:HasSpecialEffectId(TARGET_SELF, 5019) then
        arg0:SetAIFixedMoveTargetSpecifyAngle(TARGET_SELF, 180, 3, AI_SPA_DIR_TYPE_TargetF)
        arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, arg0:GetRandam_Float(0.5, 4), POINT_AI_FIXED_POS, 0, TARGET_SELF, true, -1)
        return true
    elseif arg0:IsAiJumping() then
        arg0:AddTopGoal(GOAL_COMMON_JumpEndWait, 10)
        return true
    elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_ANIME_COLLECTSLEEPING) then
        arg0:AddTopGoal(GOAL_COMMON_Wait, 2, TARGET_SELF, 0, 0, 0)
        return true
    elseif arg0:IsRiding(TARGET_SELF) == false then
        if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_ANIME_SLEEPING) == false then
            if arg0:HasSpecialEffectAttribute(TARGET_SELF, SP_EFFECT_TYPE_SLEEP) and arg0:HasSpecialEffectId(TARGET_SELF, 5851) == false and arg0:HasSpecialEffectId(TARGET_SELF, 5852) == false and arg0:HasSpecialEffectId(TARGET_SELF, 5853) == false then
                arg0:AddTopGoal(GOAL_COMMON_Fall_Asleep, 10, true)
                return true
            end
        elseif arg0:HasSpecialEffectAttribute(TARGET_SELF, SP_EFFECT_TYPE_SLEEP) == true then
            arg0:AddTopGoal(GOAL_COMMON_Fall_Asleep, 10, true)
            return true
        end
    elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_FACILITY_RIDE) == true and arg0:HasSpecialEffectAttribute(TARGET_SELF, SP_EFFECT_TYPE_SLEEP) == true then
        arg0:AddTopGoal(GOAL_COMMON_Dismount, 10)
        return true
    end
    if arg0:IsRiding(TARGET_SELF) == false and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_ANIME_SLEEPING) == true then
        if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP) and (not not IsTargetTimeZone(arg0, PLAN_TIME_TYPE_NIGHT) or IsTargetTimeZone(arg0, PLAN_TIME_TYPE_MIDNIGHT)) and (arg0:GetCurrTargetState() == AI_TARGET_STATE__NONE or arg0:GetCurrTargetState() == AI_TARGET_STATE__AWARE) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_GUARD) == false then
            arg0:AddTopGoal(GOAL_COMMON_Fall_Asleep, 10, false)
            return true
        elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_MORNING) and (not not IsTargetTimeZone(arg0, PLAN_TIME_TYPE_MORNING) or IsTargetTimeZone(arg0, PLAN_TIME_TYPE_DAYTIME)) and (arg0:GetCurrTargetState() == AI_TARGET_STATE__NONE or arg0:GetCurrTargetState() == AI_TARGET_STATE__AWARE) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_GUARD) == false then
            arg0:AddTopGoal(GOAL_COMMON_Fall_Asleep, 10, false)
            return true
        elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_DAYTIME) and (not not IsTargetTimeZone(arg0, PLAN_TIME_TYPE_MORNING) or not not IsTargetTimeZone(arg0, PLAN_TIME_TYPE_DAYTIME) or IsTargetTimeZone(arg0, PLAN_TIME_TYPE_EVENING)) and (arg0:GetCurrTargetState() == AI_TARGET_STATE__NONE or arg0:GetCurrTargetState() == AI_TARGET_STATE__AWARE) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_GUARD) == false then
            arg0:AddTopGoal(GOAL_COMMON_Fall_Asleep, 10, false)
            return true
        else
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, PLAN_ANIMEID_SLEEP_END, TARGET_ENE_0, 9999, 0, 0, 0, 0)
            return true
        end
    elseif arg0:IsRiding(TARGET_SELF) == false then
        local local0 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__surpriseAnimId)
        if 0 < local0 and arg0:IsChangeState() == true and arg0:GetPrevTargetState() == AI_TARGET_STATE__NONE and arg0:GetCurrTargetState() == AI_TARGET_STATE__BATTLE then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 1, local0, TARGET_ENE_0, 9999, 0, 0, 0, 0)
            return true
        end
    end
    if arg0:IsRiding(TARGET_SELF) == false and 0 < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__enableWeaponOnOff) then
        if arg0:HasSpecialEffectId(TARGET_SELF, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOnSpecialEffectId)) == true then
            if arg0:IsBattleState() == false and arg0:IsCautionState() == false and arg0:IsSearchHighState() == false and arg0:IsSearchLowState() == false and arg0:IsMemoryState() == false then
                arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOffAnimId), TARGET_SELF, 9999, 0, 0, 0, 0)
                return true
            end
        elseif arg0:HasSpecialEffectId(TARGET_SELF, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOffSpecialEffectId)) == true and (arg0:IsBattleState() == true or arg0:IsCautionState() == true or arg0:IsSearchHighState() == true or arg0:IsSearchLowState() == true or arg0:IsMemoryState() == true) then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOnAnimId), TARGET_SELF, 9999, 0, 0, 0, 0)
            return true
        end
    end
    if arg0:IsRiding(TARGET_SELF) == false and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_ANIME_SLEEPING) == false then
        if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP) and (not not IsTargetTimeZone(arg0, PLAN_TIME_TYPE_NIGHT) or IsTargetTimeZone(arg0, PLAN_TIME_TYPE_MIDNIGHT)) and (arg0:GetCurrTargetState() == AI_TARGET_STATE__NONE or arg0:GetCurrTargetState() == AI_TARGET_STATE__AWARE) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_GUARD) == false then
            arg0:AddTopGoal(GOAL_COMMON_Fall_Asleep, 10, false)
            return true
        elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_MORNING) and (not not IsTargetTimeZone(arg0, PLAN_TIME_TYPE_MORNING) or IsTargetTimeZone(arg0, PLAN_TIME_TYPE_DAYTIME)) and (arg0:GetCurrTargetState() == AI_TARGET_STATE__NONE or arg0:GetCurrTargetState() == AI_TARGET_STATE__AWARE) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_GUARD) == false then
            arg0:AddTopGoal(GOAL_COMMON_Fall_Asleep, 10, false)
            return true
        elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_DAYTIME) and (not not IsTargetTimeZone(arg0, PLAN_TIME_TYPE_MORNING) or not not IsTargetTimeZone(arg0, PLAN_TIME_TYPE_DAYTIME) or IsTargetTimeZone(arg0, PLAN_TIME_TYPE_EVENING)) and (arg0:GetCurrTargetState() == AI_TARGET_STATE__NONE or arg0:GetCurrTargetState() == AI_TARGET_STATE__AWARE) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_GUARD) == false then
            arg0:AddTopGoal(GOAL_COMMON_Fall_Asleep, 10, false)
            return true
        end
    end
    if arg0:IsRiding(TARGET_SELF) == true and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_FACILITY_RIDE) and arg0:GetTimer(12) <= 0 then
        if arg0:IsBattleState() == true then
            local local0 = arg0:GetDist(TARGET_ENE_0)
            if arg0:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_B, 180, 180, 999) then
                arg0:AddTopGoal(GOAL_COMMON_Dismount, 10)
                return true
            elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_FLAMETHROWER_RIDE) then
                if local0 <= 1.5 and arg0:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 20, 180, 99) == false then
                    arg0:AddTopGoal(GOAL_COMMON_Dismount, 10)
                    return true
                end
            elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_L_BARISTA_RIDE) then
                if local0 <= 3 then
                    arg0:AddTopGoal(GOAL_COMMON_Dismount, 10)
                    return true
                end
            elseif local0 <= 3 and arg0:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 20, 180, 99) == false then
                arg0:AddTopGoal(GOAL_COMMON_Dismount, 10)
                return true
            end
        elseif (arg0:IsCautionState() == true or arg0:IsSearchHighState() == true or arg0:IsSearchLowState() == true) and arg0:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_B, 180, 180, 6) then
            arg0:AddTopGoal(GOAL_COMMON_Dismount, 10)
            return true
        end
    end
    return false
end

function COMMON_EasySetup3(arg0)
    COMMON_EzSetup(arg0)
    return 
end

function COMMON_EzSetup(arg0)
    if arg0:GetLatestSoundTargetRank() == AI_SOUND_RANK__BEHAVIOR and COMMON_SoundBehavior(arg0, arg0:GetLatestSoundBehaviorID()) ~= false then
        return true
    elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_DECLARE) == true then
        _COMMON_SetBuddyBattleActLogic(arg0)
    else
        _COMMON_SetBattleActLogic(arg0)
    end
    return 
end

function _COMMON_SetBattleActLogic(arg0)
    local local0 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backToHomeStuckAct)
    local local1 = 1
    local local2 = arg0:IsSearchTarget(TARGET_ENE_0)
    local local3 = arg0:GetMovePointEffectRange()
    local local4 = TARGET_ENE_0
    local local5 = arg0:GetDist(TARGET_ENE_0)
    if not not arg0:IsSearchHighState() or arg0:IsSearchLowState() then
        local4 = TARGET_SEARCH
        local5 = arg0:GetDist(TARGET_SEARCH)
    end
    if local2 == true and arg0:HasSpecialEffectId(TARGET_ENE_0, 13945) == true then
        arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 2, TARGET_HOSTPLAYER, 10, TARGET_SELF, false, -1)
        return true
    elseif arg0:GetFlyRouteState() ~= AI_FLY_ROUTE_STATE_NOT_USE_FLY_ROUTE then
        if arg0:IsBattleState() and arg0:GetFlyRouteState() == AI_FLY_ROUTE_STATE_ON_GROUND then
            _COMMON_AddBattleGoal(arg0)
        else
            _COMMON_AddNonBattleGoal(arg0, 30, 0, false)
        end
    elseif arg0:TeamHelp_IsValidReply() then
        arg0:AddTopGoal(GOAL_COMMON_TeamReplyHelp, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__callHelp_ForgetTimeByArrival))
        return true
    elseif arg0:IsForceBattleGoal() then
        arg0:ClearForceBattleGoal()
        arg0:ReqPlatoonState(PLATOON_STATE_Battle)
        _COMMON_AddBattleGoal(arg0)
    else
        if local2 == true or not not arg0:IsSearchLowState() or arg0:IsSearchHighState() then
            if arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__maxBackhomeDist) < local3 then
                if local0 == local1 then
                    local local6 = arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhereSmooth, 1.5, POINT_INITIAL, AI_DIR_TYPE_CENTER, 0, TARGET_SELF, true)
                    local6:SetLifeEndSuccess(true)
                    arg0:AddTopGoal(GOAL_COMMON_FadeWarpToInitPos, 10, 2, 4)
                    arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", 1)
                    return true
                elseif local5 < 2 then
                    _COMMON_AddBattleGoal(arg0)
                    return true
                else
                    _COMMON_AddNonBattleGoal(arg0, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__nonBattleActLife), 2, false)
                    return true
                end
            elseif arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backhomeDist) < local3 then
                if local5 < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backhomeBattleDist) then
                    arg0:ReqPlatoonState(PLATOON_STATE_Battle)
                    _COMMON_AddBattleGoal(arg0)
                    return true
                end
                local local6 = arg0:GetActTypeOnFailedPathEnd()
                local local7 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__failedPath_AttackId)
                local local8 = 0
                local local9 = false
                if arg0:IsValidPlatoon() == true and arg0:IsPlatoonLeader() == false then
                    local local10 = arg0:GetPlatoonCommand()
                    local local11 = local10:GetCommandNo()
                    if local11 == PLAN_PLATOON_COMMAND__MOVE or local11 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR or local11 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR_RESET or local11 == PLAN_PLATOON_COMMAND__DEF or local11 == PLAN_PLATOON_COMMAND__SCOUT_MOVE then
                        local9 = true
                    end
                end
                if local9 == true then
                    local8 = arg0:GetDistAtoB(local4, TARGET_TEAM_FORMATION)
                elseif 0 <= arg0:GetMovePointNumber() then
                    local8 = arg0:GetDistAtoB(local4, POINT_MOVE_POINT)
                else
                    local8 = arg0:GetDistAtoB(local4, POINT_INITIAL)
                end
                if arg0:GetMovePointEffectRange() < local8 then
                    _COMMON_AddReturnLimitGoal(arg0)
                    return true
                else
                    _COMMON_AddBattleGoal(arg0)
                    return true
                end
            else
                _COMMON_AddBattleGoal(arg0)
                return true
            end
        elseif local0 == local1 then
            arg0:SetStringIndexedNumber("IsEnableFadeWarp_OnFailedPath", 1)
        end
        _COMMON_AddNonBattleGoal(arg0, 30, -1, true)
        return true
    end
    return false
end

function _COMMON_SetBuddyBattleActLogic(arg0)
    local local0 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__maxBackhomeDist)
    local local1 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backhomeDist)
    local local2 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__nonBattleActLife)
    local local3 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__callHelp_ForgetTimeByArrival)
    local local4 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__IsGuard_Act)
    local local5 = arg0:GetMovePointEffectRange()
    local local6 = arg0:GetDist(TARGET_HOSTPLAYER)
    local local7 = 23
    local local8 = false
    local local9 = false
    local local10 = -1
    if 0 < local4 then
        local10 = 9910
    end
    if arg0:IsSearchTarget(TARGET_ENE_0) == true or not not arg0:IsSearchHighState() or arg0:IsSearchLowState() then
        local8 = true
    end
    if local8 == true and (arg0:HasSpecialEffectId(TARGET_ENE_0, 297800) == true or arg0:HasSpecialEffectId(TARGET_ENE_0, 297810) == true) then
        local8 = false
    end
    if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_DECLARE) == true and 0 <= arg0:GetBuddyActiveRange() then
        local1 = arg0:GetBuddyActiveRange() + 10
        local0 = arg0:GetBuddyActiveRange() + 30
    end
    if arg0:GetBuddyFollowType() == PLAN_BUDDYFOLLOWTYPE_FOLLOW and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_AGGRESSIVE) == false and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_AGGRESSIVE_DEMIHUMAN) == false then
        local9 = true
    end
    if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_NO_FOLLOW) then
        if local8 == true then
            _COMMON_AddBattleGoal(arg0)
        else
            _COMMON_AddNonBattleGoal(arg0, 30, -1, true)
            return true
        end
    elseif local0 < local5 then
        arg0:AddTopGoal(GOAL_COMMON_BackToHome, 2, 0, false, 0, 0, TARGET_SELF)
        return true
    elseif local1 < local5 then
        local local11 = arg0:GetDistAtoB(TARGET_HOSTPLAYER, POINT_INITIAL)
        if local7 <= local6 and local11 < arg0:GetMovePointEffectRange() and local9 == true then
            arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 10, TARGET_HOSTPLAYER, local7 - 3, TARGET_SELF, false, -1)
            return true
        elseif local8 == true then
            if arg0:GetDist(TARGET_ENE_0) < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backhomeBattleDist) then
                _COMMON_AddBattleGoal(arg0)
                return true
            elseif arg0:GetDistAtoB(TARGET_ENE_0, POINT_INITIAL) < arg0:GetMovePointEffectRange() then
                _COMMON_AddBattleGoal(arg0)
                return true
            else
                _COMMON_AddReturnLimitGoal(arg0)
                return true
            end
        elseif local11 < arg0:GetMovePointEffectRange() then
            _COMMON_AddNonBattleGoal(arg0, 30, -1, true)
            return true
        else
            arg0:AddTopGoal(GOAL_COMMON_Wait, 2, TARGET_HOSTPLAYER)
            return true
        end
    elseif local8 == true then
        if local9 == false then
            _COMMON_AddBattleGoal(arg0)
            return true
        elseif local7 <= local6 then
            arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 10, TARGET_HOSTPLAYER, local7 - 3, TARGET_SELF, false, -1)
            return true
        end
        local local11 = true
        local local12 = 5
        if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_INTERCEPT_LONGRANGE) ~= true and local7 + local12 < arg0:GetDistAtoB(TARGET_HOSTPLAYER, TARGET_ENE_0) then
            local11 = false
        end
        if local11 == true then
            _COMMON_AddBattleGoal(arg0)
            return true
        end
        local local13 = 3
        local local14 = arg0:IsExistMeshOnLine(TARGET_SELF, AI_DIR_TYPE_R, local13)
        local local15 = arg0:IsExistMeshOnLine(TARGET_SELF, AI_DIR_TYPE_L, local13)
        local local16 = 0
        if local14 == false and local15 == false then
            arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, arg0:GetRandam_Float(2, 4), TARGET_HOSTPLAYER, 2, TARGET_ENE_0, true, local10)
        else
            if local14 == true and local15 == true then
                local16 = arg0:GetRandam_Int(0, 1)
            elseif local14 == true then
                local16 = 1
            else
                local16 = 0
            end
            arg0:AddTopGoal(GOAL_COMMON_SidewayMove, arg0:GetRandam_Float(2, 3), TARGET_ENE_0, local16, arg0:GetRandam_Int(30, 45), true, true, local10, GUARD_GOAL_DESIRE_RET_Failed, true)
            if 0 < local4 then
                arg0:AddTopGoal(GOAL_COMMON_Guard, arg0:GetRandam_Float(0.7, 1.5), local10, TARGET_ENE_0, GUARD_GOAL_DESIRE_RET_Failed, false)
            else
                arg0:AddTopGoal(GOAL_COMMON_Stay, arg0:GetRandam_Float(0.7, 1.5), local12, TARGET_ENE_0)
            end
            return true
        end
    else
        _COMMON_AddNonBattleGoal(arg0, 30, -1, true)
        return true
    end
    return true
end

function _COMMON_AddReturnLimitGoal(arg0)
    if arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backToHomeStuckAct) == 1 then
        arg0:SetStringIndexedNumber("IsEnableFadeWarp_OnFailedPath", 1)
    end
    local local0 = arg0:GetActTypeOnFailedPathEnd()
    local local1 = -1
    if 0 < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__IsGuard_Act) then
        local1 = 9910
    end
    if arg0:HasSpecialEffectId(TARGET_SELF, 13799) then
        local local2 = POINT_INITIAL
        local local3 = false
        if arg0:IsValidPlatoon() == true and arg0:IsPlatoonLeader() == false then
            local local4 = arg0:GetPlatoonCommand()
            local local5 = local4:GetCommandNo()
            if local5 == PLAN_PLATOON_COMMAND__MOVE or local5 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR or local5 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR_RESET or local5 == PLAN_PLATOON_COMMAND__DEF or local5 == PLAN_PLATOON_COMMAND__SCOUT_MOVE then
                local3 = true
            end
        end
        if local3 == true then
            local2 = TARGET_TEAM_FORMATION
        elseif 0 <= arg0:GetMovePointNumber() then
            local2 = POINT_MOVE_POINT
        end
        arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 45, local2, 10, TARGET_SELF, false, -1, 0, 0)
        arg0:AddTopGoal(GOAL_COMMON_Wait, 2, TARGET_ENE_0)
        return true
    elseif 0 == local0 then
        arg0:AddTopGoal(GOAL_COMMON_BackToHome, 10, 0, false, 0, 0, TARGET_ENE_0)
    elseif 1 == local0 then
        arg0:AddTopGoal(GOAL_COMMON_BackToHome, 10, 0, false, 0, 0, TARGET_ENE_0)
    elseif 2 == local0 then
        arg0:AddTopGoal(GOAL_COMMON_SideWay_On_FailedPath, 30, 1, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__rangedAttackId), 10, 8, 8, local1, true)
    elseif 3 == local0 then
        arg0:AddTopGoal(GOAL_COMMON_SideWay_On_FailedPath, 30, 1, -1, 3, 8, 8, local1, true)
    end
    return true
end

function _COMMON_AddBattleGoal(arg0)
    local local0 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__battleGoalID)
    local local1 = arg0:GetPrevTargetState()
    local local2 = 0
    if arg0:HasSpecialEffectId(TARGET_SELF, 5015) then
        arg0:AddTopGoal(local0, -1)
    elseif arg0:IsBattleState() then
        arg0:ReqPlatoonState(PLATOON_STATE_Battle)
        local local3 = nil
        if arg0:HasSpecialEffectId(TARGET_SELF, 5060) == true and arg0:HasSpecialEffectId(TARGET_SELF, 5061) == false then
            arg0:Replaning()
        elseif arg0:IsValidPlatoon() == true then
            local local4 = arg0:GetPlatoonCommand()
            local local5 = local4:GetCommandNo()
            local local6 = arg0:GetDist(TARGET_TEAM_FORMATION)
            if local5 == PLAN_PLATOON_COMMAND__ATK then
                local3 = arg0:AddTopGoal(local0, -1)
            elseif local5 == PLAN_PLATOON_COMMAND__DEF then
                _COMMON_AddNonBattleGoal(arg0, -1, -1, true)
            elseif local5 == PLAN_PLATOON_COMMAND__RUN then
                if arg0:GetDist(TARGET_ENE_0) <= 4 then
                    local3 = arg0:AddTopGoal(local0, -1)
                else
                    arg0:AddTopGoal(GOAL_COMMON_LeaveTargetToPathEnd, -1, TARGET_TEAM_LEADER, 80, TARGET_SELF, false, -1, GOAL_RESULT_Continue, false, 2)
                end
            elseif local5 == PLAN_PLATOON_COMMAND__STOP then
                local3 = arg0:AddTopGoal(local0, -1)
            else
                local3 = arg0:AddTopGoal(local0, -1)
            end
        else
            local3 = arg0:AddTopGoal(local0, -1)
        end
        if local3 then
            local3:SetManagementGoal()
        end
    elseif arg0:IsCautionState() then
        arg0:ReqPlatoonState(PLATOON_STATE_Caution)
        _COMMON_AddCautionAndFindGoal(arg0, 1)
    elseif arg0:IsSearchHighState() then
        _COMMON_AddCautionAndFindGoal(arg0, 4)
    elseif arg0:IsSearchLowState() then
        _COMMON_AddCautionAndFindGoal(arg0, 3)
    elseif arg0:IsMemoryState() then
        _COMMON_AddCautionAndFindGoal(arg0, 0)
    else
        _COMMON_AddNonBattleGoal(arg0, -1, -1, true)
    end
    return 
end

function _COMMON_AddChangeStateActionGoal(arg0, arg1)
    local local0 = 0
    local local1 = 0
    local local2 = TARGET_NONE
    local local3 = 1810
    local local4 = arg0:GetRandam_Int(1, 100)
    local local5 = arg0:GetDist(TARGET_ENE_0)
    if arg1 == 0 then
        local1 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__changeStateAction_ToNormal)
        local2 = POINT_INITIAL
    else
        local1 = 0
        local2 = TARGET_ENE_0
    end
    if local1 == 1 then
        if 10 <= local5 or local5 == -1 then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, local3, local2, DIST_NONE, 0, -1)
        else
            arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, local2)
        end
    elseif local1 == 2 then
        if 10 <= local5 or local5 == -1 then
            arg0:AddTopGoal(GOAL_COMMON_Turn, 3, local2)
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, local3, local2, DIST_NONE, 0, -1)
        else
            arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, local2)
        end
    end
    return 
end

function _COMMON_AddCautionAndFindGoal(arg0, arg1)
    local local0 = 0
    local local1 = 0
    local local2 = 10
    local local3 = 1.2
    local local4 = 1.2
    local local5 = 3500
    local local6 = 3502
    local local7 = TARGET_ENE_0
    local local8 = false
    if arg1 == 0 then
        local1 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__goalAction_ToDisappear)
        local8 = arg0:IsForgettingMemoryTarget()
    elseif arg1 == 1 and arg0:GetLatestSoundTargetRank() == AI_SOUND_RANK__IMPORTANT then
        local1 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__goalAction_ToCautionImportant)
        local8 = arg0:IsForgettingSoundTarget()
    elseif arg1 == 1 then
        local1 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__goalAction_ToCaution)
        local8 = arg0:IsForgettingSoundTarget()
    elseif arg1 == 3 then
        local1 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__goalAction_ToSearchLv1)
        local8 = arg0:IsForgettingTopSearchTarget()
        local7 = TARGET_SEARCH
    elseif arg1 == 4 then
        local1 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__goalAction_ToSearchLv2)
        local8 = arg0:IsForgettingTopSearchTarget()
        local7 = TARGET_SEARCH
    end
    local local9 = arg0:GetDist(local7)
    if local1 == 1 then
        arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, local7)
    elseif local1 == 2 then
        if local8 == true then
            arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, local7)
        else
            arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhere, local2, local7, AI_DIR_TYPE_CENTER, local3, TARGET_SELF, true)
        end
    elseif local1 == 3 then
        if local8 == true then
            arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, local7)
        else
            arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhere, local2, local7, AI_DIR_TYPE_CENTER, local3, TARGET_SELF, false)
        end
    elseif local1 == 4 then
        arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, local7)
    elseif local1 == 5 then
        arg0:AddTopGoal(GOAL_COMMON_LeaveTarget_Continuous, 10, local7, 15, TARGET_SELF, false, -1, GUARD_GOAL_DESIRE_RET_Continue, false, 2)
    elseif local1 == 6 then
        arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhere, local2, local7, AI_DIR_TYPE_CENTER, local3, TARGET_SELF, false)
        arg0:AddTopGoal(GOAL_COMMON_WalkAround_On_FailedPath, 1000)
    elseif local1 == 7 then
        if local8 == true then
            arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, local7)
        else
            arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, local2, local7, local3, local7, true, 9910)
        end
    elseif local1 == 99 then
        arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 5, 3008, TARGET_ENE_0, DIST_NONE, 0, 90)
    elseif local1 == 98 then
        arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 5, 3006, TARGET_ENE_0, DIST_NONE, 0, 90)
    elseif local1 == 8 then
        arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, -1, 3503, TARGET_SELF, 9999, 0, 90)
    elseif local1 == 9 then
        arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, -1, local5, local7, 9999, 0, 90)
        arg0:AddTopGoal(GOAL_COMMON_Wait, arg0:GetRandam_Int(2, 5), local7, 0, 0, 0)
    elseif local1 == 10 then
        arg0:AddTopGoal(GOAL_COMMON_Turn, 3, local7)
        arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, -1, local5, local7, 9999, 0, 90)
        arg0:AddTopGoal(GOAL_COMMON_Wait, arg0:GetRandam_Int(2, 5), local7, 0, 0, 0)
    elseif local1 == 11 then
        if local8 == true then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, -1, local5, local7, 9999, 0, 90)
            arg0:AddTopGoal(GOAL_COMMON_Wait, arg0:GetRandam_Int(2, 5), local7, 0, 0, 0)
        else
            arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhere, local2, local7, AI_DIR_TYPE_CENTER, local4, TARGET_SELF, true)
        end
    elseif local1 == 12 then
        if local8 == true then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, -1, local5, local7, 9999, 0, 90)
            arg0:AddTopGoal(GOAL_COMMON_Wait, arg0:GetRandam_Int(2, 5), local7, 0, 0, 0)
        else
            arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhere, local2, local7, AI_DIR_TYPE_CENTER, local4, TARGET_SELF, false)
        end
    elseif local1 == 13 then
        arg0:AddTopGoal(GOAL_COMMON_LeaveTarget, local2, local7, 20, local7, true, -1)
        arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, -1, local5, local7, 9999, 0, 90)
        arg0:AddTopGoal(GOAL_COMMON_Wait, arg0:GetRandam_Int(2, 5), local7, 0, 0, 0)
    elseif local1 == 14 then
        arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3501, local7, 9999, 0, 90)
    elseif local1 == 15 then
        if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_DETECT_ANIM_COOLTIME) == false then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, local6, local7, 9999, 0, 90)
        else
            arg0:AddTopGoal(GOAL_COMMON_Turn, 3, local7)
        end
    elseif local1 == 16 then
        if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_DETECT_ANIM_COOLTIME) == false then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, local6, local7, 9999, 0, 90)
        elseif local8 == true then
            arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, local7)
        else
            arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhere, local2, local7, AI_DIR_TYPE_CENTER, local3, TARGET_SELF, true)
        end
    else
        arg0:SetStringIndexedNumber("NeglectTarget", 1)
        _COMMON_AddNonBattleGoal(arg0, 5, -1, false)
    end
    return 
end

function _COMMON_AddNonBattleGoal(arg0, arg1, arg2, arg3)
    arg0:TeamHelp_ValidateCall()
    arg0:TeamHelp_ValidateReply()
    if arg0:IsChangeState() and not arg0:IsBattleState() and not arg0:IsCautionState() then
        local local0 = 0
        _COMMON_AddChangeStateActionGoal(arg0, 0)
    end
    arg0:AddTopGoal(GOAL_COMMON_NonBattleAct, arg1, arg2, arg3, false, POINT_INIT_POSE, 0, 0)
    return 
end

function COMMON_Interrupt(arg0, arg1)
    if arg0:IsLadderAct(TARGET_SELF) then
        return false
    elseif arg0:IsInterupt(INTERUPT_FindUnfavorableFailedPoint) and arg0:GetStringIndexedNumber("RepCount_Disable_FailedPath") == 0 and (arg0:IsBattleState() == true or arg0:IsSearchHighState() == true or arg0:IsSearchLowState() == true or arg0:IsCautionState() == true) then
        local local0 = arg0:GetActTypeOnFailedPathEnd()
        if arg0:GetStringIndexedNumber("IsIgnore_Sideway_onFailedPath") == 1 then
            local0 = 0
        end
        if local0 ~= 0 then
            if arg0:CheckDoesExistPath(TARGET_ENE_0, AI_DIR_TYPE_CENTER, 0) then
                arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", 2)
                arg1:ClearSubGoal()
                arg0:Replaning()
            elseif arg0:CalcSetPointWaitAndSee() then
                local local1 = true
                if arg0:IsRiding(TARGET_SELF) == true then
                    local1 = false
                end
                arg1:ClearSubGoal()
                arg1:AddSubGoal(GOAL_COMMON_MoveToWaitandSee, 30, 2, TARGET_SELF, local1, 1, -1)
                _COMMON_Add_On_FailedPathGoal(arg0, arg1)
            else
                arg1:ClearSubGoal()
                _COMMON_Add_On_FailedPathGoal(arg0, arg1)
            end
            return true
        end
    end
    if arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) and arg0:GetStringIndexedNumber("RepCount_Disable_FailedPath") == 0 then
        if arg0:IsBattleState() == true and arg0:CheckDoesExistPath(TARGET_ENE_0, AI_DIR_TYPE_CENTER, 0) == true then
            arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", 2)
            arg1:ClearSubGoal()
            return true
        end
        local local0 = arg0:GetActTypeOnFailedPathEnd()
        if arg0:GetStringIndexedNumber("IsEnableFadeWarp_OnFailedPath") == 1 then
            arg1:ClearSubGoal()
            arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", 1)
            arg1:AddSubGoal(GOAL_COMMON_FadeWarpToInitPos, 10, 2, 4)
            return true
        elseif arg0:GetStringIndexedNumber("IsIgnore_Sideway_onFailedPath") == 1 then
            local0 = 0
        end
        if local0 ~= 0 then
            arg1:ClearSubGoal()
            _COMMON_Add_On_FailedPathGoal(arg0, arg1)
            return true
        end
    end
    return false
end

function _COMMON_Add_On_FailedPathGoal(arg0, arg1)
    arg0:DecideWalkAroundPos()
    local local0 = arg0:GetActTypeOnFailedPathEnd()
    local local1 = -1
    if 0 < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__IsGuard_Act) then
        local1 = 9910
    end
    if arg0:HasSpecialEffectId(TARGET_SELF, 13799) then
        arg1:AddSubGoal(GOAL_COMMON_Guard_On_FailedPath, 30, 1, 15)
        return true
    elseif 0 ~= local0 then
        if 1 == local0 then
            arg1:AddSubGoal(GOAL_COMMON_BackToHome_On_FailedPath, 100, 1)
        elseif 2 == local0 then
            arg1:AddSubGoal(GOAL_COMMON_SideWay_On_FailedPath, 30, 1, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__rangedAttackId), 10, 8, 8, local1, false)
        elseif 3 == local0 then
            arg1:AddSubGoal(GOAL_COMMON_SideWay_On_FailedPath, 30, 1, -1, 3, 8, 8, local1, false)
        end
    end
    return 
end

return 
