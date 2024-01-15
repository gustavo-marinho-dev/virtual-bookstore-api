

using VirtualBookstore.Domain.Enums;

namespace VirtualBookstore.Application.DTOs.Book
{
    public class GetBookByIdBookResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationYear { get; set; }
        public string Publisher { get; set; }
        public Subject Subject { get; set; }
        public List<string> Categories { get; set; }
        public string Synopsis { get; set; }
        public decimal Rating { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
        public string Backing { get; set; }
        public string Dimensions { get; set; }
        public List<string> AuthorList { get; set; }
    }
}
