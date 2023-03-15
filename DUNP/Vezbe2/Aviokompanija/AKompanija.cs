using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DUNP.Vezbe2.Aviokompanija
{
    class AvioKompanija
    {
        private Let[] letovi;
        private int maxLetova;
        private int brLetova;
        public Let[] Letovi
        {
            get { return letovi; }
            set { letovi = value; }
        }
        public int BrLetova
        {
            get { return brLetova; }
            set { brLetova = value; }
        }
        public AvioKompanija(int maxLetova)
        {
            this.maxLetova = maxLetova;
            letovi = new Let[maxLetova];
            brLetova = 0;
        }
        public void DodajLet(Let l)
        {
            if (brLetova == maxLetova)
                return;
            if (l is CarterLetovi)
            {
                var temp = l as CarterLetovi;
                letovi[brLetova++] = new CarterLetovi(temp.BrMestaRedovni,
                    temp.BrMestaVanredni, temp.PolaznaDestinacija, temp.DolaznaDestinacija,
                    temp.DatumVremePoletanja, temp.BrRezervisanihMesta);
            }
            else
            {
                var temp = l as RedovniLetovi;
                letovi[brLetova++] = new RedovniLetovi(temp.BrMesta,
                    temp.PolaznaDestinacija, temp.DolaznaDestinacija,
                    temp.DatumVremePoletanja, temp.BrRezervisanihMesta);
            }
        }
        public void Brisi(string polaznaDestinacija, DateTime vremePoletanja)
        {
            int i, brZaBrisanje = 0;
            for (i = 0; i < brLetova; i++)
            {
                if (letovi[i].PolaznaDestinacija == polaznaDestinacija &&
                    letovi[i].DatumVremePoletanja == vremePoletanja)
                {
                    brZaBrisanje++;
                }
            }
            for (int j = 0; j < brZaBrisanje; j++)
            {
                for (i = 0; i < brLetova; i++)
                {
                    if (letovi[i].PolaznaDestinacija == polaznaDestinacija &&
                    letovi[i].DatumVremePoletanja == vremePoletanja)
                    {
                        Let pom = letovi[i];
                        letovi[i] = letovi[i + 1];
                        letovi[i + 1] = pom;
                    }
                }
            }
        }
        public void RezervisiKartu(string polaznaDestinacija,
            string dolaznaDestinacija, DateTime vremePoletanja)
        {
            for (int i = 0; i < brLetova; i++)
            {
                if (letovi[i].PolaznaDestinacija == polaznaDestinacija &&
                    letovi[i].DolaznaDestinacija == dolaznaDestinacija &&
                    letovi[i].DatumVremePoletanja == vremePoletanja)
                {
                    if (letovi[i].Rezervacija() == true)
                        return;
                }
            }
        }
        public void PoredjajPoVremenu()
        {
            for (int i = 0; i < brLetova - 1; i++)
                for (int j = i + 1; j < brLetova; j++)
                    if (letovi[i].DatumVremePoletanja > letovi[j].DatumVremePoletanja)
                    {
                        var pom = letovi[i];
                        letovi[i] = letovi[j];
                        letovi[j] = pom;
                    }
        }
        public override string ToString()
        {
            string tekst = "";
            for (int i = 0; i < brLetova; i++)
                tekst += letovi[i].ToString() + Environment.NewLine;
            return tekst;
        }
    }
}

/*
 * Main funkcija
          AvioKompanija a = new AvioKompanija(100);
          CarterLetovi l1 = new CarterLetovi(100, 80, "BG", "ZG",
              new DateTime(2022, 3, 15), 50);
          RedovniLetovi l2 = new RedovniLetovi(100, "NI", "BG",
              new DateTime(2022, 3, 18), 60);
          CarterLetovi l3 = new CarterLetovi(100, 80, "BG", "LJ",
                          new DateTime(2022, 4, 15), 50);
          a.DodajLet(l1);
          a.DodajLet(l2);
          a.DodajLet(l3);
          a.PoredjajPoVremenu();
          a.RezervisiKartu("NI", "BG", new DateTime(2022, 3, 18));
          Console.WriteLine(a.ToString());
          Console.ReadLine();
          */
