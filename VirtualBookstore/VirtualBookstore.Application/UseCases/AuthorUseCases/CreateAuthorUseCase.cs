using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Author;
using VirtualBookstore.Application.Repositories;
using VirtualBookstore.Domain.Entities;

namespace VirtualBookstore.Application.UseCases.AuthorUseCases
{
    public sealed class CreateAuthorUseCase : IRequestHandler<CreateAuthorRequest, AuthorResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public CreateAuthorUseCase(IUnitOfWork unitOfWork, IAuthorRepository authorRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<AuthorResponse> Handle(CreateAuthorRequest request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Author>(request);
            _authorRepository.Create(book);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<AuthorResponse>(book);
        }
    }
}
