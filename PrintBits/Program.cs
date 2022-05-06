using CommandLine;
using PrintBits;

Parser.Default.ParseArguments<Options>(args).WithParsed(App.Run);
