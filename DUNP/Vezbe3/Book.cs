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

        }
        

    }
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}
  
