using MediatR;

namespace CQRSExample.CQRS.Command
{
    public class DeleteProductCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
