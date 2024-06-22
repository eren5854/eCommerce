using AutoMapper;
using eCommerceServer.Application.Features.Products.CreateProduct;
using eCommerceServer.Application.Features.Products.UpdateProduct;
using eCommerceServer.Domain.Products;
using eCommerceServer.Domain.Shared;

namespace eCommerceServer.Application.Mapping;
public sealed class ProductMappingProfile: Profile
{
    public ProductMappingProfile()
    {
        CreateMap<CreateProductCommand, Product>().ForMember(x => x.Name, options =>
        {
            options.MapFrom(y => new Name(y.Name));
        });

        CreateMap<UpdateProductCommand, Product>().ForMember(x => x.Name, options =>
        {
            options.MapFrom(y => new Name(y.Name));
        });
    }
}
