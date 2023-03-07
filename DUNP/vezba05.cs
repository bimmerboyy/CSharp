﻿/* U biblioteci postoje clanovi za koje se cuvaju podaci o imenu,prezimenu,da li je pocasni,iznos kredita.
 Svaki put kada clan hoce da zaduzi neku knjigu,ako nije pocasni,umanjuje mu se iznos kredita za 500 
Kreirati u glavnoj main funkciji 3 clana od kojih je 1 pocasni.Prvi clan neka ima 900 kredita,drugi 1500,trci 400 (pocasni).
Pokusati da zaduzite 3 knjige za svkaog clana.

 */

using System;

namespace DUNP
{
   

    class Clan
    {
        private string ime;
        private string prezime;
        private bool DaLiJePocasni;
        private float IznosKredita;
        public Clan(string ime, string prezime, bool DaLiJePocasni, float IznosKredita)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.DaLiJePocasni = DaLiJePocasni;
            this.IznosKredita = IznosKredita;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public bool DaLiJePocasniGetSet
        {
            get { return DaLiJePocasni; }
            set { DaLiJePocasni = value; }
        }
        public float IznosKreditaGetSet
        {
            get { return IznosKredita; }
            set { IznosKredita = value; }
        }
        public float zaduzivanje()
        {
            if(DaLiJePocasni == false)
            {
                IznosKredita -= 500;
            }
            return IznosKredita;
        }
    }
  


}
