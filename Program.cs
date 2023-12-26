using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конвертор_валют
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saleCurrency; 
            string purchaseCurrency;           

            double balanceInRUB;
            double balanceInUSD;
            double balanceInEUR;

            double rateRUBtoUSD = 0.01;
            double rateRUBtoEUR = 0.01;

            double rateUSDtoRUB = 88.61;
            double rateUSDtoEUR = 0.91;

            double rateEURtoRUB = 97.06;
            double rateEURtoUSD = 1.09;

            double compareSum = 0;
            double amountOfCurrencySale = 0; 

            Console.WriteLine("Добро пожаловать в наш конвертор валют!");
            Console.Write("Введите количество рублей на вашем счёте: ");
            balanceInRUB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество долларов на вашем счёте: ");
            balanceInUSD = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество евро на вашем счёте: ");
            balanceInEUR = Convert.ToDouble(Console.ReadLine());

            Console.Write("Какую валюту вы хотите продать?\n 1 - рубли, 2 - доллары, 3 - евро.\n");
            saleCurrency = Console.ReadLine();

            if (saleCurrency == "1")
                compareSum = balanceInRUB;
            else if (saleCurrency == "2")
                compareSum = balanceInUSD;
            else if (saleCurrency == "3")
                compareSum = balanceInEUR;

            Console.Write("На какую сумму вы хотите продать?\n");
            amountOfCurrencySale = Convert.ToDouble(Console.ReadLine());

            Console.Write("В какую валюту вы хотите конвертировать средства?\n 1 - в рубли, 2 - в доллары, 3 - в евро.\n");
            purchaseCurrency = Console.ReadLine();

            if (purchaseCurrency == "1")
            {
                if (saleCurrency == "2")
                {
                    balanceInRUB += Convert.ToDouble(amountOfCurrencySale) * rateUSDtoRUB;
                    balanceInUSD -= amountOfCurrencySale;
                }
                else if (saleCurrency == "3")
                {
                    balanceInRUB += Convert.ToDouble(amountOfCurrencySale) * rateEURtoRUB;
                    balanceInEUR -= amountOfCurrencySale;
                }
            }

            if (purchaseCurrency == "2")
            {
                if (saleCurrency == "1")
                {
                    balanceInUSD += Convert.ToDouble(amountOfCurrencySale) * rateRUBtoUSD;
                    balanceInRUB -= amountOfCurrencySale;
                }
                else if (saleCurrency == "3")
                {
                    balanceInUSD += Convert.ToDouble(amountOfCurrencySale) * rateEURtoUSD;
                    balanceInEUR -= amountOfCurrencySale;
                }
            }

            if (purchaseCurrency == "3")
            {
                if (saleCurrency == "1")
                {
                    balanceInEUR += Convert.ToDouble(amountOfCurrencySale) * rateRUBtoEUR;
                    balanceInRUB -= amountOfCurrencySale;
                }
                else if (saleCurrency == "2")
                {
                    balanceInEUR += Convert.ToDouble(amountOfCurrencySale) * rateUSDtoEUR;
                    balanceInUSD -= amountOfCurrencySale;
                }
            }

            Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRUB} рублей, " +
                $"{balanceInUSD} долларов, и {balanceInEUR} евро.\n");

            Console.WriteLine("Для выхода из программы введите: Exit");
            Console.ReadLine();         
        }
    }
}
