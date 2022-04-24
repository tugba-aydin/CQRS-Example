using CQRSExample.CQRS.Command;
using CQRSExample.Data;
using CQRSExample.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.CommandHandler
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Product>
    {
        private readonly IProductRepository productRepository;
        public UpdateProductCommandHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetProductById(request.Id);
            product.Name = request.Name;
            product.Stock = request.Stock;
            product.Price = request.Price;
            product.Photo = request.Photo;

            return await productRepository.UpdateProduct(product);  
        }
    }
}
