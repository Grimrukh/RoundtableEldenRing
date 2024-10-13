using System.Numerics;
using System.Runtime.InteropServices;

namespace EldenRingBase;

static class Extensions
{
    static readonly Random Rand = new();
    
    public static void Shuffle<T>(this IList<T> list)
    {  
        int n = list.Count;  
        while (n > 1) {  
            n--;  
            int k = Rand.Next(n + 1);  
            (list[k], list[n]) = (list[n], list[k]);
        }  
    }
    
    public static List<T> CloneShuffled<T>(this IEnumerable<T> list)
    {
        var clone = new List<T>(list);
        clone.Shuffle();
        return clone;
    }
    
    public static List<int> GetRandomPermutation(int count)
    {
        var permutation = new List<int>(count);
        for (int i = 0; i < count; i++)
            permutation.Add(i);
        permutation.Shuffle();
        return permutation;
    }
    
    public static float NextSingle()
    {
        return Rand.NextSingle();
    }

    public static bool RollChance(float chance)
    {
        return chance switch
        {
            < 0f => false,
            >= 1f => true,
            _ => Rand.NextSingle() < chance,
        };
    }
    
    public static T RollChances<T>(List<(float chance, T item)> chances)
    {
        float totalChance = 0f;
        foreach ((float chance, T _) in chances)
            totalChance += chance;

        if (totalChance <= 0f)
        {
            // Too dangerous to throw here.
            Logging.DebugPrint("Total chance is zero. Returning random item.");
            return chances[Rand.Next(0, chances.Count)].item;
        }
        
        float roll = Rand.NextSingle() * totalChance;
        foreach ((float chance, T item) in chances)
        {
            if (roll < chance)
                return item;
            roll -= chance;
        }

        return chances[^1].item;
    }
    
    public static T RollChances<T>(List<T> items, List<float> chances)
    {
        if (items.Count != chances.Count)
            throw new ArgumentException("Items and chances must have same length.");
        List<(float, T)> combined = items.Select((t, i) => (chances[i], t)).ToList();
        return RollChances(combined);
    }

    /// <summary>
    /// Keep rolling each item's chances and return the first one that succeeds. Requires a final lone item to use
    /// if all previous rolls fail.
    /// 
    /// This will progressively split the remaining probability, so:
    ///     RollChancesInSequence([(0.5, "A"), (0.5, "B")], "C")
    /// will have an overall 50% chance of "A", 25% chance of "B", and (remaining) 25% chance of "C".
    /// </summary>
    /// <param name="chances"></param>
    /// <param name="finalItem"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T RollChancesInSequence<T>(List<(float chance, T item)> chances, T finalItem)
    {
        if (chances.Count == 0)
            return finalItem;
        
        foreach ((float chance, T item) in chances)
        {
            if (Rand.NextSingle() < chance)
                return item;
        }

        return finalItem;
    }

    public static int RandInt(int maxValue)
    {
        return Rand.Next(maxValue);
    }

    public static T GetRandomWeighted<T>(this List<T> list, List<float> weights, float totalWeight)
    {
        if (list.Count == 0)
            throw new ArgumentException("List must not be empty.");
        if (list.Count != weights.Count)
            throw new ArgumentException("List and weights must have same length.");
        if (totalWeight <= 0f)
            throw new ArgumentException("Total weight must be positive.");
        float roll = Rand.NextSingle() * totalWeight;
        for (int i = 0; i < list.Count; i++)
        {
            if (roll < weights[i])
                return list[i];
            roll -= weights[i];
        }
        return list[^1];  // won't happen
    }
    
    public static T GetRandomWeighted<T>(this List<T> list, List<int> weights, int totalWeight)
    {
        if (list.Count == 0)
            throw new ArgumentException("List must not be empty.");
        if (list.Count != weights.Count)
            throw new ArgumentException("List and weights must have same length.");
        if (totalWeight <= 0f)
            throw new ArgumentException("Total weight must be positive.");
        int roll = Rand.Next(totalWeight);
        for (int i = 0; i < list.Count; i++)
        {
            if (roll < weights[i])
                return list[i];
            roll -= weights[i];
        }
        return list[^1];  // won't happen
    }
    
    /// <summary>
    /// Get a random `float` between `min` (inclusive) and `max` (exclusive).
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public static float RandRange(float min, float max)
    {
        return min + (max - min) * Rand.NextSingle();
    }

    /// <summary>
    /// Get a random rotation angle, in degrees, between [-180, 180).
    /// </summary>
    /// <returns></returns>
    public static float GetRandomRotation()
    {
        return 360f * Rand.NextSingle() - 180f;
    }
    
    /// <summary>
    /// Get a Vector3 with a random Y rotation angle, in degrees, between [-180, 180). X and Z are zero.
    /// </summary>
    /// <returns></returns>
    public static Vector3 GetRandomRotYVector()
    {
        return new Vector3(0f, 360f * Rand.NextSingle() - 180f, 0f);
    }

    public static T GetRandomItem<T>(this List<T> listio)
    {
        int index = Rand.Next(0, listio.Count);
        return listio[index];
    }
    
    public static T PopRandomItem<T>(this List<T> listio)
    {
        int index = Rand.Next(0, listio.Count);
        T item = listio[index];
        listio.RemoveAt(index);
        return item;
    }
    
    public static byte[] GetBytes<T>(this T str) where T : struct 
    {
        int size = Marshal.SizeOf(str);
        byte[] bytes = new byte[size];

        IntPtr ptr = IntPtr.Zero;
        try
        {
            ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, bytes, 0, size);
        }
        finally
        {
            Marshal.FreeHGlobal(ptr);
        }
        return bytes;
    }
    
    /// <summary>
    /// Get the squared length of a Vector in the XZ (FromSoft ground) plane distance.
    /// </summary>
    /// <param name="v"></param>
    /// <returns></returns>
    public static float GetXZSquaredLength(this Vector3 v)
    {
        float xSq = MathF.Pow(v.X, 2);
        float zSq = MathF.Pow(v.Z, 2);
        return xSq + zSq;
    }
    
    public static Vector3 SlideSideways(this Vector3 position, float rotationY, float distance, float offsetY = 0f)
    {
        // Convert to radians and negate to correct for LHS coordinate system.
        float radians = -rotationY * MathF.PI / 180f;

        // Calculate orthogonal vector.
        float deltaX = (float)Math.Cos(radians + Math.PI / 2) * distance;
        float deltaZ = (float)Math.Sin(radians + Math.PI / 2) * distance;

        // Add to position.
        return new Vector3(position.X + deltaX, position.Y + offsetY, position.Z + deltaZ);
    }
    
    public static Vector3 SlideForwards(this Vector3 position, float rotationY, float distance, float offsetY = 0f)
    {
        // Convert to radians and negate to correct for LHS coordinate system.
        float radians = -rotationY * MathF.PI / 180f;

        // Calculate forward vector.
        float deltaX = (float)Math.Cos(radians) * distance;
        float deltaZ = (float)Math.Sin(radians) * distance;

        // Add to position.
        return new Vector3(position.X + deltaX, position.Y + offsetY, position.Z + deltaZ);
    }

    public static float CorrectAngleRange(this float angleDeg)
    {
        while (angleDeg >= 180f)
            angleDeg -= 360f;
        while (angleDeg < -180f)
            angleDeg += 360f;
        return angleDeg;
    }
}