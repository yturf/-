using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сдвиг_значений_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int lastNumber = 9;

            int[] array = new int[5] { 4, 6, 8, 33, 9 };

            int userInput;

            Console.Write("Массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.Write("\nУкажите значение для сдвига массива влево: ");
            userInput = Convert.ToInt32(Console.Read());

            for (int i = 0; i < userInput; i++)
            {
                int lastArray = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                    array[j] = array[j - 1];
                array[0] = lastArray;
            }

            Console.WriteLine("Сдвинутый массив: ");

            for (int i = 0; i < array.Length; ++i)

            Console.Write(array[i] + " ");
            Console.ReadKey();
        }
    }
}
