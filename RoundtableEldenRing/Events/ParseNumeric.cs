using System.Text.RegularExpressions;
using SoulsFormats;

namespace RoundtableEldenRing.Events;

public static partial class ParseNumeric
{
    public static EMEVD.Event FromNumeric(uint eventID, EMEVD.Event.RestBehaviorType restBehavior, params string[] numericInstructions)
    {
        return new EMEVD.Event(eventID, restBehavior)
        {
            Instructions = numericInstructions.Select(ParseNumericInstruction).ToList(),
        };
    }
    
    public static EMEVD.Instruction AutoArgs(int bank, int id, string argTypes, params object[] args)
    {
        if (argTypes.Length != args.Length)
        {
            throw new ArgumentException($"Mismatched argument types and values in EMEVD instruction: {argTypes}");
        }
        
        if (argTypes.Length == 0)
        {
            return new EMEVD.Instruction(bank, id);
        }
        
        char[] argTypeArray = argTypes.ToCharArray();
        for (int i = 0; i < argTypeArray.Length; i++)
        {
            args[i] = argTypeArray[i] switch
            {
                'B' => (byte)args[i],
                'b' => (sbyte)args[i],
                'H' => (ushort)args[i],
                'h' => (short)args[i],
                'I' => (uint)args[i],
                'i' => (int)args[i],
                'f' => (float)args[i],
                _ => throw new ArgumentException(
                    $"Invalid argument type '{argTypeArray[i]}' in EMEVD instruction: {argTypes}")
            };
        }
        
        return new EMEVD.Instruction(bank, id, args);
    }
    
    public static EMEVD.Instruction ParseNumericInstruction(string instruction)
    {
        Regex regex = NumericInstructionRegex();
        
        Match match = regex.Match(instruction);
        if (!match.Success)
        {
            throw new ArgumentException($"Cannot parse numeric EMEVD instruction: {instruction}");
        }

        int bank = int.Parse(match.Groups[1].Value);
        int id = int.Parse(match.Groups[2].Value);
        char[] argTypes = match.Groups[3].Value.ToCharArray();
        string[] args = match.Groups[4].Value.Split(", ");
        
        // NOTE: There may be zero args.
        
        if (argTypes.Length != args.Length)
        {
            throw new ArgumentException($"Mismatched argument types and values in EMEVD instruction: {instruction}");
        }

        object[] argData = new object[argTypes.Length];
        for (int i = 0; i < argTypes.Length; i++)
        {
            argData[i] = argTypes[i] switch
            {
                'B' => byte.Parse(args[i]),
                'b' => sbyte.Parse(args[i]),
                'H' => ushort.Parse(args[i]),
                'h' => short.Parse(args[i]),
                'I' => uint.Parse(args[i]),
                'i' => int.Parse(args[i]),
                'f' => float.Parse(args[i]),
                _ => throw new ArgumentException(
                    $"Invalid argument type '{argTypes[i]}' in EMEVD instruction: {instruction}")
            };
        }
        
        return new EMEVD.Instruction(bank, id, argData);
    }

    [GeneratedRegex(@"^ *(\d+)\[(\d+)\] \(([BbHhIif]*)\)\[(.*)\]$")]
    private static partial Regex NumericInstructionRegex();
}