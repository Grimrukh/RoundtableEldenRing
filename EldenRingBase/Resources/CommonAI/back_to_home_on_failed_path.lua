REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_BackToHome_On_FailedPath, 0, "パスチェック間隔", 0)
function BackToHomeOnFailedPath_Activate(arg0, arg1)
    arg1:SetTimer(0, arg1:GetParam(0))
    if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BUDDY_DECLARE) then
        arg1:SetNumber(1, 1)
        arg1:SetNumber(0, 1)
    else
        arg1:SetNumber(1, 0)
        arg1:SetNumber(0, 0)
    end
    if arg0:IsRiding(TARGET_SELF) == true then
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 100, POINT_INITIAL, 1, TARGET_SELF, true, -1, -1, -1)
    else
        arg1:AddSubGoal(GOAL_COMMON_BackToHome, 100, arg1:GetParam(1))
    end
    return 
end

function BackToHomeOnFailedPath_Update(arg0, arg1)
    local local0 = GOAL_RESULT_Continue
    if arg0:IsBattleState() == true and arg0:GetDist(TARGET_ENE_0) < 6 then
        arg0:SetStringIndexedNumber("IsIgnore_Sideway_onFailedPath", 1)
        return GOAL_RESULT_Success
    end
    local local1 = TARGET_ENE_0
    if arg0:IsSearchLowState() == true or arg0:IsSearchHighState() == true then
        local1 = TARGET_SEARCH
    end
    if true == arg1:IsFinishTimer(0) then
        local local2 = false
        if true == arg0:CheckDoesExistPath(TARGET_ENE_0, AI_DIR_TYPE_CENTER, 0) then
            local0 = GOAL_RESULT_Success
        else
            arg1:SetTimer(0, arg1:GetParam(0))
        end
    end
    if arg1:GetNumber(1) == 1 and 23 <= arg0:GetDist(TARGET_HOSTPLAYER) then
        return GOAL_RESULT_Success
    elseif arg1:GetNumber(0) == 1 and arg0:GetDist(POINT_INITIAL) <= 2 then
        arg1:SetNumber(0, 0)
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_Wait, 2, TARGET_NONE)
    end
    if arg1:GetSubGoalNum() <= 0 then
        return GOAL_RESULT_Success
    else
        return local0
    end
end

function BackToHomeOnFailedPath_Terminate(arg0, arg1)
    return 
end

function BackToHomeOnFailedPath_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_Shoot) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_FINDSHOOT_STEP_ON_FAILED_PATHGOAL) then
        local local0 = 3
        local local1 = false
        local local2 = false
        local local3 = 0
        local local4 = 6003
        local local5 = 6002
        if local0 <= arg0:GetExistMeshOnLineDist(TARGET_SELF, AI_DIR_TYPE_R, local0 + 1) then
            local1 = true
        end
        if local0 <= arg0:GetExistMeshOnLineDist(TARGET_SELF, AI_DIR_TYPE_L, local0 + 1) then
            local2 = true
        end
        if local1 == true and local2 == true then
            local3 = arg0:GetRandam_Int(local5, local4)
        elseif local1 == false and local2 == false then
            local3 = arg0:GetRandam_Int(local5, local4)
        elseif local1 == true then
            local3 = local4
        else
            local3 = local5
        end
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_SpinStep, 2, local3, TARGET_ENE_0, 0, AI_DIR_TYPE_CENTER, 0)
        return true
    elseif arg0:IsInterupt(INTERUPT_CANNOT_MOVE) then
        local local0 = arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__CannotMoveAction)
        if arg0:IsTouchBreakableObject() and 0 <= local0 and arg0:IsLookToTarget(POINT_CurrRequestPosition, 90) then
            local local6 = 10
            if arg0:IsHugeEnemy() == true then
                local6 = 100
            end
            if arg0:GetTouchBreakableObjectDefense() <= local6 then
                arg1:ClearSubGoal()
                if arg0:IsRiding(TARGET_SELF) == false and 0 < arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__enableWeaponOnOff) and arg0:HasSpecialEffectId(TARGET_SELF, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOffSpecialEffectId)) == true then
                    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOnAnimId), TARGET_SELF, 9999, 0, 0, 0, 0)
                    arg1:AddSubGoal(GOAL_COMMON_NonspinningAttack, -1, local0, TARGET_NONE, DIST_None)
                    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__weaponOffAnimId), TARGET_SELF, 9999, 0, 0, 0, 0)
                    return true
                else
                    arg1:AddSubGoal(GOAL_COMMON_NonspinningAttack, -1, local0, TARGET_NONE, DIST_None)
                    return true
                end
            end
        end
        if arg1:GetNumber(1) == 1 then
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1, TARGET_ENE_0)
            return true
        elseif arg0:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__backToHomeStuckAct) == 1 and arg0:GetStringIndexedNumber("mRepCount_Disable_FailedPath") == 0 then
            arg1:ClearSubGoal()
            arg0:SetStringIndexedNumber("RepCount_Disable_FailedPath", 1)
            arg1:AddSubGoal(GOAL_COMMON_FadeWarpToInitPos, 10, 2, 4)
        else
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_Wait, arg1:GetLife(), TARGET_ENE_0)
        end
        return true
    elseif arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) then
        return true
    else
        return false
    end
end

return 
