using System;
using System.Collections.Generic;

namespace Merging_into_one_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[] { "один", "три", "два" };
            string[] array2 = new string[] { "три", "три", "четыре", "пять" };

            List<string> mergeList = new List<string>();

            mergeList.AddRange(array1);

            for (int i = 0; i < mergeList.Count; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (mergeList.Contains(array2[j]))
                    {
                        continue;
                    }
                    else
                    {
                        mergeList.Add(array2[j]);
                    }
                }
            }

            MergeList(mergeList);

            Console.ReadKey();
        }

        public static void MergeList(List<string> mergeList)
        {
            foreach (var item in mergeList)
            {
                Console.Write(item + " ");

            }
        }
    }
}