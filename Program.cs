using System;

namespace Динамический_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandGetSumArray = "sum";
            const string CommandToExit = "exit";

            int arraySize = 0;

            string userInput;

            bool isWork = true;

            Console.WriteLine("Чтобы узнать сумму всех введенных чисел массива, " +
             "введите команду - " + CommandGetSumArray);
            Console.WriteLine("Чтобы выйти из программы введите команду - " + CommandToExit);
            Console.Write("\nВведите размер массива: ");

            bool resultArraySize = int.TryParse(Console.ReadLine(), out arraySize);

            if (resultArraySize)
            {

            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }

            int[] arrayInitial = new int[arraySize];

            for (int i = 0; i < arrayInitial.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива под индексом {i}");

                bool resultArrayInitial = int.TryParse(Console.ReadLine(), out arrayInitial[i]);

                if (resultArrayInitial)
                {

                }
                else
                {
                    Console.WriteLine("Некорректный ввод!");
                }
            }

            Console.WriteLine("\nИсходный массив:");

            for (int i = 0; i < arrayInitial.Length; i++)
            {
                Console.Write(arrayInitial[i] + " ");
            }

            while (isWork)
            {
                Console.WriteLine("\nВведите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandGetSumArray:
                        {
                            int sum = 0;

                            for (int i = 0; i < arrayInitial.Length; i++)
                            {
                                sum += arrayInitial[i];
                            }
                            Console.WriteLine("Сумма всех введенных чисел исходного массива равна: " + sum);
                        }
                        break;

                    case CommandToExit:
                        {
                            isWork = false;
                        }
                        break;

                    default:
                        {
                            int[] temporaryArray = new int[arrayInitial.Length + 1];

                            for (int i = 0; i < arrayInitial.Length; i++)
                            {
                                temporaryArray[i] = arrayInitial[i];
                            }
                            temporaryArray[temporaryArray.Length - 1] = Convert.ToInt32(userInput);
                            arrayInitial = temporaryArray;

                            Console.Write("\nНовый массив: ");

                            for (int i = 0; i < arrayInitial.Length; i++)
                            {
                                Console.Write(arrayInitial[i] + " ");
                            }

                        }
                        break;

                }
            }
        }
    }
}


