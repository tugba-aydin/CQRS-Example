using CQRSExample.CQRS.Query;
using CQRSExample.Data;
using CQRSExample.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSExample.CQRS.QueryHandler
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<Product>>
    {
        private readonly IProductRepository productRepository;
        public GetProductListQueryHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public async Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetProductsList();
        }
    }
}
