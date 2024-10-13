using System.Numerics;

namespace EldenRingBase;

public enum TileSize : byte
{
    Small = 0,
    Medium = 1,
    Large = 2,
    None = 255,
}

public enum MapAreaType : byte
{
    LegacyDungeonBase = 10,  // many matching areas (10-19)
    LegacyDungeonDLC = 20,  // many matching areas (20-29)
    
    // TODO: Add DLC dungeon categories.
    
    Catacombs = 30,
    Cave = 31,
    Tunnel = 32,
    DivineTower = 34,
    ShunningGrounds = 35,  // unique area, likely because it connects Leyndell to Deeproot Depths
    RuinStrewnPrecipice = 39,  // unique area, obviously important
    
    CatacombsDLC = 40,
    GaolDLC = 41,
    RuinedForgeDLC = 42,
    CaveDLC = 43,
    
    Colosseum = 45,
    
    Overworld = 60,
    OverworldDLC = 61,
    
    Unknown = 255,
}

/// <summary>
/// Initialized with a classic map stem string like 'm10_00_00_00' or 'm60_10_10_02' and provides utilities.
/// </summary>
public class MapStem
{
    // Actual members:
    readonly string _stem;
    public readonly byte[] Bytes;
    public readonly MapAreaType AreaType;

    public byte AA => Bytes[0];
    public byte Area => Bytes[0];

    public byte BB => Bytes[1];
    public byte Block => Bytes[1];
    public byte TileX
    {
        get
        {
            if (AreaType is MapAreaType.Overworld or MapAreaType.OverworldDLC)
                return Bytes[1];
            throw new Exception($"Map {_stem} is not an overworld map tile.");
        }
    }
    
    public byte CC => Bytes[2];
    public byte TileZ
    {
        get 
        {
            if (AreaType is MapAreaType.Overworld or MapAreaType.OverworldDLC)
                return Bytes[2];
            throw new Exception($"Map {_stem} is not an overworld map tile.");
        }
    }
    
    public byte DD => Bytes[3];
    public byte Version => (byte)(Bytes[3] / 10);  // first digit of DD only
    public TileSize TileSize  // second digit of DD only
    {
        get
        {
            if (AreaType is MapAreaType.Overworld or MapAreaType.OverworldDLC)
                return (TileSize)(Bytes[3] % 10);
            throw new Exception($"Map {_stem} is not an overworld map tile.");
        }
    }

    public bool IsBaseOverworld => AreaType == MapAreaType.Overworld;
    public bool IsDLCOverworld => AreaType == MapAreaType.OverworldDLC;
    public bool IsAnyOverworld => AreaType is MapAreaType.Overworld or MapAreaType.OverworldDLC;

    public bool IsBaseGenericDungeon => 
        AreaType is MapAreaType.Catacombs or MapAreaType.Cave or MapAreaType.Tunnel
        or MapAreaType.DivineTower || _stem == "m18_00_00_00";  // includes Fringefolk Hero's Grave (Stranded Graveyard)

    public bool IsDLCGenericDungeon => 
        AreaType is MapAreaType.CatacombsDLC or MapAreaType.GaolDLC 
            or MapAreaType.RuinedForgeDLC or MapAreaType.CaveDLC;

    /// <summary>
    /// Hero's Graves are different from other Catacombs (e.g., no lever). Note that the DLC has none.
    /// </summary>
    public bool IsHerosGrave => HerosGraveCatacombs.Contains(_stem);

    /// <summary>
    /// Underground River areas all have AA == 12. (None in the DLC.)
    /// </summary>
    public bool IsUnderground => Bytes[0] == 12;
    
    /// <summary>
    /// Auto-detected path to map directory relative to 'Game' root directory.
    /// </summary>
    public string MapDirPath => $"map/{_stem[1..3]}/{_stem}";
    
    /// <summary>
    /// Auto-detected path to MSB file relative to 'Game' root directory.
    /// </summary>
    public string MSBPath => $"map/mapstudio/{_stem}.msb.dcx";
    
    /// <summary>
    /// Check if this map should have an EMEVD file.
    ///
    /// NOTE: EMEVD is NOT compulsory for any overworld map. Most small tiles have EMEVD, and some large tiles do
    /// (e.g. caravans). I don't think any vanilla medium tiles have EMEVD.
    /// </summary>
    public bool ShouldHaveEMEVD => !IsAnyOverworld && !MapsWithoutEMEVD.Contains(_stem);
    
    /// <summary>
    /// Offset of first event flag in this map, e.g. 1000_0000 or 60_4030_0000, from `[[EventFlagMan]+0x28]`.
    /// </summary>
    public int BaseEventFlagOffset => AreaType switch
    {
        MapAreaType.Overworld => GetOverworldMapBaseFlag(TileX, TileZ),
        _ => GetDungeonMapBaseFlag(_stem),
    };

    static readonly HashSet<string> HerosGraveCatacombs =
    [
        "m30_08_00_00",
        "m30_09_00_00",
        "m30_10_00_00",
        "m30_17_00_00",
        "m18_00_00_00",  // Fringefolk Hero's Grave (with Stranded Graveyard)
    ];

    /// <summary>
    /// Non-overworld maps that do not have or need EMEVD.
    /// </summary>
    static readonly HashSet<string> MapsWithoutEMEVD =
    [
        "m11_70_00_00",
        "m11_72_00_00",
        "m19_70_00_00",
    ];

    public MapStem(string mapStem)
    {
        _stem = mapStem;
        try
        {
            Bytes =
            [
                byte.Parse(mapStem[1..3]),
                byte.Parse(mapStem[4..6]),
                byte.Parse(mapStem[7..9]),
                byte.Parse(mapStem[10..12]),
            ];
        }
        catch (FormatException)
        {
            throw new FormatException($"Cannot parse four byte components of map stem: {mapStem}");
        }

        AreaType = Bytes[0] switch
        {
            >= 10 and <= 19 => MapAreaType.LegacyDungeonBase,
            >= 20 and <= 29 => MapAreaType.LegacyDungeonDLC,
            (byte)MapAreaType.Catacombs => MapAreaType.Catacombs,
            (byte)MapAreaType.Cave => MapAreaType.Cave,
            (byte)MapAreaType.Tunnel => MapAreaType.Tunnel,
            (byte)MapAreaType.DivineTower => MapAreaType.DivineTower,
            (byte)MapAreaType.ShunningGrounds => MapAreaType.ShunningGrounds,
            (byte)MapAreaType.RuinStrewnPrecipice => MapAreaType.RuinStrewnPrecipice,
            (byte)MapAreaType.Colosseum => MapAreaType.Colosseum,
            (byte)MapAreaType.Overworld => MapAreaType.Overworld,
            _ => MapAreaType.Unknown, // 255 (-1)
        };
    }

    /// <summary>
    /// Alternate constructor that takes the four bytes of a map stem.
    /// </summary>
    /// <param name="aa"></param>
    /// <param name="bb"></param>
    /// <param name="cc"></param>
    /// <param name="dd"></param>
    public MapStem(byte aa, byte bb, byte cc, byte dd) 
        : this($"m{aa:D2}_{bb:D2}_{cc:D2}_{dd:D2}") {}

    /// <summary>
    /// Alternate constructor that takes the four ints of a map stem. These are converted to bytes to ensure size.
    /// </summary>
    /// <param name="aa"></param>
    /// <param name="bb"></param>
    /// <param name="cc"></param>
    /// <param name="dd"></param>
    public MapStem(int aa, int bb, int cc, int dd) 
        : this((byte)aa, (byte)bb, (byte)cc, (byte)dd) {}

    /// <summary>
    /// Alternate constructor that takes a byte array of the four bytes of a map stem.
    /// </summary>
    /// <param name="mapBytes"></param>
    public MapStem(IReadOnlyList<byte> mapBytes) 
        : this($"m{mapBytes[0]:D2}_{mapBytes[1]:D2}_{mapBytes[2]:D2}_{mapBytes[3]:D2}") {}

    /// <summary>
    /// Alternate constructor that takes a path to a map file (e.g. MSB) and extracts the minimal stem.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static MapStem FromPath(string path)
    {
        return new MapStem(Path.GetFileName(path).Split('.')[0]);
    }

    public bool IsMap(string mapStem) => _stem == mapStem;

    public bool IsMap(byte[] mapBytes) => Bytes.SequenceEqual(mapBytes);
    
    public Vector3 GetTileWorldTranslation(byte originTileX = 46, byte originTileZ = 49)
    {
        if (AreaType != MapAreaType.Overworld)
            throw new Exception($"Map {_stem} is not an overworld map tile.");

        switch (TileSize)
        {
            case TileSize.Small:
            {
                int tileXOffset = TileX - originTileX;
                int tileZOffset = TileZ - originTileZ;
                return new Vector3(tileXOffset * 256f, 0, tileZOffset * 256f);
            }
            case TileSize.Medium:
            {
                // Get small SW tile.
                int smallTileX = TileX * 2;
                int smallTileZ = TileZ * 2;
                int tileXOffset = smallTileX - originTileX;
                int tileZOffset = smallTileZ - originTileZ;
                // Convert to that tile and account for 0.5 small tile origin offset.
                return new Vector3(tileXOffset * 256f - 128f, 0, tileZOffset * 256f - 128f);
            }
            case TileSize.Large:
            {
                // Get small SW tile.
                int smallTileX = TileX * 4;
                int smallTileZ = TileZ * 4;
                int tileXOffset = smallTileX - originTileX;
                int tileZOffset = smallTileZ - originTileZ;
                // Convert to that tile and account for 1.5 small tile origin offset.
                return new Vector3(tileXOffset * 256f - 384f, 0, tileZOffset * 256f - 384f);
            }
            default:
                throw new ArgumentOutOfRangeException($"Invalid tile size: {TileSize}.");
        }
    }

    /// <summary>
    /// Get base entity ID for this map. Format differs for dungeons vs. overworld.
    /// </summary>
    /// <returns></returns>
    public uint GetBaseEntityID()
    {
        // TODO: small tiles only?
        return uint.Parse(
            AreaType == MapAreaType.Overworld
                ? $"10{TileX:D2}{TileZ:D2}0000"  // overworld
                : $"{Area:D2}{Block:D2}0000");  // dungeons
    }
    
    public uint GetBaseFlagID()
    {
        // TODO: small tiles only?
        return uint.Parse(
            AreaType == MapAreaType.Overworld
                ? $"10{TileX:D2}{TileZ:D2}0000"  // overworld
                : $"{Area:D2}{Block:D2}0000");  // dungeons
    }
    
    #region Flag Offsets

    static int GetOverworldMapBaseFlag(int tileX, int tileZ)
    {
        if (tileX is < 32 or > 57)
            return -1;
        if (tileZ is < 30 or > 63)
            return -1;
        return OverworldTile3230Offset + (tileX - 32) * 40 * OverworldBlockSize + (tileZ - 30) * OverworldBlockSize;
    }
    
    static int GetDungeonMapBaseFlag(string stem)
    {
        if (stem == "m35_00_00_00")
            return SubterraneanShunningGroundsOffset;
        if (stem == "m39_20_00_00")
            return RuinStrewnPrecipiceOffset;
        
        if (stem.StartsWith("m1"))
        {
            int legacyBlockIndex = LegacyDungeonBlockIndices.GetValueOrDefault(stem, -1);
            if (legacyBlockIndex >= 0)
                return LegacyDungeonBaseOffset + legacyBlockIndex * DungeonBlockSize;
            return -1;
        }

        if (stem.StartsWith("m30"))
        {
            int catacombsIndex = CatacombsBlockIndices.IndexOf(stem);
            if (catacombsIndex >= 0)
                return CatacombsBaseOffset + catacombsIndex * DungeonBlockSize;
            return -1;
        }
        
        if (stem.StartsWith("m31"))
        {
            int caveIndex = CaveBlockIndices.IndexOf(stem);
            if (caveIndex >= 0)
                return CaveBaseOffset + caveIndex * DungeonBlockSize;
            return -1;
        }
        
        if (stem.StartsWith("m32"))
        {
            int tunnelIndex = TunnelBlockIndices.IndexOf(stem);
            if (tunnelIndex >= 0)
                return TunnelBaseOffset + tunnelIndex * DungeonBlockSize;
            return -1;
        }
        
        if (stem.StartsWith("m34"))
        {
            int divineTowerIndex = DivineTowerBlockIndices.IndexOf(stem);
            if (divineTowerIndex >= 0)
                return DivineTowerBaseOffset + divineTowerIndex * DungeonBlockSize;
            return -1;
        }

        return -1;
    }

    const int DungeonBlockSize = 0x465;
    const int OverworldBlockSize = 0x36B;
    
    const int OverworldTile3230Offset = 0x49B33;

    const int LegacyDungeonBaseOffset = 0x151BCF;
    /// <summary>
    /// Index of a Legacy Dungeon's event flag block in the event flag array.
    /// </summary>
    /// <returns></returns>
    static readonly Dictionary<string, int> LegacyDungeonBlockIndices = new()
    {
        ["m10_00_00_00"] = 0,
        ["m10_01_00_00"] = 1,
        ["m11_00_00_00"] = 4,
        ["m11_05_00_00"] = 5,
        ["m11_10_00_00"] = 6,
        ["m12_01_00_00"] = 11,
        ["m12_02_00_00"] = 12,
        ["m12_03_00_00"] = 13,
        ["m12_04_00_00"] = 14,
        ["m12_05_00_00"] = 15,
        ["m12_06_00_00"] = 16,
        ["m12_07_00_00"] = 17,
        ["m12_08_00_00"] = 18,
        ["m12_09_00_00"] = 19,
        ["m13_00_00_00"] = 20,
        ["m14_00_00_00"] = 23,
        ["m15_00_00_00"] = 26,
        ["m16_00_00_00"] = 29,
        ["m18_00_00_00"] = 35,
        ["m19_00_00_00"] = 38,
    };

    const int SubterraneanShunningGroundsOffset = 0x15CFFC;
    const int RuinStrewnPrecipiceOffset = 0x15DD2B;

    const int DivineTowerBaseOffset = 0x16237B;
    static readonly List<string> DivineTowerBlockIndices =
    [
        "m34_10_00_00",
        "m34_11_00_00",
        "m34_12_00_00",
        "m34_13_00_00",
        "m34_14_00_00",
        "m34_15_00_00",
    ];
    
    // NOTE: Catacombs has no missing block IDs from 0-20 and no unused memory blocks.
    const int CatacombsBaseOffset = 0x167B5F;
    static readonly List<string> CatacombsBlockIndices =
    [
        "m30_00_00_00",
        "m30_01_00_00",
        "m30_02_00_00",
        "m30_03_00_00",
        "m30_04_00_00",
        "m30_05_00_00",
        "m30_06_00_00",
        "m30_07_00_00",
        "m30_08_00_00",
        "m30_09_00_00",
        "m30_10_00_00",
        "m30_11_00_00",
        "m30_12_00_00",
        "m30_13_00_00",
        "m30_14_00_00",
        "m30_15_00_00",
        "m30_16_00_00",
        "m30_17_00_00",
        "m30_18_00_00",
        "m30_19_00_00",
        "m30_20_00_00",
    ];

    // NOTE: Cave blocks only omit SOME of the unused block IDs.
    const int CaveBaseOffset = 0x16FF35;
    static readonly List<string> CaveBlockIndices =
    [
        "m31_00_00_00",
        "m31_01_00_00",
        "m31_02_00_00",
        "m31_03_00_00",
        "m31_04_00_00",
        "m31_05_00_00",
        "m31_06_00_00",
        "m31_07_00_00",
        "m31_09_00_00",
        "m31_10_00_00",
        "m31_11_00_00",
        "m31_12_00_00",
        "",
        "",
        "m31_15_00_00",
        "m31_16_00_00",
        "m31_17_00_00",
        "m31_18_00_00",
        "m31_19_00_00",
        "m31_20_00_00",
        "m31_21_00_00",
        "m31_22_00_00",
    ];

    // Tunnels omit all unused block IDs.
    const int TunnelBaseOffset = 0x17830B;
    static readonly List<string> TunnelBlockIndices = 
    [
        "m32_00_00_00",
        "m32_01_00_00",
        "m32_02_00_00",
        "m32_04_00_00",
        "m32_05_00_00",
        "m32_07_00_00",
        "m32_08_00_00",
        "m32_11_00_00",
    ];
    #endregion
    
    #region String Conversion
    // Implicit casts to and from `string`.
    public static implicit operator string(MapStem stem) => stem._stem;
    public static implicit operator MapStem(string stem) => new(stem);

    // Explicit string conversion.
    public override string ToString() => _stem;

    // Equality just checks `_stem`.
    public override bool Equals(object? obj) => obj is MapStem stem && stem._stem == _stem;
    public override int GetHashCode() => _stem.GetHashCode();
    
    public static bool operator ==(MapStem? left, MapStem? right)
    {
        if (left is null && right is null)
            return true;
        if (left is null || right is null)
            return false;
        return left.Equals(right);
    }

    public static bool operator !=(MapStem? left, MapStem? right)
    {
        return !(left == right);
    }

    /// <summary>
    /// Wrapper for `Bytes[index]` to get that map stem component.
    /// </summary>
    /// <param name="index"></param>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public int this[int index]
    {
        get
        {
            if (index is < 0 or >= 4)
                throw new IndexOutOfRangeException($"Map stem index must be 0-3, not {index}.");
            return Bytes[index];
        }
    }

    /// <summary>
    /// Direct string indexing into the map stem.
    /// </summary>
    /// <param name="range"></param>
    public string this[Range range] => _stem[range];
    #endregion
}