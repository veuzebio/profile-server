using MediatR;
using Microsoft.AspNetCore.Mvc;
using Profile.Application.Resume.Commands;
using Profile.Application.Resume.Queries;
using Profile.Domain.CharacterAggregate.Models;
using Swashbuckle.AspNetCore.Examples;
using System.ComponentModel.DataAnnotations;

namespace Profile.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CharacterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet, Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Character>> GetByIdAsync([Required] Guid id, CancellationToken cancellationToken)
        {
            var query = new GetCharacterByIdQuery() { Id = id };
            return await _mediator.Send(query, cancellationToken);
        }

        [HttpPost, Route("create")]
        [SwaggerRequestExample]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(CreateNewCharacterCommand command)
        {
            var id = await _mediator.Send(command);
 
            return Created(nameof(GetByIdAsync), new { Id = id });
        }
    }
}
