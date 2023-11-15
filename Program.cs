using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeopleInQueue;
            int fixedReceptionTime = 10;
            int hour;
            int minute;

            Console.Write("Введите количество старушек в очереди: ");
            numberOfPeopleInQueue = Convert.ToInt32(Console.ReadLine());

            hour = numberOfPeopleInQueue * fixedReceptionTime / 60;
            minute = numberOfPeopleInQueue * fixedReceptionTime % 60;

            Console.WriteLine("Вам нужно отстоять в очереди " + hour + " часа и " + minute + " минут.");
                     
            Console.ReadKey();

        }
    }
}
