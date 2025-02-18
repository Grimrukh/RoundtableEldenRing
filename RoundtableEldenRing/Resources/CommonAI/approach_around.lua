REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachAround, 0, "Ú®ÎÛ", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachAround, 1, "B»è£", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachAround, 2, "ùñÎÛ", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachAround, 3, "à­?", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachAround, 4, "K[hEzStateÔ", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachAround, 5, "Ú®ûü", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachAround, 6, "wèûüÖÌ£", 0)
REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ApproachAround, true)
REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_ApproachAround, true)
function ApproachAround_Activate(arg0, arg1)
    local local0 = arg1:GetParam(0)
    local local1 = arg1:GetParam(1)
    local local2 = arg1:GetParam(4)
    arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, -1, local0, arg1:GetParam(5), local1, arg1:GetParam(2), arg1:GetParam(3), arg1:GetParam(6), nil, false, true)
    if 0 < local2 and local1 < arg0:GetDist(local0) then
        arg0:DoEzAction(arg1:GetLife(), local2)
    end
    return 
end

function ApproachAround_Update(arg0, arg1, arg2)
    if arg1:GetSubGoalNum() <= 0 then
        return GOAL_RESULT_Success
    else
        return GOAL_RESULT_Continue
    end
end

function ApproachAround_Terminate(arg0, arg1)
    return 
end

function ApproachAround_Interupt(arg0, arg1)
    return false
end

return 
