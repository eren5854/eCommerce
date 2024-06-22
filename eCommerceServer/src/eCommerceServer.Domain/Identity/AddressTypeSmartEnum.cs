using Ardalis.SmartEnum;

namespace eCommerceServer.Domain.Identity;
public sealed class AddressTypeSmartEnum : SmartEnum<AddressTypeSmartEnum>
{
    public static readonly AddressTypeSmartEnum Home = new AddressTypeSmartEnum("Ev", 1);
    public static readonly AddressTypeSmartEnum WorkPlace = new AddressTypeSmartEnum("İş Yeri", 2);
    public AddressTypeSmartEnum(string name, int value) : base(name, value)
    {
    }

}
