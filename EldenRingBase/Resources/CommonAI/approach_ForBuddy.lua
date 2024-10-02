REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachForBuddy, 0, "追従対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachForBuddy, 1, "相対位置への到達判定距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachForBuddy, 2, "旋回対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachForBuddy, 3, "歩く?", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachForBuddy, 4, "ガードEzState番号", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachForBuddy, 5, "相対位置への基準角", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachForBuddy, 6, "相対位置の角度幅", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachForBuddy, 7, "相対位置への距離", 0)
REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ApproachForBuddy, true)
function ApproachForBuddy_Activate(arg0, arg1)
    local local0 = arg1:GetParam(7)
    arg0:AddObserveAreaCustom(0, TARGET_HOSTPLAYER, TARGET_ENE_0, AI_DIR_TYPE_F, 360, 180, 16)
    if local0 + 4 < arg0:GetDist(TARGET_HOSTPLAYER) then
        arg1:SetNumber(0, 0)
    elseif local0 + 2 < arg0:GetDist(TARGET_HOSTPLAYER) then
        arg1:SetNumber(0, 1)
    else
        arg1:SetNumber(0, 2)
    end
    ApproachForBuddy_AddInnerGoal(arg0, arg1)
    if 0 < guardActionId and range < arg0:GetDist(targetType) then
        arg0:DoEzAction(life_time, guardActionId)
    end
    return 
end

function ApproachForBuddy_Update(arg0, arg1, arg2)
    if arg1:GetNumber(0) == 1 and arg1:GetParam(7) + 4 < arg0:GetDist(arg1:GetParam(0)) then
        arg1:SetNumber(0, 0)
        arg1:ClearSubGoal()
        ApproachForBuddy_AddInnerGoal(arg0, arg1)
    end
    if arg1:GetSubGoalNum() <= 0 then
        if arg1:GetNumber(0) == 0 then
            arg1:SetNumber(0, 1)
        elseif arg1:GetNumber(0) == 1 then
            arg1:SetNumber(0, 2)
        else
            return GOAL_RESULT_SUCCESS
        end
        ApproachForBuddy_AddInnerGoal(arg0, arg1)
    end
    return GOAL_RESULT_Continue
end

function ApproachForBuddy_Terminate(arg0, arg1)
    arg0:DeleteObserve(0)
    return 
end

function ApproachForBuddy_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_Inside_ObserveArea) and arg0:IsInsideObserve(0) then
        arg1:ClearSubGoal()
        arg0:Replaning()
        arg0:DeleteObserve(0)
        return true
    else
        return false
    end
end

function ApproachForBuddy_AddInnerGoal(arg0, arg1)
    local local0 = arg1:GetLife()
    local local1 = arg1:GetParam(0)
    local local2 = arg1:GetParam(2)
    local local3 = arg1:GetParam(4)
    local local4 = arg1:GetParam(5)
    local local5 = arg1:GetParam(6)
    local local6 = arg1:GetParam(7)
    if arg1:GetNumber(0) == 0 then
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, -1, local1, local6 + 2, local2, arg1:GetParam(3), local3)
    elseif arg1:GetNumber(0) == 1 then
        local local7 = arg0:GetRandam_Int(local4 - local5, local4 + local5)
        arg0:SetAIFixedMoveTargetSpecifyAngle(local1, local7, arg0:GetExistMeshOnLineDistSpecifyAngle(local1, local7, local6, AI_SPA_DIR_TYPE_TargetF), AI_SPA_DIR_TYPE_TargetF)
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, -1, POINT_AI_FIXED_POS, arg1:GetParam(1), local2, true, local3, -1, -1, AI_CALC_DIST_TYPE__XZ)
    else
        arg1:AddSubGoal(GOAL_COMMON_Wait, 0.5, TARGET_SELF)
    end
    return 
end

return 
