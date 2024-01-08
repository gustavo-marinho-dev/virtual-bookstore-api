using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.Repositories.Common;
using VirtualBookstore.Domain.Entities.Commom;
using VirtualBookstore.Infrastructure.Data.Context;

namespace VirtualBookstore.Infrastructure.Data.Repositories.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly VirtualBookstoreContext Context;

        public BaseRepository(VirtualBookstoreContext context)
        {
            Context = context;
        }

        public void Create(T entity)
        {
            Context.Add(entity);
        }

        public void Update(T entity)
        {
            Context.Update(entity);
        }

        public void Delete(T entity)
        {
            entity.DeletedAt = DateTimeOffset.UtcNow;
            Context.Update(entity);
        }

        public Task<T?> Get(Guid id, CancellationToken cancellationToken)
        {
            return Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id && !x.DeletedAt.HasValue, cancellationToken);
        }

        public Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return Context.Set<T>().Where(x => !x.DeletedAt.HasValue).ToListAsync(cancellationToken);
        }

        public Task<List<T>> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>().Where(expression).ToListAsync();
        }

        public Task<List<T>> GetWhereOrderedBy<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> order)
        {
            return Context.Set<T>().Where(expression).OrderBy(order).ToListAsync();
        }
    }
}
