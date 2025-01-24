namespace RoundtableEldenRing.Memory;

/// <summary>
/// Category enum used by inventory items in memory.
/// 
/// Note that this differs from the enum used by Item Lots and EMEVD.
/// </summary>
public enum InventoryItemCategory
{
    WEAPON = 0b00000000,
    ARMOR = 0b00000001,
    TALISMAN = 0b00000010,
    GOOD = 0b00000100,  // includes spells
    ASH_OF_WAR = 0b00001000,  // aka 'Gem' (original Bloodborne name)
}
