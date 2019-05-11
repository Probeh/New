using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Server.Resources.Models;

namespace Server.Resources.Context
{
    public class ApplicationDBContext : DbContext
    {
        // Properties
        public DbSet<Company> Companies { get; set; }
        public DbSet<Software> Software { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}