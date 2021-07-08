using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjectionDemoAPI.Data
{
    public class MiniDbContext : DbContext
    {
        // This is the class that will communicate with the DB.
        // 1. Create Product Table.

        public MiniDbContext(DbContextOptions<MiniDbContext>options) : base(options)
        {
            // Entity Framework can work with Oracle, MSSQL or any other RDBMS!
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.Price).IsRequired();


        }

    }
}
