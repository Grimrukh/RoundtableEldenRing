REGISTER_GOAL_UPDATE_TIME(GOAL_COMMON_Fall, 0.1, 0.2)
REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_Fall, true)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Fall, 0, "�^�[�Q�b�g�yType�z", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Fall, 1, "�����J�nEzState�ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Fall, 2, "������~EzState�ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Fall, 3, "������~�}�[�W��[m]", 0)
function Fall_Activate(arg0, arg1)
    if arg0:GetDistYSigned(arg1:GetParam(0)) <= 0 then
        arg0:SetAttackRequest(arg1:GetParam(1))
    end
    return 
end

function Fall_Update(arg0, arg1)
    if arg1:GetParam(3) < arg0:GetDistYSigned(arg1:GetParam(0)) then
        return GOAL_RESULT_Success
    end
    arg0:SetAttackRequest(arg1:GetParam(1))
end

function Fall_Terminate(arg0, arg1)
    arg0:SetAttackRequest(arg1:GetParam(2))
    return 
end

function Fall_Interupt(arg0, arg1)
    return false
end

return 
