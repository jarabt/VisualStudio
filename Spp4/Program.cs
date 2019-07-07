using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte delší slovo: ");
            string s1 = Console.ReadLine().Trim();
            Console.WriteLine("Zadejte kratší slovo: ");
            string s2 = Console.ReadLine().Trim();
            int diff = s1.Length - s2.Length;
            Console.WriteLine("Slova se liší délkou o {0} znaků", diff);
            Console.ReadKey();

        }
    }
}
