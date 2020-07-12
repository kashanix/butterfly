using Application.Features.Calculator.Commands.CalculateOperation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Api.SeedWork;

namespace Web.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CalculateOperationController : BaseApiController
    {
        public CalculateOperationController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("Calculate")]
        public async Task<IActionResult> Calculate([FromBody] CalculateOperationCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
