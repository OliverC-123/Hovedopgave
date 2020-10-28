using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Class2
    {
        public void Opgaver4()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Variabler i udtryk");
            Console.WriteLine("Du kan nu vælge imellem opgave 1 og 2\n\n");
            Console.WriteLine("Du kan vælge imellem\n'a' for opgave 1\n's' for opgave 2\nAlle andre vil sende dig tilbage til hovedmenuen");
            valg = Console.ReadLine();
            switch (valg)
            {
                case "a":
                    {
                    int tal1 = 100;
                    int tal2 = 200;
                    int tal3 = 300;
                    int result;
                    result = tal1 + tal2 * tal3;
                    Console.WriteLine($"{result}");
                    Console.ReadKey();
                        break;
                    }
                case "s":
                    {
                    double tal1 = 20.5;
                    double tal2 = 9.101;
                    double tal3 = 4.9;
                    double result;
                    result = tal1 * tal2 - tal3;
                    Console.WriteLine($"{tal1} * {tal2} - {tal3} = {result}");
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
