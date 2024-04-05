using Again.Models;
using Microsoft.EntityFrameworkCore;

namespace Again.Context;

public class ProniaDbContext : DbContext
{
	public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
	{
	}

	public DbSet<Shipping> Shippings { get; set; }
}
