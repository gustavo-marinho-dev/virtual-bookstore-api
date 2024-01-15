using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VirtualBookstore.Domain.DTOs.Adress;

namespace VirtualBookstore.Application.Validators.Address
{
    public class GetAdressByCepRequestValidator : AbstractValidator<GetAdressByCepRequest>
    {
        public GetAdressByCepRequestValidator()
        {
            RuleFor(request => request.Cep)
                .Must(BeValidCepFormat).WithMessage("Formato inválido, o CEP deve ter 8 dígitos numéricos.");
        }

        private bool BeValidCepFormat(string cep)
        {
            return !string.IsNullOrEmpty(cep) && Regex.IsMatch(cep, @"^\d{8}$");
        }
    }
}
