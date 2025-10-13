using Application.Commands.Items.CreateItems;
using Application.Commands.Items.DeleteItems;
using Application.Commands.Items.UpdateItems;
using Application.Queries.Items.GetItemById;
using Application.Queries.Items.GetItems;
using Contracts.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ReactBackEndApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreItemsController : ControllerBase
    {
        private readonly ILogger<StoreItemsController> _logger;
        private readonly IMediator _mediator;
        public StoreItemsController(
            ILogger<StoreItemsController> logger, 
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("Items")]
        public async Task<ActionResult> GetItems()
        {
            var token = new CancellationToken();
            var result = await _mediator.Send(new GetItemsQuery(), token);

            return Ok(result);
           
        }

        [HttpGet("Items/{id}")]
        public async Task<ActionResult> GetItemById([FromRoute] Guid id)
        {

            var token = new CancellationToken();
            var validator = new GetItemByIdValidator();
            var validatorResult = validator.Validate(id);

            if (!validatorResult.IsValid)
            {
                return BadRequest(new
                {
                    Message = "Failed Validation",
                    Errors = validatorResult.Errors
                });
            }

            var result = await _mediator.Send(new GetItemByIdQuery(id), token);

            return Ok(result);
        }

        [HttpPost("Items")]
        public async Task<ActionResult> CreateItem([FromBody] GetItemRequest item)
        {

            var token = new CancellationToken();
            var valdator = new CreateItemValidator();
            var validatorResult = valdator.Validate(item);

            if (!validatorResult.IsValid)
            {
                return BadRequest(new
                {
                    Message = "Failed Validation",
                    Errors = validatorResult.Errors
                });
            }

            var result = await _mediator
                .Send(new CreateItemCommand(item.Title, item.Description, item.Price), token);

            return Ok(new { Token = token, Result = result });
        }

        [HttpPut("Items/{id}")]
        public async Task<ActionResult> UpdateItem([FromRoute] Guid id, [FromBody] GetItemRequest item)
        {

            var token = new CancellationToken();

            var valdator = new UpdateItemValidator();
            var validatorResult = valdator.Validate(item);

            if (!validatorResult.IsValid)
            {
                return BadRequest(new
                {
                    Message = "Failed Validation",
                    Errors = validatorResult.Errors
                });
            }

            var result = await _mediator
            .Send(new UpdateItemCommand(id, item.Title, item.Description, item.Price, true), token);

            return Ok(result);
        }

        [HttpDelete("Items/{id}")]
        public async Task<ActionResult> DeleteItem([FromRoute] Guid id)
        {

            var token = new CancellationToken();
            var validator = new DeleteItemValidator();
            var validatorResult = validator.Validate(id);
            if (!validatorResult.IsValid)
            {
                return BadRequest(new
                {
                    Message = "Failed Validation",
                    Errors = validatorResult.Errors
                });
            }
            var result = await _mediator.Send(new DeleteItemCommand(id), token);

            return Ok(result);
        }

    }
}
