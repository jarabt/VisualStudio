using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokrocilyPriklad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej poloměr kruhu (cm): ");
            float r = float.Parse(Console.ReadLine());
            float obvod = 2 * 3.1415F * r;
            float obsah = 3.1415F * r * r;
            Console.WriteLine("Obvod zadaného kruhu je: " + obvod + " cm");
            Console.WriteLine("Jeho obsah je: " + obsah + " cm^2");
            Console.ReadLine();

        }
    }
}
