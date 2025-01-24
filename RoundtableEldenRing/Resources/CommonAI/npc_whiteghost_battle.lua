RegisterTableGoal(GOAL_NPC_WhiteGhost_Battle, "GOAL_NPC_WhiteGhost_Battle")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_NPC_WhiteGhost_Battle, true)
Goal.Initialize = function (arg0, arg1, arg2, arg3)
    return 
end

Goal.Activate = function (arg0, arg1, arg2)
    local local0 = {}
    local local1 = {}
    local local2 = {}
    Common_Clear_Param(local0, local1, local2)
    local local3 = arg1:GetRandam_Int(1, 100)
    local local4 = arg1:GetExcelParam(AI_EXCEL_THINK_PARAM_TYPE__thinkAttr_doAdmirer)
    local local5 = arg1:IsSearchTarget(TARGET_ENE_0)
    local local6 = arg1:GetEventRequest(3)
    local local7 = arg1:GetDist(TARGET_ENE_0)
    local local8 = arg1:GetDist(TARGET_LOCALPLAYER)
    local local9 = arg1:GetHpRate(TARGET_SELF)
    if arg1:IsTargetWeakSoulCoin(TARGET_ENE_0) then
        local0[4] = 100
    elseif arg1:GetEventRequest() == 10 then
        if local8 <= 5 then
            local0[2] = 100
        else
            local0[3] = 100
        end
    elseif 70 <= local8 then
        if local5 == false then
            local0[1] = 100
        elseif 25 <= local7 then
            local0[1] = 100
        else
            local0[1] = 100
        end
    elseif 5 <= local8 then
        if local5 == false then
            local0[1] = 100
        elseif 30 <= local7 then
            local0[1] = 100
        else
            local0[4] = 100
        end
    elseif 2 <= local8 then
        if local5 == false then
            local0[5] = 100
        elseif 45 <= local7 then
            local0[5] = 100
        else
            local0[4] = 100
        end
    elseif local5 == false then
        local0[2] = 100
    elseif 15 <= local7 then
        local0[2] = 100
    else
        local0[4] = 100
    end
    local1[1] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act01)
    local1[2] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act02)
    local1[3] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act03)
    local1[4] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act04)
    local1[5] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act05)
    local1[6] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act06)
    local1[7] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act07)
    local1[8] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act08)
    local1[9] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act09)
    local1[10] = REGIST_FUNC(arg1, arg2, GOAL_NPC_WhiteGhost_Battle_Act10)
    Common_Battle_Activate(arg1, arg2, local0, local1, REGIST_FUNC(arg1, arg2, WhiteGhost_ActAfter_AdjustSpace), local2)
    return 
end

function GOAL_NPC_WhiteGhost_Battle_Act01(arg0, arg1, arg2)
    if arg0:GetDist(TARGET_LOCALPLAYER) <= 4 then
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 2, TARGET_LOCALPLAYER, 2, TARGET_SELF, true, -1)
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 0.1, 141, TARGET_LOCALPLAYER, -1, 0, 0)
    else
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 2, TARGET_LOCALPLAYER, 2, TARGET_SELF, false, -1)
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 0.1, 141, TARGET_LOCALPLAYER, -1, 0, 0)
    end
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act02(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 2, TARGET_LOCALPLAYER, 999, TARGET_SELF, true, -1)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 0.1, 141, TARGET_SELF, -1, 0, 0)
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act03(arg0, arg1, arg2)
    arg0:SetEventMoveTarget(arg0:GetStringIndexedNumber("NPC_PointFrontWall"))
    if POINT_EVENT <= 0.3 then
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 0.3, 141, TARGET_SELF, -1, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 2, POINT_EVENT, 0.3, TARGET_SELF, false, -1)
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 0.1, 141, TARGET_SELF, -1, 0, 0)
    end
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act04(arg0, arg1, arg2)
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act05(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 0.3, 141, TARGET_SELF, -1, 0, 0)
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act06(arg0, arg1, arg2)
    arg0:SetEventMoveTarget(arg0:GetStringIndexedNumber("NPC_PointFrontWall"))
    if POINT_EVENT <= 0.3 then
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 0.3, 141, TARGET_SELF, -1, 0, 0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 3, POINT_EVENT, 0.3, TARGET_SELF, false, -1)
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 0.1, 141, TARGET_SELF, -1, 0, 0)
    end
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act07(arg0, arg1, arg2)
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act08(arg0, arg1, arg2)
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act09(arg0, arg1, arg2)
    return 0
end

function GOAL_NPC_WhiteGhost_Battle_Act10(arg0, arg1, arg2)
    return 0
end

function WhiteGhost_ActAfter_AdjustSpace(arg0, arg1, arg2)
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
