using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje.ZadaciSaVezbi
{
     class Igrac
    {
        private string ime;
        public int broj;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public int Broj
        {
            get { return broj; }
            set
            {
                if (broj >= 0 || broj <= 10 || broj == -1)
                {
                    broj = value;
                }
                else
                {
                    Console.WriteLine("Uneli ste neispravan broj");
                }
            }
        }
        public void GetBroj()
        {
            Console.WriteLine("Unesite broj:");
            string unetBroj = Console.ReadLine();
            Broj = int.Parse(unetBroj);
        }
        public override string ToString()
        {
            return $"{ime} je uneo broj {broj}";
        }
    }
}
