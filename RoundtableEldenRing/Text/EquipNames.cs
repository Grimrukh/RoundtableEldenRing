namespace RoundtableEldenRing.Text;

public static class EquipNames
{
    public static Dictionary<uint, string> WeaponNames { get; } = ResourceManager.GetEmbeddedJSON<uint, string>("WeaponNames.json");
    public static Dictionary<uint, string> ArmorNames { get; } = ResourceManager.GetEmbeddedJSON<uint, string>("ArmorNames.json");
    public static Dictionary<uint, string> TalismanNames { get; } = ResourceManager.GetEmbeddedJSON<uint, string>("TalismanNames.json");
    public static Dictionary<uint, string> GoodNames { get; } = ResourceManager.GetEmbeddedJSON<uint, string>("GoodNames.json");
    public static Dictionary<uint, string> AshOfWarNames { get; } = ResourceManager.GetEmbeddedJSON<uint, string>("AshOfWarNames.json");

    public static Dictionary<string, uint> WeaponIDs { get; } = BuildInverseDictionary(WeaponNames);
    public static Dictionary<string, uint> ArmorIDs { get; } = BuildInverseDictionary(ArmorNames);
    public static Dictionary<string, uint> TalismanIDs { get; } = BuildInverseDictionary(TalismanNames);
    public static Dictionary<string, uint> GoodIDs { get; } = BuildInverseDictionary(GoodNames);
    public static Dictionary<string, uint> AshOfWarIDs { get; } = BuildInverseDictionary(AshOfWarNames);

    static Dictionary<string, uint> BuildInverseDictionary(Dictionary<uint, string> idsToNames)
    {
        Dictionary<string, uint> namesToIds = new();
        foreach ((uint id, string name) in idsToNames)
            namesToIds.TryAdd(name, id);
        return namesToIds;
    }
}