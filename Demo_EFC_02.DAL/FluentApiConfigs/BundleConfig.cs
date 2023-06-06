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
    internal class BundleConfig : IEntityTypeConfiguration<Bundle>
    {
        public void Configure(EntityTypeBuilder<Bundle> builder)
        {
            builder.ToTable("Bundle");

            builder.HasKey(b => b.BundleId).IsClustered();
            builder.Property(b => b.BundleId).ValueGeneratedOnAdd();

            builder.HasMany(b => b.Products)
                   .WithMany(p => p.Bundles)
                   .UsingEntity<BundleProduct>();
        }
    }
}
