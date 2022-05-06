# PrintBits
[<img src="https://img.shields.io/github/workflow/status/oliverbooth/PrintBits/.NET">](https://github.com/oliverbooth/PrintBits/actions?query=workflow%3A%22.NET%22)
[<img src="https://img.shields.io/github/downloads/oliverbooth/PrintBits/total">](https://github.com/oliverbooth/PrintBits/releases)

PrintBits is a command-line utility for printing the bits of an integer

## Installation
### Windows
Download the [latest release](https://github.com/oliverbooth/PrintBits/releases/latest), and ensure `bits.exe` is somewhere in `%PATH%`

### Linux / macOS
Download the [latest release](https://github.com/oliverbooth/PrintBits/releases/latest), and ensure `bits` is somewhere in `$PATH` or create a symbolic link in `/usr/bin`

## Usage
To print the bits of a given integer, simply specify the integer.
```bash
$ bits 1024
```
This will output the bits like so:
```
0000010000000000
```
The number of bits to print is determined by the value, and will use the next power of 2 capable of displaying the bits.

### Specifying bit count
Pass a value to the `--count` flag (shorthand `-c`) to override the automatic bit-count determination, and print a specific number of bits.
```bash
$ bits -c 32 1024
```
This will output 32 bits like so:
```
00000000000000000000010000000000
```

## Summary
```
-c, --count     (Default: 0) The number of bits to print.

--help          Display this help screen.

--version       Display version information.

value pos. 0    Required. The value whose bits to print.
```

## License
This project is licensed under MIT. See [LICENSE.md](LICENSE.md) for more details.

## Disclaimer
This tool is provided as-is and by running it you accept any and all liability should the tool behave unexpectedly.
