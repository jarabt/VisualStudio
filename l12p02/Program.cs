using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l12p02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5 / 2;
            double b = 5 / 2;
            double c = 5.0 / 2;
            double d = 5 / 2.0;
            double e = 5.0 / 2.0;
            // int f = 5 / 2.0;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", a, b, c, d, e);

            Console.WriteLine(5 % 2);

            Console.ReadLine();
        }
    }
}
