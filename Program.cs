using System;

namespace Кадровый_учёт
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDossier = "1";
            const string CommandPrintAllTheDossier = "2";
            const string CommandDeleteTheDossier = "3";
            const string CommandSearchByLastName = "4";
            const string CommandExit = "5";

            string[] listInitials = { "Иванов Пётр Сергеевич", "Козлов Виталий Александрович" };
            string[] listPositions = { "Маляр", "Плотник" };

            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(5, 0);
                Console.WriteLine("Меню");
                Console.WriteLine("Добавить досье(нажмите) - " + CommandAddDossier);
                Console.WriteLine("Вывести всё досье(нажмите) - " + CommandPrintAllTheDossier);
                Console.WriteLine("Удалить досье(нажмите) - " + CommandDeleteTheDossier);
                Console.WriteLine("Поиск по фамилии(нажмите) - " + CommandSearchByLastName);
                Console.WriteLine("Выход(нажмите) - " + CommandExit);

                string userInput = Console.ReadLine();
                int index = 0;

                switch (userInput)
                {
                    case CommandAddDossier:
                        AddInListOfDossiers(ref listInitials, ref listPositions);
                        break;
                    case CommandPrintAllTheDossier:
                        ShowDossier(listInitials, listPositions);
                        break;
                    case CommandDeleteTheDossier:
                        RemoveAt(ref listInitials, ref listPositions, ref index);
                        break;
                    case CommandSearchByLastName:
                        SearchByLastName(listInitials, listPositions);
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

        static void AddInListOfDossiers(ref string[] listInitials, ref string[] listPositions)
        {
            Console.WriteLine($"Введите ФИО сотрудника: ");
            listInitials = AddDossier(Console.ReadLine(), listInitials);

            Console.WriteLine($"Введите должность сотрудника: ");
            listPositions = AddDossier(Console.ReadLine(), listPositions);

            ShowDossier(listInitials, listPositions);

            Console.Clear();
        }

        static string[] AddDossier(string text, string[] oldArray)
        {
            oldArray = ExpandArray(oldArray);
            oldArray[oldArray.Length - 1] = text;

            return oldArray;
        }

        static string[] ExpandArray(string[] oldArray)
        {
            string[] tempArray = new string[oldArray.Length + 1];

            for (int i = 0; i < oldArray.Length; i++)
            {
                tempArray[i] = oldArray[i];
            }

            return tempArray;
        }

        static void ShowDossier(string[] tempListInitials, string[] tempListPositions)
        {
            Console.WriteLine("Список досье: ");

            for (int i = 0; i < tempListInitials.Length; i++)
            {
                Console.WriteLine($"Сотрудник под номером {i + 1}: {tempListInitials[i]}: {tempListPositions[i]}");
            }

            Console.ReadKey();
            Console.Clear();
        }

        static void RemoveAt(ref string[] firstArray, ref string[] secondArray, ref int index)
        {
            CheckingTheInputForDeletion(ref firstArray, ref secondArray);

            string[] newFirstArray = new string[firstArray.Length - 1];
            string[] newSecondArray = new string[secondArray.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newFirstArray[i] = firstArray[i];
                newSecondArray[i] = secondArray[i];
            }

            for (int i = index + 1; i < firstArray.Length && i < secondArray.Length; i++)
            {
                newFirstArray[i - 1] = firstArray[i];
                newSecondArray[i - 1] = secondArray[i];
            }

            firstArray = newFirstArray;
            secondArray = newSecondArray;

            Console.Clear();
        }

        static void CheckingTheInputForDeletion(ref string[] listInitials, ref string[] listPositions)
        {
            Console.Write("Введите номер досье которое хотите удалить: ");

            while (int.TryParse(Console.ReadLine(), out int indexToDelete) == false || indexToDelete > listInitials.Length || indexToDelete <= 0)
            {
                Console.Write("Введеное число не верного формата или под номером нет такого сотрудника, еще раз: ");
            }
        }

        static void SearchByLastName(string[] listInitials, string[] listPositions) 
        {
            Console.Write("Введите фамилия для поиска: ");
            string surnameToFind = Console.ReadLine();

            char space = ' ';
            string[] tempArray;
            bool doesDossierExist = false;

            for (int i = 0; i < listInitials.Length; i++)
            {
                tempArray = listInitials[i].Split(space);

                if (surnameToFind.ToLower() == tempArray[0].ToLower())
                {
                    Console.WriteLine($"ФИО сотрудника: {listInitials[i]}. Должность сотрудника: {listPositions[i]}.");
                    doesDossierExist = true;
                }
            }

            if (doesDossierExist == false)
            {
                Console.WriteLine("С такой фамилией досье не найдено!");
            }
        }
    }
}
