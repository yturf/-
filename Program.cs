using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контроль_выхода
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String announcementOfListOfParticipants;
            String wordKeyToExit = "Exit";
            bool isWordKeyToExit;
            isWordKeyToExit = true;

            Console.WriteLine("Введите имя участника: ");

            while (isWordKeyToExit)
            {
                announcementOfListOfParticipants = Console.ReadLine();

                if (announcementOfListOfParticipants == wordKeyToExit)
                {
                    isWordKeyToExit = false;
                }
            }

            Console.ReadKey();
        }
    }
}
