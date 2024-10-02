REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcStanceAttack_WithMove, 0, "攻撃対象", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcStanceAttack_WithMove, 1, "高ｦ射撃ボタン", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcStanceAttack_WithMove, 2, "メッシュ検索する距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcStanceAttack_WithMove, 3, "攻撃前旋回時間", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcStanceAttack_WithMove, 4, "旋回の成功判定角度", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcStanceAttack_WithMove, 5, "上攻撃を行う上下角度", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_NpcStanceAttack_WithMove, 6, "下攻撃を行う上下角度", 0)
function NpcStanceAttackWithMove_Activate(arg0, arg1)
    if NpcStanceAttackWithMove_AddInnerGoal(arg0, arg1) == false then
        arg1:AddSubGoal(GOAL_COMMON_Wait, 0.1, attackTarget)
    end
    return 
end

function NpcStanceAttackWithMove_Update(arg0, arg1)
    if arg0:GetDist(arg1:GetParam(0)) <= 5 then
        return GOAL_RESULT_Failed
    elseif arg1:GetSubGoalNum() <= 0 and NpcStanceAttackWithMove_AddInnerGoal(arg0, arg1) == false then
        return GOAL_RESULT_Failed
    else
        return GOAL_RESULT_Continue
    end
end

function NpcStanceAttackWithMove_Terminate(arg0, arg1)
    return 
end

function NpcStanceAttackWithMove_Interupt(arg0, arg1)
    return false
end

function NpcStanceAttackWithMove_AddInnerGoal(arg0, arg1)
    local local0 = arg1:GetParam(0)
    local local1 = arg1:GetParam(2)
    local local2 = arg1:GetParam(3)
    if local2 < 0 then
        local2 = 1.5
    end
    local local3 = arg1:GetParam(4)
    local local4 = arg1:GetParam(5)
    local local5 = arg1:GetParam(6)
    local local6 = false
    local local7 = false
    local local8 = arg0:GetDist(local0)
    local local9 = {}
    local local10 = {AI_DIR_TYPE_F, AI_DIR_TYPE_B, AI_DIR_TYPE_L, AI_DIR_TYPE_R}
    if local8 <= 5 then
        return false
    elseif local8 <= 7 then
        local9[1] = 0
        local9[2] = 80
        local9[3] = 10
        local9[4] = 10
    elseif local8 <= 10 then
        local9[1] = 10
        local9[2] = 10
        local9[3] = 40
        local9[4] = 40
    elseif local8 <= 15 then
        local9[1] = 80
        local9[2] = 0
        local9[3] = 10
        local9[4] = 10
    else
        return false
    end
    if arg0:GetExistMeshOnLineDist(TARGET_SELF, local10[1], local1 + 0.5) < local1 then
        local9[1] = 0
    end
    if arg0:GetExistMeshOnLineDist(TARGET_SELF, local10[2], local1 + 0.5) < local1 then
        local9[2] = 0
    end
    if arg0:GetExistMeshOnLineDist(TARGET_SELF, local10[3], local1 + 0.5) < local1 then
        local9[3] = 0
    end
    if arg0:GetExistMeshOnLineDist(TARGET_SELF, local10[4], local1 + 0.5) < local1 then
        local9[4] = 0
    end
    local local11 = local9[1] + local9[2] + local9[3] + local9[4]
    if local11 <= 0 then
        return false
    end
    local local12 = NPC_ATK_L2Hold
    local local13 = 1
    local local14 = 0
    local local15 = 1
    for local16 = 1 - local15, 4, local15 do
        local14 = local14 + local9[local16]
        if arg0:GetRandam_Int(1, local11) <= local14 then
            MoveDir = local10[local16]
            local16 = 4
        end
    end
    if MoveDir == AI_DIR_TYPE_F then
        local16 = arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 2, local0, 0, local0, true, NPC_ATK_L2Hold, GUARD_GOAL_DESIRE_RET_Failed, false)
        local16:SetLifeEndSuccess(true)
    elseif MoveDir == AI_DIR_TYPE_B then
        local16 = arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 2, local0, 999, local0, true, NPC_ATK_L2Hold, GUARD_GOAL_DESIRE_RET_Failed, false)
        local16:SetLifeEndSuccess(true)
    elseif MoveDir == AI_DIR_TYPE_L then
        local16 = arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 2, local0, false, 45, true, true, NPC_ATK_L2Hold, GUARD_GOAL_DESIRE_RET_Failed, false)
        local16:SetLifeEndSuccess(true)
    else
        local16 = arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 2, local0, true, 45, true, true, NPC_ATK_L2Hold, GUARD_GOAL_DESIRE_RET_Failed, false)
        local16:SetLifeEndSuccess(true)
    end
    local16 = arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 1, arg1:GetParam(1), local0, 999, local2, local3, local4, local5)
    local16:SetLifeEndSuccess(true)
    local16 = arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 2, NPC_ATK_L2Hold, local0, 999, local2, local3, local4, local5)
    local16:SetLifeEndSuccess(true)
    return true
end

return 
