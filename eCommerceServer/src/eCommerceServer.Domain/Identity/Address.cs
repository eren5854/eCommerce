using eCommerceServer.Domain.Abstractions;

namespace eCommerceServer.Domain.Identity;
public sealed class Address : Entity
{
    public string AddressName { get; set; } = string.Empty;
    public string DeliveryRecipientName { get; set; } = string.Empty;
    public string DeliveryRecipientLastName { get; set; } = string.Empty;
    public string DeliveryRecipientPhone { get; set; } = string.Empty;
    public AddressTypeSmartEnum AddressType { get; set; } = AddressTypeSmartEnum.Home;
    public string City { get; set; } = string.Empty;
    public string Town { get; set; } = string.Empty;
    public string Neighborhood { get; set; } = string.Empty;
    public int ZipCode { get; set; } = 0;
    public string AddressDescription { get; set; } = string.Empty;
}
