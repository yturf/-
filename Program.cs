using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            string userInput = "";
            string wordToExit = "Exit";
            double amountOfCurrencySale = 0;
            bool obieg = true;

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

            while (obieg != Convert.ToBoolean(wordToExit))
            {
                Console.Write("Какую операцию вы хотите провести?\n" +
                   commandToExchangeRubForUsd + " - обменять рубли на доллары, " + 
                   commandToExchangeRubForEur + " - обменять рубли на евро.\n" +
                   commandToExchangeUsdForRub + " - обменять доллары на рубли, " +
                   commandToExchangeUsdForEur + " - обменять доллары на евро.\n" +
                   commandToExchangeEurForRub + " - обменять евро на рубли, " +
                   commandToExchangeEurForUsd + " - обменять евро на доллары.\n" +
                   "");
                userInput = Console.ReadLine();

                Console.Write("На какую сумму вы хотите продать?\n");
                amountOfCurrencySale = Convert.ToDouble(Console.ReadLine());

                if (userInput == commandToExchangeRubForUsd)
                {
                    if (balanceInRub > amountOfCurrencySale)
                    {
                        balanceInUsd = balanceInRub + amountOfCurrencySale * rateRubToUsd;
                        balanceInRub -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else 
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                else if (userInput == commandToExchangeRubForEur)
                {
                    if (balanceInRub > amountOfCurrencySale)
                    {
                        balanceInEur = balanceInRub + amountOfCurrencySale * rateRubToEur;
                        balanceInRub -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else 
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                else if (userInput == commandToExchangeUsdForRub)
                {
                    if (balanceInUsd > amountOfCurrencySale)
                    {
                        balanceInRub = balanceInUsd + amountOfCurrencySale * rateUsdToRub;
                        balanceInUsd -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                else if (userInput == commandToExchangeUsdForEur)
                {
                    if (balanceInUsd > amountOfCurrencySale)
                    {
                        balanceInEur = balanceInUsd + amountOfCurrencySale * rateUsdToEur;
                        balanceInUsd -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                else if (userInput == commandToExchangeEurForRub)
                {
                    if (balanceInEur > amountOfCurrencySale)
                    {
                        balanceInRub = balanceInEur + amountOfCurrencySale * rateEurToRub;
                        balanceInEur -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }

                else if (userInput == commandToExchangeEurForUsd)
                {
                    if (balanceInEur > amountOfCurrencySale)
                    {
                        balanceInUsd = balanceInEur + amountOfCurrencySale * rateEurToUsd;
                        balanceInEur -= amountOfCurrencySale;
                        Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
                        $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }  
                else if (userInput == wordToExit)
                {
                    return;
                }
                Console.WriteLine("Для продолжения нажмите Enter,\n" +
                      "Для выхода из программы введите Exit и нажмите Enter");

                wordToExit = Console.ReadLine();
            }
        }
    }
}
