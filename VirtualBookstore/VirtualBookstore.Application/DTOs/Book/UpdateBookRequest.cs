using MediatR;
using VirtualBookstore.Domain.Enums;

namespace VirtualBookstore.Application.DTOs.Book
{
    public sealed record UpdateBookRequest : IRequest<BookResponse>
    {
        public Guid Id { get; init; }
        public string Title { get; init; }
        public DateTime PublicationYear { get; init; }
        public string Publisher { get; init; }
        public Subject Subject { get; init; }
        public string Categorie { get; init; }
        public string Thumbnail { get; init; }
        public string Synopsis { get; init; }
        public double Rating { get; init; }
        public double Price { get; init; }
        public string Language { get; init; }
        public string ISBN { get; init; }
        public int Pages { get; init; }
        public Backing Backing { get; init; }
        public string Dimensions { get; init; }
        public ICollection<Guid> Authors { get; init; }
    }
}
