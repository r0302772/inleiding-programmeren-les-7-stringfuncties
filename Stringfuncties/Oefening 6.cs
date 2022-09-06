using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfuncties
{
    class Oefening_6
    {
        static void Main(string[] args)
        {
            Methodes.PasSchermkleurenAan(6);

            string opgave1 = "Geef een woord 1 in: ", woord1, woord2, letter1, letter2, resultaat;

            woord1 = Methodes.GeefEenWoordIn(opgave1);
            woord2 = Methodes.GeefEenWoordIn("Geef een woord 2 in: ");

            int lengte, woord1lengte = woord1.Length, woord2lengte = woord2.Length, opgavelengte = opgave1.Length;

            lengte = woord1lengte < woord2lengte ? woord1lengte : woord2lengte;

            resultaat = new string(' ', opgavelengte);

            for (int i = 0; i < lengte; i++)
            {
                letter1 = woord1.Substring(i, 1).ToLower();
                letter2 = woord2.Substring(i, 1).ToLower();

                resultaat += letter1 == letter2 ? '-' : ' ';

                /*if (letter1 == letter2)
                {
                    resultaat += '-';
                }

                else
                {
                    resultaat += ' ';
                }*/
            }

            Console.WriteLine(resultaat);

            Methodes.DrukOpEnter();
        }
    }
}
