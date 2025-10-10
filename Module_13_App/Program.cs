using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HashSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberChars = new HashSet<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var puntuationChars = new HashSet<char>() { '-', '.', ',', '!', '?', ' ' };

            string sentence = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
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
        }
    }
}