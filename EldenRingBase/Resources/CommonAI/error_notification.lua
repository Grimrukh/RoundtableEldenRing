REGISTER_DBG_GOAL_PARAM(GOAL_COMMON_ErrorNotification, 0, "エラーコード", 0)
REGISTER_GOAL_NO_INTERUPT(GOAL_COMMON_ErrorNotification, true)
function ErrorNotification_Activate(arg0, arg1)
    if arg1:GetParam(0) == 0 then
        print("★エラーゴール通知：戦闘行動として定義されていないActが選択されました。定義していない行動に確率が設定されていないか確認してください")
    else
        print("★エラーゴール通知：例外エラーが呼ばれました")
    end
    return 
end

function ErrorNotification_Update(arg0, arg1)
    return GOAL_RESULT_Continue
end

function ErrorNotification_Terminate(arg0, arg1)
    return 
end

function ErrorNotification_Interupt(arg0, arg1)
    return false
end

return 
