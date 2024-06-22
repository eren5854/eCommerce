using eCommerceServer.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerceServer.Infrastructure.Configurations;
public sealed class UserAddressConfiguration : IEntityTypeConfiguration<UserAddress>
{
    public void Configure(EntityTypeBuilder<UserAddress> builder)
    {
        builder.ToTable("UserAddresses").HasKey(x => new { x.AppUserId, x.AddressId });
    }
}
