namespace CSharp.DUNP.Vezbe2.Projekat.Model
{
    public class Racunar
    {
        //preklopiti metodu ToString da ispisuje koji je broj trenutno generisan

        #region ATRIBUTI
        private int broj;
        private Random r = new Random();
        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }
        #endregion
        #region METODE
        public void GetBroj()
        {
            Broj = r.Next(1, 10); //Generisanje nasumicne vrednosti izmedju 1 i 10
        }
        public override string ToString()
        {
            return $"Racunar je generisao broj: {broj}";
        }
        #endregion
    }

}
