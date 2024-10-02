function Platoon002000_Initialize(arg0)
    arg0:SetEnablePlatoonMove(false)
    arg0:SetTimer(0, 2)
    return 
end

function Platoon002000_Activate(arg0)
    return 
end

function Platoon002000_Deactivate(arg0)
    return 
end

function Platoon002000_Update(arg0)
    arg0:SetEnablePlatoonMove(false)
    if 0 < arg0:GetTeamDefeatEntityId() and arg0:IsExistTargetTeamDefeat() == false then
        arg0:SendCommandAll(PLAN_PLATOON_COMMAND__BUDDY_RETURN)
    else
        arg0:SendCommandAll(PLAN_PLATOON_COMMAND__BUDDY_BATTLE)
    end
    return 
end

return 
