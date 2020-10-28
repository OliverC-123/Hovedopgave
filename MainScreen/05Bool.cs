using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Bool
    {
        public void Opgaver5()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Boolean");
            Console.WriteLine("Du kan nu vælge opgave 1\n\n");
            Console.WriteLine("Du kan vælge mellem\n'a' for opgave 1\nAlle andre vil sende dig tilbage til hovedmenuen");
            valg =Console.ReadLine();
            switch (valg)
            {
                case "a":
                    { int var1 = 2;
                    int var2 = 1;
                    bool ean = var1 > var2;
                    Console.WriteLine($"{ean}");
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
