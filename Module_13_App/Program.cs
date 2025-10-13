using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HashSetTest
{
    class Program
    {
        public static Stack<string> words = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "pop")
                {
                    words.TryPop(out string popResult);
                }
                else if (input == "peek")
                {
                    words.TryPeek(out string peekResult);
                }
                else
                {
                    words.Push(input);
                }
                
                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }
    }
}