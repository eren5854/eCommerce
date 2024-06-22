namespace eCommerceServer.Domain.Identity;
public sealed class UserAddress
{
    public Guid AppUserId { get; set; } = Guid.NewGuid();
    public AppUser? AppUser { get; set; }
    public Guid AddressId { get; set; } = Guid.NewGuid();
    public Address? Address { get; set; }
}
