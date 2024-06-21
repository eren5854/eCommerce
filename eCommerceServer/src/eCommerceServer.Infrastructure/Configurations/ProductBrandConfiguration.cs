using eCommerceServer.Domain.ProductBrands;
using eCommerceServer.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerceServer.Infrastructure.Configurations;
public sealed class ProductBrandConfiguration : IEntityTypeConfiguration<ProductBrand>
{
    public void Configure(EntityTypeBuilder<ProductBrand> builder)
    {
        builder
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new Name(value))
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.HasQueryFilter(filter => !filter.IsDeleted);
    }
}