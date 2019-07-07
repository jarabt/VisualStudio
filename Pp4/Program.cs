using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej řetězec: ");
            string retezec = Console.ReadLine();
            Console.WriteLine(retezec.ToLower().Contains("itnetwork"));
            Console.ReadLine();

        }
    }
}
