using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zdvojnasobovac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo ke zdvojnásobení: ");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            a = a * 2;
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
