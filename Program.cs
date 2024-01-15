using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Кратные_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN;
            int minValueOfNumberN = 1;
            int maxValueOfNumberN = 28;
            int numberOfMultiples = 0; 
            int minValueOfMultiples = 100;
            int maxValueOfMultiples = 1000;

            Random random = new Random();

            numberN = random.Next(minValueOfNumberN, maxValueOfNumberN);
            Console.WriteLine("Рамдомное число = " + numberN);

            for (int i = 0; i < maxValueOfMultiples; i += numberN) 
            {
                if (i >= minValueOfMultiples)
                {
                    numberOfMultiples++;
                }
            }

            Console.WriteLine("Количество трехзначных натуральных чисел," +
                " которые кратны " + numberN + " = " + numberOfMultiples);

            Console.ReadKey();
        }
    }
}
