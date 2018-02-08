using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace fruit_api.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
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
            this.Fruits.Add(new Fruit { Name = "Mango" });
            this.Fruits.Add(new Fruit { Name = "Avacado" });
            this.Flowers.Add(new Flower { Name = "Rose" });
            this.Flowers.Add(new Flower { Name = "Frangipani" });
            // this.FruitItems.Add(new FruitItem { Name = "Item3" });
            this.SaveChanges();
        }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Flower> Flowers { get; set; }
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