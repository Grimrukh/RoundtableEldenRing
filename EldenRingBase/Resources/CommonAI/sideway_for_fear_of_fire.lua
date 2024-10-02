REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_For_Fear_Of_Fire, 0, "遠ざかる距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_For_Fear_Of_Fire, 1, "ガードID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_For_Fear_Of_Fire, 2, "サイドウェイできるか", 0)
function SideWayForFearOfFire_Activate(arg0, arg1)
    local local0 = arg1:GetParam(0)
    if local0 <= 4 then
        local0 = 4
    end
    arg1:SetNumber(1, local0)
    arg1:SetNumber(2, 4)
    arg1:SetNumber(3, arg0:GetRandam_Float(0.5, 5))
    arg1:SetNumber(4, arg0:GetRandam_Int(0, 1))
    SideWayForFearOfFire_AddInnerGoal(arg0, arg1, 1)
    return 
end

function SideWayForFearOfFire_Update(arg0, arg1)
    if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BEAST_REPELLENT_UNDAMAGED) == false then
        return GOAL_RESULT_SUCCESS
    elseif arg1:GetNumber(6) == 1 then
        if arg0:HasSpecialEffectAttribute(TARGET_ENE_0, SP_EFFECT_TYPE_BEAST_REPELLENT) == true then
            arg1:SetNumber(6, 0)
        end
        if arg1:GetTimer(2) <= 0 then
            return GOAL_RESULT_SUCCESS
        end
    elseif arg0:HasSpecialEffectAttribute(TARGET_ENE_0, SP_EFFECT_TYPE_BEAST_REPELLENT) == false then
        arg1:SetNumber(6, 1)
        arg1:SetTimer(2, arg0:GetRandam_Float(0.5, 3.5))
    end
    if arg1:GetNumber(7) == 1 then
        if 2.5 <= arg0:GetDist(TARGET_ENE_0) then
            arg1:SetTimer(1, 4.5)
        end
        if arg1:GetTimer(1) <= 0 then
            arg0:SetStringIndexedNumber("DisableFearOfFire", 1)
            return GOAL_RESULT_SUCCESS
        end
    end
    local local0 = arg1:GetParam(1)
    local local1 = arg1:GetParam(2)
    if arg1:GetNumber(0) == 1 and (not (local1 ~= 0 or arg0:GetDist(TARGET_ENE_0) > arg1:GetNumber(2)) or local1 == 1 and arg0:GetDist(TARGET_ENE_0) <= arg1:GetNumber(3) and arg1:GetTimer(0) <= 0) then
        arg1:SetNumber(0, 0)
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_Wait, waitTime, TARGET_SELF)
    end
    if arg1:GetSubGoalNum() <= 0 then
        SideWayForFearOfFire_AddInnerGoal(arg0, arg1, 0)
    end
    return GOAL_RESULT_Continue
end

function SideWayForFearOfFire_Terminate(arg0, arg1)
    return 
end

function SideWayForFearOfFire_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) then
        SideWayForFearOfFire_AddWaitGoal(arg0, arg1, 1)
        return true
    else
        return false
    end
end

function SideWayForFearOfFire_AddInnerGoal(arg0, arg1, arg2)
    arg1:SetNumber(0, 0)
    local local0 = arg1:GetNumber(1)
    local local1 = arg1:GetNumber(3)
    local local2 = arg1:GetNumber(4)
    local local3 = arg1:GetParam(1)
    local local4 = arg0:GetDist(TARGET_ENE_0)
    if arg1:GetParam(2) == 0 then
        if local4 <= arg1:GetNumber(2) or arg1:GetNumber(5) == 1 then
            arg1:SetNumber(5, 1)
            if arg0:HasSpecialEffectId(TARGET_SELF, 5160) then
                arg1:AddSubGoal(GOAL_COMMON_Wait, 0.1, TARGET_SELF)
                arg1:AddSubGoal(GOAL_COMMON_LeaveTarget_Continuous, 20, TARGET_ENE_0, 999, TARGET_SELF, false, local3, GUARD_GOAL_DESIRE_RET_Success, false, 1)
            else
                arg1:AddSubGoal(GOAL_COMMON_Wait, 0.1, TARGET_SELF)
                arg1:AddSubGoal(GOAL_COMMON_LeaveTarget_Escape, 20, TARGET_ENE_0, 999, TARGET_SELF, false, 2)
            end
        elseif local4 <= local0 then
            arg1:SetNumber(2, arg0:GetRandam_Float(1, 4))
            arg1:SetNumber(0, 1)
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 5, TARGET_ENE_0, local0 + 2, TARGET_ENE_0, true, local3)
        else
            arg1:SetNumber(2, arg0:GetRandam_Float(1, 4))
            arg1:SetNumber(0, 1)
            SideWayForFearOfFire_AddWaitGoal(arg0, arg1, 1)
        end
    elseif 0 < local3 then
        if arg2 == 1 and local4 <= local1 then
            if 3 < arg0:GetExistMeshOnLineDist(TARGET_SELF, AI_DIR_TYPE_B, 4.5) then
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 6001, TARGET_ENE_0, 0, AI_DIR_TYPE_B, 4)
            else
                SideWayForFearOfFire_AddWaitGoal(arg0, arg1, 1)
            end
        else
            arg1:SetNumber(7, 1)
            if arg1:GetTimer(1) <= 0 then
                arg1:SetTimer(1, 4.5)
            end
            local local5 = arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 20, TARGET_ENE_0, local2, arg0:GetRandam_Int(30, 45), true, true, local3, GUARD_GOAL_DESIRE_RET_Continue, true)
            local5:SetLifeEndSuccess(true)
        end
    elseif local4 <= local1 and arg1:GetTimer(0) <= 0 then
        if 3 < arg0:GetExistMeshOnLineDist(TARGET_SELF, AI_DIR_TYPE_B, 4.5) then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 6001, TARGET_ENE_0, 0, AI_DIR_TYPE_B, 4)
            arg1:SetTimer(0, arg0:GetRandam_Float(0.5, 2.5))
        else
            SideWayForFearOfFire_AddWaitGoal(arg0, arg1, 1)
        end
    else
        arg1:SetNumber(7, 1)
        if arg1:GetTimer(1) <= 0 then
            arg1:SetTimer(1, 4.5)
        end
        arg1:SetNumber(3, arg0:GetRandam_Float(0.5, 5))
        local local5 = arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 20, TARGET_ENE_0, local2, arg0:GetRandam_Int(30, 45), true, true, local3, GUARD_GOAL_DESIRE_RET_Continue, true)
        local5:SetLifeEndSuccess(true)
    end
    return 
end

function SideWayForFearOfFire_AddWaitGoal(arg0, arg1, arg2)
    local local0 = arg1:GetParam(1)
    if local0 == -1 then
        arg1:AddSubGoal(GOAL_COMMON_Wait, arg2, TARGET_ENE_0)
    else
        arg1:AddSubGoal(GOAL_COMMON_Guard, arg2, local0, TARGET_ENE_0, GUARD_GOAL_DESIRE_RET_Success, true)
    end
    return 
end

return 
