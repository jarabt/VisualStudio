using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JednoduchaKalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v kalkulačce");
            Console.WriteLine("Zadejte první číslo: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte drujé číslo: ");
            float b = float.Parse(Console.ReadLine());
            float soucet = a + b;
            float rozdil = a - b;
            float soucin = a * b;
            float podil = a / b;
            Console.WriteLine("Součet je: " + soucet);
            Console.WriteLine("Rozdíl je: " + rozdil);
            Console.WriteLine("Součin je: " + soucin);
            Console.WriteLine("Podíl je: " + podil);
            Console.WriteLine("Děkujeme za použití kalkulačky, aplikaci ukončíte libovolnou klávesou.");
            Console.ReadLine();
            // string soucetS = soucet.ToString();
        }
    }
}
