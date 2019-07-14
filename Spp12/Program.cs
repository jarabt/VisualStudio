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
            bool goOn = true;
            
            // nadpisy
            for (int i = 1; i < hraci_pole.GetLength(0); i++)
            {
                char number = char.Parse(i.ToString());
                hraci_pole[0, i] = number;
                hraci_pole[i, 0] = number;
            }

            int counter = 0;
            
            while (goOn)
            {
                // zobrazeni hraciho pole
                int[] inColumn =        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // testing of O in a column
                int[] diagDecreasing  = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // testing of decreasing diag
               
                for (int i = 0; i < hraci_pole.GetLength(0); i++)
                {
                    int inRowO = 0; // testing of O in row
                    
                    for (int j = 0; j < hraci_pole.GetLength(1); j++)
                    {

                        Console.Write(hraci_pole[i, j]);
                        // checking victory ROW + COLUMN
                        if (hraci_pole[i, j] == 'O')
                        {
                            inRowO += 1;
                            inColumn[j] += 1;
                            if (Math.Abs(i - j) < 5)
                                diagDecreasing[(4 + (j - i))]++;
                        }
                        else
                        {
                            inRowO = 0;
                            inColumn[j] = 0;
                        }
                        if ((inRowO == 5) || (inColumn.Contains(5)) || (diagDecreasing.Contains(5)))
                            Console.WriteLine("Vyhraly koleceka");
                    }

                    Console.WriteLine();
                }

                // sem přijde kontrola remízy nebo výhry





                if (counter % 2 == 0)
                    Console.WriteLine("Na řadě je hráč s kolečky");
                else
                    Console.WriteLine("Na řadě je hráč s křížky");

                bool badInput = true;
                while (badInput)
                {
                    Console.Write("Zadej pozici X kam chceš táhnout: ");
                    int inputY;
                    while (!int.TryParse(Console.ReadLine(), out inputY))
                        Console.WriteLine("Zadej prosím celé číslo");
                    Console.Write("Zadej pozici Y kam chceš táhnout: ");
                    int inputX;
                    while (!int.TryParse(Console.ReadLine(), out inputX))
                        Console.WriteLine("Zadej prosím celé číslo");
                    
                    if ((0 < inputX) && (inputX < 10) && (0 < inputY) && (inputY < 10))
                        if (hraci_pole[inputX, inputY] == '\0')
                        {
                            if (counter % 2 == 0)
                                hraci_pole[inputX, inputY] = 'O';
                            else
                                hraci_pole[inputX, inputY] = 'X';
                            badInput = false;
                        }
                        else
                        {
                            Console.WriteLine("Neplatná pozice, zadej ji prosím znovu.");
                            badInput = true;
                        }
                    else
                    {
                        Console.WriteLine("Neplatná pozice, zadej ji prosím znovu.");
                        badInput = true;
                    }

                    
                }

                counter++;
                goOn = true;

            }


            Console.ReadKey();
                                 
        }
    }
}
