using CQRSExample.Entities;
using MediatR;

namespace CQRSExample.CQRS.Command
{
    public class UpdateProductCommand:IRequest<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }
}
