using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string[] fullNames = { "Иванов Пётр Сергеевич", "Козлов Виталий Александрович" };
            string[] fullPositions = { "Маляр", "Плотник" };

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

                switch (userInput)
                {
                    case CommandAddDossier:
                        AddInListOfDossiers(ref fullNames, ref fullPositions);
                        break;

                    case CommandPrintAllTheDossier:
                        ShowDossier(fullNames, fullPositions);
                        break;

                    case CommandDeleteTheDossier:
                        RemoveDossier(ref fullNames, ref fullPositions);
                        break;

                    case CommandSearchByLastName:
                        SearchByLastName(fullNames, fullPositions);
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

        static void AddInListOfDossiers(ref string[] fullNames, ref string[] fullPositions)
        {
            Console.WriteLine($"Введите ФИО сотрудника: ");
            fullNames = ExpandArray(Console.ReadLine(), fullNames);

            Console.WriteLine($"Введите должность сотрудника: ");
            fullPositions = ExpandArray(Console.ReadLine(), fullPositions);

            ShowDossier(fullNames, fullPositions);

            Console.Clear();
        }

        static string[] ExpandArray(string text, string[] oldArray)
        {
            string[] tempArray = new string[oldArray.Length + 1];

            for (int i = 0; i < oldArray.Length; i++)
            {
                tempArray[i] = oldArray[i];
            }

            oldArray = tempArray;
            oldArray[oldArray.Length - 1] = text;

            return oldArray;
        }

        static string[] ReduceArray(string[] reducedArray, int index)
        {
            string[] tempArray = new string[reducedArray.Length - 1];

            for (int i = 0, j = 0; i < tempArray.Length; i++, j++)
            {
                if (j == index)
                {
                    j++;
                }

                tempArray[i] = reducedArray[j];
            }

            return tempArray;
        }

        static void ShowDossier(string[] tempFullNames, string[] tempFullPositions)
        {
            Console.WriteLine("Список досье: ");

            for (int i = 0; i < tempFullNames.Length; i++)
            {
                Console.WriteLine($"Сотрудник под номером {i + 1}: {tempFullNames[i]}: {tempFullPositions[i]}");
            }

            Console.ReadKey();
            Console.Clear();
        }

        static void RemoveDossier(ref string[] firstArray, ref string[] secondArray)
        {
            CheckNumberInput(out int indexToDelete);
            CheckNumberRange(firstArray, indexToDelete);

            firstArray = ReduceArray(firstArray, indexToDelete - 1);
            secondArray = ReduceArray(secondArray, indexToDelete - 1);            

            Console.Clear();
        }

        static void CheckNumberInput(out int indexToDelete)
        {
            Console.Write("Введите номер досье которое хотите удалить: ");

            while (int.TryParse(Console.ReadLine(), out indexToDelete) == false)
            {
                Console.Write("Введеное число не верного формата, еще раз: ");
            }
        }

        static void CheckNumberRange(string[] fullNames, int indexToDelete)
        {
            while (indexToDelete > fullNames.Length || indexToDelete <= 0)
            {
                Console.Write("Под таким номером нет сотрудника, еще раз: \n");
                CheckNumberInput(out indexToDelete);
            }
        }

        static void SearchByLastName(string[] fullNames, string[] fullPositions)
        {
            Console.Write("Введите фамилия для поиска: ");
            string surnameToFind = Console.ReadLine();

            string[] nameParts;
            bool doesDossierExist = false;

            for (int i = 0; i < fullNames.Length; i++)
            {
                nameParts = fullNames[i].Split();

                if (surnameToFind.ToLower() == nameParts[0].ToLower())
                {
                    Console.WriteLine($"ФИО сотрудника: {fullNames[i]}. Должность сотрудника: {fullPositions[i]}.");
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
