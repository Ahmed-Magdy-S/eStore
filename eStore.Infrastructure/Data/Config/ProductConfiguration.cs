using eStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eStore.Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p=>p.Id).IsRequired();
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p=>p.Price).HasColumnType("decimal");
            builder.Property(p=>p.ImageUrl).IsRequired();
            builder.HasOne(p => p.ProductBrand).WithMany().HasForeignKey(k=>k.ProductBrandId);
            builder.HasOne(p => p.ProductType).WithMany().HasForeignKey(k=>k.ProductTypeId);
        }
    }
}
