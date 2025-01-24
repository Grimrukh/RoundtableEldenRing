using System.Text;
using PropertyHook;
using RoundtableBase.Memory;
using SoulsFormats;

namespace RoundtableEldenRing.Params;

/// <summary>
/// Exposes access to a PARAM in game memory for direct row/field modification based on known ParamDef layouts.
///
/// Note that Rows cannot be added or removed, as the size of the PARAM in memory must not change.
/// </summary>
public class MemoryPARAM : RTPointer
{
    readonly PARAM _param;
    readonly PARAMDEF _paramdef;
    readonly int _paramDataSize;
    readonly List<string> _rowNames;
    readonly Dictionary<string, int> _fieldToOffset;

    /// <summary>
    /// Maps row IDs to their indices in the PARAM for address resolution.
    ///
    /// If duplicate IDs exist, only the first one will be stored.
    /// </summary>
    public readonly Dictionary<int, int> IDToIndex;

    /// <summary>
    /// Access to all Rows in PARAM, without the ability to add or remove them.
    /// </summary>
    public List<PARAM.Row> Rows => _param.Rows;
    
    /// <summary>
    /// Ensure that the PARAM is fully loaded and ready for reading and writing (e.g. for multi-threaded access).
    /// </summary>
    public bool Ready { get; private set; }

    public MemoryPARAM(PHPointer pointer, PARAMDEF paramdef) : base(pointer)
    {
        _paramdef = paramdef;
        (_param, _paramDataSize) = ReadParam(pointer);
        
        // NOTE: We aggressively apply this, as `param.ParamType` string can easily get lost while rewriting PARAM.
        _param.ApplyParamdef(paramdef);
        
        _rowNames = [];
        foreach (PARAM.Row row in _param.Rows)
            _rowNames.Add(row.Name);
            
        IDToIndex = GetIDToIndex(_param);
        _fieldToOffset = GetFieldToOffsetDict(paramdef);
        Ready = true;
    }
    
    /// <summary>
    /// Get a field value in the PARAM in memory by row ID and field name.
    ///
    /// Mostly for debugging, since you can just access the row directly.
    /// </summary>
    /// <param name="rowID"></param>
    /// <param name="fieldName"></param>
    public object GetFieldValueFast(int rowID, string fieldName)
    {
        PARAMDEF.Field? field = _paramdef.Fields.FirstOrDefault(f => f.InternalName == fieldName);
        if (field == null)
            throw new KeyNotFoundException($"Field name '{fieldName}' not found in PARAMDEF.");
        
        if (!_fieldToOffset.TryGetValue(fieldName, out int offset))
        {
            if (field.BitSize != -1)
                throw new KeyNotFoundException($"Field name '{fieldName}' uses partial bits and cannot be accessed directly in memory.");
            throw new KeyNotFoundException($"Field name '{fieldName}' has type {field.DisplayType} and cannot be accessed directly in memory.");
        }
        
        int rowIndex = IDToIndex[rowID];
        int rowDataOffset = (int)Pointer.ReadInt64(0x40 + 0x18 * rowIndex + 0x8);

        return field.DisplayType switch
        {
            PARAMDEF.DefType.s8 => ReadSByte(rowDataOffset + offset),
            PARAMDEF.DefType.u8 => ReadByte(rowDataOffset + offset),
            PARAMDEF.DefType.s16 => ReadInt16(rowDataOffset + offset),
            PARAMDEF.DefType.u16 => ReadUInt16(rowDataOffset + offset),
            PARAMDEF.DefType.s32 or PARAMDEF.DefType.b32 => ReadInt32(rowDataOffset + offset),
            PARAMDEF.DefType.u32 => ReadUInt32(rowDataOffset + offset),
            PARAMDEF.DefType.f32 or PARAMDEF.DefType.angle32 => ReadSingle(rowDataOffset + offset),
            PARAMDEF.DefType.f64 => ReadDouble(rowDataOffset + offset),
            PARAMDEF.DefType.dummy8 or PARAMDEF.DefType.fixstr or PARAMDEF.DefType.fixstrW => throw
                new ArgumentException($"Cannot fast-read param field '{fieldName}' from memory. " +
                                      $"Field type {field.DisplayType} is unsupported."),
            _ => throw new ArgumentOutOfRangeException($"Cannot fast-reade param field {field} from memory.")
        };
    }

    /// <summary>
    /// Find `rowID` in memory and write all of its bytes. Faster than setting, say, 3+ fields in the row.
    /// </summary>
    /// <param name="rowID"></param>
    public void FastSetRow(int rowID)
    {
        PARAM.Row row = this[rowID];
        int rowIndex = IDToIndex[rowID];
        int rowDataOffset = (int)Pointer.ReadInt64(0x40 + 0x18 * rowIndex + 0x8);
        byte[] rowBytes = row.WriteCells();
        WriteBytes(rowDataOffset, rowBytes);
    }

    /// <summary>
    /// Set a field value in the PARAM by row ID and field name.
    ///
    /// Updates `PARAM` and also edits memory immediately rather than calling the expensive
    /// `WriteEntireParamToMemory()`, which has to export the entire PARAM to a byte array to write to memory (can be
    /// multiple MB).
    /// </summary>
    /// <param name="rowID"></param>
    /// <param name="fieldName"></param>
    /// <param name="fieldValue"></param>
    public void FastSet(int rowID, string fieldName, object fieldValue)
    {
        PARAMDEF.Field? field = _paramdef.Fields.FirstOrDefault(f => f.InternalName == fieldName);
        if (field == null)
            throw new KeyNotFoundException($"Field name '{fieldName}' not found in PARAMDEF.");
        
        if (!_fieldToOffset.TryGetValue(fieldName, out int offset))
        {
            if (field.BitSize != -1)
                throw new KeyNotFoundException($"Field name '{fieldName}' uses partial bits and cannot be accessed directly in memory.");
            throw new KeyNotFoundException($"Field name '{fieldName}' has type {field.DisplayType} and cannot be accessed directly in memory.");
        }
        
        // Update our copy of PARAM.
        PARAM.Row row = this[rowID];
        row[fieldName].Value = fieldValue;
        
        // Update PARAM in memory.
        int rowIndex = IDToIndex[rowID];
        int rowDataOffset = (int)Pointer.ReadInt64(0x40 + 0x18 * rowIndex + 0x8);

        switch (field.DisplayType)
        {
            case PARAMDEF.DefType.s8:
                WriteSByte(rowDataOffset + offset, (sbyte)fieldValue); break;
            case PARAMDEF.DefType.u8:
                WriteByte(rowDataOffset + offset, (byte)fieldValue); break;
            case PARAMDEF.DefType.s16:
                WriteInt16(rowDataOffset + offset, (short)fieldValue); break;
            case PARAMDEF.DefType.u16:
                WriteUInt16(rowDataOffset + offset, (ushort)fieldValue); break;
            case PARAMDEF.DefType.s32:
            case PARAMDEF.DefType.b32:
                WriteInt32(rowDataOffset + offset, (int)fieldValue); break;
            case PARAMDEF.DefType.u32:
                WriteUInt32(rowDataOffset + offset, (uint)fieldValue); break;
            case PARAMDEF.DefType.f32:
            case PARAMDEF.DefType.angle32:
                WriteSingle(rowDataOffset + offset, (float)fieldValue); break;
            case PARAMDEF.DefType.f64:
                WriteDouble(rowDataOffset + offset, (double)fieldValue); break;
            case PARAMDEF.DefType.dummy8:
            case PARAMDEF.DefType.fixstr:
            case PARAMDEF.DefType.fixstrW:
                throw new ArgumentException(
                    $"Cannot fast-write param field '{fieldName}' to memory. " +
                    $"Field type {field.DisplayType} is unsupported.");
            default:
                throw new ArgumentOutOfRangeException($"Cannot fast-write param field {field} to memory.");
        }
    }

    /// <summary>
    /// Write current PARAM state back to memory after all desired edits have been made.
    ///
    /// TODO: Check speed. This happens a lot more often than reading!
    /// </summary>
    /// <exception cref="Exception"></exception>
    public bool WriteEntireParamToMemory()
    {
        if (_param.Rows.Count != _rowNames.Count)
            throw new Exception("New PARAM has a different number of rows. Not saving.");
        
        // User isn't allowed to edit row name. We restore the old ones to preserve offsets.
        for (int i = 0; i < Rows.Count; i++)
            Rows[i].Name = _rowNames[i];
        
        byte[] newParamBytes = _param.Write();
        
        // We update ROW DATA ONLY, not the header or string data.
        newParamBytes = newParamBytes[0x40.._paramDataSize];
        return WriteBytes(0x40, newParamBytes);
    }

    /// <summary>
    /// Export PARAM to a byte array for saving to a file or sending to another process.
    /// </summary>
    /// <returns></returns>
    public byte[] Write()
    {
        for (int i = 0; i < Rows.Count; i++)
            Rows[i].Name = _rowNames[i];
        return _param.Write();
    }
    
    /// <summary>
    /// Retrieve a `PARAM.Row` by its ID rather than index in PARAM.
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="KeyNotFoundException"></exception>
    public PARAM.Row this[int id]
    {
        get
        {
            if (!IDToIndex.TryGetValue(id, out int index))
                throw new KeyNotFoundException($"ID {id} not found in PARAM.");
            return _param.Rows[index];
        }
    }

    /// <summary>
    /// Check if row ID is present in this PARAM.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool ContainsRowID(int id)
    {
        return IDToIndex.ContainsKey(id);
    }

    /// <summary>
    /// Retrieve or fast-set a field value in the PARAM by row ID (NOT index) and field name.
    ///
    /// Will throw exceptions if the row ID or field name is not found in the PARAM.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="fieldName"></param>
    public object this[int id, string fieldName]
    {
        get => this[id][fieldName].Value;  // should be synced with memory, so we don't need a `FastGet`
        set => FastSet(id, fieldName, value);
    }

    public void PrintRow(int id)
    {
        PARAM.Row row = this[id];
        Console.WriteLine($"Row {id} ({row.Name}) [{row.ID}]:");
        foreach (KeyValuePair<string, PARAM.Cell> pair in row.CellDict)
            Console.WriteLine($"    {pair.Key} = {pair.Value}");
    }

    /// <summary>
    /// Read a PARAM from memory and return it as a `PARAM` object, along with the offset of its string data.
    /// </summary>
    /// <param name="pointer"></param>
    /// <returns></returns>
    static (PARAM param, int stringsOffset) ReadParam(PHPointer pointer)
    {
        uint stringsOffset = pointer.ReadUInt32(0x0);
        ushort rowCount = pointer.ReadUInt16(0xA);
        long paramTypeOffset = pointer.ReadInt64(0x10);
        string paramType = pointer.ReadString((int)paramTypeOffset, Encoding.ASCII, 0x40);
        long lastRowNameOffset = pointer.ReadInt64(0x40 + 0x18 * (rowCount - 1) + 0x10);
        
        byte[] bytes = pointer.ReadBytes(0, stringsOffset);
        
        // Add some empty bytes to read null names from in SoulsFormats.
        // Note that if names are stripped, there will only be one offset here, so in most cases, this will only add
        // four null bytes.
        // TODO: Added a PARAM reader that ignores names, so maybe don't need the pad.
        
        Array.Resize(ref bytes, bytes.Length + (int)lastRowNameOffset - (int)Math.Max(stringsOffset, paramTypeOffset) + 0x40);
        return (PARAM.ReadFromMemory(bytes), (int)stringsOffset);
    }

    /// <summary>
    /// Get a dictionary mapping row IDs to their indices in the PARAM.
    /// </summary>
    /// <param name="param"></param>
    /// <returns></returns>
    static Dictionary<int, int> GetIDToIndex(PARAM param)
    {
        Dictionary<int, int> idToIndex = new();
        for (int i = 0; i < param.Rows.Count; i++)
        {
            PARAM.Row row = param.Rows[i];
            if (idToIndex.ContainsKey(row.ID))
                continue;  // ignore duplicate row ID (use first)
            int id = row.ID;
            idToIndex.Add(id, i);
        }

        return idToIndex;
    }

    /// <summary>
    /// Currently, only supports fields that are not partial bits or dummy8.
    /// </summary>
    /// <param name="field"></param>
    /// <returns></returns>
    static bool SupportsFastOffset(PARAMDEF.Field field)
    {
        if (field.BitSize != -1)
            return false;
        return field.DisplayType is not (PARAMDEF.DefType.fixstr or PARAMDEF.DefType.fixstrW
            or PARAMDEF.DefType.dummy8);
    }
    
    /// <summary>
    /// Iterate over all fields in `paramdef` and construct a dictionary mapping field names to their row offsets.
    /// </summary>
    /// <param name="paramdef"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <exception cref="NotImplementedException"></exception>
    static Dictionary<string, int> GetFieldToOffsetDict(PARAMDEF paramdef)
    {
        Dictionary<string, int> fieldToOffset = new();
        int offset = 0x0;
        int bitOffset = -1;
        var bitType = PARAMDEF.DefType.u8;  // choice of init doesn't matter since initial `bitOffset` is -1

        foreach (PARAMDEF.Field field in paramdef.Fields)
        {
            int size = getFieldSize(field);
            // Console.WriteLine($"{field.InternalName}: {size} ({field.DisplayType}, {field.BitSize}) -> 0x{offset:X}");
            if (SupportsFastOffset(field))
            {
                // Record offset of this field before incrementing it by this field's size.
                fieldToOffset[field.InternalName] = offset;
            }
            offset += size;
        }

        return fieldToOffset;

        int getFieldSize(PARAMDEF.Field field)
        {
            PARAMDEF.DefType type = field.DisplayType;
            
            if (MaxBitCounts.TryGetValue(type, out int maxBitCount) && field.BitSize != -1)
            {
                // Partial bits only. Skipping a bunch of validation checks here, as failing such checks would
                // already have prevented the PARAMDEF from being applied to this PARAM.

                PARAMDEF.DefType newBitType = type == PARAMDEF.DefType.dummy8 ? PARAMDEF.DefType.u8 : type;
                
                if (bitOffset == -1 || newBitType != bitType || bitOffset + field.BitSize > maxBitCount)
                {
                    // Consume new byte(s).
                    bitType = newBitType;
                    bitOffset = field.BitSize;

                    return newBitType switch
                    {
                        PARAMDEF.DefType.u8 => 1,
                        PARAMDEF.DefType.u16 => 2,
                        PARAMDEF.DefType.u32 => 4,
                        _ => throw new ArgumentOutOfRangeException(),  // not reachable
                    };
                }

                // This field doesn't consume any new bytes.
                bitOffset += field.BitSize;
                return 0;
            }
            
            // Non-bit field. Any leftover bits are discarded.
            bitOffset = -1;

            return type switch
            {
                PARAMDEF.DefType.u8 or PARAMDEF.DefType.s8 => 1,
                PARAMDEF.DefType.u16 or PARAMDEF.DefType.s16 => 2,
                PARAMDEF.DefType.u32 or PARAMDEF.DefType.s32 or PARAMDEF.DefType.f32 or PARAMDEF.DefType.b32 => 4,
                PARAMDEF.DefType.f64 => 8,
                PARAMDEF.DefType.dummy8 or PARAMDEF.DefType.fixstr => field.ArrayLength,
                PARAMDEF.DefType.fixstrW => field.ArrayLength * 2,
                _ => throw new NotImplementedException($"Unsupported field type: {type}")
            };
        }
    }
    
    static readonly Dictionary<PARAMDEF.DefType, int> MaxBitCounts = new()
    {
        {PARAMDEF.DefType.dummy8, 8},
        {PARAMDEF.DefType.u8, 8},
        {PARAMDEF.DefType.u16, 16},
        {PARAMDEF.DefType.u32, 32},
    };
}