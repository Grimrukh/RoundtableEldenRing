function Platoon001010_Initialize(arg0)
    return 
end

function Platoon001010_Activate(arg0)
    return 
end

function Platoon001010_Deactivate(arg0)
    return 
end

function Platoon001010_Update(arg0)
    local local0 = arg0:GetMemberAI(0)
    local0:SetNumber(15, 10)
    if local0:IsEventFlag(13002821) == false and local0:HasSpecialEffectId(TARGET_SELF, 15259) == false then
        local local1 = 0
        local local2 = 0
        local0:SetNumber(15, 11)
        local local3 = {}
        local local4 = nil
        local local5 = 1
        local local6 = 1 - local5
    end
    return 
end

return 
