using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfuncties
{
    public static class Methodes
    {
        public static void DrukOpEnter()
        {
            Console.WriteLine();
            Console.Write("Druk op enter om verder te gaan!");
            Console.ReadLine();
        }
        public static void PasSchermkleurenAan(int oefening)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = $"Oefening {oefening} - " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
        }
        public static string GeefEenWoordIn(string opgave)
        {
            string invoer;

            do
            {
                Console.Write(opgave);
                invoer = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(invoer));

            return invoer;
        }

    }
}
