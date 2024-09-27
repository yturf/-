using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Split используется для разрыва строки с разделителями на подстроки.";

            char[] separators = new char[] { ' ', '.' };

            string[] arrayOfWords = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in arrayOfWords)
            {
                Console.WriteLine($"Слово: {word}");
            }

            Console.ReadKey();
        }
    }
}
