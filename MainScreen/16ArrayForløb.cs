using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Array_for
    {
        public void Opgave16()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Returtyper og parametre");
            Console.WriteLine("Du kan nu vælge opgave 1\n\n");
            Console.WriteLine("Du kan vælge\n'a' for opgave 1");
            Console.WriteLine("Tryk 'b' for at gå tilbage til hovedmenuen");
            try
            {
                valg = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Indtast gyldigt valgmulighed som henvist");
            }
            switch (valg)
            {
                case "a":
                    {
                    int[] numbers = new int[6];
                    // Gør array værdier valgfrit
                        Console.WriteLine("Indtast værdier til et array");
                        numbers[0] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast værdier til et array");
                        numbers[1] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast værdier til et array");
                        numbers[2] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast værdier til et array");
                        numbers[3] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast værdier til et array");
                        numbers[4] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast værdier til et array");
                        numbers[5] = Convert.ToInt32(Console.ReadLine());

                    int sum = numbers.Sum(); // int sum udregner sum af numbers
                        Console.WriteLine("Total sum af array er - " + sum);

                    string[] words = { "Yes", "No", "Yes", "No", "Maybe" }; // Array med ord
                    for (int i = 0; i < words.Length; i++) // Kører igennem array med ord
                        Console.WriteLine(words[i]); // Udskriver array med ord

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
