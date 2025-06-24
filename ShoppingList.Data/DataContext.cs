using Microsoft.EntityFrameworkCore;
using ShoppingList.Core.Models;
using System.Diagnostics;

namespace ShoppingList.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> DataCategory { get; set; }
        public DbSet<Product> DataProduct { get; set; }
        public DbSet<OrderList> DataOrderList { get; set; }

        //seeding to categories
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(

                new Category { Id = 1, Name = "מוצרי ניקיון" },
                new Category { Id = 2, Name = "גבינות" },
                new Category { Id = 3, Name = "ירקות ופירות" },
                new Category { Id = 4, Name = "בשר ודגים" },
                new Category { Id = 5, Name = "מאפים" }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection to DB
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ShoppingListDB; Trusted_Connection=True");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        //

    }
}
