REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttack_SuccessAngle180, 0, "EzStateID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttack_SuccessAngle180, 1, "�U���Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttack_SuccessAngle180, 2, "��������", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttack_SuccessAngle180, 3, "��U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttack_SuccessAngle180, 4, "���U���p�x", 0)
function ComboAttack180_Activate(arg0, arg1)
    arg1:AddSubGoal(GOAL_COMMON_CommonAttack, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 180, 1.5, 20, true, true, false, false, arg1:GetParam(3), arg1:GetParam(4), true)
    return 
end

function ComboAttack180_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function ComboAttack180_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ComboAttack_SuccessAngle180, true)
function ComboAttack180_Interupt(arg0, arg1)
    return false
end

return 
