using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje.ZadaciSaVezbi
{
     class Racunar
    {
        public int broj;
        Random random = new Random();

        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }

        public void GetBroj()
        {
            Broj = random.Next(1, 100);
        }
        public override string ToString()
        {
            return $"Racunar je generisao broj {broj}";
        }
    }
}
