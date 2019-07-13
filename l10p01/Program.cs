using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l10p01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Já bych všechny ty internety zakázala.".Insert(29, "ne"));
            Console.WriteLine("Kdo se směje naposled, ten je admin.".Remove(12, 9));
            Console.WriteLine("Kdo se směje naposled, ten je admin.".Substring(13, 8));
            Console.WriteLine("akát".CompareTo("blýskavice"));
            Console.ReadKey();

        }
    }
}
