using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class PPP
    {

        public void Opgave17()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Returtyper og parametre");
            Console.WriteLine("Du kan nu vælge opgave 1\n\n");
            Console.WriteLine("Du kan vælge \n'a' for en kort beskrivelse af Private, Protected og Public");
            Console.WriteLine("Tryk 'b' for at gå tilbage til hovedmenuen");
            try
            {
                valg = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Indtast gyldigt valgmulighed som henvist");
            }
            switch (valg)
            {
                case "a": // Meget kort beskrivelse om de 3 måder at tilgængelig gøre en class
                    {
                    Console.WriteLine("Private = Kan kun 'kalde' på sin egne objekter og instanser\nProtected = Kan 'kalde' på sig selv og nedarvede objekter/instanser");
                    Console.WriteLine("Public = Alle kan 'kalde' på public objekter eller instanser");
                    Console.WriteLine("Istans variabler er som standard private\nHvor metoder er some standard public");
                        break;
                    }
                case "b":
                    {
                    Program test6 = new Program();
                    test6.MainScreen();
                        break;
                    }
                default:                   
                    break;
            }
        }
    }
}
