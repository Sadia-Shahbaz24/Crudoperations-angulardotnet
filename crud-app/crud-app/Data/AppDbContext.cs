using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace crud_app.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
      public DbSet<Employee> Employees { get; set; }
    
  }
}
