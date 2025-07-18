﻿using System.Numerics;

namespace RoundtableEldenRing;

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
    // Lists of 'major' legacy dungeons in base game and DLC, for use with `IsMajorLegacyDungeon(Any|Base|DLC)` props.
    // Excludes underground rivers, special generic dungeons like Stranded Graveyard, and arenas like Stone Platform.
    static readonly HashSet<string> MAJOR_LEGACY_DUNGEONS_BASE = [
        "m10_00_00_00",  // Stormveil Castle
        "m11_00_00_00",  // Leyndell, Royal Capital
        "m11_05_00_00",  // Leyndell, Ashen Capital
        "m12_05_00_00",  // Mohgwyn Palace
        "m13_00_00_00",  // Crumbling Farum Azula
        "m14_00_00_00",  // Academy of Raya Lucaria
        "m15_00_00_00",  // Miquella's Haligtree
        "m16_00_00_00",  // Volcano Manor
    ];
    static readonly HashSet<string> MAJOR_LEGACY_DUNGEONS_DLC = [
        "m20_00_00_00",  // Belurat, Tower Settement
        "m20_01_00_00",  // Enir-Ilim
        "m21_00_00_00",  // Shadow Keep
        "m21_01_00_00",  // Specimen Storehouse
        "m22_00_00_00",  // Stone Coffin Fissure
        "m28_00_00_00",  // Midra's Manse
    ];
    
    // Actual members:
    readonly string stem;
    public readonly byte[] Bytes;
    public readonly MapAreaType AreaType;
    
    // All other fields are computed properties.

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
            throw new Exception($"Map {stem} is not an overworld map tile.");
        }
    }
    
    public byte CC => Bytes[2];
    public byte TileZ
    {
        get 
        {
            if (AreaType is MapAreaType.Overworld or MapAreaType.OverworldDLC)
                return Bytes[2];
            throw new Exception($"Map {stem} is not an overworld map tile.");
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
            throw new Exception($"Map {stem} is not an overworld map tile.");
        }
    }
    
    public bool IsDLC => 
        AreaType is MapAreaType.OverworldDLC
        || AA is >= 20 and <= 29  // legacy dungeons 
        || AA is >= 40 and <= 49;  // generic dungeons 

    public bool IsOverworldBase => AreaType == MapAreaType.Overworld;
    public bool IsOverworldDLC => AreaType == MapAreaType.OverworldDLC;
    public bool IsOverworldAny => AreaType is MapAreaType.Overworld or MapAreaType.OverworldDLC;

    public bool IsMajorLegacyDungeonBase => MAJOR_LEGACY_DUNGEONS_BASE.Contains(stem);
    public bool IsMajorLegacyDungeonDLC => MAJOR_LEGACY_DUNGEONS_DLC.Contains(stem);
    public bool IsMajorLegacyDungeonAny => IsMajorLegacyDungeonBase || IsMajorLegacyDungeonDLC;

    public bool IsGenericDungeonBase => 
        AreaType is MapAreaType.Catacombs or MapAreaType.Cave or MapAreaType.Tunnel
        or MapAreaType.DivineTower || stem == "m18_00_00_00";  // includes Fringefolk Hero's Grave (Stranded Graveyard)
    public bool IsGenericDungeonDLC => AreaType is >= MapAreaType.CatacombsDLC and <= MapAreaType.CaveDLC;
    public bool IsGenericDungeonAny => IsGenericDungeonBase || IsGenericDungeonDLC;

    /// <summary>
    /// Hero's Graves are different from other Catacombs (e.g., no lever). Note that the DLC has none.
    /// </summary>
    public bool IsHerosGrave => HEROS_GRAVE_CATACOMBS.Contains(stem);

    /// <summary>
    /// Underground River areas all have AA == 12. (None in the DLC.)
    /// </summary>
    public bool IsUnderground => Bytes[0] == 12;
    
    /// <summary>
    /// Auto-detected path to map directory relative to 'Game' root directory.
    /// </summary>
    public string MapDirPath => $"map/{stem[1..3]}/{stem}";
    
    /// <summary>
    /// Auto-detected path to MSB file relative to 'Game' root directory.
    /// </summary>
    public string MSBPath => $"map/mapstudio/{stem}.msb.dcx";
    
    /// <summary>
    /// Check if this map should have an EMEVD file.
    ///
    /// NOTE: EMEVD is NOT compulsory for any overworld map. Most small tiles have EMEVD, and some large tiles do
    /// (e.g. caravans). I don't think any vanilla medium tiles have EMEVD.
    /// </summary>
    public bool ShouldHaveEMEVD => !IsOverworldAny && !MAPS_WITHOUT_EMEVD.Contains(stem);
    
    /// <summary>
    /// Offset of first event flag in this map, e.g. 1000_0000 or 60_4030_0000, from `[[EventFlagMan]+0x28]`.
    /// </summary>
    public int BaseEventFlagOffset => AreaType switch
    {
        MapAreaType.Overworld => GetOverworldMapBaseFlag(TileX, TileZ),
        _ => GetDungeonMapBaseFlag(stem),
    };

    static readonly HashSet<string> HEROS_GRAVE_CATACOMBS =
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
    static readonly HashSet<string> MAPS_WITHOUT_EMEVD =
    [
        "m11_70_00_00",
        "m11_72_00_00",
        "m19_70_00_00",
    ];

    public MapStem(string mapStem)
    {
        stem = mapStem;
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
            
            (byte)MapAreaType.CatacombsDLC => MapAreaType.CatacombsDLC,
            (byte)MapAreaType.GaolDLC => MapAreaType.GaolDLC,
            (byte)MapAreaType.RuinedForgeDLC => MapAreaType.RuinedForgeDLC,
            (byte)MapAreaType.CaveDLC => MapAreaType.CaveDLC,
            
            (byte)MapAreaType.Colosseum => MapAreaType.Colosseum,
            
            (byte)MapAreaType.Overworld => MapAreaType.Overworld,
            (byte)MapAreaType.OverworldDLC => MapAreaType.OverworldDLC,
            
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

    public bool IsMap(string mapStem) => stem == mapStem;

    public bool IsMap(byte[] mapBytes) => Bytes.SequenceEqual(mapBytes);
    
    public Vector3 GetTileWorldTranslation(byte originTileX = 46, byte originTileZ = 49)
    {
        if (AreaType != MapAreaType.Overworld)
            throw new Exception($"Map {stem} is not an overworld map tile.");

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
        return OVERWORLD_TILE3230_OFFSET + (tileX - 32) * 40 * OVERWORLD_BLOCK_SIZE + (tileZ - 30) * OVERWORLD_BLOCK_SIZE;
    }
    
    static int GetDungeonMapBaseFlag(string stem)
    {
        if (stem == "m35_00_00_00")
            return SUBTERRANEAN_SHUNNING_GROUNDS_OFFSET;
        if (stem == "m39_20_00_00")
            return RUIN_STREWN_PRECIPICE_OFFSET;
        
        if (stem.StartsWith("m1"))
        {
            int legacyBlockIndex = LEGACY_DUNGEON_BLOCK_INDICES.GetValueOrDefault(stem, -1);
            if (legacyBlockIndex >= 0)
                return LEGACY_DUNGEON_BASE_OFFSET + legacyBlockIndex * DUNGEON_BLOCK_SIZE;
            return -1;
        }

        if (stem.StartsWith("m30"))
        {
            int catacombsIndex = CATACOMBS_BLOCK_INDICES.IndexOf(stem);
            if (catacombsIndex >= 0)
                return CATACOMBS_BASE_OFFSET + catacombsIndex * DUNGEON_BLOCK_SIZE;
            return -1;
        }
        
        if (stem.StartsWith("m31"))
        {
            int caveIndex = CAVE_BLOCK_INDICES.IndexOf(stem);
            if (caveIndex >= 0)
                return CAVE_BASE_OFFSET + caveIndex * DUNGEON_BLOCK_SIZE;
            return -1;
        }
        
        if (stem.StartsWith("m32"))
        {
            int tunnelIndex = TUNNEL_BLOCK_INDICES.IndexOf(stem);
            if (tunnelIndex >= 0)
                return TUNNEL_BASE_OFFSET + tunnelIndex * DUNGEON_BLOCK_SIZE;
            return -1;
        }
        
        if (stem.StartsWith("m34"))
        {
            int divineTowerIndex = DIVINE_TOWER_BLOCK_INDICES.IndexOf(stem);
            if (divineTowerIndex >= 0)
                return DIVINE_TOWER_BASE_OFFSET + divineTowerIndex * DUNGEON_BLOCK_SIZE;
            return -1;
        }

        return -1;
    }

    const int DUNGEON_BLOCK_SIZE = 0x465;
    const int OVERWORLD_BLOCK_SIZE = 0x36B;
    
    const int OVERWORLD_TILE3230_OFFSET = 0x49B33;

    const int LEGACY_DUNGEON_BASE_OFFSET = 0x151BCF;
    /// <summary>
    /// Index of a Legacy Dungeon's event flag block in the event flag array.
    /// </summary>
    /// <returns></returns>
    static readonly Dictionary<string, int> LEGACY_DUNGEON_BLOCK_INDICES = new()
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

    const int SUBTERRANEAN_SHUNNING_GROUNDS_OFFSET = 0x15CFFC;
    const int RUIN_STREWN_PRECIPICE_OFFSET = 0x15DD2B;

    const int DIVINE_TOWER_BASE_OFFSET = 0x16237B;
    static readonly List<string> DIVINE_TOWER_BLOCK_INDICES =
    [
        "m34_10_00_00",
        "m34_11_00_00",
        "m34_12_00_00",
        "m34_13_00_00",
        "m34_14_00_00",
        "m34_15_00_00",
    ];
    
    // NOTE: Catacombs has no missing block IDs from 0-20 and no unused memory blocks.
    const int CATACOMBS_BASE_OFFSET = 0x167B5F;
    static readonly List<string> CATACOMBS_BLOCK_INDICES =
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
    const int CAVE_BASE_OFFSET = 0x16FF35;
    static readonly List<string> CAVE_BLOCK_INDICES =
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
    const int TUNNEL_BASE_OFFSET = 0x17830B;
    static readonly List<string> TUNNEL_BLOCK_INDICES = 
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
    public static implicit operator string(MapStem stem) => stem.stem;
    public static implicit operator MapStem(string stem) => new(stem);

    // Explicit string conversion.
    public override string ToString() => stem;

    // Equality just checks `stem`.
    public override bool Equals(object? obj) => obj is MapStem s && s.stem == stem;
    public override int GetHashCode() => stem.GetHashCode();
    
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
    public string this[Range range] => stem[range];
    #endregion
}