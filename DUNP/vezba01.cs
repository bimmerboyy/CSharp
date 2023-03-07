
using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            //Prosiriti zadatak da se unese ime i prezime studenta i da se ispise poruka 
            //Hello ime i prezime
            string imeIprezime;
            System.Console.WriteLine("Unesite ime i prezime studenta");
            imeIprezime = Console.ReadLine();
            System.Console.WriteLine("Hello " + imeIprezime);
            System.Console.ReadLine(); //Sluzi da nam drzi konzolu otvorenu
        }
    }
}