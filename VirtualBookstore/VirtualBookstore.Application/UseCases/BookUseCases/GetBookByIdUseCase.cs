using AutoMapper;
using MediatR;
using VirtualBookstore.Application.DTOs.Book;
using VirtualBookstore.Application.Exceptions;
using VirtualBookstore.Application.Repositories;

namespace VirtualBookstore.Application.UseCases.BookUseCases
{
    public sealed class GetBookByIdUseCase : IRequestHandler<GetBookByIdRequest, GetBookByIdBookResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBookByIdUseCase(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<GetBookByIdBookResponse> Handle(GetBookByIdRequest request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetByIdAsNoTracking(request.Id, cancellationToken);

            if (book == null)
            {
                throw new NotFoundException("Nenhum resutado para o ID enviado.");
            }

            return _mapper.Map<GetBookByIdBookResponse>(book);
        }
    }
}
