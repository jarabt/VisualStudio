using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jp08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[10];
            for (int i = 0; i < cisla.Length; i++)
                cisla[i] = 10 - i;
            foreach (int n in cisla)
                Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
