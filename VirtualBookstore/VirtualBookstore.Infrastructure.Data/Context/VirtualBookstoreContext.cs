using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Infrastructure.Data.Context
{
    public class VirtualBookstoreContext : DbContext
    {
        public VirtualBookstoreContext(DbContextOptions<VirtualBookstoreContext> options) : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author {get; set;}
        public DbSet<BookAuthor> BookAuthor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
