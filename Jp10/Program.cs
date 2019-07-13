using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Výpočet průměru známek");
            Console.WriteLine("Zadejte známky oddělené čárkou:");
            string s = Console.ReadLine();
            string[] sPole = s.Split(',');
            int length = sPole.Length;
            int[] znamky = new int[length];
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                znamky[i] = int.Parse(sPole[i]);
                sum += znamky[i];
            }
            double prumer = (double)sum / length;
            Console.Write("Průměr: {0}", prumer);
            Console.ReadKey();
        }
    }
}
