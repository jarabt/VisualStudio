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
            int[] cisla = { 1, 2, 3, 3, 3, 5 };
            Console.WriteLine(cisla.Length);
            cisla = cisla.Distinct().ToArray();
            Console.WriteLine(cisla.Length);
            foreach (int n in cisla)
                Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
