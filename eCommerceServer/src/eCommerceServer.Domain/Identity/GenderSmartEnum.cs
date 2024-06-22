using Ardalis.SmartEnum;

namespace eCommerceServer.Domain.Identity;
public sealed class GenderSmartEnum : SmartEnum<GenderSmartEnum>
{
    public static readonly GenderSmartEnum Male = new GenderSmartEnum("Erkek", 1);
    public static readonly GenderSmartEnum Female = new GenderSmartEnum("Kadın", 2);
    public static readonly GenderSmartEnum Unspecified = new GenderSmartEnum("Belirtilmemiş", 3);

    public GenderSmartEnum(string name, int value) : base(name, value)
    {
    }
}
