using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l09p04
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializace proměnných
            string s = "cernediryjsoutamkdebuhdelilnulou";
            Console.WriteLine("Původní zpráva: {0}", s);
            string zprava = "";
            int posun = 1;

            // cyklus projíždějící jednotlivé znaky
            foreach(char c in s)
            {
                int i = (int)c;
                i += posun;
                // kontrola přetečení
                if (i > (int)'z')
                    i -= 26;
                char znak = (char)i;
                zprava += znak;
            }

            // výpis
            Console.WriteLine("Zašifrovaná zpráva: {0}", zprava);
            Console.ReadKey();

        }
    }
}
