using Microsoft.AspNetCore.Identity;

namespace NewProject.Models;

public class AppUser : IdentityUser
{
    public string Fullname { get; set; }

}
