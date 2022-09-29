using System.Text;
using BenchmarkDotNet.Attributes;

namespace KataNet;

public class FinalMorseDecoder : MorseDecoder
{
	[Benchmark]
	public override string DecodeMisteryMessage()
	{
		var dictionary = GetMorseDictionary();

		var sb = new StringBuilder();
		var keys = MorseDecoder.MisteryMessage.Split(' ');

		for (int i = 0; i < keys.Length; i++)
		{
			if (keys[i] == " " && keys[i + 1] == " ")
			{
				sb.Append(dictionary.ElementAt(i).Value);
				i++;
				continue;
			}

			dictionary.TryGetValue(keys[i], out var u);
			sb.Append(u);
		}

		return sb.ToString();
	}

	private Dictionary<string, char> GetMorseDictionary()
	{
		return new Dictionary<string, char>()
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
			["-----"] = '0',
			[" "] = ' '
		};
	}


}