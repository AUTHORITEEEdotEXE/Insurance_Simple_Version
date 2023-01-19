using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaPoistenia
{
    internal class Poistenec
    {
        /// <summary>
        /// Meno poistenca
        /// </summary>
        public string Meno { get; private set; }
        /// <summary>
        /// Priezvisko poistenca
        /// </summary>
        public string Priezvisko { get; private set; }
        /// <summary>
        /// Telefonne cislo poistenca
        /// </summary>
        public string TelCislo { get; private set; }
        /// <summary>
        /// Vek poistenca
        /// </summary>
        public int Vek { get; private set; }

        //konstruktor
        public Poistenec (string meno, string priezvisko, string telCislo, int vek)
        {
            Meno = meno;
            Priezvisko = priezvisko;
            TelCislo = telCislo;
            Vek = vek;
        }
        // vypis 
        public override string ToString()
        {
           
            return this.Meno + "    " + this.Priezvisko + "    " + this.Vek + "    " + this.TelCislo ;
        }
    }
}
