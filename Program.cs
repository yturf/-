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
            int valueInitial = 5;
            int magnificationSize = 7;
            int maxValue = 97;

            for (int i = valueInitial; i < maxValue; i += magnificationSize)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
