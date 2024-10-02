using System.Reflection;
using Newtonsoft.Json;

namespace EldenRingBase;

public static class ResourceManager
{
    /// <summary>
    /// Load and return a text resource as a `string`.
    /// </summary>
    /// <param name="resourceName"></param>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public static string GetEmbeddedResource(string resourceName)
    {
        if (!resourceName.StartsWith("EldenRingBase.Resources."))
            resourceName = "EldenRingBase.Resources." + resourceName;
        var assembly = Assembly.GetCallingAssembly();
        using Stream? stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
            throw new NullReferenceException(
                $"Could not find embedded resource '{resourceName}' in assembly {Assembly.GetCallingAssembly().GetName()}.");
        using StreamReader reader = new(stream);
        return reader.ReadToEnd();
    }
    
    /// <summary>
    /// Load and return a binary resource as a `MemoryStream`.
    /// </summary>
    /// <param name="resourceName"></param>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public static MemoryStream GetEmbeddedBinaryResource(string resourceName)
    {
        if (!resourceName.StartsWith("EldenRingBase.Resources."))
            resourceName = "EldenRingBase.Resources." + resourceName;
        var assembly = Assembly.GetCallingAssembly();
        using Stream? stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
            throw new NullReferenceException(
                $"Could not find embedded resource '{resourceName}' in assembly {Assembly.GetCallingAssembly().GetName()}.");
        MemoryStream ms = new();
        stream.CopyTo(ms);
        ms.Position = 0;
        return ms;
    }

    /// <summary>
    /// Load and return a text JSON resource as a dictionary of the given key/value types.
    /// </summary>
    /// <param name="resourceName"></param>
    /// <param name="converters"></param>
    /// <typeparam name="KT"></typeparam>
    /// <typeparam name="VT"></typeparam>
    /// <returns></returns>
    public static Dictionary<KT, VT> GetEmbeddedJSON<KT, VT>(string resourceName, params JsonConverter[] converters) where KT : notnull
    {
        string json = GetEmbeddedResource(resourceName);
        return JsonConvert.DeserializeObject<Dictionary<KT, VT>>(json, converters) 
               ?? new Dictionary<KT, VT>();
    }
}