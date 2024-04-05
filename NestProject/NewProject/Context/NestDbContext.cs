using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewProject.Models;

namespace NewProject.Context;

public class NestDbContext : IdentityDbContext<AppUser>
{
    public NestDbContext(DbContextOptions<NestDbContext> options) : base(options)
    {
    }
}
