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
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Application.UseCases.BookUseCases
{
    public sealed class UpdateBookUseCase : IRequestHandler<UpdateBookRequest, BookResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public UpdateBookUseCase(IUnitOfWork unitOfWork,
                                 IBookRepository bookRepository,
                                 IAuthorRepository authorRepository,
                                 IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<BookResponse> Handle(UpdateBookRequest request, CancellationToken cancellationToken)
        {
            var originalBook = await _bookRepository.GetById(request.Id, cancellationToken);

            if (originalBook == null)
            {
                throw new NotFoundException($"Não foi encontrado o livro requisitado.");
            }

            var authors = await _authorRepository.GetWhere(x => request.Authors.Contains(x.Id));

            if (!authors.Any())
            {
                throw new NotFoundException($"Um ou mais autores não encontrados");
            }

            var updatedBook = _mapper.Map<Book>(request);

            updatedBook.Authors = authors;

            _mapper.Map(updatedBook, originalBook);
            _bookRepository.Update(originalBook);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<BookResponse>(updatedBook);
        }
    }
}
