using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            int number;
            while (true)
            {
                Console.Write("Введите число: ");
                int.TryParse(Console.ReadLine(), out number);
                if (set.Contains(number))
                {
                    Console.WriteLine("Число уже вводилось ранее.");
                }
                else
                {
                    Console.WriteLine("Число успешно сохранено.");
                    set.Add(number);
                }
            }
        }
    }
}
