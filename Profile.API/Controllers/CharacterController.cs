using MediatR;
using Microsoft.AspNetCore.Mvc;
using Profile.Application.Resume.Commands;
using Profile.Application.Resume.Queries;
using Profile.Domain.CharacterAggregate.Models;
using System.ComponentModel.DataAnnotations;

namespace Profile.API.Controllers
{
    /// <summary>
    /// Provides actions for character profile manipulation.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CharacterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Retrieves a specific character by the given id.
        /// </summary>
        /// <param name="id" example="3699564C-EC62-47B2-152B-08DB92C6FCE4">Character's id.</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <returns>Character's profile.</returns>
        [HttpGet, Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Character>> GetByIdAsync([Required] Guid id, CancellationToken cancellationToken)
        {
            var query = new GetCharacterByIdQuery() { Id = id };
            return await _mediator.Send(query, cancellationToken);
        }

        /// <summary>
        /// Creates a new character profile.
        /// </summary>
        /// <param name="command">Information needed to create a new character.</param>
        /// <returns>Created result with a Location header.</returns>
        [HttpPost, Route("create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(CreateNewCharacterCommand command)
        {
            var id = await _mediator.Send(command);
 
            return Created(nameof(GetByIdAsync), new { Id = id });
        }
    }
}
