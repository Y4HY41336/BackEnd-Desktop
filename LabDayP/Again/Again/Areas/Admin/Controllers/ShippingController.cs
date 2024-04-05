using Again.Context;
using Again.Models;
using Microsoft.AspNetCore.Mvc;

namespace Again.Areas.Admin.Controllers;
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
        var shipping = _context.Shippings.FirstOrDefault(s => s.Id == id);
        if (shipping == null)
        {
            return NotFound();
        }
        return View(shipping);
    }
    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteSlider(int id)
    {
        var shipping = _context.Shippings.FirstOrDefault(s=> s.Id == id);
        if (shipping == null)
        {
            return NotFound();
        }
        _context.Shippings.Remove(shipping);
        return RedirectToAction("Index");

    }
}
