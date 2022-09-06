using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfuncties
{
    class Oefening_7
    {
        enum klinkers { a, e, i, o, u };
        static void Main(string[] args)
        {
            Methodes.PasSchermkleurenAan(7);

            string invoer, letter, zonderklinkers = "";

            invoer = Methodes.GeefEenWoordIn("Geef een woord in: ");

            for (int i = 0; i < invoer.Length; i++)
            {
                letter = invoer.Substring(i, 1).ToLower();

                zonderklinkers += Enum.IsDefined(typeof(klinkers), letter) ? "" : letter;

                /*switch (letter)
                {
                    case "a":
                        break;
                    case "e":
                        break;
                    case "i":
                        break;
                    case "o":
                        break;
                    case "u":
                        break;
                    default:
                        resultaat += letter;
                        break;
                }*/

            }

            Console.WriteLine($"Het woord zonder klinkers is \"{zonderklinkers}\".");

            Methodes.DrukOpEnter();
        }
    }
}
