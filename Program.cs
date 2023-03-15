using CSharp.DUNP.Vezbe2.Projekat.Biznis;
using System;
using System.Buffers;

namespace CSharp
{

    public class Digitron <T> where T : IComparable<T>
{
    public T Broj1 { get; set; } 
public T Broj2 { get; set; }
        /*
    public T Zbir() { return Broj1 + Broj2; }
    public T Razlika() { return Broj1 - Broj2; }
        */

        public bool Jednaki() { if (Broj1.Equals(Broj2))
                return true;
        return false;
        }


}

}

partial class Program
    {
        static void Main(string[] args)
           
        {
            Console.WriteLine("Unesite jedan broj");
            string sBr = Console.ReadLine();
            double x = double.Parse(sBr);
            double kv = Kvadrat(x);
            Func<double, double> kvadrat = k => k * k;
            Func<double,double,double> proizvod = (a,b) => a * b;
            Console.WriteLine($"Kvadrat broj je  {x} je {kvadrat(x)} a proizvod je {proizvod(x,3)}");

          

        }
    public static double Kvadrat(double x)
    {
        return x * x;
    }
  
