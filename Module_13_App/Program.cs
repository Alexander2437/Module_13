using System;
using System.Collections.Generic;

namespace HashSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
            var characters = sentence.ToCharArray();
            
            var CharSet = new HashSet<char>();

            foreach (char character in characters) 
            {
                if (character != ' ')
                    CharSet.Add(character);
            }

            Console.WriteLine("Number of symbols: {0}", CharSet.Count);
        }
    }
}