using Again2.Context;
using Again2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Again2.Areas.Admin.Controllers;
[Area("Admin")]
public class ShippingController : Controller
{
    private readonly ProniaDbContext _context;

    public ShippingController(ProniaDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var shippings = _context.Shippings.ToList();
        return View(shippings);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Shipping shipping)
    {
        _context.Shippings.Add(shipping);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Delete(int id)
    {

        var shippings = _context.Shippings.FirstOrDefault(x => x.Id == id);
        if (shippings != null)
        {
            return NotFound();
        }
        return View(shippings);
    }
}
