REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboRepeat, 0, "StateID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboRepeat, 1, "�Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboRepeat, 2, "��������", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboRepeat, 3, "��U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboRepeat, 4, "���U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboRepeat, 5, "�����p�x", 0)
ENABLE_COMBO_ATK_CANCEL(GOAL_COMMON_ComboRepeat)
function ComboRepeat_Activate(arg0, arg1)
    arg1:AddSubGoal(GOAL_COMMON_CommonAttack, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 90, 0, 90, true, true, false, false, arg1:GetParam(3), arg1:GetParam(4), true)
    return 
end

function ComboRepeat_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function ComboRepeat_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ComboRepeat, true)
function ComboRepeat_Interupt(arg0, arg1)
    return false
end

return 
