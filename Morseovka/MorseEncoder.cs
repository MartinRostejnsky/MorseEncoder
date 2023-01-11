﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Morseovka
{
    class MorseEncoder
    {

        protected Dictionary<string, string> Text2Morse = new Dictionary<string, string>()
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

        protected Dictionary<string, string> Morse2Text = new Dictionary<string, string>()
        {
            { "----", "ch" },
            { ".-", "a"},
            { "-...", "b" },
            { "-.-.", "c" },
            { "-..", "d" },
            { ".", "e" },
            { "..-.", "f" },
            { "--.", "g" },
            { "....", "h" },
            { "..", "i" },
            { ".---", "j" },
            { "-.-", "k" },
            { ".-..", "l" },
            { "--", "m" },
            { "-.", "n" },
            { "---", "o" },
            { ".--.", "p" },
            { "--.-", "q" },
            { ".-.", "r" },
            { "...", "s" },
            { "-", "t" },
            { "..-", "u" },
            { "...-", "v" },
            { ".--", "w" },
            { "-..-", "x" },
            { "-.--", "y" },
            { "--..", "z" },
            { "-----", "0" },
            { ".----", "1" },
            { "..---", "2" },
            { "...--", "3" },
            { "....-", "4" },
            { ".....", "5" },
            { "-....", "6" },
            {"--...", "7" },
            {"---..", "8" },
            {"----.", "9" },
            { " ", " " },
            { ".-.-.-", "." },
            { "--..--", "," },
            { "..--..", "?" },
            { "-.-.--", "!" },
            { "-.--.", "(" },
            { "-.--.-", ")" },
            { ".-...", "&" },
            { "---...", ":" },
            { "-.-.-.", ";" },
            { "-...-", "=" },
            { ".-.-.", "+" },
            { "-....-", "-" },
            { "..--.-", "_" },
            { ".-..-.", "\"" },
            { "...-..-", "$" },
            { ".--.-.", "@" }
        };
        public string Encode(string text)
        {


            char[] chars= text.ToCharArray();
            List<string> coded = new List<string>();

            foreach (char c in chars) {
                coded.Add(Text2Morse[c.ToString()]);
            }

            string code = string.Join("/", coded);
            return code;
        }

        public string Decode(string code)
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

    }
}
