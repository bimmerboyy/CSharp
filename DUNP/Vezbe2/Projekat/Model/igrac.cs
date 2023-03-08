using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DUNP.Vezbe2.Projekat.Model
{
    public class Igrac
    {
        //preklopiti metodu ToString da ispisuje ime igraca i koji je broj trenutno uneo

        #region ATRIBUTI
        private string ime;
        private int broj;

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
                if (value > 0 && broj <= 10 || value == -1)
                {
                    broj = value;
                }
                else
                {
                    Console.WriteLine("Uneli ste broj koji nije u intervalu od 1 do 10");
                }
            }
        }
        #endregion
        #region KONSTRUKTOR
        public Igrac()
        {
            ime = "Tarik";
            
        }
        #endregion
        #region METODE
        public void GetBroj()
        {
            Console.WriteLine("Unesite broj izmedju 1 i 10");
            string StrBroj = Console.ReadLine();
            Broj = int.Parse(StrBroj); // I nacin za kovertovanje iz stringa u int
                                       // Broj = Convert.ToInt32(Broj); II nacin 
            //III nacin
           // if (int.TryParse(StrBroj, out int broj)) {
              
           // }
        }
        public override string ToString()
        {
            return $"Igrac {ime} je generisao broj {broj}";
        }
        #endregion

    }

}
