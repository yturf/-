using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Конвертер_валют
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balanceInRub;
            double balanceInUsd;
            double balanceInEur;

            double rateRubToUsd = 0.01;
            double rateRubToEur = 0.01;

            double rateUsdToRub = 88.61;
            double rateUsdToEur = 0.91;

            double rateEurToRub = 97.06;
            double rateEurToUsd = 1.09;

            string typeOfOperation = "";
            string wordToExit = "";
            double amountOfCurrencySale = 0;

            string commandToExchangeRubForUsd = "1";
            string commandToExchangeRubForEur = "2";
            string commandToExchangeUsdForRub = "3";
            string commandToExchangeUsdForEur = "4";
            string commandToExchangeEurForRub = "5";
            string commandToExchangeEurForUsd = "6";

            Console.WriteLine("Добро пожаловать в наш конвертор валют!");

            Console.Write("Введите количество рублей на вашем счёте: ");
            balanceInRub = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество долларов на вашем счёте: ");
            balanceInUsd = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество евро на вашем счёте: ");
            balanceInEur = Convert.ToDouble(Console.ReadLine());

            while (wordToExit != "Exit")
            {
                Console.Write("Какую операцию вы хотите провести?\n" +
                   "1 - обменять рубли на доллары, 2 - обменять рубли на евро.\n" +
                   "3 - обменять доллары на рубли, 4 - обменять доллары на евро.\n" +
                   "5 - обменять евро на рубли, 6 - обменять евро на доллары.\n" +
                   "");
                typeOfOperation = Console.ReadLine();

                Console.Write("На какую сумму вы хотите продать?\n");
                amountOfCurrencySale = Convert.ToDouble(Console.ReadLine());

                if (typeOfOperation == commandToExchangeRubForUsd)
                {
                    if (balanceInRub > amountOfCurrencySale)
                    {
                        balanceInUsd = balanceInRub + Convert.ToDouble(amountOfCurrencySale) * rateRubToUsd;
                        balanceInRub -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                if (typeOfOperation == commandToExchangeRubForEur)
                {
                    if (balanceInRub > amountOfCurrencySale)
                    {
                        balanceInEur = balanceInRub + Convert.ToDouble(amountOfCurrencySale) * rateRubToEur;
                        balanceInRub -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                if (typeOfOperation == commandToExchangeUsdForRub)
                {
                    if (balanceInUsd > amountOfCurrencySale)
                    {
                        balanceInRub = balanceInUsd + Convert.ToDouble(amountOfCurrencySale) * rateUsdToRub;
                        balanceInUsd -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                if (typeOfOperation == commandToExchangeUsdForEur)
                {
                    if (balanceInUsd > amountOfCurrencySale)
                    {
                        balanceInEur = balanceInUsd + Convert.ToDouble(amountOfCurrencySale) * rateUsdToEur;
                        balanceInUsd -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                if (typeOfOperation == commandToExchangeEurForRub)
                {
                    if (balanceInEur > amountOfCurrencySale)
                    {
                        balanceInRub = balanceInEur + Convert.ToDouble(amountOfCurrencySale) * rateEurToRub;
                        balanceInEur -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                if (typeOfOperation == commandToExchangeEurForUsd)
                {
                    if (balanceInEur > amountOfCurrencySale)
                    {
                        balanceInUsd = balanceInEur + Convert.ToDouble(amountOfCurrencySale) * rateEurToUsd;
                        balanceInEur -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }
                Console.WriteLine("Для продолжения нажмите Enter,\n" +
                      "Для выхода из программы введите Exit и нажмите Enter");

                wordToExit = Console.ReadLine();
            }
        }
    }
}
