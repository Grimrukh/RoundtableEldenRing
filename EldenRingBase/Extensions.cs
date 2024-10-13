using System.Numerics;
using System.Runtime.InteropServices;
using SoulsFormats;

namespace EldenRingBase;

public static class Extensions
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
    
    public static int RandInt(int minValue, int maxValue)
    {
        return Rand.Next(minValue, maxValue);
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

    static readonly List<float> Cardinals = [0f, 90f, 180f, -90f];
    
    public static float GetRandomCardinalVector()
    {
        return Cardinals[Rand.Next(4)];
    }

    public static T GetRandomItem<T>(this List<T> listio)
    {
        int index = Rand.Next(0, listio.Count);
        return listio[index];
    }
    
    public static List<T> GetRandomItems<T>(this List<T> listio, int count, bool withReplacement = true)
    {
        List<T> items = [];
        if (withReplacement)
        {
            for (int i = 0; i < count; i++)
            {
                int index = Rand.Next(0, listio.Count);
                items.Add(listio[index]);
            }
            return items;
        }

        listio = listio.ToList();  // copy
        for (int i = 0; i < count; i++)
        {
            int index = Rand.Next(0, listio.Count);
            T item = listio[index];
            listio.RemoveAt(index);
            items.Add(item);
        }

        return items;
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
    
    public static List<T> GetRangeSafe<T>(this List<T> list, int startIndex, int endIndex)
    {
        endIndex = Math.Min(endIndex, list.Count);
        return startIndex > endIndex 
            ? [] 
            : list.GetRange(startIndex, endIndex - startIndex);
    }

    /// <summary>
    /// Get XZ angle of `b` from `a`, in degrees by default.
    ///
    /// Setting enemy/asset with position `a` to this Y rotation will make it face `b`. Note standard negation for LHS
    /// and order of `Atan2` arguments to reflect that enemies "face" their negative Z axis.
    ///
    /// Reasoning:
    ///     In normal usage, atan(y, x) gives you the angle from the positive X axis toward the positive Y axis.
    ///     However, for "facing", we consider the negative Z axis as the "forward" direction. If an enemy was placed in
    ///     the world with rotation (0, 0, 0), they would be facing "south" (negative Z), and so a point with coords
    ///     (0, -N) directly south of them would have an angle of 0 degrees.
    ///     And since degrees increase clockwise in this system, we want atan(-x, -z). This is like saying "zero is at
    ///     -Z axis" and "invert the target X axis".
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="radians"></param>
    /// <returns></returns>
    public static float GetFacingAngleY(this Vector3 a, Vector3 b, bool radians = false)
    {
        Vector3 aToB = b - a;
        float angleRad = MathF.Atan2(-aToB.X, -aToB.Z);
        return radians ? angleRad : 180f / MathF.PI * angleRad;
    }

    public static EMEVD.Event FindOrCreateEventID(this EMEVD emevd, long eventID)
    {
        EMEVD.Event? ev = emevd.Events.Find(e => e.ID == eventID);
        if (ev != null) return ev;
        ev = new EMEVD.Event(eventID);
        emevd.Events.Add(ev);
        return ev;
    }

    /// <summary>
    /// Construct 4x4 rotation matrix by multiplying XZY Euler angles together.
    /// </summary>
    /// <param name="eulerXZY"></param>
    /// <param name="radians"></param>
    /// <returns></returns>
    public static Matrix4x4 EulerAnglesTo4x4(Vector3 eulerXZY, bool radians = false)
    {
        if (!radians)
            eulerXZY = MathF.PI / 180f * eulerXZY;
        float sx = MathF.Sin(eulerXZY.X);
        float sy = MathF.Sin(eulerXZY.Y);
        float sz = MathF.Sin(eulerXZY.Z);
        float cx = MathF.Cos(eulerXZY.X);
        float cy = MathF.Cos(eulerXZY.Y);
        float cz = MathF.Cos(eulerXZY.Z);
        Matrix4x4 mX = new(
            1f, 0f, 0f, 0f,
            0f, cx, -sx, 0f,
            0f, sx, cx, 0f,
            0f, 0f, 0f, 1f);
        Matrix4x4 mY = new(
            cy, 0f, sy, 0f,
            0f, 1f, 0f, 0f,
            -sy, 0f, cy, 0f,
            0f, 0f, 0f, 1f);
        Matrix4x4 mZ = new(
            cz, -sz, 0f, 0f,
            sz, cz, 0f, 0f,
            0f, 0f, 1f, 0f,
            0f, 0f, 0f, 1f);
        return mY * mZ * mX;
    }
    
    /// <summary>
    /// Convert a 4x4 rotation matrix to Euler angles in XZY (FromSoft) order.
    ///
    /// Only looks at the upper-left 3x3 submatrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="radians"></param>
    /// <returns></returns>
    public static Vector3 ToEulerAngles(this Matrix4x4 matrix, bool radians = false)
    {
        // TODO: Above Python in C#.
        float x, y, z;
        if (matrix.M21 < 1f)
        {
            if (matrix.M21 > -1f)
            {
                // Unique solution.
                z = MathF.Asin(matrix.M21);
                y = MathF.Atan2(-matrix.M31, matrix.M11);
                x = MathF.Atan2(-matrix.M23, matrix.M22);
            }
            else
            {
                // Not a unique solution: x - y = Atan2(M32, M33)
                z = -MathF.PI / 2;
                y = -MathF.Atan2(matrix.M32, matrix.M33);
                x = 0f;
            }
        }
        else
        {
            // Not a unique solution: x + y = Atan2(M32, M33)
            z = MathF.PI / 2;
            y = MathF.Atan2(matrix.M32, matrix.M33);
            x = 0f;
        }
        
        Vector3 eulerRad = new(x, y, z);
        return radians ? eulerRad : 180f / MathF.PI * eulerRad;
    }
}