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

            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write($"Проверьте правильность ввода!\nВведите число: ");               
            }

            return number;
        }
    }
}
