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
    internal class BundleProductConfig : IEntityTypeConfiguration<BundleProduct>
    {
        public void Configure(EntityTypeBuilder<BundleProduct> builder)
        {
            builder.ToTable("MM_Bundle_Product");

            builder.HasKey(bp => new {
                BundleId= bp.BundleId,
                ProductId= bp.ProductId
            }).IsClustered();

        }
    }
}
