REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 0, "アニメID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 1, "アニメID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 2, "攻撃対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 3, "成功距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 4, "メッシュチェック候補1", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 5, "メッシュチェック候補2", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 6, "コンボ段数", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 7, "メッシュ検索する距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 8, "攻撃前旋回時間", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 9, "旋回の成功判定角度", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 10, "上攻撃を行う上下角度", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcComboAttack_WithMove, 11, "下攻撃を行う上下角度", 0)
function NpcComboAttackWithMove_Activate(arg0, arg1)
    arg1:SetNumber(0, 0)
    if NpcComboAttackWithMove_AddInnerGoal(arg0, arg1) == 0 then
        arg1:AddSubGoal(GOAL_COMMON_Wait, 0.1, attackTarget)
    end
    return 
end

function NpcComboAttackWithMove_Update(arg0, arg1)
    if arg1:GetSubGoalNum() <= 0 then
        if arg1:GetParam(6) <= arg1:GetNumber(0) then
            return GOAL_RESULT_Success
        elseif NpcComboAttackWithMove_AddInnerGoal(arg0, arg1) == 0 then
            return GOAL_RESULT_Failed
        end
    end
    return GOAL_RESULT_Continue
end

function NpcComboAttackWithMove_Terminate(arg0, arg1)
    return 
end

function NpcComboAttackWithMove_Interupt(arg0, arg1)
    return false
end

function NpcComboAttackWithMove_AddInnerGoal(arg0, arg1)
    local local0 = arg1:GetParam(0)
    local local1 = arg1:GetParam(1)
    local local2 = arg1:GetParam(2)
    local local3 = arg1:GetParam(3)
    local local4 = arg1:GetParam(4)
    local local5 = arg1:GetParam(5)
    local local6 = arg1:GetParam(7)
    local local7 = arg1:GetParam(8)
    if local7 < 0 then
        local7 = 1.5
    end
    local local8 = arg1:GetParam(10)
    local local9 = arg1:GetParam(11)
    local local10 = false
    local local11 = false
    local local12 = -1
    if local4 ~= -1 and local6 <= arg0:GetExistMeshOnLineDist(TARGET_SELF, local4, local6 + 0.5) then
        local10 = true
    end
    if local5 ~= -1 and local6 <= arg0:GetExistMeshOnLineDist(TARGET_SELF, local5, local6 + 0.5) then
        local11 = true
    end
    if local10 == true and local11 == true then
        if arg0:GetRandam_Int(0, 1) == 1 then
            local12 = local0
        else
            local12 = local1
        end
    elseif local10 == true and local11 == false then
        local12 = local0
    elseif local10 == false and local11 == true then
        local12 = local1
    else
        return 0
    end
    local local13 = arg1:GetNumber(0)
    if local13 == 0 then
        arg1:AddSubGoal(GOAL_COMMON_ComboTunable_SuccessAngle180, 10, local12, local2, local3, local7, arg1:GetParam(9), local8, local9)
    elseif local13 == arg1:GetParam(6) - 1 then
        arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, local12, local2, local3, local8, local9)
    else
        arg1:AddSubGoal(GOAL_COMMON_ComboRepeat_SuccessAngle180, 10, local12, local2, local3, local8, local9)
    end
    arg1:SetNumber(0, local13 + 1)
    return 1
end

return 
