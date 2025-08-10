using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Толковый_словарь
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ExplanatoryDictionary = new Dictionary<string, string>();

            ExplanatoryDictionary.Add("Друг", "человек, близкий по духу");
            ExplanatoryDictionary.Add("Забота", "внимание, поддержка, оказание помощи");
            ExplanatoryDictionary.Add("Задабривание", "умасливание лестью, услугами, подарками");

            const string CommandExit = "Выйти";

            bool isOpen = true;

            Console.WriteLine("Все слова в словаре.");
            Console.WriteLine("--------------------");

            foreach (var key in ExplanatoryDictionary.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("Введите слово, значение которого хотите узнать:");

            Console.WriteLine("Для выхода из словаря введите - " + CommandExit);

            while (isOpen)
            {
                string userInput = Console.ReadLine();

                if (userInput == GetWord(ExplanatoryDictionary, userInput))
                if (userInput.ToLower() == CommandExit.ToLower())
                    isOpen = false;
                else
                    Console.WriteLine("Такого слова нет...");
            }

        }
        static string GetWord(Dictionary<string, string> dictionary, string needWord)
        {
            foreach (var key in dictionary)
            {
                if (needWord == key.Key)
                {
                    Console.WriteLine($"Слово - {key.Key}. Его значение - {key.Value}.");
                }
            }

            return needWord;
        }
    }
}
