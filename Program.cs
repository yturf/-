using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подмассив_повторений_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[30];

            int maxRepetitions = 0;
            int repeatingNumber = 0; 
            int repetitions = 1;
            int minRandomNumber = 1;
            int maxRandomNumber = 8;

            Console.Write("Массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minRandomNumber, maxRandomNumber);
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    repetitions++;
                }
                else
                {
                    repetitions = 1;
                }
                if (repetitions > maxRepetitions)
                {
                    maxRepetitions = repetitions;
                    repeatingNumber = array[i];
                }
            }

            Console.WriteLine($"\nЧисло {repeatingNumber} повторяется больше всех, " +
                $"количество его повторений равно {maxRepetitions}.");

            Console.ReadKey();
        }
    }
}
