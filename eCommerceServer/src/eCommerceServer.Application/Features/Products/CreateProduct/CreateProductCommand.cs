using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.Products.CreateProduct;
public sealed record CreateProductCommand(
    string Name,
    string? Description,
    decimal Price,
    string? PictureUrl,
    Guid CategoryId,
    Guid ProductBrandId): IRequest<Result<string>>;
