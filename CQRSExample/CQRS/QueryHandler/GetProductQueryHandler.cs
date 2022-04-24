using CQRSExample.CQRS.Query;
using CQRSExample.Data;
using CQRSExample.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.QueryHandler
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
    {
        private readonly IProductRepository productRepository;
        public GetProductQueryHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository; 
        }
        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetProductById(request.Id);
        }
    }
}
