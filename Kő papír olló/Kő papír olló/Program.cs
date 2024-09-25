using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kő_papír_olló
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[] lehetosegek = new string[] { "Kő", "Papír", "Olló" };
            string gepvalasztas = lehetosegek[rnd.Next(lehetosegek.Length)];

            Console.WriteLine("Választásod [kő/papír/olló]: ");
            string jatekosvalasztas = Console.ReadLine();

            if (gepvalasztas == jatekosvalasztas) {
                Console.WriteLine("Döntetlen");
            }
            else if (gepvalasztas == "Kő" && jatekosvalasztas == "Papír" ||
                gepvalasztas == "Papír" && jatekosvalasztas == "Olló" ||
                gepvalasztas == "Olló" && jatekosvalasztas == "Kő"
                ) {
                Console.WriteLine("Nyertél!");
            }
            else if (jatekosvalasztas == "Kő" && gepvalasztas == "Papír" ||
                jatekosvalasztas == "Papír" && gepvalasztas == "Olló" ||
                jatekosvalasztas == "Olló" && gepvalasztas == "Kő"
                )
            {
                Console.WriteLine("Nyertél!");
            } else
            {
                Console.WriteLine("Értékelhetetlen válasz!");
            }
            Console.WriteLine("- VÉGE -");
            Console.ReadKey();
        }
    }
}
