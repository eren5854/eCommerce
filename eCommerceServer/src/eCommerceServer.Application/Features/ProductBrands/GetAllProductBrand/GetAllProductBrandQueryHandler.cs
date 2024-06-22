using eCommerceServer.Domain.ProductBrands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace eCommerceServer.Application.Features.ProductBrands.GetAllProductBrand;
internal class GetAllProductBrandQueryHandler(IProductBrandRepository productBrandRepository) : IRequestHandler<GetAllProductBrandQuery, Result<List<ProductBrand>>>
{
    public async Task<Result<List<ProductBrand>>> Handle(GetAllProductBrandQuery request, CancellationToken cancellationToken)
    {
        var productBrand = await productBrandRepository.GetAll().ToListAsync(cancellationToken);

        return Result<List<ProductBrand>>.Succeed(productBrand);
    }
}
