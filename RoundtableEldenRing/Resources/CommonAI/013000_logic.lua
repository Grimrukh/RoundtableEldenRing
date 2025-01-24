function common13000_Logic(arg0)
    COMMON_Initialize(arg0)
    if COMMON_EasySetup_Initial(arg0) == false then
        local local0 = arg0:GetEventRequest()
        local local1 = arg0:IsSearchTarget(TARGET_ENE_0)
        local local2 = arg0:GetCurrTargetType()
        if local0 == 100 then
            arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 5, POINT_INITIAL, 0.5, TARGET_SELF, true, -1)
        elseif local0 == 110 then
            arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 5, POINT_INITIAL, 0.5, TARGET_SELF, false, -1)
        elseif RideRequest(arg0, 10, -1) then
            arg0:AddTopGoal(GOAL_COMMON_Mount, 10, 1.2)
        else
            if arg0:IsChangeState() then
                if not not arg0:IsFindState() or arg0:IsBattleState() then
                    if arg0:GetDist(TARGET_ENE_0) <= 8 and arg0:GetTimer(10) <= 0 then
                        arg0:SetTimer(10, 30)
                        arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3030, TARGET_ENE_0, 9999, 0, 180, 0, 0)
                    end
                elseif (not not arg0:IsCautionState() or arg0:GetPrevTargetState() == AI_TARGET_STATE__CAUTION) and arg0:GetTimer(11) <= 0 then
                    arg0:SetTimer(11, 10)
                    arg0:AddTopGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0, 3), TARGET_ENE_0, 0, 0, 0)
                    arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3031, TARGET_ENE_0, 9999, 0, 0, 0, 0)
                end
            end
            COMMON_EasySetup3(arg0)
        end
    end
    return 
end

function common13000_Interupt(arg0, arg1)
    return 
end

return 
