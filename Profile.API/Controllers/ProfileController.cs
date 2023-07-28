using MediatR;
using Microsoft.AspNetCore.Mvc;
using Profile.Application.Resume.Commands;
using Profile.Application.Resume.Queries;

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
        public IActionResult GetResume(string language = "pt-BR")
        {
            var query = new GetResumeByLanguageQuery() { Language = language };

            var resume = _mediator.Send(query);

            return Ok(resume);
        }

        [HttpPost, Route("seed")]
        public IActionResult CreateSeed(CreateNewResumeCommand command)
        {
            _mediator.Send(command);
 
            return Ok();
        }
    }
}
