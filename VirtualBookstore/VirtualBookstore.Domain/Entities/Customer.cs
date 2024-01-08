using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime Birthdate { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Guid CardId { get; set; }
        public Cart Cart { get; set; }
    }
}
