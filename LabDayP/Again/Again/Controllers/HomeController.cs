using Again.Context;
using Microsoft.AspNetCore.Mvc;

namespace Again.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaDbContext _context;

        public HomeController(ProniaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var shippings = _context.Shippings.ToList();
            return View(shippings);
        }
    }
}
