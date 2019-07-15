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
            int counter = 78;

            // nadpisy
            for (int i = 1; i < hraci_pole.GetLength(0); i++)
            {
                char number = char.Parse(i.ToString());
                hraci_pole[0, i] = number;
                hraci_pole[i, 0] = number;
            }
            
            while (goOn)
            {
                // showing of desk and + checking of victory

                bool victoryO = false;
                bool victoryX = false;

                // declaring and clearing of arrays for checking of victory
                int[] inColumnO =       { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // testing of O in a column
                int[] inColumnX =       { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // testing of X in a column
                int[] diagDecreasingO = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // testing of O decreasing diag
                int[] diagDecreasingX = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // testing of X decreasing diag
                int[] diagIncreasingO = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // testing of O increasing diag
                int[] diagIncreasingX = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // testing of X increasing diag

                

                for (int i = 0; i < hraci_pole.GetLength(0); i++)
                {
                    int inRowO = 0; // testing of O in row
                    int inRowX = 0; // testing of X in row

                    for (int j = 0; j < hraci_pole.GetLength(1); j++)
                    {
                        Console.Write(hraci_pole[i, j]);

                        // sumarizing of variables for checking of "O" victory
                        if (hraci_pole[i, j] == 'O')
                        {
                            inRowO += 1;
                            inColumnO[j] += 1;
                            if (Math.Abs(i - j) < 5)
                                diagDecreasingO[(4 + (j - i))]++;
                            if (((i + j) < 15) && ((i + j) > 5))
                                diagIncreasingO[((j + i) - 6)]++;
                        }

                        // sumarizing of variables for checking of "X" victory
                        else if (hraci_pole[i, j] == 'X')
                        {
                            inRowX += 1;
                            inColumnX[j] += 1;
                            if (Math.Abs(i - j) < 5)
                                diagDecreasingX[(4 + (j - i))]++;
                            if (((i + j) < 15) && ((i + j) > 5))
                                diagIncreasingX[((j + i) - 6)]++;
                        }

                        // clearing of variables for "O" and "X" victory
                        else
                        {
                            inRowO = 0;
                            inColumnO[j] = 0;
                            inRowX = 0;
                            inColumnX[j] = 0;
                            if (Math.Abs(i - j) < 5)
                            {
                                diagDecreasingO[(4 + (j - i))] = 0;
                                diagDecreasingX[(4 + (j - i))] = 0;
                            }
                            if (((i + j) < 15) && ((i + j) > 5))
                            {
                                diagIncreasingO[((j + i) - 6)] = 0;
                                diagIncreasingX[((j + i) - 6)] = 0;
                            }
                        }
                        // checking of "O" victory
                        if (inRowO == 5)
                            victoryO = true;
                        // checking of "X" victory
                        if (inRowX == 5)
                            victoryX = true;
                    }
                    // checking of "O" victory
                    if ((inColumnO.Contains(5)) || (diagDecreasingO.Contains(5)) || (diagIncreasingO.Contains(5)))
                        victoryO = true;
                    // checking of "X" victory
                    if ((inColumnX.Contains(5)) || (diagDecreasingX.Contains(5)) || (diagIncreasingX.Contains(5)))
                        victoryX = true;

                    Console.WriteLine();
                }

                // "O" victory
                if (victoryO)
                {
                    Console.Write("Vyhrál hráč s kolečky");
                    goOn = false;
                }

                // "X" victory
                else if (victoryX)
                {
                    Console.Write("Vyhrál hráč s křížky");
                    goOn = false;
                }

                // checking of tie - full desk
                else if (counter == 81)
                {
                    Console.Write("Remíza.");
                    goOn = false;
                }

                else
                {
                    Console.WriteLine();

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
                }

            }


            Console.ReadKey();
                                 
        }
    }
}
