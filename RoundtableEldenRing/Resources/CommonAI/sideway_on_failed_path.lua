REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_On_FailedPath, 0, "パスチェック間隔", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_On_FailedPath, 1, "途中行動のアニメID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_On_FailedPath, 2, "途中行動を行う時間", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_On_FailedPath, 3, "途中行動を行う間隔", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_On_FailedPath, 4, "諦めて巣に帰る時間", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_On_FailedPath, 5, "ガードを行うか", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_On_FailedPath, 6, "帰巣限界時用か", 0)
function SideWayOnFailedPath_Activate(arg0, arg1)
    arg1:SetTimer(0, arg1:GetParam(0))
    arg1:SetTimer(1, arg1:GetParam(4))
    if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_DECLARE) then
        arg1:SetNumber(1, 1)
    else
        arg1:SetNumber(1, 0)
    end
    SideWayOnFailedPath_AddInnerGoal(arg0, arg1)
    return 
end

function SideWayOnFailedPath_Update(arg0, arg1)
    if 0 < arg1:GetParam(6) then
        local local0 = 0
        local local1 = false
        if arg0:IsBattleState() == true and arg0:GetDist(TARGET_ENE_0) < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backhomeBattleDist) then
            return GOAL_RESULT_Failed
        elseif arg1:GetNumber(1) == 1 and 23 <= arg0:GetDist(TARGET_HOSTPLAYER) then
            return GOAL_RESULT_Success
        elseif arg0:IsValidPlatoon() == true and arg0:IsPlatoonLeader() == false then
            local local2 = arg0:GetPlatoonCommand()
            local local3 = local2:GetCommandNo()
            if local3 == PLAN_PLATOON_COMMAND__MOVE or local3 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR or local3 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR_RESET or local3 == PLAN_PLATOON_COMMAND__DEF or local3 == PLAN_PLATOON_COMMAND__SCOUT_MOVE then
                local1 = true
            end
        end
        if local1 == true then
            local0 = arg0:GetDistAtoB(TARGET_ENE_0, TARGET_TEAM_FORMATION)
        elseif 0 <= arg0:GetMovePointNumber() then
            local0 = arg0:GetDistAtoB(TARGET_ENE_0, POINT_MOVE_POINT)
        else
            local0 = arg0:GetDistAtoB(TARGET_ENE_0, POINT_INITIAL)
        end
        if arg1:GetSubGoalNum() <= 0 then
            if local0 < arg0:GetMovePointEffectRange() or arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__maxBackhomeDist) < arg0:GetMovePointEffectRange() or arg0:GetMovePointEffectRange() < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backhomeDist) then
                return GOAL_RESULT_Success
            end
            SideWayOnFailedPath_AddInnerGoal(arg0, arg1)
        end
    else
        if arg0:IsBattleState() == true and arg0:GetDist(TARGET_ENE_0) < 6 then
            arg0:SetStringIndexedNumber("IsIgnore_Sideway_onFailedPath", 1)
            return GOAL_RESULT_Success
        elseif arg1:GetNumber(1) == 1 and 23 <= arg0:GetDist(TARGET_HOSTPLAYER) then
            return GOAL_RESULT_Success
        end
        local local4 = TARGET_ENE_0
        if arg0:IsSearchLowState() == true or arg0:IsSearchHighState() == true then
            local4 = TARGET_SEARCH
        end
        if arg1:GetNumber(0) == 2 then
            local local5 = 0
            if arg0:GetDistAtoB(local4, POINT_INITIAL) < 30 then
                return GOAL_RESULT_Success
            end
        end
        if true == arg1:IsFinishTimer(0) then
            if true == arg0:CheckDoesExistPath(local4, AI_DIR_TYPE_CENTER, 0) then
                return GOAL_RESULT_Success
            end
            arg1:SetTimer(0, arg1:GetParam(0))
        end
        if arg1:GetSubGoalNum() <= 0 then
            SideWayOnFailedPath_AddInnerGoal(arg0, arg1)
        end
    end
    return GOAL_RESULT_Continue
end

function SideWayOnFailedPath_Terminate(arg0, arg1)
    return 
end

function SideWayOnFailedPath_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_Shoot) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_FINDSHOOT_STEP_ON_FAILED_PATHGOAL) then
        local local0 = 3
        local local1 = false
        local local2 = false
        local local3 = 0
        local local4 = 6003
        local local5 = 6002
        if local0 <= arg0:GetExistMeshOnLineDist(TARGET_SELF, AI_DIR_TYPE_R, local0 + 1) then
            local1 = true
        end
        if local0 <= arg0:GetExistMeshOnLineDist(TARGET_SELF, AI_DIR_TYPE_L, local0 + 1) then
            local2 = true
        end
        if local1 == true and local2 == true then
            local3 = arg0:GetRandam_Int(local5, local4)
        elseif local1 == false and local2 == false then
            local3 = arg0:GetRandam_Int(local5, local4)
        elseif local1 == true then
            local3 = local4
        else
            local3 = local5
        end
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_SpinStep, 2, local3, TARGET_ENE_0, 0, AI_DIR_TYPE_CENTER, 0)
        return true
    elseif arg0:IsInterupt(INTERUPT_CANNOT_MOVE) and 1 <= arg1:GetNumber(0) then
        local local0 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__CannotMoveAction)
        if arg0:IsTouchBreakableObject() and 0 <= local0 and arg0:IsLookToTarget(POINT_CurrRequestPosition, 90) then
            local local6 = 10
            if arg0:IsHugeEnemy() == true then
                local6 = 100
            end
            if arg0:GetTouchBreakableObjectDefense() <= local6 then
                arg1:ClearSubGoal()
                if arg0:IsRiding(TARGET_SELF) == false and 0 < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__enableWeaponOnOff) and arg0:HasSpecialEffectId(TARGET_SELF, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOffSpecialEffectId)) == true then
                    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOnAnimId), TARGET_SELF, 9999, 0, 0, 0, 0)
                    arg1:AddSubGoal(GOAL_COMMON_NonspinningAttack, -1, local0, TARGET_NONE, DIST_None)
                    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOffAnimId), TARGET_SELF, 9999, 0, 0, 0, 0)
                    return true
                else
                    arg1:AddSubGoal(GOAL_COMMON_NonspinningAttack, -1, local0, TARGET_NONE, DIST_None)
                    return true
                end
            end
        end
        if arg1:GetNumber(1) == 1 then
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1, TARGET_ENE_0)
            return true
        elseif arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backToHomeStuckAct) == 1 and arg0:GetStringIndexedNumber("RepCount_Disable_FailedPath") == 0 then
            arg1:ClearSubGoal()
            arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", 1)
            arg1:AddSubGoal(GOAL_COMMON_FadeWarpToInitPos, 10, 2, 4)
        else
            arg1:SetNumber(0, 2)
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_Wait, arg1:GetLife(), TARGET_ENE_0)
        end
        return true
    elseif arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) then
        return true
    elseif arg1:GetNumber(0) == 2 and (not not arg0:IsInterupt(INTERUPT_Damaged) or arg0:IsInterupt(INTERUPT_SuccessGuard)) then
        arg1:ClearSubGoal()
        SideWayOnFailedPath_AddShootGoal(arg0, arg1)
        return true
    else
        return false
    end
end

function SideWayOnFailedPath_AddInnerGoal(arg0, arg1)
    local local0 = arg1:GetParam(2)
    local local1 = arg1:GetParam(5)
    local local2 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__shiftAnimeId_RangedAttack)
    local local3 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__spEffectId_RangedAttack)
    if 0 < local3 and 0 < local2 and arg0:HasSpecialEffectId(TARGET_SELF, local3) == false then
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, local2, TARGET_ENE_0, 9999, 0, -1)
        return 
    end
    local local4 = true
    if arg0:IsRiding(TARGET_SELF) then
        local4 = false
    end
    if arg1:IsFinishTimer(1) then
        arg1:SetNumber(0, 1)
        if arg0:GetMovePointEffectRange() < 2 then
            SideWayOnFailedPath_AddWaitGoal(arg0, arg1, 3)
            arg1:SetNumber(0, 2)
        else
            local local5 = arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, -1, POINT_INITIAL, 1, TARGET_ENE_0, local4, local1, GUARD_GOAL_DESIRE_RET_Continue, true)
            local5:SetFailedEndOption(AI_GOAL_FAILED_END_OPT__PARENT_NEXT_SUB_GOAL)
            arg1:SetNumber(0, 1)
        end
    elseif arg1:IsFinishTimer(2) and arg1:GetParam(1) ~= -1 and arg1:GetNumber(0) ~= 1 and arg1:GetNumber(1) ~= 1 and arg1:GetNumber(2) ~= 1 then
        SideWayOnFailedPath_AddShootGoal(arg0, arg1)
        arg1:SetTimer(2, arg1:GetParam(3))
    elseif arg0:GetRandam_Int(0, 9) == 0 and arg0:IsRiding(TARGET_SELF) == false and arg0:IsExistMeshOnLine(TARGET_SELF, AI_DIR_TYPE_B, 2) then
        local local6 = arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, LeaveTime, TARGET_ENE_0, 9999, TARGET_ENE_0, local4, local1, GUARD_GOAL_DESIRE_RET_Continue, true)
        local6:SetFailedEndOption(AI_GOAL_FAILED_END_OPT__PARENT_NEXT_SUB_GOAL)
    else
        local local7 = 2
        if arg0:IsRiding(TARGET_SELF) then
            local7 = 3
        end
        local local5 = arg0:GetToTargetAngle(TARGET_ENE_0)
        local local8 = false
        local local9 = false
        local local10 = 0
        if local7 <= arg0:GetExistMeshOnLineDistSpecifyAngle(TARGET_SELF, 90 + local5, local7 + 2, AI_SPA_DIR_TYPE_TargetF) then
            local8 = true
        end
        if local7 <= arg0:GetExistMeshOnLineDistSpecifyAngle(TARGET_SELF, -90 + local5, local7 + 2, AI_SPA_DIR_TYPE_TargetF) then
            local9 = true
        end
        if local8 == false and local9 == false then
            local local11 = arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, -1, POINT_INITIAL, 1, TARGET_ENE_0, local4, local1, GUARD_GOAL_DESIRE_RET_Continue, true)
            local11:SetFailedEndOption(AI_GOAL_FAILED_END_OPT__PARENT_NEXT_SUB_GOAL)
            arg1:SetNumber(0, 1)
            arg1:SetTimer(1, 0)
        else
            if local8 == true and local9 == true then
                local10 = arg0:GetRandam_Int(0, 1)
            elseif local8 == true then
                local10 = 1
            else
                local10 = 0
            end
            arg1:AddSubGoal(GOAL_COMMON_SidewayMove, arg0:GetRandam_Float(2, 4), TARGET_ENE_0, local10, arg0:GetRandam_Int(30, 45), local4, true, local1, GUARD_GOAL_DESIRE_RET_Continue, true)
        end
    end
    return 
end

function SideWayOnFailedPath_AddShootGoal(arg0, arg1)
    local local0 = arg1:GetParam(1)
    if local0 == -1 or arg0:IsBattleState() == false then
        SideWayOnFailedPath_AddWaitGoal(arg0, arg1, 2)
    else
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, arg1:GetParam(2), local0, TARGET_ENE_0, 9999, 0, -1)
    end
    return 
end

function SideWayOnFailedPath_AddWaitGoal(arg0, arg1, arg2)
    local local0 = arg1:GetParam(5)
    if local0 == -1 then
        arg1:AddSubGoal(GOAL_COMMON_Wait, arg2, TARGET_ENE_0)
    else
        arg1:AddSubGoal(GOAL_COMMON_Guard, arg2, local0, TARGET_ENE_0, GUARD_GOAL_DESIRE_RET_Success, true)
    end
    return 
end

return 
