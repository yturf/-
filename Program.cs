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
            String wordKeyToExit;
            wordKeyToExit = "Exit";

            Console.WriteLine("Введите имя участника: ");

            while (true)            
            {
                announcementOfListOfParticipants = Console.ReadLine();
                if (announcementOfListOfParticipants == wordKeyToExit)
                {
                    break;
                }                   
            }

            Console.ReadKey();
        }
    }
}
