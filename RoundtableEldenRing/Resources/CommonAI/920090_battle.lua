RegisterTableGoal(GOAL_GHOST_920090_Battle, "MoujaSoldier_Sword_110005_Battle")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_GHOST_920090_Battle, true)
Goal.Initialize = function (arg0, arg1, arg2, arg3)
    return 
end

Goal.Activate = function (arg0, arg1, arg2)
    local local0 = {}
    local local1 = {}
    local local2 = {}
    Common_Clear_Param(local0, local1, local2)
    Init_Pseudo_Global(arg1, arg2)
    arg1:SetStringIndexedNumber("Dist_SideStep", 2.7 + 1)
    arg1:SetStringIndexedNumber("Dist_BackStep", 2.5 + 1)
    local local3 = arg1:GetDist(TARGET_ENE_0)
    local local4 = arg1:GetEventRequest()
    local local5 = arg1:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__thinkAttr_doAdmirer)
    local local6 = arg1:GetRandam_Int(1, 100)
    local local7 = arg1:GetRandam_Int(1, 100)
    local0[1] = 50
    local0[4] = 0
    local0[7] = 50
    local0[8] = 0
    local0[14] = 0
    local1[1] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act01)
    local1[2] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act02)
    local1[4] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act04)
    local1[5] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act05)
    local1[6] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act06)
    local1[7] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act07)
    local1[8] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act08)
    local1[9] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act09)
    local1[11] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act11)
    local1[12] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act12)
    local1[13] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act13)
    local1[14] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act14)
    local1[15] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act15)
    local1[16] = REGIST_FUNC(arg1, arg2, MoujaSoldier110005_Act16)
    Common_Battle_Activate(arg1, arg2, local0, local1, REGIST_FUNC(arg1, arg2, MoujaSoldier110005_ActAfter_AdjustSpace), local2)
    return 
end

function MoujaSoldier110005_Act01(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 3.2 - arg0:GetMapHitRadius(TARGET_SELF), 3.2 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 3.2 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = 3000
    local local1 = 3001
    local local2 = 2.4 - arg0:GetMapHitRadius(TARGET_SELF) + 1
    local local3 = 5 - arg0:GetMapHitRadius(TARGET_SELF)
    local local4 = 0
    local local5 = 0
    local local6 = arg0:GetRandam_Int(1, 100)
    if local6 <= 35 then
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, local3, local4, local5, 0, 0)
    elseif local6 <= 75 then
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, local2, local4, local5, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, local1, TARGET_ENE_0, local3, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, local2, local4, local5, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_ComboRepeat, 10, local1, TARGET_ENE_0, 3.9 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, 3002, TARGET_ENE_0, local3, 0, 0)
    end
    GetWellSpace_Odds = 100
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act02(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 7 - arg0:GetMapHitRadius(TARGET_SELF), 7 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 7 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = 3003
    local local1 = 5 - arg0:GetMapHitRadius(TARGET_SELF)
    local local2 = 0
    local local3 = 0
    if arg0:GetRandam_Int(1, 100) <= 90 then
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, local1, local2, local3, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, 2.4 - arg0:GetMapHitRadius(TARGET_SELF) + 1, local2, local3, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, 3001, TARGET_ENE_0, local1, 0, 0)
    end
    return 
end

function MoujaSoldier110005_Act04(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 3.5 - arg0:GetMapHitRadius(TARGET_SELF), 3.5 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 3.5 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, 3005, TARGET_ENE_0, 5 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    GetWellSpace_Odds = 100
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act05(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 2.3 - arg0:GetMapHitRadius(TARGET_SELF), 2.3 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 2.3 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, 3006, TARGET_ENE_0, 5 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    GetWellSpace_Odds = 100
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act06(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 12.5 - arg0:GetMapHitRadius(TARGET_SELF), 12.5 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 12.5 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, 3007, TARGET_ENE_0, 5 - arg0:GetMapHitRadius(TARGET_SELF), -1, 45, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act07(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 3.5 - arg0:GetMapHitRadius(TARGET_SELF), 3.5 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 3.5 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = 3008
    local local1 = 5 - arg0:GetMapHitRadius(TARGET_SELF)
    local local2 = 0
    local local3 = 0
    if arg0:GetRandam_Int(1, 100) <= 30 then
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, local1, local2, local3, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, 3.5 - arg0:GetMapHitRadius(TARGET_SELF) + 1, local2, local3, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, 3005, TARGET_ENE_0, local1, 0, 0)
    end
    GetWellSpace_Odds = 100
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act08(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 2.2 - arg0:GetMapHitRadius(TARGET_SELF), 2.2 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 2.2 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = 3009
    local local1 = 5 - arg0:GetMapHitRadius(TARGET_SELF)
    local local2 = 0
    local local3 = 0
    if arg0:GetRandam_Int(1, 100) <= 30 then
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, local1, local2, local3, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, 3.5 - arg0:GetMapHitRadius(TARGET_SELF) + 1, local2, local3, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, 3005, TARGET_ENE_0, local1, 0, 0)
    end
    GetWellSpace_Odds = 100
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act09(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 13.4 - arg0:GetMapHitRadius(TARGET_SELF), 13.4 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 13.4 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, 3011, TARGET_ENE_0, 5 - arg0:GetMapHitRadius(TARGET_SELF), -1, 45, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act11(arg0, arg1, arg2)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = 10
    if local1 <= arg0:GetDist(TARGET_ENE_0) then
        Approach_Act(arg0, arg1, local1, 12, 0, 3)
    end
    arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 5, TARGET_ENE_0, 10, TARGET_ENE_0, true, -1)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act12(arg0, arg1, arg2)
    local local0 = -1
    if arg0:GetRandam_Int(1, 100) <= 0 then
        local0 = 9910
    end
    arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 4, TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, local0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act13(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_Turn, 3, TARGET_ENE_0, arg0:GetRandam_Int(15, 20))
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act14(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 3.2 - arg0:GetMapHitRadius(TARGET_SELF), 3.2 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 3.2 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = 3000
    local local1 = 5 - arg0:GetMapHitRadius(TARGET_SELF)
    local local2 = 0
    local local3 = 0
    if arg0:GetRandam_Int(1, 100) <= 20 then
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, local1, local2, local3, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, local0, TARGET_ENE_0, 2.2 - arg0:GetMapHitRadius(TARGET_SELF) + 1, local2, local3, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, 3009, TARGET_ENE_0, local1, 0, 0)
    end
    GetWellSpace_Odds = 100
    return GetWellSpace_Odds
end

function MoujaSoldier110000_Act15(arg0, arg1, arg2)
    local local0 = math.abs(arg0:GetDistYSigned(TARGET_ENE_0))
    local local1 = arg0:GetRandam_Int(1, 100)
    if 12 <= arg0:GetDist(TARGET_ENE_0) then
        arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0.7, 1.3), TARGET_ENE_0, 0, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0.7, 1.3), TARGET_ENE_0, 0, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, 3011, TARGET_ENE_0, 999, -1, 45, 0, 0)
        arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0.7, 1.3), TARGET_ENE_0, 0, 0, 0)
    end
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function MoujaSoldier110005_Act16(arg0, arg1, arg2)
    Approach_Act_Flex(arg0, arg1, 999, 13.4 - arg0:GetMapHitRadius(TARGET_SELF) + 1, 13.4 - arg0:GetMapHitRadius(TARGET_SELF) + 10, 50, 0, 4, 8)
    local local0 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 10, 3011, TARGET_ENE_0, 999, -1, 45, 0, 0)
    local local1 = arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(1.3, 2.2), TARGET_ENE_0)
    local1:SetTargetRange(0, 7, 999)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function MoujaSoldier110005_ActAfter_AdjustSpace(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_MoujaSoldier_Sword_110005_AfterAttackAct, 10)
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

return 
