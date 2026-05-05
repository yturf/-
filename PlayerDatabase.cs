using System;
using System.Collections.Generic;

namespace PlayerDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddPlayer = "1";
            const string CommandShowAllPlayers = "2";
            const string CommandBanByUniqueNumber = "3";
            const string CommandUnblockByUniqueNumber = "4";
            const string CommandDeletingUniqueNumber = "5";
            const string CommandExit = "6";

            bool isOpen = true;

            Database database = new Database();

            List<Player> players = new List<Player>();

            while (isOpen)
            {
                Console.SetCursorPosition(5, 0);
                Console.WriteLine("------База данных игроков-------");
                Console.WriteLine("Добавить игрока - " + CommandAddPlayer);
                Console.WriteLine("Показать всех игроков - " + CommandShowAllPlayers);
                Console.WriteLine("Забанить игрока по индивидуальному номеру - " + CommandBanByUniqueNumber);
                Console.WriteLine("Разбанить игрока по индивидуальному номеру - " + CommandUnblockByUniqueNumber);
                Console.WriteLine("Удалить игрока по индивидуальному номеру - " + CommandDeletingUniqueNumber);
                Console.WriteLine("Выйти из программы - " + CommandExit);

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAddPlayer:
                        AddPlayerToDatabase();
                        break;

                    case CommandShowAllPlayers:
                        database.ShowAllPlayers();
                        break;

                    case CommandBanByUniqueNumber:
                        database.BanInPlayer();
                        break;

                    case CommandUnblockByUniqueNumber:
                        database.BanOutPlayer();
                        break;

                    case CommandDeletingUniqueNumber:
                        RemovePlayerToDatabase();
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine("Ввод не распознан введите еще раз");
                        break;
                }

                Console.WriteLine("Для продолжения нажмите любую кнопку");
                Console.ReadKey();
                Console.Clear();

            }

            void AddPlayerToDatabase()
            {
                int id;
                string nickName;
                int level;
                bool isBanned;

                Console.WriteLine("Введите ID игрока - ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите Ник игрока - ");
                nickName = Console.ReadLine();

                Console.WriteLine("Введите уровень игрока - ");
                level = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Заблокирован ли игрок - true/false");
                isBanned = Convert.ToBoolean(Console.ReadLine());

                database.AddPlayer(new Player(id, nickName, level, isBanned));
            }

            void RemovePlayerToDatabase()
            {
                int id;

                Console.WriteLine("Введите ID игрока для удаления - ");
                id = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < database.players.Count; i++)
                {
                    if (id == database.players[i].Id)
                    {
                        database.RemovePlayer(database.players[i]);
                    }
                }
            }
        }

        class Database
        {
            public List<Player> players = new List<Player>();

            public void AddPlayer(Player player)
            {
                players.Add(player);
            }

            public void RemovePlayer(Player player)
            {
                players.Remove(player);
            }

            public void ShowAllPlayers()
            {
                for (int i = 0; i < players.Count; i++)
                {
                    players[i].ShowPlayerInfo();
                }
            }

            public void BanInPlayer()
            {
                int id;

                Console.Write("Введите номер для бана игрока - ");
                id = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < players.Count; i++)
                {
                    if (id == players[i].Id)
                    {
                        if (players[i].IsBanned == false)
                            players[i].BanIt();
                        else
                            Console.WriteLine("Игрок уже забанен");
                    }
                }
            }

            public void BanOutPlayer()
            {
                int id;

                Console.Write("Введите номер для разбана игрока - ");
                id = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < players.Count; i++)
                {
                    if (id == players[i].Id)
                    {
                        if (players[i].IsBanned == true)
                            players[i].OutBan();
                        else
                            Console.WriteLine("Игрок уже разбанен");
                    }
                }
            }
        }

        class Player
        {
            private int _id;
            private string _nickName;
            private int _level;
            private bool _isBanned;

            public Player(int id, string nickName, int level, bool isBanned)
            {
                Id = id;
                NickName = nickName;
                Level = level;
                IsBanned = isBanned;
            }

            public int Id { get; private set; }
            public string NickName { get; private set; }
            public int Level { get; private set; }
            public bool IsBanned { get; private set; }

            public void ShowPlayerInfo()
            {
                if (IsBanned)
                {
                    Console.WriteLine($"Уникальный номер игрока - {Id}\nНик игрока - {NickName}" +
                        $"\nУровен - {Level}\nСтатус - забанен\n");
                }
                else
                {
                    Console.WriteLine($"Уникальный номер игрока - {Id}\nНик игрока - {NickName}" +
                        $"\nУровен - {Level}\nСтатус - принят\n");
                }
            }

            public bool BanIt()
            {
                return IsBanned = true;
            }

            public bool OutBan()
            {
                return IsBanned = false;
            }
        }
    }
}

//Реализовать базу данных игроков и методы для работы с ней. Должно быть консольное меню для взаимодействия
//пользователя с возможностями базы данных.
//Игрок должен состоять из уникального номера, ника, уровня и булевого значения, забанен ли игрок.
//Реализовать возможность добавления игрока, бана игрока по уникальному номеру, разбана игрока по
//уникальному номеру и удаление игрока по уникальному номеру.

//Создавать полноценные системы баз данных не нужно, задание выполняется инструментами, которые вы
//уже изучили в рамках курса. Надо сделать класс "База данных".
