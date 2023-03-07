using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Atleticar se sprema za takmi ˇ cenje tako što tr ˇ ci oko fudbalskog terena di- ˇ
menzija d×s. Prve sedmice trci svaki dan po 10 krugova oko terena. Druge ˇ
sedmice trci svaki dan po 20 krugova oko terena. Tre ˇ ce sedmice tr ´ ci svaki ˇ
dan po 30 krugova oko terena.
 */

namespace CSharp.Vezbanje.Atleticar
{
   class Atleticar
    {
        private string ime;
        private double d;
        private double s;
        public Atleticar(string ime,double d,double s) {
            this.ime = ime;
            this.d = d;
            this.s = s;
        }
        public double PretrcaniMetriPrvaSedmica()
        {
            double PrvaSedmica = 10;
            PrvaSedmica = (double) PrvaSedmica * (2 * s + 2 * d);
            return (double) PrvaSedmica;
        }
        public double PretrcaniMetriDrugaSedmica()
        {
            double DrugaSedmica = 20;
            DrugaSedmica = (double) DrugaSedmica * (2 * s + 2 * d);
            return (double) DrugaSedmica;
        }
        public double PretrcaniMetriTrecaSedmica()
        {
            double TrecaSedmica = 30;
            TrecaSedmica = (double) TrecaSedmica * (2 * s + 2 * d);
            return (double) TrecaSedmica;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public double D
        {
            get { return d; }
            set { d = value; }
        }
        public double S
        {
            get { return s; }
            set { s = value; }

        }

    }
}

/* Main funkcija 
 *   Atleticar atleticar1 = new Atleticar("Asko Kolasinac", 5.7, 3.4);
     Console.WriteLine(atleticar1.Ime + " je u prvoj sedmici pretrcao " + atleticar1.PretrcaniMetriPrvaSedmica() + "m"
                + "\nU drugoj sedmici je pretrcao " + atleticar1.PretrcaniMetriDrugaSedmica() + "m" 
                + "\nU trecoj sedmici je pretrcao " + atleticar1.PretrcaniMetriTrecaSedmica() + "m");
 * 
 * */
