REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonBattleAct, 0, "ìGÇ…îΩâûÇ∑ÇÈãóó£ÅymÅz", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonBattleAct, 1, "ìGÇ¢ÇΩÇÁèIóπÅH", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonBattleAct, 2, "ëñÇÈÅH", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonBattleAct, 3, "ê˘âÒÅyTYPEÅz", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonBattleAct, 4, "ëÉÇÃìûíÖãóó£ÅymÅz", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonBattleAct, 5, "ë“ã@éûÉSÅ[Éã", 0)
REGISTER_GOAL_UPDATE_TIME(GOAL_COMMON_NonBattleAct, 0.1, 0.2)
function _IsWalk_ForNonBattleAct(arg0, arg1)
    local local0 = 1
    if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_SPIRIT_CANDLE) then
        if arg0:HasSpecialEffectAttribute(TARGET_SELF, SP_EFFECT_TYPE_HIDDEN) then
            local0 = 0
        else
            local0 = 1
        end
        return local0
    elseif arg0:HasSpecialEffectId(TARGET_SELF, 5000) then
        local0 = 0
    elseif arg0:HasSpecialEffectId(TARGET_SELF, 5004) then
        if arg0:IsRiding(TARGET_SELF) then
            local0 = 0
        else
            local0 = 1
        end
    elseif arg1:GetParam(2) == 0 then
        local0 = 1
    else
        local0 = 0
    end
    return local0
end

function NonBattleAct_Activate(arg0, arg1)
    local local0 = true
    if _IsWalk_ForNonBattleAct(arg0, arg1) == 0 then
        local0 = false
    end
    if arg0:HasSpecialEffectId(TARGET_SELF, 5011) then
        arg1:AddSubGoal(GOAL_COMMON_Stay, arg1:GetLife(), 0, TARGET_SELF)
    elseif 0 < arg0:GetStringIndexedNumber("NonBattleAct_FailedPathMove") then
        local local1 = arg0:GetActTypeOnNonBattleFailedPathEnd()
        arg0:SetStringIndexedNumber("NonBattleAct_FailedPathMove", 0)
        if AI_FAILED_PATH_NONBTL_ACT_TYPE__STAY == local1 then
            arg1:AddSubGoal(GOAL_COMMON_Stay, arg1:GetLife(), 0, TARGET_SELF)
        elseif AI_FAILED_PATH_NONBTL_ACT_TYPE__WALK_AROUND == local1 then
            arg1:AddSubGoal(GOAL_COMMON_WalkAround, -1, 0.5, local0)
        end
    elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_DECLARE) then
        local local1 = arg0:GetPlatoonCommand()
        local local2 = local1:GetCommandNo()
        local local3 = arg0:GetBuddyFollowType()
        if 0 < arg0:GetTeamDefeatEntityId() and arg0:IsExistTargetTeamDefeat() == false then
            local local4 = 1840
            if arg0:IsNpcPlayer() == true then
                local4 = NPC_ATK_BuddyReturn
            end
            arg0:NotifyBuddyUnsummon()
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1.5, TARGET_SELF)
            arg1:AddSubGoal(GOAL_COMMON_WaitWithAnime, -1, local4, TARGET_SELF)
        elseif local3 == PLAN_BUDDYFOLLOWTYPE_NOFOLLOW_WAIT then
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1.5, TARGET_SELF)
        elseif local3 == PLAN_BUDDYFOLLOWTYPE_NOFOLLOW_WALKAROUND or not not arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_AGGRESSIVE) or arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_AGGRESSIVE_DEMIHUMAN) then
            arg1:AddSubGoal(GOAL_COMMON_WalkAround_Anywhere, arg1:GetLife(), 2, 10, true, -1, arg0:GetRandam_Float(4, 8), -1, false, false, false)
        else
            local local5 = TARGET_HOSTPLAYER
            local local6 = false
            local local7 = 45
            local local8 = 3
            local local9 = 1.5
            if arg0:IsBattleState() then
                local5 = TARGET_ENE_0
            end
            if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_WALK_FOLLOW) then
                local6 = true
            end
            if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_REAR_FOLLOW) then
                local8 = 1.5
                local7 = 135
                local9 = 1
            end
            if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_FLY_FOLLOW) then
                local8 = 5.5
                local7 = 60
                local9 = 0.3
            end
            if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_NO_FOLLOW) then
                arg1:AddSubGoal(GOAL_COMMON_Wait, 10, TARGET_SELF)
                return true
            elseif arg0:GetDist(TARGET_HOSTPLAYER) < 0.5 then
                arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(1.5, 2.5), TARGET_SELF)
                arg1:AddSubGoal(GOAL_COMMON_ApproachSettingDirection, 10, TARGET_HOSTPLAYER, 1, TARGET_SELF, true, -1, AI_DIR_TYPE_ToB, 4)
            else
                arg1:AddSubGoal(GOAL_COMMON_ApproachForBuddy, 30, TARGET_HOSTPLAYER, 2, TARGET_SELF, local6, -1, local7, 15, local8)
            end
        end
    elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_STRAGGLER_DEACT) then
        arg1:AddSubGoal(GOAL_COMMON_Wait, 1, TARGET_SELF)
    elseif not not arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_STRAGGLER_ACT) or arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_STRAGGLER_ACT_HOSTILE) then
        local local1 = 15
        if local1 <= arg0:GetDist(POINT_StragglerAfterDefeat) then
            arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 10, POINT_StragglerAfterDefeat, local1 - arg0:GetRandam_Int(0, 5), TARGET_SELF, true, -1)
        else
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1, TARGET_SELF)
        end
    elseif arg0:IsValidPlatoon() == true and arg0:IsPlatoonLeader() == false then
        local local1 = arg0:GetPlatoonCommand()
        local local2 = local1:GetCommandNo()
        local local3 = arg0:GetDist(TARGET_TEAM_FORMATION)
        local local4 = 1
        if local2 == PLAN_PLATOON_COMMAND__MOVE or local2 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR or local2 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR_RESET then
            if arg0:IsSearchTarget(TARGET_ENE_0) then
                arg1:AddSubGoal(GOAL_COMMON_BackToHome, arg1:GetLife(), 0, arg1:GetParam(6), 0, 0, TARGET_TEAM_FORMATION)
            elseif arg0:GetStringIndexedNumber("COMMON_PatrolBehavior_DoneAct") ~= 1 and COMMON_PatrolBehavior(arg0, arg1, local1:GetParam(0), local1:GetParam(1)) then
                arg0:SetStringIndexedNumber("COMMON_PatrolBehavior_DoneAct", 1)
            elseif local3 < local4 then
                arg1:AddSubGoal(GOAL_COMMON_Stay, 0.5, 0, TARGET_SELF)
            else
                arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, arg1:GetLife(), TARGET_TEAM_FORMATION, AI_DIR_TYPE_CENTER, local4, TARGET_SELF, local0)
            end
        elseif local2 == PLAN_PLATOON_COMMAND__DEF then
            if local3 < local4 then
                arg1:AddSubGoal(GOAL_COMMON_Stay, 0.5, 0, TARGET_SELF)
            else
                arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, arg1:GetLife(), TARGET_TEAM_FORMATION, AI_DIR_TYPE_CENTER, local4, TARGET_SELF, local0)
            end
        elseif local2 == PLAN_PLATOON_COMMAND__RUN then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTargetToPathEnd, -1, TARGET_TEAM_LEADER, 80, TARGET_SELF, false, -1, GOAL_RESULT_Continue, false, 2)
            arg1:AddSubGoal(GOAL_COMMON_Stay, 10, 0, TARGET_TEAM_LEADER)
        elseif local2 == PLAN_PLATOON_COMMAND__PATROLEND or local2 == PLAN_PLATOON_COMMAND__PATROLEND_WITHWALKAROUND or local2 == PLAN_PLATOON_COMMAND__STOPEND or local2 == PLAN_PLATOON_COMMAND__STOPEND_WITHWALKAROUND then
            if arg0:GetDist(TARGET_TEAM_MEMBER_3) < 35 then
                if local2 == PLAN_PLATOON_COMMAND__PATROLEND_WITHWALKAROUND or local2 == PLAN_PLATOON_COMMAND__STOPEND_WITHWALKAROUND then
                    if arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__caravanRole) == 1 then
                        arg0:SetAIFixedMoveTargetSpecifyAngle(TARGET_SELF, arg0:GetToTargetAngle(TARGET_TEAM_MEMBER_3) - 180, 10, AI_SPA_DIR_TYPE_TargetF)
                        arg1:AddSubGoal(GOAL_COMMON_Stay, 3, 5, POINT_AI_FIXED_POS)
                    else
                        arg1:AddSubGoal(GOAL_COMMON_WalkAround_Anywhere, -1, -1, 10, true, -1, -1, -1, false, false, false)
                    end
                else
                    arg1:AddSubGoal(GOAL_COMMON_Wait, 3, TARGET_SELF)
                end
            else
                arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 10, TARGET_TEAM_MEMBER_3, arg0:GetRandam_Float(15, 35), TARGET_SELF, true, -1)
            end
        elseif local2 == PLAN_PLATOON_COMMAND__STOP and arg0:HasSpecialEffectId(TARGET_SELF, 5551) then
            if local3 < 5 then
                arg1:AddSubGoal(GOAL_COMMON_Wait, 3, TARGET_SELF)
            else
                arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, arg1:GetLife(), TARGET_TEAM_FORMATION, AI_DIR_TYPE_CENTER, 5, TARGET_SELF, true)
            end
        else
            NonBattleAct_Common(arg0, arg1)
        end
    elseif arg0:IsValidPlatoon() == true and arg0:IsPlatoonLeader() == true then
        local local1 = arg0:GetPlatoonCommand()
        local local2 = local1:GetCommandNo()
        if local2 == PLAN_PLATOON_COMMAND__WAIT or local2 == PLAN_PLATOON_COMMAND__PATROLEND then
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1, TARGET_SELF)
        else
            NonBattleAct_Common(arg0, arg1)
        end
    else
        NonBattleAct_Common(arg0, arg1)
    end
    return 
end

function NonBattleAct_Common(arg0, arg1)
    local local0 = arg0:GetMovePointNumber()
    local local1 = true
    if _IsWalk_ForNonBattleAct(arg0, arg1) == 0 then
        local1 = false
    end
    if 0 <= local0 then
        if arg0:GetFlyRouteState() ~= AI_FLY_ROUTE_STATE_NOT_USE_FLY_ROUTE then
            arg0:AddObserveSpecialEffectAttribute(TARGET_SELF, 5025)
            if arg0:GetFlyRouteState() == AI_FLY_ROUTE_STATE_ON_GROUND then
                arg1:AddSubGoal(GOAL_COMMON_WalkAround_Anywhere, -1, 2, 10, true, 3020, 18, -1, false, true)
            elseif arg0:GetFlyRouteState() == AI_FLY_ROUTE_STATE_ON_GROUND_TAKEOFF_REQUESTED then
                if arg0:GetDist(POINT_MOVE_POINT) < 2 then
                    arg1:AddSubGoal(GOAL_COMMON_Turn, 5, POINT_FlyRoute_CruiseBoundary, 0)
                    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 20008, POINT_FlyRoute_CruiseBoundary, 0, 0, 0, 0, 0)
                else
                    arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhereSmooth, arg1:GetLife(), POINT_MOVE_POINT, AI_DIR_TYPE_CENTER, 0, TARGET_SELF, false)
                end
            else
                arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhereSmoothFly, arg1:GetLife(), POINT_MOVE_POINT, AI_DIR_TYPE_CENTER, 0, TARGET_SELF, false, 0, 45)
            end
        elseif arg0:IsSearchTarget(TARGET_ENE_0) and arg0:GetStringIndexedNumber("NeglectTarget") == 0 then
            arg1:AddSubGoal(GOAL_COMMON_BackToHome, arg1:GetLife(), 0, arg1:GetParam(6), 0, 0)
        elseif arg0:GetStringIndexedNumber("COMMON_PatrolBehavior_DoneAct") ~= 1 and COMMON_PatrolBehavior(arg0, arg1) then
            arg0:SetStringIndexedNumber("COMMON_PatrolBehavior_DoneAct", 1)
        elseif arg0:HasSpecialEffectId(TARGET_SELF, 5003) and arg0:IsNpcPlayer() then
            arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, arg1:GetLife(), POINT_MOVE_POINT, 0, TARGET_SELF, false, NPC_ATK_DashHold)
        elseif not not arg0:HasSpecialEffectId(TARGET_SELF, 5001) or arg0:GetMovePointActionId(local0) ~= -1 and arg0:IsPlatoonLeader() == false then
            arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, arg1:GetLife(), POINT_MOVE_POINT, AI_DIR_TYPE_CENTER, 0, TARGET_SELF, local1)
        else
            arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhereSmooth, arg1:GetLife(), POINT_MOVE_POINT, AI_DIR_TYPE_CENTER, 0, TARGET_SELF, local1)
        end
    elseif arg0:GetMovePointType() == 6 then
        if 12 <= arg0:GetMovePointEffectRange() then
            arg1:AddSubGoal(GOAL_COMMON_BackToHome, arg1:GetLife(), 0, arg1:GetParam(6), 0, 0)
        else
            arg1:AddSubGoal(GOAL_COMMON_WalkAround, -1, 0.5, local1)
        end
    else
        local local2 = arg1:GetParam(3)
        local local3 = arg1:GetParam(4)
        if local3 == 0 then
            local3 = 2
        end
        if arg0:GetStringIndexedNumber("COMMON_PatrolBehavior_DoneAct") ~= 1 and COMMON_PatrolBehavior(arg0, arg1) then
            arg0:SetStringIndexedNumber("COMMON_PatrolBehavior_DoneAct", 1)
        elseif local3 < arg0:GetMovePointEffectRange() and arg0:IsGotHome() == false then
            arg1:AddSubGoal(GOAL_COMMON_BackToHome, arg1:GetLife(), 0, arg1:GetParam(6), 0, 0)
        elseif arg0:HasSpecialEffectId(TARGET_SELF, 11710) then
            arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 1, 3020, TARGET_NONE)
        elseif arg1:IsExistParam(5) and arg1:GetParam(5) ~= 0 then
            local local4 = arg1:GetParam(5)
            if 0 < local4 then
                arg1:AddSubGoal(local4, arg1:GetLife())
            else
                arg1:AddSubGoal(GOAL_COMMON_Stay, arg1:GetLife(), 0, local2)
            end
        elseif arg0:IsUpdateFirstAnimation() == true then
            if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_INITIAL_STANDBY) == false then
                if not not arg0:IsBattleState() or not not arg0:IsSearchHighState() or not not arg0:IsSearchLowState() or arg0:IsCautionState() then
                    arg1:AddSubGoal(GOAL_COMMON_Stay, arg1:GetLife(), 0, local2)
                elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_RETURN_INITIAL_STANDBY) then
                    arg1:AddSubGoal(GOAL_COMMON_Turn, 2, POINT_INIT_POSE, 0, -1, GUARD_GOAL_DESIRE_RET_Continue, true)
                    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, arg0:GetInitStayId() + 1050, TARGET_SELF, 0, 0, 0, 0, 0)
                else
                    local local4 = 9
                    local local5 = 1
                    for local6 = 0 - local5, local4, local5 do
                        if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_RETURN_INITIAL_STANDBY_WITHANIM + local6) then
                            arg1:AddSubGoal(GOAL_COMMON_Turn, 2, POINT_INIT_POSE, 0, -1, GUARD_GOAL_DESIRE_RET_Continue, true)
                            arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, PLAN_ANIMEID_RETURN_INITIAL_STANBY + local6, TARGET_SELF, 0, 0, 0, 0, 0)
                        elseif local6 == local4 then
                            arg1:AddSubGoal(GOAL_COMMON_Stay, arg1:GetLife(), 0, local2)
                        end
                    end
                end
            else
                arg1:AddSubGoal(GOAL_COMMON_Stay, arg1:GetLife(), 0, TARGET_SELF)
            end
        else
            arg1:AddSubGoal(GOAL_COMMON_Stay, 0.1, 0, TARGET_SELF)
        end
    end
    return 
end

function NonBattleAct_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function NonBattleAct_Terminate(arg0, arg1)
    return 
end

function NonBattleAct_Interupt(arg0, arg1)
    local local0 = false
    if not local0 then
        local0 = arg0:IsInterupt(INTERUPT_Damaged_Stranger)
    end
    if not local0 then
        local0 = arg0:IsInterupt(INTERUPT_Damaged)
    end
    if local0 then
        arg1:SetTimer(1, 99999)
        return true
    elseif arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) and arg0:GetStringIndexedNumber("RepCount_Disable_FailedPath") == 0 then
        if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_DECLARE) == true then
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1.5, TARGET_SELF)
            return true
        elseif arg0:GetStringIndexedNumber("IsEnableFadeWarp_OnFailedPath") == 1 then
            arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", 1)
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_FadeWarpToInitPos, 10, 2, 4)
            return true
        end
        arg0:SetStringIndexedNumber("NonBattleAct_FailedPathMove", 1)
        if AI_FAILED_PATH_NONBTL_ACT_TYPE__WALK_AROUND == arg0:GetActTypeOnNonBattleFailedPathEnd() then
            arg0:SetNonBattleWalkAroundMode(true)
        end
        arg1:ClearSubGoal()
        arg0:Replaning()
        return true
    elseif arg0:IsInterupt(INTERUPT_PlatoonAiOrder) then
        local local1 = arg0:GetPlatoonCommand()
        local local2 = local1:GetCommandNo()
        if local2 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR then
            arg1:ClearSubGoal()
            arg0:Replaning()
            return true
        elseif local2 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR_RESET then
            COMMON_PatrolBehavior_FlagInitialize(arg0, true)
        elseif local2 == PLAN_PLATOON_COMMAND__PATROLEND or local2 == PLAN_PLATOON_COMMAND__PATROLEND_WITHWALKAROUND or local2 == PLAN_PLATOON_COMMAND__STOPEND or local2 == PLAN_PLATOON_COMMAND__STOPEND_WITHWALKAROUND then
            arg1:ClearSubGoal()
            arg0:Replaning()
            return true
        end
    end
    if arg0:IsInterupt(INTERUPT_ActivateSpecialEffect) and (not not arg0:GetSpecialEffectActivateInterruptId(5025) or arg0:GetSpecialEffectDeActivateInterruptId(5025)) then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

return 
