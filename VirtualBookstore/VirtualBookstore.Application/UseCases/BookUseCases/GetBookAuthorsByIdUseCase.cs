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
    public sealed class GetBookAuthorsByIdUseCase : IRequestHandler<GetBookAuthorsByIdRequest, GetBookAuthorsByIdResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBookAuthorsByIdUseCase(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<GetBookAuthorsByIdResponse> Handle(GetBookAuthorsByIdRequest request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetByIdAsNoTracking(request.Id, cancellationToken);

            if (book == null)
            {
                throw new NotFoundException("Nenhum resutado para o ID enviado.");
            }

            return _mapper.Map<GetBookAuthorsByIdResponse>(book);
        }
    }
}
