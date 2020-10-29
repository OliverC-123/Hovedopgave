using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Variabler
    {
        public void Opgaver1() // Har ikke brugt noget her jeg ikke brugte på MainScreen
        {
           
            string valg = ""; 
            Console.WriteLine("Du har valgt Variabler");
            Console.WriteLine("Du kan nu vælge imellem opgave 1, 2, 3,4 ,5 og 6\n\n");
            Console.WriteLine("Du kan vælge imellem\n'a' for opgave 1\n's' for opgave 2\n'd' for opgave 3\n'f' for opgave 4\n'g' for opgave 5\n'h' for opgave 6");
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
                    int tal1 = 5;
                    int tal2 = 3;

                    Console.WriteLine($"{tal1}\n{tal2}");
                    Console.ReadKey();


                        break;
                    }
                case "s":
                    {
                    int tal1 = 5;
                    int tal2 = 3;

                    Console.WriteLine("Tal1 er {0}\nTal2 er {1}", tal1, tal2);
                    Console.ReadKey();

                        break;
                    }
                case "d":
                    {
                    string Navn = "Søren";
                    int Alder = 16;
                    double Penge = 1234.34;
                    Console.WriteLine("Jeg hedder {0}, er {1} år gammel og har tjent {2} kr. å at lappe cykler", Navn, Alder, Penge);
                    Console.ReadKey();
                        break;
                    }
                case "f":
                    {
                    double Kage = 23.56;
                    double Øl = 34.67;
                    double Pølse = 65.34;
                    Console.WriteLine("Kage\t{0} Øl\t{1} Pølse\t{2}", Kage, Øl, Pølse);
                    Console.WriteLine("I alt beregning {0}", Kage + Øl + Pølse);
                    Console.ReadKey();
                        break;
                    }
                case "g":
                    {
                    string Navn;
                    int Alder = 0;
                    Console.WriteLine("Indskriv navn.");
                    Navn = Console.ReadLine();
                    Console.WriteLine("Indskriv alder.");
                    try
                    {
                        Alder = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Genstart.");
                        Alder = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Jeg hedder {0} og er {1} år gammel.", Navn, Alder);
                    Console.ReadKey();
                        break;
                    }
                case "h":
                    {
                    double Pi = Math.PI;
                    int r;
                    Console.WriteLine("Indtast radius");
                    r = Convert.ToInt32(Console.ReadLine());
                    double R2 = Math.Pow(r, 2);
                    Console.WriteLine("Resutalt: {0}\nVia formel: Areal ", Pi * R2);
                    Console.ReadKey();
                        break;
                    }
                case "b": // min 'b' case bliver brugt til at retunere til MainScreen via en klasse/metode som MainScreen brugte til at komme her hen
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
