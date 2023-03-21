using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje.ZadaciSaVezbi
{
    class Igra
    {
       private Igrac igrac;
        private Racunar racunar;
       

        public Igra()
        {
            igrac = new Igrac();
            racunar = new Racunar();
        }

        public void DaLiJePogodio()
        {
            int brojPogodaka = 0;
            int brojPokusaja = 0;
            while (true)
            {
             
                igrac.GetBroj();
                racunar.GetBroj();ž
                igrac.ToString();
                racunar.ToString();
                if(igrac.Broj == -1)
                {
                    Console.WriteLine("Kraj igre");
                    break;
                }
                if(igrac.Broj == racunar.Broj)
                {
                    brojPogodaka++;
                }
               brojPokusaja++;
            }
            var prosek = (float) brojPogodaka / brojPokusaja * 100;
            Console.WriteLine($"Igrac {igrac.Ime} je imao {brojPogodaka} pogodaka i {brojPokusaja} pokusaja a prosek mu je {prosek}");
        }
        

    }
}
