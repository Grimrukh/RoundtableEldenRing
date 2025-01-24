REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Mount, 0, "到達判定距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Mount, 1, "乗れなかった場合のクールタイム秒数", 0)
REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_Mount, true)
REGISTER_GOAL_UPDATE_TIME(GOAL_COMMON_Mount, 0, 0)
local local0 = 90000
function _GetRequestId_forMount(arg0, arg1)
    local local0 = arg0
    if arg1:IsNpcPlayer() == true and arg0 == UPVAL0 then
        local0 = NPC_ATK_RideMount
    end
    return local0
end

function _GetCoolTime_forMount(arg0, arg1)
    local local0 = 300
    if arg1:GetParam(1) ~= nil and 0 < arg1:GetParam(1) then
        local0 = arg1:GetParam(1)
    end
    return local0
end

function Mount_Activate(arg0, arg1)
    if arg0:IsRiding(TARGET_SELF) then
        arg1:SetNumber(0, -1)
        return 
    end
    local local0 = arg0:IsSearchTarget(TARGET_RIDE_0)
    if local0 == false and arg0:ReserveRide(10) == true then
        local0 = arg0:IsSearchTarget(TARGET_RIDE_0)
    end
    if local0 == true then
        local local1 = TARGET_RIDE_0
        local local2 = arg1:GetParam(0)
        local local3 = 0
        local local4 = AI_DIR_TYPE_CENTER
        if arg0:HasSpecialEffectId(local1, 5210) then
            local3 = 2
            local4 = AI_DIR_TYPE_B
            local2 = 0.5
        elseif arg0:HasSpecialEffectId(local1, 5211) then
            local3 = 1.5
            local4 = AI_DIR_TYPE_B
            local2 = 0.5
        elseif arg0:HasSpecialEffectId(local1, 5212) then
            local3 = 3
            local4 = AI_DIR_TYPE_B
            local2 = 0.5
        elseif arg0:HasSpecialEffectId(local1, 5213) then
            local3 = 1
            local4 = AI_DIR_TYPE_B
            local2 = 0.5
        end
        if arg0:HasSpecialEffectId(TARGET_SELF, 5225) then
            local3 = 1.5
            local4 = AI_DIR_TYPE_B
            local2 = 0.5
        elseif arg0:HasSpecialEffectId(TARGET_SELF, 5226) then
            local3 = 1.5
            local4 = AI_DIR_TYPE_R
            local2 = 0.5
        elseif arg0:HasSpecialEffectId(TARGET_SELF, 5227) then
            local3 = 1.5
            local4 = AI_DIR_TYPE_L
            local2 = 0.5
        end
        if arg0:GetExistMeshOnLineDistEx(local1, local4, local3, 1, 0) < local3 then
            arg0:SetTimer(13, _GetCoolTime_forMount(arg0, arg1))
            arg1:SetNumber(0, -1)
        else
            arg1:AddSubGoal(GOAL_COMMON_ApproachSettingDirection, arg1:GetLife(), local1, local2, TARGET_SELF, false, -1, local4, local3)
            arg1:AddSubGoal(GOAL_COMMON_MountSub, 4)
            arg1:SetNumber(0, 0)
        end
    else
        arg1:SetNumber(0, -1)
    end
    return 
end

function Mount_Update(arg0, arg1)
    if arg1:GetLife() <= 0 and arg0:IsRiding(TARGET_SELF) == false then
        arg0:SetTimer(13, _GetCoolTime_forMount(arg0, arg1))
        return GOAL_RESULT_Failed
    elseif arg1:GetNumber(0) == 0 then
        if arg1:GetSubGoalNum() <= 0 then
            if arg1:GetLastSubGoalResult() == GOAL_RESULT_Success then
                return GOAL_RESULT_Success
            else
                return GOAL_RESULT_Failed
            end
        else
            return GOAL_RESULT_Continue
        end
    else
        return GOAL_RESULT_Failed
    end
end

function Mount_Terminate(arg0, arg1)
    return 
end

function Mount_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) then
        arg1:ClearSubGoal()
        arg0:SetTimer(13, _GetCoolTime_forMount(arg0, arg1))
        return true
    else
        return false
    end
end

REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_MountSub, true)
REGISTER_GOAL_UPDATE_TIME(GOAL_COMMON_MountSub, 0, 0)
function MountSub_Activate(arg0, arg1)
    local local0 = arg1:GetLife()
    arg0:ClearMoveRequest()
    arg0:TurnTo(TARGET_RIDE_0)
    arg0:SetAttackRequest(_GetRequestId_forMount(UPVAL0, arg0))
    return 
end

function MountSub_Update(arg0, arg1)
    if arg1:GetLife() <= 0 and arg0:IsRiding(TARGET_SELF) == false then
        arg0:SetTimer(13, _GetCoolTime_forMount(arg0, arg1))
        return GOAL_RESULT_Failed
    elseif arg0:IsEnableComboAttack() then
        return GOAL_RESULT_Success
    elseif arg0:IsEnableCancelMove() then
        return GOAL_RESULT_Success
    elseif arg0:IsEnableCancelAttack() then
        return GOAL_RESULT_Success
    elseif arg0:IsFinishAttack_CheckAttackNo(_GetRequestId_forMount(UPVAL0, arg0)) then
        return GOAL_RESULT_Success
    elseif arg0:IsStartAttack_CheckAttackNo(_GetRequestId_forMount(UPVAL0, arg0)) == false then
        arg0:SetAttackRequest(_GetRequestId_forMount(UPVAL0, arg0))
    end
    return GOAL_RESULT_Continue
end

function MountSub_Terminate(arg0, arg1)
    return 
end

function MountSub_Interupt(arg0, arg1)
    return false
end

return 
