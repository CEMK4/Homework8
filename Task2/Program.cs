using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string phoneNumber;
            string fullName;
            string key;
            do
            {
                Console.Write("Введите номер телефона: ");
                phoneNumber = Console.ReadLine();
                Console.Write("Введите ФИО владельца: ");
                fullName = Console.ReadLine();

                phoneBook.Add(phoneNumber, fullName);

                Console.WriteLine("Для завершения введите пустую строку или любой символ для продолжения.");
                key = Console.ReadLine();
            } while (!String.IsNullOrWhiteSpace(key));

            Console.Write("Введите номер телефона: ");
            phoneNumber = Console.ReadLine();
            if (phoneBook.ContainsKey(phoneNumber))
            {
                Console.WriteLine($"ФИО: {phoneBook[phoneNumber]}");
            }
            else
            {
                Console.WriteLine("Владельца по такому номеру телефона не зарегистрировано.");
            }        
        }
    }
}
