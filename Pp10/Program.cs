using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej text k rozveselení:");
            string s = Console.ReadLine();
            string rozveselenyS = "";
            int i = 0;
            int counter = 0;
            string[] arraySmiles = { ":)", ":D", ":P" };


            while (i < s.Length)
            {
                if (s[i] == '.')
                {
                    rozveselenyS += " " + arraySmiles[counter % 3];
                    counter++;
                }

                else if (s[i] == '!')
                {
                    rozveselenyS += s[i] + " " + arraySmiles[counter % 3];
                    counter++;
                }
                else if (s[i] == '?')
                {
                    rozveselenyS += s[i] + " " + arraySmiles[counter % 3];
                    counter++;
                }
                else
                    rozveselenyS += s[i];

                i++;
            }

            Console.Write("Rozveselený text: {0}", rozveselenyS);
            Console.ReadKey();

        }
    }
}
