using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Освоение_циклов1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String announcementOfListOfParticipants;
            int countOfParticipants;

            Console.Write("Введите количество участников в списке: ");
            countOfParticipants = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите имя участника: ");

            while (countOfParticipants-- > 0)
            {
                announcementOfListOfParticipants = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }   
}
