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
        }
       
    }
}
