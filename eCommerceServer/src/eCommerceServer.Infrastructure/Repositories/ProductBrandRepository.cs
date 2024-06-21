using eCommerceServer.Domain.ProductBrands;
using eCommerceServer.Infrastructure.Context;
using GenericRepository;

namespace eCommerceServer.Infrastructure.Repositories;
public sealed class ProductBrandRepository : Repository<ProductBrand, ApplicationDbContext>, IProductBrandRepository
{
    public ProductBrandRepository(ApplicationDbContext context) : base(context)
    {
    }
}
