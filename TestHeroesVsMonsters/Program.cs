using HeroesVsMonsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHeroesVsMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;

            Console.Write("Choix (1 = Humain, 2 = Nain) : ");
            while (!int.TryParse(Console.ReadLine(), out choix) || !(choix == 1 || choix == 2))
            {
                Console.Write("T'es con l'elfe?? (1 = Humain, 2 = Nain) : ");
            }

            Foret f = new Foret((choix == 1) ? HeroesTypes.Humain : HeroesTypes.Nain);
            f.Lance();

            Console.ReadLine();
            Console.WriteLine("Test of a pull request");
        }
    }
}
