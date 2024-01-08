using AutoMapper;
using MediatR;
using VirtualBookstore.Application.DTOs.Book;
using VirtualBookstore.Application.Exceptions;
using VirtualBookstore.Application.Repositories;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Application.UseCases.BookUseCases
{
    public sealed class CreateBookUseCase : IRequestHandler<CreateBookRequest, BookResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public CreateBookUseCase(IUnitOfWork unitOfWork, 
                                 IBookRepository bookRepository, 
                                 IAuthorRepository authorRepository, 
                                 IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<BookResponse> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            var authors = await _authorRepository.GetWhere(x => request.Authors.Contains(x.Id));

            if (!authors.Any())
            {
                throw new NotFoundException($"Um ou mais autores não encontrados");
            }

            var book = _mapper.Map<Book>(request);

            book.Authors = authors;

            _bookRepository.Create(book);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<BookResponse>(book);
        }
    }
}
