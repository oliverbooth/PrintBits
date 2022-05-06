using CommandLine;

namespace PrintBits;

internal sealed class Options
{
    [Option('c', "count", Required = false, Default = 0, HelpText = "The number of bits to print.")]
    public int Count { get; set; } = 0;

    [Value(0, Required = true, HelpText = "The value whose bits to print.")]
    public long Value { get; set; } = 0;
}
