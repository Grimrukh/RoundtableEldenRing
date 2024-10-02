using SoulsFormats;

namespace EldenRingBase.Params;

/// <summary>
/// Utility class for quickly loading and reading PARAMs, mostly for mod creation purposes.
/// </summary>
public static class ParamReader
{
    const string gameRegulationPath = @"C:\Steam\steamapps\common\ELDEN RING\Game\regulation.bin";

    static BND4? GameParam;

    /// <summary>
    /// Read and return given `paramType`, with its `PARAMDEF` applied.
    /// </summary>
    /// <param name="paramType"></param>
    /// <param name="reloadGameParam"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static PARAM ReadParamType(ParamType paramType, bool reloadGameParam = true)
    {
        string paramName = paramType.ToString();
        return ReadParamType(paramName, reloadGameParam);
    }

    public static PARAM ReadParamType(string paramName, bool reloadGameParam = true)
    {
        if (reloadGameParam || GameParam == null)
            GameParam = SFUtil.DecryptERRegulation(gameRegulationPath);

        string paramdefName = paramName.Split("_")[0];
        PARAMDEF paramdef = PARAMDEF.XmlDeserialize($"Resources/Defs/{paramdefName}.xml");
        
        BinderFile? paramFile = GameParam.Files.Find(
            x => x.Name == $@"N:\GR\data\Param\param\GameParam\{paramName}.param");
        if (paramFile == null)
            throw new Exception($"File '{paramName}' not found in regulation.");
        PARAM param = PARAM.Read(paramFile.Bytes);
        bool success = param.ApplyParamdefCarefully(paramdef);
        if (!success)
            throw new Exception($"Failed to apply PARAMDEF to {paramName} due to PARAM mismatch.");
        return param;
    }
    
    public static Dictionary<ParamType, (BinderFile paramFile, PARAM param)> ReadParamTypes(
    string gameDirectory, out BND4 gameParam, params ParamType[] paramTypes)
    {
        string regulationPath = Path.Combine(gameDirectory, "regulation.bin");
        gameParam = SFUtil.DecryptERRegulation(regulationPath);
        
        Dictionary<ParamType, (BinderFile paramFile, PARAM param)> loadedParams = new();
        
        foreach (ParamType paramType in paramTypes)
        {
            string paramName = paramType.ToString();  // enum names are valid
            string paramdefName = paramName.Split("_")[0];
            PARAMDEF paramdef = PARAMDEF.XmlDeserialize($"Resources/Defs/{paramdefName}.xml");
        
            BinderFile? paramFile = gameParam.Files.Find(
                x => x.Name == $@"N:\GR\data\Param\param\GameParam\{paramName}.param");
            if (paramFile == null)
                throw new Exception($"File '{paramName}' not found in regulation.");
            PARAM param = PARAM.Read(paramFile.Bytes);
            bool success = param.ApplyParamdefCarefully(paramdef);
            if (!success)
                throw new Exception($"Failed to apply PARAMDEF to {paramName} due to PARAM mismatch.");
            loadedParams[paramType] = (paramFile, param);
        }

        return loadedParams;
    }

    /// <summary>
    /// Get all XML Paramdefs, ignoring any errors (they only happen in useless ones).
    /// </summary>
    /// <returns></returns>
    public static List<PARAMDEF> GetParamdefs()
    {
        List<PARAMDEF> paramdefs = [];
        foreach (string xmlFile in Directory.GetFiles("Resources/Defs", "*.xml"))
        {
            try
            {
                paramdefs.Add(PARAMDEF.XmlDeserialize(xmlFile));
            }
            catch
            {
                // Ignore errors in useless defs.
            }
        }

        return paramdefs;
    }

    public static void WriteParamWrapper(string paramName)
    {
        string paramdefName = paramName.Split("_")[0];
        PARAMDEF paramdef = PARAMDEF.XmlDeserialize($"Resources/Defs/{paramdefName}.xml");
        WriteParamWrapper(paramdef);
    }
    
    /// <summary>
    /// Use Paramdef to write a 'ParamTypeName.cs' file that wraps the given `PARAM` with properly typed/named fields.
    /// </summary>
    /// <param name="paramdef"></param>
    public static void WriteParamWrapper(PARAMDEF paramdef)
    {
        using StreamWriter file = new($@"C:\Dark Souls\Projects\Elden Ring\EldenRingEldenRingBase\dotnet\EldenRingBase\Params\Wrappers\{paramdef.ParamType}.cs");

        file.WriteLine(
            $$"""
              using SoulsFormats;
                           
              namespace EldenRingBase.Params.Wrappers;

              public class {{paramdef.ParamType}}
              {
                  public PARAM? Param { get; }
                  public List<Row> Rows { get; }
                  
              """);
                
        // Row class.
        file.WriteLine(
            """
                public class Row(PARAM.Row row) : IParamRow
                {
                    public PARAM.Row InternalRow => row;
                
                    public int ID => row.ID;
            """);
        foreach (PARAMDEF.Field field in paramdef.Fields)
        {
            if (field.DisplayType == PARAMDEF.DefType.dummy8)
                continue;  // not exposed
            string type = GetDefDisplayTypeString(field.DisplayType);
            string name = field.InternalName;
            file.WriteLine();
            if (!string.IsNullOrEmpty(field.Description))
                file.WriteLine(
            $"        // {(string.IsNullOrEmpty(field.Description) ? field.Description : "Unknown.")}");
            file.WriteLine(
                $$"""
                          public {{type}} {{name}}
                          {
                              get => ({{type}})row["{{name}}"].Value;
                              set => row["{{name}}"].Value = value;
                          }
                  """);
        }
        
        file.WriteLine(
            $$"""
              
                      public object this[string fieldName]
                      {
                          get => row[fieldName].Value;
                          set => row[fieldName].Value = value;
                      }
                  }
                  
                  /// <summary>
                  /// Construct from a standard `PARAM` read from disk.
                  /// </summary>
                  public {{paramdef.ParamType}}(PARAM param)
                  {
                      if (param.AppliedParamdef == null)
                          throw new Exception("PARAM must have a PARAMDEF applied to be wrapped.");
                      Param = param;   
                      Rows = Param.Rows.Select(r => new Row(r)).ToList();
                  }
                  
                  /// <summary>
                  /// Construct from a `ParamInMemory`, which does not expose `PARAM` (row count must not changed).
                  /// </summary>
                  public {{paramdef.ParamType}}(ParamInMemory param)
                  {
                      Param = null;  // not accessible   
                      Rows = param.Rows.Select(r => new Row(r)).ToList();
                  }
                  
                  public Row? FindRow(int id)
                  {
                      return Rows.Find(r => r.ID == id);
                  }
              }
              """);
    }

    public static string GetDefDisplayTypeString(PARAMDEF.DefType defType)
    {
        return defType switch
        {
            PARAMDEF.DefType.s8 => "sbyte",
            PARAMDEF.DefType.u8 => "byte",
            PARAMDEF.DefType.s16 => "short",
            PARAMDEF.DefType.u16 => "ushort",
            PARAMDEF.DefType.s32 => "int",
            PARAMDEF.DefType.u32 => "uint",
            PARAMDEF.DefType.b32 => "int",
            PARAMDEF.DefType.f32 => "float",
            PARAMDEF.DefType.angle32 => "float",
            PARAMDEF.DefType.f64 => "double",
            PARAMDEF.DefType.dummy8 => "byte",
            PARAMDEF.DefType.fixstr => "string",
            PARAMDEF.DefType.fixstrW => "string",
            _ => "object",
        };
    }
}