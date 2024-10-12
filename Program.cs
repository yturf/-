using System;

namespace Readint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = ReadInt();

            Console.WriteLine($"Конвертация прошла успешно. Число: {result}.");
            Console.ReadKey();
        }

        static int ReadInt()
        {
            int number = 0;

            Console.Write("Введите число: ");

            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write($"Проверьте правильность ввода!\nВведите число: ");               
            }

            return number;
        }
    }
}
