using EldenRingBase.GameHook;
using PropertyHook;

namespace EldenRingBase.Memory;


/// <summary>
/// TODO: Still to come:
///     - Check what equipment and spells player currently has equipped/attuned (for Follower outfitting).
///     - When player HP hits zero, scan nearby enemies and look for one doing an attack animation. 'Player Vendetta'
///     classes roll for attaching to that enemy (choose randomly from multiple enemy and/or vendetta candidates).
/// </summary>
public class PlayerManager
{
    EldenRingHook Hook { get; }

    const string GetRunesFuncAOB = "44 8B 49 6C 45 33 DB";
    PHPointer GetRunesFunc { get; }
    
    public EnemyIns? PlayerIns { get; private set; }

    public ChrAsm? PlayerAsm { get; private set; }
    
    public int PlayerHP
    {
        get => PlayerIns?.ModuleBase.EnemyData.CurrentHP ?? -1;
        set
        {
            if (PlayerIns != null) 
                PlayerIns.ModuleBase.EnemyData.CurrentHP = value;
        }
    }

    public bool IsGameLoaded => PlayerHP >= 0;
    public bool IsPlayerAlive => PlayerHP > 0;
    public bool IsPlayerDead => PlayerHP == 0;

    public MapStem? GetPlayerMapStem()
    {
        if (!Hook.Hooked) return null;
        byte[] fieldAreaMapBytes = Hook.FieldArea.ReadBytes(0x2C, 4).Reverse().ToArray();
        return new MapStem(fieldAreaMapBytes);
    }

    public PlayerManager(EldenRingHook hook)
    {
        Hook = hook;
        
        GetRunesFunc = Hook.RegisterAbsoluteAOB(GetRunesFuncAOB);
        
        Hook.OnGameLoaded += OnLoaded;
        Hook.OnGameUnloaded += OnUnloaded;
    }

    void OnLoaded(object? sender, EventArgs e)
    {
        PlayerIns = new EnemyIns(Hook.WorldChrMan.CreateChildPointer(EldenRingHook.PlayerInsOffset, 0 * 10));
        PlayerAsm = new ChrAsm(Hook.GameDataMan.CreateChildPointer(0x8));
    }
    
    void OnUnloaded(object? sender, EventArgs e)
    {
        PlayerIns = null;
        PlayerAsm = null;
    }

    /// <summary>
    /// Execute a one-off script to give the player a certain number of runes.
    ///
    /// `amount` can be negative to take runes away. Both addition and subtraction are properly displayed in the HUD.
    /// </summary>
    /// <param name="amount"></param>
    public bool GetRunes(int amount)
    {
        if (!Hook.Loaded)
        {
            Logging.WarningPrint("Cannot Get Runes when game is not loaded.");
            return false;
        }
        if (!Hook.WorldChrMan.TryResolve(out IntPtr worldChrManAddr))
        {
            Logging.ErrorPrint("Failed to resolve WorldChrMan.");
            return false;
        }
        if (!GetRunesFunc.TryResolve(out IntPtr getRunesFuncAddr))
        {
            Logging.ErrorPrint("Failed to resolve GetRunes function.");
            return false;
        }
        
        IntPtr runeAmountAddr = Hook.AllocateClose(sizeof(int));

        try
        {
            Kernel32.WriteInt32(Hook.Handle, runeAmountAddr, amount);

            string getRunesAsm = ResourceManager.GetEmbeddedResource("GetRunes.asm");
            string asm = string.Format(
                getRunesAsm,
                runeAmountAddr.ToString("X2"),
                worldChrManAddr.ToString("X2"),
                getRunesFuncAddr.ToString("X2"));
            Hook.AssembleAndExecute(asm);
        }
        catch (Exception e)
        {
            Logging.ErrorPrint($"Failed to execute Get Runes script: {e}");
            return false;
        }
        finally
        {
            Hook.Free(runeAmountAddr);
        }

        return true;
    }
}
