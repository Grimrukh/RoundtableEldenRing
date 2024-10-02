namespace EldenRingBase.Params;

/// <summary>
/// Used by all eight 'itemLotCategoryXX' fields in both enemy/map `ItemLotParam` Params.
///
/// Different to other item enums!
/// </summary>
public enum ItemLotItemCategory
{
    None = 0,
    Good = 1,
    Weapon = 2,
    Armor = 3,
    Talisman = 4,
    AshOfWar = 5,
    CustomWeapon = 6,  // 'EquipParamCustomWeapon' ID (=> base Weapon ID, Ash of War ID, reinforcement level)
}
