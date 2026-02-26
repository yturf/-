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

            MergeList(mergeList, array2);

            ShowMergedList(mergeList);

            Console.ReadKey();
        }

        public static void MergeList(List<string> mergeList, string[] array)
        {
            foreach (var item in array)
            {
                if (mergeList.Contains(item) == false)
                {
                    mergeList.Add(item);
                }
            }
        }

        public static void ShowMergedList(List<string> mergeList)
        {
            foreach (var item in mergeList)
            {
                Console.Write(item + " ");

            }
        }
    }
}