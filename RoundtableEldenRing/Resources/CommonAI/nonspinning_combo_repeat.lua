REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboRepeat, 0, "EzState�ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboRepeat, 1, "�U���ΏہyType�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboRepeat, 2, "���������yType�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboRepeat, 3, "��U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NonspinningComboRepeat, 4, "���U���p�x", 0)
ENABLE_COMBO_ATK_CANCEL(GOAL_COMMON_NonspinningComboRepeat)
function NonspinningComboRepeat_Activate(arg0, arg1)
    arg1:AddSubGoal(GOAL_COMMON_CommonAttack, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 180, 0, 180, true, true, false, true, arg1:GetParam(3), arg1:GetParam(4), true)
    return 
end

function NonspinningComboRepeat_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function NonspinningComboRepeat_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_NonspinningComboRepeat, true)
function NonspinningComboRepeat_Interupt(arg0, arg1)
    return false
end

return 
