REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget_ParallelMov, 0, "�ړ��Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget_ParallelMov, 1, "���B���苗��", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget_ParallelMov, 2, "����Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget_ParallelMov, 3, "����?", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget_ParallelMov, 4, "�K�[�hEzState�ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget_ParallelMov, 5, "�K�[�h�S�[���I���^�C�v", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ApproachTarget_ParallelMov, 6, "�K�[�h�S�[��:�������s�����琬���Ƃ��邩", 0)
REGISTER_GOAL_UPDATE_TIME(GOAL_COMMON_ApproachTarget_ParallelMov, 0, 0)
REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ApproachTarget_ParallelMov, true)
function ApproachTarget_ParallelMov_Activate(arg0, arg1)
    arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), arg1:GetParam(3), arg1:GetParam(4), arg1:GetParam(5), arg1:GetParam(6))
    return 
end

function ApproachTarget_ParallelMov_Update(arg0, arg1, arg2)
    arg0:RequestParallelMove()
    return GOAL_RESULT_Continue
end

function ApproachTarget_ParallelMov_Terminate(arg0, arg1)
    return 
end

function ApproachTarget_ParallelMov_Interupt(arg0, arg1)
    return false
end

return 
