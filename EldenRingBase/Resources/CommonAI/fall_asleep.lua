REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_Fall_Asleep, 0, "ã≠êßêáñ∞èÛë‘Ç©", 0)
function FallAsleep_Activate(arg0, arg1)
    local local0 = PLAN_ANIMEID_SLEEP_START
    arg0:AddObserveSpecialEffectAttribute(TARGET_SELF, PLAN_SP_EFFECT_NATURAL_SLEEP_GUARD)
    if arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_ANIME_SLEEPING) then
        arg1:AddSubGoal(GOAL_COMMON_Wait, 3, TARGET_SELF, 0, 0, 0)
    elseif arg1:GetParamBool(0) then
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, local0, TARGET_SELF, 9999, 0, 0, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 10, POINT_INIT_POSE, 1, TARGET_SELF, true, -1)
        arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0, 8), POINT_INIT_POSE)
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, local0, POINT_INIT_POSE, 9999, 5, 10, 0, 0)
    end
    return 
end

function FallAsleep_Update(arg0, arg1)
    if arg1:GetParamBool(0) == true and arg0:HasSpecialEffectAttribute(TARGET_SELF, SP_EFFECT_TYPE_SLEEP) == false then
        return GOAL_RESULT_Failed
    else
        return GOAL_RESULT_Continue
    end
end

function FallAsleep_Terminate(arg0, arg1)
    return 
end

function FallAsleep_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_ActivateSpecialEffect) and arg0:GetSpecialEffectActivateInterruptId(PLAN_SP_EFFECT_NATURAL_SLEEP_GUARD) then
        arg1:ClearSubGoal()
        arg0:Replaning()
        return true
    else
        return false
    end
end

return 
