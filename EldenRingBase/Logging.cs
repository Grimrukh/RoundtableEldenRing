namespace EldenRingBase;

public static class Logging
{
    static bool DoDebugPrint => true;

    public static void DebugPrint(string msg, ConsoleColor? color = null)
    {
        if (!DoDebugPrint) return;
        if (color != null)
            Console.ForegroundColor = color.Value;
        Console.WriteLine($"DEBUG: {msg}");
        if (color != null)
            Console.ResetColor();
    }
    
    public static void InfoPrint(string msg)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"INFO: {msg}");
        Console.ResetColor();
    }
    
    public static void WarningPrint(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"WARNING: {msg}");
        Console.ResetColor();
    }
    
    public static void ErrorPrint(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR: {msg}");
        Console.ResetColor();
    }
}