using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Loops
    {
        public void Opgaver8()
        {
            string valg = "";
            Console.WriteLine("Du har valgt Loops");
            Console.WriteLine("Du kan nu vælge imellem opgave 1, 2, 3, 4 ,5, 6, 7, 8 og 9\n\n");
            Console.WriteLine("Du kan vælge imellem\n'a' for opgave 1\n's' for opgave 2\n'd' for opgave 3\n'f' for opgave 4");
            Console.WriteLine("'g' for opgave 5\n'h' for opgave 6\n'z' for opgave 7\n'x' for opgave 8\n 'c' for opgave 9");
            Console.WriteLine("Tryk 'b' for at gå tilbage til hovedmenuen");
            valg = Console.ReadLine();
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
                        Console.WriteLine("for loop");
                        for (int i = 1; i < 11; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        int u = 1;
                        Console.WriteLine("while loop");
                        while (u < 11)
                        {
                            Console.WriteLine(u);
                            u++;
                        }
                        Console.ReadKey();
                        break;
                    }
                case "s":
                    {
                        Console.WriteLine("For loop");
                        for (int i = 100; i >= 0; i--)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        int u = 100;
                        Console.WriteLine("While loop");
                        while (u >= 0)
                        {
                            Console.WriteLine(u);
                            u--;
                        }
                        Console.ReadKey();
                        break;
                    }
                case "d":
                    {
                        for (int i = 5; i <= 50; i += 5)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        break;
                    }
                case "f":
                    {
                        Console.WriteLine("For loop");
                        for (int i = 20; i >= 0; i--)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        int u = 20;
                        Console.WriteLine("While loop");
                        while (u >= 0)
                        {
                            Console.WriteLine(u);
                            u--;
                        }
                        Console.ReadKey();
                        break;
                    }
                case "g":
                    {
                        int u = 0;
                        for (int i = 7; i <= 70; i += 7)
                        {
                            u++;

                            Console.WriteLine($"{u} * 7 = {i}");
                        }
                        Console.ReadKey();
                        break;
                    }
                case "h":
                    {
                        int u = 0;
                        int svar = 0;

                        while (true)
                        {
                            Console.WriteLine("Indtast tal");
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

                        for (int i = svar; i <= 100; i += svar)
                        {
                            u++;

                            Console.WriteLine($"{u} * {svar} = {i}");
                        }
                        Console.ReadKey();
                        break;
                    }
                case "z":
                    {
                        string tvkant = "\x250c"; // top ventre kant
                        string thkant = "\x2510"; // top højre kant
                        string bvkant = "\x2514"; // bund venstre kant
                        string bhkant = "\x2518"; // Bund højre kant
                        string vside = "\x2502"; // Venstre side
                        string hside = "\x2502"; // Højre side
                        string top = "\x2500"; // Top
                        string bund = "\x2500"; // Bund 

                        int hoej = 10;
                        int bred = 4;

                        for (int i = 0; i < bred; i++)
                        {
                            Console.SetCursorPosition(20 + i, 4);
                            Console.Write(top);
                            Console.SetCursorPosition(20 + i, 4 + hoej);
                            Console.Write(bund);
                        }
                        for (int i = 0; i < hoej; i++)
                        {
                            Console.SetCursorPosition(20, 4 + i);
                            Console.Write(vside);
                            Console.SetCursorPosition(20 + bred, 4 + i);
                            Console.Write(hside);
                        }
                        Console.SetCursorPosition(20, 4);
                        Console.Write(tvkant);
                        Console.SetCursorPosition(20 + bred, 4);
                        Console.Write(thkant);
                        Console.SetCursorPosition(20, 4 + hoej);
                        Console.Write(bvkant);
                        Console.SetCursorPosition(20 + bred, 4 + hoej);
                        Console.Write(bhkant);

                        Console.ReadKey();
                        break;
                    }
                case "x":
                    {
                        string tvkant = "\x250c"; // top ventre kant
                        string thkant = "\x2510"; // top højre kant
                        string bvkant = "\x2514"; // bund venstre kant
                        string bhkant = "\x2518"; // Bund højre kant
                        string vside = "\x2502"; // Venstre side
                        string hside = "\x2502"; // Højre side
                        string top = "\x2500"; // Top
                        string bund = "\x2500"; // Bund 

                        int hoej = 4;
                        int bred = 10;

                        for (int i = 0; i < bred; i++)
                        {
                            Console.SetCursorPosition(20 + i, 4);
                            Console.Write(top);
                            Console.SetCursorPosition(20 + i, 4 + hoej);
                            Console.Write(bund);
                        }
                        for (int i = 0; i < hoej; i++)
                        {
                            Console.SetCursorPosition(20, 4 + i);
                            Console.Write(vside);
                            Console.SetCursorPosition(20 + bred, 4 + i);
                            Console.Write(hside);
                        }
                        Console.SetCursorPosition(20, 4);
                        Console.Write(tvkant);
                        Console.SetCursorPosition(20 + bred, 4);
                        Console.Write(thkant);
                        Console.SetCursorPosition(20, 4 + hoej);
                        Console.Write(bvkant);
                        Console.SetCursorPosition(20 + bred, 4 + hoej);
                        Console.Write(bhkant);

                        string navn = "Oliver";
                        Console.SetCursorPosition(20 + bred / 2 - 3, 4 + hoej / 2);
                        Console.WriteLine(navn);
                        Console.ReadKey();
                        break;
                    }
                case "c":
                    {
                        string tvkant = "\x250c"; // top ventre kant
                        string thkant = "\x2510"; // top højre kant
                        string bvkant = "\x2514"; // bund venstre kant
                        string bhkant = "\x2518"; // Bund højre kant
                        string vside = "\x2502"; // Venstre side
                        string hside = "\x2502"; // Højre side
                        string top = "\x2500"; // Top
                        string bund = "\x2500"; // Bund 

                        int hoej = 0;
                        int bred = 0;
                        Console.WriteLine("Indgiv højde");
                        hoej = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indgiv brede");
                        bred = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < bred; i++)
                        {
                            Console.SetCursorPosition(20 + i, 4);
                            Console.Write(top);
                            Console.SetCursorPosition(20 + i, 4 + hoej);
                            Console.Write(bund);
                        }
                        for (int i = 0; i < hoej; i++)
                        {
                            Console.SetCursorPosition(20, 4 + i);
                            Console.Write(vside);
                            Console.SetCursorPosition(20 + bred, 4 + i);
                            Console.Write(hside);
                        }
                        Console.SetCursorPosition(20, 4);
                        Console.Write(tvkant);
                        Console.SetCursorPosition(20 + bred, 4);
                        Console.Write(thkant);
                        Console.SetCursorPosition(20, 4 + hoej);
                        Console.Write(bvkant);
                        Console.SetCursorPosition(20 + bred, 4 + hoej);
                        Console.Write(bhkant);

                        string navn = "Oliver";
                        Console.SetCursorPosition(20 + bred / 2 - 3, 4 + hoej / 2);
                        Console.WriteLine(navn);
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
