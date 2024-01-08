using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Book;

namespace VirtualBookstore.Application.Validators.Book
{
    public sealed class DeleteBookRequestValidator : AbstractValidator<DeleteBookRequest>
    {
        public DeleteBookRequestValidator()
        {
            RuleFor(request => request.Id)
               .NotEmpty().WithMessage("O ID do livro é obrigatório.")
               .NotEqual(Guid.Empty).WithMessage("O ID do livro não pode ser vazio.");
        }
    }
}
