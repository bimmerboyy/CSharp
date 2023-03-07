using System;

namespace DUNP // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clan clan1 = new Clan("Tarik", "Kucevic", false, 900);
            Clan clan2 = new Clan("Nikola", "Matkovic", false, 1500);
            Clan clan3 = new Clan("Ermin", "Paljevic", true, 400);

            Console.WriteLine("Posle zaduzivanja " + clan1.Ime + " ima na racunu " + clan1.zaduzivanje());
            Console.WriteLine("Posle zaduzivanja " + clan2.Ime + " ima na racunu " + clan2.zaduzivanje());
            Console.WriteLine("Posle zaduzivanja " + clan3.Ime + " ima na racunu " + clan3.zaduzivanje());
        }
    }
}