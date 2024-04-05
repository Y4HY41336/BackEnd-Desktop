using Again2.Context;
using Again2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Again2.ViewComponents;

public class ProductViewComponent : ViewComponent
{
    private readonly ProniaDbContext _context;

    public ProductViewComponent(ProniaDbContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var product = await _context.Products.ToListAsync();

        return View(product);
    }


}
