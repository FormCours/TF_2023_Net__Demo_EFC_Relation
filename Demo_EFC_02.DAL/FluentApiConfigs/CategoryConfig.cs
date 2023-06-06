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
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(c => c.CategoryId).IsClustered();
            builder.Property(c => c.CategoryId).ValueGeneratedOnAdd();

            builder.HasMany(c => c.Products)
                   .WithOne(p => p.Category);
        }
    }
}
