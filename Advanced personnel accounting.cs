using System;
using System.Collections.Generic;

namespace Advanced_personnel_accounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDossier = "1";
            const string CommandPrintAllTheDossier = "2";
            const string CommandDeleteTheDossier = "3";
            const string CommandExit = "4";

            Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>()
            {
                { "Маляр", new List<string>{ "1. Иванов Пётр Сергеевич", "2. Сидоров Антоний Геннадьевич" } },
                { "Плотник", new List<string>{"1. Козлов Виталий Александрович", "2. Пугачёв Александр Григорьевич"} },
                { "Программист", new List<string>{"1. Петров Иван Петрович" } }
            };

            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(5, 0);
                Console.WriteLine("Меню");
                Console.WriteLine("Добавить досье(нажмите) - " + CommandAddDossier);
                Console.WriteLine("Вывести всё досье(нажмите) - " + CommandPrintAllTheDossier);
                Console.WriteLine("Удалить досье(нажмите) - " + CommandDeleteTheDossier);
                Console.WriteLine("Выход(нажмите) - " + CommandExit);

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAddDossier:
                        AddInListOfDossiers(employees);
                        break;

                    case CommandPrintAllTheDossier:
                        ShowDossier(employees);
                        break;

                    case CommandDeleteTheDossier:
                        RemoveDossier(employees);
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine("Ввод не распознан введите еще раз");
                        break;
                }

                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AddInListOfDossiers(Dictionary<string, List<string>> employees)
        {
            Console.WriteLine($"Введите ФИО сотрудника: ");
            string fullNames = Console.ReadLine();

            Console.WriteLine($"Введите должность сотрудника: ");
            string fullPositions = Console.ReadLine();

            AddJob(employees, fullPositions, fullNames);

            ShowDossier(employees);

            Console.Clear();
        }

        static void AddJob(Dictionary<string, List<string>> employees, string fullPositions, string fullNames)
        {
            bool haveJob = employees.ContainsKey(fullPositions);

            if (haveJob == true)
            {
                employees[fullPositions].Add(fullNames);
            }
            else
            {
                employees.Add(fullPositions, new List<string> { fullNames });
            }
        }

        static void RemoveDossier(Dictionary<string, List<string>> employees)
        {
            Console.WriteLine("Введите должность с которой хотите уволить сотрудника: ");
            string jobForDelete = Console.ReadLine();

            Console.Write("На этой должности трудится: ");

            foreach (var item in employees)
            {
                if (item.Key.ToLower() == jobForDelete.ToLower())
                {
                    Console.WriteLine(string.Join(" ", item.Value));
                }
            }

            Console.WriteLine("Введите номер сотрудника для удаления: ");
            int numberToDelete = Convert.ToInt32(Console.ReadLine());
            int numberToAdjust = 1;

            bool isInAccounting = employees.TryGetValue(jobForDelete, out List<string> names);

            if (isInAccounting)
            {
                if (employees[jobForDelete].Count > 0)
                {
                    employees[jobForDelete].RemoveAt(numberToDelete - numberToAdjust);
                }
                else
                {
                    employees.Remove(jobForDelete);
                    Console.WriteLine("Такого работника нет...");
                }
            }
        }

        static void ShowDossier(Dictionary<string, List<string>> employees)
        {
            Console.WriteLine("Список досье: ");

            int index = 1;
            string signOfSeparation = " ";

            foreach (var item in employees)
            {
                Console.WriteLine($"Сотрудник под номером {index}: {item.Key}: {string.Join(signOfSeparation, item.Value)}.");
                index++;
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
