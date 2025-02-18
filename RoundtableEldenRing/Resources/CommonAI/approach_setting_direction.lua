REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 0, "Ú®ÎÛ", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 1, "B»è£", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 2, "ùñÎÛ", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 3, "à­?", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 4, "K[hEzStateÔ", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 5, "Ú®ûü", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 6, "wèûüÖÌ£", 0)
REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ApproachSettingDirection, true)
REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_ApproachSettingDirection, true)
function ApproachSettingDirection_Activate(arg0, arg1)
    local local0 = arg1:GetParam(0)
    local local1 = arg1:GetParam(1)
    local local2 = arg1:GetParam(4)
    arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, -1, local0, arg1:GetParam(5), local1, arg1:GetParam(2), arg1:GetParam(3), arg1:GetParam(6))
    if 0 < local2 and local1 < arg0:GetDist(local0) then
        arg0:DoEzAction(arg1:GetLife(), local2)
    end
    return 
end

function ApproachSettingDirection_Update(arg0, arg1, arg2)
    if arg1:GetSubGoalNum() <= 0 then
        return GOAL_RESULT_Success
    else
        return GOAL_RESULT_Continue
    end
end

function ApproachSettingDirection_Terminate(arg0, arg1)
    return 
end

function ApproachSettingDirection_Interupt(arg0, arg1)
    return false
end

return 
