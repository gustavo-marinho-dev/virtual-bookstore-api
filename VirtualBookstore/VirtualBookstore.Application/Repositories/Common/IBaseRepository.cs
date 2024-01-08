using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities.Commom;

namespace VirtualBookstore.Application.Repositories.Common
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T?> Get(Guid id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
        Task<List<T>> GetWhere(Expression<Func<T, bool>> expression);
        Task<List<T>> GetWhereOrderedBy<TKey>(Expression<Func<T, bool>> expression, Expression<Func<T, TKey>> order);
    }
}
