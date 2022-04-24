using CQRSExample.CQRS.Command;
using CQRSExample.CQRS.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductsController(IMediator _mediator)
        {
            mediator = _mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var result = await mediator.Send(new GetProductListQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("detail")]
        public async Task<IActionResult> Details(int id)
        {
            var result = await mediator.Send(new GetProductQuery { Id = id });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Edit(UpdateProductCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result= await mediator.Send(new DeleteProductCommand { Id = id });
            return Ok(result);
        }
    }
}
