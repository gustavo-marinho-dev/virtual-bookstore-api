using MediatR;
using Microsoft.AspNetCore.Mvc;
using VirtualBookstore.Application.DTOs.Author;

namespace VirtualBookstore.Api.Controllers
{
    [ApiController]
    [Route("author")]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet("GetById/{Id}")]
        //public async Task<ActionResult<List<BookResponse>>> GetById(Guid Id, CancellationToken cancellationToken)
        //{
        //    var response = await _mediator.Send(new GetBookByIdRequest(Id), cancellationToken);
        //    return Ok(response);
        //}

        [HttpPost]
        public async Task<ActionResult<AuthorResponse>> Create(CreateAuthorRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(DeleteAuthorRequest request, CancellationToken cancellationToken)
        {
            await _mediator.Send(request, cancellationToken);
            return NoContent();
        }
    }

}
