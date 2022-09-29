using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataNet
{
	internal class PantherMorseDecoder : MorseDecoder
	{
		public override string DecodeMisteryMessage()
		{
			var morseDict = new Dictionary<string, string>()
			{
				{".-", "a"},
				{"-...", "b"},
				{"-.-." , "c"},
				{"-.."      , "d"},
				{"."        , "e"},
				{"..-." , "f"},
				{"--."      , "g"},
				{"...." , "h"},
				{".."       , "i"},
				{".---" , "j"},
				{"-.-"      , "k"},
				{".-.." , "l"},
				{"--"       , "m"},
				{"-."       , "n"},
				{"---"      , "o"},
				{".--." , "p"},
				{"--.-" , "q"},
				{".-."      , "r"},
				{"..."      , "s"},
				{"-"        , "t"},
				{"..-"      , "u"},
				{"...-" , "v"},
				{".--"      , "w"},
				{"-..-" , "x"},
				{"-.--" , "y"},
				{"--.." , "z"},
				{".----"    , "1"},
				{"..---"    , "2"},
				{"...--"    , "3"},
				{"....-"    , "4"},
				{"....."    , "5"},
				{"-...."    , "6"},
				{"--..."    , "7"},
				{"---.."    , "8"},
				{"----."    , "9"},
				{"-----"    , "0"},
			};

			string[] morseWords = MisteryMessage.Split("   ");
			string[] realWords = new string[morseWords.Length];

			for (int i = 0; i < morseWords.Length; i++)
			{
				string[] morseChars = morseWords[i].Split(" ");

				StringBuilder word = new(string.Empty, morseChars.Length);

				for (int j = 0; j < morseChars.Length; j++)
				{
					word.Append(morseDict[morseChars[j]]);
				}

				realWords[i] = word.ToString();
			}

			return string.Join(" ", realWords);
		}
	}
}
