using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Papousek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, jsem virtuální papoušek Lóra, rád opakuji!");
            Console.WriteLine("Napiš něco: ");

            string vstup;
            vstup = Console.ReadLine();
            string vystup;
            vystup = vstup + ", " + vstup + "!";

            Console.WriteLine(vystup);
            Console.ReadKey();

        }
    }
}
