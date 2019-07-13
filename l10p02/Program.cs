using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace l10p02
{
    class Program
    {
        static void Main(string[] args)
        {
            // řetězec, který chceme dekódovat
            string s = ".. - -. . - .-- --- .-. -.-";
            Console.WriteLine("Původní zpráva: {0}", s);
            // řetězec s dekódovanou zprávou
            string zprava = "";

            // vzorová pole
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
                "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--",
            "-..-", "-.--", "--.." };

            // rozbití řetězce na znaky morzeovky
            string[] znaky = s.Split(' ');

            // iterace znaků morzeovky
            foreach (string morzeuvZnak in znaky)
            {
                char abecedniZnak = '?';
                int index = Array.IndexOf(morseovyZnaky, morzeuvZnak);
                if (index >= 0) // znak nalezen
                    abecedniZnak = abecedniZnaky[index];
                zprava += abecedniZnak;
            }

            Console.WriteLine("Dekódovaná zpráva: {0}", zprava);
            Console.ReadKey();
        }
    }
}
