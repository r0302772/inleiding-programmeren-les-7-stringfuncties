using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfuncties
{
    class Oefening_3
    {
        static void Main(string[] args)
        {
            Methodes.PasSchermkleurenAan(3);

            string invoer, uitvoer = "";

            invoer = Methodes.GeefEenWoordIn("Geef een woord in: ");

            for (int i = 0; i < invoer.Length; i++)
            {
                uitvoer = uitvoer.Insert(0, invoer.Substring(i, 1));
            }

            string besluit = invoer == uitvoer ? "een" : "geen";

            Console.WriteLine($"\"{invoer}\" is {besluit} palindroom.");

            Methodes.DrukOpEnter();
        }
    }
}
