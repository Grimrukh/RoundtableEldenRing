function _COMMON_GetEzStateAnimId(arg0, arg1)
    ret = {}
    local local0 = 1
    local local1 = 1
    for local2 = 1 - local1, 30, local1 do
        ret[local2] = arg0:GetEzStateAnimId(arg1, local2 - 1)
    end
    return ret
end

function _COMMON_GetMinDist(arg0, arg1)
    ret = {}
    local local0 = 1
    local local1 = 1
    for local2 = 1 - local1, 30, local1 do
        ret[local2] = arg0:GetMinDist(arg1, local2 - 1)
    end
    return ret
end

function _COMMON_GetMaxDist(arg0, arg1)
    ret = {}
    local local0 = 0
    local local1 = 1
    for local2 = 0 - local1, 29, local1 do
        ret[local2] = arg0:GetMaxDist(arg1, local2 - 1)
    end
    return ret
end

function _COMMON_GetAtkDistType(arg0, arg1)
    ret = {}
    local local0 = 1
    local local1 = 1
    local local2 = 1 - local1
    goto basicblock_12:
end

function _COMMON_GetOddsParam(arg0, arg1)
    ret = {}
    local local0 = 0
    local local1 = 1
    for local2 = 0 - local1, 99, local1 do
        ret[local2] = arg0:GetOddsParam(arg0:GetOddsParamIdOffset(100) + arg1, local2)
    end
    return ret
end

function _COMMON_MulOddsXWeight(arg0, arg1)
    local local0 = 0
    local local1 = true
    if table.getn(arg1) == 0 then
        local1 = false
    end
    local local2 = 0
    local local3 = 0
    local local4 = 1
    for local5 = 0 - local4, 99, local4 do
        if local1 == false then
            arg1[local5] = 1
        end
        arg0[local5] = arg0[local5] * arg1[local5]
        if arg0[local5] < 0 then
            arg0[local5] = 0
        else
            arg0[local5] = arg0[local5] + local2
            local2 = arg0[local5]
            if local3 < arg0[local5] then
                local3 = arg0[local5]
            end
        end
    end
    return local3
end

function _COMMON_MulWeightParam(arg0, arg1, arg2)
    local local0 = false
    if table.getn(arg1) == 0 then
        local0 = true
    end
    local local1 = 0
    local local2 = 1
    for local3 = 0 - local2, 99, local2 do
        if local0 then
            arg1[local3] = 1
        end
        arg1[local3] = arg1[local3] * arg0:GetOddsParam(arg0:GetOddsParamIdOffset(100) + arg2, local3)
    end
    return 
end

function _COMMON_SetEnemyActRate(arg0, arg1, arg2, arg3)
    arg1:SetStringIndexedNumber("ActRate01", arg3)
    arg1:SetStringIndexedNumber("ActRate02", arg3)
    arg1:SetStringIndexedNumber("ActRate03", arg3)
    arg1:SetStringIndexedNumber("ActRate04", arg3)
    arg1:SetStringIndexedNumber("ActRate05", arg3)
    arg1:SetStringIndexedNumber("ActRate06", arg3)
    arg1:SetStringIndexedNumber("ActRate07", arg3)
    arg1:SetStringIndexedNumber("ActRate08", arg3)
    arg1:SetStringIndexedNumber("ActRate09", arg3)
    arg1:SetStringIndexedNumber("ActRate10", arg3)
    arg1:SetStringIndexedNumber("ActRate11", arg3)
    arg1:SetStringIndexedNumber("ActRate12", arg3)
    arg1:SetStringIndexedNumber("ActRate13", arg3)
    arg1:SetStringIndexedNumber("ActRate14", arg3)
    arg1:SetStringIndexedNumber("ActRate15", arg3)
    arg1:SetStringIndexedNumber("ActRate16", arg3)
    arg1:SetStringIndexedNumber("ActRate17", arg3)
    arg1:SetStringIndexedNumber("ActRate18", arg3)
    arg1:SetStringIndexedNumber("ActRate19", arg3)
    arg1:SetStringIndexedNumber("ActRate20", arg3)
    return 
end

return 
