REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttackTunableSpin, 0, "StateID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttackTunableSpin, 1, "�Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttackTunableSpin, 2, "��������", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttackTunableSpin, 3, "�U���O���񎞊�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttackTunableSpin, 4, "���ʔ���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttackTunableSpin, 5, "��U���p�x", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ComboAttackTunableSpin, 6, "���U���p�x", 0)
function ComboAttackTunableSpin_Activate(arg0, arg1)
    local local0 = arg1:GetParam(3)
    local local1 = arg1:GetParam(4)
    if local0 < 0 then
        local0 = 1.5
    end
    if local1 < 0 then
        local1 = 20
    end
    arg1:AddSubGoal(GOAL_COMMON_CommonAttack, arg1:GetLife(), arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 90, local0, local1, true, true, false, false, arg1:GetParam(5), arg1:GetParam(6), true)
    return 
end

function ComboAttackTunableSpin_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function ComboAttackTunableSpin_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ComboAttackTunableSpin, true)
function ComboAttackTunableSpin_Interupt(arg0, arg1)
    return false
end

return 
