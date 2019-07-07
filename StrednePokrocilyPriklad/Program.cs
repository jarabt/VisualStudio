using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrednePokrocilyPriklad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo k umocnění: ");
            float a = float.Parse(Console.ReadLine());
            float vysledek = a * a;
            Console.WriteLine("Výsledek je: " + vysledek);
            Console.ReadLine();

        }
    }
}
