using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Author;
using VirtualBookstore.Application.Repositories;
using VirtualBookstore.Domain.Entities;
using VirtualBookstore.Infrastructure.Data.Context;
using VirtualBookstore.Infrastructure.Data.Repositories.Common;

namespace VirtualBookstore.Infrastructure.Data.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(VirtualBookstoreContext context) : base(context) { }

        Task<Author?> IAuthorRepository.CreateAuthor(CreateAuthorRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
