REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 0, "�ړ��Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 1, "���B���苗��", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 2, "����Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 3, "����?", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 4, "�K�[�hEzState�ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 5, "�ړ�����", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachSettingDirection, 6, "�w������ւ̋���", 0)
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
