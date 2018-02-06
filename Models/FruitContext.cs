using Microsoft.EntityFrameworkCore;

namespace fruit_api.Models
{
    public class FruitContext : DbContext
    {
        public FruitContext(DbContextOptions<FruitContext> options)
            : base(options)
        {
        }

        public DbSet<FruitItem> FruitItems { get; set; }

    }
}