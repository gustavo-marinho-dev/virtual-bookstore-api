using MediatR;
using Microsoft.AspNetCore.Mvc;
using VirtualBookstore.Application.DTOs.Book;
using VirtualBookstore.Application.DTOs.ViaCepApi;
using VirtualBookstore.Domain.DTOs.Adress;

namespace VirtualBookstore.Api.Controllers;

[ApiController]
[Route("api/addresses")]
public class AddressController : ControllerBase
{
    private readonly IMediator _mediator;

    public AddressController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("autocomplete/{Cep}")]
    public async Task<ActionResult<List<ViaCepResponse>>> GetAdressByCep(string Cep, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAdressByCepRequest(Cep), cancellationToken);
        return Ok(response);
    }
}

