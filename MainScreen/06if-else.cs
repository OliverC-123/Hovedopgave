using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MainScreen
{
    class Class3
    {
        public void Opgaver6()
        {
            string valg = "";
            Console.WriteLine("Du har valgt If-else");
            Console.WriteLine("Du kan nu vælge imellem opgave 1, 2, 3, 4 ,5, 6 og 7\n\n");
            Console.WriteLine("Du kan vælge imellem\n'a' for opgave 1\n's' for opgave 2\n'd' for opgave 3\n'f' for opgave 4\n'g' for opgave 5\n'h' for opgave 6\n'j' for opgave 7");
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
                    int tal1 = 42;
                    int tal2 = 64;
                    int result = tal1 + tal2;
                    if (result > 100)
                    {
                        Console.WriteLine("Summen er større end 100!");
                    }
                    else if (result == 100)
                    {
                        Console.WriteLine("Summen er 100!");
                    }
                    else
                    {
                        Console.WriteLine("Summen er mindre end 100!");
                    }
                    Console.ReadKey();
                        break;
                    }
                case "s":
                    {
                    int alder;
                    Console.WriteLine("Indtast alder");
                    alder = Convert.ToInt32(Console.ReadLine());
                    if (alder > 57)
                    {
                        Console.WriteLine("Du er for gammel");
                    }
                    else
                    {
                        Console.WriteLine("Du er ikke for gammel");
                    }
                    Console.ReadKey();
                        break;
                    }
                case "d":
                    {
                    int alder;
                    Console.WriteLine("Indtast alder");
                    alder = Convert.ToInt32(Console.ReadLine());
                    if (alder > 60)
                    {
                        Console.WriteLine("Du er for gammel");
                    }
                    else if (alder >= 50 && alder <= 60)
                    {
                        Console.WriteLine("Du er hverken for gammel eller for ung");
                    }
                    else
                    {
                        Console.WriteLine("Du er for ung");
                    }
                    Console.ReadKey();
                        break;
                    }
                case "f":
                    {
                    string navn = "Oliver";
                    string Bruger1 = "olcar";
                    string Bruger;
                    string PW1;
                    string PW = "1234";

                    Console.WriteLine("Indtast brugernavn");
                    Bruger = Console.ReadLine();
                    Console.WriteLine("Indtast password");
                    PW1 = Console.ReadLine();
                    if (Bruger1 == Bruger || PW1 == PW) // min if tjekker om det indtastede information passer med Brugernavn og Password
                    {
                        Console.WriteLine($"Velkommen {navn}");
                    }
                    else
                    {
                        Console.WriteLine("Brugernavn eller password er forkert.");
                    }
                    Console.ReadKey();
                        break;
                    }
                case "g":
                    {
                    int i = 0;
                    string navn = "Oliver";
                    string Bruger1 = "olcar";
                    string PW1;
                    string PW = "1234";
                    string Bruger;

                    while (i == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Indtast brugernavn");
                        Bruger = Console.ReadLine();
                        i = 1;
                        if (Bruger == Bruger1)
                        {
                            while (i == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Indtast password");
                                PW1 = Console.ReadLine();
                                if (PW == PW1)
                                {
                                    Console.WriteLine($"Velkommen {navn}");
                                    Console.ReadKey();
                                    i = 0;
                                }
                                else if (PW != PW1)
                                {
                                    Console.WriteLine("Password er forkert");
                                    Console.ReadKey();
                                    i = 1;
                                }
                            }

                        }
                        else if (Bruger != Bruger1)
                        {
                            Console.WriteLine("Brugernavn er forkert.");
                            Console.ReadKey();
                            i = 0;
                        }
                    }

                    Console.ReadKey();
                        break;
                    }
                case "h":
                    {
                    int svar = 0;
                    double total;                  

                        while (true)
                        {
                            Console.WriteLine("Hvor mange km køre du til og fra arbejde, hver dag?");

                            try
                            {
                                svar = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Forkert indtastning");
                            }

                        }

                        if (svar <= 24)
                        {
                            Console.WriteLine("Du kører under 24km og får ikke noget fradag.");
                        }
                        else if (svar >= 25 && svar <= 120)
                        {
                            total = (svar - 24) * 1.93;
                            Console.WriteLine($"Du vil modtage {total} kr fradag");
                        }
                        else
                        {
                            total = 96 * 1.93 + (svar - 120) * 0.97;
                            Console.WriteLine($"Du vil modtage {total} kr fradag");
                        }
                        Console.ReadKey();                  
                        break;
                    }
                case "j":
                    {
                    string svar1;
                    int alder = 0;
                    Console.Title = "Festen";
                    while (true)
                    {
                        while (true)
                        {
                            Console.WriteLine("vælg imellem rød, grøn, blå og gul.");
                            svar1 = Console.ReadLine();
                            if (svar1 == "rød") // Dette var den nemmeste måde jeg kunne få den til at bestemme hvilken farve blev svaret
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            }
                            else if (svar1 == "grøn")
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                            else if (svar1 == "blå")
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            }
                            else if (svar1 == "gul")
                            {
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Forkert svar!");
                            }
                        }
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Indtast alder");
                            try
                            {
                                alder = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Forkert svar!");
                            }
                        }
                        if (alder >= 18)
                        {
                            Console.WriteLine("Velkommen til cocktailbaren!");
                            break;
                        }
                        else if (alder < 18)
                        {
                            Console.WriteLine("Velkommen til sodavandsbare!");
                            break;
                        }
                    }
                    Console.ReadKey();
                    Program test0 = new Program();
                    test0.MainScreen();
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
