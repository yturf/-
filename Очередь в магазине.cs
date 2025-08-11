using System;
using System.Collections.Generic;

namespace Очередь_в_магазине
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandCallClient = "1";

            Queue<int> purchaseAmounts = new Queue<int>();

            Random randomPrice = new Random();

            int lenghtQueue = 3;
            int cashAccount = 0;

            bool isOpen = true;

            for (int i = 0; i < lenghtQueue; i++)
            {
                purchaseAmounts.Enqueue(randomPrice.Next(5, 25));
            }

            ShowMoneyAccounts(purchaseAmounts);

            Console.Write("Чтобы принять клиента нажмите клавишу - 1: ");

            while (isOpen)
            {
                string userInput = Console.ReadLine();

                if (userInput == CommandCallClient)
                {
                    AddMoneyInAccount(ref cashAccount, purchaseAmounts);
                    ToServeClient(purchaseAmounts);
                }
                if (purchaseAmounts.Count == 0)
                {
                    Console.WriteLine("В очереди никого нет!");
                    isOpen = false;
                }
            }
        }

        static private void ToServeClient(Queue<int> queue)
        {
            Console.WriteLine("Клиент с суммой " + queue.Dequeue() + " обслужен и ушёл!");

            if (queue.Count > 0)
            {
                Console.WriteLine("В очереди остались.");

                ShowMoneyAccounts(queue);

                Console.WriteLine("Нажмите любую клавишу!");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Введите команду для приема клиета: ");
            }
        }

        private static void AddMoneyInAccount(ref int money, Queue<int> queue)
        {
            money += queue.Peek();

            Console.WriteLine("Сумма в кошельке: " + money);
        }

        static private void ShowMoneyAccounts(Queue<int> queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine($"Покупатель с суммой {item}.");
            }

            Console.WriteLine("--------------");
        }
    }
}
