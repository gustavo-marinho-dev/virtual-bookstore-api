using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.Repositories;
using VirtualBookstore.Domain.Entities;
using VirtualBookstore.Infrastructure.Data.Context;
using VirtualBookstore.Infrastructure.Data.Repositories.Common;

namespace VirtualBookstore.Infrastructure.Data.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(VirtualBookstoreContext context) : base(context) { }

        public Task<Book?> GetById(Guid id, CancellationToken cancellationToken)
        {
            return Context.Book.Include(x => x.Authors)
                .FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
        }
        
        public Task<Book?> GetByIdAsNoTracking(Guid id, CancellationToken cancellationToken)
        {
            return Context.Book.AsNoTracking()
                .Include(x => x.Authors)
                .FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
        }
    }
}
