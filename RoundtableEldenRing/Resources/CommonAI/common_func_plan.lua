function RideRequest(arg0, arg1, arg2)
    if arg0:IsRiding(TARGET_SELF) == true then
        return false
    elseif 0 < arg0:GetTimer(13) then
        return false
    elseif 0 < arg2 and arg0:IsSearchTarget(TARGET_ENE_0) == true and arg0:GetDist(TARGET_ENE_0) <= arg2 then
        return false
    elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_HORSE_RIDE) == true then
        if arg0:IsBattleState() == false and arg0:IsSearchHighState() == false and arg0:IsSearchLowState() == false and arg0:IsCautionState() == false and arg0:IsMemoryState() == false then
            return false
        end
    elseif arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_FACILITY_RIDE) == true then
        if arg0:IsBattleState() == true or arg0:IsSearchHighState() == true or arg0:IsSearchLowState() == true or arg0:IsCautionState() == true or arg0:IsMemoryState() == true then
            return false
        end
    else
        return false
    end
    if arg0:ReserveRide(arg1) == true then
        return true
    else
        return false
    end
end

function FearOfFire(arg0, arg1, arg2)
    if arg0:HasSpecialEffectAttribute(TARGET_ENE_0, SP_EFFECT_TYPE_BEAST_REPELLENT) and arg0:HasSpecialEffectAttribute(TARGET_SELF, SP_EFFECT_TYPE_ENABLE_BEAST_REPELLENT) and arg0:HasSpecialEffectId(TARGET_SELF, PLAN_SP_EFFECT_BEAST_REPELLENT_UNDAMAGED) and arg0:GetStringIndexedNumber("DisableFearOfFire") == 0 then
        if arg2 == nil then
            arg2 = PLAN_SIDEWAYTYPE__NONE
        end
        if arg2 == PLAN_SIDEWAYTYPE__NONE then
            arg1:AddSubGoal(GOAL_COMMON_SideWay_For_Fear_Of_Fire, -1, 10, -1, false)
        elseif arg2 == PLAN_SIDEWAYTYPE__DEFAULT then
            arg1:AddSubGoal(GOAL_COMMON_SideWay_For_Fear_Of_Fire, -1, 7, -1, true)
        elseif arg2 == PLAN_SIDEWAYTYPE__GUARD then
            arg1:AddSubGoal(GOAL_COMMON_SideWay_For_Fear_Of_Fire, -1, 7, 9910, true)
        elseif arg2 == PLAN_SIDEWAYTYPE__PARRY then
            arg1:AddSubGoal(GOAL_COMMON_SideWay_For_Fear_Of_Fire, -1, 7, 9920, true)
        end
        return true
    else
        return false
    end
end

function CommonNPC_ChangeWepL1(arg0, arg1)
    if WEP_Primary ~= arg0:GetEquipWeaponIndex(ARM_L) then
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_ChangeWep_L1, TARGET_NONE, DIST_None)
    end
    return 
end

function CommonNPC_ChangeWepR1(arg0, arg1)
    if WEP_Primary ~= arg0:GetEquipWeaponIndex(ARM_R) then
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_ChangeWep_R1, TARGET_NONE, DIST_None)
    end
    return 
end

function CommonNPC_ChangeWepL2(arg0, arg1)
    if WEP_Secondary ~= arg0:GetEquipWeaponIndex(ARM_L) then
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_ChangeWep_L2, TARGET_NONE, DIST_None)
    end
    return 
end

function CommonNPC_ChangeWepR2(arg0, arg1)
    if WEP_Secondary ~= arg0:GetEquipWeaponIndex(ARM_R) then
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_ChangeWep_R2, TARGET_NONE, DIST_None)
    end
    return 
end

function CommonNPC_SwitchBothHandMode(arg0, arg1)
    if not arg0:IsBothHandMode(TARGET_SELF) then
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_ChangeStyleR, TARGET_NONE, DIST_None)
    end
    return 
end

function CommonNPC_SwitchOneHandMode(arg0, arg1)
    if arg0:IsBothHandMode(TARGET_SELF) then
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_ChangeStyleR, TARGET_NONE, DIST_None)
    end
    return 
end

function NPC_Approach_Act_Flex(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
    if arg7 == nil then
        arg7 = 3
    end
    if arg8 == nil then
        arg8 = 8
    end
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = true
    if arg4 <= local0 then
        local1 = false
    elseif arg3 <= local0 and arg0:GetRandam_Int(1, 100) <= arg5 then
        local1 = false
    end
    local local2 = -1
    if arg0:GetRandam_Int(1, 100) <= arg6 then
        local2 = 4
    end
    if local1 == true then
        life = arg7
    else
        life = arg8
    end
    local local3 = 0
    if arg2 <= local0 then
        if local1 == true then
            arg2 = arg2 + arg0:GetStringIndexedNumber("AddDistWalk") + local3
        else
            arg2 = arg2 + arg0:GetStringIndexedNumber("AddDistRun") + local3
        end
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, life, TARGET_ENE_0, arg2, TARGET_SELF, local1, local2)
    end
    return 
end

function NPC_KATATE_Switch(arg0, arg1)
    if arg0:IsBothHandMode(TARGET_SELF) then
        arg1:AddSubGoal(GOAL_COMMON_NonspinningComboAttack, 10, NPC_ATK_ChangeStyleR, TARGET_ENE_0, DIST_None, 0)
    end
    return 
end

function NPC_RYOUTE_Switch(arg0, arg1)
    if not arg0:IsBothHandMode(TARGET_SELF) then
        arg1:AddSubGoal(GOAL_COMMON_NonspinningComboAttack, 10, NPC_ATK_ChangeStyleR, TARGET_ENE_0, DIST_None, 0)
    end
    return 
end

function Damaged_StepCount_NPCPlayer(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
    local local0 = arg0:GetRandam_Int(1, 100)
    if arg0:IsInterupt(INTERUPT_Damaged) and arg0:GetDist(TARGET_ENE_0) < arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        if local0 <= arg6 then
            arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_StepB, TARGET_ENE_0, DIST_None, 0)
        elseif local0 <= arg6 + arg7 then
            arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_StepL, TARGET_ENE_0, DIST_None, 0)
        else
            arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_StepR, TARGET_ENE_0, DIST_None, 0)
        end
        if arg0:GetRandam_Int(1, 100) <= arg4 then
            arg1:AddSubGoal(GOAL_COMMON_ComboAttack, 10, arg5, TARGET_ENE_0, DIST_Middle, 0)
        end
        return true
    else
        return 
    end
end

function FindAttack_Step_NPCPlayer(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
    local local0 = arg0:GetRandam_Int(1, 100)
    if arg0:IsInterupt(INTERUPT_FindAttack) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        if local0 <= arg4 then
            arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_StepB, TARGET_ENE_0, DIST_None, 0)
        elseif local0 <= arg4 + arg5 then
            arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_StepL, TARGET_ENE_0, DIST_None, 0)
        else
            arg1:AddSubGoal(GOAL_COMMON_Attack, 10, NPC_ATK_StepR, TARGET_ENE_0, DIST_None, 0)
        end
        return true
    else
        return 
    end
end

function FindAttack_Act(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_FindAttack) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function FindAttack_Step(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
    local local0 = arg0:GetRandam_Int(1, 100)
    local local1 = GET_PARAM_IF_NIL_DEF(arg4, 50)
    local local2 = GET_PARAM_IF_NIL_DEF(arg6, 25)
    local local3 = GET_PARAM_IF_NIL_DEF(arg7, 3)
    if arg0:IsInterupt(INTERUPT_FindAttack) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        if local0 <= local1 then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 701, TARGET_ENE_0, 0, AI_DIR_TYPE_B, local3)
        elseif local0 <= local1 + GET_PARAM_IF_NIL_DEF(arg5, 25) then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 702, TARGET_ENE_0, 0, AI_DIR_TYPE_L, local3)
        else
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 703, TARGET_ENE_0, 0, AI_DIR_TYPE_R, local3)
        end
        return true
    else
        return 
    end
end

function FindAttack_Guard(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
    local local0 = GET_PARAM_IF_NIL_DEF(arg6, 3)
    if arg0:IsInterupt(INTERUPT_FindAttack) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        if arg0:GetRandam_Int(1, 100) <= GET_PARAM_IF_NIL_DEF(arg4, 40) then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 4, TARGET_ENE_0, local0, TARGET_ENE_0, true, 9910)
        else
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 4, TARGET_ENE_0, local0, TARGET_ENE_0, true, 9910)
            arg1:AddSubGoal(GOAL_COMMON_SidewayMove, GET_PARAM_IF_NIL_DEF(arg5, 4), TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, 9910)
        end
        return true
    else
        return 
    end
end

function FindAttack_Step_or_Guard(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
    local local0 = arg0:GetRandam_Int(1, 100)
    local local1 = GET_PARAM_IF_NIL_DEF(arg5, 50)
    local local2 = GET_PARAM_IF_NIL_DEF(arg7, 25)
    local local3 = GET_PARAM_IF_NIL_DEF(arg8, 3)
    local local4 = GET_PARAM_IF_NIL_DEF(arg11, 3)
    if arg0:IsInterupt(INTERUPT_FindAttack) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        if arg0:GetRandam_Int(1, 100) <= arg4 then
            arg1:ClearSubGoal()
            if local0 <= local1 then
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 701, TARGET_ENE_0, 0, AI_DIR_TYPE_B, local3)
            elseif local0 <= local1 + GET_PARAM_IF_NIL_DEF(arg6, 25) then
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 702, TARGET_ENE_0, 0, AI_DIR_TYPE_L, local3)
            else
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 703, TARGET_ENE_0, 0, AI_DIR_TYPE_R, local3)
            end
            return true
        end
        arg1:ClearSubGoal()
        if local0 <= GET_PARAM_IF_NIL_DEF(arg9, 40) then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 4, TARGET_ENE_0, local4, TARGET_ENE_0, true, 9910)
        else
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 4, TARGET_ENE_0, local4, TARGET_ENE_0, true, 9910)
            arg1:AddSubGoal(GOAL_COMMON_SidewayMove, GET_PARAM_IF_NIL_DEF(arg10, 4), TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, 9910)
        end
        return true
    else
        return 
    end
end

function Damaged_Act(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_Damaged) and arg0:GetDist(TARGET_ENE_0) < arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function Damaged_Guard(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
    local local0 = GET_PARAM_IF_NIL_DEF(arg6, 3)
    if arg0:IsInterupt(INTERUPT_Damaged) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        if arg0:GetRandam_Int(1, 100) <= GET_PARAM_IF_NIL_DEF(arg4, 40) then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 4, TARGET_ENE_0, local0, TARGET_ENE_0, true, 9910)
        else
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 4, TARGET_ENE_0, local0, TARGET_ENE_0, true, 9910)
            arg1:AddSubGoal(GOAL_COMMON_SidewayMove, GET_PARAM_IF_NIL_DEF(arg5, 4), TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, 9910)
        end
        return true
    else
        return 
    end
end

function Damaged_Step(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
    local local0 = arg0:GetRandam_Int(1, 100)
    local local1 = GET_PARAM_IF_NIL_DEF(arg4, 50)
    local local2 = GET_PARAM_IF_NIL_DEF(arg6, 25)
    local local3 = GET_PARAM_IF_NIL_DEF(arg7, 3)
    if arg0:IsInterupt(INTERUPT_Damaged) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        if local0 <= local1 then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 701, TARGET_ENE_0, 0, AI_DIR_TYPE_B, local3)
        elseif local0 <= local1 + GET_PARAM_IF_NIL_DEF(arg5, 25) then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 702, TARGET_ENE_0, 0, AI_DIR_TYPE_L, local3)
        else
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 703, TARGET_ENE_0, 0, AI_DIR_TYPE_R, local3)
        end
        return true
    else
        return 
    end
end

function Damaged_Step_or_Guard(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
    local local0 = arg0:GetRandam_Int(1, 100)
    local local1 = GET_PARAM_IF_NIL_DEF(arg5, 50)
    local local2 = GET_PARAM_IF_NIL_DEF(arg7, 25)
    local local3 = GET_PARAM_IF_NIL_DEF(arg8, 3)
    local local4 = GET_PARAM_IF_NIL_DEF(arg11, 3)
    if arg0:IsInterupt(INTERUPT_Damaged) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        if arg0:GetRandam_Int(1, 100) <= arg4 then
            arg1:ClearSubGoal()
            if local0 <= local1 then
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 701, TARGET_ENE_0, 0, AI_DIR_TYPE_B, local3)
            elseif local0 <= local1 + GET_PARAM_IF_NIL_DEF(arg6, 25) then
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 702, TARGET_ENE_0, 0, AI_DIR_TYPE_L, local3)
            else
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 703, TARGET_ENE_0, 0, AI_DIR_TYPE_R, local3)
            end
            return true
        end
        arg1:ClearSubGoal()
        if local0 <= GET_PARAM_IF_NIL_DEF(arg9, 40) then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 4, TARGET_ENE_0, local4, TARGET_ENE_0, true, 9910)
        else
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 4, TARGET_ENE_0, local4, TARGET_ENE_0, true, 9910)
            arg1:AddSubGoal(GOAL_COMMON_SidewayMove, GET_PARAM_IF_NIL_DEF(arg10, 4), TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, 9910)
        end
        return true
    else
        return 
    end
end

function GuardBreak_Act(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_GuardBreak) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function GuardBreak_Attack(arg0, arg1, arg2, arg3, arg4)
    if arg0:IsInterupt(INTERUPT_GuardBreak) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, arg4, TARGET_ENE_0, DIST_Middle, 0)
        return true
    else
        return false
    end
end

function MissSwing_Int(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_MissSwing) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function MissSwing_Attack(arg0, arg1, arg2, arg3, arg4)
    if arg0:IsInterupt(INTERUPT_MissSwing) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, arg4, TARGET_ENE_0, DIST_Middle, 0)
        return true
    else
        return false
    end
end

function UseItem_Act(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_UseItem) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function Shoot_1kind(arg0, arg1, arg2, arg3)
    local local0 = GET_PARAM_IF_NIL_DEF(bkStepPer, 50)
    local local1 = GET_PARAM_IF_NIL_DEF(leftStepPer, 25)
    local local2 = GET_PARAM_IF_NIL_DEF(rightStepPer, 25)
    local local3 = GET_PARAM_IF_NIL_DEF(safetyDist, 3)
    if arg0:IsInterupt(INTERUPT_Shoot) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function Shoot_2dist(arg0, arg1, arg2, arg3, arg4, arg5)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = arg0:GetRandam_Int(1, 100)
    local local2 = arg0:GetRandam_Int(1, 100)
    if arg0:IsInterupt(INTERUPT_Shoot) then
        if local0 <= arg2 then
            if local1 <= arg4 then
                arg1:ClearSubGoal()
                return 1
            end
        elseif local0 <= arg3 then
            if local1 <= arg5 then
                arg1:ClearSubGoal()
                return 2
            end
        else
            return 0
        end
    end
    return 0
end

function MissSwingSelf_Step(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = arg0:GetRandam_Int(1, 100)
    local local2 = GET_PARAM_IF_NIL_DEF(arg3, 50)
    local local3 = GET_PARAM_IF_NIL_DEF(arg5, 25)
    local local4 = GET_PARAM_IF_NIL_DEF(arg6, 3)
    if arg0:IsInterupt(INTERUPT_MissSwingSelf) and arg0:GetRandam_Int(1, 100) <= arg2 then
        arg1:ClearSubGoal()
        if local1 <= local2 then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 701, TARGET_ENE_0, 0, AI_DIR_TYPE_B, local4)
        elseif local1 <= local2 + GET_PARAM_IF_NIL_DEF(arg4, 25) then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 702, TARGET_ENE_0, 0, AI_DIR_TYPE_L, local4)
        else
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 703, TARGET_ENE_0, 0, AI_DIR_TYPE_R, local4)
        end
        return true
    else
        return 
    end
end

function RebByOpGuard_Step(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = arg0:GetRandam_Int(1, 100)
    local local2 = GET_PARAM_IF_NIL_DEF(arg3, 50)
    local local3 = GET_PARAM_IF_NIL_DEF(arg5, 25)
    local local4 = GET_PARAM_IF_NIL_DEF(arg6, 3)
    if arg0:IsInterupt(INTERUPT_ReboundByOpponentGuard) and arg0:GetRandam_Int(1, 100) <= arg2 then
        arg1:ClearSubGoal()
        if local1 <= local2 then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 701, TARGET_ENE_0, 0, AI_DIR_TYPE_B, local4)
        elseif local1 <= local2 + GET_PARAM_IF_NIL_DEF(arg4, 25) then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 702, TARGET_ENE_0, 0, AI_DIR_TYPE_L, local4)
        else
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 703, TARGET_ENE_0, 0, AI_DIR_TYPE_R, local4)
        end
        return true
    else
        return 
    end
end

function SuccessGuard_Act(arg0, arg1, arg2, arg3)
    local local0 = arg0:GetRandam_Int(1, 100)
    if arg0:IsInterupt(INTERUPT_SuccessGuard) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function SuccessGuard_Attack(arg0, arg1, arg2, arg3, arg4)
    if arg0:IsInterupt(INTERUPT_SuccessGuard) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, arg4, TARGET_ENE_0, DIST_Middle, 0)
        return true
    else
        return false
    end
end

function FarDamaged_Act(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_Damaged) and arg2 <= arg0:GetDist(TARGET_ENE_0) and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function MissSwing_Act(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_MissSwing) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function FindGuardBreak_Act(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_GuardBreak) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function FindGuardFinish_Act(arg0, arg1, arg2, arg3)
    if arg0:IsInterupt(INTERUPT_GuardFinish) and arg0:GetDist(TARGET_ENE_0) <= arg2 and arg0:GetRandam_Int(1, 100) <= arg3 then
        arg1:ClearSubGoal()
        return true
    else
        return false
    end
end

function FindShoot_Act(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = arg0:GetRandam_Int(1, 100)
    if arg0:IsInterupt(INTERUPT_Shoot) then
        if local0 <= arg5 and local1 <= arg2 then
            arg1:ClearSubGoal()
            return 1
        elseif local0 <= arg6 and local1 <= arg3 then
            arg1:ClearSubGoal()
            return 2
        elseif local0 <= arg7 and local1 <= arg4 then
            arg1:ClearSubGoal()
            return 3
        else
            arg1:ClearSubGoal()
            return 0
        end
    else
        return 0
    end
end

function BusyApproach_Act(arg0, arg1, arg2, arg3, arg4)
    local local0 = -1
    if arg0:GetRandam_Int(1, 100) <= arg4 then
        local0 = 9910
    end
    if arg3 <= arg0:GetDist(TARGET_ENE_0) then
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 10, TARGET_ENE_0, arg2, TARGET_SELF, false, local0)
    else
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 2, TARGET_ENE_0, arg2, TARGET_SELF, true, local0)
    end
    return 
end

function Approach_and_Attack_Act(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
    local local0 = true
    if arg3 <= arg0:GetDist(TARGET_ENE_0) then
        local0 = false
    end
    local local1 = -1
    if arg0:GetRandam_Int(1, 100) <= arg4 then
        local1 = 9910
    end
    arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 10, TARGET_ENE_0, arg2, TARGET_SELF, local0, local1)
    arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 10, arg5, TARGET_ENE_0, arg6, GET_PARAM_IF_NIL_DEF(arg7, 1.5), GET_PARAM_IF_NIL_DEF(arg8, 20))
    return 
end

function KeepDist_and_Attack_Act(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
    local local0 = true
    if arg4 <= arg0:GetDist(TARGET_ENE_0) then
        local0 = false
    end
    local local1 = -1
    if arg0:GetRandam_Int(1, 100) <= arg5 then
        local1 = 9910
    end
    arg1:AddSubGoal(GOAL_COMMON_KeepDist, 10, TARGET_ENE_0, arg2, arg3, TARGET_ENE_0, local0, local1)
    arg1:AddSubGoal(GOAL_COMMON_Attack, 10, arg6, TARGET_ENE_0, arg7, 0)
    return 
end

function Approach_and_GuardBreak_Act(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
    local local0 = true
    if arg3 <= arg0:GetDist(TARGET_ENE_0) then
        local0 = false
    end
    local local1 = -1
    if arg0:GetRandam_Int(1, 100) <= arg4 then
        local1 = 9910
    end
    arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 10, TARGET_ENE_0, arg2, TARGET_SELF, local0, local1)
    arg1:AddSubGoal(GOAL_COMMON_GuardBreakAttack, 10, arg5, TARGET_ENE_0, arg6, 0)
    arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, arg7, TARGET_ENE_0, arg8, 0)
    return 
end

function GetWellSpace_Act(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
    local local0 = -1
    if arg0:GetRandam_Int(1, 100) <= arg2 then
        local0 = 9910
    end
    local local1 = arg0:GetRandam_Int(1, 100)
    local local2 = arg0:GetRandam_Int(0, 1)
    if local1 > arg3 then
        if local1 <= arg3 + arg4 and arg0:GetTeamRecordCount(COORDINATE_TYPE_SideWalk_L + local2, TARGET_ENE_0, 2) < 2 then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 2.5, TARGET_ENE_0, 2, TARGET_ENE_0, true, local0)
            arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 3, TARGET_ENE_0, local2, arg0:GetRandam_Int(30, 45), true, true, local0)
        elseif local1 <= arg3 + arg4 + arg5 then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 2.5, TARGET_ENE_0, 3, TARGET_ENE_0, true, local0)
        elseif local1 <= arg3 + arg4 + arg5 + arg6 then
            arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0.5, 1), 0, 0, 0, 0)
        else
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 701, TARGET_ENE_0, 0, AI_DIR_TYPE_B, 4)
        end
    end
    return 
end

function GetWellSpace_Act_IncludeSidestep(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
    local local0 = -1
    if arg0:GetRandam_Int(1, 100) <= arg2 then
        local0 = 9910
    end
    local local1 = arg0:GetRandam_Int(1, 100)
    local local2 = arg0:GetRandam_Int(0, 1)
    if local1 > arg3 then
        if local1 <= arg3 + arg4 and arg0:GetTeamRecordCount(COORDINATE_TYPE_SideWalk_L + local2, TARGET_ENE_0, 2) < 2 then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 2.5, TARGET_ENE_0, 2, TARGET_ENE_0, true, local0)
            arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 3, TARGET_ENE_0, local2, arg0:GetRandam_Int(30, 45), true, true, local0)
        elseif local1 <= arg3 + arg4 + arg5 then
            arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 2.5, TARGET_ENE_0, 3, TARGET_ENE_0, true, local0)
        elseif local1 <= arg3 + arg4 + arg5 + arg6 then
            arg1:AddSubGoal(GOAL_COMMON_Wait, arg0:GetRandam_Float(0.5, 1), 0, 0, 0, 0)
        elseif local1 <= arg3 + arg4 + arg5 + arg6 + arg7 then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 6001, TARGET_ENE_0, 0, AI_DIR_TYPE_B, 4)
        elseif arg0:GetRandam_Int(1, 100) <= 50 then
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 6002, TARGET_ENE_0, 0, AI_DIR_TYPE_L, 4)
        else
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, 5, 6003, TARGET_ENE_0, 0, AI_DIR_TYPE_R, 4)
        end
    end
    return 
end

function Shoot_Act(arg0, arg1, arg2, arg3, arg4)
    if arg4 == 1 then
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, arg2, TARGET_ENE_0, DIST_None, 0)
    elseif 2 <= arg4 then
        arg1:AddSubGoal(GOAL_COMMON_ComboAttack, 10, arg2, TARGET_ENE_0, DIST_None, 0)
        if 3 <= arg4 then
            arg1:AddSubGoal(GOAL_COMMON_ComboRepeat, 10, arg3, TARGET_ENE_0, DIST_None, 0)
            if 4 <= arg4 then
                arg1:AddSubGoal(GOAL_COMMON_ComboRepeat, 10, arg3, TARGET_ENE_0, DIST_None, 0)
                if 5 <= arg4 then
                    arg1:AddSubGoal(GOAL_COMMON_ComboRepeat, 10, arg3, TARGET_ENE_0, DIST_None, 0)
                end
            end
        end
        arg1:AddSubGoal(GOAL_COMMON_ComboFinal, 10, arg3, TARGET_ENE_0, DIST_None, 0)
    end
    return 
end

function Approach_Act(arg0, arg1, arg2, arg3, arg4, arg5)
    if arg5 == nil then
        arg5 = 10
    end
    local local0 = true
    if arg3 <= arg0:GetDist(TARGET_ENE_0) then
        local0 = false
    end
    local local1 = -1
    if arg0:GetRandam_Int(1, 100) <= arg4 then
        local1 = 9910
    end
    arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, arg5, TARGET_ENE_0, arg2, TARGET_SELF, local0, local1)
    return 
end

function Approach_or_Leave_Act(arg0, arg1, arg2, arg3, arg4, arg5)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = true
    if arg4 ~= -1 and arg4 <= local0 then
        local1 = false
    end
    local local2 = -1
    if arg0:GetRandam_Int(1, 100) <= arg5 then
        local2 = 9910
    end
    if arg2 <= local0 then
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 5, TARGET_ENE_0, arg3, TARGET_SELF, local1, local2)
    else
        arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 5, TARGET_ENE_0, arg2, TARGET_ENE_0, true, local2)
    end
    return 
end

function Watching_Parry_Chance_Act(arg0, arg1)
    FirstDist = arg0:GetRandam_Float(2, 4)
    SecondDist = arg0:GetRandam_Float(2, 4)
    arg1:AddSubGoal(GOAL_COMMON_KeepDist, 5, TARGET_ENE_0, FirstDist, FirstDist + 0.5, TARGET_ENE_0, true, 9920)
    arg1:AddSubGoal(GOAL_COMMON_SidewayMove, arg0:GetRandam_Float(3, 5), TARGET_ENE_0, arg0:GetRandam_Int(0, 1), 180, true, true, 9920)
    arg1:AddSubGoal(GOAL_COMMON_KeepDist, 5, TARGET_ENE_0, SecondDist, SecondDist + 0.5, TARGET_ENE_0, true, 9920)
    arg1:AddSubGoal(GOAL_COMMON_SidewayMove, arg0:GetRandam_Float(3, 5), TARGET_ENE_0, arg0:GetRandam_Int(0, 1), 180, true, true, 9920)
    return 
end

function Parry_Act(arg0, arg1, arg2, arg3, arg4, arg5)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    if arg0:IsInterupt(INTERUPT_ParryTiming) then
        if local0 <= arg2 and arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_F, arg3) and not arg0:IsActiveGoal(GOAL_COMMON_Parry) then
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_Parry, 1.25, 4000, TARGET_SELF, 0)
            return true
        end
    elseif arg0:IsInterupt(INTERUPT_SuccessParry) and local0 <= arg4 and arg0:IsInsideTarget(TARGET_ENE_0, AI_DIR_TYPE_F, arg5) then
        arg1:ClearSubGoal()
        if 1 < local0 then
            arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 3, TARGET_ENE_0, 1, TARGET_SELF, false, -1)
        else
            arg1:AddSubGoal(GOAL_COMMON_Wait, 1, TARGET_ENE_0)
        end
        arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, 2, 3110, TARGET_ENE_0, 3, 0, -1)
        return true
    end
    return 
end

function ObserveAreaForBackstab(arg0, arg1, arg2, arg3, arg4)
    arg0:AddObserveArea(arg2, TARGET_ENE_0, TARGET_SELF, AI_DIR_TYPE_B, arg4, arg3)
    return 
end

function Backstab_Act(arg0, arg1, arg2, arg3, arg4, arg5)
    if arg0:IsInterupt(INTERUPT_Inside_ObserveArea) and arg0:IsThrowing() == false and arg0:IsFinishTimer(arg4) == true and arg0:IsInsideObserve(arg2) then
        arg0:SetTimer(arg4, arg5)
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 5, TARGET_ENE_0, arg3, TARGET_SELF, false, -1)
        arg1:AddSubGoal(GOAL_COMMON_Attack, 10, 3110, TARGET_ENE_0, 3, 0)
        return true
    else
        return 
    end
end

function Torimaki_Act(arg0, arg1, arg2)
    local local0 = -1
    if arg0:GetRandam_Int(1, 100) <= arg2 then
        local0 = 9910
    end
    local local1 = arg0:GetDist(TARGET_ENE_0)
    if 15 <= local1 then
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 5, TARGET_ENE_0, 4.5, TARGET_SELF, true, -1)
    elseif 6 <= local1 then
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 5, TARGET_ENE_0, 4.5, TARGET_SELF, true, -1)
    elseif 3 <= local1 then
        arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 3, TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, local0)
    else
        arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 5, TARGET_ENE_0, 4, TARGET_ENE_0, true, local0)
    end
    arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 3, TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, local0)
    return 
end

function Kankyaku_Act(arg0, arg1, arg2)
    local local0 = -1
    if arg0:GetRandam_Int(1, 100) <= arg2 then
        local0 = 9910
    end
    local local1 = arg0:GetDist(TARGET_ENE_0)
    if 15 <= local1 then
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 5, TARGET_ENE_0, 6.5, TARGET_SELF, true, -1)
    elseif 8 <= local1 then
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, 5, TARGET_ENE_0, 6.5, TARGET_SELF, true, -1)
    elseif 4 <= local1 then
        arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 3, TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, local0)
    else
        arg1:AddSubGoal(GOAL_COMMON_LeaveTarget, 5, TARGET_ENE_0, 6, TARGET_ENE_0, true, local0)
    end
    arg1:AddSubGoal(GOAL_COMMON_SidewayMove, 3, TARGET_ENE_0, arg0:GetRandam_Int(0, 1), arg0:GetRandam_Int(30, 45), true, true, local0)
    return 
end

function ClearTableParam(arg0, arg1)
    local local0 = 1
    local local1 = 1
    for local2 = 1 - local1, 50, local1 do
        arg0[local2] = 0
        arg1[local2] = {}
    end
    return 
end

function SelectOddsIndex(arg0, arg1)
    local local0 = table.getn(arg1)
    local local1 = 0
    local local2 = 1
    for local3 = 1 - local2, local0, local2 do
        local1 = local1 + arg1[local3]
    end
    local3 = arg0:GetRandam_Int(0, local1 - 1)
    local local4 = 1
    for local5 = 1 - local4, local0, local4 do
        local local6 = arg1[local5]
        if local3 < local6 then
            return local5
        end
        local3 = local3 - local6
    end
    return -1
end

function SelectFunc(arg0, arg1, arg2)
    local local0 = SelectOddsIndex(arg0, arg1)
    if local0 < 1 then
        return nil
    else
        return arg2[local0]
    end
end

function SelectGoalFunc(arg0, arg1, arg2)
    return SelectFunc(arg1, arg2, _GetGoalActFuncTable(arg0))
end

function CallAttackAndAfterFunc(arg0, arg1, arg2, arg3, arg4, arg5)
    local local0 = SelectOddsIndex(arg1, arg3)
    local local1 = 0
    if 1 <= local0 then
        local local2 = _GetGoalActFuncTable(arg0)
        local local3 = nil
        if arg4 ~= nil then
            local3 = arg4[local0]
        end
        local1 = local2[local0](arg0, arg1, arg2, local3)
    end
    if arg1:GetRandam_Int(1, 100) <= local1 then
        if arg0["ActAfter"] ~= nil then
            arg0:ActAfter(arg1, arg2, arg5)
        else
            HumanCommon_ActAfter_AdjustSpace(arg1, arg2, arg5)
        end
    end
    return 
end

function _GetGoalActFuncTable(arg0)
    local local0 = {arg0["Act01"], arg0["Act02"], arg0["Act03"], arg0["Act04"], arg0["Act05"], arg0["Act06"], arg0["Act07"], arg0["Act08"], arg0["Act09"], arg0["Act10"], arg0["Act11"], arg0["Act12"], arg0["Act13"], arg0["Act14"], arg0["Act15"], arg0["Act16"], arg0["Act17"], arg0["Act18"], arg0["Act19"], arg0["Act20"]}
    return local0
end

function GetTargetAngle(arg0, arg1)
    if arg0:IsInsideTarget(arg1, AI_DIR_TYPE_F, 90) then
        if arg0:IsInsideTarget(arg1, AI_DIR_TYPE_F, 90) then
            return TARGET_ANGLE_FRONT
        elseif arg0:IsInsideTarget(arg1, AI_DIR_TYPE_L, 180) then
            return TARGET_ANGLE_LEFT
        else
            return TARGET_ANGLE_RIGHT
        end
    elseif arg0:IsInsideTarget(arg1, AI_DIR_TYPE_L, 90) then
        return TARGET_ANGLE_LEFT
    elseif arg0:IsInsideTarget(arg1, AI_DIR_TYPE_R, 90) then
        return TARGET_ANGLE_RIGHT
    else
        return TARGET_ANGLE_BACK
    end
end

function GetCurrentTimeType(arg0)
    local local0 = 360
    local local1 = 600
    local local2 = 1080
    local local3 = 1200
    local local4 = 180
    local local5 = arg0:GetAreaMinute() + arg0:GetAreaHour() * 60
    if local0 <= local5 and local5 < local1 then
        return PLAN_TIME_TYPE_MORNING
    elseif local1 <= local5 and local5 < local2 then
        return PLAN_TIME_TYPE_DAYTIME
    elseif local2 <= local5 and local5 < local3 then
        return PLAN_TIME_TYPE_EVENING
    elseif not (local3 > local5 or local5 >= 1440) or 0 <= local5 and local5 < local4 then
        return PLAN_TIME_TYPE_NIGHT
    elseif local4 <= local5 and local5 < local0 then
        return PLAN_TIME_TYPE_MIDNIGHT
    else
        return nil
    end
end

function IsTargetTimeZone(arg0, arg1)
    local local0 = 360
    local local1 = 600
    local local2 = 1080
    local local3 = 1200
    local local4 = 180
    local local5 = arg0:GetAreaMinute() + arg0:GetAreaHour() * 60
    if arg1 == PLAN_TIME_TYPE_MORNING then
        if local0 <= local5 and local5 < local1 then
            return true
        else
            return false
        end
    elseif arg1 == PLAN_TIME_TYPE_DAYTIME then
        if local1 <= local5 and local5 < local2 then
            return true
        else
            return false
        end
    elseif arg1 == PLAN_TIME_TYPE_EVENING then
        if local2 <= local5 and local5 < local3 then
            return true
        else
            return false
        end
    elseif arg1 == PLAN_TIME_TYPE_NIGHT then
        if not (local3 > local5 or local5 >= 1440) or 0 <= local5 and local5 < local4 then
            return true
        else
            return false
        end
    elseif arg1 == PLAN_TIME_TYPE_MIDNIGHT then
        if local4 <= local5 and local5 < local0 then
            return true
        else
            return false
        end
    else
        return false
    end
end

function IsInsideTargetTimeZone(arg0, arg1, arg2)
    local local0 = false
    local local1 = false
    local local2 = {}
    local2[PLAN_TIME_TYPE_MORNING] = false
    local2[PLAN_TIME_TYPE_DAYTIME] = false
    local2[PLAN_TIME_TYPE_EVENING] = false
    local2[PLAN_TIME_TYPE_NIGHT] = false
    local2[PLAN_TIME_TYPE_MIDNIGHT] = false
    local local3 = 0
end

function GET_PARAM_IF_NIL_DEF(arg0, arg1)
    if arg0 ~= nil then
        return arg0
    else
        return arg1
    end
end

function REGIST_FUNC(arg0, arg1, arg2, arg3)
    arg0 = arg2
    arg0 = arg1
    arg0 = arg3
    return function ()
        return UPVAL0(UPVAL1, UPVAL2, UPVAL3)
    end

end

function Approach_Act_Flex(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
    if arg7 == nil then
        arg7 = 3
    end
    if arg8 == nil then
        arg8 = 8
    end
    local local0 = arg0:GetDist(TARGET_ENE_0)
    local local1 = true
    if arg4 <= local0 then
        local1 = false
    elseif arg3 <= local0 and arg0:GetRandam_Int(1, 100) <= arg5 then
        local1 = false
    end
    local local2 = -1
    if arg0:GetRandam_Int(1, 100) <= arg6 then
        local2 = 9910
    end
    if local1 == true then
        life = arg7
    else
        life = arg8
    end
    local local3 = 0
    if arg2 <= local0 then
        if local1 == true then
            arg2 = arg2 + arg0:GetStringIndexedNumber("AddDistWalk") + local3
        else
            arg2 = arg2 + arg0:GetStringIndexedNumber("AddDistRun") + local3
        end
        arg1:AddSubGoal(GOAL_COMMON_ApproachTarget, life, TARGET_ENE_0, arg2, TARGET_SELF, local1, local2)
    end
    return 
end

function SpaceCheck(arg0, arg1, arg2, arg3)
    local local0 = arg0:GetMapHitRadius(TARGET_SELF)
    if arg3 * 0.95 <= arg0:GetExistMeshOnLineDistSpecifyAngleEx(TARGET_SELF, arg2, arg3 + local0, AI_SPA_DIR_TYPE_TargetF, local0, 0) then
        return true
    else
        return false
    end
end

function InsideRange(arg0, arg1, arg2, arg3, arg4, arg5)
    return YSD_InsideRangeEx(arg0, arg1, arg2, arg3, arg4, arg5)
end

function InsideDir(arg0, arg1, arg2, arg3)
    return YSD_InsideRangeEx(arg0, arg1, arg2, arg3, -999, 999)
end

function YSD_InsideRangeEx(arg0, arg1, arg2, arg3, arg4, arg5)
    local local0 = arg0:GetDist(TARGET_ENE_0)
    if arg4 <= local0 and local0 <= arg5 then
        local local1 = arg0:GetToTargetAngle(TARGET_ENE_0)
        local local2 = 0
        if arg2 < 0 then
            local2 = -1
        else
            local2 = 1
        end
        if not (arg2 + arg3 / -2 > local1 or local1 > arg2 + arg3 / 2) or arg2 + arg3 / -2 <= local1 + 360 * local2 and local1 + 360 * local2 <= arg2 + arg3 / 2 then
            return true
        else
            return false
        end
    else
        return false
    end
end

function SetCoolTime(arg0, arg1, arg2, arg3, arg4, arg5)
    if arg4 <= 0 then
        return 0
    elseif arg0:GetAttackPassedTime(arg2) <= arg0:RegistAttackTimeInterval(arg2, arg3) then
        return arg5
    else
        return arg4
    end
end

function Counter_Act(arg0, arg1, arg2, arg3)
    if arg2 == nil then
        arg2 = 4
    end
    local local0 = arg0:GetNumber(15)
    if arg0:IsInterupt(INTERUPT_Damaged) then
        arg0:SetTimer(15, 5)
        if local0 == 0 then
            local0 = arg2
        end
        arg0:SetNumber(15, local0 * 2)
    end
    if 100 <= local0 then
        arg0:SetNumber(15, 100)
    end
    if arg0:IsInterupt(INTERUPT_Damaged) and arg0:GetRandam_Int(1, 100) <= arg0:GetNumber(15) and arg0:GetTimer(14) <= 0 then
        arg0:SetTimer(14, 3)
        arg0:SetNumber(15, 0)
        arg1:ClearSubGoal()
        arg1:AddSubGoal(GOAL_COMMON_EndureAttack, 0.5, arg3, TARGET_ENE_0, DIST_None, 0, 180, 0, 0)
        return true
    else
        return false
    end
end

function ReactBackstab_Act(arg0, arg1, arg2, arg3, arg4)
    local local0 = arg0:GetRandam_Int(1, 100)
    local local1 = 3
    local local2 = 6000
    local local3 = 6002
    local local4 = 6003
    if arg3 == nil then
        arg4 = 0
    end
    if arg0:IsInterupt(INTERUPT_BackstabRisk) then
        if arg0:GetRandam_Int(1, 100) <= arg4 then
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_StabCounterAttack, local1, arg3, TARGET_ENE_0, DIST_None, 0, 180, 0, 0)
        elseif arg2 == 1 then
            arg1:ClearSubGoal()
            arg1:AddSubGoal(GOAL_COMMON_SpinStep, local1, local2, TARGET_SELF, 0, AI_DIR_TYPE_F, 0)
        elseif arg2 == 2 then
            arg1:ClearSubGoal()
            if local0 <= 50 then
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, local1, local3, TARGET_SELF, 0, AI_DIR_TYPE_L, 0)
            else
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, local1, local4, TARGET_SELF, 0, AI_DIR_TYPE_R, 0)
            end
        elseif arg2 == 3 then
            arg1:ClearSubGoal()
            if local0 <= 33 then
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, local1, local2, TARGET_SELF, 0, AI_DIR_TYPE_F, 0)
            elseif local0 <= 66 then
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, local1, local3, TARGET_SELF, 0, AI_DIR_TYPE_L, 0)
            else
                arg1:AddSubGoal(GOAL_COMMON_SpinStep, local1, local4, TARGET_SELF, 0, AI_DIR_TYPE_R, 0)
            end
        end
        return false
    else
        return 
    end
end

function Init_Pseudo_Global(arg0, arg1)
    arg0:SetStringIndexedNumber("Dist_SideStep", 5)
    arg0:SetStringIndexedNumber("Dist_BackStep", 5)
    arg0:SetStringIndexedNumber("AddDistWalk", 0)
    arg0:SetStringIndexedNumber("AddDistRun", 0)
    Init_AfterAttackAct(arg0, arg1)
    return 
end

function Init_AfterAttackAct(arg0, arg1)
    arg0:SetStringIndexedNumber("DistMin_AAA", -999)
    arg0:SetStringIndexedNumber("DistMax_AAA", 999)
    arg0:SetStringIndexedNumber("BaseDir_AAA", AI_DIR_TYPE_F)
    arg0:SetStringIndexedNumber("Angle_AAA", 360)
    arg0:SetStringIndexedNumber("Odds_Guard_AAA", 0)
    arg0:SetStringIndexedNumber("Odds_NoAct_AAA", 0)
    arg0:SetStringIndexedNumber("Odds_BackAndSide_AAA", 0)
    arg0:SetStringIndexedNumber("Odds_Back_AAA", 0)
    arg0:SetStringIndexedNumber("Odds_Backstep_AAA", 0)
    arg0:SetStringIndexedNumber("Odds_Sidestep_AAA", 0)
    arg0:SetStringIndexedNumber("Odds_BitWait_AAA", 0)
    arg0:SetStringIndexedNumber("Odds_BsAndSide_AAA", 0)
    arg0:SetStringIndexedNumber("Odds_BsAndSs_AAA", 0)
    arg0:SetStringIndexedNumber("DistMin_Inter_AAA", -999)
    arg0:SetStringIndexedNumber("DistMax_Inter_AAA", 999)
    arg0:SetStringIndexedNumber("BaseAng_Inter_AAA", 0)
    arg0:SetStringIndexedNumber("Ang_Inter_AAA", 360)
    arg0:SetStringIndexedNumber("BackAndSide_BackLife_AAA", 2)
    arg0:SetStringIndexedNumber("BackAndSide_SideLife_AAA", arg0:GetRandam_Float(2.5, 3.5))
    arg0:SetStringIndexedNumber("BackLife_AAA", arg0:GetRandam_Float(2, 3))
    arg0:SetStringIndexedNumber("BsAndSide_SideLife_AAA", arg0:GetRandam_Float(2.5, 3.5))
    arg0:SetStringIndexedNumber("BackAndSide_BackDist_AAA", 1.5)
    arg0:SetStringIndexedNumber("BackDist_AAA", arg0:GetRandam_Float(2.5, 3.5))
    arg0:SetStringIndexedNumber("BackAndSide_SideDir_AAA", arg0:GetRandam_Int(45, 60))
    arg0:SetStringIndexedNumber("BsAndSide_SideDir_AAA", arg0:GetRandam_Int(45, 60))
    return 
end

function Update_Default_NoSubGoal(arg0, arg1, arg2)
    if arg2:GetSubGoalNum() <= 0 then
        return GOAL_RESULT_Success
    else
        return GOAL_RESULT_Continue
    end
end

function GuardGoalSubFunc_Activate(arg0, arg1, arg2)
    if 0 < arg2 then
        arg0:DoEzAction(arg1, arg2)
    end
    return 
end

function GuardGoalSubFunc_Update(arg0, arg1, arg2, arg3, arg4)
    if 0 < arg2 then
        if arg1:GetNumber(0) ~= 0 then
            return GOAL_RESULT_Failed
        elseif arg1:GetNumber(1) ~= 0 then
            return arg3
        end
    end
    if arg1:GetLife() <= 0 then
        if arg4 then
            return GOAL_RESULT_Success
        else
            return GOAL_RESULT_Failed
        end
    else
        return GOAL_RESULT_Continue
    end
end

function GuardGoalSubFunc_Interrupt(arg0, arg1, arg2, arg3)
    if 0 < arg2 then
        if arg0:IsInterupt(INTERUPT_Damaged) then
            arg1:SetNumber(0, 1)
        elseif arg0:IsInterupt(INTERUPT_SuccessGuard) and arg3 ~= GOAL_RESULT_Continue then
            arg1:SetNumber(1, 1)
        end
    end
    return false
end

return 
