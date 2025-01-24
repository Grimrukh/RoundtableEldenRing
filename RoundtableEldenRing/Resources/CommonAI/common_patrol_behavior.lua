function COMMON_PatrolBehavior_FlagInitialize(arg0, arg1)
    local local0 = arg0:GetMovePointNumber()
    if arg0:GetStringIndexedNumber("COMMON_PatrolBehavior_MovePointIdx") ~= local0 or arg1 then
        arg0:SetStringIndexedNumber("COMMON_PatrolBehavior_DoneAct", 0)
    end
    if not not arg0:IsSearchLowState() or not not arg0:IsSearchHighState() or not not arg0:IsCautionState() or arg0:IsBattleState() then
        arg0:SetStringIndexedNumber("COMMON_PatrolBehavior_DoneAct", 1)
    end
    arg0:SetStringIndexedNumber("COMMON_PatrolBehavior_MovePointIdx", local0)
    return 
end

function COMMON_PatrolBehavior(arg0, arg1, arg2)
    local local0 = arg0:GetMovePointActionId(arg0:GetPrevMovePointNumber())
    if arg2 ~= nil and arg2 ~= -1 then
        local0 = arg2
    end
    if local0 == 402000 then
        arg1:AddSubGoal(GOAL_COMMON_WaitWithAnime, -1, 3037, TARGET_SELF)
        return true
    elseif local0 == 405099 then
        arg1:AddSubGoal(GOAL_COMMON_WaitWithAnime, -1, 3031, TARGET_SELF)
        return true
    elseif local0 == 449100 then
        arg1:AddSubGoal(GOAL_COMMON_WaitWithAnime, -1, 20020, TARGET_SELF)
        return true
    elseif local0 == 455001 then
        arg1:AddSubGoal(GOAL_COMMON_WaitWithAnime, -1, 20002, TARGET_SELF)
        return true
    elseif local0 == 460000 then
        arg1:AddSubGoal(GOAL_COMMON_WaitWithAnime, -1, 3033, TARGET_SELF)
        return true
    elseif 900001 <= local0 and local0 <= 900099 then
        arg1:AddSubGoal(GOAL_COMMON_Wait, local0 - 900000, TARGET_SELF)
        return true
    elseif 910001 <= local0 and local0 <= 919999 then
        arg1:AddSubGoal(GOAL_COMMON_Wait, (local0 - 910000) / 100, TARGET_SELF)
        return true
    elseif 1000000 <= local0 and local0 <= 1099999 then
        local local1 = local0 - 1000000
        if (3000 > local1 or local1 > 3039) and (3100 > local1 or local1 > 3104) and (3200 > local1 or local1 > 3204) and (20000 > local1 or local1 > 20029) then
            return false
        else
            arg1:AddSubGoal(GOAL_COMMON_WaitWithAnime, -1, local1, TARGET_SELF)
            return true
        end
    else
        return false
    end
end

return 
