using AutoMapper;
using eCommerceServer.Application.Features.Categories.CreateCategory;
using eCommerceServer.Application.Features.Categories.UpdateCategory;
using eCommerceServer.Application.Features.ProductBrands.CreateProductBrand;
using eCommerceServer.Application.Features.ProductBrands.UpdateProductBrand;
using eCommerceServer.Domain.Categories;
using eCommerceServer.Domain.ProductBrands;
using eCommerceServer.Domain.Shared;

namespace eCommerceServer.Application.Mapping;
public sealed class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<CreateCategoryCommand, Category>().ForMember(x => x.Name, options =>
        {
            options.MapFrom(y => new Name(y.Name));
        });

        CreateMap<UpdateCategoryCommand, Category>().ForMember(x => x.Name, options =>
        {
            options.MapFrom(y => new Name(y.Name));
        });

        CreateMap<CreateProductBrandCommand, ProductBrand>().ForMember(x => x.Name, options =>
        {
            options.MapFrom(y => new Name(y.Name));
        });

        CreateMap<UpdateProductBrandCommand, ProductBrand>().ForMember(x => x.Name, options =>
        {
            options.MapFrom(y => new Name(y.Name));
        });
    }
}
