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
        public IActionResult GetById(Guid id)
        {
            var query = new GetCharacterByIdQuery() { Id = id };

            var character = _mediator.Send(query);

            return Ok(character);
        }

        [HttpPost, Route("create")]
        public IActionResult Create(CreateNewCharacterCommand command)
        {
            var id = _mediator.Send(command);
 
            return Created(nameof(GetById), new { Id = id });
        }
    }
}
