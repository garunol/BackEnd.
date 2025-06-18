using Microsoft.EntityFrameworkCore;

namespace QLSP.Models
{
    public class QLSPDbContext : DbContext
    {
        public QLSPDbContext(DbContextOptions<QLSPDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
