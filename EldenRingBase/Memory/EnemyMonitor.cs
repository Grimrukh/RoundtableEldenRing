using PropertyHook;
using EldenRingBase.GameHook;

namespace EldenRingBase.Memory;


/// <summary>
/// Checks memory to monitor and manipulate all loaded game 'enemies' (really, all characters).
/// </summary>
public class EnemyMonitor : GameMonitor
{
    // In 1.16, these offsets increased by exactly 0x8. Hoping they don't change again!
    const int EnemyInsStartOffset = 0x1F1B8;
    const int EnemyInsEndOffset = 0x1F1C0;
    
    protected override int UpdateInterval => 500;

    EldenRingHook Hook { get; }

    IntPtr CharacterListStartOffset => Hook.WorldChrMan.ReadIntPtr(EnemyInsStartOffset);
    IntPtr CharacterListEndOffset => Hook.WorldChrMan.ReadIntPtr(EnemyInsEndOffset);
    PHPointer? EnemyInsArray { get; set; }

    readonly List<EnemyIns> _enemies = [];
    /// <summary>
    /// List of all enemies found on memory on this update.
    ///
    /// Retrieval first checks if `EnemyInsArray` is still valid.
    /// </summary>
    public List<EnemyIns> Enemies => EnemyInsArray is { IsNonZero: true } ? _enemies : [];
    
    public Dictionary<string, (string modelName, uint entityID)> LivingEnemies { get; } = new();

    /// <summary>
    /// Event that is invoked whenever an enemy "dies".
    ///
    /// In order to "die", an enemy must first be alive for ONE SECOND, then have their HP drop to zero.
    /// </summary>
    public event Action<(string name, string modelName, uint entityID, MapStem? mapStem)>? OnEnemyDeath;
    
    /// <summary>
    /// Tracks how long an enemy has been alive, by name, which is unique thanks to the '[BB CC DD]' suffix added to it.
    ///
    /// Once an enemy reaches one second, they are added to `LivingEnemies`. Once there, they will be removed as SOON as
    /// their HP hits zero on a single frame, and this will trigger the `OnEnemyDeath` event with their name, model
    /// name, and entity ID.
    ///
    /// This is done to prevent us from seeing enemies that are only alive for a split second on map load before being
    /// despawned by EMEVD.
    /// </summary>
    Dictionary<string, float> EnemyAliveSinceTime { get; } = new();

    public EnemyMonitor(EldenRingHook hook)
    {
        Hook = hook;

        Hook.OnGameLoaded += OnLoaded;
        Hook.OnGameUnloaded += OnUnloaded;
        
        // Check if game is already loaded.
        if (Hook.Loaded)
            OnLoaded(null, null);
    }
    
    void OnLoaded(object? sender, EventArgs? eventArgs)
    {
        EnemyInsArray = Hook.CreateChildPointer(Hook.WorldChrMan, EnemyInsStartOffset);
    }
    
    void OnUnloaded(object? sender, EventArgs? eventArgs)
    {
        EnemyInsArray = null;
    }
    
    public EnemyIns? FindEnemyHandle(int handle)
    {
        return Enemies.FirstOrDefault(enemy => enemy.LocalHandle == handle);
    }

    public EnemyIns? FindEnemyName(string name)
    {
        return Enemies.FirstOrDefault(enemy => enemy.Name == name);
    }

    public EnemyIns? FindEnemyEntityID(int entityID)
    {
        if (entityID <= 0)
        {
            Console.WriteLine($"Invalid entity ID: {entityID}. Must be positive (non-zero).");
            return null;
        }
        return Enemies.FirstOrDefault(enemy => enemy.EntityID == entityID);
    }

    public IEnumerable<EnemyIns> FindEnemiesWithModel(string modelName)
    {
        if (modelName is not ['c', _, _, _, _] || !int.TryParse(modelName[1..], out _))
        {
            Console.WriteLine($"Invalid enemy model name: {modelName}. Must be 'c' followed by four digits.");
            return [];
        }
        return Enemies.Where(enemy => enemy.ModelName == modelName);
    }

    public IEnumerable<EnemyIns> FindEnemiesWithModel(int modelID)
    {
        if (modelID is < 0 or > 9999)
        {
            Console.WriteLine($"Invalid enemy model ID: {modelID}. Must be four or less digits.");
            return [];
        }
        return FindEnemiesWithModel($"c{modelID:D4}");
    }

    /// <summary>
    /// Get number of loaded characters.
    ///
    /// Same as checking `Count` of character pointer list, but doesn't need to actually read the pointers.
    /// </summary>
    /// <returns></returns>
    int GetEnemyInsCount()
    {
        // Each list entry is 8 bytes, so we divide the difference by 8.
        return (int)(CharacterListEndOffset.ToInt64() - CharacterListStartOffset.ToInt64()) / 8;
    }

    protected override bool OnUpdate(long updateTime, long gameLoadedTime)
    {
        _enemies.Clear();
        if (gameLoadedTime < 0 || EnemyInsArray is not { IsNonZero: true })
        {
            // Game is not loaded. Lose track of all enemy states.
            LivingEnemies.Clear();
            EnemyAliveSinceTime.Clear();
            return true;
        }

        try
        {
            int count = GetEnemyInsCount();
            // Every 8 bytes is an address.
            for (int i = 0; i < count; i++)
            {
                EnemyIns enemy = new(Hook.CreateChildPointer(EnemyInsArray, i * 8));
                _enemies.Add(enemy);
                if (enemy.CurrentHP > 0)
                {
                    if (LivingEnemies.ContainsKey(enemy.Name))
                    {
                        // Enemy is still alive. Nothing else to do.
                        continue;
                    }

                    // Enemy has not been alive long enough yet.
                    if (EnemyAliveSinceTime.TryAdd(enemy.Name, updateTime))
                    {
                        // Enemy seen to be alive for the first time.
                        continue;
                    }

                    if (updateTime >= EnemyAliveSinceTime[enemy.Name] + 1)
                    {
                        // Enemy has been alive for ONE SECOND continuously. Mark it as alive.
                        LivingEnemies[enemy.Name] = (enemy.ModelName, enemy.EntityID);
                        // Logging.DebugPrint($"Enemy {i} '{enemy.Name}' officially ALIVE (map {enemy.MapStem}). Last HP = {enemy.CurrentHP}");
                    }
                }
                else
                {
                    // Enemy is dead.
                    // Logging.DebugPrint($"Enemy '{enemy.Name}' seen with zero HP.");
                    EnemyAliveSinceTime.Remove(enemy.Name);
                    if (!LivingEnemies.ContainsKey(enemy.Name))
                        continue;

                    // Official enemy death event: enemy was alive for >= 1 second, then died.
                    // Logging.DebugPrint($"--> Enemy {i} '{enemy.Name}' has DIED (map {enemy.MapStem}). HP = {enemy.CurrentHP}");
                    OnEnemyDeath?.Invoke((enemy.Name, enemy.ModelName, enemy.EntityID, enemy.MapStem));
                    LivingEnemies.Remove(enemy.Name);
                }
            }
        }
        catch (NullReferenceException)
        {
            // TODO: pointer died while being resolved
            _enemies.Clear();
            LivingEnemies.Clear();
            EnemyAliveSinceTime.Clear();
            return true;
        }

        // Logging.DebugPrint($"Enemy count: {Enemies.Count}");

        return true;
    }
}