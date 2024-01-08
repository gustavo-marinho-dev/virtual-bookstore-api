using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public Guid StockItemId { get; set; }
        public StockItem StockItem { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public string Comments { get; set; }
    }
}
