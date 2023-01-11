// See https://aka.ms/new-console-template for more information
using Morseovka;

Console.WriteLine("Hello, World!");

MorseEncoder morseEncoder = new MorseEncoder();

Console.WriteLine(morseEncoder.Decode(".-/----/.---/---"));