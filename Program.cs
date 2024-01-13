using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Программа_под_паролем
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            string userInput = "";

            int countAttempts = 3;
            int restOfCount;

            Console.Write("Придумайте пароль: ");
            password = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Введите пароль. У вас только " + countAttempts + " попытки!");

            for (int i = 0; i < countAttempts; i++)
            {
                userInput = Console.ReadLine();
                restOfCount = countAttempts - (i + 1);

                if (userInput == password)
                {
                    Console.WriteLine("Пароль верный!");
                    Console.Clear();
                    Console.WriteLine("Тайное сообщение!");
                    Console.ReadKey();
                    break;                   
                }
                else 
                {
                    Console.WriteLine("Пароль неверный! Доступ закрыт! ");
                    Console.WriteLine("У вас осталась попыток: " + restOfCount);                  
                }
            }
        }
    }
}
