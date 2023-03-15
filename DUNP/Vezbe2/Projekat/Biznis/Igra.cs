using CSharp.DUNP.Vezbe2.Projekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DUNP.Vezbe2.Projekat.Biznis
{
    public class Igra
    {
        private Racunar r;
        private Igrac i;
       
        public Igra()
        {
            r = new Racunar();
            i = new Igrac();
        }
        public void PokreniIgru()
        {
            int BrojPokodaka = 0;
            int BrojPokusaja = 0;
            while (true)
            {
                r.GetBroj();
                i.GetBroj();
                if(i.Broj == -1)
                {
                    break;
                }
                Console.WriteLine(i.ToString());
                Console.WriteLine(r.ToString());
                if (r.Broj == i.Broj)
                {
                    BrojPokodaka++;
                }
                BrojPokodaka++;

                
            }
            var prosek = (float)BrojPokodaka / BrojPokusaja * 100;
            Console.WriteLine($"Igrac je pogodio {BrojPokodaka} od {BrojPokusaja} i uspesnost je {prosek}%");
        }
    }
}


/*Main funcija 
 * 
 * 
 *   Igra igra = new Igra();
            igra.PokreniIgru();
            Console.ReadLine();

*/
