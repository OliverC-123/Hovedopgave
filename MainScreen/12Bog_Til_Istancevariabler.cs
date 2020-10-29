using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    public class Bog1 // Denne class er til opgaven med Istancevariabler
    {
        public double Råd;
        public double GetRåd()
        {
            return Råd;
        }
        public void SetRåd(double Råd)
        {
            this.Råd = Råd;
        }
        public string title = "";

        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string Gettitle()
        {
            return title;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Jeg er en bog");
        }
        public double pris;
        public double Getpris()
        {
            return pris;
        }
        public void Setpris(double pris)
        {
            this.pris = pris;
        }

    }
}
