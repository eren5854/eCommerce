namespace eCommerceServer.Domain.Abstractions;
public abstract class Entity
{
    protected Entity() 
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public override bool Equals(object? obj) 
        // buradaki yapının Id bazlı kontrol edilmesi referans bazlı kontrol edilmemesi için Equals metodunu eziyoruz.
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is not Entity entity)
        {
            return false;
        }

        return Id == entity.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
