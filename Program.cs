using System;

namespace Кадровый_учет
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
                        AddDossier(ref employeeFullNames, ref employeePositions);
                        break;

                    case CommandPrintAllDossier:
                        PrintAllDossier(employeeFullNames, employeePositions);
                        break;

                    case CommandDeleteDossier:
                        RemoveDossier(ref employeeFullNames, ref employeePositions);
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

        private static void AddDossier(ref string[] fullNames, ref string[] positions)
        {
            Console.Write("Введите ФИО сотрудника: ");
            string employeeFullName = Console.ReadLine();

            Console.Write("Введите должность сотрудника: ");
            string employeePosition = Console.ReadLine();

            fullNames = AddElement(fullNames, employeeFullName);
            positions = AddElement(positions, employeePosition);
        }

        private static string[] AddElement(string[] dossier, string element)
        {
            string[] tempArray = new string[dossier.Length + 1];

            int length = dossier.Length;

            for (int i = 0; i < length; i++)
            {
                tempArray[i] = dossier[i];
            }

            tempArray[dossier.Length] = element;

            return tempArray;
        }

        private static void PrintAllDossier(string[] fullNames, string[] positions)
        {
            int length = fullNames.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i + 1}: ФИО сотрудника: {fullNames[i]}. Должность: {positions[i]}.");
            }
        }

        private static void RemoveDossier(ref string[] fullNames, ref string[] positions)
        {
            if (fullNames.Length == 0)
            {
                ChangeColor(ConsoleColor.Red, "Нет досье для удаления!");
                return;
            }

            PrintAllDossier(fullNames, positions);

            Console.Write("Введите номер досье которое хотите удалить: ");

            if (int.TryParse(Console.ReadLine(), out int numberToDelete) == false || ValidateIndexRange(numberToDelete - 1, fullNames.Length) == false)
            {
                ChangeColor(ConsoleColor.Red, "Некорректный номер досье!");
                return;
            }

            int convertIndex = numberToDelete - 1;

            fullNames = RemoveElement(convertIndex, fullNames);
            positions = RemoveElement(convertIndex, positions);
        }

        private static string[] RemoveElement(int removeIndex, string[] array)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i < removeIndex; i++)
            {
                tempArray[i] = array[i];
            }

            for (int i = removeIndex + 1; i < array.Length; i++)
            {
                tempArray[i - 1] = array[i];
            }

            return tempArray;
        }

        private static bool ValidateIndexRange(int index, int maxIndexLimit)
        {
            int minIndexLimit = 0;

            return index >= minIndexLimit && index < maxIndexLimit;
        }

        static void SearchByLastName(string[] fullName, string[] Position)
        {
            Console.Write("Введите фамилию для поиска: ");
            string surnameToFind = Console.ReadLine();

            string[] tempArray;
            bool isDossierExist = false;

            for (int i = 0; i < fullName.Length; i++)
            {
                tempArray = fullName[i].Split();

                if (surnameToFind.ToLower() == tempArray[0].ToLower())
                {
                    Console.WriteLine($"ФИО сотрудник: {fullName[i]}. Должность: {Position[i]}");
                    isDossierExist = true;
                }
            }

            if (isDossierExist == false)
            {
                ChangeColor(ConsoleColor.Red,"С такой фамилией досье не найдено...");
            }
        }

        private static void ChangeColor(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
