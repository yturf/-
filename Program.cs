using System;
using System.Diagnostics.Eventing.Reader;

namespace Health_Bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health;
            int maxHealth = 10;
            int mana;
            int maxMana = 10;

            bool isWork = true;

            while (isWork)
            {
                Console.Write("Жизней у игрока осталось: ");

                CheckInputHealth(out health);

                Console.Write("Маны у игрока осталось: ");

                CheckInputMana(out mana);

                if (health <= maxHealth && mana <= maxMana)
                {
                    Console.WriteLine("Параметры игрока\n");

                    GetBars(health, maxHealth, ConsoleColor.Red, 5, '_');
                    GetBars(mana, maxMana, ConsoleColor.Blue, 6, '_');

                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }                         

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void GetBars(int value, int maxValue, ConsoleColor color, int position, char simbol)
        {
            if (value >= 0 && value <= maxValue)
            {
                ConsoleColor defoltColor = Console.BackgroundColor;

                string bar = "";

                for (int i = 0; i < value; i++)
                {
                    bar += simbol;
                }

                Console.SetCursorPosition(0, position);
                Console.Write("[");
                Console.BackgroundColor = color;
                Console.Write(bar);
                Console.BackgroundColor = defoltColor;

                bar = "";

                for (int i = value; i < maxValue; i++)
                {
                    bar += simbol;
                    Console.Write(" _");
                }

                Console.Write("]");
            }
            else
            {
                Console.WriteLine("\nНеверный ввод!");
            }
        }

        static void CheckInputHealth(out int health)
        {
            while (int.TryParse(Console.ReadLine(), out health) == false)
            {
                Console.Clear();
                Console.Write($"Проверьте правильность ввода! Введите число: ");
                Console.Write("\nЖизней у игрока осталось: ");
            }
        }

        static void CheckInputMana(out int mana)
        {
            while (int.TryParse(Console.ReadLine(), out mana) == false)
            {
                Console.Clear();
                Console.Write($"Проверьте правильность ввода! Введите число: ");
                Console.Write("\nМаны у игрока осталось: ");
            }
        }
    }
}
