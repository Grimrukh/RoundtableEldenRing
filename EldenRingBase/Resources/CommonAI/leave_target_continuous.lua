REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTarget_Continuous, 0, "移動対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTarget_Continuous, 1, "到達判定距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTarget_Continuous, 2, "旋回対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTarget_Continuous, 3, "歩くか", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTarget_Continuous, 4, "ガード番号", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTarget_Continuous, 5, "ガード終了時の終了結果", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTarget_Continuous, 6, "ガード寿命が尽きたら成功か", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_LeaveTarget_Continuous, 7, "パスチェックを行う距離", 0)
function LeaveTargetContinuous_Activate(arg0, arg1)
    local local0 = arg1:GetParam(1)
    arg1:SetNumber(0, 0)
    arg1:AddSubGoal(GOAL_COMMON_LeaveTargetToPathEnd, -1, arg1:GetParam(0), 9999, arg1:GetParam(2), arg1:GetParam(3), arg1:GetParam(4), arg1:GetParam(5), arg1:GetParam(6), arg1:GetParam(7))
    return 
end

function LeaveTargetContinuous_Update(arg0, arg1)
    local local0 = arg1:GetParam(7)
    if arg1:GetParam(1) < arg0:GetDist(arg1:GetParam(0)) then
        return GOAL_RESULT_Success
    elseif arg1:GetSubGoalNum() <= 0 then
        if arg1:GetNumber(0) == 0 then
            local local1 = {AI_DIR_TYPE_BL, AI_DIR_TYPE_BR, AI_DIR_TYPE_L, AI_DIR_TYPE_R}
            local local2 = {225, 135, 270, 90}
            local local3 = false
            local local4 = 1
            for local5 = 1 - local4, 4, local4 do
                local local6 = arg0:GetRandam_Int(1, table.getn(local1))
                local3 = SpaceCheck(arg0, arg1, local2[local6], local0)
                arg0:SetAIFixedMoveTarget(TARGET_SELF, local1[local6], 5)
                table.remove(local1, local6)
                table.remove(local2, local6)
                if local3 ~= true then

                else
                    if local3 == true then
                        arg1:AddSubGoal(GOAL_COMMON_Turn, 3, POINT_AI_FIXED_POS)
                    else
                        arg0:SetAIFixedMoveTarget(TARGET_SELF, AI_DIR_TYPE_B, 5)
                        arg1:AddSubGoal(GOAL_COMMON_Turn, 3, POINT_AI_FIXED_POS)
                    end
                    arg1:SetNumber(0, 1)
                end
            end
            if local3 == true then
                arg1:AddSubGoal(GOAL_COMMON_Turn, 3, POINT_AI_FIXED_POS)
            else
                arg0:SetAIFixedMoveTarget(TARGET_SELF, AI_DIR_TYPE_B, 5)
                arg1:AddSubGoal(GOAL_COMMON_Turn, 3, POINT_AI_FIXED_POS)
            end
            arg1:SetNumber(0, 1)
        elseif arg1:GetTimer(0) <= 0 then
            arg0:SetAIFixedMoveTarget(TARGET_SELF, AI_DIR_TYPE_B, 1)
            arg1:AddSubGoal(GOAL_COMMON_LeaveTargetToPathEnd, -1, POINT_AI_FIXED_POS, 9999, arg1:GetParam(2), arg1:GetParam(3), arg1:GetParam(4), arg1:GetParam(5), arg1:GetParam(6), local0)
            arg1:SetTimer(0, 1)
            arg1:SetNumber(0, 0)
        else
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1, TARGET_NONE, 0, 0, 0)
        end
    end
    return GOAL_RESULT_Continue
end

function LeaveTargetContinuous_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_LeaveTarget_Continuous, true)
function LeaveTargetContinuous_Interupt(arg0, arg1)
    return false
end

return 
