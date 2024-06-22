using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.Products.UpdateProduct;
public sealed record UpdateProductCommand(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    string PictureUrl,
    Guid CategoryId,
    Guid ProductBrandId) : IRequest<Result<string>>;
