using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pp06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte levou mez 1. intervalu: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte pravou mez 1. intervalu: ");
            int p1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte levou mez 2. intervalu: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte pravou mez 2. intervalu: ");
            int p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dvojice čísel, jejichž součet leží v některém z intervalů:");
            Console.WriteLine("(1. číslo je z prvního intervalu a 2. z druhého intervalu)");

            int a;
            int b;
            int sum;
            for (int i = 0; i <= (p1 - l1); i++)
                for (int j = 0; j <= (p2 - l2); j++)
                {
                    a = i + l1;
                    b = j + l2;
                    sum = a + b;
                    if (((sum >= l1) && (sum <= p1)) || ((sum >= l2) && (sum <= p2)))
                        Console.Write("[{0};{1}], ", a, b);
                }
            Console.ReadKey();

        }
    }
}
