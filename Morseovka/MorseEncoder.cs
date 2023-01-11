using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Morseovka
{
    class MorseEncoder
    {

        protected static Dictionary<string, string> Text2Morse = new Dictionary<string, string>()
        {
            { "ch", "----" },
            { "a", ".-" },
            { "b", "-..." },
            { "c", "-.-." },
            { "d", "-.." },
            { "e", "." },
            { "f", "..-." },
            { "g", "--." },
            { "h", "...." },
            { "i", ".." },
            { "j", ".---" },
            { "k", "-.-" },
            { "l", ".-.." },
            { "m", "--" },
            { "n", "-." },
            { "o", "---" },
            { "p", ".--." },
            { "q", "--.-" },
            { "r", ".-." },
            { "s", "..." },
            { "t", "-" },
            { "u", "..-" },
            { "v", "...-" },
            { "w", ".--" },
            { "x", "-..-" },
            { "y", "-.--" },
            { "z", "--.." },
            { "0", "-----" },
            { "1", ".----" },
            { "2", "..---" },
            { "3", "...--" },
            { "4", "....-" },
            { "5", "....." },
            { "6", "-...." },
            { "7", "--..." },
            { "8", "---.." },
            { "9", "----." },
            { " ", " " },
            { ".", ".-.-.-" },
            { ",", "--..--" },
            { "?", "..--.." },
            { "!", "-.-.--" },
            { "(", "-.--." },
            { ")", "-.--.-" },
            { "&", ".-..." },
            { ":", "---..." },
            { ";", "-.-.-." },
            { "=", "-...-" },
            { "+", ".-.-." },
            { "-", "-....-" },
            { "_", "..--.-" },
            { "\"", ".-..-." },
            { "$", "...-..-" },
            { "@", ".--.-." }
        };

        protected static Dictionary<string, string> Morse2Text => Text2Morse.ToDictionary(x => x.Value, x => x.Key);
        public static string Encode(string text)
        {


            List<string> chars= ToRetardedCharArray(text);
            List<string> coded = new List<string>();

            foreach (string c in chars) {
                coded.Add(Text2Morse[c.ToString().ToLower()]);
            }

            string code = string.Join("/", coded);
            return code;
        }

        public static string Decode(string code)
        {
            string[] splitted = code.Split("/");
            List<string> decoded = new List<string>();
            foreach (string s in splitted)
            {
                decoded.Add(Morse2Text[s.ToString()]);
            }

            string text = string.Join("", decoded);

            return text;
        }

        private static List<string> ToRetardedCharArray(string text)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'c')
                    try
                    {
                        {
                            if (text[i + 1] == 'h')
                            {
                                list.Add("ch");
                                i++;
                            }
                            else { list.Add("c"); }
                        }
                    }
                    catch
                    {
                        list.Add("c");
                    }
                
                else { list.Add(text[i].ToString().ToLower()); }
            }
            return list;
        }

    }
}
