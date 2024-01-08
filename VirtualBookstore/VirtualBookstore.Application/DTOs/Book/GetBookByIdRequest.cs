using MediatR;

namespace VirtualBookstore.Application.DTOs.Book
{
    public sealed record GetBookByIdRequest(Guid Id) : IRequest<GetBookByIdBookResponse>;
}