using eCommerceServer.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerceServer.Infrastructure.Configurations;
public sealed class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.Property(p => p.Gender).HasConversion(p => p.Value, v => GenderSmartEnum.FromValue(v));
        builder.Property(p => p.UserRole).HasConversion(p => p.Value, v => UserRoleSmartEnum.FromValue(v));

        //builder.HasQueryFilter(filter => !filter)
    }
}
