using BingoLibrary.Data;
using BingoLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BingoLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger ,ApplicationDbContext db)
        {
            _db = db;
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactUs(ContactUsData obj)
        {
            if (ModelState.IsValid)
            {
                _db.ContactUsData.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogInData obj)
        {
            var m = from LogInData in _db.Logindata select LogInData.LoggerEmail;
            if (m.Contains(obj.LoggerEmail))
            {
                return Ok("Found");
            }
            return NotFound();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}