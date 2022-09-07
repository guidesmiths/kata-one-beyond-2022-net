If you want to run the benchmarks you need to run the application without attaching it to the debugger and in Release mode:

`dotnet run -c Release`


The mapping of Morse characters to regular characters is as follows:

```
[".-"]		= 'a',
["-..."]	= 'b',
["-.-."]	= 'c',
["-.."]		= 'd',
["."]		= 'e',
["..-."]	= 'f',
["--."]		= 'g',
["...."]	= 'h',
[".."]		= 'i',
[".---"]	= 'j',
["-.-"]		= 'k',
[".-.."]	= 'l',
["--"]		= 'm',
["-."]		= 'n',
["---"]		= 'o',
[".--."]	= 'p',
["--.-"]	= 'q',
[".-."]		= 'r',
["..."]		= 's',
["-"]		= 't',
["..-"]		= 'u',
["...-"]	= 'v',
[".--"]		= 'w',
["-..-"]	= 'x',
["-.--"]	= 'y',
["--.."]	= 'z',
[".----"]	= '1',
["..---"]	= '2',
["...--"]	= '3',
["....-"]	= '4',
["....."]	= '5',
["-...."]	= '6',
["--..."]	= '7',
["---.."]	= '8',
["----."]	= '9',
["-----"]	= '0',
```