using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    class Program
    {
        static void Main(string[] args)
        {
            //montant Entier;
            Int32 montant;
            Console.WriteLine("Saisir le montant à décomposer");
            montant = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Billets 100 : "+ (montant/100).ToString());
            montant = montant % 100;
            Console.WriteLine("Billets 50 : "+ (montant/50).ToString());
            montant = montant % 50;
            Console.WriteLine("Billets 20 : "+ (montant/20).ToString());
            montant = montant % 20;
            Console.WriteLine("Billets 10 : "+ (montant/10).ToString());
            montant = montant % 10;
            Console.WriteLine("Pièces 1 : "+ montant.ToString());

            Console.ReadKey();

        }
    }
}
