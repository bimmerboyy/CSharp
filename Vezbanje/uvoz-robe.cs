using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Prilikom uvoza robe u Republiku Srbiju se na osnovnu cenu proizvoda
prvo zaracuna carina od 10%, pa se na tako dobijeni iznos zara ˇ cuna PDV ˇ
od 20%. Napisati C# program koji od korisnika ucitava cenu (u evrima) ˇ
nekog proizvoda koji se uvozi u Srbiju, i utvrduje za koliko je njegova ¯
cena u Srbiji uvecana ovom procedurom. 
*/

namespace CSharp.Vezbanje.UvozRobe
{
    class UvozRobe {
        private double cena;
       public UvozRobe(double cena)
        {
            this.cena = cena;
        }
        public double NakonProcedure()
        {
            double carina = cena / 10;
            cena += carina;
            double pdv = cena * 20 / 100;
            cena += pdv;
            return (double) cena;
        }
    }
}

/* Main funckija
 * 
 * 
 * UvozRobe roba1 = new UvozRobe(350);
   Console.WriteLine("Nakon procedure pdv-a i carine roba ce iznositi " + roba1.NakonProcedure() + " evra.");

*/
