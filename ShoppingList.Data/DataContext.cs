using Microsoft.EntityFrameworkCore;
using ShoppingList.Core.Models;
using System.Diagnostics;

namespace ShoppingList.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
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

            optionsBuilder.UseSqlServer("Server=lea-db.cl4c242yux6i.ap-south-1.rds.amazonaws.com,1433;Database=LeaDb;User Id=admin;Password=sg325956754;TrustServerCertificate=true;Encrypt=true;");

            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        //

    }
}
