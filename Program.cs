using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Картинки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfImagesInTheAlbum = 52;
            int numberOfImagesInARow = 3;
            int numberOfFullRows;
            int theRestOfTheImages;

            numberOfFullRows = numberOfImagesInTheAlbum / numberOfImagesInARow;
            theRestOfTheImages = numberOfImagesInTheAlbum % numberOfImagesInARow;

            Console.WriteLine("Количество полных рядов с картинками: " + numberOfFullRows);
            Console.WriteLine("Остаток картинок: " + theRestOfTheImages);

            Console.ReadKey();
        }
    }
}
