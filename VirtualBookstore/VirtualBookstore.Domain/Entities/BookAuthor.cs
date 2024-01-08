using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Domain.Entities
{
    public class BookAuthor : BaseEntity
    {
        public Guid BookId { get; set; }
        public Guid AuthorId { get; set; }
    }
}
