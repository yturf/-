using System;

namespace Прак
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDossier = "1";
            const string CommandPrintAllDossier = "2";
            const string CommandDeleteDossier = "3";
            const string CommandSearchByLastName = "4";
            const string CommandExit = "5";

            string[] employeeFullNames = { "Иванов Иван Иванович", "Петров Петр Петрович" };
            string[] employeePositions = { "Инженер", "Плотник" };

            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(5, 0);
                Console.WriteLine("Меню");
                Console.WriteLine("Добавить досье(нажмите) - " + CommandAddDossier);
                Console.WriteLine("Вывести всё досье(нажмите) - " + CommandPrintAllDossier);
                Console.WriteLine("Удалить досье(нажмите) - " + CommandDeleteDossier);
                Console.WriteLine("Поиск по фамилии(нажмите) - " + CommandSearchByLastName);
                Console.WriteLine("Выход(нажмите) - " + CommandExit);

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAddDossier:
                        Console.Write("Введите ФИО сотрудника: ");
                        string employeeFullName = Console.ReadLine();

                        Console.Write("Введите должность сотрудника: ");
                        string employeePosition = Console.ReadLine();

                        AddNewDossier(employeeFullName, employeePosition, ref employeeFullNames, ref employeePositions);

                        break;

                    case CommandPrintAllDossier:
                        PrintAllDossier(employeeFullNames, employeePositions);
                        break;

                    case CommandDeleteDossier:
                        if (employeeFullNames.Length == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Нет досье для удаления!");
                            Console.ResetColor();
                            break;
                        }

                        PrintAllDossier(employeeFullNames, employeePositions);
                        Console.Write("Введите номер досье которое хотите удалить: ");

                        if (int.TryParse(Console.ReadLine(), out int removeNumber) == false || ValidateIndex(removeNumber - 1, employeeFullNames.Length) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Некорректный номер досье!");
                            Console.ResetColor();
                            break;
                        }

                        RemoveDossier(removeNumber - 1, ref employeeFullNames, ref employeePositions);
                        break;

                    case CommandSearchByLastName:
                        SearchByLastName(employeeFullNames, employeePositions);
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ввод не распознан введите еще раз");
                        Console.ResetColor();
                        break;
                }

                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void AddNewDossier(string fullName, string position, ref string[] fullNames, ref string[] positions)
        {
            string[] newFullNames = new string[fullNames.Length + 1];
            string[] newPositions = new string[positions.Length + 1];

            int length = fullNames.Length;

            for (int i = 0; i < length; i++)
            {
                newFullNames[i] = fullNames[i];
                newPositions[i] = positions[i];
            }

            fullNames = newFullNames;
            positions = newPositions;

            fullNames[fullNames.Length - 1] = fullName;
            positions[positions.Length - 1] = position;
        }

        private static void PrintAllDossier(string[] fullNames, string[] positions)
        {
            int length = fullNames.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1}: ФИО сотрудника: {fullNames[i]}. Должность: {positions[i]}.");
            }
        }

        private static void RemoveDossier(int removeIndex, ref string[] fullNames, ref string[] positions)
        {
            string[] newFullNames = new string[fullNames.Length - 1];
            string[] newPositions = new string[positions.Length - 1];

            int length = newFullNames.Length;

            for (int i = 0, j = 0; i < length; i++, j++)
            {
                if (i == removeIndex)
                {
                    i++;
                }

                newFullNames[j] = fullNames[i];
                newPositions[j] = positions[i];
            }

            fullNames = newFullNames;
            positions = newPositions;
        }

        private static bool ValidateIndex(int index, int maxIndexLimit)
        {
            int minIndexLimit = 0;

            return index >= minIndexLimit && index < maxIndexLimit;
        }

        static void SearchByLastName(string[] fullName, string[] Position)
        {
            Console.Write("Введите фамилию для поиска: ");
            string surnameToFind = Console.ReadLine();

            string[] tempArray;
            bool doesDossierExist = false;

            for (int i = 0; i < fullName.Length; i++)
            {
                tempArray = fullName[i].Split();

                if (surnameToFind.ToLower() == tempArray[0].ToLower())
                {
                    Console.WriteLine($"ФИО сотрудник: {fullName[i]}. Должность: {Position[i]}");
                    doesDossierExist = true;
                }
            }

            if (doesDossierExist == false)
            {
                Console.WriteLine("С такой фамилией досье не найдено...");
            }
        }
    }
}

