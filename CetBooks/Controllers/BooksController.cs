using CetBooks.Models;
using Microsoft.AspNetCore.Mvc;

namespace CetBooks.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            FakeDB fakeDB = new FakeDB();
            var allbooks = fakeDB.GetAllBooks();

            return View(allbooks);
        }

        public IActionResult Detail(int? id)
        {
            if (!id.HasValue) return BadRequest();

            FakeDB db = new FakeDB();
            var book = db.GetBookById(id.Value);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);

        }
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();

            FakeDB db = new FakeDB();
            var result = db.DeleteBook(id.Value);
            if (result)
            {

                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Create(Book book)
        {
            if(book.Title  != null) {
                FakeDB db = new FakeDB();
                var length = db.GetAllBooks().Count();
                var newBook = new Book
                {
                    Id = length + 1,
                    Title = book.Title,
                    Description = book.Description,
                    Author = book.Author,
                    PageSize = book.PageSize,
                    Price = book.Price,
                    PublishDate = book.PublishDate
                };
                db.AddBook(newBook);
            }
            return View();
        }

    }
}
