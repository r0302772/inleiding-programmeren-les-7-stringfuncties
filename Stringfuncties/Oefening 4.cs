using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfuncties
{
    class Oefening_4
    {
        static void Main(string[] args)
        {
            Methodes.PasSchermkleurenAan(4);

            string invoer, uitvoer1, uitvoer2;

            invoer = Methodes.GeefEenWoordIn("Geef een woord in: ").ToLower();

            //de letter "o" vervangen door letter "x" 
            uitvoer1 = invoer.Replace("o", "x");

            Console.WriteLine($"\nWe vervangen \"o\" met \"x\": \"{uitvoer1}\"");

            //de letter "x" vervangen door letter "p"
            uitvoer2 = Vervangen(uitvoer1, "x", "p");

            Console.WriteLine($"\nWe vervangen \"x\" met \"p\": \"{uitvoer2}\"");

            Methodes.DrukOpEnter();
        }

        private static string Vervangen(string start, string x, string y)
        {
            string uitvoer = "";

            for (int i = 0; i < start.Length; i++)
            {
                string letter = start.Substring(i, 1);
                uitvoer += letter == x ? y : letter;
            }

            return uitvoer;
        }
    }
}
