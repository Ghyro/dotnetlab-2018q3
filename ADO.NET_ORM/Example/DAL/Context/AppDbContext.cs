using System.Data.Entity;
using DAL.Configuration;
using DAL.Entities;

namespace DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("InternationWidgets")
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
<<<<<<< HEAD
        public DbSet<OrderItem> OrderItems { get; set; }
=======
>>>>>>> 1c23a0cb8f3b54ae925267c6e31cf8f859cc0ca4

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //TODO: setup dbcontext configuration using EF Fluent API. DO NOT add property attributes for any files from "Entities" folder.
            modelBuilder.Configurations.Add(new ItemConfig());
            modelBuilder.Configurations.Add(new OrderConfig());
<<<<<<< HEAD
            modelBuilder.Configurations.Add(new OrderItemConfig());
=======
>>>>>>> 1c23a0cb8f3b54ae925267c6e31cf8f859cc0ca4

            base.OnModelCreating(modelBuilder);
        }
    }
}
