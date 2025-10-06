using System;
using System.Collections;
using System.Text;

namespace Module_13_App
{
    class Program
    {
        public static void Main(string[] args) 
        {
            ArrayList arrayExample = new ArrayList();

            int[] nums = { 1, 2, 3 };
            string[] strings = { "one", "two", "three" };

            arrayExample.AddRange(nums);
            arrayExample.AddRange(strings);

            var changedArr = GetSumOfElements(arrayExample);

            foreach ( var element in changedArr )
            {
                Console.WriteLine(element);
            }
        }
        
        public static ArrayList GetSumOfElements(ArrayList input)
        {
            int intResult = 0;
            //string stringResult = null;
            StringBuilder stringResult = new StringBuilder();

            foreach (var element in input)
            { 
                if (element is Int32)
                {
                    // var tempInt = (Int32)element;
                    intResult += (Int32)element; 
                }
                else
                {
                    //var tempString = (String)element;
                    //stringResult += (String)element + " ";
                    stringResult.Append(element + " ");
                }
            }

            //ArrayList result = [intResult, stringResult];
            ArrayList result = [intResult, stringResult.ToString()];

            return result;
        }
    }
}
