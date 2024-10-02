using System.Text;
using EldenRingBase.GameHook;
using PropertyHook;
using SoulsFormats;

namespace EldenRingBase.Params;

/// <summary>
/// Exposes read-only access to a PARAM (so you can't add/remove Rows!).
/// </summary>
public class ParamInMemory : PointerWrapper
{
    readonly PARAM _param;
    readonly PARAMDEF _paramdef;
    readonly int _paramDataSize;

    public readonly Dictionary<int, int> IDToIndex;
    readonly List<string> rowNames;
    readonly Dictionary<string, int> fieldToOffset;
    
    public List<PARAM.Row> Rows => _param.Rows;
    public bool Ready { get; private set; }

    public ParamInMemory(PHPointer pointer, PARAMDEF paramdef) : base(pointer)
    {
        _paramdef = paramdef;
        (_param, _paramDataSize) = ReadParam(pointer);
        
        // NOTE: We aggressively apply this, as `param.ParamType` string can easily get lost while rewriting PARAM.
        _param.ApplyParamdef(paramdef);
        
        rowNames = [];
        foreach (PARAM.Row row in _param.Rows)
            rowNames.Add(row.Name);
            
        IDToIndex = GetIDToIndex(_param);
        fieldToOffset = GetFieldToOffset(paramdef);
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
        
        if (!fieldToOffset.TryGetValue(fieldName, out int offset))
        {
            if (field.BitSize != -1)
                throw new KeyNotFoundException($"Field name '{fieldName}' uses partial bits and cannot be accessed directly in memory.");
            throw new KeyNotFoundException($"Field name '{fieldName}' has type {field.DisplayType} and cannot be accessed directly in memory.");
        }
        
        int rowIndex = IDToIndex[rowID];
        int rowDataOffset = (int)Pointer.ReadInt64(0x40 + 0x18 * rowIndex + 0x8);

        switch (field.DisplayType)
        {
            case PARAMDEF.DefType.s8:
                return Pointer.ReadSByte(rowDataOffset + offset);
            case PARAMDEF.DefType.u8:
                return Pointer.ReadByte(rowDataOffset + offset);
            case PARAMDEF.DefType.s16:
                return Pointer.ReadInt16(rowDataOffset + offset);
            case PARAMDEF.DefType.u16:
                return Pointer.ReadUInt16(rowDataOffset + offset);
            case PARAMDEF.DefType.s32:
            case PARAMDEF.DefType.b32:
                return Pointer.ReadInt32(rowDataOffset + offset);
            case PARAMDEF.DefType.u32:
                return Pointer.ReadUInt32(rowDataOffset + offset);
            case PARAMDEF.DefType.f32:
            case PARAMDEF.DefType.angle32:
                return Pointer.ReadSingle(rowDataOffset + offset);
            case PARAMDEF.DefType.f64:
                return Pointer.ReadDouble(rowDataOffset + offset);
            case PARAMDEF.DefType.dummy8:
            case PARAMDEF.DefType.fixstr:
            case PARAMDEF.DefType.fixstrW:
                throw new ArgumentException(
                    $"Cannot fast-read param field '{fieldName}' from memory. " +
                    $"Field type {field.DisplayType} is unsupported.");
            default:
                throw new ArgumentOutOfRangeException($"Cannot fast-reade param field {field} from memory.");
        }
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
        Pointer.WriteBytes(rowDataOffset, rowBytes);
    }

    /// <summary>
    /// Alternate wrapper.
    /// </summary>
    /// <param name="row"></param>
    public void FastSetRow(PARAM.Row row) => FastSetRow(row.ID);

    /// <summary>
    /// Set a field value in the PARAM by row ID and field name.
    ///
    /// Updates `PARAM` and also edits memory immediately rather than calling the most expensive `SaveParam()`.
    /// </summary>
    /// <param name="rowID"></param>
    /// <param name="fieldName"></param>
    /// <param name="fieldValue"></param>
    public void FastSet(int rowID, string fieldName, object fieldValue)
    {
        PARAMDEF.Field? field = _paramdef.Fields.FirstOrDefault(f => f.InternalName == fieldName);
        if (field == null)
            throw new KeyNotFoundException($"Field name '{fieldName}' not found in PARAMDEF.");
        
        if (!fieldToOffset.TryGetValue(fieldName, out int offset))
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
                Pointer.WriteSByte(rowDataOffset + offset, (sbyte)fieldValue); break;
            case PARAMDEF.DefType.u8:
                Pointer.WriteByte(rowDataOffset + offset, (byte)fieldValue); break;
            case PARAMDEF.DefType.s16:
                Pointer.WriteInt16(rowDataOffset + offset, (short)fieldValue); break;
            case PARAMDEF.DefType.u16:
                Pointer.WriteUInt16(rowDataOffset + offset, (ushort)fieldValue); break;
            case PARAMDEF.DefType.s32:
            case PARAMDEF.DefType.b32:
                Pointer.WriteInt32(rowDataOffset + offset, (int)fieldValue); break;
            case PARAMDEF.DefType.u32:
                Pointer.WriteUInt32(rowDataOffset + offset, (uint)fieldValue); break;
            case PARAMDEF.DefType.f32:
            case PARAMDEF.DefType.angle32:
                Pointer.WriteSingle(rowDataOffset + offset, (float)fieldValue); break;
            case PARAMDEF.DefType.f64:
                Pointer.WriteDouble(rowDataOffset + offset, (double)fieldValue); break;
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
        if (_param.Rows.Count != rowNames.Count)
            throw new Exception("New PARAM has a different number of rows. Not saving.");
        
        // User isn't allowed to edit row name. We restore the old ones to preserve offsets.
        for (int i = 0; i < Rows.Count; i++)
            Rows[i].Name = rowNames[i];
        
        byte[] newParamBytes = _param.Write();
        
        // We update ROW DATA ONLY, not the header or string data.
        newParamBytes = newParamBytes[0x40.._paramDataSize];
        return Pointer.WriteBytes(0x40, newParamBytes);
    }

    public byte[] Write()
    {
        for (int i = 0; i < Rows.Count; i++)
            Rows[i].Name = rowNames[i];
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

    public bool ContainsRowID(int id)
    {
        return IDToIndex.ContainsKey(id);
    }

    public object this[int id, string fieldName]
    {
        get => this[id][fieldName].Value;  // should be synced with memory, so we don't need a `FastGet`
        set => FastSet(id, fieldName, value);
    }

    static (PARAM, int) ReadParam(PHPointer pointer)
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

    static bool SupportsFastOffset(PARAMDEF.Field field)
    {
        if (field.BitSize != -1)
            return false;
        return field.DisplayType is not (PARAMDEF.DefType.fixstr or PARAMDEF.DefType.fixstrW
            or PARAMDEF.DefType.dummy8);
    }
    
    static Dictionary<string, int> GetFieldToOffset(PARAMDEF paramdef)
    {
        Dictionary<string, int> fieldToOffset = new();
        int offset = 0x0;
        int bitOffset = 0;
        var bitType = PARAMDEF.DefType.u8;

        foreach (PARAMDEF.Field field in paramdef.Fields)
        {
            if (SupportsFastOffset(field))
                fieldToOffset[field.InternalName] = offset;
            
            // Increment offset by this field's size.
            int size = getFieldSize(field);
            offset += size;
            // Console.WriteLine($"{field.InternalName}: {size} ({field.DisplayType}, {field.BitSize}) -> 0x{offset:X}");
        }

        return fieldToOffset;

        int getFieldSize(PARAMDEF.Field field)
        {
            PARAMDEF.DefType type = field.DisplayType;
            
            if (type is PARAMDEF.DefType.u32 or PARAMDEF.DefType.u16 or PARAMDEF.DefType.u8 or PARAMDEF.DefType.dummy8)
            {
                if (field.BitSize != -1)
                {
                    // Partial bits only. Skipping a bunch of validation checks here, as PARAMDEF wouldn't be able to
                    // be applied to PARAM in that case.

                    PARAMDEF.DefType newBitType = type == PARAMDEF.DefType.dummy8 ? PARAMDEF.DefType.u8 : type;
                    int bitLimit;
                    switch (type)
                    {
                        case PARAMDEF.DefType.dummy8:
                        case PARAMDEF.DefType.u8:
                            bitLimit = 8;
                            break;
                        case PARAMDEF.DefType.u16:
                            bitLimit = 16;
                            break;
                        case PARAMDEF.DefType.u32:
                            bitLimit = 32;
                            break;
                        default:
                            throw new NotImplementedException($"Unsupported field type: {type}");
                    }
                    
                    if (bitOffset == -1 || newBitType != bitType || bitOffset + field.BitSize > bitLimit)
                    {
                        // Time to consume new byte(s).
                        bitOffset = 0;
                        bitType = newBitType;

                        switch (bitType)
                        {
                            case PARAMDEF.DefType.u8:
                                return 1;
                            case PARAMDEF.DefType.u16:
                                return 2;
                            case PARAMDEF.DefType.u32:
                                return 4;
                        }
                    }

                    // This field doesn't consume any new bytes.
                    bitOffset += field.BitSize;
                    return 0;
                }
            }
            
            // Leftover bits discarded.
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
}