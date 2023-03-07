using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DUNP.Vezbe1
{
    internal class vezba02
    {
    }
}

/*
class Console
{
    static void Main(string[] args)
    {
        Krug krug = new Krug();

        System.Console.WriteLine("Krug ima obim: " + krug.Obim());
        System.Console.WriteLine("Krug ima povrsinu: " + krug.Povrsina());
        krug.PoluPrecnikSetiGet = 15.5f; //menjamo poluprecnik ali to nije dobro pa stavljamo na private
        System.Console.WriteLine("Krug ima obim: " + krug.Obim());
        System.Console.WriteLine("Krug ima povrsinu: " + krug.Povrsina());


    }

}


public class Krug
{
    private float PoluPrecnik; //mozemo staviti atribute na public,private itd
    //kreiramo konstruktor
    public float PoluPrecnikSetiGet
    {
        get
        {
            return PoluPrecnik;
        }
        set
        {
            PoluPrecnik = value;
        }
    }
    public Krug()
    {
        PoluPrecnik = 2.5f;
    }
    //Metod 1 - za racunanje obima
    public float Obim()
    {
        float Obim;
        Obim = (float)(2 * PoluPrecnik * Math.PI);
        return 0;
    }

    // Metod 2 - za racunanje povrsina
    public float Povrsina()
    {
        return (float)(Math.Pow(PoluPrecnik, 2) * Math.PI); //Posto vraca double moramo da ga pretvorimo u float

    }
}

*/