using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Class4
    {
        public void Opgaver7()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Switch Cases");
            Console.WriteLine("Du kan nu vælge imellem opgave 1 og 2\n\n");
            Console.WriteLine("Du kan vælge imellem\n'a' for opgave 1\n's' for opgave 2\nAlle andre vil sende dig tilbage til hovedmenuen");
            valg = Console.ReadLine();
            switch (valg)
            {
                case "a":
                    {
                    int valg1 = 0 ;                        
                    string textToEnter = "TILLYKKE DU HAR VUNDET";
                    Console.WriteLine("indtast tal mellem 1 og 6");

                    while (true)
                        try
                        {
                               
                            valg1 = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Forkert svar!");
                        }

                    switch (valg1)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 5:
                        case 6:
                            {
                                Console.WriteLine($"Du har tastest {valg1}");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Forkert indput");
                                break;
                            }
                    }

                    Console.ReadKey();
                        break;
                    }
                case "s":
                    {
                    int svar = 0;
                    while (true)
                    {
                        Console.WriteLine("Vælg imellem ------\n1. Isbjørn - 10kr\n2. Champangnebrus - 15kr\n3.Tequila Sunrise - 20kr\n4. Mojito - 30kr\n5. Brandbil - 5kr\n6. Filur - 8kr");
                        try
                        {
                            svar = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Forkert valgmulighed!");
                        }

                    }
                    switch (svar)
                    {
                        case 1:
                            {
                                Console.WriteLine("Du har valgt en Isbjørn til 10kr");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Du har valgt en Champagnebrus til 15kr");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Du har valgt en Tequila Sunrise til 20kr");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Du har valgt en Mojito til 30kr");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Du har valgt en Brandbil til 5kr");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Du har valgt en Filur til 8kr");
                                break;
                            }
                    }
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
