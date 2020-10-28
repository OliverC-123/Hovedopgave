using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Bil
    {
        public void FillGas(Double Liters, bool isDiesel)
        {
            Console.Write("Filled tank with: " + Liters + " Liters of ");
            if (isDiesel)
            {
                Console.WriteLine("Diesel");
            }
            else
            {
                Console.WriteLine("Gas");
            }

        }
        public double RemainingGas()
        {
            return 7.5;
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine has started!");
        }
        public void StopEngine()
        {
            Console.WriteLine("Engine has stopped!");
        }
    }
    class Class7
    {
        public void Opgaver11()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Returtyper og parametre");
            Console.WriteLine("Du kan nu vælge opgave 1\n\n");
            Console.WriteLine("Du kan vælge mellem\n'a' for opgave 1\nAlle andre vil sende dig tilbage til hovedmenuen");

            valg = Console.ReadLine();
            switch (valg)
            {
                case "a":
                    { 
                    Bil ford = new Bil();
                    ford.FillGas(7.5, false);

                    Console.WriteLine(ford.RemainingGas() + " remaining");

                    ford.StartEngine();
                    ford.StopEngine();

                    Console.ReadKey();
                    break;
                    }
                default:
                    {
                    Program test6 = new Program();
                    test6.MainScreen();
                    }
                    break;
            }
        }
    }
}
