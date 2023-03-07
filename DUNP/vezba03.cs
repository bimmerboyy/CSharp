//Kreirati novi projekat (Konzolna aplikacija u .NET framework-u)
//Kreirati klasu Kvadrat koji ima privatno polje stranica
//Svojstvo starnica sa set i get metodom
//Obim - metoda koja vraca obim kvadrata 
//Povrsina - metoda koja vraca obim povrsinu kvadrata 

//U glavnoj funkciji kreirati 2 kvadrata i ispisati koji ima vecu povrsinu 

using System;

namespace Kvadrat{
    class ConsoleApp
{
    static void Main(string[] args)
    {
        Kvadrat k1 = new Kvadrat();
        Kvadrat k2 = new Kvadrat();
        k2.StranicaGetSet = 5f;
        if(k1.Povrsina() > k2.Povrsina()){
            System.Console.WriteLine("Prvi ima vecu povrsinu");
        }
        else{
            System.Console.WriteLine("Drugi ima vecu povrsinu");
        }

        System.Console.ReadLine();
    }
}

class Kvadrat
{
    public Kvadrat(){
        stranica = 9f;
    }
    private float stranica;

    public float StranicaGetSet{
            get { return stranica; }
            set { stranica = value; }
    }
    public float Obim(){
        float Obim;
        Obim = 4 * stranica;
        return Obim;
    }
    public float Povrsina(){
        float Povrsina;
        Povrsina = stranica * stranica;
        return Povrsina;
    }

}

}
