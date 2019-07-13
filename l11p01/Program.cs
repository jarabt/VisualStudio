using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l11p01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] kinosal = new int[5, 5];
            kinosal[2, 2] = 1; // prostředek
            for (int i = 1; i < 4; i++)
                kinosal[i, 3] = 1;
            for (int i = 0; i < 5; i++)
                kinosal[i, 4] = 1;

            for (int j = 0; j < kinosal.GetLength(1); j++) // řádky
            {
                for (int i = 0; i < kinosal.GetLength(0); i++) 
                    Console.Write(kinosal[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();

            int[,,] kinosaly = new int[5, 5, 3];

            int[][] kinosal2 = new int[5][];
            for (int i = 0; i < kinosal2.Length; i++)
                kinosal2[i] = new int[5];
            int sloupcu = kinosal2.Length;
            int radku = 0;
            if (sloupcu != 0)
                radku = kinosal2[0].Length;
            kinosal2[4][2] = 1;

            int[,] kinosal3 = new int[,]
            {
                {0,0,0,0,1 },
                {0,0,0,1,1 },
                {0,0,1,1,1 },
                {0,0,0,1,1 },
                {0,0,0,0,1 }
            };

            int[][] zubatePole = new int[][]
            {
                new int[] {15,2,8,5,3 },
                new int[] {3,3,7 },
                new int[] {9,1,16,13 },
                new int[] { },
                new int[] {5 }
            };




        }
    }
}
