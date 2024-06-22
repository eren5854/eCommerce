using Ardalis.SmartEnum;

namespace eCommerceServer.Domain.Identity;
public sealed class UserRoleSmartEnum : SmartEnum<UserRoleSmartEnum>
{
    public static readonly UserRoleSmartEnum Admin = new UserRoleSmartEnum("Admin", 1);
    public static readonly UserRoleSmartEnum Seller = new UserRoleSmartEnum("Seller", 2);
    public static readonly UserRoleSmartEnum User = new UserRoleSmartEnum("User", 3);
    public UserRoleSmartEnum(string name, int value) : base(name, value)
    {
    }
}
