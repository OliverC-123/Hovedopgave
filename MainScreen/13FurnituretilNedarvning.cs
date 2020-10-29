using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Furniture // Dette er min class furniture til opgave 13 om nedarvning
    {
        protected double cost;
        protected string manufactorer = "IKEA";

        public void Setcost(Double cost)
        {
            this.cost = cost;
        }
        public double Getcost()
        {
            return cost;
        }
        public void Setmanufactorer(string cost)
        {
            this.manufactorer = manufactorer;
        }
        public string Getmanufactorer()
        {
            return manufactorer;
        }
        public void PrintInfo()
        {
            Console.WriteLine("[Furniture] " + manufactorer + " - " + cost); // Detter er en trejde måde at udskrive variabler i tekst
        }
    }
}
