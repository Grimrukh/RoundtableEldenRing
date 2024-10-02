using PropertyHook;
using EldenRingBase.GameHook;

namespace EldenRingBase.Memory;


public class PlayerManager
{
    EldenRingHook Hook { get; }

    // TODO: Hard-coded offset. May change in future Elden Ring updates?
    const int LocalPlayerOffset = 0x10EF8;

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
        
        Hook.OnHooked += OnHooked;
        Hook.OnUnhooked += OnUnhooked;
    }

    void OnHooked(object? sender, EventArgs e)
    {
        PlayerIns = new EnemyIns(Hook.WorldChrMan.CreateChildPointer(LocalPlayerOffset, 0 * 10));
        PlayerAsm = new ChrAsm(Hook.GameDataMan.CreateChildPointer(0x8));
    }
    
    void OnUnhooked(object? sender, EventArgs e)
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
    public void GetRunes(int amount)
    {
        if (!Hook.WorldChrMan.TryResolve(out IntPtr worldChrManAddr))
        {
            Logging.DebugPrint("Failed to resolve WorldChrMan.");
            return;
        }
        if (!GetRunesFunc.TryResolve(out IntPtr getRunesFuncAddr))
        {
            Logging.DebugPrint("Failed to resolve GetRunes function.");
            return;
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
        finally
        {
            Hook.Free(runeAmountAddr);
        }
    }
}
