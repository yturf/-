using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Динамический_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            int sumArrayInitial = 0;
            int numberForArray = 0;

            string userInput = "";
            string getSumArray = "sum";
            string commandToExit = "exit";

            Console.Write("Введите размер массива: ");
            arraySize = Convert.ToInt32(Console.ReadLine());

            int[] arrayInitial = new int[arraySize];
            int[] augmentedArray = new int[arrayInitial.Length + 1];

            for (int i = 0; i < arrayInitial.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива под индексом {i}");
                arrayInitial[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("Для получения суммы всех чисел в массиве введите команду: sum.");
            Console.WriteLine("Для выхода из программы введите команду: exit.");
            Console.WriteLine("Вывод исходного массива:");

            for (int i = 0; i < arrayInitial.Length; i++)
            {
                Console.Write(arrayInitial[i] + " ");
                sumArrayInitial += arrayInitial[i];
                augmentedArray[i] = arrayInitial[i];
            }

            while (userInput != commandToExit)
            {
                Console.WriteLine("\nВведите команду: ");

                userInput = Console.ReadLine();


                if (userInput == Convert.ToString(numberForArray))
                {
                    augmentedArray[augmentedArray.Length - 1] = numberForArray;

                    for (int i = 0; i < arrayInitial.Length; i++)
                    {
                        arrayInitial[i] = augmentedArray[i];
                        Console.Write(arrayInitial[i] + " ");
                    }
                }

                if (userInput == getSumArray)
                {
                    Console.WriteLine("\nСумма всех введенных чисел массива: " + sumArrayInitial);
                }
            }
            Console.ReadKey();
        }
    }
}
