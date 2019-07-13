using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pole = { "  ", "██"};  // alt + 219
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(pole[(i + j) % 2]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
