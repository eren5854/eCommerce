using eCommerceServer.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerceServer.Infrastructure.Configurations;
public sealed class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder
            .Property(p => p.AddressType)
            .HasConversion(p => p.Value, v => AddressTypeSmartEnum.FromValue(v));

        builder.HasQueryFilter(filter => !filter.IsDeleted);
    }
}