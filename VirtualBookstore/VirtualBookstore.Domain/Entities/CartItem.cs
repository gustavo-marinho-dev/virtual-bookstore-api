using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        private int _quantity;
        public Guid StockItemId { get; set; }
        public StockItem StockItem { get; set; }
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value > StockItem.Quantity)
                {
                    throw new InvalidOperationException("A quantidade no carrinho maior do que a disponível em estoque.");
                }

                _quantity = value;
            }
        }
    }
}
