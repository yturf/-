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

            string input = Console.ReadLine();

            bool isWork = int.TryParse(input, out number);           

            while (true)
            {
                Console.Clear();

                if (isWork == true)
                {
                    return number;
                }               
                else
                {
                    Console.WriteLine($"Конвертация не удалась...");
                    Console.Write("Введите число: ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
