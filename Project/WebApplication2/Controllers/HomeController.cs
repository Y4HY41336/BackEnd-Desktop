using Microsoft.AspNetCore.Mvc;
using WebApplication2.Contexts;
namespace WebApplication2.Controllers
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
            var Sliders = _context.Sliders.ToList();
            return View(Sliders);
        }
    }
}
