using CQRSExample.CQRS.Command;
using CQRSExample.Data;
using CQRSExample.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.CommandHandler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IProductRepository productRepository;
        public CreateProductCommandHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository;  
        }
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Id = request.Id,
                Name = request.Name,
                Photo = request.Photo,
                Stock = request.Stock,
                Price = request.Price
            };
            return await productRepository.CreateProduct(product);
        }
    }
}
