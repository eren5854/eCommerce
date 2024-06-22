using Microsoft.AspNetCore.Identity;

namespace eCommerceServer.Domain.Identity;
public sealed class AppUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => string.Join(" ", FirstName, LastName);
    public string IdentityNumber {  get; set; } = string.Empty;
    public string? ProfilePicture {  get; set; }
    public DateTime DateOfBirth { get; set; }
    public GenderSmartEnum Gender { get; set; } = GenderSmartEnum.Unspecified;
    //public CreditCard
    public UserRoleSmartEnum UserRole { get; set; } = UserRoleSmartEnum.User;
    public bool IsDeleted { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
