REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboAttack, 0, "EzState�ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboAttack, 1, "�U���ΏہyType�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboAttack, 2, "���������yType�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboAttack, 3, "��U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboAttack, 4, "���U���p�x", 0)
function NonspinningComboAttack_Activate(arg0, arg1)
    arg1:AddSubGoal(GOAL_COMMON_CommonAttack, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 180, 0, 180, true, true, false, true, arg1:GetParam(3), arg1:GetParam(4), true)
    return 
end

function NonspinningComboAttack_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function NonspinningComboAttack_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_NonspinningComboAttack, true)
function NonspinningComboAttack_Interupt(arg0, arg1)
    return false
end

return 
