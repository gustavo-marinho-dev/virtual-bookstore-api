using VirtualBookstore.Domain.Entities.Commom;
using VirtualBookstore.Domain.Enums;

namespace VirtualBookstore.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public DateTime PublicationYear { get; set; }
        public string Publisher { get; set; }
        public Subject Subject { get; set; }
        public string Categorie { get; set; }
        public string Thumbnail { get; set; }
        public string Synopsis { get; set; }
        public double Rating { get; set; }
        public double Price { get; set; }
        public string Language { get; set; }
        public string ISBN { get; set; }
        public int Pages { get; set; }
        public Backing Backing { get; set; }
        public string Dimensions { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}