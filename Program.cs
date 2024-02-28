using System;

namespace Бой_с_боссом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandCommonAttackPlayer = "1";
            const string CommandFireballPlayer = "2";
            const string CommandExplosionAttackPlayer = "3";
            const string CommandBlessingPlayer = "4";

            int healthPlayer = 130;
            int maxHealthPlayer = 130;
            int mannaPlayer = 80;
            int maxMannaPlayer = 80;
            int commonAttackPlayer = 10;
            int fireballPlayer = 20;
            int mannaCostFromFireball = 25;
            int explosionAttackPlayer = 35; 
            int blessingLimit = 3;
            int blessingHealthRegeneration = 50;
            int blessingMannaRegeneration = 40; ;

            string userInput = "";
            string playerName = "";

            bool haveFireballIsUsed = false;
            bool haveExplosionIsUsed = false;

            Random random = new Random();

            int healthBoss = 150;
            int maxHealthBoss = 150;
            int minAttackBoss = 25;
            int maxAttackBoss = 35;
            int commonAttackBoss = random.Next(minAttackBoss, maxAttackBoss);

            Console.Write("Введите имя героя:");
            playerName = Console.ReadLine();

            Console.WriteLine("\nДля обычной атаки введите: " + CommandCommonAttackPlayer + 
                "\nДля огненного шара: " + CommandFireballPlayer +
                "\nДля применения взрыва: " + CommandExplosionAttackPlayer +
                "\nДля лечения: " + CommandBlessingPlayer
                );

            Console.WriteLine("\nБой начинается!");

            while (healthPlayer > 0 && healthBoss > 0) 
            {
                Console.WriteLine($"\nЗдоровье игрока  {playerName}: {healthPlayer}/{maxHealthPlayer}\n" +
                    $"Манна игрока {playerName}: {mannaPlayer}/{maxMannaPlayer}");
                Console.WriteLine($"\nЗдоровье босса: {healthBoss}/{maxHealthBoss}");

               Console.WriteLine("\nВведите команду!");
                userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {                       
                    case CommandCommonAttackPlayer:
                        healthPlayer -= commonAttackBoss;
                        healthBoss -= commonAttackPlayer;
                        haveFireballIsUsed = false;
                        break;
                    case CommandFireballPlayer:

                        if (mannaCostFromFireball <= mannaPlayer)
                        {
                            healthBoss -= fireballPlayer;
                            healthPlayer -= commonAttackBoss;
                            mannaPlayer -= mannaCostFromFireball;
                            haveFireballIsUsed = true;
                        }
                        else
                        {
                            healthPlayer -= commonAttackBoss;
                        }
                        break;
                    case CommandExplosionAttackPlayer:

                        if  (haveFireballIsUsed == true && haveExplosionIsUsed == false)
                        {
                            healthBoss -= explosionAttackPlayer;
                            healthPlayer -= commonAttackBoss;
                            haveFireballIsUsed = false;
                            haveExplosionIsUsed = true;
                        }
                        if (haveFireballIsUsed)
                        {
                             Console.WriteLine("Для повторного взрыва, необходимо использовать огненный шар!");
                             healthPlayer -= commonAttackBoss;
                        }
                        else
                        {
                            healthPlayer -= commonAttackBoss;
                        }
                        break;
                    case CommandBlessingPlayer: 

                        if (blessingLimit > 0)
                        {
                            healthPlayer += blessingHealthRegeneration;

                            if (healthPlayer > maxHealthPlayer)
                            {
                                healthPlayer = maxHealthPlayer;
                            }
                            mannaPlayer += blessingMannaRegeneration;

                            if (mannaPlayer > maxMannaPlayer)
                            {
                                mannaPlayer = maxMannaPlayer;
                            }
                            healthPlayer -= commonAttackBoss;
                            blessingLimit--;

                            if (blessingLimit <= 0)
                            {
                                Console.WriteLine("Больше нельзя лечиться!");
                                healthPlayer -= commonAttackBoss;
                            }
                        }
                        else
                        {
                            healthPlayer -= commonAttackBoss;
                        }
                        break;
                    default:
                        healthPlayer -= commonAttackBoss;
                        break;
                }                                            
            }
                if (healthBoss <= 0 && healthBoss <= 0)
                {
                    Console.WriteLine("Ничья.");
                }                   
                else if (healthPlayer <= 0)
                {
                    Console.WriteLine("Вы проиграли...");
                }                 
                else if (healthBoss <= 0)
                {
                    Console.WriteLine("Вы победили!");
                }

            Console.ReadKey();
        }
    }
}
