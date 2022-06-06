using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuration
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCategories");
            builder.HasOne(p => p.Product).WithMany(pd => pd.ProductInCategories)
                   .HasForeignKey(p => p.ProductId);
            builder.HasOne(c => c.Category).WithMany(ct=>ct.ProductInCategories)
                   .HasForeignKey(c => c.CategoryId);
        }
    }
}
