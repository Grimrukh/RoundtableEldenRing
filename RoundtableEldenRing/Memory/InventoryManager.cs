using System.Runtime.InteropServices;
using PropertyHook;
using RoundtableBase;
using RoundtableEldenRing.Text;

namespace RoundtableEldenRing.Memory;

public class InventoryManager
{
    EldenRingHook Hook { get; }

    static readonly byte[] InventoryAccessorOriginal = [0x8B, 0xC3, 0x2B, 0xC1, 0x48, 0x8D, 0x0C, 0x80];
    // This is the 8 bytes AFTER our injection point, in case the injection is already there.
    const string InventoryAccessorAOB = "48 8B 47 38 48 8D 0C 88 E8";
    PHPointer InventoryAccessor { get; }

    const string AwardItemFuncAOB =
        "40 55 56 57 41 54 41 55 41 56 41 57 48 8D AC 24 ? ? ? ? 48 81 EC ? ? ? ? 48 C7 45 C8 ? ? ? " +
        "? 48 89 9C 24 ? ? ? ? 48 8B 05 ? ? ? ? 48 33 C4 48 89 85 ? ? ? ? 44 89 4C 24 ? 4D 8B F8";
    PHPointer AwardItemFunc { get; }

    IntPtr? InventoryInfoAddr { get; set; } 
    IntPtr? InventoryHookAddr { get; set; }
    
    public InventoryManager(EldenRingHook hook)
    {
        Hook = hook;

        InventoryAccessor = Hook.RegisterAbsoluteAOB(InventoryAccessorAOB);
        AwardItemFunc = Hook.RegisterAbsoluteAOB(AwardItemFuncAOB);
    }

    public string GetName(InventoryItem item)
    {
        Dictionary<uint, string> nameDict = item.Category switch
        {
            InventoryItemCategory.WEAPON => EquipNames.WeaponNames,
            InventoryItemCategory.ARMOR => EquipNames.ArmorNames,
            InventoryItemCategory.TALISMAN => EquipNames.TalismanNames,
            InventoryItemCategory.GOOD => EquipNames.GoodNames,
            InventoryItemCategory.ASH_OF_WAR => EquipNames.AshOfWarNames,
            _ => new Dictionary<uint, string>(),
        };
        
        return nameDict.GetValueOrDefault(item.ID, "Unknown");
    }

    public List<InventoryItem> GetInventoryItems()
    {
        if (InventoryInfoAddr == null)
        {
            Console.WriteLine("Inventory hook not enabled.");
            return [];
        }

        IntPtr[] inventoryAddresses =
        [
            Kernel32.ReadIntPtr(Hook.Handle, InventoryInfoAddr.Value, Hook.Is64Bit),
            Kernel32.ReadIntPtr(Hook.Handle, InventoryInfoAddr.Value + 0x8, Hook.Is64Bit),
            Kernel32.ReadIntPtr(Hook.Handle, InventoryInfoAddr.Value + 0x10, Hook.Is64Bit),
        ];

        List<InventoryItem> items = [];
        foreach (IntPtr inventoryAddress in inventoryAddresses)
        {
            if (inventoryAddress == 0)
                continue;

            PHPointer inventory = Hook.CreateBasePointer(inventoryAddress);
            int count = inventory.ReadInt32(-8);
            if (count <= 0)
                continue;

            for (int i = 0; i < count; i++)
            {
                uint itemCategoryAndId = inventory.ReadUInt32(i * 20 + 4);
                uint itemQuantity = inventory.ReadUInt32(i * 20 + 8);
                
                if (itemCategoryAndId == 0 || itemCategoryAndId == 0xFFFFFFFF || itemQuantity == 0)
                    continue;

                InventoryItem item = new(Hook.CreateBasePointer(inventoryAddress + i * 20));
                items.Add(item);
            }
        }

        return items;
    }

    /// <summary>
    /// TODO: Should not be used; glitches out and awarded items are permanently stuck in storage.
    ///
    /// Much better to use dynamic EMEVD and pre-established Item Lot IDs.
    /// </summary>
    /// <param name="category"></param>
    /// <param name="id"></param>
    /// <param name="quantity"></param>
    // ReSharper disable once UnusedMember.Local
    void AwardItem(InventoryItemCategory category, uint id, uint quantity)
    {
        if (!Hook.MapItemMan.TryResolve(out IntPtr mapItemManAddr))
        {
            Logging.Debug("Failed to resolve MapItemMan.");
            return;
        }
        if (!AwardItemFunc.TryResolve(out IntPtr awardItemFuncAddr))
        {
            Logging.Debug("Failed to resolve AwardItem function.");
            return;
        }
        
        IntPtr itemSpawnInfoAddr = Hook.AllocateClose(4 * sizeof(int));
        Logging.Debug($"itemSpawnInfoAddr = {mapItemManAddr:X}");

        try
        {
            Kernel32.WriteUInt32(Hook.Handle, itemSpawnInfoAddr + 0x0, 1);
            Kernel32.WriteUInt32(Hook.Handle, itemSpawnInfoAddr + 0x4, id);
            Kernel32.WriteUInt32(Hook.Handle, itemSpawnInfoAddr + 0x8, quantity);
            Kernel32.WriteUInt32(Hook.Handle, itemSpawnInfoAddr + 0xC, 0xFFFFFFFF);  // unknown

            string awardItemAsm = ResourceManager.GetEmbeddedResource("AwardItem.asm");
            string asm = string.Format(
                awardItemAsm,
                ((int)category * 0x1000_0000).ToString("X2"),  // 0
                itemSpawnInfoAddr.ToString("X2"),  // 1
                (itemSpawnInfoAddr + 0x4).ToString("X2"),  // 2
                (itemSpawnInfoAddr + 0xC).ToString("X2"),  // 3
                mapItemManAddr.ToString("X2"),  // 4
                awardItemFuncAddr.ToString("X2"));  // 5
            Logging.Debug(asm);
            Hook.AssembleAndExecute(asm);
            Logging.Debug($"Awarded item: {category} {id} x{quantity}");
        }
        finally
        {
            Hook.Free(itemSpawnInfoAddr);
        }
    }

    public void EnableInventoryHook()
    {
        if (InventoryHookAddr != null)
        {
            Console.WriteLine("Inventory hook already enabled.");
            return;
        }
        
        if (!InventoryAccessor.TryResolve(out IntPtr inventoryAccessorAddr))
        {
            Console.WriteLine("Failed to find InventoryAccessor address.");
            return;
        }

        // AOB is 8 bytes AFTER the injection point.
        inventoryAccessorAddr -= 8;
        
        // First, we allocate some non-executable memory to store the hooked inventory information (three possible
        // inventory addresses).
        // Cheat Engine does this in a single block using a label, but we don't have that luxury (I assume).
        InventoryInfoAddr = Hook.AllocateClose(0x16);  // space for three 64-bit values
        
        string inventoryHookAsm = ResourceManager.GetEmbeddedResource("RoundtableEldenRing.Resources.InventoryHook.asm");
        inventoryHookAsm = string.Format(
            inventoryHookAsm,
            InventoryInfoAddr.Value.ToInt64(),
            inventoryAccessorAddr + 8);  // return address (original AOB location)
        
        // Allocate injection code.
        Logging.Debug(inventoryHookAsm);
        InventoryHookAddr = Hook.AssembleAllocateWrite(inventoryHookAsm, executable: true);
        Logging.Debug($"Inventory hook address: {InventoryHookAddr.Value.ToInt64():X}");
        
        MemBuilder injectionSiteMem = new();
        int relativeJump = (int)(InventoryHookAddr.Value - (inventoryAccessorAddr + 0x5));  // jumps AFTER jump instruction in game function (5 bytes)
        injectionSiteMem.Write("e9");  // jmp
        injectionSiteMem.Write(BitConverter.GetBytes(relativeJump));
        injectionSiteMem.Write("90 90 90");  // nop nop nop
        
        // Inject jump instruction.
        byte[] injectionSiteBytes = injectionSiteMem.Finish();
        Logging.Debug($"Final injection SITE code: {BitConverter.ToString(injectionSiteBytes)}");
        if (!Kernel32.WriteBytes(Hook.Handle, inventoryAccessorAddr, injectionSiteBytes))
        {
            Console.WriteLine($"ERROR: Failed to inject Inventory Manager jump. Error: {Marshal.GetLastWin32Error()}");
            Hook.Free(InventoryHookAddr.Value);  // free injected code
            InventoryHookAddr = null;
            return;
        }
        Logging.Debug("Injected inventory hook successfully.");
    }
    
    public void DisableInventoryHook()
    {
        if (InventoryAccessor.IsNonZero)
        {
            // Restore original bytes.
            InventoryAccessor.WriteBytes(-8, InventoryAccessorOriginal);
        }
        
        if (InventoryHookAddr != null)
        {
            // Free hook memory.
            Hook.Free(InventoryHookAddr.Value);
            InventoryHookAddr = null;
        }
        
        if (InventoryInfoAddr != null)
        {
            // Free info memory.
            Hook.Free(InventoryInfoAddr.Value);
            InventoryInfoAddr = null;
        }
        
        Logging.Debug("Inventory hook disabled.");
    }
}