using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JednoduchyPriklad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, jak se jmenuješ? ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Jaký jsi? ");
            string s2 = Console.ReadLine();
            Console.WriteLine(s1 + " je " + s2);
            Console.ReadLine();
        }
    }
}
