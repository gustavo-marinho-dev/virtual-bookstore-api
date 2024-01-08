using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public List<CartItem> Items { get; set; }
        public double ShippingCost { get; set; }
        public double TaxAmount { get; set; }
        public double Subtotal => Items.Sum(item => item.StockItem.Book.Price * item.Quantity);
        public double TotalPrice => Subtotal + ShippingCost + TaxAmount;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
