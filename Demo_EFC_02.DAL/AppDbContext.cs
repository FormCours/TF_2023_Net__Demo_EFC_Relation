using Demo_EFC_02.DAL.Entities;
using Demo_EFC_02.DAL.FluentApiConfigs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFC_02.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Bundle> Bundles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=Forma300\TFTIC;Initial Catalog=Demo_EFC_02;Trusted_Connection=True"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BundleConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new BundleProductConfig());
        }
    }
}
