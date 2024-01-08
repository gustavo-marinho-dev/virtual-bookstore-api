using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Biography { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
