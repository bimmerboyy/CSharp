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

/*
 * 
            Poslanik poslanik1 = new Poslanik("Dragoljub", "Ackovic", 1987, 4, 14);
            Poslanik poslanik2 = new Poslanik("Stefan", "Adzic", 1995, 7, 29);
            Poslanik poslanik3 = new Poslanik("Natan", "Albahari", 1997, 3, 6);
            Poslanik poslanik4 = new Poslanik("Miroslav", "Aleksic", 1993, 10, 16);
            Poslanik poslanik5 = new Poslanik("Ivan", "Antic", 1991, 1, 1);

            Poslanik[] NizPoslanika = new Poslanik[5];
            NizPoslanika[0] = poslanik1;
            NizPoslanika[1] = poslanik2;
            NizPoslanika[2] = poslanik3;
            NizPoslanika[3] = poslanik4;
            NizPoslanika[4] = poslanik5;


            int temp;
            for(int i = 0;i < NizPoslanika.Length - 1;i++)
            {
                for(int j = 0;j < NizPoslanika.Length - i - 1; j++)
                {
                    if (NizPoslanika[j].Godina > NizPoslanika[j + 1].Godina)
                    {
                        temp = NizPoslanika[j].Godina;
                        NizPoslanika[j].Godina = NizPoslanika[j + 1].Godina;
                        NizPoslanika[j + 1].Godina = temp;
                    }
                    if (NizPoslanika[j].Godina == NizPoslanika[j + 1].Godina)
                    {
                        if (NizPoslanika[j].Mesec > NizPoslanika[j + 1].Mesec)
                        {
                            temp = NizPoslanika[j].Godina;
                            NizPoslanika[j].Godina = NizPoslanika[j + 1].Godina;
                            NizPoslanika[j + 1].Godina = temp;
                        }
                    }
                    if (NizPoslanika[j].Mesec == NizPoslanika[j].Mesec)
                    {
                        if (NizPoslanika[j].Dan > NizPoslanika[j + 1].Dan)
                        {
                            temp = NizPoslanika[j].Godina;
                            NizPoslanika[j].Godina = NizPoslanika[j + 1].Godina;
                            NizPoslanika[j + 1].Godina = temp;
                        }
                    }
                   

                }
            }
       //Zameniti samo godine


Console.WriteLine("Najstariji poslanik je: " + NizPoslanika[0].Ime + " " + NizPoslanika[0].Prezime +
    "\nNajmladja dva poslanika su \n1." + NizPoslanika[NizPoslanika.Length - 1].Ime + " " + NizPoslanika[NizPoslanika.Length - 1].Prezime
    + "\n2." + NizPoslanika[NizPoslanika.Length - 2].Ime + " " + NizPoslanika[NizPoslanika.Length - 2].Prezime);

*/
