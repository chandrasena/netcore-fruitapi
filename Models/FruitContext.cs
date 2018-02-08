using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace fruit_api.Models
{
    public class FruitContext : DbContext
    {
        public FruitContext(DbContextOptions<FruitContext> options)
            : base(options)
        {
            Seed();
            // if (this.FruitItems.Count() == 0)
            // {
            //     this.FruitItems.Add(new FruitItem { Name = "Item1" });
            //     this.SaveChanges();
            // }
        }
        private void Seed() {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            // this.FruitItems.Add(new FruitItem { Name = "Item1" });
            // this.FruitItems.Add(new FruitItem { Name = "Item2" });
            // this.FruitItems.Add(new FruitItem { Name = "Item3" });
            this.SaveChanges();
        }
        public DbSet<FruitItem> FruitItems { get; set; }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=fruits.db");
        // }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}