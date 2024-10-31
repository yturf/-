using System;

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

            while (true)
            {
                Console.Write("Жизней у игрока осталось: ");

                while (int.TryParse(Console.ReadLine(), out health) == false)
                {
                    Console.Clear();
                    Console.Write($"Проверьте правильность ввода! Введите число: ");
                    Console.Write("\nЖизней у игрока осталось: ");
                }

                Console.Write("Маны у игрока осталось: ");

                while (int.TryParse(Console.ReadLine(), out mana) == false)
                {
                    Console.Clear();
                    Console.Write($"Проверьте правильность ввода! Введите число: ");
                    Console.Write("\nМаны у игрока осталось: ");
                }

                Console.WriteLine("Параметры игрока\n");

                if (health <= maxHealth)
                {
                    GetBars(health, maxHealth, ConsoleColor.Red, 5, '_');
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }

                if (mana <= maxMana)
                {
                    GetBars(mana, maxMana, ConsoleColor.Blue, 6, '_');
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void GetBars(int value, int maxValue, ConsoleColor color, int position, char simvol)
        {
            if (value >= 0 && value <= maxValue)
            {
                ConsoleColor defoltColor = Console.BackgroundColor;

                string bar = "";

                for (int i = 0; i < value; i++)
                {
                    bar += simvol;
                }

                Console.SetCursorPosition(0, position);
                Console.Write("[");
                Console.BackgroundColor = color;
                Console.Write(bar);
                Console.BackgroundColor = defoltColor;

                bar = "";

                for (int i = value; i < maxValue; i++)
                {
                    bar += simvol;
                    Console.Write(" _");
                }

                Console.Write("]");
            }
            else
            {
                Console.WriteLine("\nНеверный ввод!");
            }
        }
    }
}
