using eCommerceServer.Domain.Categories;
using eCommerceServer.Infrastructure.Context;
using GenericRepository;

namespace eCommerceServer.Infrastructure.Repositories;
public sealed class CategoryRepository : Repository<Category, ApplicationDbContext>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}
