﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DUNP.Vezbe2.Aviokompanija
{
    class RedovniLetovi : Let
    {
        private int brMesta;
        public int BrMesta
        {
            get { return brMesta; }
            set { brMesta = value; }
        }
        public RedovniLetovi(int brMesta,
            string polaznaDestinacija,
            string dolaznaDestinacija,
            DateTime datumVremePoletanja,
            int brRezervisanihMesta) :
            base(polaznaDestinacija, dolaznaDestinacija, datumVremePoletanja, brRezervisanihMesta)
        {
            this.brMesta = brMesta;
        }
        public override bool Rezervacija()
        {
            if (BrRezervisanihMesta == BrMesta)
                return false;
            BrRezervisanihMesta++;
            return true;
        }
        public override string ToString()
        {
            return $"Na letu koji ide od {PolaznaDestinacija} do {DolaznaDestinacija}"
                + $"datuma {DatumVremePoletanja.ToString("dd.MM.yyyy HH:mm:ss")}, ima slobodnih mesta {brMesta - BrRezervisanihMesta}";
        }
    }
}

//Implementirati CarterLet koji ima BrojMestaURedovimaLetu i BrojMestaDopunskomLetu