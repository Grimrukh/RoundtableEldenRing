function common14020_Logic(arg0)
    COMMON_Initialize(arg0)
    if COMMON_EasySetup_Initial(arg0) == false then
        local local0 = arg0:GetEventRequest()
        local local1 = arg0:IsSearchTarget(TARGET_ENE_0)
        arg0:GetStringIndexedNumber("TimerStart_a")
        if arg0:GetStringIndexedNumber("TimerStart_a") == 0 then
            arg0:SetTimer(0, 100)
            arg0:SetTimer(1, 30)
            arg0:SetTimer(2, 30)
            arg0:SetTimer(2, 30)
            arg0:SetStringIndexedNumber("TimerStart_a", 1)
        end
        if arg0:IsChangeState() and arg0:IsCautionState() then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3031, TARGET_ENE_0, 9999, 0, 0, 0, 0)
        end
        if arg0:IsChangeState() and arg0:IsSearchLowState() == false and arg0:IsSearchHighState() == false and arg0:IsCautionState() == false and arg0:IsBattleState() == false and arg0:GetNumber(6) == 1 then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3033, TARGET_ENE_0, 9999, 0, 0, 0, 0)
            arg0:SetNumber(6, 0)
        end
        if arg0:IsFinishTimer(1) == true then
            if arg0:IsBattleState() then
                arg0:SetTimer(1, 30)
            elseif arg0:GetRandam_Int(1, 100) <= 40 and arg0:GetDist(TARGET_ENE_0) <= 20 then
                arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3030, TARGET_SELF, 9999, 0, 0, 0, 0)
                arg0:SetTimer(1, 45)
            end
        end
        if arg0:IsFinishTimer(0) == true then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3022, TARGET_SELF, DIST_Middle, 0, -1)
            arg0:SetStringIndexedNumber("TimerStart_a", 0)
        end
        if arg0:IsBattleState() then
            arg0:SetTimer(0, 100)
            arg0:SetTimer(2, 30)
        end
        if arg0:IsFinishTimer(2) == true then
            arg0:SetAIFixedMoveTargetSpecifyAngle(TARGET_LOCALPLAYER, 30, 1, AI_SPA_DIR_TYPE_TargetF)
            local local2 = arg0:GetDist(TARGET_LOCALPLAYER) - 10
            if arg0:GetRandam_Int(1, 100) <= 50 then
                arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhere, 10, POINT_AI_FIXED_POS, AI_DIR_TYPE_CENTER, 15, POINT_AI_FIXED_POS, false)
            end
            arg0:SetTimer(2, 10)
        end
        if local0 == 100 then
            arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 5, POINT_INITIAL, 0.5, TARGET_SELF, true, -1)
        elseif local0 == 110 then
            arg0:AddTopGoal(GOAL_COMMON_ApproachTarget, 5, POINT_INITIAL, 0.5, TARGET_SELF, false, -1)
        elseif RideRequest(arg0, 10, -1) then
            arg0:AddTopGoal(GOAL_COMMON_Mount, 10, 1.2)
        else
            COMMON_EasySetup3(arg0)
        end
    end
    return 
end

function common14020_Interupt(arg0, arg1)
    return 
end

return 
