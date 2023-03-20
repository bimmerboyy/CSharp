using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DUNP.Vezbe3
{
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }


        public override string ToString()
        {
            return Name + " " + Price;
            /* nacini za skracib+vanje
            return Name.Short(2) + " " + Price;
            return Spliter.Short(Name,2) + " " + Price;
            */
        }
    }
}
