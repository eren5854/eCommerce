using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.ProductBrands.DeleteProductBrandById;
public sealed record DeleteProductBrandByIdCommand(Guid Id): IRequest<Result<string>>;
