using Microsoft.EntityFrameworkCore;
using ShoppingList.Core.Models;
using System.Diagnostics;

namespace ShoppingList.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        //public DbSet<Product> DataProduct { get; set; }
        public DbSet<Order> Order { get; set; }

        //seeding to categories
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(

                new Category { ID = 1, Name = "מוצרי ניקיון" },
                new Category { ID = 2, Name = "גבינות" },
                new Category { ID = 3, Name = "ירקות ופירות" },
                new Category { ID = 4, Name = "בשר ודגים" },
                new Category { ID = 5, Name = "מאפים" }
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
