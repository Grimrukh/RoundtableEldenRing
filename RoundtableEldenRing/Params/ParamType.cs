namespace RoundtableEldenRing.Params;

/// <summary>
/// NOTE: These params are automatically scanned for and found in game memory.
/// </summary>
public enum ParamType
{
    ActionButtonParam,
    ItemLotParam_enemy,
    ItemLotParam_map,
    NpcParam,
    NpcThinkParam,
    CharaInitParam,
    SpEffectParam,  // TODO: no 'Param' suffix in Defs, but pretty sure 'SpEffectParam.param' is the name?
    GameAreaParam,  // needed to scale boss rune drops
    // CalcCorrectGraph,  // not needed at the moment
    EquipParamWeapon,
    EquipParamArmor,
    EquipParamAccessory,
    EquipParamGoods,
    EquipParamGem,
    EquipParamCustomWeapon,
}
