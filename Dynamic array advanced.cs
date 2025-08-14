using System;
using System.Collections.Generic;

namespace Dynamic_array_advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandFindSum = "Sum";
            const string CommandAddNumber = "Add";
            const string CommandShowList = "Show";
            const string CommandExit = "Exit";

            List<int> numbers = new List<int>();

            bool isOpen = true;

            Console.WriteLine("Команды для ввода:\n1.Sum\n2.Add\n3.Show\n4.Exit");
            Console.WriteLine("Введите команду: ");

            while (isOpen)
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAddNumber:
                        AddNumbersToList(numbers);
                        break;

                    case CommandFindSum:
                        ShowSum(SumAllNumbers(numbers));
                        break;

                    case CommandShowList:
                        ShowList(numbers);
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine("Ввод не распознан введите еще раз");
                        break;
                }
            }
        }

        private static void AddNumbersToList(List<int> list)
        {
            int number = 0;

            Console.WriteLine("Введите число: ");

            ValidateNumber(ref number);

            list.Add(number);
        }

        private static int SumAllNumbers(List<int> list)
        {
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                count += list[i];
            }

            return count;
        }

        private static void ShowSum(int count)
        {
            Console.WriteLine(count);
        }

        private static void ValidateNumber(ref int number)
        {
            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write("Введеное число не верного формата, еще раз: ");
            }
        }

        private static void ShowList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}
