using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консольное_меню
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string setPassword = "";
            string commandExit = "Esc";
            string setNameApplication = "";
            string userInput = "";

            string colorWhite = "1";
            string colorGreen = "2";
            string colorYellow = "3";

            bool isObieg = true;

            int triesCount = 3;

            Console.Write("Установите пароль для вашего приложения: ");
            setPassword = Console.ReadLine();

            Console.Clear();

            Console.Write("Будьте внимательны! У вас 3 попытки!\nВведите пароль для входа в приложение: ");

            for (int i = 0; i < triesCount; i++)
            {
                userInput = Console.ReadLine();

                if (userInput == setPassword) 
                {
                    Console.WriteLine("Пароль принят! Доступ открыт!");
                    break;
                }
                else  
                {
                    Console.WriteLine("Пароль неверный! Доступ закрыт! ");
                    Console.WriteLine("У вас осталось попыток: " + (triesCount - (i + 1)));
                }
            }

            if (userInput == setPassword)
            {
                    Console.WriteLine("Для выхода из программы введите: " + commandExit);
                    Console.WriteLine("Дайте название для приложения: ");
                    setNameApplication = Console.ReadLine();

                    Console.Clear();

                while (isObieg)
                {
                    Console.WriteLine("Задайте цвет для своей консоли:\n" +
                        colorWhite +  " - белый\n" +
                        colorGreen + " - зелёный\n" +
                        colorYellow + " - желтый");

                    Console.WriteLine("Добро пожаловать в приложение - " + setNameApplication);

                    userInput = Console.ReadLine();

                    if (userInput == commandExit || setNameApplication == commandExit)
                    {
                        isObieg = false;

                    }
                     if (userInput == colorWhite)
                     {
                         Console.BackgroundColor = ConsoleColor.White;
                     }
                     else if (userInput == colorGreen)
                     {
                         Console.BackgroundColor = ConsoleColor.Green;
                     }
                     else if (userInput == colorYellow)
                     {
                         Console.BackgroundColor = ConsoleColor.Yellow;
                     }
                }
            }                             
        }
    }
}
