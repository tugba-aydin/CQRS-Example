using CQRSExample.Entities;
using MediatR;
using System.Collections.Generic;

namespace CQRSExample.CQRS.Query
{
    public class GetProductListQuery:IRequest<List<Product>>
    {
    }
}
