using System;

namespace Локальные_максимумы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int sizeMyArray = 30;
            int[] myArray = new int[sizeMyArray];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(0, 101);

                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();

            Console.Write("\nЛокальные максимумы массива: ");

            for (int i = 1; i < sizeMyArray - 1; i++)
            {
                if (myArray[i] > myArray[i - 1] && myArray[i] > myArray[i + 1])
                {
                    Console.Write(myArray[i] + " ");
                }
            }

            Console.WriteLine();

            if (myArray[0] > myArray[1])
            {
                Console.WriteLine("\nПервый локальный максимум: " + myArray[0]);
            }

            if (myArray[sizeMyArray - 1] > myArray[sizeMyArray - 2])
            {
                Console.WriteLine("\nПоследний локальный максимум: " + myArray[sizeMyArray - 1]);
            }

            Console.ReadKey();
        }
    }
}
