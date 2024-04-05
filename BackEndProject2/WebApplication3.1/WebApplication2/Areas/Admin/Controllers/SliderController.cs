using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Contexts;
using WebApplication2.ViewModels;

namespace WebApplication2.Areas.Admin.Controllers;
[Area("Admin")]
public class SliderController : Controller
{

    private readonly ProniaDbContext _context;
    public SliderController(ProniaDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var Sliders = await _context.Sliders.ToListAsync();
        var Shippings = await _context.Shippings.ToListAsync();

        HomeViewModel viewModel = new HomeViewModel()
        {
            Sliders = Sliders,
            Shippings = Shippings
        };
        return View(viewModel);
    }
}

