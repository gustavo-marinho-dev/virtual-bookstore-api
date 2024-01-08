using FluentValidation;
using System;
using VirtualBookstore.Application.DTOs.Author;

namespace VirtualBookstore.Application.Validators.Author
{
    public class CreateAuthorRequestValidator : AbstractValidator<CreateAuthorRequest>
    {
        public CreateAuthorRequestValidator()
        {
            RuleFor(request => request.FullName)
                .NotEmpty()
                .MaximumLength(255);

            RuleFor(request => request.DateOfBirth)
                .NotEmpty()
                .Must(dateOfBirth => dateOfBirth.Year <= DateTime.Now.Year)
                .WithMessage("A data de nascimento não pode ser no futuro.");

            RuleFor(request => request.Nationality)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(request => request.Biography)
                .NotEmpty()
                .MaximumLength(1000);
        }
    }
}
