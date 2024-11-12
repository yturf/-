using System;

namespace Health_Bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float healthPercent = 100;
            float manaPercent = 100;
            float barLength = 10;

            bool isWork = true;

            while (isWork)
            {
                Console.Write("Жизней у игрока осталось: ");
                healthPercent = ReadPercent();

                Console.Write("Маны у игрока осталось: ");
                manaPercent = ReadPercent();

                Console.WriteLine("Параметры игрока\n");

                OutputBars("Здоровье: ", healthPercent, barLength, 4, '#');
                OutputBars("Мана: ", manaPercent, barLength, 5, '#');

                Console.ReadKey();
                Console.Clear();
            }
        }

        static string CreatorOfTheLine(int length, char simbol)
        {
            return new string(simbol, length);
        }

        static void OutputBars(string message, float percent, float length, int position, char simbol)
        {
            int maxPercent = 100;
            int filledLength = (int)(length * (percent / maxPercent));

            Console.SetCursorPosition(0, position);
            Console.Write($"{message}[");

            Console.Write(CreatorOfTheLine(filledLength, simbol));
            Console.Write(CreatorOfTheLine((int)length - filledLength, '_'));

            Console.Write("]");
        }

        static int ReadPercent()
        {
            int percent = 0;
            int minPercentValue = 0;
            int maxPercentValue = 100;

            bool isValidInput = true;

            while (isValidInput)
            {
                string inputPercent = Console.ReadLine();

                if (int.TryParse(inputPercent, out percent) && percent >= minPercentValue && percent <= maxPercentValue)
                {
                    isValidInput = false;
                }
                else
                {
                    Console.WriteLine($"Проверьте правильность ввода! Введите число от " +
                        $"{minPercentValue} до {maxPercentValue}.");
                }
            }

            return percent;
        }
    }
}
