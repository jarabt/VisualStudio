using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pp05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte postlupně koeficienty a,b,c kvadratické rovnice ax^2+bx+c=0");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            if (a == 0)
                Console.WriteLine("Není kvadratická rovnice");
            else if (d < 0)
                Console.WriteLine("Neexistuje řešení v oblasti reálných čísel");
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Rovnice má jeden kořen x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Rovnice má 2 reálné kořeny x1 = " + x1 + ", x2 = " + x2);
            }
            Console.ReadLine();



        }
    }
}
