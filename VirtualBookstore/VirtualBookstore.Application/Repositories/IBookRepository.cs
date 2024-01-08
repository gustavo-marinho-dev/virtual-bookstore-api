using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.Repositories.Common;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Application.Repositories
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        Task<Book?> GetById(Guid Id, CancellationToken cancellationToken);

        /// <summary>
        /// Obtém um livro pelo ID sem rastreamento, incluindo informações sobre os autores.
        /// </summary>
        /// <param name="id">O ID do livro.</param>
        /// <param name="cancellationToken">O token de cancelamento para cancelar a operação assíncrona.</param>
        /// <returns>O livro correspondente ao ID, ou null se não encontrado.</returns>
        Task<Book?> GetByIdAsNoTracking(Guid id, CancellationToken cancellationToken);
    }
}
