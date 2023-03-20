partial class Program
{
    //Ova klasa  sluzzi da klonira rad sa bazom 

    public class BookRepository
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>
            {
                new Book {Name = "C# and .NET 7 ",Price = 19.99, Date = DateTime.Now},
                new Book {Name = "C++ with examples ",Price = 9.99, Date = new DateTime(2012,2,2)},
                new Book {Name = "C for students ",Price = 29.99, Date = new DateTime(2000,2,2)},
                new Book {Name = "C# and .NET",Price = 19.99, Date = new  DateTime(2021,2,2)},
                new Book {Name = "C# and .NET 7 ",Price = 19.99, Date = new DateTime(2020,2,2)},
            };

    }
        //LINQ
        public List<Book> GetAllBooks()
        {
            return books;
        }
        public List<Book> FilterBookByPriceCheaper(double price)
        {
           List<Book> cheaper = books.Where(b => b.Price < price).ToList();
            return cheaper;
        }
       
        public List<Book> FilterBooksInRange(DateTime? date1,DateTime? date2)

        {
            if(date1.HasValue && date2.HasValue)
            {
                List<Book> filtered = books.Where(b => b.Date >= date1 && b.Date <= date2).ToList();
                return filtered;
            }
            return books;
        }
        public Book GetByName(string name)
        {
            /*
            foreach(Book book in books)
            {
                if(book.Name == name)
                    return book;
                return null;
            }
            */
      
            return books.FirstOrDefault(b => b.Name == name);
            //II nacin
            //return books.SingleOrDefault(b => b.Name == name);
        }
        /*
         * Neke funkcije
         * 
         * FirtsOrDefault
         * SingleOrDefault
         
         
         * Where
         * 
         * Count() // koliko ima knjiga
         * 
         * Contains - proverava da li se element nalazi u nizu ali je spora
         * StartWith za stringove 
         * EndsWith
         * books.OrderBy(b=> b.Name).ToList(); za sortiranje
            books.OrderByDescending(b => b.Name).ToList();
         * 
         * */


    }
   
   
}

/*
 * Main ovaj
 * 
 *  Console.WriteLine("Unesite cenu do koje biste platili knjigu");
        string sBr = Console.ReadLine();
        double cena = double.Parse(sBr);
        var repo = new BookRepository();
        var cheapBooks = repo.FilterBookByPriceCheaper(cena);
        Console.WriteLine($"Jeftinije knjige od {cena}");

        foreach (var book in cheapBooks)
        {
            Console.WriteLine(book);
            Console.ReadLine();
        }




    }
 * 
 * Main prethodni
 * 
 * 
 * Console.WriteLine("Unesite jedan broj");
            string sBr = Console.ReadLine();
            double x = double.Parse(sBr);
            double kv = Kvadrat(x);
            Func<double, double> kvadrat = k => k * k;
            Func<double,double,double> proizvod = (a,b) => a * b;
            Console.WriteLine($"Kvadrat broj je  {x} je {kvadrat(x)} a proizvod je {proizvod(x,3)}");

   public static double Kvadrat(double x)
    {
        return x * x;
    }


    public class Digitron <T> where T : IComparable<T>
{
    public T Broj1 { get; set; } 
public T Broj2 { get; set; }
        
    public T Zbir() { return Broj1 + Broj2; }
    public T Razlika() { return Broj1 - Broj2; }
        

public bool Jednaki()
{
    if (Broj1.Equals(Broj2))
        return true;
    return false;
}
*/


