using CQRSExample.Entities;
using MediatR;

namespace CQRSExample.CQRS.Query
{
    public class GetProductQuery:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
