using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pp08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej počet čísel: ");
            int count = int.Parse(Console.ReadLine());
            int[] array_int = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("Zadej {0}. číslo: ", i + 1);
                array_int[i] = int.Parse(Console.ReadLine());
            }

            int[] sorted_array = new int[count];
            Array.Copy(array_int, sorted_array, count);
            Array.Sort(sorted_array);
            int median_index = sorted_array.Length / 2;
            int median = sorted_array[median_index];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0} se od mediánu odchyluje o {1}", array_int[i], array_int[i] - median);
            }


            Console.ReadKey();
        }
    }
}
