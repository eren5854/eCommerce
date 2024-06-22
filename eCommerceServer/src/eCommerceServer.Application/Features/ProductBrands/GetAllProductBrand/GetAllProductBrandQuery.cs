using eCommerceServer.Domain.ProductBrands;
using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.ProductBrands.GetAllProductBrand;
public sealed record GetAllProductBrandQuery() : IRequest<Result<List<ProductBrand>>>;
