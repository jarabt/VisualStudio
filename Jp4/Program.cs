using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej jméno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej příjmení: ");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadej svůj věk: ");
            int vek = int.Parse(Console.ReadLine());

            Console.WriteLine(jmeno.ToUpper() + " " + prijmeni.ToUpper());
            Console.WriteLine("Za rok ti bude {0} let.", vek + 1);
            Console.ReadKey();

        }
    }
}
