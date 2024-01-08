using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public int BuildingNumber { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
