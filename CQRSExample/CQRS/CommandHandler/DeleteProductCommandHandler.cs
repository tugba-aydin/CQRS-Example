using CQRSExample.CQRS.Command;
using CQRSExample.Data;
using CQRSExample.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.CommandHandler
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, int>
    {
        private readonly IProductRepository productRepository;
        public DeleteProductCommandHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository; 
        }

        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await productRepository.DeleteProduct(request.Id);
        }
    }
}
