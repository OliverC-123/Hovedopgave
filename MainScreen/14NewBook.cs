using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    public class Bog2
    {
        public double pris;
        public string title;
        public string forfatter;
        public Bog2(string forfatter, string title, double pris)
        {
            this.forfatter = forfatter;
            this.pris = pris;
            this.title = title;
        }
        public void Print()
        {
            Console.WriteLine("[Bog] " + title + " --- " + pris + "kr --- " + forfatter);
        }
    }
}
