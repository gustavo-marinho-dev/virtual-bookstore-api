using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Book;

namespace VirtualBookstore.Application.Validators.Book
{
    public class CreateBookRequestValidator : AbstractValidator<CreateBookRequest>
    {
        public CreateBookRequestValidator()
        {
            RuleFor(request => request.Title)
                .NotEmpty()
                .MaximumLength(255);
            RuleFor(request => request.PublicationYear)
                .NotEmpty()
                .Must(year => year.Year <= DateTime.Now.Year)
                .WithMessage("O ano de publicação não pode ser no futuro."); 
            RuleFor(request => request.Publisher)
                .NotEmpty()
                .MaximumLength(255);
            RuleFor(request => request.Subject)
                .NotNull();
            RuleFor(request => request.Categorie)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(request => request.Thumbnail)
                .NotEmpty()
                .MaximumLength(255);
            RuleFor(request => request.Synopsis)
                .NotEmpty();
            RuleFor(request => request.Rating)
                .InclusiveBetween(0, 5);
            RuleFor(request => request.Price)
                .GreaterThan(0);
            RuleFor(request => request.Language)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(request => request.ISBN)
                .NotEmpty()
                .MaximumLength(20);
            RuleFor(request => request.Pages)
                .GreaterThan(0);
            RuleFor(request => request.Backing)
                .IsInEnum();
            RuleFor(request => request.Dimensions)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(request => request.Authors)
                .NotEmpty()
                .WithMessage("Pelo menos um autor deve ser especificado.");
        }
    }
}
