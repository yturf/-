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

            char symbol;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите один символ: " );
            symbol = Convert.ToChar(Console.ReadLine());

            name = symbol + name + symbol;

            Console.Clear();

            for (int i = 0; i < name.Length; i++) 
            {
                lineSymbols += symbol;
            }

            Console.WriteLine(lineSymbols);
            Console.WriteLine(name);
            Console.WriteLine(lineSymbols);

            Console.ReadKey();
        }
    }
}
