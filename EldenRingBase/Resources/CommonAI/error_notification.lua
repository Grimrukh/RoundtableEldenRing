REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ErrorNotification, 0, "�G���[�R�[�h", 0)
REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ErrorNotification, true)
function ErrorNotification_Activate(arg0, arg1)
    if arg1:GetParam(0) == 0 then
        print("���G���[�S�[���ʒm�F�퓬�s���Ƃ��Ē�`����Ă��Ȃ�Act���I������܂����B��`���Ă��Ȃ��s���Ɋm�����ݒ肳��Ă��Ȃ����m�F���Ă�������")
    else
        print("���G���[�S�[���ʒm�F��O�G���[���Ă΂�܂���")
    end
    return 
end

function ErrorNotification_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function ErrorNotification_Terminate(arg0, arg1)
    return 
end

function ErrorNotification_Interupt(arg0, arg1)
    return false
end

return 
