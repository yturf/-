using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Pac_Man
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int pacmanX = 1;
            int pacmanY = 1;
            int score = 0;

            char[,] map = ReadMap("map.txt");
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.WriteLine("@");

                Console.SetCursorPosition(35, 0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"score: {score}");
                pressedKey = Console.ReadKey();

                HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score);
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

        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref int score)
        {
            int[] derection = GetDerection(pressedKey);

            int nextPacmanPositionX = pacmanX + derection[0];
            int nextPacmanPositionY = pacmanY + derection[1];

            char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];

            if (nextCell == ' ' || nextCell == '*')
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;
                
                if (nextCell == '*')
                {
                    score++;
                    map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
                }
            }
        }

        private static int[] GetDerection(ConsoleKeyInfo pressedKey)
        {
            int[] derection = { 0, 0 };

            if (pressedKey.Key == ConsoleKey.UpArrow)
                derection[1] = -1;
            else if (pressedKey.Key == ConsoleKey.DownArrow)
                derection[1] = 1;
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
                derection[0] = -1;
            else if (pressedKey.Key == ConsoleKey.RightArrow)
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
    }
}
