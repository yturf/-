using System;

namespace WorkingWithClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Bob", 20, 300);

            player.ShowInfo();
        }
    }

    class Player
    {
        private string _name;
        private int _age;
        private int _health;

        public Player(string name, int age, int health)
        {
            _name = name;
            _age = age;
            _health = health;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя - {_name}\nВозраст - {_age}\nЗдоровье - {_health}");
        }
    }
}