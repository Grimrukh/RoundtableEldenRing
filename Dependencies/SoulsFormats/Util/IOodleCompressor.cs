using System;
namespace SoulsFormats;

public interface IOodleCompressor
{
    public byte[] Compress(Span<byte> source);
    public Memory<byte> Decompress(Span<byte> source, long uncompressedSize);
}
