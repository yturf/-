using System;

namespace Бой_с_боссом
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            string userInputCommonAttackPlayer = "1";
            string userInputFireballPlayer = "2";
            string userInputExplosionAttackPlayer = "3";
            string userInputBlessingPlayer = "4";

            const string CommandCommonAttackPlayer = "1";
            const string CommandFireballPlayer = "2";
            const string CommandExplosionAttackPlayer = "3";
            const string CommandBlessingPlayer = "4";

            bool ifFireballIsUsed = false;
            bool ifExplosionIsUsed = false;

            Random randomAttackBoss = new Random();

            int healthBoss = 150;
            int maxHealthBoss = 150;
            int commonAttackBoss = randomAttackBoss.Next(25, 35);

            Console.Write("Введите имя героя:");
            playerName = Console.ReadLine();

            Console.WriteLine("\nДля обычной атаки введите: " + userInputCommonAttackPlayer + 
                "\nДля огненного шара: " + userInputFireballPlayer +
                "\nДля применения взрыва: " + userInputExplosionAttackPlayer +
                "\nДля лечения: " + userInputBlessingPlayer
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
                        ifFireballIsUsed = false;
                        break;

                    case CommandFireballPlayer:
                        if (mannaCostFromFireball <= mannaPlayer)
                        {
                            healthBoss -= fireballPlayer;
                            healthPlayer -= commonAttackBoss;
                            mannaPlayer -= mannaCostFromFireball;
                            ifFireballIsUsed = true;
                        }
                        else
                        {
                            healthPlayer -= commonAttackBoss;
                        }
                        break;

                    case CommandExplosionAttackPlayer:
                        if  (ifFireballIsUsed == true && ifExplosionIsUsed == false)
                        {
                            healthBoss -= explosionAttackPlayer;
                            healthPlayer -= commonAttackBoss;
                            ifFireballIsUsed = false;
                            ifExplosionIsUsed = true;
                        }
                        if (ifFireballIsUsed == false && ifExplosionIsUsed  == true)
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
                if (healthPlayer <= 0)
                {
                    Console.WriteLine("Вы проиграли...");
                } 
                
                else if (healthBoss <= 0)
                {
                    Console.WriteLine("Вы победили!");
                }

                else if (healthBoss <= 0 && healthBoss <= 0)
                {
                    Console.WriteLine("Ничья.");
                }                   

            Console.ReadKey();
        }
    }
}
