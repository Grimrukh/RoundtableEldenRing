REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Guard_On_FailedPath, 0, "パスチェック間隔", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Guard_On_FailedPath, 1, "諦めて巣に帰る時間", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Guard_On_FailedPath, 2, "ガードを行うか", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Guard_On_FailedPath, 3, "帰巣限界時用か", 0)
function GuardOnFailedPath_Activate(arg0, arg1)
    arg1:SetTimer(0, arg1:GetParam(0))
    arg1:SetTimer(1, arg1:GetParam(1))
    arg1:AddSubGoal(GOAL_COMMON_Guard, 3, 9910, TARGET_ENE_0, GUARD_GOAL_DESIRE_RET_Continue, true)
    return 
end

function GuardOnFailedPath_Update(arg0, arg1)
    local local0 = GOAL_RESULT_Continue
    if true == arg1:IsFinishTimer(0) then
        if 0 < arg1:GetParam(3) then
            local local1 = 0
            local local2 = false
            if arg0:GetDist(TARGET_ENE_0) < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backhomeBattleDist) then
                local0 = GOAL_RESULT_Success
            end
            if arg0:IsValidPlatoon() == true and arg0:IsPlatoonLeader() == false then
                local local3 = arg0:GetPlatoonCommand()
                local local4 = local3:GetCommandNo()
                if local4 == PLAN_PLATOON_COMMAND__MOVE or local4 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR or local4 == PLAN_PLATOON_COMMAND__PATROL_BEHAVIOR_RESET or local4 == PLAN_PLATOON_COMMAND__DEF or local4 == PLAN_PLATOON_COMMAND__SCOUT_MOVE then
                    local2 = true
                end
            end
            if local2 == true then
                local1 = arg0:GetDistAtoB(TARGET_ENE_0, TARGET_TEAM_FORMATION)
            elseif 0 <= arg0:GetMovePointNumber() then
                local1 = arg0:GetDistAtoB(TARGET_ENE_0, POINT_MOVE_POINT)
            else
                local1 = arg0:GetDistAtoB(TARGET_ENE_0, POINT_INITIAL)
            end
            if arg1:GetSubGoalNum() <= 0 then
                if local1 < arg0:GetMovePointEffectRange() or arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__maxBackhomeDist) < arg0:GetMovePointEffectRange() or arg0:GetMovePointEffectRange() < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backhomeDist) then
                    local0 = GOAL_RESULT_Success
                else
                    GuardOnFailedPath_AddInnerGoal(arg0, arg1)
                end
            end
        else
            if true == arg1:IsFinishTimer(0) then
                if true == arg0:CheckDoesExistPath(TARGET_ENE_0, AI_DIR_TYPE_CENTER, 0) then
                    local0 = GOAL_RESULT_Success
                else
                    arg1:SetTimer(0, arg1:GetParam(0))
                end
            end
            if arg1:GetSubGoalNum() <= 0 then
                GuardOnFailedPath_AddInnerGoal(arg0, arg1)
            end
        end
    end
    return local0
end

function GuardOnFailedPath_Terminate(arg0, arg1)
    return 
end

function GuardOnFailedPath_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) then
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_Guard, arg1:GetLife(), 9910, TARGET_ENE_0, GUARD_GOAL_DESIRE_RET_Continue, true)
        return true
    else
        return false
    end
end

function GuardOnFailedPath_AddInnerGoal(arg0, arg1)
    local local0 = arg1:GetParam(2)
    local local1 = arg0:GetRandam_Float(2, 4)
    if arg1:IsFinishTimer(1) then
        arg1:SetNumber(0, 1)
        if arg0:GetMovePointEffectRange() < 2 then
            arg1:AddSubGoal(GOAL_COMMON_Guard, local1, 9910, TARGET_ENE_0, GUARD_GOAL_DESIRE_RET_Continue, true)
            arg1:SetNumber(0, 2)
        else
            if arg0:IsRiding(TARGET_SELF) == true then
                local local2 = arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, -1, POINT_INITIAL, 1, TARGET_SELF, true, local0, GUARD_GOAL_DESIRE_RET_Continue, true)
                local2:SetFailedEndOption(AI_GOAL_FAILED_END_OPT__PARENT_NEXT_SUB_GOAL)
            else
                local local2 = arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, -1, POINT_INITIAL, 1, TARGET_ENE_0, true, local0, GUARD_GOAL_DESIRE_RET_Continue, true)
                local2:SetFailedEndOption(AI_GOAL_FAILED_END_OPT__PARENT_NEXT_SUB_GOAL)
            end
            arg1:SetNumber(0, 1)
        end
    else
        arg1:AddSubGoal(GOAL_COMMON_Guard, local1, 9910, TARGET_ENE_0, GUARD_GOAL_DESIRE_RET_Continue, true)
    end
    return 
end

return 
