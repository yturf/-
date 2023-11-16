using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeopleInQueue;
            int fixedReceptionTime = 10;
            int allWaitingTimeForReception;
            int waitingHours;
            int waitingMinutes;

            Console.Write("Введите количество старушек в очереди: ");
            numberOfPeopleInQueue = Convert.ToInt32(Console.ReadLine());

            allWaitingTimeForReception = numberOfPeopleInQueue * fixedReceptionTime;
            // Следует делить на кол-во минут в часе, т. е. 60.
            waitingHours = allWaitingTimeForReception / 60;
            waitingMinutes = allWaitingTimeForReception % 60;

            Console.WriteLine("Вам нужно отстоять в очереди " + waitingHours + " часа и " + waitingMinutes + " минут.");

            Console.ReadKey();
        }
    }
}
