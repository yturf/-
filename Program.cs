using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магазин_кристаллов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int crystals;
            int crystalUnitPrice = 15;

            Console.Write("Сколько у вас золота? ");
            money = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Здраствуйте! Один кристалл у нас стоит {crystalUnitPrice} золотых монет. Сколько вы хотите купить? ");
            crystals = Convert.ToInt32(Console.ReadLine());

            money -= crystals * crystalUnitPrice;
            Console.Write($"Вы купили {crystals} кристаллов и у вас осталось {money} монет.");

            Console.ReadKey();
        }
    }
}
