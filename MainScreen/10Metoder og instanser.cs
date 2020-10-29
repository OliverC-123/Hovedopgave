using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    public class Bog
    {
        public void PrintInfo()
        {
            Console.WriteLine("Jeg er en bog");
        }
        public bool HarRaad(int pris, int penge)
        {
            if (penge > pris)
            {
                Console.WriteLine("Du har råd til bogen");
            }
            else
            {
                Console.WriteLine("Du har ikke råd til bogen");
            }
            return penge < pris;
        }
    }
    class Class6
    {
        public void Opgaver10()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Metoder og instanser");
            Console.WriteLine("Du kan nu vælge imellem opgave 1 og 2\n\n");
            Console.WriteLine("Du kan vælge imellem\n'a' for opgave 1\n's' for opgave 2");
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
                    Bog Sherlock_Holmes = new Bog();
                    Sherlock_Holmes.PrintInfo();
                    Console.ReadKey();
                        break;
                    }
                case "s":
                    {
                    Bog Sherlock_Holmes = new Bog();
                    Sherlock_Holmes.PrintInfo();
                    Sherlock_Holmes.HarRaad(150, 160);
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
