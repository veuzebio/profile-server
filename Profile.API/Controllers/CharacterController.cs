using MediatR;
using Microsoft.AspNetCore.Mvc;
using Profile.Application.Resume.Commands;
using Profile.Application.Resume.Queries;

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
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetCharacterByIdQuery() { Id = id };

            var character = await _mediator.Send(query, cancellationToken);

            return Ok(character);
        }

        [HttpPost, Route("create")]
        public async Task<IActionResult> Create(CreateNewCharacterCommand command)
        {
            var id = await _mediator.Send(command);
 
            return Created(nameof(GetByIdAsync), new { Id = id });
        }
    }
}
