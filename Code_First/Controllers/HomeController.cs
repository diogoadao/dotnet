using Code_First.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_First.Controllers
{
    public class HomeController : Controller
    {
        private LibraryContext _context;

        public HomeController(LibraryContext context)
        {
            _context = context;
        }

        public string Index()
        {
            _context.Database.EnsureCreated();
            return "Its okay";
        }
    }
}