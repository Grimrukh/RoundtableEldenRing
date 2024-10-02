RegisterTableGoal(GOAL_Wyvern450010_Battle, "Wyvern450010_Battle")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_Wyvern450010_Battle, true)
Goal.Initialize = function (arg0, arg1, arg2, arg3)
    return 
end

Goal.Activate = function (arg0, arg1, arg2)
    Init_Pseudo_Global(arg1, arg2)
    local local0 = {}
    local local1 = {}
    local local2 = {}
    Common_Clear_Param(local0, local1, local2)
    local local3 = arg1:GetEventRequest()
    if arg1:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_B, 180) then
        local0[2] = 30
    elseif local3 == 10 then
        local0[12] = 50
    elseif local3 == 20 then
        local0[11] = 50
    elseif arg1:GetDist(TARGET_ENE_0) <= 5 then
        local0[6] = 50
    else
        local0[10] = 50
    end
    local1[1] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act01)
    local1[2] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act02)
    local1[3] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act03)
    local1[4] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act04)
    local1[5] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act05)
    local1[6] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act06)
    local1[7] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act07)
    local1[8] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act08)
    local1[9] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act09)
    local1[10] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act10)
    local1[11] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act11)
    local1[12] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act12)
    local1[20] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act20)
    local1[21] = REGIST_FUNC(arg1, arg2, Wyvern450010_Act21)
    Common_Battle_Activate(arg1, arg2, local0, local1, REGIST_FUNC(arg1, arg2, Wyvern450010_ActAfter_AdjustSpace), local2)
    return 
end

function Wyvern450010_Act01(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 5, 3002, TARGET_ENE_0, 15 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 5, 3003, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act02(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3004, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act03(arg0, arg1, arg2)
    local local0 = 20 - arg0:GetMapHitRadius(TARGET_SELF)
    if 5 <= arg0:GetRelativeAngleFromTarget(TARGET_ENE_0) then
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3006, TARGET_ENE_0, local0, 0, 0, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3005, TARGET_ENE_0, local0, 0, 0, 0, 0)
    end
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act04(arg0, arg1, arg2)
    local local0 = 20 - arg0:GetMapHitRadius(TARGET_SELF)
    if arg0:GetRelativeAngleFromTarget(TARGET_ENE_0) <= -5 then
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3008, TARGET_ENE_0, local0, 0, 0, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3007, TARGET_ENE_0, local0, 0, 0, 0, 0)
    end
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act05(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 15, 3009, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act06(arg0, arg1, arg2)
    local local0 = 20 - arg0:GetMapHitRadius(TARGET_SELF)
    if arg0:GetRelativeAngleFromTarget(TARGET_ENE_0) <= -5 then
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3011, TARGET_ENE_0, local0, 0, 0, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3010, TARGET_ENE_0, local0, 0, 0, 0, 0)
    end
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act07(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3012, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act08(arg0, arg1, arg2)
    local local0 = 20 - arg0:GetMapHitRadius(TARGET_SELF)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3004, TARGET_ENE_0, local0, 0, 0, 0, 0)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3001, TARGET_ENE_0, local0, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act09(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 15, 3000, TARGET_ENE_0, DIST_None, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act10(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3001, TARGET_ENE_0, DIST_None, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act11(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3015, TARGET_ENE_0, DIST_None, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act12(arg0, arg1, arg2)
    local local0 = 3012
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3012, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_Act20(arg0, arg1, arg2)
    local local0 = 8
    local local1 = 0
    local local2 = -1
    if arg0:GetRandam_Int(1, 100) <= local1 then
        local2 = 9910
    end
    if local0 <= arg0:GetDist(TARGET_ENE_0) then
        Approach_Act(arg0, arg1, local0, 8, local1, 3)
    end
    return 
end

function Wyvern450010_Act21(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_Turn, 2, TARGET_ENE_0, 90, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450010_ActAfter_AdjustSpace(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_Wyvern450010_AfterAttackAct, 10)
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

Goal.Terminate = function (arg0, arg1, arg2)
    return 
end

Goal.Interrupt = function (arg0, arg1, arg2)
    if arg1:IsInterupt(INTERUPT_ForgetTarget) and 12 <= arg1:GetAttackPassedTime(3023) then
        arg2:ClearSubGoal()
        arg2:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3023, TARGET_ENE_0, DIST_None, 0, 90)
        return true
    else
        return false
    end
end

RegisterTableGoal(GOAL_Wyvern450010_AfterAttackAct, "Wyvern450010_AfterAttackAct")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_Wyvern450010_AfterAttackAct, true)
Goal.Activate = function (arg0, arg1, arg2)
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

return 
