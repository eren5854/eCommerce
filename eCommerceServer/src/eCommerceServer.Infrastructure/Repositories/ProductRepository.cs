using eCommerceServer.Domain.Products;
using eCommerceServer.Infrastructure.Context;
using GenericRepository;

namespace eCommerceServer.Infrastructure.Repositories;
public sealed class ProductRepository : Repository<Product, ApplicationDbContext>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}
