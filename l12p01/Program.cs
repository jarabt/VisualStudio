using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l12p01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pí: {0}\ne: {1}", Math.PI, Math.E);

            double d = 2.72;
            int a = (int)Math.Round(d);
            Console.WriteLine(a);

            Console.WriteLine(Math.Pow(2, 3));

            // třetí odmocnina
            Console.WriteLine(Math.Pow(8, (1.0 / 3.0)));

            Console.ReadKey();


        }
    }
}
