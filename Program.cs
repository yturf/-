using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minNumber = 0;
            int maxNumber = 101;
            int number = random.Next(minNumber, maxNumber);
            int firstMultipleNumber = 3;
            int secondMultipleNumber = 5;
            int sumOfAllPositiveNumbers = 0;

            Console.WriteLine("Случайное число: " + number);

            for (int i = 0; i <= number; i++)
            {
                if (i % firstMultipleNumber == 0 || i % secondMultipleNumber == 0)
                {
                    Console.WriteLine(i);
                    sumOfAllPositiveNumbers += i;
                }
            }

            Console.WriteLine($"Сумма всех положительных чисел числа {number} (включая число),");
            Console.WriteLine($"которые кратны {firstMultipleNumber} и {secondMultipleNumber}, равна {sumOfAllPositiveNumbers}.");
            Console.ReadKey();
        }
    }
}
