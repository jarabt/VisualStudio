using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // řezězec, který chceme zakódovat
            Console.WriteLine("Zadejte zprávu k zakódování:");
            string s = Console.ReadLine().ToLower();
            Console.WriteLine("Původní zpráva: {0}", s);
            // řetězec se zakódovanou zprávou
            string zprava = "";

            // vzorová pole
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
                "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--",
            "-..-", "-.--", "--.." };

            // iterace znaků původní zprávy
            foreach (char znak in s)
            {
                string morseuvZnak = "";
                int index = abecedniZnaky.IndexOf(znak);
                if (index >= 0) // znak nalezen
                    morseuvZnak = morseovyZnaky[index];
                zprava += (morseuvZnak + " ");
            }

            Console.WriteLine("Zakódovaná zpráva: {0}", zprava);
            Console.ReadKey();

        }
    }
}
