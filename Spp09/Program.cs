using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spp09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej palindrom:");
            string s = Console.ReadLine().Trim().ToLower();
            string s_reversed = "";
            int length = s.Length;
            for (int i = length; i > 0; i--)
                s_reversed += s[i - 1];

            if (s == s_reversed)
                Console.WriteLine("Ano, toto je palindrom.");
            else
                Console.WriteLine("Toto není palindrom.");

            Console.ReadKey();

            

        }
    }
}
