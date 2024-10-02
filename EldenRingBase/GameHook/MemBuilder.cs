namespace EldenRingBase.GameHook;

/// <summary>
/// My utility class for constructing a byte array for direct
/// injection into process memory.
/// </summary>
public class MemBuilder
{
    /// <summary>
    /// Exception raised by invalid MemBuilder state.
    /// </summary>
    public class MemBuilderException : Exception
    {
        public MemBuilderException(string message) : base(message) { }
    }
    
    readonly List<byte> mem = [];
    readonly Dictionary<string, (int, int)> reserved = new();

    public int Offset => mem.Count;

    static List<byte> ParseHexString(string hex)
    {
        List<byte> result = [];
        foreach (string b in hex.Split(' '))
            result.Add(byte.Parse(b, System.Globalization.NumberStyles.AllowHexSpecifier));
        return result;
    }

    public void Write(IEnumerable<byte> bytes)
    {
        mem.AddRange(bytes);
    }

    public void Write(string hex)
    {
        Write(ParseHexString(hex));
    }

    public void Write(byte b)
    {
        mem.Add(b);
    }

    public byte[] Finish()
    {
        if (reserved.Count > 0)
            throw new MemBuilderException("Cannot call `MemBuilder.Finish()` when reserved names remain.");
        return mem.ToArray();
    }

    public void Reserve(string name, int size)
    {
        if (reserved.ContainsKey(name))
            throw new MemBuilderException($"Name '{name}' is already reserved.");
        reserved[name] = (size, Offset);
        for (int i = 0; i < size; i++)
            Write(0xFE);  // placeholder bytes
    }

    public int GetReservedOffset(string name)
    {
        if (!reserved.TryGetValue(name, out (int, int) value))
            throw new MemBuilderException($"Cannot get offset of unreserved name '{name}'.");
        return value.Item2;
    }

    public void Fill(string name, IEnumerable<byte> value)
    {
        if (!reserved.TryGetValue(name, out (int size, int offset) res))
            throw new MemBuilderException($"Cannot fill unreserved name '{name}'.");
        byte[] valueArray = value.ToArray();
        if (valueArray.Length != res.size)
            throw new MemBuilderException($"Number of bytes to write to reserved '{name}' does not match reserved size: {res.size}");
        for (int i = 0; i < valueArray.Length; i++)
            mem[res.offset + i] = valueArray[i];
        reserved.Remove(name);
    }

    public void Fill(string name, string hex)
    {
        Fill(name, ParseHexString(hex));
    }
    
    public void PadAlign(int alignment)
    {
        int pad = alignment - Offset % alignment;
        for (int i = 0; i < pad; i++)
            Write(0x90);  // NOP
    }
}