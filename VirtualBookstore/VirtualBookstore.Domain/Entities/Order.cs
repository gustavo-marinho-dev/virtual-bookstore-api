using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities.Commom;
using VirtualBookstore.Domain.Enums;

namespace VirtualBookstore.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public double Subtotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public ShipType ShipType { get; set; }
        public DateTime ShipDate { get; set; }
        public OrderState Status { get; set; }
        public Guid BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        public Guid ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }
        
        //TODO: ETAPA DE PAGAMENTO
        //public CCTransaction CreditCardTransaction { get; set; }
        public List<OrderItem> Item { get; set; }
    }
}
