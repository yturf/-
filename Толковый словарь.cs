using System;
using System.Collections.Generic;

namespace Толковый_словарь
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> explanatoryDictionary = new Dictionary<string, string>();

            explanatoryDictionary.Add("Друг", "человек, близкий по духу");
            explanatoryDictionary.Add("Забота", "внимание, поддержка, оказание помощи");
            explanatoryDictionary.Add("Задабривание", "умасливание лестью, услугами, подарками");

            const string CommandExit = "Выйти";

            bool isOpen = true;

            Console.WriteLine("Все слова в словаре.");
            Console.WriteLine("--------------------");

            foreach (var key in explanatoryDictionary.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("Введите слово, значение которого хотите узнать:");

            Console.WriteLine("Для выхода из словаря введите - " + CommandExit);

            while (isOpen)
            {
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == CommandExit.ToLower())
                    isOpen = false;

                else
                    GetWord(explanatoryDictionary, userInput);
            }
        }

        static void GetWord(Dictionary<string, string> dictionary, string needWord)
        {
            if (dictionary.ContainsKey(needWord))
            {
                if (dictionary.TryGetValue(needWord, out string word))
                {
                    Console.WriteLine($"Слово - {needWord}. Его значение - {word}.");
                }
            }
            else
                Console.WriteLine("Такого слова нет...");
        }
    }
}
