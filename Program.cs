using System;

namespace Readint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numder;

            requestingNumber(out numder);

            Console.ReadKey();
        }

        static int requestingNumber(out int numder)
        {
            while (true)
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();

                Console.Clear();

                bool result = int.TryParse(input, out numder);

                if (result == true)
                {
                    Console.WriteLine($"Конвертация прошла успешно. Число: {numder}.");
                    return numder;
                }

                else
                {
                    Console.WriteLine($"Конвертация не удалась...");
                }
            }
        }
    }
}
