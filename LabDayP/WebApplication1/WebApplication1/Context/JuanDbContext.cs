using Microsoft.EntityFrameworkCore;
using WebApplication1.DataBase.Models;

namespace WebApplication1.Context;

public class JuanDbContext : DbContext
{
    public JuanDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Slider>? Sliders { get; set; }

}

