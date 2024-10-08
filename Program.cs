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

            int numberOfSymbolOnTheLeft = - 1;
            int stack = 0;

            Console.Write($"Введите строку используя символы {leftSymbol} и {rightSymbol}: ");
            line = Console.ReadLine();
            
            for ( int i = 0; i < line.Length; i++ )
            {   
                if (line[i] == leftSymbol)
                {
                    stack++;
                    numberOfSymbolOnTheLeft++;
                }              

                else
                {
                    stack--;
                }             
            }

            if (line[0] == rightSymbol && line.Length - 1 == leftSymbol)
            {
                stack = 1;
            }

            if (stack == 0)
            {
                Console.WriteLine("Скобочное выражение является корректным." +
                    "Максимальная глубина вложенности строк равна: " + numberOfSymbolOnTheLeft);
            }

            else
            {
                Console.WriteLine("Скобочное выражение является некорректным.");
            }

            Console.ReadKey();
        }
    }
}
