using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Author;
using VirtualBookstore.Application.Exceptions;
using VirtualBookstore.Application.Repositories;

namespace VirtualBookstore.Application.UseCases.AuthorUseCases
{
    public sealed class DeleteAuthorUseCase : IRequestHandler<DeleteAuthorRequest>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteAuthorUseCase(IAuthorRepository authorRepository, IUnitOfWork unitOfWork)
        {
            _authorRepository = authorRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(DeleteAuthorRequest request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.Get(request.Id, cancellationToken);

            if (author != null)
            {
                _authorRepository.Delete(author);
                await _unitOfWork.Save(cancellationToken);
            }

            else
                throw new NotFoundException($"Não foi encontrado o autor requisitado.");
        }
    }
}
