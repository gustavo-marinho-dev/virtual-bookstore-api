using MediatR;

namespace VirtualBookstore.Application.DTOs.Book
{
    public sealed record DeleteBookRequest(Guid Id) : IRequest;
}