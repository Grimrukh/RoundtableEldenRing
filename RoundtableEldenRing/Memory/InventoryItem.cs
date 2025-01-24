using PropertyHook;
using RoundtableBase.Memory;

namespace RoundtableEldenRing.Memory;


public class InventoryItem(PHPointer pointer) : RTPointer(pointer)
{
   
    /// <summary>
    /// Item is only removable (deletable) if both IDs are non-zero.
    /// </summary>
    public bool Removable
    {
        get
        {
            uint id1 = ReadUInt32(0);
            uint id2 = ReadUInt32(4);
            return id1 != 0 && id2 != 0;
        }
    }
    
    /// <summary>
    /// Item is only editable if it is removable AND both of its item IDs match.
    ///
    /// I think this is because of From's cheat detection system? The first ID, for equipment, seems to be something
    /// that just ticks up for each new equipment you pick up. So it's generally not possible to edit equipment.
    /// </summary>
    public bool Editable
    {
        get
        {
            uint id1 = ReadUInt32(0);
            uint id2 = ReadUInt32(4);
            Console.WriteLine($"{ID} -- {id1 & 0x0FFFFFFF} {id2 & 0x0FFFFFFF}");
            if (id1 == 0 || id2 == 0) return false;
            return (id1 & 0x0FFFFFFF) == (id2 & 0x0FFFFFFF);
        }
    }
    
    /// <summary>
    /// Get ID of item. We use the second ID.
    /// </summary>
    public uint ID
    {
        get => ReadUInt32(4) & 0x0FFFFFFF;
        set
        {
            if (!Editable) return;
            // Keep existing category bits.
            WriteUInt32(0, ReadUInt32(0) & 0xF0000000 | value);
            WriteUInt32(4, ReadUInt32(4) & 0xF0000000 | value);
        }
    }

    /// <summary>
    /// TODO: Settable?
    /// </summary>
    public InventoryItemCategory Category => (InventoryItemCategory)((ReadUInt32(4) & 0xF0000000) >> 28);

    // TODO: settable?
    public uint Quantity
    {
        get => ReadUInt32(8);
        set
        {
            if (!Editable) return;
            // TODO: Should enforce some max.
            WriteUInt32(8, value);
        }
    }

    public bool Delete()
    {
        if (!Removable) return false;
        
        WriteBytes(0, [0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255]);
        return true;
    }
}