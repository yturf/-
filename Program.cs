using System;
using System.IO;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map = ReadMap("map.txt");

            for (int x = 0; x < map.GetLength(1); x++)
            {
                for(int y = 0; y < map.GetLength(0); y++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");
            Console.WriteLine(file.Length);
            //string[] file = new string[]
            //{
            //    "###",
            //    "###"
            //};
            char[,] map = new char[file.Length, GetMaxLengthOfLine(file)];

            for (int x = 0; x < map.GetLength(1); x++)
            {
                for(int y = 0; y < map.GetLength(0); y++)
                {
                    map[y, x] = file[x] [y];
                }
            }
            return map;
        }

        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (string line in lines)
            {
                if(line.Length > maxLength)
                    maxLength = line.Length;
            }
            return maxLength;
        }
    }
}
