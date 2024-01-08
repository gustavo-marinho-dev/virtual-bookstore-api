using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookstore.Application.DTOs.Author
{
    public sealed record CreateAuthorRequest(
        string FullName,
        DateTime DateOfBirth,
        string Nationality,
        string Biography,
        ICollection<Guid>? Books
    ) : IRequest<AuthorResponse>;
}
