using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Class8
    {
        public void Opgaver12()
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
                    Bog1 Moby = new Bog1();
                    Moby.SetTitle("Moby Dick");
                    Console.WriteLine("Bogen hedder " + Moby.Gettitle());
                    Bog1 cost = new Bog1();
                    cost.Setpris(240);
                    Console.WriteLine(Moby.Gettitle() + " Koster " + cost.Getpris());
                    Bog1 afford = new Bog1();
                    afford.SetRåd(200);
                    Console.WriteLine("Du har " + afford.GetRåd() + " og har ikke råd til bogen");
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
