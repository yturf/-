using System;

namespace Скобочное_выражение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;

            char leftSymbol = '(';
            char rightSymbol = ')';

            int maxDepth = 0;
            int stack = 0;

            Console.Write($"Введите строку используя символы {leftSymbol} и {rightSymbol}: ");
            line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == leftSymbol)
                {
                    stack++;
                    maxDepth++;
                }

                else
                {
                    stack--;
                }
            }

            if (line[0] == rightSymbol && line[line.Length - 1] == leftSymbol)
            {
                stack = 1;
            }

            if (stack == 0)
            {
                Console.WriteLine("Скобочное выражение является корректным." +
                    "Максимальная глубина вложенности строк равна: " + maxDepth);
            }

            else
            {
                Console.WriteLine("Скобочное выражение является некорректным.");
            }

            Console.ReadKey();
        }
    }
}
