using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Chair : Furniture // Her beder jeg class Chair om at nedarve fra Furniture
    {
        private int ben;

        public void Setben(int ben)
        {
            this.ben = ben;
        }
        public int Getben()
        {
            return ben;
        }
        public void PrintInfo()
        {
            Console.WriteLine("[Stol] " + manufactorer + " - " + cost + "kr. - " + ben + " ben ");
        }
    }
}
