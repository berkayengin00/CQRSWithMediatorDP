using CQRSDP.Data.Commands.Request;
using CQRSDP.Data.Commands.Response;
using CQRSDP.Data.Queries.Request;
using CQRSDP.Data.Queries.Response;
using CQRSDP.Handler.Handlers.CommandHandler;
using CQRSDP.Handler.Handlers.QueryHandler;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest query)
        {
            var result = await _mediator.Send(query);
            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateProductCommandRequest requestModel)
        {
            var result = await _mediator.Send(requestModel);
            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteProductCommandRequest requestModel)
        {
            var result = await _mediator.Send(requestModel);
            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

    }
}
