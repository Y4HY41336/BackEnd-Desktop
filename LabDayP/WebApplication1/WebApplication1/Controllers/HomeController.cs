using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly JuanDbContext _context;
        public HomeController(JuanDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Sliders = await _context.Sliders.ToListAsync();
            return View(Sliders);
        }
    }
}
