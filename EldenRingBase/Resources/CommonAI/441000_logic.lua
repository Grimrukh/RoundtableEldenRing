function GiantGolem441000_Logic(arg0)
    COMMON_Initialize(arg0)
    if COMMON_EasySetup_Initial(arg0) == false then
        if arg0:IsValidPlatoon() == true then
            local local0 = arg0:GetPlatoonCommand()
            if local0:GetCommandNo() == PLAN_PLATOON_COMMAND__STOP then
                if arg0:HasSpecialEffectId(TARGET_SELF, 5020) == false then
                    arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, -1, 3020, TARGET_ENE_0, 0, 0, 180, 180, 180)
                else
                    arg0:AddTopGoal(GOAL_COMMON_Stay, 10, 0, TARGET_TEAM_FORMATION)
                end
            elseif arg0:GetDist(TARGET_TEAM_FORMATION) < 1 then
                arg0:AddTopGoal(GOAL_COMMON_Stay, 0.5, 0, TARGET_TEAM_FORMATION)
            else
                arg0:AddTopGoal(GOAL_COMMON_MoveToSomewhere, 10, TARGET_TEAM_FORMATION, AI_DIR_TYPE_CENTER, 0.1, TARGET_SELF, true)
            end
        else
            arg0:AddTopGoal(GOAL_COMMON_Stay, 0.5, 0, TARGET_SELF)
        end
    end
    return 
end

function GiantGolem441000_Interupt(arg0, arg1)
    local local0 = arg0:GetPlatoonCommand()
    isChangedOrder = arg0:IsInterupt(INTERUPT_PlatoonAiOrder)
    if isChangedOrder and local0:GetCommandNo() == 12 then
        arg1:ClearSubGoal()
        arg0:Replaning()
    end
    return 
end

return 
