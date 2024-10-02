using PropertyHook;

namespace EldenRingBase.GameHook;

public abstract class PointerWrapper(PHPointer pointer)
{
    public PHPointer Pointer { get; } = pointer;

    public bool IsValid => Pointer.IsNonZero;
}