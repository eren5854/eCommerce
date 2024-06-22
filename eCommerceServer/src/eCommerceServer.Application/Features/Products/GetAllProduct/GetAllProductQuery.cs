using eCommerceServer.Domain.Products;
using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.Products.GetAllProduct;
public sealed record GetAllProductQuery() : IRequest<Result<List<Product>>>;
