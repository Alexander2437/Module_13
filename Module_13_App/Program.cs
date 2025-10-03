using System;

namespace Module_13_App
{
    class Program
    {
        public static void Main(string[] args) 
        {
        
        }

        public bool GetSortType(int[] array)
        {
            if (array.First() < array.Last())
                return true;
            return false;
        }

        static bool CheckAscending(int[] numbers)
        {
            //  используем цикл for для обхода массива
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //  проверяем следующий элемент на предмет того, что он меньше предыдушего
                if (numbers[i + 1] < numbers[i])
                    return false;
            }
            return true;
        }
    }
}
