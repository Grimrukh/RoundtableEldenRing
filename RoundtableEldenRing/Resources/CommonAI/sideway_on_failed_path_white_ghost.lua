REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_SideWay_On_FailedPath_WhiteGhost, 0, "パスチェック間隔", 0)
function SideWayOnFailedPathWhiteGhost_Activate(arg0, arg1)
    arg1:SetTimer(0, arg1:GetParam(0))
    SideWayOnFailedPathWhiteGhost_AddInnerGoal(arg0, arg1)
    return 
end

function SideWayOnFailedPathWhiteGhost_Update(arg0, arg1)
    if true == arg1:IsFinishTimer(0) then
        if true == arg0:CheckDoesExistPath(TARGET_HOSTPLAYER, AI_DIR_TYPE_CENTER, 0) then
            return GOAL_RESULT_Success
        end
        arg1:SetTimer(0, arg1:GetParam(0))
    end
    if arg0:IsBattleState() then
        return GOAL_RESULT_Success
    elseif arg1:GetSubGoalNum() <= 0 then
        SideWayOnFailedPathWhiteGhost_AddInnerGoal(arg0, arg1)
    end
    return GOAL_RESULT_Continue
end

function SideWayOnFailedPathWhiteGhost_Terminate(arg0, arg1)
    return 
end

function SideWayOnFailedPathWhiteGhost_Interupt(arg0, arg1)
    return false
end

function SideWayOnFailedPathWhiteGhost_AddInnerGoal(arg0, arg1)
    local local0 = arg1:GetParam(1)
    local local1 = true
    if arg0:GetRandam_Int(0, 9) == 0 and arg0:IsExistMeshOnLine(TARGET_SELF, AI_DIR_TYPE_B, 2) then
        local local2 = arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, LeaveTime, TARGET_HOSTPLAYER, 9999, TARGET_HOSTPLAYER, local1, -1, GUARD_GOAL_DESIRE_RET_Continue, true)
        local2:SetFailedEndOption(AI_GOAL_FAILED_END_OPT__PARENT_NEXT_SUB_GOAL)
    else
        local local3 = 2
        local local4 = arg0:GetToTargetAngle(TARGET_HOSTPLAYER)
        local local5 = false
        local local6 = false
        local local7 = 0
        if local3 <= arg0:GetExistMeshOnLineDistSpecifyAngle(TARGET_SELF, 90 + local4, local3 + 2, AI_SPA_DIR_TYPE_TargetF) then
            local5 = true
        end
        if local3 <= arg0:GetExistMeshOnLineDistSpecifyAngle(TARGET_SELF, -90 + local4, local3 + 2, AI_SPA_DIR_TYPE_TargetF) then
            local6 = true
        end
        if not (local5 ~= false or local6 ~= false) or local5 == true and local6 == true then
            local7 = arg0:GetRandam_Int(0, 1)
        elseif local5 == true then
            local7 = 1
        else
            local7 = 0
        end
        arg1:AddSubGoal(GOAL_COMMON_SidewayMove, arg0:GetRandam_Float(2, 4), TARGET_HOSTPLAYER, local7, arg0:GetRandam_Int(30, 45), local1, true, -1, GUARD_GOAL_DESIRE_RET_Continue, true)
        arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0.5, 1.5), TARGET_SELF)
    end
    return 
end

return 
