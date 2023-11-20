using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Последовательность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            int magnificationSize = 7;
            int maxValue = 97;

            for (value = 5; value < maxValue; value += magnificationSize)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
