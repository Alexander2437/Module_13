using System;
using System.Collections;
using System.Text;

namespace Module_13_App
{
    class Program
    {
        public static void Main(string[] args) 
        {
            var months = new List<string>()
            {
               "Jan", "Feb", "Mar", "Apr", "May"
            };

            var missing = new ArrayList()
            {
               1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            GetMonths(months, missing);
        }

        public static void GetMonths(List<string> firstCollection, ArrayList SecondCollection) 
        {
            List<string> stringItems = new List<string>();

            foreach (var item in SecondCollection) 
            {
                if (item is string) 
                {
                    stringItems.Add((string)item);
                }
            }

            firstCollection.AddRange(stringItems);

            foreach (var item in firstCollection) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
