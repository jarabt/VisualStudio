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
            for (int i = 0; i < length; i++)
            {
                if (index > password.Length - 1)
                    index = 0;                
                password_full += password[index];
                index += 1;
            }
            Console.WriteLine(password_full);
            Console.ReadLine();

        }
    }
}
