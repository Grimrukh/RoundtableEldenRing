REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WaitWithAnime, 0, "�A�j��ID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WaitWithAnime, 1, "����Ώ�", 1)
function WaitWithAnime_Activate(arg0, arg1)
    arg1:AddSubGoal(GOAL_COMMON_AttackNonCancel, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), 9999, 0, -1)
    return 
end

function WaitWithAnime_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function WaitWithAnime_Terminate(arg0, arg1)
    return 
end

function WaitWithAnime_Interupt(arg0, arg1)
    return false
end

return 
