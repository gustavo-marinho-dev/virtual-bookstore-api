using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using VirtualBookstore.Application.DTOs.Author;
using VirtualBookstore.Application.DTOs.ViaCepApi;
using VirtualBookstore.Application.Exceptions;
using VirtualBookstore.Application.Repositories;
using VirtualBookstore.Domain.DTOs.Adress;
using VirtualBookstore.Domain.Entities;
using VirtualBookstore.Infrastructure.ExternalServices.Services;

namespace VirtualBookstore.Application.UseCases.AddressUseCase
{
    public sealed class GetAddressByCepUseCase : IRequestHandler<GetAdressByCepRequest, GetAdressByCepResponse>
    {
        private readonly IMapper _mapper;
        private readonly IViaCEPExternalService _viaCepService;

        public GetAddressByCepUseCase(IMapper mapper, IViaCEPExternalService viaCepService)
        {
            _mapper = mapper;
            _viaCepService = viaCepService;
        }

        public async Task<GetAdressByCepResponse> Handle(GetAdressByCepRequest request, CancellationToken cancellationToken)
        {
            var response = await _viaCepService.BuscaCep(request.Cep);

            if (response.Erro)
            {
                throw new NotFoundException("Não foi encontrado um endereço com base no CEP fornecido");
            }

            var address = _mapper.Map<GetAdressByCepResponse>(response);

            return address;
        }
    }
}
