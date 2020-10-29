using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Konstruktors
    {
        public void Opgave14()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Returtyper og parametre");
            Console.WriteLine("Du kan nu vælge opgave 1\n\n");
            Console.WriteLine("Du kan vælge \n'a' for opgave 1");
            Console.WriteLine("Tryk 'b' for at gå tilbage til hovedmenuen");
            try
            {
                valg = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Indtast gyldigt tal som henvist");
            }
            switch (valg)
            {
                case "a":
                    {
                    Bog2 Moby = new Bog2("Arnold", "Moby Dickenson", 240.50);
                    Moby.Print();
                    Console.ReadKey();
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
