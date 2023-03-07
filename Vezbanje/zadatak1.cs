using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napisati C# program koji od korisnika ucitava njegovo ime u nominativu ˇ
i vokativu, i onda ga pozdravlja, recimo ovako:
*/

namespace CSharp.Vezbanje.zadatak1
{
    
    class Padezi
    {
        private string ime;
       public Padezi(string ime)
        {
            this.ime = ime;
        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set { ime = value; }
        }
       public string PrikaziNominativ()
        {
            return ime;
        }
       public string PrikaziVokativ()
        {
            if(ime.Substring(ime.Length - 1) == "k")
            {
                ime = ime.Remove(ime.Length - 1);
                ime += "če";
            }
            if(ime.Substring(ime.Length - 1) == "e")
            {
                ime = ime.Remove(ime.Length - 1);
            }
            ime += "e";
            return ime;
        }
    }
    
}

/* Main program
 * 
 *   Padezi ime1 = new Padezi("Tarik");
     Console.WriteLine("Kako se zoves -> " + ime1.PrikaziNominativ() + "\nKako tvoje ime glasi u vokativu " + ime1.PrikaziVokativ() 
                + "\nZnao sam!Ti se zoves " + ime1.PrikaziNominativ() + "\nZdravo, " + ime1.PrikaziVokativ());
 */