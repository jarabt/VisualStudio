using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l09p03
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;     // znak
            int i;  // ordinární znak ascii hodnota znaku
            // převedeme znak na jeho ASCII hodnotu
            c = 'a';
            i = (int)c;
            Console.WriteLine("Znak {0} jsme převedli na ASCII hodnotu {1}", c, i);
            // převedeme ASCII hodnotu na znak
            i = 98;
            c = (char)i;
            Console.WriteLine("ASCII hodnotu {1} jsme převedli na znak {0}", c, i);
            Console.ReadLine();


        }
    }
}
