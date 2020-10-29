using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Arrays
    {
        public void Opgave15()
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
                    int[] number = { -2, -1, 0, 10 }; // Konstant for start

                    Console.WriteLine(number[3]);
                    Console.WriteLine(number[1]);
                    int[] numbers = new int[4]; // Værdier kan komme når de behøves
                    numbers[0] = -2;
                    numbers[1] = -1;
                    numbers[2] = 0;
                    numbers[3] = 10;
                    Console.WriteLine(number[3]);
                    Console.WriteLine(number[1]);
                    int sum = numbers.Sum(); // int sum udregner sum af numbers
                    Console.WriteLine(sum);
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
