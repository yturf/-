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

            List<string> mergeList1 = new List<string>();
            List<string> mergeList2 = new List<string>();

            mergeList1.AddRange(array1);
            mergeList1.AddRange(array2);

            int index = 1;

            for (int i = 0; i < mergeList1.Count; i++)
            {
                for (int j = index; j < mergeList1.Count; j++)
                {
                    if (mergeList1[i] != mergeList1[j])
                    {
                        continue;
                    }
                    else
                    {
                        mergeList1.RemoveAt(i);
                    }
                }

                index++;
            }

            mergeList2.AddRange(mergeList1);

            foreach (var item in mergeList2)
            {
                Console.Write(item + " ");

            }

            Console.ReadKey();
        }
    }
}