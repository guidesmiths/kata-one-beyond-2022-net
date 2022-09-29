using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KataNet.Decoders
{
    public class HedgehogMorseDecoder : MorseDecoder
    {
        [Benchmark]
        public override string DecodeMisteryMessage()
        {
            var dic = new Dictionary<string, char>();
            AddTrad(dic);
            var message = MorseDecoder.MisteryMessage.Trim();
            var list = message.Split("   ");
            string codigo = string.Empty;
            string resultado = string.Empty;
            foreach (var pal in list)
            {
                var caracts = pal.Split(' ');
                foreach (var car in caracts)
                {
                    resultado = resultado + dic.First(x => x.Key == car).Value;
                }
                resultado += ' ';
            }
            return resultado;
        }
        private void AddTrad(Dictionary<string, char> dicc)
        {
            dicc.Add(".-", 'a');
            dicc.Add("-...", 'b');
            dicc.Add("-.-.", 'c');
            dicc.Add("-..", 'd');
            dicc.Add(".", 'e');
            dicc.Add("..-.", 'f');
            dicc.Add("--.", 'g');
            dicc.Add("....", 'h');
            dicc.Add("..", 'i');
            dicc.Add(".---", 'j');
            dicc.Add("-.-", 'k');
            dicc.Add(".-..", 'l');
            dicc.Add("--", 'm');
            dicc.Add("-.", 'n');
            dicc.Add("---", 'o');
            dicc.Add(".--.", 'p');
            dicc.Add("--.-", 'q');
            dicc.Add(".-.", 'r');
            dicc.Add("...", 's');
            dicc.Add("-", 't');
            dicc.Add("..-", 'u');
            dicc.Add("...-", 'v');
            dicc.Add(".--", 'w');
            dicc.Add("-..-", 'x');
            dicc.Add("-.--", 'y');
            dicc.Add("--..", 'z');
            dicc.Add(".----", '1');
            dicc.Add("..---", '2');
            dicc.Add("...--", '3');
            dicc.Add("....-", '4');
            dicc.Add(".....", '5');
            dicc.Add("-....", '6');
            dicc.Add("--...", '7');
            dicc.Add("---..", '8');
            dicc.Add("----.", '9');
            dicc.Add("-----", '0');
        }
    }
}
