REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Wait_On_FailedPath, 0, "�p�X�`�F�b�N�Ԋu", 0)
function WaitOnFailedPath_Activate(arg0, arg1)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 1, 0, 0, 0, 0)
    return 
end

function WaitOnFailedPath_Update(arg0, arg1)
    local local0 = GOAL_RESULT_Continue
    if arg1:GetSubGoalNum() <= 0 then
        doesExist = arg0:CheckDoesExistPath(TARGET_ENE_0, AI_DIR_TYPE_CENTER, 0)
        if true == doesExist then
            local0 = GOAL_RESULT_Success
        else
            checkInterval = arg1:GetParam(0)
            arg1:AddSubGoal(GOAL_COMMON_Wait, checkInterval, 0, 0, 0, 0)
            local0 = GOAL_RESULT_Continue
        end
    end
    return local0
end

function WaitOnFailedPath_Terminate(arg0, arg1)
    return 
end

function WaitOnFailedPath_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) then
        return true
    else
        return 
    end
end

return 
