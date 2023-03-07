using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Vezbanje.ObimKruga
{
    class Krug
    {
        private double PoluPrecnikKruga;

       

        public Krug(double PoluPrecnikKruga)
        {
            this.PoluPrecnikKruga = PoluPrecnikKruga;
        }
        public double Obim()
        {
            return (double) (2 * PoluPrecnikKruga * Math.PI);
            
        }
        public double PoluPrecnikKrugaGetSet{
            get {  return PoluPrecnikKruga;}
            set { PoluPrecnikKruga = value; }
        }
}
}
