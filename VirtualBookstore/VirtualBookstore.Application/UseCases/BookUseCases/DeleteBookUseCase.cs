using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Book;
using VirtualBookstore.Application.Exceptions;
using VirtualBookstore.Application.Repositories;

namespace VirtualBookstore.Application.UseCases.BookUseCases
{
    public sealed class DeleteBookUseCase : IRequestHandler<DeleteBookRequest>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBookUseCase(IBookRepository bookRepository, IUnitOfWork unitOfWork)
        {
            _bookRepository = bookRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteBookRequest request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.Get(request.Id, cancellationToken);

            if(book != null)
            {
                _bookRepository.Delete(book);
                await _unitOfWork.Save(cancellationToken);
            }

            else
                throw new NotFoundException($"Não foi encontrado o livro requisitado.");
        }
    }
}
