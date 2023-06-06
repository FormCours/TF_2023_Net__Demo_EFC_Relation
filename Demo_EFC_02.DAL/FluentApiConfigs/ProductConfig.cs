using Demo_EFC_02.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFC_02.DAL.FluentApiConfigs
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(p => p.ProductId).IsClustered();
            builder.Property(p => p.ProductId).ValueGeneratedOnAdd();

            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products);

            builder.HasMany(p => p.Bundles)
                   .WithMany(b => b.Products)
                   .UsingEntity<BundleProduct>();
        }
    }
}
