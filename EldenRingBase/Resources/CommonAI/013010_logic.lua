function common13010_Logic(arg0)
    local local0 = arg0:GetEventRequest()
    local local1 = arg0:IsSearchTarget(TARGET_ENE_0)
    local local2 = arg0:GetCurrTargetType()
    local local3 = arg0:GetPrevTargetState()
    if local0 == 100 then
        arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 5, POINT_INITIAL, 0.5, TARGET_SELF, true, -1)
    elseif local0 == 110 then
        arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 5, POINT_INITIAL, 0.5, TARGET_SELF, false, -1)
    elseif RideRequest(arg0, 10, -1) then
        arg0:AddTopGoal(GOAL_COMMON_Mount, 10, 1.2)
    else
        COMMON_EasySetup3(arg0)
    end
    return 
end

function common13010_Interupt(arg0, arg1)
    return 
end

return 
