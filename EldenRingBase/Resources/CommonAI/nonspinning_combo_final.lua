REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboFinal, 0, "EzState�ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboFinal, 1, "�U���ΏہyType�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboFinal, 2, "���������yType�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboFinal, 3, "��U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboFinal, 4, "���U���p�x", 0)
ENABLE_COMBO_ATK_CANCEL(GOAL_COMMON_NonspinningComboFinal)
function NonspinningComboFinal_Activate(arg0, arg1)
    arg1:AddSubGoal(GOAL_COMMON_CommonAttack, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 180, 0, 180, false, true, false, true, arg1:GetParam(3), arg1:GetParam(4), true)
    return 
end

function NonspinningComboFinal_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function NonspinningComboFinal_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_NonspinningComboFinal, true)
function NonspinningComboFinal_Interupt(arg0, arg1)
    return false
end

return 
