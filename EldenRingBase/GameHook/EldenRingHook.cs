using Keystone;
using PropertyHook;

namespace EldenRingBase.GameHook;

public class EldenRingHook : PHook
{
    public long BaseAddress { get; private set; }
    
    // Hard-coded offset. TODO: Could be game version dependent.
    public const int PlayerInsOffset = 0x10EF8;
    
    // High-level pointers.
    public PHPointer WorldChrMan { get; }
    public PHPointer GameDataMan { get; }
    public PHPointer MapItemMan { get; }
    public PHPointer SoloParamRepository { get; }
    public PHPointer FieldArea { get; }
    public PHPointer EventFlagMan { get; }
    
    /// <summary>
    /// Used to check if game is loaded.
    /// </summary>
    public PHPointer PlayerIns { get; }
    
    const string windowName = "ELDEN RING™";
    const int RelativePtrAddressOffset = 0x3;
    const int RelativePtrInstructionSize = 0x7;
    // const int LargeRelativePtrInstructionSize = 0x8;
    
    static readonly Engine Engine = new(Architecture.X86, Mode.X64);


    /// <summary>
    /// Some functions, like reading/writing event flags, require some padding time after the game loads.
    /// </summary>
    public long LoadedTimeMs { get; private set; } = -1;  // default is unloaded

    public bool Loaded => LoadedTimeMs >= 0;  // i.e. not -1
    
    public bool FlagsAvailable => EventFlagMan.IsNonZero && EventFlagMan.ReadIntPtr(0x28) != IntPtr.Zero;

    public EldenRingHook(int refreshInterval, int minLifetime) :
        base(refreshInterval, minLifetime, p => p.MainWindowTitle == windowName)
    {
        OnHooked += ERHook_OnHooked;
        OnUnhooked += ERHook_OnUnhooked;

        WorldChrMan = RegisterRelativeAOB(Offsets.WorldChrManAoB, RelativePtrAddressOffset, RelativePtrInstructionSize, 0x0);
        GameDataMan = RegisterRelativeAOB(Offsets.GameDataManAoB, RelativePtrAddressOffset, RelativePtrInstructionSize, 0x0);
        MapItemMan = RegisterRelativeAOB(Offsets.MapItemManAoB, RelativePtrAddressOffset, RelativePtrInstructionSize, 0x0);
        SoloParamRepository = RegisterRelativeAOB(Offsets.SoloParamRepositoryAoB, RelativePtrAddressOffset, RelativePtrInstructionSize, 0x0);
        FieldArea = RegisterRelativeAOB(Offsets.FieldAreaAoB, RelativePtrAddressOffset, RelativePtrInstructionSize, 0x0);

        // Note that this is missing the extra offset 0 to get the actual PlayerIns class.
        PlayerIns = WorldChrMan.CreateChildPointer(PlayerInsOffset);
        
        EventFlagMan = RegisterRelativeAOB(Offsets.EventFlagManAoB, RelativePtrAddressOffset, RelativePtrInstructionSize, 0x0);
    }

    void ERHook_OnHooked(object? sender, PHEventArgs e)
    {
        if (Process.MainModule != null) 
            BaseAddress = Process.MainModule.BaseAddress.ToInt64();
        //Console.WriteLine($"Elden Ring base address: {BaseAddress:X}");
    }

    void ERHook_OnUnhooked(object? sender, PHEventArgs e)
    {
        // No default logic yet.
    }

    public event EventHandler<PHEventArgs>? OnGameLoaded;
    public event EventHandler<PHEventArgs>? OnGameUnloaded;

    public override void Refresh()
    {
        base.Refresh();
        if (!Hooked)
            return;
        switch (Loaded)
        {
            case false when PlayerIns.Resolve() != IntPtr.Zero:
                // Game has just loaded.
                OnGameLoaded?.Invoke(this, new PHEventArgs(this));
                LoadedTimeMs = 0;
                break;
            case true when PlayerIns.Resolve() == IntPtr.Zero:
                // Game has just unloaded. Note that this CANNOT trigger before `OnGameLoaded` triggers, as Loaded
                // will only be set to true when the hook first sees that the game is loaded.
                OnGameUnloaded?.Invoke(this, new PHEventArgs(this));
                LoadedTimeMs = -1;
                break;
            case true:
                // Still loaded. Increment loaded time.
                LoadedTimeMs += RefreshInterval;
                break;
        }
    }

    public bool Focused => Hooked && User32.GetForegroundProcessID() == Process.Id;

    public uint NewGamePlusLevel
    {
        get => GameDataMan.ReadUInt32(0x120);
        set => GameDataMan.WriteUInt32(0x120, value);
    }

    /// <summary>
    /// Convert to array of ints for AOBScanner.
    /// </summary>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static int[] BytesToPattern(byte[] bytes)
    {
        int[] pattern = new int[bytes.Length];
        for (int i = 0; i < bytes.Length; i++)
            pattern[i] = bytes[i];
        return pattern;
    }
    
    public bool AssembleAndExecute(string asm)
    {
        //Console.WriteLine(asm);
        
        if (Process.MainModule == null)
            return false;
        
        // Assemble from base address to get array size.
        EncodedData? bytes = Engine.Assemble(asm, (ulong)Process.MainModule.BaseAddress);
        KeystoneError error = Engine.GetLastKeystoneError();
        if (error != KeystoneError.KS_ERR_OK)
            throw new Exception($"Something went wrong during assembly. Code could not be assembled. Error: {error}");

        IntPtr? startPtr = null;
        try
        {
            startPtr = AllocateClose(bytes.Buffer.Length, flProtect: Kernel32.PAGE_EXECUTE_READWRITE);
            // Reassemble with the location of `startPtr` to support relative instructions.
            bytes = Engine.Assemble(asm, (ulong)startPtr);
            error = Engine.GetLastKeystoneError();
            if (error != KeystoneError.KS_ERR_OK) // would be very unusual
            {
                Logging.DebugPrint($"Something went wrong during assembly. Code could not be assembled. Error: {error}");
                return false;
            }
            Kernel32.WriteBytes(Handle, startPtr.Value, bytes.Buffer);
            //DebugPrintArray(bytes.Buffer);
            Execute(startPtr.Value);
        }
        catch (Exception e)
        {
            Logging.DebugPrint($"Failed to assemble and execute code: {e.Message}");
            return false;
        }
        finally
        {
            if (startPtr != null)
                Free(startPtr.Value);
        }
        return true;
    }

    public bool AssembleAndInject(string asm, IntPtr address, int injectionSiteLength, IntPtr? basePtr = null)
    {
        if (Process.MainModule == null)
            return false;
        if (basePtr == null)
            basePtr = Process.MainModule.BaseAddress;
        
        EncodedData? bytes = Engine.Assemble(asm, (ulong)basePtr);
        KeystoneError error = Engine.GetLastKeystoneError();
        if (error != KeystoneError.KS_ERR_OK)
            throw new Exception($"Something went wrong during assembly. Code could not be assembled. Error: {error}");

        if (bytes.Buffer.Length < injectionSiteLength)
        {
            // Add padding "nop" instructions to `asm` and reassemble.
            int paddingLength = injectionSiteLength - bytes.Buffer.Length;
            for (int i = 0; i < paddingLength; i++)
                asm += "\nnop";
            bytes = Engine.Assemble(asm, (ulong)basePtr);
            error = Engine.GetLastKeystoneError();
            if (error != KeystoneError.KS_ERR_OK)
                throw new Exception($"Something went wrong during assembly. Code could not be assembled. Error: {error}");
        }
        
        Kernel32.WriteBytes(Handle, address, bytes.Buffer);
        //DebugPrintArray(bytes.Buffer);
        
        return true;
    }
    
    public IntPtr AssembleAllocateWrite(string asm, IntPtr? basePtr = null, bool executable = true)
    {
        //Console.WriteLine(asm);
        
        if (Process.MainModule == null)
            return IntPtr.Zero;
        
        // Assemble from base address to get array size.
        EncodedData? bytes = Engine.Assemble(asm, (ulong)Process.MainModule.BaseAddress);
        KeystoneError error = Engine.GetLastKeystoneError();
        if (error != KeystoneError.KS_ERR_OK)
            throw new Exception($"Something went wrong during assembly. Code could not be assembled. Error: {error}");

        IntPtr startPtr = AllocateClose(bytes.Buffer.Length, basePtr, flProtect: executable ? Kernel32.PAGE_EXECUTE_READWRITE : Kernel32.PAGE_READWRITE);

        // Reassemble with the location of `startPtr` to support relative instructions.
        bytes = Engine.Assemble(asm, (ulong)startPtr);
        error = Engine.GetLastKeystoneError();
        if (error != KeystoneError.KS_ERR_OK)  // would be very unusual
            throw new Exception($"Something went wrong during assembly. Code could not be assembled. Error: {error}");

        Kernel32.WriteBytes(Handle, startPtr, bytes.Buffer);
        //DebugPrintArray(bytes.Buffer);
        
        return startPtr;
    }
}