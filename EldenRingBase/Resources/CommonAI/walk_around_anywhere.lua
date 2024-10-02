REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 0, "移動時の到達判定距離", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 1, "移動時間", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 2, "歩くか", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 3, "見回しアニメのID", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 4, "見回しアニメを行う時間", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 5, "移動→見回しを行うセット数", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 6, "最初に見回しアニメをしてから移動するか", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 7, "毎回移動ポイントを再生成するか", 0)
REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_WalkAround_Anywhere, 8, "見回しアニメのゴールをアニメ終了まで待つか", 0)
function WalkAroundAnywhere_Activate(arg0, arg1)
    if arg0:GetStringIndexedNumber("COMMON_WAA__isPointCreated") == 0 then
        arg0:BeginWalkAroundFree()
        arg0:SetStringIndexedNumber("COMMON_WAA__isPointCreated", 1)
    end
    arg0:ChangeWalkAroundFreePoint()
    if arg1:GetParam(6) == 1 then
        arg1:SetNumber(0, 1)
    else
        arg1:SetNumber(0, 0)
    end
    WalkAroundAnyWhere_InnerGoal(arg0, arg1)
    return 
end

function WalkAroundAnywhere_Update(arg0, arg1)
    local local0 = arg1:GetParam(5)
    if arg1:GetSubGoalNum() <= 0 and (local0 == -1 or arg1:GetNumber(1) < local0) then
        WalkAroundAnyWhere_InnerGoal(arg0, arg1)
    end
    return GOAL_RESULT_Continue
end

function WalkAroundAnywhere_Terminate(arg0, arg1)
    return 
end

function WalkAroundAnywhere_Interupt(arg0, arg1)
    if arg0:IsInterupt(INTERUPT_MovedEnd_OnFailedPath) then
        arg1:ClearSubGoal()
        WalkAroundAnyWhere_InnerGoal(arg0, arg1)
        return true
    else
        return false
    end
end

function WalkAroundAnyWhere_InnerGoal(arg0, arg1)
    local local0 = arg1:GetParam(3)
    local local1 = arg1:GetParam(4)
    local local2 = POINT_WalkAroundPosition_Free
    local local3 = arg0:GetDist(local2)
    if arg1:GetNumber(0) == 0 then
        local local4 = arg1:AddSubGoal(GOAL_COMMON_MoveToSomewhere, arg1:GetParam(1), local2, AI_DIR_TYPE_CENTER, arg1:GetParam(0), TARGET_SELF, arg1:GetParam(2))
        local4:SetLifeEndSuccess(true)
        arg1:SetNumber(0, 1)
    else
        if arg1:GetParam(5) ~= -1 then
            arg1:SetNumber(1, arg1:GetNumber(1) + 1)
        end
        if local0 == -1 then
            arg1:AddSubGoal(GOAL_COMMON_Wait, local1, TARGET_SELF, 0, 0, 0)
        elseif arg1:GetParam(8) == 1 then
            arg1:AddSubGoal(GOAL_COMMON_WaitWithAnime, local1, local0, TARGET_SELF)
        else
            arg1:AddSubGoal(GOAL_COMMON_AttackTunableSpin, local1, local0, TARGET_SELF, 9999, 0, -1)
        end
        arg1:SetNumber(0, 0)
        if arg1:GetParam(7) == 1 then
            arg0:EndWalkAroundFree()
            arg0:BeginWalkAroundFree()
        end
        arg0:ChangeWalkAroundFreePoint()
    end
    return false
end

return 
