using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaPoistenia
{
    internal class Zoznam
    {
        /// <summary>
        /// Vytvorenie noveho poistenca
        /// </summary>
        /// <returns>new Poistenec</returns>
        public Poistenec VytvorPoistenca()
        {
            Console.WriteLine("Zadajte meno:");
            string meno = Console.ReadLine();
            Console.WriteLine("Zadejte prijmeni:");
            string priezvisko = Console.ReadLine();
            Console.WriteLine("Zadejte telefonni cislo:");
            string telCislo = Console.ReadLine();
            Console.WriteLine("Zadejte vek:");
            int vek;
            while(!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Nezadali jste číslo");
            }
            Poistenec poistenec = new Poistenec(meno, priezvisko, telCislo, vek);

            return poistenec;
        }

        /// <summary>
        /// Vyhladavanie poistenca v liste
        /// </summary>
        /// <param name="poistenci"></param>
        public void NajdiPoistenca(List<Poistenec> poistenci)
        {
            Console.WriteLine("Zadejte jméno hledaného pojištence:");
            string hladaneMeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení hledaného pojištence:");
            string hladanePriezvisko = Console.ReadLine();
            Console.WriteLine();


            // vyhladavanie pomocou LINQ otazky
            var vyhladanie = from p in poistenci
                             where hladaneMeno == p.Meno && hladanePriezvisko == p.Priezvisko
                             select p;
                // podmienka ak sa nenajdu ziadni
                if(vyhladanie.Count() == 0)
                {
                    Console.WriteLine("Nenašli se žádní pojištenci.");
                }
                else
                {
                    Console.WriteLine("Vyhledaní pojištenci:");
                    foreach (Poistenec poistenec in vyhladanie)
                    {
                        Console.WriteLine(poistenec);
                    }
                }
        }

        /// <summary>
        /// Zobrazenie listu poistencov
        /// </summary>
        /// <param name="poistenci"></param>

        public void VypisPoistencov(List<Poistenec> poistenci)
            
        {
            Console.WriteLine("Seznam pojištenců");
            for (int i = 0; i < poistenci.Count(); i++)
            {
                Console.WriteLine(poistenci[i]);
            }
        }
    }
}
