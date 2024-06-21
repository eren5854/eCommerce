using eCommerceServer.Domain.Abstractions;
using eCommerceServer.Domain.Shared;

namespace eCommerceServer.Domain.ProductBrands;
public sealed class ProductBrand: Entity
{
    public Name Name { get; set; } = new(string.Empty);
}
