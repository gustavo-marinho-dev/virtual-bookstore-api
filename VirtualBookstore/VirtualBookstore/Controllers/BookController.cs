using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VirtualBookstore.Application.DTOs.Book;

namespace VirtualBookstore.Api.Controllers;

[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    private readonly IMediator _mediator;

    public BookController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<List<BookResponse>>> GetById(Guid Id,CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetBookByIdRequest(Id), cancellationToken);
        return Ok(response);
    }

    [HttpGet("{Id}/authors")]
    public async Task<ActionResult<List<BookResponse>>> GetBookAuthors(Guid Id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetBookAuthorsByIdRequest(Id), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<BookResponse>> Create(CreateBookRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = response.Id}, response);
    }

    [HttpPut]
    public async Task<ActionResult<BookResponse>> Update(UpdateBookRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id = response.Id }, response);
    }

    [HttpDelete]
    public async Task<ActionResult> Delete(DeleteBookRequest request, CancellationToken cancellationToken)
    {
        await _mediator.Send(request, cancellationToken);
        return NoContent();
    }
}
