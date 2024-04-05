using Microsoft.AspNetCore.Mvc;

namespace Again.Areas.Admin.Controllers;
[Area("Admin")]
public class Dashboard : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
