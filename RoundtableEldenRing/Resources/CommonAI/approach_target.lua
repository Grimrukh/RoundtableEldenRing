REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget, 0, "�ړ��Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget, 1, "���B���苗��", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget, 2, "����Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget, 3, "����?", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget, 4, "�K�[�hEzState�ԍ�", 0)
REGISTER_GOAL_UPDATE_TIME(GOAL_COMMON_ApproachTarget, 0, 0)
function ApproachTarget_Activate(arg0, arg1)
    local local0 = arg1:GetLife()
    local local1 = arg1:GetParam(0)
    local local2 = arg1:GetParam(1)
    local local3 = arg1:GetParam(5)
    local local4 = arg1:GetParam(6)
    arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, local0, local1, AI_DIR_TYPE_CENTER, local2, arg1:GetParam(2), arg1:GetParam(3), 0, nil, arg1:GetParam(7))
    if local2 < arg0:GetDist(local1) or PLAN_STYLE_GUARD <= arg0:GetBehaviorStateId(0) then
        GuardGoalSubFunc_Activate(arg0, local0, arg1:GetParam(4))
    end
    return 
end

function ApproachTarget_Update(arg0, arg1, arg2)
    return GuardGoalSubFunc_Update(arg0, arg1, arg1:GetParam(4), arg1:GetParam(5), arg1:GetParam(6))
end

function ApproachTarget_Terminate(arg0, arg1)
    return 
end

function ApproachTarget_Interupt(arg0, arg1)
    return GuardGoalSubFunc_Interrupt(arg0, arg1, arg1:GetParam(4), arg1:GetParam(5))
end

return 
