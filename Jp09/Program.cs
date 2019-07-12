using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jp09
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
                Console.Write("{0}:{1}\t", i, (char)i);
            Console.ReadKey();

        }
        
    }
}
