REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_LadderAct, true)
function _GetId(arg0, arg1)
    local local0 = false
    if not not arg1:IsNpcPlayer() or arg1:IsLocalPlayer() then
        local0 = true
    end
    local local1 = arg0
    if local0 == true then
        if arg0 == 7210 then
            local1 = NPC_ATK_LadderUp
        elseif arg0 == 7220 then
            local1 = NPC_ATK_LadderDown
        end
    end
    return local1
end

local local0 = -1
local local1 = 0
local local2 = 1
local local3 = 2
local local4 = 3
local local5 = 4
local local6 = 5
local local7 = 6
local local8 = 7
local local9 = 8
local local10 = 9
local local11 = 23
local local12 = 7210
local local13 = 7220
local local14 = 7230
function LadderAct_Activate(arg0, arg1)
    local local0 = arg1:GetParam(0)
    local local1 = arg1:GetParam(1)
    local local2 = arg1:GetParam(2)
    local local3 = 0
    local local4 = arg0:CalcGetNearestLadderActDmyIdByLadder()
    if local4 == 191 then
        local3 = _GetId(7210, arg0)
    else
        local3 = _GetId(7220, arg0)
    end
    if arg0:GetLadderActState(TARGET_SELF) == UPVAL0 then
        if arg0:IsChrAroundLadderEdge(2, local4) == false then
            if arg0:CanStartLadderAttach() then
                arg1:AddSubGoal(GOAL_COMMON_HoverAdjust, -1)
                arg1:AddSubGoal(GOAL_COMMON_LadderMove, -1, 3000, TARGET_SELF, arg0:GetLadderDirMove(TARGET_SELF))
            end
        else
            arg0:RequestLadderWait()
            if local4 ~= 192 and local4 == 191 then

            end
        end
    end
    return 
end

function LadderAct_Update(arg0, arg1)
    arg1:AddLifeParentSubGoal(0.3)
    if arg1:GetSubGoalNum() <= 0 then
        return GOAL_RESULT_Success
    else
        return GOAL_RESULT_Continue
    end
end

function LadderAct_Terminate(arg0, arg1)
    return 
end

REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_LadderAct, true)
function LadderAct_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_Damaged) then
        return false
    else
        return false
    end
end

return 
