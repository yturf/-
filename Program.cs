using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Конвертор_валют_1
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
            double amountOfCurrencySale = 0;
            string wordToExit = "";

            Console.WriteLine("Добро пожаловать в наш конвертор валют!");
            Console.WriteLine("Для выхода из программы введите: Exit");

                Console.Write("Введите количество рублей на вашем счёте: ");
             balanceInRub = Convert.ToDouble(Console.ReadLine());

             Console.Write("Введите количество долларов на вашем счёте: ");
             balanceInUsd = Convert.ToDouble(Console.ReadLine());

             Console.Write("Введите количество евро на вашем счёте: ");
             balanceInEur = Convert.ToDouble(Console.ReadLine());

            while (wordToExit != "Exit")
            {               
             Console.Write("Какую операцию вы хотите провести?\n1 - обменять рубли на доллары, 2 - обменять рубли на евро.\n" +
                "3 - обменять доллары на рубли, 4 - обменять доллары на евро.\n" +
                "5 - обменять евро на рубли, 6 - обменять евро на доллары.\n" +
                "");
             typeOfOperation = Console.ReadLine();

             Console.Write("На какую сумму вы хотите продать?\n");
             amountOfCurrencySale = Convert.ToDouble(Console.ReadLine());

             if (typeOfOperation == "1")
             {
                balanceInUsd = balanceInRub + Convert.ToDouble(amountOfCurrencySale) * rateRubToUsd;
                balanceInRub -= amountOfCurrencySale;
             }

             if (typeOfOperation == "2")
             {
                balanceInEur = balanceInRub + Convert.ToDouble(amountOfCurrencySale) * rateRubToEur;
                balanceInRub -= amountOfCurrencySale;
             }

             if (typeOfOperation == "3")
             {
                balanceInRub = balanceInUsd + Convert.ToDouble(amountOfCurrencySale) * rateUsdToRub;
                balanceInUsd -= amountOfCurrencySale;
             }

             if (typeOfOperation == "4")
             {
                balanceInEur = balanceInUsd + Convert.ToDouble(amountOfCurrencySale) * rateUsdToEur;
                balanceInUsd -= amountOfCurrencySale;
             }

             if (typeOfOperation == "5")
             {
                balanceInRub = balanceInEur + Convert.ToDouble(amountOfCurrencySale) * rateEurToRub;
                balanceInEur -= amountOfCurrencySale;
             }

             if (typeOfOperation == "6")
             {
                balanceInUsd = balanceInEur + Convert.ToDouble(amountOfCurrencySale) * rateEurToUsd;
                balanceInEur -= amountOfCurrencySale;
                 if (balanceInRub < 0 || balanceInUsd < 0 || balanceInEur < 0) 
                 {               
                    Console.WriteLine("У вас недостаточно средств");                    
                 }            
             }
           
             Console.Write($"Обмен валюты произведен. На вашем счету:\n{balanceInRub} рублей, " +
             $"{balanceInUsd} долларов, и {balanceInEur} евро.\n");

             Console.WriteLine("Для продолжения нажмите Enter,\n" +
                   "Для выхода из программы введите Exit и нажмите Enter");

                wordToExit = Console.ReadLine();
            }           
        }
    }
}
