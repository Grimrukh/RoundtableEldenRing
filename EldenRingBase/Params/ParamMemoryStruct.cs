using System.Text;
using PropertyHook;
using EldenRingBase.GameHook;

namespace EldenRingBase.Params;


/// <summary>
/// Struct for a PARAM in game memory.
///
/// Exactly matches `PARAM` class, but only supports more limiting direct editing of certain fields in existing rows.
/// </summary>
/// <param name="pointer"></param>
public class ParamMemoryStruct(PHPointer pointer, string assertedParamdefName) : PointerWrapper(pointer)
{
    static class Offsets
    {
        public const int StringsOffset = 0x0; // suggests length of row data
        public const int ParamTypeOffset = 0x10;
        public const int TableLength = 0x30;
    }

    Dictionary<int, int> RowOffsets { get; } = BuildOffsetDictionary(pointer, assertedParamdefName);

    static Dictionary<int, int> BuildOffsetDictionary(PHPointer paramPointer, string assertedParamName)
    {
        Dictionary<int, int> dictionary = new();
        int nameOffset = paramPointer.ReadInt32(Offsets.ParamTypeOffset);
        string? paramName = paramPointer.ReadString(nameOffset, Encoding.UTF8, 0x18);
        if (paramName != assertedParamName)
            throw new InvalidOperationException(
                $"Incorrect PARAM pointer: expected name '{assertedParamName}' but found '{paramName}'.");

        int tableLength = paramPointer.ReadInt32(Offsets.TableLength);
        
        // Offsets in a 'PARAM Row Header':
        const int paramID = 0x0;
        const int paramOffset = 0x8;
        const int nextParam = 0x18;

        int rowHeaderOffset = 0x40;  // after PARAM header

        while (rowHeaderOffset < tableLength)
        {
            int rowID = paramPointer.ReadInt32(rowHeaderOffset + paramID);
            int rowDataOffset = paramPointer.ReadInt32(rowHeaderOffset + paramOffset);
            dictionary.Add(rowID, rowDataOffset);
            rowHeaderOffset += nextParam;
        }

        return dictionary;
    }
}
