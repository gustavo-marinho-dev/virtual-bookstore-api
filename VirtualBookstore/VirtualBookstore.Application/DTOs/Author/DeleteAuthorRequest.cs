using MediatR;

namespace VirtualBookstore.Application.DTOs.Author
{
    public sealed record DeleteAuthorRequest(Guid Id) : IRequest;
}
