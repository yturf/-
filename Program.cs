using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Освоение_циклов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String proverb;
            int numberOfRepetitionsOfProverb;

            Console.Write("Введите количество повторений пословицы для запоминания: ");
            numberOfRepetitionsOfProverb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите текст пословицы: ");
            proverb = Console.ReadLine();

            for (int i = 1; i <= numberOfRepetitionsOfProverb; i++ )
            {
                Console.WriteLine(proverb);
            }

            Console.ReadKey();
        }
    }
}
