REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakTunable, 0, "EzStateID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakTunable, 1, "�U���Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakTunable, 2, "��������", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakTunable, 3, "�U���O���񎞊ԁy�b�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakTunable, 4, "���ʔ���p�x�y�x�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakTunable, 5, "��U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_GuardBreakTunable, 6, "���U���p�x", 0)
function GuardBreakTunable_Activate(arg0, arg1)
    local local0 = arg1:GetParam(3)
    local local1 = arg1:GetParam(4)
    if local0 < 0 then
        local0 = 1.5
    end
    if local1 < 0 then
        local1 = 20
    end
    arg1:AddSubGoal(GOAL_COMMON_CommonAttack, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 90, local0, local1, true, true, true, false, arg1:GetParam(5), arg1:GetParam(6), true)
    return 
end

function GuardBreakTunable_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function GuardBreakTunable_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_GuardBreakTunable, true)
function GuardBreakTunable_Interupt(arg0, arg1)
    return false
end

return 
