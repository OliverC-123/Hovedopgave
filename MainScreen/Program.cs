using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Program
    {
        public void MainScreen()
        {
            while (true)
            {
                int valg = 0;
                Console.WriteLine("Velkommen til Olivers C# Opgave");
                Console.WriteLine("Du har nu mulighed for at vælge et emne og se opgaver der hører til");
                Console.WriteLine("1. ----- Variable\n2. ----- Strings\n3. ----- Aritmetiske udtryk\n4. ----- Variabler in udtryk\n5. ----- Boolean");
                Console.WriteLine("6. ----- If-Else\n7. ----- Switch cases\n8. ----- Loops\n9. ----- Udvidet kontrolstruktur");
                Console.WriteLine("10. ----- Metoder og Instanser\n11. ----- Returtyper og Parametre\n12. ----- Istancevariabler\n13. ----- Nedarvning\n14. ----- Konstruktors");
                Console.WriteLine("15. ----- Arrays\n16. ----- Gennemløb af Arrays\n17. ----- Public, Private og Protected\n");
                valg = Convert.ToInt32(Console.ReadLine());
                switch (valg)
                {
                    case 1:
                        {
                            Variabler test1 = new Variabler();
                            test1.Opgaver1();
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

                    default:
                        {

                        }
                        break;
                }
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            Program Opgaver = new Program();
            Opgaver.MainScreen();
        }
    }
}
