namespace CetBooks.Models
{
    public class FakeDB
    {

        public static List<Book> Db { get; set; } = new List<Book>();

         static FakeDB() {
            Db.Add(
                new Book {
                    Id = 1,
                    Title = "C#",
                    Description = "Programming Languges",
                    Author="Ahmet Yıldırım",
                    PageSize = 200,
                    Price  =100,
                    PublishDate = DateTime.Now
                       
                
                }
                );
            Db.Add(
             new Book
             {
                 Id = 2,
                 Title = "Asp.net",
                 Description = "Programming Languges",
                 Author = "Ahmet Yıldırım",
                 PageSize = 300,
                 Price = 150,
                 PublishDate = DateTime.Now


             }
             );
        }

        public  List<Book> GetAllBooks()
        {
            return Db;

        }

        public Book? GetBookById(int id)
        {
            //foreach ( Book book in Db ) {
            //   if( book.Id == id ) return book;
            //}
            
           return Db.FirstOrDefault(b=>b.Id == id);
          //  return Db.Where(b=>b.Id == id).FirstOrDefault(); ;

        }

        public void AddBook(Book book)
        {
            Db.Add(book);
        }

        public bool DeleteBook(int id)
        {
            var book= GetBookById(id);

            if (book==null) return false; 
            Db.Remove(book);
            return true;
        }
    }
}
