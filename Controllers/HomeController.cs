using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreWebApplication.Models;

namespace CoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        BookService _bookService;
        public HomeController(BookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
           // Book b = new Book();
           // b.Author = "Manoj";
           // b.BookName = "Manoj BookName";
           // b.Category = "Manoj Category";
           // b.Price = 2324; 
           // _bookService.Create(b);
            var allBookList = _bookService.Get();
            return View(allBookList);          
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
