using System.Numerics;

namespace TronLink.Blazor.Extensions;

public static class HexExtensions
{
    public static BigInteger HexToBigInteger(this string hex)
    {
        if (!hex.StartsWith("0x")) return BigInteger.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        if (hex.Length >= 2) hex = hex[2..];
        return BigInteger.Parse(hex, System.Globalization.NumberStyles.HexNumber);
    }
    
    public static long HexToLong(this string hex)
    {
        if (!hex.StartsWith("0x")) return long.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        if (hex.Length >= 2) hex = hex[2..];
        return long.Parse(hex, System.Globalization.NumberStyles.HexNumber);
    }
}