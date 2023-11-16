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
            int countOfPeopleInQueue;
            int fixedReceptionTimeInMinutes = 10;
            int allWaitingTimeForReceptionInHours;
            int waitingHours;
            int waitingMinutes;
            int quantityOfMinutesPerHour = 60;

            Console.Write("Введите количество старушек в очереди: ");
            countOfPeopleInQueue = Convert.ToInt32(Console.ReadLine());

            allWaitingTimeForReceptionInHours = countOfPeopleInQueue * fixedReceptionTimeInMinutes;
            waitingHours = allWaitingTimeForReceptionInHours / quantityOfMinutesPerHour;
            waitingMinutes = allWaitingTimeForReceptionInHours % quantityOfMinutesPerHour;

            Console.WriteLine("Вам нужно отстоять в очереди " + waitingHours + " часа и " + waitingMinutes + " минут.");

            Console.ReadKey();
        }
    }
}
