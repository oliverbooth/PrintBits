namespace PrintBits;

internal sealed class App
{
    public static void Run(Options options)
    {
        int bits = options.Count;
        var value = (ulong) options.Value;

        if (bits < 1)
        {
            for (var i = 63; i >= 0; i--)
            {
                if (value >> i == 1)
                {
                    // get next available power of 2
                    bits = (int) Math.Pow(2, Math.Ceiling(Math.Log(i + 1) / Math.Log(2)));
                    break;
                }
            }
        }

        PrintBits((long) value, bits);
    }

    private static void PrintBits(long value, int bits)
    {
        for (int i = bits - 1; i >= 0; i--)
        {
            long bit = value & (1L << i);
            bit >>= i;

            if (bit == 0) Console.ForegroundColor = ConsoleColor.Red;
            else if (bit == 1) Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(bit);
        }

        Console.ResetColor();
        Console.WriteLine();
    }
}
