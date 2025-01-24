function Common_NPC_AI_GetWeponParam(arg0, arg1, arg2, arg3)
    local local0 = arg1:GetCurrentEquipWeaponId(TARGET_SELF, arg3)
    local local1 = arg1:GetWeaponBehaviorVarID(local0)
    local local2 = 5
    local local3 = 5
    local local4 = 3
    local local5 = 3
    local local6 = 3
    local local7 = 3
    local local8 = 3
    local local9 = 3
    local local10 = 3
    local local11 = 3
    local local12 = 3
    local local13 = 3
    local local14 = 3
    local local15 = 3
    local local16 = 3
    local local17 = 3
    local local18 = 0
    local local19 = 0
    local local20 = 1
    local local21 = 1
    local local22 = 3
    local local23 = 3
    local local24 = 5
    local local25 = 2
    if 100 <= local1 and local1 <= 199 then
        local2 = 1.1
        local3 = 1
        local4 = 1.2
        local5 = 1.1
        local6 = 1.4
        local7 = 1.2
        local8 = 1.4
        local9 = 1.2
        local10 = 1.2
        local11 = 1.2
        local12 = 2
        local13 = 2.4
        local14 = 2
        local15 = 2.4
        local17 = 2
        local17 = 2.4
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 6
        local25 = 2
    end
    if 200 <= local1 and local1 <= 299 then
        local2 = 2.2
        local3 = 2
        local4 = 2
        local5 = 1.5
        local6 = 2.5
        local7 = 2
        local8 = 2.5
        local9 = 1.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 3
        local14 = 2.8
        local15 = 2.5
        local17 = 3.9
        local17 = 2.4
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 300 <= local1 and local1 <= 399 then
        local2 = 1.8
        local3 = 1.6
        local4 = 2.3
        local5 = 2.1
        local6 = 3.5
        local7 = 2
        local8 = 2.3
        local9 = 2.8
        local10 = 2.8
        local11 = 2.4
        local12 = 4.2
        local13 = 3.4
        local14 = 2.2
        local15 = 2.6
        local17 = 3
        local17 = 3
        local18 = 20
        local19 = 4
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 4
        local25 = 2
    end
    if 400 <= local1 and local1 <= 499 then
        local2 = 2.9
        local3 = 2.7
        local4 = 2.9
        local5 = 2.7
        local6 = 4
        local7 = 3.3
        local8 = 4
        local9 = 2.4
        local10 = 2.9
        local11 = 3.2
        local12 = 4
        local13 = 5
        local14 = 3.6
        local15 = 3.5
        local17 = 4
        local17 = 4
        local18 = 0
        local20 = 2
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 3
        local25 = 2
    end
    if 500 <= local1 and local1 <= 599 then
        local2 = 2.5
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.2
        local7 = 2.5
        local8 = 2.5
        local9 = 2.5
        local10 = 2.5
        local11 = 2.2
        local12 = 5
        local13 = 5.2
        local14 = 2
        local15 = 2
        local17 = 4.4
        local17 = 2.4
        local18 = 0
        local20 = 12
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 6
        local25 = 2
    end
    if 600 <= local1 and local1 <= 699 then
        local2 = 2.7
        local3 = 2.2
        local4 = 2.6
        local5 = 2.4
        local6 = 2.9
        local7 = 2.7
        local8 = 2.7
        local9 = 2.5
        local10 = 2.5
        local11 = 2.2
        local12 = 5
        local13 = 5.2
        local14 = 2
        local15 = 2
        local17 = 4.4
        local17 = 2.4
        local18 = 0
        local20 = 12
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 6
        local25 = 2
    end
    if 700 <= local1 and local1 <= 799 then
        local2 = 2.2
        local3 = 2
        local4 = 2.2
        local5 = 2
        local6 = 1.8
        local7 = 1.7
        local8 = 1.8
        local9 = 1.7
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 3.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 800 <= local1 and local1 <= 899 then
        local2 = 2.4
        local3 = 2.2
        local4 = 2.8
        local5 = 2.4
        local6 = 3.8
        local7 = 2
        local8 = 3.1
        local9 = 2.8
        local10 = 2.8
        local11 = 2.4
        local12 = 4.2
        local13 = 3.4
        local14 = 2.2
        local15 = 1.4
        local17 = 3
        local17 = 3
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 4
        local25 = 2
    end
    if 900 <= local1 and local1 <= 999 then
        local2 = 2.4
        local3 = 2.3
        local4 = 2.4
        local5 = 2.3
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 4
        local13 = 4.2
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 11
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 1000 <= local1 and local1 <= 1099 then
        local2 = 2.2
        local3 = 2
        local4 = 2.2
        local5 = 2
        local6 = 2
        local7 = 1.8
        local8 = 2.2
        local9 = 2
        local10 = 2
        local11 = 2.2
        local12 = 3.4
        local13 = 2.2
        local14 = 2.2
        local15 = 2
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 2
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 1100 <= local1 and local1 <= 1199 then
        local2 = 1.6
        local3 = 1.3
        local4 = 1.8
        local5 = 1.3
        local6 = 1.6
        local7 = 1.3
        local8 = 1.9
        local9 = 1.2
        local10 = 1.6
        local11 = 1.6
        local12 = 2.9
        local13 = 2.1
        local14 = 1
        local15 = 1
        local17 = 2.2
        local17 = 2
        local18 = 20
        local19 = 1.5
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 1200 <= local1 and local1 <= 1299 then
        local2 = 2.4
        local3 = 2.2
        local4 = 2.8
        local5 = 2.4
        local6 = 3.8
        local7 = 2
        local8 = 3.1
        local9 = 2.8
        local10 = 2.8
        local11 = 2.4
        local12 = 4.2
        local13 = 3.4
        local14 = 2.2
        local15 = 1.4
        local17 = 3
        local17 = 3
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 4
        local25 = 2
    end
    if 1300 <= local1 and local1 <= 1399 then
        local2 = 1.6
        local3 = 1.3
        local4 = 1.8
        local5 = 1.3
        local6 = 1.6
        local7 = 1.3
        local8 = 1.9
        local9 = 1.2
        local10 = 1.6
        local11 = 1.6
        local12 = 2.9
        local13 = 2.1
        local14 = 1
        local15 = 1
        local17 = 2.2
        local17 = 2
        local18 = 20
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 1400 <= local1 and local1 <= 1499 then
        local2 = 1.7
        local3 = 1.5
        local4 = 1.4
        local5 = 1.3
        local6 = 1.4
        local7 = 1.2
        local8 = 1.4
        local9 = 1.2
        local10 = 1.7
        local11 = 1.6
        local12 = 3
        local13 = 3
        local14 = 1.1
        local15 = 1.2
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 1500 <= local1 and local1 <= 1599 then
        local2 = 2.2
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 1600 <= local1 and local1 <= 1699 then
        local2 = 2.7
        local3 = 2.5
        local4 = 2.5
        local5 = 2.5
        local6 = 2.8
        local7 = 3
        local8 = 3.5
        local9 = 3.7
        local10 = 2.7
        local11 = 2.2
        local12 = 5
        local13 = 5
        local14 = 2.6
        local15 = 2.6
        local17 = 4.2
        local17 = 3
        local18 = 0
        local20 = 12
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 4
        local25 = 2
    end
    if 1700 <= local1 and local1 <= 1799 then
        local2 = 3
        local3 = 3
        local4 = 3
        local5 = 3
        local6 = 3
        local7 = 3
        local8 = 3
        local9 = 3
        local10 = 3
        local11 = 2.2
        local12 = 5.3
        local13 = 4.3
        local14 = 2.6
        local15 = 2.6
        local17 = 4.2
        local17 = 3
        local18 = 0
        local20 = 12
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 4
        local25 = 2
    end
    if 1800 <= local1 and local1 <= 1899 then
        local2 = 3.2
        local3 = 2.2
        local4 = 3.2
        local5 = 2.6
        local6 = 2.8
        local7 = 3
        local8 = 3.5
        local9 = 3.7
        local10 = 2.7
        local11 = 2.2
        local12 = 3.7
        local13 = 3.7
        local14 = 2.6
        local15 = 2.6
        local17 = 4.2
        local17 = 3
        local18 = 0
        local20 = 11
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 1900 <= local1 and local1 <= 1999 then
        local2 = 3.2
        local3 = 3
        local4 = 3.2
        local5 = 3
        local6 = 2.8
        local7 = 3
        local8 = 3.5
        local9 = 3.7
        local10 = 2.7
        local11 = 2.2
        local12 = 5
        local13 = 5
        local14 = 2.6
        local15 = 2.6
        local17 = 4.2
        local17 = 3
        local18 = 0
        local20 = 11
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 2000 <= local1 and local1 <= 2099 then
        local2 = 4.2
        local3 = 4.6
        local4 = 4.2
        local5 = 4.6
        local6 = 4.8
        local7 = 4.2
        local8 = 4.2
        local9 = 4.7
        local10 = 4.2
        local11 = 4.2
        local12 = 6
        local13 = 6
        local14 = 3.6
        local15 = 3.6
        local17 = 5.2
        local17 = 4
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 3
        local25 = 2
    end
    if 2100 <= local1 and local1 <= 2199 then
        local2 = 1.2
        local3 = 1
        local4 = 1.1
        local5 = 0.8
        local6 = 1.2
        local7 = 1
        local8 = 1.6
        local9 = 1.7
        local10 = 1
        local11 = 1.2
        local12 = 2.5
        local13 = 3
        local14 = 0.8
        local15 = 1.2
        local17 = 3.5
        local17 = 1.2
        local18 = 0
        local20 = 2
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 6
        local25 = 2
    end
    if 2200 <= local1 and local1 <= 2299 then
        local2 = 1.4
        local3 = 1.2
        local4 = 2
        local5 = 1.3
        local6 = 2
        local7 = 1.3
        local8 = 2
        local9 = 1.3
        local10 = 1.4
        local11 = 1.4
        local12 = 3.2
        local13 = 3.2
        local14 = 1.8
        local15 = 1.8
        local17 = 3.5
        local17 = 3.5
        local18 = 0
        local20 = 2
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 6
        local25 = 2
    end
    if 2300 <= local1 and local1 <= 2399 then
        local2 = 2.2
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 2
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 2400 <= local1 and local1 <= 2499 then
        local2 = 2.2
        local3 = 1.8
        local4 = 2.2
        local5 = 1.8
        local6 = 2.2
        local7 = 2
        local8 = 2.2
        local9 = 2
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 11
        local21 = 11
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 3000 <= local1 and local1 <= 3099 then
        local2 = 1
        local3 = 1
        local4 = 1
        local5 = 1
        local6 = 1
        local7 = 1
        local8 = 1
        local9 = 1
        local10 = 1
        local11 = 1
        local12 = 1
        local13 = 1
        local14 = 1
        local15 = 1
        local17 = 1
        local17 = 1
        local18 = 0
        local20 = 11
        local21 = 10
        local22 = 1
        local23 = 1
        local24 = 1
        local25 = 1
    end
    if 3100 <= local1 and local1 <= 3199 then
        local2 = 1
        local3 = 1
        local4 = 1
        local5 = 1
        local6 = 1
        local7 = 1
        local8 = 1
        local9 = 1
        local10 = 1
        local11 = 1
        local12 = 1
        local13 = 1
        local14 = 1
        local15 = 1
        local17 = 1
        local17 = 1
        local18 = 0
        local20 = 11
        local21 = 10
        local22 = 1
        local23 = 1
        local24 = 1
        local25 = 1
    end
    if 3200 <= local1 and local1 <= 3299 then
        local2 = 1
        local3 = 1
        local4 = 1
        local5 = 1
        local6 = 1
        local7 = 1
        local8 = 1
        local9 = 1
        local10 = 1
        local11 = 1
        local12 = 1
        local13 = 1
        local14 = 1
        local15 = 1
        local17 = 1
        local17 = 1
        local18 = 0
        local20 = 11
        local21 = 10
        local22 = 1
        local23 = 1
        local24 = 1
        local25 = 1
    end
    if 3300 <= local1 and local1 <= 3399 then
        local2 = 2.2
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 1
        local20 = 30
        local21 = 30
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 3400 <= local1 and local1 <= 3499 then
        local2 = 2.2
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 1
        local20 = 30
        local21 = 30
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 3500 <= local1 and local1 <= 3599 then
        local2 = 2.2
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 1
        local20 = 30
        local21 = 30
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 3600 <= local1 and local1 <= 3699 then
        local2 = 2.2
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 1
        local20 = 30
        local21 = 30
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 4000 <= local1 and local1 <= 4099 then
        local2 = 20
        local3 = 20
        local4 = 20
        local5 = 20
        local6 = 20
        local7 = 20
        local8 = 20
        local9 = 20
        local10 = 20
        local11 = 20
        local12 = 20
        local13 = 20
        local14 = 20
        local15 = 20
        local17 = 20
        local17 = 20
        local18 = 0
        local20 = 20
        local21 = 20
        local22 = 0
        local23 = 0
        local24 = 3
        local25 = 2
    end
    if 4100 <= local1 and local1 <= 4199 then
        local2 = 20
        local3 = 20
        local4 = 20
        local5 = 20
        local6 = 20
        local7 = 20
        local8 = 20
        local9 = 20
        local10 = 20
        local11 = 20
        local12 = 20
        local13 = 20
        local14 = 20
        local15 = 20
        local17 = 20
        local17 = 20
        local18 = 0
        local20 = 20
        local21 = 20
        local22 = 0
        local23 = 0
        local24 = 3
        local25 = 2
    end
    if 4200 <= local1 and local1 <= 4299 then
        local2 = 20
        local3 = 20
        local4 = 20
        local5 = 20
        local6 = 20
        local7 = 20
        local8 = 20
        local9 = 20
        local10 = 20
        local11 = 20
        local12 = 20
        local13 = 20
        local14 = 20
        local15 = 20
        local17 = 20
        local17 = 20
        local18 = 0
        local20 = 20
        local21 = 20
        local22 = 0
        local23 = 0
        local24 = 3
        local25 = 2
    end
    if 4300 <= local1 and local1 <= 4399 then
        local2 = 2.2
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 20
        local21 = 20
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 4400 <= local1 and local1 <= 4499 then
        local2 = 2.2
        local3 = 2
        local4 = 2.4
        local5 = 2.2
        local6 = 2.8
        local7 = 2.5
        local8 = 2.8
        local9 = 2.5
        local10 = 2.2
        local11 = 2.2
        local12 = 3
        local13 = 2.4
        local14 = 1.2
        local15 = 1.4
        local17 = 3
        local17 = 2.4
        local18 = 0
        local20 = 20
        local21 = 20
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 6050 <= local1 and local1 <= 6099 then
        local2 = 1.2
        local3 = 1
        local4 = 1.1
        local5 = 0.8
        local6 = 1.2
        local7 = 1
        local8 = 1.6
        local9 = 1.7
        local10 = 1
        local11 = 1.2
        local12 = 2.5
        local13 = 3
        local14 = 0.8
        local15 = 1.2
        local17 = 3.5
        local17 = 1.2
        local18 = 0
        local20 = 2
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 6
        local25 = 2
    end
    if 2090000 <= local0 and local0 <= 2099999 then
        local2 = 1.8
        local3 = 1.6
        local4 = 2.3
        local5 = 2.1
        local6 = 3.5
        local7 = 2
        local8 = 2.3
        local9 = 2.8
        local10 = 2.8
        local11 = 2.4
        local12 = 4.2
        local13 = 3.4
        local14 = 2.2
        local15 = 2.6
        local17 = 3
        local17 = 3
        local18 = 20
        local19 = 4
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 4
        local25 = 2
    end
    if 9010000 <= local0 and local0 <= 9019999 then
        local2 = 3.2
        local3 = 3.1
        local4 = 3.2
        local5 = 3.1
        local6 = 3.8
        local7 = 3.5
        local8 = 3.2
        local9 = 3.3
        local10 = 3.1
        local11 = 3
        local12 = 4.8
        local13 = 5
        local14 = 2.2
        local15 = 2.4
        local17 = 3.8
        local17 = 3.2
        local18 = 0
        local20 = 2
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 5
        local25 = 2
    end
    if 15120000 <= local0 and local0 <= 15129999 then
        local8 = 1
        local9 = 1
    end
    if local0 == 3530 then
        local8 = 1
        local9 = 1
    end
    if 12180000 <= local0 and local0 <= 12189999 then
        local2 = 2.2
        local3 = 2
        local4 = 2.6
        local5 = 2.2
        local6 = 3.4
        local7 = 1.7
        local8 = 2.8
        local9 = 2.6
        local10 = 2.6
        local11 = 2.2
        local12 = 4
        local13 = 3.2
        local14 = 2
        local15 = 1.2
        local17 = 3
        local17 = 3
        local18 = 0
        local20 = 1
        local21 = 1
        local22 = 0
        local23 = 0
        local24 = 4
        local25 = 2
    end
    if arg3 == ARM_R then
        arg1:SetStringIndexedNumber("R_Dist_OneHandR1_First", local2)
        arg1:SetStringIndexedNumber("R_Dist_OneHandR1_Second", local3)
        arg1:SetStringIndexedNumber("R_Dist_TwoHandR1_First", local4)
        arg1:SetStringIndexedNumber("R_Dist_TwoHandR1_Second", local5)
        arg1:SetStringIndexedNumber("R_Dist_OneHandR2_First", local6)
        arg1:SetStringIndexedNumber("R_Dist_OneHandR2_Second", local7)
        arg1:SetStringIndexedNumber("R_Dist_TwoHandR2_First", local8)
        arg1:SetStringIndexedNumber("R_Dist_TwoHandR2_Second", local9)
        arg1:SetStringIndexedNumber("R_Dist_TwoHandL1", local9)
        arg1:SetStringIndexedNumber("R_Dist_OneHandL2", local11)
        arg1:SetStringIndexedNumber("R_Dist_DashR1", local12)
        arg1:SetStringIndexedNumber("R_Dist_DashR2", local13)
        arg1:SetStringIndexedNumber("R_Dist_RollingR1", local14)
        arg1:SetStringIndexedNumber("R_Dist_RollingR2", local15)
        arg1:SetStringIndexedNumber("R_Dist_BackStepR1", local17)
        arg1:SetStringIndexedNumber("R_Dist_BackStepR2", Dist_BackStepR2)
        arg1:SetStringIndexedNumber("R_ArtsType", local18)
        arg1:SetStringIndexedNumber("R_ArtsDist", local19)
        arg1:SetStringIndexedNumber("R_WeaponType", local20)
        arg1:SetStringIndexedNumber("R_TwoHandL1Type", local22)
        arg1:SetStringIndexedNumber("R_Left_ActionType", local23)
        arg1:SetStringIndexedNumber("R_ComboNum_R1", local24)
        arg1:SetStringIndexedNumber("R_ComboNum_R2", local25)
    else
        arg1:SetStringIndexedNumber("L_Dist_OneHandR1_First", local2)
        arg1:SetStringIndexedNumber("L_Dist_OneHandR1_Second", local3)
        arg1:SetStringIndexedNumber("L_Dist_TwoHandR1_First", local4)
        arg1:SetStringIndexedNumber("L_Dist_TwoHandR1_Second", local5)
        arg1:SetStringIndexedNumber("L_Dist_OneHandR2_First", local6)
        arg1:SetStringIndexedNumber("L_Dist_OneHandR2_Second", local7)
        arg1:SetStringIndexedNumber("L_Dist_TwoHandR2_First", local8)
        arg1:SetStringIndexedNumber("L_Dist_TwoHandR2_Second", local9)
        arg1:SetStringIndexedNumber("L_Dist_TwoHandL1", local9)
        arg1:SetStringIndexedNumber("L_Dist_OneHandL2", local11)
        arg1:SetStringIndexedNumber("L_Dist_DashR1", local12)
        arg1:SetStringIndexedNumber("L_Dist_DashR2", local13)
        arg1:SetStringIndexedNumber("L_Dist_RollingR1", local14)
        arg1:SetStringIndexedNumber("L_Dist_RollingR2", local15)
        arg1:SetStringIndexedNumber("L_Dist_BackStepR1", local17)
        arg1:SetStringIndexedNumber("L_Dist_BackStepR2", Dist_BackStepR2)
        arg1:SetStringIndexedNumber("L_ArtsType", local18)
        arg1:SetStringIndexedNumber("L_ArtsDist", local19)
        arg1:SetStringIndexedNumber("L_WeaponType", local21)
        arg1:SetStringIndexedNumber("L_TwoHandL1Type", local22)
        arg1:SetStringIndexedNumber("L_Left_ActionType", local23)
        arg1:SetStringIndexedNumber("L_ComboNum_R1", local24)
        arg1:SetStringIndexedNumber("L_ComboNum_R2", local25)
    end
    return 
end

return 
