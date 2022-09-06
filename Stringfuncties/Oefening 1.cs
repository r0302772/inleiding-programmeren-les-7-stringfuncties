using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfuncties
{
    class Oefening_1
    {
        static void Main(string[] args)
        {
            Methodes.PasSchermkleurenAan(1);

            string invoer;
            int som = 0;

            do
            {
                Console.Write("Geef een getal: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out int getal));

            int lengte = invoer.Length;

            for (int i = 0; i < lengte; i++)
            {
                string invoerDeel = invoer.Substring(i, 1);
                int getalDeel = int.Parse(invoerDeel);
                som += getalDeel;
            }

            Console.WriteLine($"De som van de cijfers is {som}.");

            Methodes.DrukOpEnter();
        }
    }
}
