using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l10p04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("První řádek\nDruhý řádek");
            Console.WriteLine("\u4456");  // kód v unikódu
            Console.WriteLine("Toto je zpětné lomítko: \\");
            Console.WriteLine("Toto je uvozovka: \"");
            Console.WriteLine(@"C:\Users\sdraco\Dropbox\itnetwork");


            Console.ReadKey();

        }
    }
}
