using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.ProductBrands.CreateProductBrand;
public sealed record CreateProductBrandCommand(string Name): IRequest<Result<string>>;
