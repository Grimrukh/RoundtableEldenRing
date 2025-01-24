RegisterTableGoal(GOAL_COMMON_SetTimerRealtime, "SetTimerRealtime")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_SetTimerRealtime, true)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SetTimerRealtime, 0, "タイマーインデックス", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SetTimerRealtime, 1, "時間", 0)
Goal.Activate = function (arg0, arg1, arg2)
    arg1:SetTimer(arg2:GetParam(0), arg2:GetParam(1))
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

return 
