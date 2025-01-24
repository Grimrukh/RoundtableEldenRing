RegisterTableGoal(GOAL_COMMON_SetNumberRealtime, "SetTimerRealtime")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_SetNumberRealtime, true)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SetNumberRealtime, 0, "ナンバーインデックス", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SetNumberRealtime, 1, "番号", 0)
Goal.Activate = function (arg0, arg1, arg2)
    arg1:SetNumber(arg2:GetParam(0), arg2:GetParam(1))
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

return 
