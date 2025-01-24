RegisterTableGoal(GOAL_COMMON_MoveToMultiPoint, "GOAL_COMMON_MoveToMultiPoint")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_COMMON_MoveToMultiPoint, true)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 0, "到達判定距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 1, "旋回対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 2, "歩くか", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 3, "ガード番号", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 4, "ポイント1", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 5, "ポイント2", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 6, "ポイント3", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 7, "ポイント4", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 8, "ポイント5", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 9, "ポイント6", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 10, "ポイント7", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 11, "ポイント8", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 12, "ポイント9", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_MoveToMultiPoint, 13, "ポイント10", 0)
Goal.Activate = function (arg0, arg1, arg2)
    local local0 = true
    local local1 = 1
    for local2 = 5 - local1, 13, local1 do
        if arg2:GetParam(local2) == nil or arg2:GetParam(local2) <= 0 then
            arg2:SetNumber(0, local2 - 1)
            local0 = false
            break
        end
    end
    if local0 == true then
        arg2:SetNumber(0, 13)
    end
    local2 = 9999
    local local3 = -1
    local local4 = 1
    for local1 = 4 - local4, arg2:GetNumber(0) - 1, local4 do
        arg1:SetEventMoveTarget(arg2:GetParam(local1))
        local local5 = arg1:GetDist(POINT_EVENT)
        if local5 < local2 then
            local2 = local5
            local3 = local1
        end
    end
    local4 = 1
    for local1 = local3 - local4, arg2:GetNumber(0), local4 do
        arg2:AddSubGoal(GOAL_COMMON_MoveToPoint, arg2:GetLife(), arg2:GetParam(local1), arg2:GetParam(0), arg2:GetParam(1), arg2:GetParam(2), arg2:GetParam(3))
    end
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    if arg2:GetSubGoalNum() <= 0 then
        if arg1:GetDist(arg2:GetParam(arg2:GetNumber(0))) <= arg2:GetParam(0) then
            return GOAL_RESULT_Success
        end
        local local0 = 9999
        local local1 = -1
        local local2 = 1
        for local3 = 4 - local2, arg2:GetNumber(0), local2 do
            arg1:SetEventMoveTarget(arg2:GetParam(local3))
            local local4 = arg1:GetDist(POINT_EVENT)
            if local4 < local0 then
                local0 = local4
                local1 = local3
            end
        end
        local2 = 1
        for local3 = local1 - local2, arg2:GetNumber(0), local2 do
            arg2:AddSubGoal(GOAL_COMMON_MoveToPoint, arg2:GetLife(), arg2:GetParam(local3), arg2:GetParam(0), arg2:GetParam(1), arg2:GetParam(2), arg2:GetParam(3))
        end
    end
    return GOAL_RESULT_Continue
end

return 
