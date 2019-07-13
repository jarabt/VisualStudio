using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spp12
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] hraci_pole = new char[10, 10];
            char[] pole = { ' ', 'O', 'X' };

            // nadpisy
            for (int i = 1; i < hraci_pole.GetLength(0); i++)
            {
                char number = char.Parse(i.ToString());
                hraci_pole[0, i] = number;
                hraci_pole[i, 0] = number;
            }

                       

            // zobrazeni hraciho pole 
            for (int i = 0; i < hraci_pole.GetLength(0); i++)
            {
                for (int j = 0; j < hraci_pole.GetLength(1); j++)
                    Console.Write(hraci_pole[i, j]);
                Console.WriteLine();
            }

            Console.ReadKey();
                                 
        }
    }
}
