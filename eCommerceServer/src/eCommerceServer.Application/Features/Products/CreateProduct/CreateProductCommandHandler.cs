using AutoMapper;
using eCommerceServer.Domain.Products;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eCommerceServer.Application.Features.Products.CreateProduct;
internal class CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //var isProductExists = await productRepository.AnyAsync(x => x.)

        Product product = mapper.Map<Product>(request);
        product.CreatedBy = "Admin";
        product.CreatedDate = DateTime.Now;

        await productRepository.AddAsync(product, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<string>.Succeed("Product created is successful");
    }
}
