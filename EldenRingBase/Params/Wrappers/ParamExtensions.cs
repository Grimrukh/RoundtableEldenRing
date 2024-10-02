namespace EldenRingBase.Params.Wrappers;

public struct ItemLotSlotInfo(
    int id, ItemLotItemCategory category, ushort basePoint = 0, ushort cumulatePoint = 0, uint flagID = 0,
    byte quantity = 1, bool luckEnabled = true, bool cumulateReset = false)
{
    public int ID = id;
    public ItemLotItemCategory Category = category;
    public ushort BasePoint = basePoint;
    public ushort CumulatePoint = cumulatePoint;
    public uint FlagID = flagID;
    public byte Quantity = quantity;
    public bool LuckEnabled = luckEnabled;
    public bool CumulateReset = cumulateReset;

    public static ItemLotSlotInfo Empty(ushort basePoint = 0)
    {
        return new ItemLotSlotInfo(0, ItemLotItemCategory.None, basePoint, quantity: 0, luckEnabled: false);
    }
}

public static class ParamExtensions
{
    public static ItemLotSlotInfo GetItemLotSlot(this ITEMLOT_PARAM_ST.Row itemLot, int slot)
    {
        if (slot is < 1 or > 8)
            throw new ArgumentException("Item lot slot must be between 1 and 8, inclusive.");
        return new ItemLotSlotInfo
        {
            ID = (int)itemLot[$"lotItemId0{slot}"],
            Category = (ItemLotItemCategory)(int)itemLot[$"lotItemCategory0{slot}"],
            BasePoint = (ushort)itemLot[$"lotItemBasePoint0{slot}"],
            CumulatePoint = (ushort)itemLot[$"cumulateLotPoint0{slot}"],
            FlagID = (uint)itemLot[$"getItemFlagId0{slot}"],
            Quantity = (byte)itemLot[$"lotItemNum0{slot}"],
            LuckEnabled = (ushort)itemLot[$"enableLuck0{slot}"] == 1,
            CumulateReset = (ushort)itemLot[$"cumulateReset0{slot}"] == 1,
        };
    }

    public static void SetItemLotSlot(this ITEMLOT_PARAM_ST.Row itemLot, int slot, ItemLotSlotInfo item)
    {
        if (slot is < 1 or > 8)
            throw new ArgumentException("Item lot slot must be between 1 and 8, inclusive.");
        itemLot[$"lotItemId0{slot}"] = item.ID;
        itemLot[$"lotItemCategory0{slot}"] = (int)item.Category;
        itemLot[$"lotItemBasePoint0{slot}"] = item.BasePoint;
        itemLot[$"cumulateLotPoint0{slot}"] = item.CumulatePoint;
        itemLot[$"getItemFlagId0{slot}"] = item.FlagID;
        itemLot[$"lotItemNum0{slot}"] = item.Quantity;
        itemLot[$"enableLuck0{slot}"] = item.LuckEnabled ? 1 : 0;
        itemLot[$"cumulateReset0{slot}"] = item.CumulateReset ? 1 : 0;
    }

    /// <summary>
    /// Set an item lot to drop a single item, optionally with some chance (converted to an integer out of 1000).
    /// </summary>
    /// <param name="itemLot"></param>
    /// <param name="id"></param>
    /// <param name="category"></param>
    /// <param name="quantity"></param>
    /// <param name="chance"></param>
    public static void SetSimpleItemLot(this ITEMLOT_PARAM_ST.Row itemLot, int id, ItemLotItemCategory category, byte quantity = 1, float? chance = null)
    {
        switch (chance)
        {
            case null:
            {
                itemLot.SetItemLotSlot(1, new ItemLotSlotInfo(id, category, quantity: quantity));
                for (int i = 2; i <= 8; i++)
                    itemLot.SetItemLotSlot(i, ItemLotSlotInfo.Empty());
                return;
            }
            case < 0f or > 1f:
                throw new ArgumentException("Chance must be between 0 and 1, inclusive, if not null (guaranteed).");
            default:
                ushort chanceInt = (ushort)(chance * 1000);
                ushort failInt = (ushort)(1000 - chanceInt);

                itemLot.SetItemLotSlot(1, ItemLotSlotInfo.Empty(failInt));
                itemLot.SetItemLotSlot(2, new ItemLotSlotInfo(id, category, basePoint: chanceInt, quantity: quantity));
                for (int i = 3; i <= 8; i++)
                    itemLot.SetItemLotSlot(i, ItemLotSlotInfo.Empty());
                return;
        }
    }

    public static int GetScalingLevel(this NPC_PARAM_ST.Row npc)
    {
        return npc.spEffectID3 > 0 ? (npc.spEffectID3 - 7000) / 10 : -1;
    }
}