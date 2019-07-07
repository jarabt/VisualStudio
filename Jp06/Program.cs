using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jp06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik ryb si dáš k večeři?");
            int pocet = int.Parse(Console.ReadLine());
            for (int i = 0; i < pocet; i++)
                Console.WriteLine("<° )))-<");
            Console.ReadLine();

        }
    }
}
