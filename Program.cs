using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Степень_двойки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = 2;
            double randomNumber;
            int maxNumber = 100;
            double resultOfDegree = 1;
            int degree = 0;

             Random random = new Random();

             randomNumber = random.Next(baseNumber, maxNumber);
             Console.WriteLine(randomNumber);

             while (resultOfDegree <= randomNumber) 
             {
                 resultOfDegree *= baseNumber;
                 degree++;
             }

            Console.WriteLine($"Рандомное число: {randomNumber}, " +
                $" {baseNumber} в степени {degree} = {resultOfDegree}.");

            Console.ReadKey();
        }
    }
}
