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
            Console.WriteLine(montant / 100);
            montant = montant / 100;
            Console.Writeline(montant);
            montant = montant / 50;
            Console.Writeline(montant);
            montant = montant / 20;
            Console.Writeline(montant);
            montant = montant / 10;
            Console.Writeline(montant);
            montant = montant / 5;
            Console.Writeline(montant);
            Console.ReadKey();

        }
    }
}
