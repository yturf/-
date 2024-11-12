using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Канзас_сити_шафл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6] { 4, 6, 9, 11, 2, 7 };

            Show(array, "Исходный массив");

            Shuffle(array);

            Show(array, "\nПеремешанный массив");

            Console.ReadKey();
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomIndexElement = random.Next(array[0], array.Length);
                int currentArrayElement = array[i];

                array[i] = array[randomIndexElement];
                array[randomIndexElement] = currentArrayElement;
            }
        }      

        static void Show(int[] array, string message)
        {
            Console.Write(message + ": ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
