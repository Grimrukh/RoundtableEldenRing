RegisterTableGoal(GOAL_Wyvern450000_Battle, "Wyvern450000_Battle")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_Wyvern450000_Battle, true)
Goal.Initialize = function (arg0, arg1, arg2, arg3)
    return 
end

Goal.Activate = function (arg0, arg1, arg2)
    Init_Pseudo_Global(arg1, arg2)
    local local0 = {}
    local local1 = {}
    local local2 = {}
    Common_Clear_Param(local0, local1, local2)
    arg1:AddObserveSpecialEffectAttribute(TARGET_SELF, 5025)
    arg1:AddObserveSpecialEffectAttribute(TARGET_SELF, 5026)
    arg1:AddObserveSpecialEffectAttribute(TARGET_SELF, 5027)
    arg1:AddObserveSpecialEffectAttribute(TARGET_SELF, 5029)
    arg1:AddObserveSpecialEffectAttribute(TARGET_SELF, 5033)
    local local3 = arg1:GetDist(TARGET_ENE_0)
    local local4 = arg1:GetRandam_Int(1, 100)
    if arg1:HasSpecialEffectId(TARGET_SELF, 14570) == true then
        if arg1:HasSpecialEffectId(TARGET_SELF, 14572) == true then
            local0[35] = 100
        elseif arg1:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_B, 120) then
            if 10 <= local3 then
                local0[31] = 100
            else
                local0[18] = 100
            end
        else
            local0[36] = 100
        end
    end
    if arg1:HasSpecialEffectId(TARGET_SELF, 10205) == true then
        if 50 < local3 then
            if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 0
                local0[9] = 30
                local0[10] = 50
                local0[13] = 0
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 20
                local0[31] = 0
                local0[32] = 0
            else
                local0[30] = 100
                local0[31] = 0
                local0[32] = 0
            end
        elseif 40 < local3 then
            if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 0
                local0[9] = 40
                local0[10] = 40
                local0[13] = 0
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 20
                local0[31] = 0
                local0[32] = 0
            else
                local0[30] = 100
                local0[31] = 0
                local0[32] = 0
            end
        elseif 30 < local3 then
            if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 0
                local0[9] = 40
                local0[10] = 40
                local0[13] = 0
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 20
                local0[31] = 0
                local0[32] = 0
            else
                local0[30] = 100
                local0[31] = 0
                local0[32] = 0
            end
        elseif 20 < local3 then
            if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 30
                local0[6] = 0
                local0[7] = 0
                local0[9] = 30
                local0[10] = 20
                local0[13] = 0
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 20
                local0[31] = 0
                local0[32] = 0
            else
                local0[30] = 100
                local0[31] = 0
                local0[32] = 0
            end
        elseif 10 < local3 then
            if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 20
                local0[6] = 0
                local0[7] = 0
                local0[9] = 20
                local0[10] = 20
                local0[13] = 20
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 20
                local0[31] = 0
                local0[32] = 0
            else
                local0[30] = 100
                local0[31] = 0
                local0[32] = 0
            end
        elseif 5 < local3 then
            if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
                local0[1] = 20
                local0[2] = 0
                local0[3] = 20
                local0[4] = 20
                local0[5] = 0
                local0[6] = 0
                local0[7] = 20
                local0[9] = 0
                local0[10] = 0
                local0[13] = 20
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_L, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 30
                local0[9] = 0
                local0[10] = 0
                local0[13] = 50
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 20
                local0[31] = 0
                local0[32] = 0
            elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_R, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 30
                local0[9] = 0
                local0[10] = 0
                local0[13] = 50
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 20
                local0[31] = 0
                local0[32] = 0
            else
                local0[1] = 0
                local0[2] = 70
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 0
                local0[9] = 0
                local0[10] = 0
                local0[13] = 0
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 30
                local0[31] = 0
                local0[32] = 0
            end
        elseif 0 < local3 then
            if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
                local0[1] = 10
                local0[2] = 0
                local0[3] = 10
                local0[4] = 10
                local0[5] = 0
                local0[6] = 0
                local0[7] = 10
                local0[9] = 0
                local0[10] = 0
                local0[13] = 20
                local0[14] = 0
                local0[15] = 20
                local0[16] = 20
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_L, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 20
                local0[9] = 0
                local0[10] = 0
                local0[13] = 30
                local0[14] = 0
                local0[15] = 30
                local0[16] = 0
                local0[18] = 20
                local0[19] = 0
                local0[20] = 0
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_R, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 20
                local0[9] = 0
                local0[10] = 0
                local0[13] = 30
                local0[14] = 0
                local0[15] = 30
                local0[16] = 0
                local0[18] = 20
                local0[19] = 0
                local0[20] = 0
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            else
                local0[1] = 0
                local0[2] = 30
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 0
                local0[9] = 0
                local0[10] = 0
                local0[13] = 0
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 20
                local0[19] = 30
                local0[20] = 20
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            end
        elseif -5 < local3 then
            if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 10
                local0[9] = 0
                local0[10] = 0
                local0[13] = 10
                local0[14] = 30
                local0[15] = 10
                local0[16] = 40
                local0[18] = 0
                local0[19] = 0
                local0[20] = 0
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_L, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 10
                local0[9] = 0
                local0[10] = 0
                local0[13] = 10
                local0[14] = 30
                local0[15] = 10
                local0[16] = 30
                local0[18] = 10
                local0[19] = 0
                local0[20] = 0
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_R, 120, 180, 100) then
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 10
                local0[9] = 0
                local0[10] = 0
                local0[13] = 10
                local0[14] = 30
                local0[15] = 10
                local0[16] = 30
                local0[18] = 10
                local0[19] = 0
                local0[20] = 0
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            else
                local0[1] = 0
                local0[2] = 0
                local0[3] = 0
                local0[4] = 0
                local0[5] = 0
                local0[6] = 0
                local0[7] = 0
                local0[9] = 0
                local0[10] = 0
                local0[13] = 0
                local0[14] = 0
                local0[15] = 0
                local0[16] = 0
                local0[18] = 20
                local0[19] = 40
                local0[20] = 40
                local0[30] = 0
                local0[31] = 0
                local0[32] = 0
            end
        elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
            local0[1] = 0
            local0[2] = 0
            local0[3] = 0
            local0[4] = 0
            local0[5] = 0
            local0[6] = 20
            local0[7] = 10
            local0[9] = 0
            local0[10] = 0
            local0[13] = 10
            local0[14] = 20
            local0[15] = 20
            local0[16] = 20
            local0[18] = 0
            local0[19] = 0
            local0[20] = 0
            local0[30] = 0
            local0[31] = 0
            local0[32] = 0
        elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_L, 120, 180, 100) then
            local0[1] = 0
            local0[2] = 0
            local0[3] = 0
            local0[4] = 0
            local0[5] = 0
            local0[6] = 30
            local0[7] = 10
            local0[9] = 0
            local0[10] = 0
            local0[13] = 10
            local0[14] = 30
            local0[15] = 10
            local0[16] = 0
            local0[18] = 10
            local0[19] = 0
            local0[20] = 0
            local0[30] = 0
            local0[31] = 0
            local0[32] = 0
        elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_R, 120, 180, 100) then
            local0[1] = 0
            local0[2] = 0
            local0[3] = 0
            local0[4] = 0
            local0[5] = 0
            local0[6] = 30
            local0[7] = 10
            local0[9] = 0
            local0[10] = 0
            local0[13] = 10
            local0[14] = 30
            local0[15] = 10
            local0[16] = 0
            local0[18] = 10
            local0[19] = 0
            local0[20] = 0
            local0[30] = 0
            local0[31] = 0
            local0[32] = 0
        else
            local0[1] = 0
            local0[2] = 0
            local0[3] = 0
            local0[4] = 0
            local0[5] = 0
            local0[6] = 0
            local0[7] = 0
            local0[9] = 0
            local0[10] = 0
            local0[13] = 0
            local0[14] = 0
            local0[15] = 0
            local0[16] = 0
            local0[18] = 20
            local0[19] = 40
            local0[20] = 40
            local0[30] = 0
            local0[31] = 0
            local0[32] = 0
        end
    elseif arg1:HasSpecialEffectId(TARGET_SELF, 10205) == false then
        if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 120, 180, 100) then
            local0[25] = 100
        else
            local0[19] = 40
            local0[20] = 40
            local0[31] = 20
        end
    end
    if arg1:HasSpecialEffectId(TARGET_SELF, 10285) then
        local0[11] = 0
        local0[13] = 0
        local0[18] = 0
    end
    if arg1:HasSpecialEffectId(TARGET_SELF, 10286) then
        local0[32] = 1000
    end
    local local5 = arg1:GetExistMeshOnLineDist(TARGET_SELF, AI_DIR_TYPE_F, 50)
    local local6 = arg1:GetExistMeshOnLineDist(TARGET_SELF, AI_DIR_TYPE_F, 80)
    local local7 = arg1:GetExistMeshOnLineDistSpecifyAngle(TARGET_SELF, 44, 100, AI_SPA_DIR_TYPE_TargetF)
    local0[1] = SetCoolTime(arg1, arg2, 3002, 15, local0[1], 1)
    local0[2] = SetCoolTime(arg1, arg2, 3016, 15, local0[2], 1)
    local0[3] = SetCoolTime(arg1, arg2, 3005, 10, local0[3], 1)
    local0[3] = SetCoolTime(arg1, arg2, 3006, 10, local0[3], 1)
    local0[4] = SetCoolTime(arg1, arg2, 3007, 10, local0[4], 1)
    local0[4] = SetCoolTime(arg1, arg2, 3008, 10, local0[4], 1)
    local0[5] = SetCoolTime(arg1, arg2, 3009, 15, local0[5], 1)
    local0[6] = SetCoolTime(arg1, arg2, 3010, 10, local0[6], 1)
    local0[6] = SetCoolTime(arg1, arg2, 3011, 10, local0[6], 1)
    local0[7] = SetCoolTime(arg1, arg2, 3012, 20, local0[7], 1)
    local0[9] = SetCoolTime(arg1, arg2, 3016, 30, local0[9], 1)
    local0[10] = SetCoolTime(arg1, arg2, 3001, 30, local0[10], 1)
    local0[13] = SetCoolTime(arg1, arg2, 3016, 30, local0[13], 1)
    local0[14] = SetCoolTime(arg1, arg2, 3030, 15, local0[14], 1)
    local0[14] = SetCoolTime(arg1, arg2, 3031, 15, local0[14], 1)
    local0[15] = SetCoolTime(arg1, arg2, 3032, 30, local0[15], 1)
    local0[16] = SetCoolTime(arg1, arg2, 3033, 15, local0[16], 1)
    local0[18] = SetCoolTime(arg1, arg2, 3034, 40, local0[18], 1)
    local0[19] = SetCoolTime(arg1, arg2, 3017, 15, local0[19], 1)
    local0[20] = SetCoolTime(arg1, arg2, 3018, 15, local0[20], 1)
    local1[1] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act01)
    local1[2] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act02)
    local1[3] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act03)
    local1[4] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act04)
    local1[5] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act05)
    local1[6] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act06)
    local1[7] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act07)
    local1[8] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act08)
    local1[9] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act09)
    local1[10] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act10)
    local1[11] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act11)
    local1[12] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act12)
    local1[13] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act13)
    local1[14] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act14)
    local1[15] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act15)
    local1[16] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act16)
    local1[17] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act17)
    local1[18] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act18)
    local1[19] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act19)
    local1[20] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act20)
    local1[25] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act25)
    local1[30] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act30)
    local1[31] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act31)
    local1[32] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act32)
    local1[35] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act35)
    local1[36] = REGIST_FUNC(arg1, arg2, Wyvern450000_Act36)
    Common_Battle_Activate(arg1, arg2, local0, local1, REGIST_FUNC(arg1, arg2, Wyvern450000_ActAfter_AdjustSpace), local2)
    return 
end

function Wyvern450000_Act01(arg0, arg1, arg2)
    local local0 = 12 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = arg0:GetRandam_Int(1, 100)
    Approach_Act_Flex(arg0, arg1, local0, local0 + 0, local0 + 10, 0, 0, 3, 3)
    arg0:AddObserveSpecialEffectAttribute(TARGET_SELF, 5029)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3002, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act02(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3004, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act03(arg0, arg1, arg2)
    local local0 = 20 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = arg0:GetRandam_Int(1, 100)
    Approach_Act_Flex(arg0, arg1, local0, local0 + 0, local0 + 10, 0, 0, 3, 3)
    local local2 = 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999
    local local3 = 0
    local local4 = 0
    local local5 = arg0:GetRelativeAngleFromTarget(TARGET_ENE_0)
    if arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_L, 180) then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3005, TARGET_ENE_0, local2, local3, local4, 0, 0)
    elseif arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_R, 180) then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3006, TARGET_ENE_0, local2, local3, local4, 0, 0)
    end
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act04(arg0, arg1, arg2)
    local local0 = 20 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = arg0:GetRandam_Int(1, 100)
    Approach_Act_Flex(arg0, arg1, local0, local0 + 0, local0 + 0, 0, 0, 3, 3)
    local local2 = 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999
    local local3 = 0
    local local4 = 0
    local local5 = arg0:GetRelativeAngleFromTarget(TARGET_ENE_0)
    if arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_L, 180) then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3007, TARGET_ENE_0, local2, local3, local4, 0, 0)
    elseif arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_R, 180) then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3008, TARGET_ENE_0, local2, local3, local4, 0, 0)
    end
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act05(arg0, arg1, arg2)
    local local0 = 40 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = arg0:GetRandam_Int(1, 100)
    Approach_Act_Flex(arg0, arg1, local0, local0 + 0, local0 + 10, 0, 0, 3, 3)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3009, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act06(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    local local8 = 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999
    local local9 = 0
    local local10 = 0
    local local11 = arg0:GetRelativeAngleFromTarget(TARGET_ENE_0)
    arg0:AddObserveSpecialEffectAttribute(TARGET_SELF, 5025)
    arg0:AddObserveSpecialEffectAttribute(TARGET_SELF, 5027)
    if arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_L, 180) then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3011, TARGET_ENE_0, local8, local9, local10, 0, 0)
    elseif arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_R, 180) then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3010, TARGET_ENE_0, local8, local9, local10, 0, 0)
    end
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act07(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3012, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act08(arg0, arg1, arg2)
    local local0 = 20 - arg0:GetMapHitRadius(TARGET_SELF)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3004, TARGET_ENE_0, local0, 0, 0, 0, 0)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3001, TARGET_ENE_0, local0, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act09(arg0, arg1, arg2)
    local local0 = 45 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = arg0:GetRandam_Int(1, 100)
    Approach_Act_Flex(arg0, arg1, local0, local0 + 0, local0 + 10, 0, 0, 3, 3)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3000, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act10(arg0, arg1, arg2)
    local local0 = 50 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = arg0:GetRandam_Int(1, 100)
    Approach_Act_Flex(arg0, arg1, local0, local0 + 0, local0 + 10, 0, 0, 3, 3)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3001, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act11(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3015, TARGET_ENE_0, DIST_None, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act12(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3014, TARGET_ENE_0, DIST_None, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act13(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3016, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act14(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    local local8 = 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999
    local local9 = 0
    local local10 = 0
    if arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_L, 180) then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3031, TARGET_ENE_0, local8, local9, local10, 0, 0)
    elseif arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_R, 180) then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3030, TARGET_ENE_0, local8, local9, local10, 0, 0)
    end
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act15(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3032, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act16(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3033, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act17(arg0, arg1, arg2)
    local local0 = 0
    local local1 = 0
    local local2 = 0
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 5, 3035, TARGET_ENE_0, 10, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act18(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    arg0:AddObserveSpecialEffectAttribute(TARGET_SELF, 5026)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3034, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act19(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3017, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act20(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = local0 + 0
    local local2 = local0 + 10
    local local3 = 0
    local local4 = 0
    local local5 = 3
    local local6 = 3
    local local7 = arg0:GetRandam_Int(1, 100)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3018, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act25(arg0, arg1, arg2)
    local local0 = 99 - arg0:GetMapHitRadius(TARGET_SELF)
    local local1 = arg0:GetRandam_Int(1, 100)
    Approach_Act_Flex(arg0, arg1, local0, local0 + 0, local0 + 10, 0, 0, 3, 3)
    arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 15, 3022, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF) + 999, 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act30(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 2.5, TARGET_ENE_0, 10, TARGET_ENE_0, true, -1)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act31(arg0, arg1, arg2)
    local local0 = -1
    if arg0:GetRandam_Int(1, 100) <= 0 then
        local0 = 9910
    end
    arg1:AddSubGoal(GOAL_COMMON_Turn, 1, TARGET_ENE_0, 45, local0, GUARD_GOAL_DESIRE_RET_Continue, true)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act32(arg0, arg1, arg2)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = -1
    if arg0:GetRandam_Int(1, 100) <= 0 then
        local1 = 9910
    end
    arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, arg0:GetRandam_Int(1, 3), TARGET_ENE_0, 10, TARGET_ENE_0, true, local1)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act35(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 20, 20027, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_Act36(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_COMMON_ComboAttackTunableSpin, 20, 3037, TARGET_ENE_0, 20 - arg0:GetMapHitRadius(TARGET_SELF), 0, 0, 0, 0)
    GetWellSpace_Odds = 0
    return GetWellSpace_Odds
end

function Wyvern450000_ActAfter_AdjustSpace(arg0, arg1, arg2)
    arg1:AddSubGoal(GOAL_Wyvern450000_AfterAttackAct, 10)
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

Goal.Terminate = function (arg0, arg1, arg2)
    return 
end

Goal.Interrupt = function (arg0, arg1, arg2)
    local local0 = arg1:GetDist(TARGET_ENE_0)
    local local1 = 20 - arg1:GetMapHitRadius(TARGET_SELF)
    local local2 = 0
    local local3 = 0
    local local4 = arg1:GetRandam_Int(1, 100)
    local local5 = arg1:GetHpRate(TARGET_SELF)
    if arg1:HasSpecialEffectId(TARGET_SELF, 5110) == true or arg1:HasSpecialEffectAttribute(TARGET_SELF, SP_EFFECT_TYPE_SLEEP) == true then
        return false
    elseif arg1:IsInterupt(INTERUPT_ForgetTarget) and 12 <= arg1:GetAttackPassedTime(3023) then
        arg2:ClearSubGoal()
        arg2:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, 3023, TARGET_ENE_0, DIST_None, 0, 90)
        return true
    elseif arg1:IsInterupt(INTERUPT_ActivateSpecialEffect) and arg1:HasSpecialEffectId(TARGET_SELF, 5025) and local0 < 0 then
        if arg1:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_L, 180) then
            return true
        elseif local4 <= 90 then
            arg2:AddSubGoal(GOAL_COMMON_ComboRepeat_SuccessAngle180, 15, 3030, TARGET_ENE_0, 999, 0, 0)
            return true
        else
            return true
        end
    elseif arg1:IsInterupt(INTERUPT_ActivateSpecialEffect) and arg1:HasSpecialEffectId(TARGET_SELF, 5027) and local0 < 0 then
        if arg1:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_L, 180) then
            if local4 <= 90 then
                arg2:AddSubGoal(GOAL_COMMON_ComboRepeat_SuccessAngle180, 15, 3031, TARGET_ENE_0, 999, 0, 0)
                return true
            else
                return true
            end
        else
            return true
        end
    elseif arg1:IsInterupt(INTERUPT_ActivateSpecialEffect) and arg1:HasSpecialEffectId(TARGET_SELF, 5026) then
        arg2:ClearSubGoal()
        if arg1:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_F, 120) and 20 <= arg1:GetDist(TARGET_ENE_0) then
            local local6 = TARGET_SELF
            local local7 = 10
            local local8 = 0
            local local9 = 0
            local local10 = 0
            arg2:AddSubGoal(GOAL_COMMON_ComboRepeat, 5, 3001, TARGET_ENE_0, successDist2)
        end
        return true
    elseif arg1:IsInterupt(INTERUPT_ActivateSpecialEffect) and arg1:GetSpecialEffectActivateInterruptId(5029) then
        if arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 160, 180, 5) then
            return true
        elseif arg1:IsInsideTargetCustom(TARGET_SELF, TARGET_ENE_0, AI_DIR_TYPE_F, 160, 180, 17.5) then
            arg2:ClearSubGoal()
            arg2:AddSubGoal(GOAL_COMMON_ComboRepeat_SuccessAngle180, 10, 3003, TARGET_ENE_0, 999, 0, 0)
            return true
        end
    end
    if arg1:IsInterupt(INTERUPT_ActivateSpecialEffect) and arg1:HasSpecialEffectId(TARGET_SELF, 5033) then
        arg2:ClearSubGoal()
        arg1:Replaning()
        return true
    else
        return false
    end
end

RegisterTableGoal(GOAL_Wyvern450000_AfterAttackAct, "Wyvern450000_AfterAttackAct")
REGISTER_GOAL_NO_SUB_GOAL(GOAL_Wyvern450000_AfterAttackAct, true)
Goal.Activate = function (arg0, arg1, arg2)
    return 
end

Goal.Update = function (arg0, arg1, arg2)
    return Update_Default_NoSubGoal(arg0, arg1, arg2)
end

return 
