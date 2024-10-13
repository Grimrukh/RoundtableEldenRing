REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTargetAllDirection, 0, "�ړ��Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTargetAllDirection, 1, "���B���苗��", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTargetAllDirection, 2, "����Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTargetAllDirection, 3, "����?", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTargetAllDirection, 4, "�K�[�hEzState�ԍ�", 0)
REGISTER_GOAL_UPDATE_TIME(GOAL_COMMON_ApproachTargetAllDirection, 0, 0)
function ApproachTargetAllDirection_Activate(arg0, arg1)
    local local0 = arg1:GetLife()
    local local1 = arg1:GetParam(0)
    local local2 = arg1:GetParam(1)
    local local3 = arg1:GetParam(5)
    local local4 = arg1:GetParam(6)
    arg0:SetMoveAllDirection_LegWalk2And4(true)
    arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, local0, local1, AI_DIR_TYPE_CENTER, local2, arg1:GetParam(2), arg1:GetParam(3), 0, nil, arg1:GetParam(7))
    if local2 < arg0:GetDist(local1) then
        GuardGoalSubFunc_Activate(arg0, local0, arg1:GetParam(4))
    end
    return 
end

function ApproachTargetAllDirection_Update(arg0, arg1, arg2)
    return GuardGoalSubFunc_Update(arg0, arg1, arg1:GetParam(4), arg1:GetParam(5), arg1:GetParam(6))
end

function ApproachTargetAllDirection_Terminate(arg0, arg1)
    arg0:SetMoveAllDirection_LegWalk2And4(false)
    return 
end

function ApproachTargetAllDirection_Interupt(arg0, arg1)
    return GuardGoalSubFunc_Interrupt(arg0, arg1, arg1:GetParam(4), arg1:GetParam(5))
end

return 
