using Microsoft.EntityFrameworkCore;

namespace ProductAndCate.Models
{
    public class ProductAndCategoryContext : DbContext
    {
        public ProductAndCategoryContext(DbContextOptions options) : base(options) { }
         // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<Product> Products { get; set; }
        // public DbSet<Widget> Widgets { get; set; }
        public DbSet<Product> Categories { get; set; }
        public DbSet<Product> Associations { get; set; }
        // public DbSet<Item> Items { get; set; }

    }
}