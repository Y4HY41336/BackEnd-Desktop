using Again2.Context;
using Again2.ViewModel;
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
            var sliders = _context.Sliders.ToList();
            HomeViewModel homeView = new()
            {
                Shippings = shippings,
                Sliders = sliders
            };
            return View(homeView);
        }
    }
}
