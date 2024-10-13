REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToWaitandSee, 0, "���B���苗��", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToWaitandSee, 1, "����Ώ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToWaitandSee, 2, "����?", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToWaitandSee, 3, "�p�X�`�F�b�N�̃C���^�[�o��", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToWaitandSee, 4, "�K�[�hEzState�ԍ�", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToWaitandSee, 5, "�K�[�h�S�[���I���^�C�v", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToWaitandSee, 6, "�K�[�h�S�[��:�����t�����琬���Ƃ��邩", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToWaitandSee, 7, "���B�����XZ���ʋ������g�p���邩�H", 0)
REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_MoveToWaitandSee, true)
function MoveToWaitandSee_Activate(arg0, arg1)
    local local0 = arg1:GetParam(4)
    local local1 = arg1:GetParam(5)
    local local2 = arg1:GetParam(6)
    arg1:SetTimer(0, arg1:GetParam(3))
    arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, arg1:GetLife(), POINT_WaitAndSee, AI_DIR_TYPE_CENTER, arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), 0, nil, arg1:GetParam(7))
    return 
end

function MoveToWaitandSee_Update(arg0, arg1, arg2)
    if arg1:GetSubGoalNum() <= 0 then
        return GOAL_RESULT_Success
    elseif true == arg1:IsFinishTimer(0) then
        if arg0:CheckDoesExistPath(TARGET_ENE_0, AI_DIR_TYPE_CENTER, 0) then
            return GOAL_RESULT_Failed
        end
        arg1:SetTimer(0, arg1:GetParam(3))
    end
    return GOAL_RESULT_Continue
end

function MoveToWaitandSee_Terminate(arg0, arg1)
    return 
end

function MoveToWaitandSee_Interupt(arg0, arg1)
    return false
end

return 
