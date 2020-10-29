using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Program
    {
        public void MainScreen() // Class til hele mit loop med MainScreen
        {
            while (true) // Loop til at holde programmet kørende indtil man indtaster tal over 17
            {
                int valg = 0;
                Console.WriteLine("Velkommen til Olivers C# Opgave");
                Console.WriteLine("Du har nu mulighed for at vælge et emne og se opgaver der hører til");
                Console.WriteLine("1. ----- Variable\n2. ----- Strings\n3. ----- Aritmetiske udtryk\n4. ----- Variabler in udtryk\n5. ----- Boolean");
                Console.WriteLine("6. ----- If-Else\n7. ----- Switch cases\n8. ----- Loops\n9. ----- Udvidet kontrolstruktur");
                Console.WriteLine("10. ----- Metoder og Instanser\n11. ----- Returtyper og Parametre\n12. ----- Istancevariabler\n13. ----- Nedarvning\n14. ----- Konstruktors");
                Console.WriteLine("15. ----- Arrays\n16. ----- Gennemløb af Arrays\n17. ----- Public, Private og Protected\n");
                Console.WriteLine("Hvis du indtaster et tal over 17 lukker programmet.");
                try
                {
                    valg = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Indtast gyldigt tal som henvist");                    
                }    // Try catch command der ser om variablen 'valg' kan oversættes til int32 for at kunne blive brugt til min switch          
                switch (valg) // Hovedswitch der bruger metoder til at komme ud til alle mine klasser
                {
                    case 1:
                        {
                        Variabler test1 = new Variabler(); // kalder på min klasse
                        test1.Opgaver1(); // Bruger en metode til at tilkomme klassen
                            break;
                        }
                    case 2:
                        {
                        Strings test2 = new Strings();
                        test2.Opgaver2();
                            break;
                        }
                    case 3:
                        {
                        Class1 test3 = new Class1();
                        test3.Opgaver3();
                            break;
                        }
                    case 4:
                        {
                        Class2 test4 = new Class2();
                        test4.Opgaver4();
                            break;
                        }
                    case 5:
                        {
                        Bool test5 = new Bool();
                        test5.Opgaver5();
                            break;
                        }
                    case 6:
                        {
                        Class3 test6 = new Class3();
                        test6.Opgaver6();
                            break;
                        }
                    case 7:
                        {
                        Class4 test7 = new Class4();
                        test7.Opgaver7();
                            break;
                        }
                    case 8:
                        {
                        Loops test8 = new Loops();
                        test8.Opgaver8();
                            break;
                        }
                    case 9:
                        {
                        Class5 test9 = new Class5();
                        test9.Opgaver9();
                            break;
                        }
                    case 10:
                        {
                        Class6 test10 = new Class6();
                        test10.Opgaver10();
                            break;
                        }
                    case 11:
                        {
                        Class7 test11 = new Class7();
                        test11.Opgaver11();
                            break;
                        }
                    case 12:
                        {
                        Class8 test12 = new Class8();
                        test12.Opgaver12();
                            break;
                        }
                    case 13:
                        {
                        Class9 test13 = new Class9();
                        test13.Opgave13();
                            break;
                        }
                    case 14:
                        {
                        Konstruktors test14 = new Konstruktors();
                        test14.Opgave14();
                            break;
                        }
                    case 15:
                        {
                         Arrays test15 = new Arrays();
                        test15.Opgave15();
                            break;
                        }
                    case 16:
                        {
                        Array_for test16 = new Array_for();
                        test16.Opgave16();
                            break;
                        }
                    case 17:
                        {
                            PPP test17 = new PPP();
                            test17.Opgave17();
                            break;
                        }

                    default: // Default er alle andre godkendte indputs
                        {
                            Environment.Exit(0); // Denne command slukker programmet
                        }                    
                        break;
                }
                Console.ReadKey();
            }
        }
        static void Main(string[] args) // Alt det her er hvad der starter når programmer starter
        {
            Console.Title = "Oliver's C# Opgave"; // Giver mit program en title
            Console.BackgroundColor = ConsoleColor.DarkBlue; // Jeg kan bedre lide den mørkeblå end den standard sorte
            Console.Clear();
            Program Opgaver = new Program();
            Opgaver.MainScreen();
        }
    }
}
