function Platoon001000_Initialize(arg0)
    return 
end

function Platoon001000_Activate(arg0)
    return 
end

function Platoon001000_Deactivate(arg0)
    return 
end

function Platoon001000_Update(arg0)
    local local0 = arg0:GetMemberAI(0)
    local local1 = false
    local local2 = 0
    local local3 = 0
    if local0 ~= nil then
        if local0:HasSpecialEffectId(TARGET_SELF, 13600) == true and arg0:GetNumber(0) ~= 1 then
            local1 = true
            if local0:HasSpecialEffectId(TARGET_SELF, 13601) == true then
                local2 = 1
                local3 = 7
            elseif local0:HasSpecialEffectId(TARGET_SELF, 13602) == true then
                local2 = 8
                local3 = 14
            elseif local0:HasSpecialEffectId(TARGET_SELF, 13603) == true then
                local2 = 15
                local3 = 21
            elseif local0:HasSpecialEffectId(TARGET_SELF, 13604) == true then
                local2 = 22
                local3 = 28
            elseif local0:HasSpecialEffectId(TARGET_SELF, 5024) == true then
                local2 = 29
                local3 = 31
            else
                local2 = 0
                local3 = 0
            end
            arg0:SetNumber(0, 1)
        elseif local0:HasSpecialEffectId(TARGET_SELF, 13600) == false then
            arg0:SetNumber(0, 0)
        end
    end
    if local1 == true then
        local local4 = 0
        local local5 = 0
        local local6 = 0
        local local7 = 0
        local local8 = {}
        local local9 = 0
        local local10 = {}
        local local11 = 0
        local local12 = 1
        local local13 = local2 - local12
    end
    return 
end

return 
