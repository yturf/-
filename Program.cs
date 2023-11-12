using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSiign;
            string placeOfWork;
            Console.Write("Как вас зовут? ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кто вы по знаку зодиака? ");
            zodiacSiign = Console.ReadLine();
            Console.Write("Где вы работаете? ");
            placeOfWork = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, вам {age} год, вы {zodiacSiign} и работаете на {placeOfWork}");
            Console.ReadKey();
        }
    }
}
