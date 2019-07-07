using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spp06
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            for (int i = 0; i < 10; ++i)
            {
                s = " zelených láhví stojí na stole a jedna láhev spadne";
                if ((i < 9) && (i > 5))
                    s = s.Replace(" zelených láhví", " zelené láhve");
                else if (i == 9)
                    s = s.Replace(" zelených láhví", " zelená láhev");
                Console.WriteLine((10 - i) + s);
            }
            Console.ReadLine();
        }
    }
}
