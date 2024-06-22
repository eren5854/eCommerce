using eCommerceServer.Domain.Products;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace eCommerceServer.Application.Features.Products.GetAllProduct;
internal sealed class GertAllProductQueryHandler(
    IProductRepository productRepository) : IRequestHandler<GetAllProductQuery, Result<List<Product>>>
{
    public async Task<Result<List<Product>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        var product = await productRepository.GetAll().ToListAsync(cancellationToken);

        return Result<List<Product>>.Succeed(product);
    }
}
