using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наибольший_элемент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] A = new int[10, 10];
            int[,] newA = new int[10, 10];
            A = newA;

            int maxValue = A[0, 0];

            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = random.Next(0, 101);
                    Console.Write(A[i, j] + " ");

                    if (A[i, j] > maxValue)
                    {
                        maxValue = A[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nНаибольший элемент массива: " + maxValue + "\n");

            Console.WriteLine("Полученная матрица");

            for (int i = 0; i < newA.GetLength(0); i++)
            {
                for (int j = 0; j < newA.GetLength(1); j++)
                {
                    if (newA[i, j] == maxValue)
                    {
                        newA[i, j] = 0;
                    }
                    Console.Write(newA[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
