using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Class1
    {
        public void Opgaver3()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Aritmetiske udtryk");
            Console.WriteLine("Du kan nu vælge opgave 1\n\n");
            Console.WriteLine("Du kan vælge mellem\n'a' for opgave 1\nAlle andre vil sende dig tilbage til hovedmenuen");
            valg = Console.ReadLine();
            switch (valg)
            {
                case "a":
                    {
                    double tal1 = 2 + 1 * 2;
                    double tal2 = (2 + 1) * 2;
                    double tal3 = 5 / 2;
                    double tal4 = 8 % 3;
                    double tal5 = 1 - 5;
                    Console.WriteLine($"2 + 1 * 2 = {tal1}\n (2 + 1) * 2 ={tal2}\n 5 / 2 ={tal3}\n 8 % 3 ={tal4}\n 1-5 = {tal5}");
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
