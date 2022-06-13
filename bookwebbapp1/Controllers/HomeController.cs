using Microsoft.AspNetCore.Mvc;
using bookwebbapp1.Models;

namespace bookwebbapp1.Controllers
{

    public class HomeController : Controller
    {
        BookContext bookContext = new BookContext();
        public IActionResult Index()
        {
            List<Book> books = bookContext.Booklist.ToList();
            return View(books);
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book booksl)
        {
           bookContext.Booklist.Add(booksl);
           bookContext.SaveChanges();
            return View();
        }
    }
}
