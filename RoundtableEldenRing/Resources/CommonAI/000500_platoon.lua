function Platoon000500_Initialize(arg0)
    arg0:SetEnablePlatoonMove(true)
    arg0:SetFormationType(0, 2)
    arg0:SetFormationParam(0, 0, 0)
    local local0 = 0
    local local1 = 1
    for local2 = 1 - local1, arg0:GetMemberNum() - 1, local1 do
        arg0:SetFormationParam(local2, 0, -(local2 * 3))
    end
    arg0:SetBaseMoveRate(0, 1.5)
    local1 = 1
    for local2 = 1 - local1, arg0:GetMemberNum() - 1, local1 do
        arg0:SetBaseMoveRate(local2, 1)
    end
    if 7 < arg0:GetMemberNum() then
        local1 = 1
        for local2 = arg0:GetMemberNum() - 2 - local1, arg0:GetMemberNum() - 1, local1 do
            arg0:SetBaseMoveRate(local2, 3)
        end
    end
    return 
end

function Platoon000500_Activate(arg0)
    return 
end

function Platoon000500_Deactivate(arg0)
    return 
end

function Platoon000500_Update(arg0)
    local local0 = arg0:GetMemberAI(0)
    if local0:GetEventRequest() == 4599 then
        local local1 = 1
        for local2 = 0 - local1, arg0:GetMemberNum() - 1, local1 do
            arg0:SetBaseMoveRate(local2, 5)
        end
    end
    Platoon_Common_Act(arg0, 1)
    return 
end

return 
