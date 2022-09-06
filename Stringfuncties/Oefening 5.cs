using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfuncties
{
    class Oefening_5
    {
        static void Main(string[] args)
        {
            Methodes.PasSchermkleurenAan(5);

            string invoer, opgave = "Geef een woord in: ";

            invoer = Methodes.GeefEenWoordIn(opgave);

            Console.Write(new string(' ', opgave.Length));
            Console.WriteLine(new string('*', invoer.Length));

            Methodes.DrukOpEnter();
        }
    }
}
