using System;
using System.IO;

namespace PacMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int pacmanX = 1;
            int pacmanY = 1;
            int score = 0;

            bool isOpenGame = true;

            char[,] map = ReadMap("map.txt");

            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);
            
            Console.WriteLine("Для выхода из игры нажмите клавишу: Esc");

            while (isOpenGame)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                DrawMap(map);

                DrawPlayer(pacmanX, pacmanY);
                DrawScore(score);

                pressedKey = Console.ReadKey();

                CloseGame(pressedKey, ref isOpenGame);

                int[] derection = GetDerection(pressedKey);
                MovePlayer(ref pacmanX, ref pacmanY, map, ref score, derection);
            }
        }

        private static char[,] ReadMap(string Path)
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[GetMaxLengthOfLine(file), file.Length];

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = file[y][x];
                }
            }

            return map;
        }

        private static void MovePlayer(ref int pacmanX, ref int pacmanY, char[,]
            map, ref int score, int[] derection)
        {
            int nextPacmanPositionX = pacmanX + derection[0];
            int nextPacmanPositionY = pacmanY + derection[1];

            char spaceChar = ' ';
            char starChar = '*';
            char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];

            if (nextCell == spaceChar || nextCell == starChar)
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;

                if (nextCell == starChar)
                {
                    score++;
                    map[nextPacmanPositionX, nextPacmanPositionY] = spaceChar;
                }
            }
        }

        private static int[] GetDerection(ConsoleKeyInfo pressedKey)
        {
            int[] derection = { 0, 0 };

            ConsoleKey moveUpCommand = ConsoleKey.UpArrow;
            ConsoleKey moveDownCommand = ConsoleKey.DownArrow;
            ConsoleKey moveLeftCommand = ConsoleKey.LeftArrow;
            ConsoleKey moveRightCommand = ConsoleKey.RightArrow;

            if (pressedKey.Key == moveUpCommand)
                derection[1] = -1;
            else if (pressedKey.Key == moveDownCommand)
                derection[1] = 1;
            else if (pressedKey.Key == moveLeftCommand)
                derection[0] = -1;
            else if (pressedKey.Key == moveRightCommand)
                derection[0] = 1;

            return derection;
        }

        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
        }

        private static void DrawPlayer(int posX, int posY)
        {
            string playerChar = "@";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine(playerChar);
        }

        private static void DrawScore(int score)
        {
            Console.SetCursorPosition(35, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"score: {score}");
        }

        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (var line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }

            return maxLength;
        }

        private static bool CloseGame(ConsoleKeyInfo pressedKey, ref bool isOpenGame)
        {
            if (pressedKey.Key == ConsoleKey.Escape)
            {
                isOpenGame = false;  
                Console.Clear();
            }

            return isOpenGame;
        }
    }
}
