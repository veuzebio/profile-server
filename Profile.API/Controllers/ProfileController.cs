using MediatR;
using Microsoft.AspNetCore.Mvc;
using Profile.Application.Resume.Commands;

namespace Profile.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet, Route("resume")]
        public IEnumerable<string> GetResume(string language = "pt-BR")
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost, Route("seed")]
        public IActionResult CreateSeed(CreateNewResumeCommand command)
        {
            _mediator.Send(command);
 
            return Ok();
        }
    }
}
