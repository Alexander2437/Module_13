using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HashSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var numberChars = new HashSet<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                var puntuationChars = new HashSet<char>() { '-', '.', ',', '!', '?', ' ' };

                Console.WriteLine("Введите строку:");
                string sentence = Console.ReadLine();

                var characters = sentence.ToCharArray();

                var CharSet = new HashSet<char>();

                foreach (char character in characters)
                {
                    if (character != ' ')
                        CharSet.Add(character);
                }
                Console.WriteLine("Number of symbols: {0}", CharSet.Count);

                CharSet.ExceptWith(puntuationChars);
                Console.WriteLine("Number of symbols without punctuation marks: {0}", CharSet.Count);

                if (CharSet.Overlaps(numberChars))
                {
                    Console.WriteLine("The text contains numbers.");
                }
                else
                {
                    Console.WriteLine("The text does not contain numbers.");
                }

                Console.WriteLine();
            }
        }
    }
}