using BenchmarkDotNet.Attributes;

namespace KataNet.Decoders;

public class MattMorseDecoder : MorseDecoder
{
    [Benchmark]
    public override string DecodeMisteryMessage()
    {
        return new string(MisteryMessage.Replace("   ", " | ").Split().Select(ParseMorseCodeChar).ToArray());
    }

    private static char ParseMorseCodeChar(string morseCode)
    {
        return morseCode switch
        {
            ".-" => 'a',
            "-..." => 'b',
            "-.-." => 'c',
            "-.." => 'd',
            "." => 'e',
            "..-." => 'f',
            "--." => 'g',
            "...." => 'h',
            ".." => 'i',
            ".---" => 'j',
            "-.-" => 'k',
            ".-.." => 'l',
            "--" => 'm',
            "-." => 'n',
            "---" => 'o',
            ".--." => 'p',
            "--.-" => 'q',
            ".-." => 'r',
            "..." => 's',
            "-" => 't',
            "..-" => 'u',
            "...-" => 'v',
            ".--" => 'w',
            "-..-" => 'x',
            "-.--" => 'y',
            "--.." => 'z',
            ".----" => '1',
            "..---" => '2',
            "...--" => '3',
            "....-" => '4',
            "....." => '5',
            "-...." => '6',
            "--..." => '7',
            "---.." => '8',
            "----." => '9',
            "-----" => '0',
            _ => ' '
        };
    }
}
