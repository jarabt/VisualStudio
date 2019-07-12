using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pp09
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "moribundus";
            string password = "ahoj";
            string password_full = "";
            int length = s.Length;
            int index = 0;
            string encrypted = "";
            for (int i = 0; i < length; i++)
            {
                if (index > password.Length - 1)
                    index = 0;                
                password_full += password[index];
                index += 1;
            }

            int ascii;
            int new_ascii;
            for (int j = 0; j < length; j++)
            {
                ascii = (int)s[j];
                new_ascii = ascii + ((int)password_full[j] - ((int)'a' - 1));
                if (new_ascii > (int)'z')
                    new_ascii -= ((int)'z' - ((int)'a' - 1));
                encrypted += (char)new_ascii;                
            }

            Console.WriteLine(encrypted);
            Console.ReadLine();

        }
    }
}
