using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DUNP.Vezbe2.Aviokompanija
{
    class CarterLetovi : Let
    {
        private int brMestaRedovniLet;
        public int BrMestaRedovni
        {
            get { return brMestaRedovniLet; }
            set { brMestaRedovniLet = value; }
        }
        private int brMestaVanredniLet;
        public int BrMestaVanredni
        {
            get { return brMestaVanredniLet; }
            set { brMestaVanredniLet = value; }
        }
        public CarterLetovi(int brMestaRedovniLet,
            int brMestaVanredniLet,
            string polaznaDestinacija,
            string dolaznaDestinacija,
            DateTime datumVremePoletanja,
            int brRezervisanihMesta) :
            base(polaznaDestinacija, dolaznaDestinacija, datumVremePoletanja, brRezervisanihMesta)
        {
            this.brMestaRedovniLet = brMestaRedovniLet;
            this.brMestaVanredniLet = brMestaVanredniLet;
        }
        public override bool Rezervacija()
        {
            if (BrRezervisanihMesta == brMestaVanredniLet + brMestaRedovniLet)
                return false;
            BrRezervisanihMesta++;
            return true;
        }
        public override string ToString()
        {
            return $"Na letu koji ide od {PolaznaDestinacija} do {DolaznaDestinacija}"
                + $"datuma {DatumVremePoletanja.ToString("dd.MM.yyyy HH:mm:ss")},"
                + $" ima slobodnih mesta {brMestaRedovniLet + brMestaVanredniLet - BrRezervisanihMesta}";
        }
    }

}
