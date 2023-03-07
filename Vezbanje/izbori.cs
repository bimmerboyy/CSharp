using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Kada se nakon parlamentarnih izbora utvrdi ko su novi poslanici, saziva
se konstitutivna sednica na kojoj se verifikuju mandati novih poslanika i odabere
predsednik parlamenta, njegovi zamenici i ostali organi parlamenta koji su predvideni ustavom. Poštuju ¯ ci stare plemenske obi ´ caje, do izbora predsednika parlamenta ˇ
i njegovih zamenika sednicom rukovodi najstariji poslanik, a pomažu mu dvoje do
troje najmladih. Napisati C# program koji od korisnika u ¯ citava ceo broj ˇ n > 5, potom podatke o n poslanika koji cine saziv novog parlamenta i odre ˇ duje najstarijeg ¯
i dvoje najmladih poslanika
*/
namespace CSharp.Vezbanje.Izbori
{
    class Poslanik
    {
        private string ime;
        private string prezime;
        private int godina;
        private int mesec;
        private int dan;
      
        public Poslanik(string ime,string prezime,int godina,int mesec,int dan) {
            this.ime = ime;
            this.prezime = prezime;
            this.godina = godina;
            this.mesec = mesec;
            this.dan = dan;
        }
       
        
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public int Godina
        {
            get { return godina; }
            set { godina = value; }
        }
        public int Mesec
        {
            get { return mesec; }
            set { mesec = value; }
        }
        public int Dan
        {
            get { return dan; }
            set { dan = value; }
        }
    }
}
