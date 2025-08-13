using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Динамический_массив_продвинутый
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandFindSum = "Sum";
            const string CommandAddNumber = "Add";
            const string CommandShowList = "Show";
            const string CommandExit = "Exit";

            List<int> numbersList = new List<int>();

            bool isOpen = true;

            Console.WriteLine("Команды для ввода:\n1.Sum\n2.Add\n3.Show\n4.Exit");
            Console.WriteLine("Введите команду: ");

            while (isOpen)
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAddNumber:
                        AddNumbersToList(numbersList);
                        break;

                    case CommandFindSum:
                        SumOllNumbers(numbersList);
                        break;

                    case CommandShowList:
                        ShowList(numbersList);
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

        private static List<int> AddNumbersToList(List<int> list)
        {
            int number = 0;

            number = EnteringNumber(number);

            list.Add(number);

            return list;
        }

        private static void SumOllNumbers(List<int> list)
        {
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                count += list[i];
            }

            Console.WriteLine(count);
        }

        private static int EnteringNumber(int number)
        {
            Console.WriteLine("Введите число: ");

            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write("Введеное число не верного формата, еще раз: ");
            }

            return number;
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
