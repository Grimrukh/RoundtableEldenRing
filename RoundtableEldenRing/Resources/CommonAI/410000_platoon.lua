function Platoon410000_Initialize(arg0)
    arg0:SetEnablePlatoonMove(false)
    return 
end

function Platoon410000_Activate(arg0)
    return 
end

function Platoon410000_Deactivate(arg0)
    return 
end

function Platoon410000_Update(arg0)
    local local0 = 0
    local local1 = -1
    for local2 = arg0:GetMemberNum() - 1 - local1, 0, local1 do
        local local3 = arg0:GetMemberAI(local2)
        if local3 ~= nill and local3:GetHpRate(TARGET_SELF) <= 0 then
            local0 = local0 + 1
        end
    end
    local2 = arg0:GetMemberNum() / 2
    if math.floor(arg0:GetMemberNum() / 2) <= local0 then
        arg0:SendCommandAll(101)
    else
        arg0:SendCommandAll(100)
    end
    return 
end

return 
