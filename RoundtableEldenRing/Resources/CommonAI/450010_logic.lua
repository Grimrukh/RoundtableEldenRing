function Wyvern450010_Logic(arg0)
    COMMON_Initialize(arg0)
    local local0 = GetCurrentTimeType(arg0)
    if arg0:IsChangeState() and arg0:GetCurrTargetState() == AI_TARGET_STATE__NONE then
        arg0:GetStringIndexedNumber("Wyvern450010_FistActDone")
    end
    if not arg0:IsUseFlyRoute() and arg0:IsChangeState() then
        local local1 = arg0:GetPrevTargetState()
        if arg0:IsBattleState() then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3022, TARGET_ENE_0, DIST_NONE, 0, 90)
        elseif arg0:IsSearchLowState() and local1 == AI_TARGET_STATE__NONE then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3024, TARGET_SEARCH, DIST_NONE, 0, 90)
        elseif arg0:IsCautionState() and local1 == AI_TARGET_STATE__NONE then
            if arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_L, 180) then
                arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3028, TARGET_ENE_0, DIST_None, 0, 90)
            elseif arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_R, 180) then
                arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3029, TARGET_ENE_0, DIST_None, 0, 90)
            end
        elseif (local1 == AI_TARGET_STATE__SEARCH or local1 == AI_TARGET_STATE__SEARCH2) and arg0:IsSearchLowState() == false and arg0:IsSearchHighState() == false and arg0:IsCautionState() == false and arg0:IsBattleState() == false then
            arg0:AddTopGoal(GOAL_COMMON_AttackTunableSpin, 10, 3023, TARGET_ENE_0, DIST_NONE, 0, 90)
        end
    end
    if arg0:IsBattleState() then
        arg0:AddTopGoal(arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__battleGoalID), -1)
    elseif arg0:IsSearchLowState() then
        arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, TARGET_ENE_0)
    elseif arg0:IsCautionState() then
        arg0:AddTopGoal(GOAL_COMMON_Stay, 1, 0, TARGET_ENE_0)
    elseif arg0:GetStringIndexedNumber("Wyvern450010_FistActDone") ~= 1 then
        arg0:AddTopGoal(GOAL_COMMON_WaitWithAnime, -1, 3021, TARGET_SELF)
        arg0:SetStringIndexedNumber("Wyvern450010_FistActDone", 1)
    else
        arg0:AddTopGoal(GOAL_COMMON_WalkAround_Anywhere, -1, 2, 10, true, 3020, 18, -1, false, true)
    end
    return 
end

function Wyvern450010_Interupt(arg0, arg1)
    return false
end

return 
