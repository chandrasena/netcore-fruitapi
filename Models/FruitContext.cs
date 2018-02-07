using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace fruit_api.Models
{
    public class FruitContext : DbContext
    {
        public FruitContext(DbContextOptions<FruitContext> options)
            : base(options)
        {

            if (this.FruitItems.Count() == 0)
            {
                this.FruitItems.Add(new FruitItem { Name = "Item1" });
                this.SaveChanges();
            }
        }

        public DbSet<FruitItem> FruitItems { get; set; }
 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}