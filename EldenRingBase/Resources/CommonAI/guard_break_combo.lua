RegisterTableGoal(GOAL_COMMON_GuardBreakCombo, "GuardBreakCombo")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_GuardBreakCombo, true)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakCombo, 0, "�P�i�ڂ̍U���ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakCombo, 1, "�Q�i�ڂ̍U���ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakCombo, 2, "�U���Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakCombo, 3, "���������i�Q�i�ڂɓK�������j", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakCombo, 4, "�U���O���񎞊�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakCombo, 5, "���ʔ���p�x", 0)
Goal.Activate = function (arg0, arg1, arg2)
    local local0 = arg2:GetParam(2)
    arg2:AddSubGoal(GOAL_COMMON_GuardBreakTunable, 10, arg2:GetParam(0), local0, 10, arg2:GetParam(4), arg2:GetParam(5), 0, 0)
    arg2:AddSubGoal(GOAL_COMMON_ComboFinal, 10, arg2:GetParam(1), local0, arg2:GetParam(3), 0)
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

return 
