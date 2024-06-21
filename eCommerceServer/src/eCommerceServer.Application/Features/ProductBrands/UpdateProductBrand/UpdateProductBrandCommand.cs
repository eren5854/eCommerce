using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.ProductBrands.UpdateProductBrand;
public sealed record UpdateProductBrandCommand(
    Guid Id, 
    string Name): IRequest<Result<string>>;
