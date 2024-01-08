using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookstore.Application.DTOs.Book
{
    public sealed record GetBookAuthorsByIdResponse
    {
        public Guid BookId { get; init; }
        public string Title { get; set; }
        public List<AuthorList> AuthorList { get; set; }
    }

    public sealed record AuthorList
    {
        public Guid AuthorId { get; init; }
        public string FullName { get; init; }
        public DateTime DateOfBirth { get; init; }
        public string Nationality { get; init; }
        public string Biography { get; init; }
    }
}
