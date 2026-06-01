using Microsoft.AspNetCore.Mvc;
using Bai6_Validation.Models;

namespace Bai6_Validation.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> books = new List<Book>();

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = books.Count + 1;

                books.Add(book);

                return RedirectToAction("Index");
            }

            return View(book);
        }
    }
}