REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_AttackNonCancel, 0, "EzStateID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_AttackNonCancel, 1, "�U���Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_AttackNonCancel, 2, "��������", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_AttackNonCancel, 3, "�U���O���񎞊�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_AttackNonCancel, 4, "���ʔ���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_AttackNonCancel, 5, "��U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_AttackNonCancel, 6, "���U���p�x", 0)
function AttackNonCancel_Activate(arg0, arg1)
    local local0 = arg1:GetParam(3)
    local local1 = arg1:GetParam(4)
    if local0 < 0 then
        local0 = 1.5
    end
    if local1 < 0 then
        local1 = 20
    end
    arg1:AddSubGoal(GOAL_COMMON_CommonAttack, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 180, local0, local1, false, false, false, false, arg1:GetParam(5), arg1:GetParam(6), false)
    return 
end

function AttackNonCancel_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function AttackNonCancel_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_AttackNonCancel, true)
function AttackNonCancel_Interupt(arg0, arg1)
    return false
end

return 
