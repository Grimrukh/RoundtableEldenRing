function Common_NPC_AI_GetItemUseDist(arg0, arg1, arg2, arg3, arg4)
    local local0 = arg1:Mod(arg1:GetAIUsageParam(1, arg3), 100)
    local local1 = arg4
    if local0 == 0 then
        local1 = arg4
    end
    if local0 == 1 then
        local1 = 7
    end
    if local0 == 2 then
        local1 = 5
    end
    if local0 == 3 then
        local1 = 3
    end
    if local0 == 4 then
        local1 = 1.5
    end
    arg1:SetStringIndexedNumber("Item_ApproachDist", local1)
    return 
end

function Common_NPC_AI_GetSpellUseDist(arg0, arg1, arg2, arg3)
    local local0 = arg1:GetAIUsageParam(0, arg3)
    local local1 = arg1:Mod(local0, 100)
    local local2 = 10
    if local1 == 0 then
        local local3 = math.floor(local0 / 1000000)
        if local3 == 10 then
            local2 = 10
        elseif local3 == 11 then
            local2 = 6
        elseif local3 == 12 then
            local2 = 2.5
        end
    end
    if local1 == 10 then
        local2 = 20
    end
    if local1 == 20 then
        local2 = 7.5
    end
    if local1 == 21 then
        local2 = 3.5
    end
    if local1 == 30 then
        local2 = 1.5
    end
    arg1:SetStringIndexedNumber("Spell_ApproachDist", local2)
    return 
end

function Common_NPC_AI_GetArtsUseDist(arg0, arg1, arg2, arg3, arg4)
    local local0 = arg1:Mod(arg1:GetAIUsageParam(2, arg3), 100)
    local local1 = arg4
    if local0 == 0 then
        local1 = arg4
    end
    if local0 == 1 then
        local1 = 7
    end
    if local0 == 2 then
        local1 = 5
    end
    if local0 == 3 then
        local1 = 3
    end
    if local0 == 4 then
        local1 = 1.5
    end
    if local0 == 5 then
        local1 = -1
    end
    arg1:SetStringIndexedNumber("Arts_ApproachDist", local1)
    return 
end

return 
