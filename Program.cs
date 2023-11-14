using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перестановка_местами1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "ivanov";
            string surname = "petr";

            Console.WriteLine(name);
            Console.WriteLine(surname);

            string name1 = name;
            name = surname;
            surname = name1;

            Console.WriteLine(name);
            Console.WriteLine(surname);

            Console.ReadKey();
        }
    }
}
