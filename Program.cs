using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_конкретными_строками_столбцами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfLines = 0;
            int productOfColumns = 1;

            int[,] array = new int[3, 4] {
                    { 2, 5, 7, 2 },
                    { 23, 43, 3, 4 },
                    { 53, 63, 6, 61 },
                };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= array.GetLength(0); i++)
            {
                sumOfLines += array[1, i];
            }

            for (int j = 0; j < array.GetLength(0); j++)
            {
                productOfColumns *= array[j, 0];
            }

            Console.WriteLine("Сумма втрой строки равна " + sumOfLines);
            Console.WriteLine("Произведение первого столбца равна " + productOfColumns);

            Console.ReadKey();
        }
    }
}
