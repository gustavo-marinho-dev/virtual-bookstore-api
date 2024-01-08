using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.Repositories;
using VirtualBookstore.Domain.Entities.Commom;
using VirtualBookstore.Infrastructure.Data.Context;

namespace VirtualBookstore.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VirtualBookstoreContext _context;

        public UnitOfWork(VirtualBookstoreContext context)
        {
            _context = context;
        }
        public Task Save(CancellationToken cancellationToken)
        {
            SetDateTime();

            return _context.SaveChangesAsync(cancellationToken);
        }

        private void SetDateTime()
        {
            var addedEntities = _context.ChangeTracker.Entries()
                .Where(entry => entry.State == EntityState.Added)
                .Select(entry => entry.Entity as BaseEntity);

            var modifiedEntities = _context.ChangeTracker.Entries()
                .Where(entry => entry.State == EntityState.Modified)
                .Select(entry => entry.Entity as BaseEntity);

            foreach (var entity in addedEntities)
            {
                entity.CreatedAt = DateTimeOffset.UtcNow;
                entity.UpdatedAt = DateTimeOffset.UtcNow;
            }

            foreach (var entity in modifiedEntities)
            {
                entity.UpdatedAt = DateTimeOffset.UtcNow;
            }
        }
    }
}
