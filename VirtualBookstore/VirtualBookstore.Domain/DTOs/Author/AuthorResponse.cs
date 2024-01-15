using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookstore.Application.DTOs.Author
{
    public sealed record AuthorResponse
    {
        public Guid Id { get; init; }
        public string FullName { get; init; }
        public DateTime DateOfBirth { get; init; }
        public string Nationality { get; init; }
        public string Biography { get; init; }
        public ICollection<Guid> Books { get; init; }
    }
}
