using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;

namespace KataNet;

public class TigerMorseDecoder : MorseDecoder
{
    private static Dictionary<string, char> Dictionary = new()
    {
        [".-"] = 'a',
        ["-..."] = 'b',
        ["-.-."] = 'c',
        ["-.."] = 'd',
        ["."] = 'e',
        ["..-."] = 'f',
        ["--."] = 'g',
        ["...."] = 'h',
        [".."] = 'i',
        [".---"] = 'j',
        ["-.-"] = 'k',
        [".-.."] = 'l',
        ["--"] = 'm',
        ["-."] = 'n',
        ["---"] = 'o',
        [".--."] = 'p',
        ["--.-"] = 'q',
        [".-."] = 'r',
        ["..."] = 's',
        ["-"] = 't',
        ["..-"] = 'u',
        ["...-"] = 'v',
        [".--"] = 'w',
        ["-..-"] = 'x',
        ["-.--"] = 'y',
        ["--.."] = 'z',
        [".----"] = '1',
        ["..---"] = '2',
        ["...--"] = '3',
        ["....-"] = '4',
        ["....."] = '5',
        ["-...."] = '6',
        ["--..."] = '7',
        ["---.."] = '8',
        ["----."] = '9',
        ["-----"] = '0'
    };

    [Benchmark]
    public override string DecodeMisteryMessage()
    {
        var item = Regex.Replace(MisteryMessage, "[.-]+", x => Dictionary[x.Value].ToString());

        item = Regex.Replace(item, "(\\w) (\\w)", x => $"{x.Groups[1].Value}{x.Groups[2].Value}");
        return Regex.Replace(item, "(\\w) (\\w)", x => $"{x.Groups[1].Value}{x.Groups[2].Value}").Replace("   ", " ");
        
    }
}