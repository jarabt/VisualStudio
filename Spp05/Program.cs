using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spp05
{
    class Program
    {
        static void Main(string[] args)
        {
 		    Console.WriteLine("Zadej smajlíka: ");
            string smajlik = Console.ReadLine();
            switch (smajlik)
            {
                case ":-)":
                    Console.WriteLine("Tvůj smajlík je veselý");
                    break;
                case ":-(":
                    Console.WriteLine("Tvůj smajlík je smutný");
                    break;
                case ":-*":
                    Console.WriteLine("Tvůj smajlík je zamilovaný");
                    break;
                case ":-P":
                    Console.WriteLine("Tvůj smajlík je s vyplazeným jazykem");
                    break;
                case ":)":
                    Console.WriteLine("Tvůj smajlík je veselý");
                    break;
                case ":(":
                    Console.WriteLine("Tvůj smajlík je smutný");
                    break;
                case ":*":
                    Console.WriteLine("Tvůj smajlík je zamilovaný");
                    break;
                case ":P":
                    Console.WriteLine("Tvůj smajlík je s vyplazeným jazykem");
                    break;
                default:
                    Console.WriteLine("Tvůj smajlík je neznámý");
                    break;
            }
Console.ReadLine();


		}
    }
}
