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

            ShowArray(array, "Исходный массив");

            Shuffle(array);

            ShowArray(array, "\nПеремешанный массив");

            Console.ReadKey();
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomElement = random.Next(array[0], array.Length);
                int currentArrayElement = array[i];

                array[i] = array[randomElement];
                array[randomElement] = currentArrayElement;
            }
        }      

        static int[] ShowArray(int[] array, string message)
        {
            Console.Write(message + ": ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            return array;
        }
    }
}
