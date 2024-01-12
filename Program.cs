using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вывод_имени
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string lineSymbols = "";
            string middleLine = "";

            char symbol;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите один символ: " );
            symbol = Convert.ToChar(Console.Read());

            middleLine = symbol + name + symbol;

            Console.Clear();

            for (int i = 0; i < middleLine.Length; i++) 
            {
                lineSymbols += symbol;
            }

            Console.WriteLine(lineSymbols);
            Console.WriteLine(middleLine);
            Console.WriteLine(lineSymbols);

            Console.ReadKey();
        }
    }
}
