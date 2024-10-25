using PropertyHook;
using SoulsFormats;
using EldenRingBase.GameHook;

namespace EldenRingBase.Params;

/// <summary>
/// Accesses PARAM addresses properly, rather than searching for the whole damn thing.
///
/// Does not read/write actual regulation file. Memory manager only.
/// </summary>
public class ParamManager : GameMonitor
{
    EldenRingHook Hook { get; }
    Dictionary<string, PARAMDEF> ParamdefsByType { get; }
    
    public HashSet<ParamType> RequestedParamWrites { get; } = [];

    Dictionary<ParamType, ParamInMemory> ParamsInMemory { get; } = new();
    
    static readonly Dictionary<ParamType, int> ParamOffsets = new()
    {
        { ParamType.EquipParamWeapon, 0x88 },
        { ParamType.EquipParamArmor, 0xD0 },
        { ParamType.EquipParamAccessory, 0x118 },
        { ParamType.EquipParamGoods, 0x160 },
        { ParamType.EquipParamGem, 0x2BD8 },
        { ParamType.EquipParamCustomWeapon, 0x2C20 },
        { ParamType.NpcParam, 0x238 },
        { ParamType.NpcThinkParam, 0x310 },
        { ParamType.SpEffectParam, 0x4C0 },
        { ParamType.GameAreaParam, 0x8B0 },
        { ParamType.ItemLotParam_enemy, 0x628 },
        { ParamType.ItemLotParam_map, 0x670 },
        { ParamType.CharaInitParam, 0x700 },
        { ParamType.ActionButtonParam, 0xAA8 },

        #region Mapped Param Type Addresses
        // ["REINFORCE_PARAM_WEAPON_ST"] = [0x1A8, 0x80, 0x80],  // fifth row ID = 4
        // ["REINFORCE_PARAM_PROTECTOR_ST"] = [0x1F0, 0x80, 0x80],  // fifth row ID = 4
        // ["ATK_PARAM_ST"] = [0x280, 0x80, 0x80],  // fifth row ID = 5
        // ["ATK_PARAM_ST"] = [0x2C8, 0x80, 0x80],  // fifth row ID = 5
        // ["BULLET_PARAM_ST"] = [0x358, 0x80, 0x80],  // fifth row ID = 4
        // ["BULLET_CREATE_LIMIT_PARAM_ST"] = [0x3A0, 0x80, 0x80],  // fifth row ID = 4
        // ["BEHAVIOR_PARAM_ST"] = [0x3E8, 0x80, 0x80],  // fifth row ID = 13
        // ["BEHAVIOR_PARAM_ST"] = [0x430, 0x80, 0x80],  // fifth row ID = 100
        // ["MAGIC_PARAM_ST"] = [0x478, 0x80, 0x80],  // fifth row ID = 4021
        // ["SP_EFFECT_VFX_PARAM_ST"] = [0x508, 0x80, 0x80],  // fifth row ID = 4
        // ["SP_EFFECT_SET_PARAM_ST"] = [0x550, 0x80, 0x80],  // fifth row ID = 102010
        // ["TALK_PARAM_ST"] = [0x598, 0x80, 0x80],  // fifth row ID = 1400020
        // ["MENU_PARAM_COLOR_TABLE_ST"] = [0x5E0, 0x80, 0x80],  // fifth row ID = 1004
        // ["MOVE_PARAM_ST"] = [0x6B8, 0x80, 0x80],  // fifth row ID = 10
        // ["EQUIP_MTRL_SET_PARAM_ST"] = [0x748, 0x80, 0x80],  // fifth row ID = 4
        // ["FACE_PARAM_ST"] = [0x790, 0x80, 0x80],  // fifth row ID = 4
        // ["FACE_RANGE_PARAM_ST"] = [0x7D8, 0x80, 0x80],  // fifth row ID = 0
        // ["SHOP_LINEUP_PARAM"] = [0x820, 0x80, 0x80],  // fifth row ID = 1003
        // ["SHOP_LINEUP_PARAM"] = [0x868, 0x80, 0x80],  // fifth row ID = 30102
        // ["CACL_CORRECT_GRAPH_ST"] = [0x8F8, 0x80, 0x80],  // fifth row ID = 4
        // ["LOCK_CAM_PARAM_ST"] = [0x940, 0x80, 0x80],  // fifth row ID = 1010
        // ["OBJ_ACT_PARAM_ST"] = [0x988, 0x80, 0x80],  // fifth row ID = 351
        // ["HIT_MTRL_PARAM_ST"] = [0x9D0, 0x80, 0x80],  // fifth row ID = 4
        // ["KNOCKBACK_PARAM_ST"] = [0xA18, 0x80, 0x80],  // fifth row ID = 21
        // ["DECAL_PARAM_ST"] = [0xA60, 0x80, 0x80],  // fifth row ID = 40
        // ["AI_SOUND_PARAM_ST"] = [0xAF0, 0x80, 0x80],  // fifth row ID = 1030
        // ["PLAY_REGION_PARAM_ST"] = [0xB38, 0x80, 0x80],  // fifth row ID = 981004
        // ["NETWORK_AREA_PARAM_ST"] = [0xB80, 0x80, 0x80],  // fifth row ID = 310000
        // ["NETWORK_PARAM_ST"] = [0xBC8, 0x80, 0x80],  // fifth row ID = 1067030938
        // ["NETWORK_MSG_PARAM_ST"] = [0xC10, 0x80, 0x80],  // fifth row ID = 103
        // ["BUDGET_PARAM_ST"] = [0xC58, 0x80, 0x80],  // fifth row ID = 4
        // ["BONFIRE_WARP_PARAM_ST"] = [0xCA0, 0x80, 0x80],  // fifth row ID = 100003
        // ["BONFIRE_WARP_TAB_PARAM_ST"] = [0xCE8, 0x80, 0x80],  // fifth row ID = 14000
        // ["BONFIRE_WARP_SUB_CATEGORY_PARAM_ST"] = [0xD30, 0x80, 0x80],  // fifth row ID = 11050
        // ["MENUPROPERTY_SPEC"] = [0xD78, 0x80, 0x80],  // fifth row ID = 103
        // ["MENUPROPERTY_LAYOUT"] = [0xDC0, 0x80, 0x80],  // fifth row ID = 1003
        // ["MENU_VALUE_TABLE_SPEC"] = [0xE08, 0x80, 0x80],  // fifth row ID = 90
        // ["CEREMONY_PARAM_ST"] = [0xE50, 0x80, 0x80],  // fifth row ID = 1042390020
        // ["PHANTOM_PARAM_ST"] = [0xE98, 0x80, 0x80],  // fifth row ID = 29
        // ["CHARMAKEMENUTOP_PARAM_ST"] = [0xEE0, 0x80, 0x80],  // fifth row ID = 5
        // ["CHARMAKEMENU_LISTITEM_PARAM_ST"] = [0xF28, 0x80, 0x80],  // fifth row ID = 101
        // ["HIT_EFFECT_SFX_CONCEPT_PARAM_ST"] = [0xF70, 0x80, 0x80],  // fifth row ID = 5
        // ["HIT_EFFECT_SFX_PARAM_ST"] = [0xFB8, 0x80, 0x80],  // fifth row ID = 40
        // ["WEP_ABSORP_POS_PARAM_ST"] = [0x1000, 0x80, 0x80],  // fifth row ID = 4
        // ["TOUGHNESS_PARAM_ST"] = [0x1048, 0x80, 0x80],  // fifth row ID = 5
        // ["SE_MATERIAL_CONVERT_PARAM_ST"] = [0x1090, 0x80, 0x80],  // fifth row ID = 5
        // ["THROW_DIRECTION_SFX_PARAM_ST"] = [0x10D8, 0x80, 0x80],  // fifth row ID = 103
        // ["DIRECTION_CAMERA_PARAM_ST"] = [0x1120, 0x80, 0x80],  // fifth row ID = 90
        // ["ROLE_PARAM_ST"] = [0x1168, 0x80, 0x80],  // fifth row ID = 4
        // ["WAYPOINT_PARAM_ST"] = [0x11B0, 0x80, 0x80],  // fifth row ID = 400
        // ["GRASS_TYPE_PARAM_ST"] = [0x1240, 0x80, 0x80],  // fifth row ID = 5
        // ["GRASS_TYPE_PARAM_ST"] = [0x1288, 0x80, 0x80],  // fifth row ID = 44
        // ["GRASS_TYPE_PARAM_ST"] = [0x12D0, 0x80, 0x80],  // fifth row ID = 44
        // ["GRASS_LOD_RANGE_PARAM_ST"] = [0x1318, 0x80, 0x80],  // fifth row ID = 4
        // ["NPC_AI_ACTION_PARAM_ST"] = [0x1360, 0x80, 0x80],  // fifth row ID = 4
        // ["PARTS_DRAW_PARAM_ST"] = [0x13A8, 0x80, 0x80],  // fifth row ID = 4
        // ["MATERIAL_EX_PARAM_ST"] = [0x1558, 0x80, 0x80],  // fifth row ID = 1003
        // ["ESTUS_FLASK_RECOVERY_PARAM_ST"] = [0x15A0, 0x80, 0x80],  // fifth row ID = 1001
        // ["ESTUS_FLASK_RECOVERY_PARAM_ST"] = [0x15E8, 0x80, 0x80],  // fifth row ID = 1001
        // ["MULTI_PLAY_CORRECTION_PARAM_ST"] = [0x1630, 0x80, 0x80],  // fifth row ID = 400
        // ["MENU_OFFSCR_REND_PARAM_ST"] = [0x1678, 0x80, 0x80],  // fifth row ID = 10
        // ["CLEAR_COUNT_CORRECT_PARAM_ST"] = [0x16C0, 0x80, 0x80],  // fifth row ID = 4
        // ["MAP_MIMICRY_ESTABLISHMENT_PARAM_ST"] = [0x1708, 0x80, 0x80],  // fifth row ID = 6202000
        // ["WET_ASPECT_PARAM_ST"] = [0x1750, 0x80, 0x80],  // fifth row ID = 4
        // ["SWORD_ARTS_PARAM_ST"] = [0x1798, 0x80, 0x80],  // fifth row ID = 101
        // ["MULTI_ESTUS_FLASK_BONUS_PARAM_ST"] = [0x1828, 0x80, 0x80],  // fifth row ID = 4000
        // ["MULTI_ESTUS_FLASK_BONUS_PARAM_ST"] = [0x1870, 0x80, 0x80],  // fifth row ID = 4000
        // ["MULTI_SOUL_BONUS_RATE_PARAM_ST"] = [0x18B8, 0x80, 0x80],  // fifth row ID = 4000
        // ["WORLD_MAP_POINT_PARAM_ST"] = [0x1900, 0x80, 0x80],  // fifth row ID = 78504
        // ["WORLD_MAP_PIECE_PARAM_ST"] = [0x1948, 0x80, 0x80],  // fifth row ID = 4
        // ["WORLD_MAP_LEGACY_CONV_PARAM_ST"] = [0x1990, 0x80, 0x80],  // fifth row ID = 14
        // ["WORLD_MAP_PLACE_NAME_PARAM_ST"] = [0x19D8, 0x80, 0x80],  // fifth row ID = 8000900
        // ["CHR_MODEL_PARAM_ST"] = [0x1A20, 0x80, 0x80],  // fifth row ID = 2010
        // ["WEATHER_PARAM_ST"] = [0x2200, 0x80, 0x80],  // fifth row ID = 20
        // ["WEATHER_LOT_PARAM_ST"] = [0x2248, 0x80, 0x80],  // fifth row ID = 2020
        // ["WEATHER_ASSET_CREATE_PARAM_ST"] = [0x2290, 0x80, 0x80],  // fifth row ID = 96200
        // ["WEATHER_ASSET_REPLACE_PARAM_ST"] = [0x22D8, 0x80, 0x80],  // fifth row ID = 60001200
        // ["RIDE_PARAM_ST"] = [0x2368, 0x80, 0x80],  // fifth row ID = 300081101
        // ["BUDDY_PARAM_ST"] = [0x2488, 0x80, 0x80],  // fifth row ID = 20300000
        // ["GPARAM_REF_SETTINGS_PARAM_ST"] = [0x24D0, 0x80, 0x80],  // fifth row ID = 30040000
        // ["RANDOM_APPEAR_PARAM_ST"] = [0x2518, 0x80, 0x80],  // fifth row ID = 201
        // ["MAP_DEFAULT_INFO_PARAM_ST"] = [0x25F0, 0x80, 0x80],  // fifth row ID = 11050000
        // ["BUDDY_STONE_PARAM_ST"] = [0x2638, 0x80, 0x80],  // fifth row ID = 10000106
        // ["LEGACY_DISTANT_VIEW_PARTS_REPLACE_PARAM"] = [0x2680, 0x80, 0x80],  // fifth row ID = 100054
        // ["SOUND_COMMON_INGAME_PARAM_ST"] = [0x26C8, 0x80, 0x80],  // fifth row ID = 200
        // ["SOUND_AUTO_ENV_SOUND_GROUP_PARAM_ST"] = [0x2710, 0x80, 0x80],  // fifth row ID = 2001
        // ["SOUND_AUTO_REVERB_EVALUATION_DIST_PARAM_ST"] = [0x2758, 0x80, 0x80],  // fifth row ID = 4
        // ["SOUND_AUTO_REVERB_SELECT_PARAM_ST"] = [0x27A0, 0x80, 0x80],  // fifth row ID = 302
        // ["PLAYER_COMMON_PARAM_ST"] = [0x2908, 0x80, 0x80],  // fifth row ID = 0
        // ["CUTSCENE_GPARAM_WEATHER_PARAM_ST"] = [0x2950, 0x80, 0x80],  // fifth row ID = 10000040
        // ["CUTSCENE_GPARAM_TIME_PARAM_ST"] = [0x2998, 0x80, 0x80],  // fifth row ID = 10000040
        // ["CUTSCENE_TIMEZONE_CONVERT_PARAM_ST"] = [0x29E0, 0x80, 0x80],  // fifth row ID = 4
        // ["CUTSCENE_WEATHER_OVERRIDE_GPARAM_ID_CONVERT_PARAM_ST"] = [0x2A28, 0x80, 0x80],  // fifth row ID = 20
        // ["SOUND_CUTSCENE_PARAM_ST"] = [0x2A70, 0x80, 0x80],  // fifth row ID = 10000040
        // ["CHR_ACTIVATE_CONDITION_PARAM_ST"] = [0x2AB8, 0x80, 0x80],  // fifth row ID = 101010
        // ["CUTSCENE_MAP_ID_PARAM_ST"] = [0x2B00, 0x80, 0x80],  // fifth row ID = 10000040
        // ["CUTSCENE_TEXTURE_LOAD_PARAM_ST"] = [0x2B48, 0x80, 0x80],  // fifth row ID = 91000000
        // ["GESTURE_PARAM_ST"] = [0x2B90, 0x80, 0x80],  // fifth row ID = 4
        // ["MAP_PIECE_TEX_PARAM_ST"] = [0x2DD0, 0x80, 0x80],  // fifth row ID = 14
        // ["MAP_NAME_TEX_PARAM_ST"] = [0x2E18, 0x80, 0x80],  // fifth row ID = 15
        // ["WEATHER_LOT_TEX_PARAM_ST"] = [0x2E60, 0x80, 0x80],  // fifth row ID = 15
        // ["RESIST_CORRECT_PARAM_ST"] = [0x3178, 0x80, 0x80],  // fifth row ID = 1002
        // ["TUTORIAL_PARAM_ST"] = [0x3328, 0x80, 0x80],  // fifth row ID = 1010
        #endregion
    };

    static readonly Dictionary<ParamType, string> ParamdefNames = new()
    {
        { ParamType.EquipParamWeapon, "EQUIP_PARAM_WEAPON_ST" },
        { ParamType.EquipParamArmor, "EQUIP_PARAM_PROTECTOR_ST" },
        { ParamType.EquipParamAccessory, "EQUIP_PARAM_ACCESSORY_ST" },
        { ParamType.EquipParamGoods, "EQUIP_PARAM_GOODS_ST" },
        { ParamType.EquipParamGem, "EQUIP_PARAM_GEM_ST" },
        { ParamType.EquipParamCustomWeapon, "EQUIP_PARAM_CUSTOM_WEAPON_ST" },
        { ParamType.NpcParam, "NPC_PARAM_ST" },
        { ParamType.NpcThinkParam, "NPC_THINK_PARAM_ST" },
        { ParamType.SpEffectParam, "SP_EFFECT_PARAM_ST" },
        { ParamType.GameAreaParam, "GAME_AREA_PARAM_ST" },
        { ParamType.ItemLotParam_enemy, "ITEMLOT_PARAM_ST" },
        { ParamType.ItemLotParam_map, "ITEMLOT_PARAM_ST" },
        { ParamType.CharaInitParam, "CHARACTER_INIT_PARAM" },
        { ParamType.ActionButtonParam, "ACTIONBUTTON_PARAM_ST" },
    };
    
    public ParamManager(EldenRingHook hook, List<PARAMDEF> paramdefs)
    {
        Hook = hook;
        Hook.OnUnhooked += OnUnhooked;
        ParamdefsByType = paramdefs.ToDictionary(p => p.ParamType, p => p);
    }
    
    void OnUnhooked(object? sender, PHEventArgs e)
    {
        ParamsInMemory.Clear();
    }

    /// <summary>
    /// Retrieve found `ParamInMemory` or try to load it now (first time).
    /// 
    /// Caller may want to wrap the output of this in a `Params.Wrappers` class for easier editing.
    /// </summary>
    /// <param name="paramType"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ParamInMemory? GetParam(ParamType paramType)
    {
        if (ParamsInMemory.TryGetValue(paramType, out ParamInMemory? param))
            return param;  // already loaded (cleared when unhooked)

        if (!ParamdefNames.TryGetValue(paramType, out string? paramdefType))
        {
            Logging.Error($"Param type {Enum.GetName(paramType)} not yet supported.");
            return null;
        }
        if (!ParamOffsets.TryGetValue(paramType, out int firstParamOffset))
        {
            Logging.Error($"Param type {Enum.GetName(paramType)} cannot yet be loaded from memory");
            return null;
        }
        PHPointer paramPointer = Hook.SoloParamRepository.CreateChildPointer(firstParamOffset, 0x80, 0x80);
        if (!paramPointer.IsNonZero)
        {
            Logging.Warning($"Params not yet available in memory. May succeed next call...");
            return null;
        }

        ParamsInMemory[paramType] = new ParamInMemory(paramPointer, ParamdefsByType[paramdefType]);
        Logging.Info($"Loaded PARAM {Enum.GetName(paramType)} in memory ({ParamsInMemory[paramType].Rows.Count} rows).");
        
        return ParamsInMemory[paramType];
    }
    
    /// <summary>
    /// Dequeue and execute requested writes of PARAMs.
    ///
    /// These requests shouldn't come much, because we favor `ParamInMemory.FastSet()` now.
    /// </summary>
    /// <returns></returns>
    protected override bool OnUpdate(long updateTime, long gameLoadedTime)
    {
        bool success = true;
        foreach (ParamType paramType in RequestedParamWrites)
        {
            ParamInMemory? param = GetParam(paramType);
            success &= param is { Ready: true } && param.WriteEntireParamToMemory();
            if (!success)
                Console.WriteLine($"ERROR: Could not save Param {paramType} in game memory.");
        }

        RequestedParamWrites.Clear();
        return success;
    }
}