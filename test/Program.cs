using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Spal.";
            s = s.Insert(4, " " + ":)").Remove(7);

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
