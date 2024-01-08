using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Domain.Entities
{
    public class Stock : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Guid AdressId { get; set; }
        public Address Address { get; set; }
        public List<StockItem> Items { get; set; }
        public string Email { get; set; }
        public bool IsAvailable { get; set; }
    }
}
