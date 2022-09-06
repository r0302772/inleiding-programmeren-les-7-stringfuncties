using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfuncties
{
    class Oefening_2
    {
        static void Main(string[] args)
        {
            Methodes.PasSchermkleurenAan(2);

            string rekeningnummer, rekeningnummerzonderspaties, boodschap;

            do
            {
                Console.Write("Geef een rekeningnummer: ");
                //voorbeeld BE09 9799 3153 9097
                rekeningnummer = Console.ReadLine();
                rekeningnummerzonderspaties = rekeningnummer.Replace(" ", "");
            }
            while (rekeningnummerzonderspaties.Length != 16 || rekeningnummer.IndexOf("BE") != 0 || !long.TryParse(rekeningnummerzonderspaties.Substring(3), out long rn));

            //"BE09" van rekeningnummmer verwijderen, 9799 3153 9097 blijft over

            //Optie 1
            //rekeningnummer = rekeningnummer.Remove(' ');

            //Optie 2
            rekeningnummer = rekeningnummer.Substring(5);

            //Spaties vervangen door niets, 9799 3153 9097 wordt 979931539097
            rekeningnummer = rekeningnummer.Replace(" ", "");

            //979931539097, deel1 = 9799315390, deel2 = 97 
            string deel1 = rekeningnummer.Substring(0, 10);
            string deel2 = rekeningnummer.Substring(10);

            long getal = long.Parse(deel1);
            int controle = int.Parse(deel2);
            long rest = getal % 97;

            if (rest == 0)
            {
                rest = 97;
            }

            //Shorthand If statement

            boodschap = rest == controle ? "Rekeningnummer is OK" : "Rekeningnummer is niet OK";

            //Long

            /*if (rest == controle)
            {
                boodschap = "Rekeningnummer is OK";
            }
            else
            {
                boodschap = "Rekeningnummer is niet OK";
            }*/

            Console.WriteLine($"\n{boodschap}");

            Methodes.DrukOpEnter();
        }
    }
}
