using BingoLibrary.Data;
using BingoLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BingoLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult ExploreBooks()
        {
            IEnumerable<BookDetail> objbookDetails = _db.BooksDetail;
            return View(objbookDetails);
            
        }
    }
}
