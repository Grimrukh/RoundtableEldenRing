using SoulsFormats;
using RoundtableBase;

namespace RoundtableEldenRing.Params;

/// <summary>
/// Utility class for quickly loading, reading, and writing PARAMs from a 'regaulation.bin' file.
///
/// Can be constructed from a game directory path (from which `regulation.bin` is read) or from an existing `BND4`
/// regulation (e.g. `ParamManager.Regulation`) to use.
///
/// When a `PARAM` is loaded and retrieved, its container `BinderFile` is also returned so you can write the `PARAM`
/// back to that same `BinderFile` when ready. Then the `GameParam` stored in this class will contain the changes.
/// </summary>
public class GameParamWrapper
{
    public BND4 GameParam { get; }
    Dictionary<string, PARAMDEF> Paramdefs { get; }  // loaded ONCE on creation; keys are XML file stems

    /// <summary>
    /// Stems of all XML PARAMDEF resources.
    /// </summary>
    static readonly List<string> PARAMDEF_NAMES =
    [
        "ActionButtonParam",
        "AiAnimTblParam",
        "AIAttackParam",
        "AiOddsParam",
        "AiSoundParam",
        "AiStandardInfo",
        "AssetEnvironmentGeometryParam",
        "AssetMaterialSfxParam",
        "AssetModelSfxParam",
        "AtkParam",
        "AttackElementCorrectParam",
        "AutoCreateEnvSoundParam",
        "BaseChrSelectMenuParam",
        "BehaviorParam",
        "BonfireWarpParam",
        "BonfireWarpSubCategoryParam",
        "BonfireWarpTabParam",
        "BuddyParam",
        "BuddyStoneParam",
        "BudgetParam",
        "Bullet",
        "BulletCreateLimitParam",
        "CalcCorrectGraph",
        "CameraFadeParam",
        "Ceremony",
        "CharaInitParam",
        "CharMakeMenuListItemParam",
        "CharMakeMenuTopParam",
        "ChrActivateConditionParam",
        "ChrEquipModelParam",
        "ChrModelParam",
        "ClearCountCorrectParam",
        "CommonSystemParam",
        "CoolTimeParam",
        "CutsceneGparamTimeParam",
        "CutsceneGparamWeatherParam",
        "CutsceneMapIdParam",
        "CutSceneTextureLoadParam",
        "CutsceneTimezoneConvertParam",
        "CutsceneWeatherOverrideGparamConvertParam",
        "DecalParam",
        "DefaultKeyAssign",
        "DirectionCameraParam",
        "EnemyCommonParam",
        "EnemyStandardInfo",
        "EnvObjLotParam",
        "EquipMtrlSetParam",
        "EquipParamAccessory",
        "EquipParamCustomWeapon",
        "EquipParamGem",
        "EquipParamGoods",
        "EquipParamProtector",
        "EquipParamWeapon",
        "EventFlagUsageParam",
        "FaceParam",
        "FaceRangeParam",
        "FeTextEffectParam",
        "FinalDamageRateParam",
        "FootSfxParam",
        "GameAreaParam",
        "GameInfoParam",
        "GameSystemCommonParam",
        "Gconfig_AAQuality",
        "Gconfig_DecalQuality",
        "Gconfig_DOFQuality",
        "Gconfig_EffectQuality",
        "Gconfig_LightingQuality",
        "Gconfig_MotionBlurQuality",
        "Gconfig_RaytracingQuality",
        "Gconfig_ReflectionQuality",
        "Gconfig_ShaderQuality",
        "Gconfig_ShadowQuality",
        "Gconfig_SSAOQuality",
        "Gconfig_TextureFilterQuality",
        "Gconfig_VolumetricEffectQuality",
        "Gconfig_WaterQuality",
        "GestureParam",
        "GparamGridRegionInfo",
        "GparamRefSettings",
        "GraphicsCommonParam",
        "GraphicsConfig",
        "GrassLodRangeParam",
        "GrassMapSettings",
        "GrassTypeParam",
        "HitEffectSeParam",
        "HitEffectSfxConceptParam",
        "HitEffectSfxParam",
        "HitMtrlParam",
        "HPEstusFlaskRecoveryParam",
        "ItemLotParam",
        "KeyAssignMenuItemParam",
        "KeyAssignParam",
        "KnockBackParam",
        "KnowledgeLoadScreenItemParam",
        "LegacyDistantViewPartsReplaceParam",
        "LoadBalancerDrawDistScaleParam",
        "LoadBalancerNewDrawDistScaleParam",
        "LoadBalancerParam",
        "LockCamParam",
        "Magic",
        "MapDefaultInfoParam",
        "MapGdRegionDrawParam",
        "MapGdRegionInfoParam",
        "MapGridCreateHeightDetailLimitInfo",
        "MapGridCreateHeightLimitInfoParam",
        "MapMimicryEstablishmentParam",
        "MapNameTexParam",
        "MapNameTexParam_m61",
        "MapPieceTexParam",
        "MapPieceTexParam_m61",
        "MaterialExParam",
        "MenuColorTableParam",
        "MenuCommonParam",
        "MenuOffscrRendParam",
        "MenuPropertyLayoutParam",
        "MenuPropertySpecParam",
        "MenuValueTableParam",
        "MimicryEstablishmentTexParam",
        "MimicryEstablishmentTexParam_m61",
        "MissileParam",
        "ModelSfxParam",
        "MoveParam",
        "MultiHPEstusFlaskBonusParam",
        "MultiPlayCorrectionParam",
        "MultiSoulBonusRateParam",
        "NetworkAreaParam",
        "NetworkMsgParam",
        "NetworkParam",
        "NpcAiActionParam",
        "NpcAiBehaviorProbabilityParam",
        "NpcParam",
        "NpcThinkParam",
        "ObjActParam",
        "ObjectMaterialSfxParam",
        "ObjectParam",
        "PartsDrawParam",
        "PerformanceCheckParam",
        "PhantomParam",
        "PlayerCommonParam",
        "PlayRegionParam",
        "PostureControlParam_Gender",
        "PostureControlParam_Pro",
        "PostureControlParam_WepLeft",
        "PostureControlParam_WepRight",
        "RandomAppearEditParam",
        "RandomAppearParam",
        "ReinforceParamProtector",
        "ReinforceParamWeapon",
        "ResistCorrectParam",
        "ReverbAuxSendBusParam",
        "RideParam",
        "RoleParam",
        "RollingObjLotParam",
        "RuntimeBoneControlParam",
        "SeActivationRangeParam",
        "SeMaterialConvertParam",
        "SfxBlockResShareParam",
        "ShopLineupParam",
        "SignPuddleParam",
        "SignPuddleSubCategoryParam",
        "SignPuddleTabParam",
        "SoundAssetSoundObjEnableDistParam",
        "SoundAutoEnvSoundGroupParam",
        "SoundAutoReverbEvaluationDistParam",
        "SoundAutoReverbSelectParam",
        "SoundChrPhysicsSeParam",
        "SoundCommonIngameParam",
        "SoundCommonSystemParam",
        "SoundCutsceneParam",
        "SpeedtreeParam",
        "SpEffectParam",
        "SpEffectSetParam",
        "SpEffectVfx",
        "SwordArtsParam",
        "TalkParam",
        "ThrowDirectionSfxParam",
        "ThrowParam",
        "ToughnessParam",
        "TutorialParam",
        "WaypointParam",
        "WeatherAssetCreateParam",
        "WeatherAssetReplaceParam",
        "WeatherLotParam",
        "WeatherLotTexParam",
        "WeatherLotTexParam_m61",
        "WeatherParam",
        "WepAbsorpPosParam",
        "WetAspectParam",
        "WhiteSignCoolTimeParam",
        "WorldMapLegacyConvParam",
        "WorldMapPieceParam",
        "WorldMapPlaceNameParam",
        "WorldMapPointParam",
        "WwiseValueToStrConvertParamFormat",
    ];

    public GameParamWrapper(string regulationPath)
    {
        GameParam = SFUtil.DecryptERRegulation(regulationPath);
        Paramdefs = GetParamdefs();
    }
    
    public GameParamWrapper(BND4 gameParam)
    {
        GameParam = gameParam;
        Paramdefs = GetParamdefs();
    }

    /// <summary>
    /// Read and return both the `BinderFile` and `PARAM` for the given `paramType`, with its `PARAMDEF` applied.
    ///
    /// Just calls the string overload with the enum name.
    /// </summary>
    /// <param name="paramType"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public (BinderFile paramFile, PARAM param) ReadParamType(ParamType paramType)
    {
        string paramName = paramType.ToString();
        return ReadParamType(paramName);
    }

    /// <summary>
    /// Read and return both the `BinderFile` and `PARAM` for the given `paramName`, with its `PARAMDEF` applied.
    /// </summary>
    /// <param name="paramName"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public (BinderFile paramFile, PARAM param) ReadParamType(string paramName)
    {
        string paramdefName = paramName.Split("_")[0];
            
        PARAMDEF? paramdef = Paramdefs[paramdefName];
        if (paramdef == null)
            throw new Exception($"No PARAMDEF '{paramdefName}' found for PARAM '{paramName}'.");
        
        (string dlcPath, string basePath) = GetParamBNDPaths(paramName);
        BinderFile? paramFile = GameParam.Files.Find(x => x.Name == dlcPath || x.Name == basePath);
        if (paramFile == null)
        {
            // Print all GameParam file names for debugging.
            foreach (BinderFile file in GameParam.Files)
                Logging.Debug($"GameParam file: {file.Name}");
            throw new Exception($"File '{paramName}.param' not found in regulation. See debug log output for full list.");
        }
        
        PARAM param = PARAM.Read(paramFile.Bytes);
        bool success = param.ApplyParamdefCarefully(paramdef);
        if (!success)
            throw new Exception($"Failed to apply PARAMDEF to {paramName} due to PARAM mismatch.");
        return (paramFile, param);
    }
    
    public Dictionary<ParamType, (BinderFile paramFile, PARAM param)> ReadParamTypes(params ParamType[] paramTypes)
    {
        Dictionary<ParamType, (BinderFile paramFile, PARAM param)> loadedParams = new();
        
        foreach (ParamType paramType in paramTypes)
        {
            string paramName = paramType.ToString();  // enum names are valid
            string paramdefName = paramName.Split("_")[0];
            PARAMDEF? paramdef = Paramdefs[paramdefName];
            if (paramdef == null)
                throw new Exception($"No PARAMDEF '{paramdefName}' found for PARAM '{paramName}'.");
        
            (string dlcPath, string basePath) = GetParamBNDPaths(paramName);
            BinderFile? paramFile = GameParam.Files.Find(x => x.Name == dlcPath || x.Name == basePath);
            if (paramFile == null)
            {
                // Print all GameParam file names for debugging.
                foreach (BinderFile file in GameParam.Files)
                    Logging.Debug($"GameParam file: {file.Name}");
                throw new Exception($"File '{paramName}' not found in regulation. See debug log output for full list.");
            }
            PARAM param = PARAM.Read(paramFile.Bytes);
            bool success = param.ApplyParamdefCarefully(paramdef);
            if (!success)
                throw new Exception($"Failed to apply PARAMDEF to {paramName} due to PARAM mismatch.");
            loadedParams[paramType] = (paramFile, param);
        }

        return loadedParams;
    }

    /// <summary>
    /// Get all XML Paramdefs by their XML stem, ignoring any errors (they only happen in useless ones).
    /// </summary>
    /// <returns></returns>
    public static Dictionary<string, PARAMDEF> GetParamdefs()
    {
        Dictionary<string, PARAMDEF> paramdefs = new();
        foreach (string xmlStem in PARAMDEF_NAMES)
        {
            try
            {
                // NOTE: This also ensures there are no XML ParamType duplicates.
                string xml = ResourceManager.GetEmbeddedResource($"Defs.{xmlStem}.xml");
                paramdefs[xmlStem] = PARAMDEF.XmlDeserializeString(xml);
                // Logging.Debug($"IsGameLoaded PARAMDEF from XML: {xmlStem}");
            }
            catch
            {
                // Ignore errors in useless defs.
                Logging.Error($"Fatal error occured when trying to load PARAMDEF from XML: {xmlStem}");
                throw;
            }
        }

        return paramdefs;
    }

    public static void WriteParamWrapper(string paramName)
    {
        string paramdefName = paramName.Split("_")[0];
        string paramdefXml = ResourceManager.GetEmbeddedResource($"Defs/{paramdefName}.xml");
        PARAMDEF paramdef = PARAMDEF.XmlDeserializeString(paramdefXml);
        WriteParamWrapper(paramdef);
    }
    
    /// <summary>
    /// Use Paramdef to write a 'ParamTypeName.cs' file that wraps the given `PARAM` with properly typed/named fields.
    /// </summary>
    /// <param name="paramdef"></param>
    public static void WriteParamWrapper(PARAMDEF paramdef)
    {
        using StreamWriter file = new($@"Params\Wrappers\{paramdef.ParamType}.cs");

        file.WriteLine(
            $$"""
              using SoulsFormats;
                           
              namespace RoundtableEldenRing.Params.Wrappers;

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
                  /// Construct from a `MemoryPARAM`, which does not expose `PARAM` (row count must not changed).
                  /// </summary>
                  public {{paramdef.ParamType}}(MemoryPARAM param)
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

    /// <summary>
    /// Two possible `param` file paths: '.../GameParam/merged/DLC02' or just '.../GameParam'.
    /// If both somehow exist (not a vanilla file), DLC will be preferred.
    /// </summary>
    /// <param name="paramName"></param>
    /// <returns></returns>
    static (string dlcPath, string basePath) GetParamBNDPaths(string paramName)
    {
        string dlcPath = $@"N:\GR\data\Param\param\GameParam\merged\DLC02\{paramName}.param";
        string basePath = $@"N:\GR\data\Param\param\GameParam\{paramName}.param";
        return (dlcPath, basePath);
    }
}