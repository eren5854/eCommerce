using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.Products.DeleteProductById;
public sealed record DeleteProductByIdCommand(Guid Id) : IRequest<Result<string>>;
