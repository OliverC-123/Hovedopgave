using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Class5
    {
        public void Opgaver9()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Udvidet kontrolstruktur");
            Console.WriteLine("Du kan nu vælge imellem opgave 1, 2, 3, 4 og 5\n\n");
            Console.WriteLine("Du kan vælge imellem\n'a' for opgave 1\n's' for opgave 2\n'd' for opgave 3\n'f' for opgave 4\n'g' for opgave 5");
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
                        for (int i = 0; i < 22; i += 3)
                        {
                            Console.WriteLine(i);

                        }
                        Console.WriteLine("Loopen er nu stoppet.");
                        Console.ReadKey();
                        break;
                    }
                case "s":
                    {
                        for (int i = 0; i < 41; i += 4) // loop til 4 tabel
                        {
                            if (i == 16) // if 16 spring over
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine("Loopen er nu stoppet.");
                        Console.ReadKey();
                        break;
                    }
                case "d":
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

                        if (svar <= 24) // If sætter en krav
                        {
                            Console.WriteLine("Du kører under 24km og får ikke noget fradag.");
                        }
                        else if (svar >= 25 && svar <= 120) // Hvis if ikke opfylders prøver den else if
                        {
                            total = ((svar - 24) * 154) / 100;
                            Console.WriteLine($"Du vil modtage {total} kr fradag");
                        }
                        else // Hvis else if heller ikke opfylders sker else
                        {
                            total = (96 * 154) / 100 + ((svar - 120) * 77) / 100;
                            Console.WriteLine($"Du vil modtage {total} kr fradag");
                        }
                        Console.ReadKey();
                        break;
                    }
                case "f":
                    {
                        int løn = 0;
                        double startskat = 0;
                        double mellemskat = 0;
                        double topskat = 0;
                        double efterSkat = 0;
                        while (true)
                        {
                            Console.WriteLine("Indtast årlig indkomst før skat");
                            try
                            {
                                løn = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Indtast gyldig indtægt");
                                break;
                            }


                            if (løn <= 42000)
                            {
                                Console.WriteLine("Din indkomst er ikke nok til at betale skat");
                            }
                            else if (løn > 42000 && løn <= 280000)
                            {
                                Console.WriteLine("Din løn ligger imellem 42 000 og 280.000\nDu skal betale 30% i bundskat af din løn efter de første 42.000");
                                startskat = løn * 0.30;
                                Console.WriteLine($"Du betalte {startskat}kr i bundskat");
                                efterSkat = løn * 0.70;
                                Console.WriteLine($"Du får {efterSkat}kr. udbetalt");
                            }
                            else if (løn > 280000 && løn < 390000)
                            {
                                Console.WriteLine("Din løn ligger imellem 280.000 og 390.000\nDu skal betale 6% i " +
                                "mellemskat af alt tjent over 280.000 og bundskat af de først 280.000 minus 42.000 fradag");
                                startskat = 280000 * 0.70;
                                Console.WriteLine($"Du betalte {startskat}kr i bundskat");
                                mellemskat = (løn - 280000) * 0.94 + startskat;
                                Console.WriteLine($"Du betalte {mellemskat}kr i mellemskat");
                                efterSkat = mellemskat;
                                Console.WriteLine($"Du får {efterSkat}kr. udbetalt");
                            }
                            else if (løn > 390000)
                            {
                                Console.WriteLine("Din løn er over 390.000\n Du skal betale 15% topskat af alt tjent over 390.000" +
                                " og bundskat af de først 280.000 minus 42.000 fradag og mellemskat af din løn imellem de først 280.000 og 390.000");
                                topskat = (løn - 390000) * 0.85;
                                Console.WriteLine($"Du betalte {topskat}kr i topskat");
                                mellemskat = 110000 * 0.94;
                                Console.WriteLine($"Du betalte {mellemskat}kr i mellemskat");
                                startskat = (løn - 238000) * .70;
                                Console.WriteLine($"Du betalte {startskat}kr i bundskat");
                                efterSkat = topskat + mellemskat + startskat;


                                Console.WriteLine($"Du får {efterSkat}kr. udbetalt");
                            }
                            Console.ReadKey();
                        }
                        break;
                    }
                case "g":
                    {
                        double rente = 0;
                        double penge = 0;
                        double total = 0;

                        while (true)
                        {
                            Console.WriteLine("Hvor mange penge har du på din konto?");
                            try
                            {
                                penge = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Indtast gyldigt beløb");
                                break;
                            }

                            if (penge <= 25000)
                            {
                                rente = (penge * 1.0025) - penge;
                                Console.WriteLine(rente);
                            }
                            else if (penge > 25000 && penge <= 150000)
                            {
                                rente = (penge * 1.0125) - penge;
                                Console.WriteLine(rente);
                            }
                            else if (penge > 150000)
                            {
                                total = (150000 * 1.25 / 100) + (penge - 150000) * 0.5 / 100;
                                Console.WriteLine(total);
                            }
                            Console.ReadKey();
                        }
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
