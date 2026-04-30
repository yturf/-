using System;

namespace WorkingWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(1, 1, '@');

            renderer.Draw(player);
        }
    }

    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Char { get; private set; }

        public Player(int x, int y, char playerDesignation)
        {
            X = x;
            Y = y;
            Char = playerDesignation;
        }
    }

    class Renderer
    {
        public void Draw(Player player)
        {
            Console.SetCursorPosition(player.X, player.Y);
            Console.Write(player.Char);
        }
    }
}

//Создать класс игрока, у которого есть данные с его положением в x, y и своим символом.
//Создать класс отрисовщик, с методом, который получает игрока и отрисовывает его. 
//Используйте автореализуемое свойство.