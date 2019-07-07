using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jp05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej své jméno: ");
            string jmeno = Console.ReadLine();
            if ((jmeno.Length > 3) && (jmeno.Length < 10))
                Console.WriteLine("Normální jméno.");
            else
                Console.WriteLine("Máš moc krátké nebo moc dlouhé jméno!");
            Console.ReadLine();
        }
    }
}
