using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Author;
using VirtualBookstore.Application.Repositories.Common;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Application.Repositories
{
    public interface IAuthorRepository : IBaseRepository<Author>
    {
        Task<Author?> CreateAuthor(CreateAuthorRequest request, CancellationToken cancellationToken);
    }
}
