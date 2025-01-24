RegisterTableGoal(GOAL_CatapultDummy12000_Battle, "CatapultDummy12000_Battle")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_CatapultDummy12000_Battle, true)
Goal.Initialize = function (arg0, arg1, arg2, arg3)
    return 
end

Goal.Activate = function (arg0, arg1, arg2)
    local local0 = {}
    local local1 = {}
    Common_Clear_Param(local0, local1, {})
    local local2 = arg1:GetEventRequest(0)
    if arg1:HasSpecialEffectId(TARGET_SELF, 16600) then
        local0[1] = 100
        local0[2] = 0
        local0[3] = 0
        local0[4] = 0
        local0[5] = 0
    elseif local2 == AI_EVENT_CATAPULT_FIRE_MIDDLE_ENE then
        local0[1] = 0
        local0[2] = 100
        local0[3] = 0
        local0[4] = 0
        local0[5] = 0
    elseif local2 == AI_EVENT_CATAPULT_FIRE_MIDDLE_PC then
        local0[1] = 0
        local0[2] = 0
        local0[3] = 100
        local0[4] = 0
        local0[5] = 0
    elseif local2 == AI_EVENT_CATAPULT_FIRE_LONG_ENE then
        local0[1] = 0
        local0[2] = 0
        local0[3] = 0
        local0[4] = 100
        local0[5] = 0
    elseif local2 == AI_EVENT_CATAPULT_FIRE_LONG_PC then
        local0[1] = 0
        local0[2] = 0
        local0[3] = 0
        local0[4] = 0
        local0[5] = 100
    else
        local0[1] = 100
        local0[2] = 0
        local0[3] = 0
        local0[4] = 0
        local0[5] = 0
    end
    local1[1] = REGIST_FUNC(arg1, arg2, CatapultDummy12000_Act01)
    local1[2] = REGIST_FUNC(arg1, arg2, CatapultDummy12000_Act02)
    local1[3] = REGIST_FUNC(arg1, arg2, CatapultDummy12000_Act03)
    local1[4] = REGIST_FUNC(arg1, arg2, CatapultDummy12000_Act04)
    local1[5] = REGIST_FUNC(arg1, arg2, CatapultDummy12000_Act05)
    Common_Battle_Activate(arg1, arg2, local0, local1, REGIST_FUNC(arg1, arg2, CatapultDummy12000_ActAfter_AdjustSpace))
    return 
end

function CatapultDummy12000_Act01(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 3, TARGET_ENE_0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function CatapultDummy12000_Act02(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 1.3, TARGET_ENE_0, 0, 0, 0)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3000, TARGET_ENE_0, 9999, 0, 180, -1, -1)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 9999999, TARGET_ENE_0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function CatapultDummy12000_Act03(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 1.3, TARGET_ENE_0, 0, 0, 0)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3001, TARGET_ENE_0, 9999, 0, 180, -1, -1)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 9999999, TARGET_ENE_0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function CatapultDummy12000_Act04(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 1.3, TARGET_ENE_0, 0, 0, 0)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3002, TARGET_ENE_0, 9999, 0, 180, -1, -1)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 9999999, TARGET_ENE_0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function CatapultDummy12000_Act05(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 1.3, TARGET_ENE_0, 0, 0, 0)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3003, TARGET_ENE_0, 9999, 0, 180, -1, -1)
    arg1:AddSubGoal(GOAL_COMMON_Wait, 9999999, TARGET_ENE_0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function CatapultDummy12000_ActAfter_AdjustSpace(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_CatapultDummy12000_AfterAttackAct, 10)
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

Goal.Terminate = function (arg0, arg1, arg2)
    return 
end

Goal.Interrupt = function (arg0, arg1, arg2)
    return false
end

RegisterTableGoal(GOAL_CatapultDummy12000_AfterAttackAct, "CatapultDummy12000_AfterAttackAct")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_CatapultDummy12000_AfterAttackAct, true)
Goal.Activate = function (arg0, arg1, arg2)
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

return 
