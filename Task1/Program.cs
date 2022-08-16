using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = new List<int>();

            FillRandom(ref listOfIntegers, 100, 101);

            PrintList(ref listOfIntegers);

            RemoveNumbersInRange(ref listOfIntegers, 25, 50);

            Console.WriteLine("\n");
            PrintList(ref listOfIntegers);
            Console.WriteLine();
        }

        /// <summary>
        /// Заполняет лист случайными числами в заданном диапазоне
        /// </summary>        
        public static void FillRandom(ref List<int> list, int count, int border)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                list.Add(rand.Next(border + 1));
            }
        }

        /// <summary>
        /// Выводит лист в консоль
        /// </summary>        
        public static void PrintList(ref List<int> list)
        {
            foreach (var elem in list)
                Console.Write(elem + " ");
        }

        /// <summary>
        /// Удаляет из листа все числа из заданного диапазона (begin,end)
        /// </summary>        
        public static void RemoveNumbersInRange(ref List<int> list, int begin, int end)
        {
            list.RemoveAll((int x) => (x > begin && x < end));
        }
    }
}


