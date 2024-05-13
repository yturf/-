using System;

namespace Динамический_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandGetSumArray = "sum";
            const string CommandToExit = "exit";

            int arraySize;
            int sumArrayInitial = 0;

            string userInput = "";

            bool isWork = true;

            Console.WriteLine("Чтобы узнать сумму всех введенных чисел массива, " +
             "введите команду - sum");
            Console.WriteLine("Чтобы выйти из программы введите команду - exit");

            Console.Write("Введите размер массива: ");
            arraySize = Convert.ToInt32(Console.ReadLine());

            int[] arrayInitial = new int[arraySize];
            int[] augmentedArray = new int[arrayInitial.Length + 1];


            for (int i = 0; i < arrayInitial.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива под индексом {i}");
                arrayInitial[i] = Convert.ToInt32(Console.ReadLine());
            }

            while (isWork)
            {
                Console.WriteLine("\nИсходный массив:");

                for (int i = 0; i < arrayInitial.Length; i++)
                {
                    Console.Write(arrayInitial[i] + " ");
                }

                switch (userInput)
                {
                    case CommandGetSumArray:
                        {
                            for (int i = 0; i < arrayInitial.Length; i++)
                            {
                                augmentedArray[i] = arrayInitial[i];
                                sumArrayInitial += arrayInitial[i];
                                Console.Write(arrayInitial[i] + " ");
                            }
                            Console.WriteLine("Сумма всех введенных чисел исходного массива равна: " + sumArrayInitial);
                        }
                        break;

                    case CommandToExit:
                        {
                            isWork = false;
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("\nНовый массив:");

                            arrayInitial = augmentedArray;
                            augmentedArray[augmentedArray.Length - 1] = Convert.ToInt32(userInput);

                            for (int i = 0; i < augmentedArray.Length; i++)
                            {
                                arrayInitial[i] = augmentedArray[i];
                                Console.Write(augmentedArray[i] + " ");
                            }
                        }
                        break;

                }
            }
        }
    }
}


