using System;
using System.Collections.Generic;

namespace Dynamic_array_advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandFindSum = "Sum";
            const string CommandExit = "Exit";

            List<int> numbers = new List<int>();

            bool isOpen = true;

            Console.WriteLine($"Команды для ввода:\n1.{CommandFindSum}\n2.{CommandExit}");
            Console.WriteLine("Введите числа или команду: ");

            while (isOpen)
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandFindSum:
                        ShowSum(SumAllNumbers(numbers));
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;

                    default:
                        AddNumbersToList(numbers, userInput);
                        break;
                }
            }
        }

        private static void AddNumbersToList(List<int> list, string userInput)
        {
            int number;

            if (int.TryParse(userInput, out number) == false)
            {
                Console.Write("Введеное число не верного формата, еще раз: ");
            }
            else
            {
                list.Add(number);
            }
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
    }
}
