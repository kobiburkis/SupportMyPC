
using Microsoft.EntityFrameworkCore;

namespace SupportMyPC.Models
{
    public class ApplicationDbContext : DbContext {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
      public DbSet<SupportCall> supportCalls{ get; set; }
    }
}
