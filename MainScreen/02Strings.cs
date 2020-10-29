using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Strings
    {
        public void Opgaver2()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Strings");
            Console.WriteLine("Du kan nu vælge imellem opgave 1, 2, 3, og 4\n\n");
            Console.WriteLine("Du kan vælge imellem\n'a' for opgave 1\n's' for opgave 2\n'd' for opgave 3\n'f' for opgave 4");
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
                case "a":
                    {
                    int tal1 = 25;
                    string tal2 = "Oliver";
                    double tal3 = 6.1;
                    Console.WriteLine("{0}\n{1}\n{2}", tal1, tal2, tal3);
                    Console.ReadKey();
                        break;
                    }
                case "s":
                    {
                    int tal1 = 25;
                    string tal2 = "Oliver";
                    double tal3 = 5.12;
                    Console.WriteLine("{0}\n{1}\n{2}", tal1, tal2, tal3);
                    Console.ReadKey();
                        break;
                    }
                case "d":
                    {
                    string Value = "I dag har vi den 24. December";
                    Console.WriteLine("{0}", Value); // Dette er den metoder vi lærte at bruge på grundforløbet til at udskrive en variable. Jeg bruger dog flere metoder igennem alle opgaverne
                    Console.ReadKey();
                        break;
                    }
                case "f":
                    {
                    double worth = 200.50;
                    string jeg = "Jeg har";
                    string bank = "kr. i banken";
                    Console.WriteLine("{0} {1} {2}", jeg, worth, bank);
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
