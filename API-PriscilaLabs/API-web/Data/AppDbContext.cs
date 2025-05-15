using System;
using API_web.Models;
using Microsoft.EntityFrameworkCore;

namespace API_web.Context
{
    public class  AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>();

            modelBuilder
                .Entity<Order>()
                .Property(u => u.StateOrder)
                .HasConversion<string>();

            modelBuilder
                .Entity<Order>()
                .Property(u => u.PaymentMethod)
                .HasConversion<string>();

            modelBuilder
                .Entity<Product>()
                .Property(u => u.StateProduct)
                .HasConversion<string>();

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

        

    }
}
