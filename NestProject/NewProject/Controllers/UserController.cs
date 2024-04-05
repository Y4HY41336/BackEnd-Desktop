using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewProject.Models;
using NewProject.ViewModel;

namespace NewProject.Controllers;

public class UserController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public UserController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Register(AppUserViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        AppUser appUser = new AppUser()
        {
            Fullname = model.FullName,
            Email = model.Email,
            UserName = model.UserName,

        };

        IdentityResult identityResult = await _userManager.CreateAsync(appUser, model.Pasword);
        if (!identityResult.Succeeded)
        {
            foreach (var error in identityResult.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View();
        }

        return RedirectToAction("Index", "Home");
    }
}
