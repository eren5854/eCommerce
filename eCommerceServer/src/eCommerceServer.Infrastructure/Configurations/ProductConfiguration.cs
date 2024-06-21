using eCommerceServer.Domain.Products;
using eCommerceServer.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerceServer.Infrastructure.Configurations;
public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .Property(p => p.Name)
            .HasConversion(name => name.Value, value => new Name(value))
            .IsRequired()
            .HasColumnType("varchar(50)");

        builder.HasQueryFilter(filter => !filter.IsDeleted);
    }
}