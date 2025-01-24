function LadderWait_Activate(arg0, arg1)
    LadderWait_AddInnerGoal(arg0, arg1)
    arg1:SetNumber(0, 0)
    return 
end

function LadderWait_Update(arg0, arg1)
    if arg1:GetNumber(0) == 1 then
        if arg0:GetTimer(0) <= 0 then
            if arg0:IsChrAroundLadderEdge(2.5, dmyStartId) == false then
                return GOAL_RESULT_Success
            end
            arg1:SetTimer(0, arg0:GetRandam_Float(0, 2))
        end
    elseif arg0:IsChrAroundLadderEdge(2.5, arg0:CalcGetNearestLadderActDmyIdByLadder()) == false then
        arg1:SetTimer(0, arg0:GetRandam_Float(0, 2))
        arg1:SetNumber(0, 1)
    end
    if arg1:GetSubGoalNum() <= 0 then
        LadderWait_AddInnerGoal(arg0, arg1)
    end
    return GOAL_RESULT_Continue
end

function LadderWait_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_LadderAct, true)
function LadderWait_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_Damaged) then
        return false
    else
        return false
    end
end

function LadderWait_AddInnerGoal(arg0, arg1)
    local local0 = arg0:GetDistXZ(TARGET_ENE_0)
    if local0 > 1 and local0 <= 3 then
        local local1 = arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 2, TARGET_ENE_0, 999, TARGET_ENE_0, true, -1)
        local1:SetLifeEndSuccess(true)
    end
    local local1 = arg1:AddSubGoal(GOAL_COMMON_SidewayMove, arg0:GetRandam_Float(2, 4), TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, -1)
    local1:SetLifeEndSuccess(true)
    arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0.5, 1), TARGET_ENE_0)
    return 
end

return 
