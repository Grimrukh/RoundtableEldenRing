function Platoon000600_Initialize(arg0)
    arg0:SetEnablePlatoonMove(true)
    arg0:SetFormationType(0, 2)
    arg0:SetFormationParam(0, 0, 0)
    arg0:SetFormationParam(1, 5, 9)
    arg0:SetFormationParam(2, -5, 9)
    arg0:SetFormationParam(3, 0, -4)
    arg0:SetBaseMoveRate(0, 1.6)
    arg0:SetBaseMoveRate(3, 0.8)
    arg0:SetBaseMoveRate(1, 1.2)
    arg0:SetBaseMoveRate(2, 1.2)
    return 
end

function Platoon000600_Activate(arg0)
    return 
end

function Platoon000600_Deactivate(arg0)
    return 
end

function Platoon000600_Update(arg0)
    Platoon_Common_Act(arg0, 1)
    return 
end

return 
