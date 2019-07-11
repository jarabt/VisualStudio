using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spp08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zelenina = { "zelí", "okurka", "rajče", "paprika", "ředkev", "mrkev", "brokolice" };
            string[] ovoce = { "jablko", "hruška", "pomeranč", "jahoda", "banán", "kiwi", "malina" };
            string dale = "ano";
            int count = 0;

            while (dale == "ano")
            {
                Console.WriteLine("Zadej název libovolného ovoce nebo zeleniny: ");
                string zadani = Console.ReadLine().Trim().ToLower();
                if (zelenina.Contains(zadani))
                    Console.WriteLine("Zadal jsi zeleninu");
                else if (ovoce.Contains(zadani))
                    Console.WriteLine("Zadal jsi ovoce");
                else
                    Console.WriteLine("Tvoje slovo nemám v seznamu");
                count++;
                Console.WriteLine("Přeješ si zadat další slovo? (ano/ne)");
                dale = Console.ReadLine().Trim().ToLower();
            }
            Console.WriteLine("Zadal jsi {0} slov", count);
            Console.ReadKey();
        }
    }
}
