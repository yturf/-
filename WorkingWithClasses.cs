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
        private string Name;
        private int Age;
        private int Health;

        public Player(string name, int age, int health)
        {
            Name = name;
            Age = age;
            Health = health;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя - {Name}\nВозраст - {Age}\nЗдоровье - {Health}");
        }
    }
}