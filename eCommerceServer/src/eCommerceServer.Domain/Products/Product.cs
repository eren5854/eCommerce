using eCommerceServer.Domain.Abstractions;
using eCommerceServer.Domain.Categories;
using eCommerceServer.Domain.ProductBrands;
using eCommerceServer.Domain.Shared;

namespace eCommerceServer.Domain.Products;
public sealed class Product : Entity
{
    public Name Name { get; set; } = new(string.Empty);
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? PictureUrl { get; set; }
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
    public Guid ProductBrandId { get; set; }
    public ProductBrand? ProductBrand { get; set; }

}
