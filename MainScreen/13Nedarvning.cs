using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainScreen
{
    class Class9
    {
       public void Opgave13()
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
                    Chair f = new Chair();
                    f.Setcost(150.45);
                    f.Setmanufactorer("IKEA");
                    f.Setben(4);
                    f.PrintInfo();

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
