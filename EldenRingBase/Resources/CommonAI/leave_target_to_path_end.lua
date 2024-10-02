REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTargetToPathEnd, 0, "移動対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTargetToPathEnd, 1, "到達判定距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTargetToPathEnd, 2, "旋回対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTargetToPathEnd, 3, "歩くか", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTargetToPathEnd, 4, "ガード番号", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTargetToPathEnd, 5, "ガード終了時の終了結果", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTargetToPathEnd, 6, "ガード寿命が尽きたら成功か", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTargetToPathEnd, 7, "パスチェックを行う距離", 0)
function LeaveTargetToPathEnd_Activate(arg0, arg1)
    arg1:SetTimer(0, 1)
    local local0 = arg1:GetParam(1)
    arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, -1, arg1:GetParam(0), arg1:GetParam(1), arg1:GetParam(2), arg1:GetParam(3), arg1:GetParam(4), arg1:GetParam(5), arg1:GetParam(6))
    return 
end

function LeaveTargetToPathEnd_Update(arg0, arg1)
    local local0 = GOAL_RESULT_Continue
    if true == arg1:IsFinishTimer(0) then
        arg1:SetTimer(0, 1)
        if SpaceCheck(arg0, arg1, 0, arg1:GetParam(7)) == false then
            local0 = GOAL_RESULT_Success
        end
    end
    return local0
end

function LeaveTargetToPathEnd_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_LeaveTargetToPathEnd, true)
function LeaveTargetToPathEnd_Interupt(arg0, arg1)
    return false
end

return 
