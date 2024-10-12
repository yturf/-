using System;

namespace Readint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            RequestNumber(out number);
            Console.WriteLine($"Конвертация прошла успешно. Число: {number}.");
            Console.ReadKey();
        }

        static int RequestNumber(out int number)
        {
            Console.Write("Введите число: ");

            string userInput = Console.ReadLine();

            bool isWork = int.TryParse(userInput, out number);

            while (isWork == false)
            {
                Console.Write($"Проверьте правильность ввода!\nВведите число: ");
                userInput = Console.ReadLine();
                isWork = int.TryParse(userInput, out number);
            }

            return number;
        }
    }
}
