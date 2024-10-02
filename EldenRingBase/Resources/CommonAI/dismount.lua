REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_Dismount, true)
REGISTER_GOAL_UPDATE_TIME(GOAL_COMMON_Dismount, 0, 0)
local local0 = 90010
function _GetRequestId_forDismount(arg0, arg1)
    local local0 = arg0
    if arg1:IsNpcPlayer() == true and arg0 == UPVAL0 then
        local0 = NPC_ATK_RideDismount
    end
    return local0
end

function Dismount_Activate(arg0, arg1)
    local local0 = arg1:GetLife()
    arg1:SetTimer(0, 2)
    arg1:SetTimer(1, 5)
    arg0:SetAttackRequest(_GetRequestId_forDismount(UPVAL0, arg0))
    return 
end

function Dismount_Update(arg0, arg1)
    local local0 = UPVAL0
    if arg0:IsRiding(TARGET_SELF) == false then
        return GOAL_RESULT_Success
    elseif arg1:GetTimer(1) <= 0 then
        arg0:SetTimer(12, 900)
        return GOAL_RESULT_Failed
    elseif arg0:IsEnableComboAttack() then
        return GOAL_RESULT_Success
    elseif arg0:IsEnableCancelMove() then
        return GOAL_RESULT_Success
    elseif arg0:IsEnableCancelAttack() then
        return GOAL_RESULT_Success
    elseif arg0:IsFinishAttack_CheckAttackNo(_GetRequestId_forDismount(local0, arg0)) then
        return GOAL_RESULT_Success
    elseif arg0:IsStartAttack_CheckAttackNo(_GetRequestId_forDismount(local0, arg0)) then
        if arg1:IsFinishTimer(0) then
            arg0:SetAttackRequest(_GetRequestId_forDismount(local0, arg0))
        end
    else
        arg0:SetAttackRequest(_GetRequestId_forDismount(local0, arg0))
    end
    return GOAL_RESULT_Continue
end

function Dismount_Terminate(arg0, arg1)
    return 
end

function Dismount_Interupt(arg0, arg1)
    return false
end

return 
